using app.Services;

var menu = new Menu();

menu.Title = $"********************Questions********************";
menu.MenuPrincipal = ["Commencer", "Sortir"];

var option = -1;

do {
    menu.AfficherOptions();
    option = menu.LireOption("Veuillez choisir une option : ");

    if (option == 1) {
        var nom = menu.LireReponse("Veuillez entrer votre NOM prénom : ");
        var evaluation = new Evaluation(nom, Evaluation.GenererQuestions(), menu);
        evaluation.Evaluer();
        evaluation.Rapport();
    }

} while(option < menu.MenuPrincipal.Length);
