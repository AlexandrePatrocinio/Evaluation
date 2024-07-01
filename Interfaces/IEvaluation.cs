using System.Collections.Generic;
using app.Models;
namespace app.Interfaces;

public interface IEvaluation
{
    string Nom { get; set; }
    void Evaluer();
    IEnumerable<Question> TirageAuSort();
}