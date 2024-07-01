using System;
namespace app.Services;

public struct Menu
{
    private string[] _options;
    public string Title { get; set; }
    public string[] MenuPrincipal { get; set; }

    public Menu AfficherOptions(string[] options = null, bool netoyerecran = true) {
        if(netoyerecran) Console.Clear();
        Console.WriteLine(Title);

        _options = (options ?? MenuPrincipal);

        for (var index = 0; index < _options.Length; index++)
        {            
            Console.WriteLine();
            Console.WriteLine($"{index+1}) - {_options[index]}");
            Console.WriteLine();
        }

        return this;
    }

    public int LireOption(string message) {
        var option = -1;
        Console.Write(message);

        while (option < 1 || option > _options.Length) {
            Console.SetCursorPosition(message.Length, Console.CursorTop);            
            var reponse = Console.ReadLine();
            int.TryParse(reponse, out option);
            Console.SetCursorPosition(30, Console.CursorTop - 1);
            Console.Write("".PadRight(reponse.Length));            
        }

        return option;
    }

    public string LireReponse(string message, bool confirmation = true) {
        var reponse = String.Empty;
        var confirme = confirmation ? string.Empty : "Oui";
        Console.WriteLine();

        do {
            Console.WriteLine(message);
            reponse = Console.ReadLine();
            if (confirmation){
                Console.WriteLine("Confirmez-vous (oui ou non) ?");
                confirme = Console.ReadLine();
            }
        } while (confirme.ToUpper() != "OUI");

        return reponse;
    }

}