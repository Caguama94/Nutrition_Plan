using Programa_Dieta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa_Dieta
{
    public partial class ResumenPlan : Form
    {
        public ResumenPlan()
        {
            InitializeComponent();
            desayunoLunesMealNameLabel.Text = SeleccionMenuLunes.GetDesayunoLunes().MealName.ToString();
            comidaLunesMealNameLabel.Text = SeleccionMenuLunes.GetComidaLunes().MealName.ToString();
            cenaLunesMealNameLabel.Text = SeleccionMenuLunes.GetCenaLunes().MealName.ToString();

            desayunoMartesMealNameLabel.Text = SeleccionMenuMartes.GetDesayunoMartes().MealName.ToString();
            comidaMartesMealNameLabel.Text = SeleccionMenuMartes.GetComidaMartes().MealName.ToString();
            cenaMartesMealNameLabel.Text = SeleccionMenuMartes.GetCenaMartes().MealName.ToString();

            desayunoMiercolesMealNameLabel.Text = SeleccionMenuMiercoles.GetDesayunoMiercoles().MealName.ToString();
            comidaMiercolesMealNameLabel.Text = SeleccionMenuMiercoles.GetComidaMiercoles().MealName.ToString();
            cenaMiercolesMealNameLabel.Text = SeleccionMenuMiercoles.GetCenaMiercoles().MealName.ToString();

            desayunoJuevesMealNameLabel.Text = SeleccionMenuJueves.GetDesayunoJueves().MealName.ToString();
            comidaJuevesMealNameLabel.Text = SeleccionMenuJueves.GetComidaJueves().MealName.ToString();
            cenaJuevesMealNameLabel.Text = SeleccionMenuJueves.GetCenaJueves().MealName.ToString();

            desayunoViernesMealNameLabel.Text = SeleccionMenuViernes.GetDesayunoViernes().MealName.ToString();
            comidaViernesMealNameLabel.Text = SeleccionMenuViernes.GetComidaViernes().MealName.ToString();
            cenaViernesMealNameLabel.Text = SeleccionMenuViernes.GetCenaViernes().MealName.ToString();
        }
        private void ResumenConfirmarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDeCompra listaDeCompra = new ListaDeCompra();
            listaDeCompra.ShowDialog();
        }

        public static MealPlan GetMealsPlan()
        {
            List<Meal> mealsList = new List<Meal>
            {
                SeleccionMenuLunes.desayunoLunes,
                SeleccionMenuLunes.comidaLunes,
                SeleccionMenuLunes.cenaLunes,
                SeleccionMenuMartes.desayunoMartes,
                SeleccionMenuMartes.comidaMartes,
                SeleccionMenuMartes.cenaMartes,
                SeleccionMenuMiercoles.desayunoMiercoles,
                SeleccionMenuMiercoles.comidaMiercoles,
                SeleccionMenuMiercoles.cenaMiercoles,
                SeleccionMenuJueves.desayunoJueves,
                SeleccionMenuJueves.comidaJueves,
                SeleccionMenuJueves.cenaJueves,
                SeleccionMenuViernes.desayunoViernes,
                SeleccionMenuViernes.comidaViernes,
                SeleccionMenuViernes.cenaViernes,
            };
            MealPlan mealPlan = new MealPlan(mealsList);
            return mealPlan;
        }

        
    }
}