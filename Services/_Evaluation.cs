using System.Collections.Generic;
using app.Interfaces;
using app.Models;

namespace app.Services;

public partial class Evaluation : IEvaluation {

    public static IEnumerable<Question> GenererQuestions()
    {
        var Questions = new List<Question>()
        {
            new Question("C'est quoi un framework ?", 2)
            {
                Reponses = new List<string>()
                {
                    "Une biblioteca de fonctions qui serve à créer des interfaces utilisateur.",
                    "Un ensemble de biblioteques de types (classes, structures) avec une organisation precise qui permettent aux developpeurs de créer un logiciel pour un domaine specifique sans besoin de repartir de zéro.",
                    "Un outil générique qui serve à plusieurs buts différentes."
                }            
            },
            new Question("Quel est la différence entre .NET Framework et .NET Core renommé .NET tout court ?", 1)
            {
                Reponses = new List<string>()
                {
                    ".Net Framework c'est la version d'origine de la plataforme de développement Microsoft et elle ne fonctionne que sur Windows et .Net core c'est la version open source et multi-plataforme de développement Microsoft.",
                    ".Net Framework c'est l'ensemble de classes génériques de la plataforme Microsoft et .NET Core sont les classes principaux.",
                    "Il n'y a pas de différence. C'est juste qu'il a changé de nom après la version 4.8 de .Net Framework vers .Net core à cause d'une stratégie de marketing."
                }
            },
            new Question("Le runtime .Net a les composant suivants : ", 3)
            {
                Reponses = new List<string>()
                {
                    "BCL, IL, GC",
                    "CLR, JIT, BCL",
                    "BCL, JIT, GC"
                }
            },
            new Question("Quand la première version du .Net FrameWork a été publiée ?", 3)
            {
                Reponses = new List<string>()
                {
                    "2000",
                    "2004",
                    "2002"
                }
            },
            new Question("Quels sont les trois pricipaux langage de développement Microsoft sur .NET ?", 3)
            {
                Reponses = new List<string>()
                {
                    "C++, COBOL, C#",
                    "C#, VB.Net, J#",
                    "C#, VB.Net, F#"
                }
            },
            new Question("Quel est le composant du CLR .Net responsable par la sécurité et gestion de la mémoire ?", 2)
            {
                Reponses = new List<string>()
                {
                    "BCL",
                    "GC",
                    "JIT"
                }
            },
            new Question("Comment le .NET gère la mémoire ?", 1)
            {
                Reponses = new List<string>()
                {
                    "Les types qui heritent de System.ValueTypes sont stockés au niveau de la pile et les types qui heritent de System.Object au niveu du tas",
                    "Tous les objets sont stockés dans le tas et les structures sont stockées dans LOH",
                    "GC alloue toujours une grosse quantité de la mémoire pour le tas car la pile est trop petite pour le gros objets."
                }
            },
            new Question("C'est quoi un type référence ?", 3)
            {
                Reponses = new List<string>()
                {
                    "Un type de référence c'est un pointeur qui pointe directement vers l'adresse de mémoire où l'objet commence dans le tas.",
                    "Un type de référence est toujours enregistré dans la pile mais ces propriétés iront être enregistrées dans le tas.",
                    "Un type de référence garde dans la pile une adresse de mémoire qui pointe vers un pointeur dans la region du tas gerés par le GC."
                }
            },
            new Question("C'est quoi un IL", 3)
            {
                Reponses = new List<string>()
                {
                    "C'est un code binaire qui cible un processeur virtuel et est compilé en binaire native de la plataforme par le JIT.",
                    "C'est une langage intermediaire entre le VB.Net et le C#.",
                    "C'est un code de bas niveau qui est exécuté directement pour le processeur d'ordinateur."                    
                }
            },
            new Question("A quel moment les objets sont stockés sur le LOH ?", 3)
            {
                Reponses = new List<string>()
                {
                    "Quand le GC ne trouve plus d'espace sur le tas.",
                    "Quand les gros objets (> 95Ko) n'ont plus d'espace sur la pile.",
                    "Quand les gros types de référence (>85Ko) sont instancie en mémoire."
                }
            }
        };

        return Questions;
    }
}