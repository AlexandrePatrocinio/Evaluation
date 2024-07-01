using System;
using System.Collections.Generic;
namespace app.Models;

public class Question : Entite {
    
    public Question()
    {
        initId();
    }
    public Question(string Libelle, int BonneReponse)
    {
        initId();
        this.Libelle = Libelle;
        this.BonneReponse = BonneReponse;
    }

    public Question(Guid guid, string Libelle, int BonneReponse)
    {
        initId();
        this.Id = guid;
        this.Libelle = Libelle;
        this.BonneReponse = BonneReponse;
    }

    public string Libelle { get; set; }
    public int BonneReponse { get; set; }
    public int Ordre {get; set;}
    public IEnumerable<string> Reponses { get; set; }
}