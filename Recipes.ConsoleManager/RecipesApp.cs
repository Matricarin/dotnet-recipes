using Recipes.ConsoleManager.Models;

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
        throw new NotImplementedException();
    }

    public IEnumerable<Segment> Render(RenderOptions options, int maxWidth)
    {
        throw new NotImplementedException();
    }
}