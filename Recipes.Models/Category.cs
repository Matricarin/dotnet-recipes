using System;

namespace Recipes.Models
{
    public sealed class Category
    {
        public Guid Id {get;}
        public string Title {get;}

        public Category(Guid id, string title)
        {
            if(id.Equals(Guid.Empty))
            {
                throw new ArgumentException("Invalid Id");
            }

            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException(nameof(title));
            }

            Id = id;
            Title = title;
        }   
    }
}