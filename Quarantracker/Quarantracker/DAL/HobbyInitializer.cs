using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Quarantracker.Models;

namespace Quarantracker.DAL
{
    public class HobbyInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HobbyContext>
    {
        protected override void Seed(HobbyContext context)
        {
            var books = new List<Book>
            {
                new Book{Title = "Love Warrior", Author = "Glennon Doyle", Genre = "Memoir", Type = BookType.Paperback}
            };

            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();

            var shows = new List<Show>
            {
                new Show{Title = "Tiger King", Genre = "Documentary", Type=ShowType.Series, Service=Service.Netflix}
            };

            shows.ForEach(s => context.Shows.Add(s));
            context.SaveChanges();

            var foods = new List<Food>
            {
                new Food{Dish = "Lemon Garlic Shrimp", Course=Course.Entree, MakeAgain = true}
            };

            foods.ForEach(f => context.Foods.Add(f));
            context.SaveChanges();
        }
    }
}