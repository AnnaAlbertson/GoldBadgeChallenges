using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Cafe_Repository
{
    public class CafeMenu
    {
        //Required menu items: meal number, meal name, description, list of ingredients, price
        //Properties: meal number, meal name, description, price
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<string> Ingredients { get; set; }

        //Empty constructor
        public CafeMenu()
        {

        }

        //Overloaded constructor
        public CafeMenu(int mealNumber, string mealName, string description, decimal price, List<string> ingredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            Ingredients = ingredients;
        }
    }
}
