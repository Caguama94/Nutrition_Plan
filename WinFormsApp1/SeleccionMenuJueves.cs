using Programa_Dieta.Constantes;
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
    public partial class SeleccionMenuJueves : Form
    {
        public static Meal desayunoJueves;
        public static Meal comidaJueves;
        public static Meal cenaJueves;
        public SeleccionMenuJueves()
        {
            InitializeComponent();
        }
        public void nextButtonJueves_Click(object sender, EventArgs e)
        {
            //desayunos
            if (huevoChorizoButton.Checked == true)
            {
                Meal huevosConChorizo = FoodProvider.GetHuevosConChorizo();
                desayunoJueves = huevosConChorizo;
            }
            else if (huevoJamonButton.Checked == true)
            {
                Meal huevosConJamon = FoodProvider.GetHuevosConJamon();
                desayunoJueves = huevosConJamon;
                //huevosConJamon.MealIngredients.ForEach(i => desayunoMensaje += i.IngredientName.ToString());
            }
            else if (colacheButton.Checked == true)
            {
                Meal colache = FoodProvider.GetColache();
                desayunoJueves = colache;
            }
            else if (chilaquilesButton.Checked == true)
            {
                Meal chilaquiles = FoodProvider.GetChilaquiles();
                desayunoJueves = chilaquiles;
            }
            else
            {
                Meal omelette = FoodProvider.GetOmelette();
                desayunoJueves = omelette;
            }
            //comidas
            if (vampiroButton.Checked == true)
            {
                Meal tacosVampiro = FoodProvider.GetTacosVampiros();
                comidaJueves = tacosVampiro;
            }
            else if (atunButton.Checked == true)
            {
                Meal atun = FoodProvider.GetEnsaladaAtun();
                comidaJueves = atun;
            }
            else if (tingaButton.Checked == true)
            {
                Meal tinga = FoodProvider.GetTostadasTinga();
                comidaJueves = tinga;
            }
            else if (polloVerdurasButton.Checked == true)
            {
                Meal polloVerduras = FoodProvider.GetpolloConVerduras();
                comidaJueves = polloVerduras;
            }
            else
            {
                Meal enchiladas = FoodProvider.GetEnchiladasVerdes();
                comidaJueves = enchiladas;
            }
            //cenas
            if (toastbutton.Checked == true)
            {
                Meal toast = FoodProvider.GetToast();
                cenaJueves = toast;
            }
            else if (huevoEstrelladoButton.Checked == true)
            {
                Meal huevoEstrellado = FoodProvider.GetHuevoEstrellado();
                cenaJueves = huevoEstrellado;
            }
            else if (sandwichButton.Checked == true)
            {
                Meal sandwich = FoodProvider.GetSandwich();
                cenaJueves = sandwich;
            }
            else if (cerealButton.Checked == true)
            {
                Meal cereal = FoodProvider.GetCerealconLeche();
                cenaJueves = cereal;
            }
            else
            {
                Meal huevoRevuelto = FoodProvider.GetHuevosConJamon();
                cenaJueves = huevoRevuelto;
            }
            this.Hide();
            SeleccionMenuViernes seleccionMenuViernes = new SeleccionMenuViernes();
            seleccionMenuViernes.ShowDialog();
            //ResumenPlan resumenPlan = new ResumenPlan();
            //resumenPlan.ShowDialog();
        }
        public static Meal GetDesayunoJueves()
        {
            return desayunoJueves;
        }
        public static Meal GetComidaJueves()
        {
            return comidaJueves;
        }
        public static Meal GetCenaJueves()
        {
            return cenaJueves;
        }
    }
}