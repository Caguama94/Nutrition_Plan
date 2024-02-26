using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Dieta.Entidades
{
    public class MealPlan
    {
        public List<Meal> MealList { get; set; }
        public bool IsConfirmed { get; set; }
        public MealPlan(List<Meal> mealList, bool isConfirmed=false)
        {
            MealList = mealList;
            IsConfirmed = isConfirmed;
        }

        public static bool ConfirmPlan()
        {          
            return true;
        }
    }
}
