using Recipes.ConsoleManager.Models;

using Spectre.Console;
using Spectre.Console.Rendering;

namespace Recipes.ConsoleManager;

public sealed class RecipesApp : IRenderable
{
    public bool IsAppRunning { get; set; } = true;

    private readonly List<MenuItem> _items = new()
    {
        new MenuItem("Show categories list"), new MenuItem("Show recipes list"), new MenuItem("Exit")
    };

    public Measurement Measure(RenderOptions options, int maxWidth)
    {
        return new Measurement();
    }

    public IEnumerable<Segment> Render(RenderOptions options, int maxWidth)
    {
       var item = AnsiConsole.Prompt(new SelectionPrompt<MenuItem>().AddChoices(_items));

        yield return new Segment(item.ToString());
    }
}