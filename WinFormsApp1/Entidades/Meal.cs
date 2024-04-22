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
        public string MealType {  get; set; }
        public List<Ingredients> MealIngredients { get; set; }
        public Meal(string mealName, string mealType, List<Ingredients> mealIngredients)
        {
            MealName = mealName;
            MealType = mealType;
            MealIngredients = mealIngredients;
        }        
        public static bool AddToPlan() { return true; }
        public static bool RemoveFromPlan() { return false; }
    }
}
