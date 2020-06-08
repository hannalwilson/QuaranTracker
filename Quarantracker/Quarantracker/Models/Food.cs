using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quarantracker.Models
{
    public enum Course
    {
        Appetizer, Entree, Side, Dessert, Snack, Beverage
    }
    public class Food
    {
        public int FoodId { get; set; }
        public string Dish { get; set; }
        public Course Course { get; set; }
        public bool MakeAgain { get; set; }

    }
}