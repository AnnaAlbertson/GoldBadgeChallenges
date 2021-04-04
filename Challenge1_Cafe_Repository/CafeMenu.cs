using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1_Cafe_Repository
{
    //Enum for the ingredients, because most restaurants have ingredients they reuse over and over in other dishes
    //Stretch goal:Add method to add to enum while console app is running
    //public enum CafeIngredients - didn't qutie work the way I wanted it to
    //{
    //    Eggs,
    //    Spinach,
    //    Feta,
    //    SignatureSpices,
    //    Hollandaise,
    //    EnglishMuffin,
    //    CrabCakes,
    //    Bacon,
    //    Blueberries,
    //    MuffinMix
    //}

    //private List<CafeIngredients> MealIngredients = new List<CafeIngredients>();

    public class CafeMenu
    {
        //Required menu items: meal number, meal name, description, list of ingredients, price
        //Properties: meal number, meal name, description, price
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        //Got the idea to make a List<enum> as a property when I talked to Austin for a checkup
        public string MealIngredients { get; set; }

        //Empty constructor
        public CafeMenu()
        {

        }

        //Overloaded constructor
        public CafeMenu(int mealNumber, string mealName, string description, decimal price, string mealIngredients)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            Description = description;
            Price = price;
            MealIngredients = mealIngredients;
        }
    }
}
