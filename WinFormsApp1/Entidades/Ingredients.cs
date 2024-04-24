using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Dieta.Entidades
{
    public class Ingredients
    {
        public enum ingredientes
        {
            Huevo,
            Chorizo,
            Jamon,
            QuesoOaxaca,
            Tomate,
            Cebolla,
            Calabacita,
            Espinaca,
            Zanahoria,
            Lechuga,
            Tortilla,
            SalsaEnchiladas,
            Vampiros,
            Atun,
            Galletas,
            Mayonesa,
            Pollo,
            Tostadas,
            SalsaTinga,
            Brocoli,
            Chicharos,
            PimientoVerde,
            Arroz,
            Pan,
            QuesoPanela,
            Cereal,
            Leche,
            Manzana,
        }
        public ingredientes IngredientName { get; set; }
        public double Weight { get;set; }

        public Ingredients(ingredientes ingredientName,double weight)
        {         
            IngredientName = ingredientName;
            Weight = weight;
        }
    }
}
