using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programa_Dieta.Constantes;
using Programa_Dieta.Entidades;

namespace Programa_Dieta
{
    public partial class SeleccionMenuMartes : Form
    {
        public static Meal desayunoMartes;
        public static Meal comidaMartes;
        public static Meal cenaMartes;
        public SeleccionMenuMartes()
        {
            InitializeComponent();
        }
        public void nextButtonMartes_Click(object sender, EventArgs e)
        {
            //desayunos
            if (huevoChorizoButton.Checked == true)
            {
                Meal huevosConChorizo = FoodProvider.GetHuevosConChorizo();
                desayunoMartes = huevosConChorizo;
            }
            else if (huevoJamonButton.Checked == true)
            {
                Meal huevosConJamon = FoodProvider.GetHuevosConJamon();
                desayunoMartes = huevosConJamon;
                //huevosConJamon.MealIngredients.ForEach(i => desayunoMensaje += i.IngredientName.ToString());
            }
            else if (colacheButton.Checked == true)
            {
                Meal colache = FoodProvider.GetColache();
                desayunoMartes = colache;
            }
            else if (chilaquilesButton.Checked == true)
            {
                Meal chilaquiles = FoodProvider.GetChilaquiles();
                desayunoMartes = chilaquiles;
            }
            else
            {
                Meal omelette = FoodProvider.GetOmelette();
                desayunoMartes = omelette;
            }
            //comidas
            if (vampiroButton.Checked == true)
            {
                Meal tacosVampiro = FoodProvider.GetTacosVampiros();
                comidaMartes = tacosVampiro;
            }
            else if (atunButton.Checked == true)
            {
                Meal atun = FoodProvider.GetEnsaladaAtun();
                comidaMartes = atun;
            }
            else if (tingaButton.Checked == true)
            {
                Meal tinga = FoodProvider.GetTostadasTinga();
                comidaMartes = tinga;
            }
            else if (polloVerdurasButton.Checked == true)
            {
                Meal polloVerduras = FoodProvider.GetpolloConVerduras();
                comidaMartes = polloVerduras;
            }
            else
            {
                Meal enchiladas = FoodProvider.GetEnchiladasVerdes();
                comidaMartes = enchiladas;
            }
            //cenas
            if (toastbutton.Checked == true)
            {
                Meal toast = FoodProvider.GetToast();
                cenaMartes = toast;
            }
            else if (huevoEstrelladoButton.Checked == true)
            {
                Meal huevoEstrellado = FoodProvider.GetHuevoEstrellado();
                cenaMartes = huevoEstrellado;
            }
            else if (sandwichButton.Checked == true)
            {
                Meal sandwich = FoodProvider.GetSandwich();
                cenaMartes = sandwich;
            }
            else if (cerealButton.Checked == true)
            {
                Meal cereal = FoodProvider.GetCerealconLeche();
                cenaMartes = cereal;
            }
            else
            {
                Meal huevoRevuelto = FoodProvider.GetHuevosConJamon();
                cenaMartes = huevoRevuelto;
            }
            this.Hide();
            SeleccionMenuMiercoles seleccionMenuMiercoles = new SeleccionMenuMiercoles();
            seleccionMenuMiercoles.ShowDialog();
            //ResumenPlan resumenPlan = new ResumenPlan();
            //resumenPlan.ShowDialog();
        }
        public static Meal GetDesayunoMartes()
        {
            return desayunoMartes;
        }
        public static Meal GetComidaMartes()
        {
            return comidaMartes;
        }
        public static Meal GetCenaMartes()
        {
            return cenaMartes;
        }
    }
}