using System;
namespace app.Models;

public class Reponse : Entite {
    
    public Reponse()
    {
        initId();
    }
    public Reponse(string Libelle)
    {
        initId();
        this.Libelle = Libelle;
    }

    public Reponse(Guid guid, string Libelle){
        this.Id = guid;
        this.Libelle = Libelle;
    }

    public string Libelle { get; set; }

}