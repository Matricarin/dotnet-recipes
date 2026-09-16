using System;

namespace Recipes.Models
{
    public sealed class Ingredient
    {
        public string Title { get; }
        public int Value {get;}
        public string Unit{get;}

        public Ingredient(string title, int value, string unit)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            if(value <= 0)
            {
                throw new ArgumentException("Not accessible negative value");
            }

            if(string.IsNullOrWhiteSpace(nameof(unit)))
            {
                throw new ArgumentNullException(nameof(unit));
            }

            Title = title;
            Value = value;
            Unit = unit;
        }
    }
}