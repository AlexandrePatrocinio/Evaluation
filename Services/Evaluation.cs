using System;
using System.Collections.Generic;
using System.Linq;
using app.Interfaces;
using app.Models;

namespace app.Services;

public partial class Evaluation : IEvaluation {

    private class ReponseQuestion {
        public Question Question { get; set; }
        public int Reponse { get; set; }
    }    

    private Menu _menu;
    private IEnumerable<Question> _questions;

    private bool _trier;

    private Dictionary<string, List<ReponseQuestion>> _evaluations;

    public string Nom { get; set; }

    public Evaluation(string nom, IEnumerable<Question> questions, Menu menu)
    {
        Nom = nom ?? throw new NullReferenceException(nameof(nom));
        _menu = menu;
        _questions = questions ?? throw new NullReferenceException(nameof(questions));
        _evaluations = new Dictionary<string, List<ReponseQuestion>>();
        _trier = true;
    }

    public void Evaluer() {

        _menu.LireReponse($"Bienvenue {Nom}", false);

        foreach (var q in TirageAuSort()) {
            _menu.Title = q.Libelle;

            var option = _menu.AfficherOptions(q.Reponses.ToArray())
                .LireOption("Repondez une seul option : ");

            if(_evaluations.Keys.Count == 0 || !_evaluations.Keys.Contains(Nom))
                _evaluations.Add(Nom, new List<ReponseQuestion>());

            _evaluations[Nom].Add(new ReponseQuestion {
                Question = q,
                Reponse = option
            });
        }
    }

    public IEnumerable<Question> TirageAuSort() {
        if (_trier) {
            var Rand = new Random(100);
            foreach(var q in _questions) q.Ordre = Rand.Next(100);
            _questions = _questions.OrderBy((q)=> q.Ordre);
            _trier = false;
        }

        foreach (var q in _questions)
        {
            yield return q;
        }
    }

    public void Rapport() {        
        foreach(var nom in _evaluations.Keys) {
            _menu.LireReponse($"Resultat de l'évaluation de {nom}", false);
            var QteCorrects = 0.0;
            foreach(var result in _evaluations[nom]) {
                _menu.Title = result.Question.Libelle;

                _menu.AfficherOptions([
                    $"Votre reponse : {result.Question.Reponses.ToArray()[result.Reponse - 1]}",
                    $"Reponse correcte: {result.Question.Reponses.ToArray()[result.Question.BonneReponse - 1]}"
                ], false);

                QteCorrects += result.Reponse == result.Question.BonneReponse ? 1 : 0;
            }

            var pourcentage = (QteCorrects / _evaluations[nom].Count);

            _menu.LireReponse($"Votre note {QteCorrects}/{_evaluations[nom].Count} : {pourcentage * 100} %.\n Touchez entrer pour revenir au menu principal", false);
        }
    }
}