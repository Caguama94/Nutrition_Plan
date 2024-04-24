using Programa_Dieta.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Dieta.Constantes
{
    public class FoodProvider
    {
        public static Ingredients huevo = new Ingredients(Ingredients.ingredientes.Huevo, 4);
        public static Ingredients chorizo = new Ingredients(Ingredients.ingredientes.Chorizo, 100);
        public static Ingredients jamon = new Ingredients(Ingredients.ingredientes.Jamon, 120);
        public static Ingredients quesoOaxaca = new Ingredients(Ingredients.ingredientes.QuesoOaxaca, 100);
        public static Ingredients tomate = new Ingredients(Ingredients.ingredientes.Tomate, 130);
        public static Ingredients cebolla = new Ingredients(Ingredients.ingredientes.Cebolla, 130);
        public static Ingredients calabacita = new Ingredients(Ingredients.ingredientes.Calabacita, 250);
        public static Ingredients tortilla = new Ingredients(Ingredients.ingredientes.Tortilla, 100);
        public static Ingredients salsaEnchiladas = new Ingredients(Ingredients.ingredientes.SalsaEnchiladas, 1);
        public static Ingredients espinaca = new Ingredients(Ingredients.ingredientes.Espinaca, 60);
        public static Ingredients vampiro = new Ingredients(Ingredients.ingredientes.Vampiros, 350);
        public static Ingredients atun = new Ingredients(Ingredients.ingredientes.Atun, 1);
        public static Ingredients zanahoria = new Ingredients(Ingredients.ingredientes.Zanahoria, 200);
        public static Ingredients lechuga = new Ingredients(Ingredients.ingredientes.Lechuga, 50);
        public static Ingredients galletaSalada = new Ingredients(Ingredients.ingredientes.Galletas, 60);
        public static Ingredients mayonesa = new Ingredients(Ingredients.ingredientes.Mayonesa, 60);
        public static Ingredients pollo = new Ingredients(Ingredients.ingredientes.Pollo, 350);
        public static Ingredients tostada = new Ingredients(Ingredients.ingredientes.Tostadas, 60);
        public static Ingredients salsaTinga = new Ingredients(Ingredients.ingredientes.SalsaTinga, 1);
        public static Ingredients brocoli = new Ingredients(Ingredients.ingredientes.Brocoli, 100);
        public static Ingredients chicharos = new Ingredients(Ingredients.ingredientes.Chicharos, 50);
        public static Ingredients pimientoVerde = new Ingredients(Ingredients.ingredientes.PimientoVerde, 50);
        public static Ingredients arroz = new Ingredients(Ingredients.ingredientes.Arroz, 100);
        public static Ingredients pan = new Ingredients(Ingredients.ingredientes.Pan, 50);
        public static Ingredients quesoPanela = new Ingredients(Ingredients.ingredientes.QuesoPanela, 50);
        public static Ingredients cereal = new Ingredients(Ingredients.ingredientes.Cereal, 90);
        public static Ingredients leche = new Ingredients(Ingredients.ingredientes.Leche, 100);
        public static Ingredients manzana = new Ingredients(Ingredients.ingredientes.Manzana, 100);
        //Desayunos
        public static Meal GetHuevosConChorizo()
        {            
            List<Ingredients> listHuevoChorizo = new List<Ingredients>
            {
                huevo, chorizo
            };
            Meal huevosConChorizo = new Meal("Huevo con chorizo", "Desayuno", listHuevoChorizo);
            return huevosConChorizo;
        }
        public static Meal GetHuevosConJamon()
        {
            List<Ingredients> listHuevoJamon = new List<Ingredients>
            {
                huevo,jamon
            };
            Meal huevosConJamon = new Meal("Huevo con jamon", "Desayuno", listHuevoJamon);
            return huevosConJamon;
        }
        public static Meal GetColache()
        {
            List<Ingredients> listColache = new List<Ingredients>
            {
                quesoOaxaca, tomate, cebolla, calabacita
            };
            Meal colache = new Meal("Colache", "Desayuno", listColache);
            return colache;
        }
        public static Meal GetChilaquiles()
        {            
            List<Ingredients> listChilaquiles = new List<Ingredients>
            {
                tortilla,quesoOaxaca,salsaEnchiladas,
            };
            Meal chilaquiles = new Meal("Chilaquiles", "Desayuno", listChilaquiles);
            return chilaquiles;
        }
        public static Meal GetOmelette()
        {            
            List<Ingredients> listOmelette = new List<Ingredients>
            {
                huevo,tomate,cebolla,espinaca,quesoOaxaca
            };
            Meal omelette = new Meal("Omelette", "Desayuno", listOmelette);
            return omelette;
        }
        //Comidas
        public static Meal GetTacosVampiros()
        {            
            List<Ingredients> listTacosVampiros = new List<Ingredients>
            {
                tortilla, vampiro
            };
            Meal tacosVampiro = new Meal("Tacos de vampiro", "Comida", listTacosVampiros);
            return tacosVampiro;
        }
        public static Meal GetEnsaladaAtun()
        {           
            List<Ingredients> listAtun = new List<Ingredients>
            {
                atun, zanahoria, lechuga, galletaSalada, mayonesa
            };
            Meal ensaladaAtun = new Meal("Ensalada de atun", "Comida", listAtun);
            return ensaladaAtun;
        }

        public static Meal GetTostadasTinga()
        {            
            List<Ingredients> listTinga = new List<Ingredients>
            {
                pollo, tostada, cebolla, salsaTinga
            };
            Meal tostadasTinga = new Meal("Tostadas de tinga", "Comida", listTinga);
            return tostadasTinga;
        }
        public static Meal GetpolloConVerduras()
        {            
            List<Ingredients> listPolloVerduras = new List<Ingredients>
            {
                pollo, brocoli, zanahoria, chicharos, calabacita, pimientoVerde
            };
            Meal polloConVerduras = new Meal("Pollo con verduras", "Comida", listPolloVerduras);
            return polloConVerduras;
        }
        public static Meal GetEnchiladasVerdes()
        {                       
            List<Ingredients> listEnchiladasVerdes = new List<Ingredients>
            {
                pollo, tortilla,arroz,salsaEnchiladas
            };
            Meal enchiladasVerdes = new Meal("Enchiladas Verdes", "Comida", listEnchiladasVerdes);
            return enchiladasVerdes;
        }
        //Cenas
        public static Meal GetToast()
        {            
            List<Ingredients> listToast = new List<Ingredients>
            {
                pan, quesoPanela, tomate, jamon
            };
            Meal toast = new Meal("Toast", "Cena", listToast);
            return toast;
        }
        public static Meal GetHuevoEstrellado()
        {                        
            List<Ingredients> listHuevoEstrellado = new List<Ingredients>
            {
                huevo, tortilla
            };
            Meal huevoEstrellado = new Meal("Huevos estrellados", "Cena", listHuevoEstrellado);
            return huevoEstrellado;
        }
        public static Meal GetSandwich()
        {            
            List<Ingredients> listSandwich = new List<Ingredients>
            {
                pan, quesoPanela, tomate, jamon
            };
            Meal sandwich = new Meal("Sandwich", "Cena", listSandwich);
            return sandwich;
        }
        public static Meal GetCerealconLeche()
        {            
            List<Ingredients> listCereal = new List<Ingredients>
            {
                cereal, leche, manzana
            };
            Meal cerealConLeche = new Meal("Cereal con leche", "Cena", listCereal);
            return cerealConLeche;
        }
    }
}
