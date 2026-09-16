using Recipes.ConsoleManager;

using Spectre.Console;

var menu = new Menu();

while (menu.IsAppRunning)
{
    var panel = new Panel(menu)
        .Header("Fancy Recipes Catalog", Justify.Left)
        .RoundedBorder()
        .BorderColor(Color.CadetBlue)
        .Padding(2, 1)
        .Expand();

    AnsiConsole.Write(panel);
}

AnsiConsole.MarkupLine("[green] ... Goodbye! [/]");