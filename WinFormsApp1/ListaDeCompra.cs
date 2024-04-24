using Programa_Dieta.Constantes;
using Programa_Dieta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Dieta
{
    public partial class ListaDeCompra : Form
    {
        public ListaDeCompra()
        {
            InitializeComponent();
            MealPlan mealsPlan = ResumenPlan.GetMealsPlan();

            double totalHuevo = 0;
            double totalChorizo = 0;
            double totalJamon = 0;
            double totalQuesoOaxaca = 0;
            double totalTomate = 0;
            double totalCebolla = 0;
            double totalCalabacita = 0;
            double totalEspinaca = 0;
            double totalZanahoria = 0;
            double totalLechuga = 0;
            double totalTortilla = 0;
            double totalSalsaEnchiladas = 0;
            double totalVampiros = 0;
            double totalAtun = 0;
            double totalGalletasSaladas = 0;
            double totalMayonesa = 0;
            double totalPollo = 0;
            double totalTostadas = 0;
            double totalSalsaTinga = 0;
            double totalBrocoli = 0;
            double totalChicharos = 0;
            double totalPimientoVerde = 0;
            double totalArroz = 0;
            double totalPan = 0;
            double totalQuesoPanela = 0;
            double totalCereal = 0;
            double totalLeche = 0;
            double totalManzana = 0;

            for (int i = 0; i < mealsPlan.MealList.Count; i++)
            {
                for (int b = 0; b < mealsPlan.MealList[i].MealIngredients.Count; b++)
                    if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Huevo)
                    {
                        totalHuevo = totalHuevo + FoodProvider.huevo.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Chorizo)
                    {
                        totalChorizo = totalChorizo + FoodProvider.chorizo.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Jamon)
                    {
                        totalJamon = totalJamon + FoodProvider.jamon.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.QuesoOaxaca)
                    {
                        totalQuesoOaxaca = totalQuesoOaxaca + FoodProvider.quesoOaxaca.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Tomate)
                    {
                        totalTomate = totalTomate + FoodProvider.tomate.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Cebolla)
                    {
                        totalCebolla = totalCebolla + FoodProvider.cebolla.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Calabacita)
                    {
                        totalCalabacita = totalCalabacita + FoodProvider.calabacita.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Espinaca)
                    {
                        totalEspinaca = totalEspinaca + FoodProvider.espinaca.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Zanahoria)
                    {
                        totalZanahoria = totalZanahoria + FoodProvider.zanahoria.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Lechuga)
                    {
                        totalLechuga = totalLechuga + FoodProvider.lechuga.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Tortilla)
                    {
                        totalTortilla = totalTortilla + FoodProvider.tortilla.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.SalsaEnchiladas)
                    {
                        totalSalsaEnchiladas = totalSalsaEnchiladas + FoodProvider.salsaEnchiladas.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Vampiros)
                    {
                        totalVampiros = totalVampiros + FoodProvider.vampiro.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Atun)
                    {
                        totalAtun = totalAtun + FoodProvider.atun.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Galletas)
                    {
                        totalGalletasSaladas = totalGalletasSaladas + FoodProvider.galletaSalada.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Mayonesa)
                    {
                        totalMayonesa = totalMayonesa + FoodProvider.mayonesa.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Pollo)
                    {
                        totalPollo = totalPollo + FoodProvider.pollo.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Tostadas)
                    {
                        totalTostadas = totalTostadas + FoodProvider.tostada.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.SalsaTinga)
                    {
                        totalSalsaTinga = totalSalsaTinga + FoodProvider.salsaTinga.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Brocoli)
                    {
                        totalBrocoli = totalBrocoli + FoodProvider.brocoli.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Chicharos)
                    {
                        totalChicharos = totalChicharos + FoodProvider.chicharos.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.PimientoVerde)
                    {
                        totalPimientoVerde = totalPimientoVerde + FoodProvider.pimientoVerde.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Arroz)
                    {
                        totalArroz = totalArroz + FoodProvider.arroz.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Pan)
                    {
                        totalPan = totalPan + FoodProvider.pan.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.QuesoPanela)
                    {
                        totalQuesoPanela = totalQuesoPanela + FoodProvider.quesoPanela.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Cereal)
                    {
                        totalCereal = totalCereal + FoodProvider.cereal.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Leche)
                    {
                        totalLeche = totalLeche + FoodProvider.leche.Weight;
                    }
                    else if (mealsPlan.MealList[i].MealIngredients[b].IngredientName == Ingredients.ingredientes.Manzana)
                    {
                        totalManzana = totalManzana + FoodProvider.manzana.Weight;
                    }
            }

            totalHuevoLabel.Text = $"{totalHuevo.ToString()} piezas";
            totalChorizoLabel.Text = $"{totalChorizo.ToString()} gramos ";
            totalJamonLabel.Text = $"{totalJamon.ToString()} gramos";
            totalQuesoOaxacaLabel.Text = $"{totalQuesoOaxaca.ToString()} gramos";
            totalTomateLabel.Text = $"{totalTomate.ToString()} gramos";
            totalCebollaLabel.Text = $"{totalCebolla.ToString()} gramos";
            totalCalabacitaLabel.Text = $"{totalCalabacita.ToString()} gramos";
            totalEspinacaLabel.Text = $"{totalEspinaca.ToString()} gramos";
            totalZanahoriaLabel.Text = $"{totalZanahoria.ToString()} gramos";
            totalLechugaLabel.Text = $"{totalLechuga.ToString()} gramos";
            totalTortillaLabel.Text = $"{totalTortilla.ToString()} gramos";
            totalSalsaEnchiladasLabel.Text = $"{totalSalsaEnchiladas.ToString()} latas";
            totalVampirosLabel.Text = $"{totalVampiros.ToString()} gramos";
            totalAtunLabel.Text = $"{totalAtun.ToString()} latas";
            totalGalletasSaladasLabel.Text = $"{totalGalletasSaladas.ToString()} gramos";
            totalMayonesaLabel.Text = $"{totalMayonesa.ToString()} gramos";
            totalPolloLabel.Text = $"{totalPollo.ToString()} gramos";
            totalTostadasLabel.Text = $"{totalTostadas.ToString()} gramos";
            totalSalsaTingaLabel.Text = $"{totalSalsaTinga.ToString()} gramos";
            totalBrocoliLabel.Text = $"{totalBrocoli.ToString()} gramos";
            totalChicharosLabel.Text = $"{totalChicharos.ToString()} gramos";
            totalPimientoVerdeLabel.Text = $"{totalPimientoVerde.ToString()} gramos";
            totalArrozLabel.Text = $"{totalArroz.ToString()} gramos";
            totalPanLabel.Text = $"{totalPan.ToString()} gramos";
            totalQuesoPanelaLabel.Text = $"{totalQuesoPanela.ToString()} gramos";
            totalCerealLabel.Text = $"{totalCereal.ToString()} gramos";
            totalLecheLabel.Text= $"{totalLeche.ToString()} gramos";
            totalManzanaLabel.Text = $"{totalManzana.ToString()} gramos";

        }
    }
}
