namespace Recipes.ConsoleManager.Models
{
    public sealed class MenuItem
    {
        public string Title { get; }

        public MenuItem(string title)
        {
            Title = title;
        }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is string s)
            {
                return Title.Equals(s);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Title.GetHashCode();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}