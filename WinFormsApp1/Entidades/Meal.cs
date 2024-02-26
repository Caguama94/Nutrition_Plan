using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Dieta.Entidades
{
    public class Meal
    {
        public string MealName { get; set; }
        public List<Ingredients> MealIngredients { get; set; }
        public bool AddMeal { get; set; }


        public Meal(string mealName, List<Ingredients> mealIngredients, bool addMeal=false)
        {
            MealName = mealName;
            MealIngredients = mealIngredients;
            AddMeal = addMeal;
        }


        public static bool AddToPlan() { return true; }
        public static bool RemoveFromPlan() { return false; }
    }
}
