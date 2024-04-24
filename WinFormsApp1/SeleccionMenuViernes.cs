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
    public partial class SeleccionMenuViernes : Form
    {
        public static Meal desayunoViernes;
        public static Meal comidaViernes;
        public static Meal cenaViernes;
        public SeleccionMenuViernes()
        {
            InitializeComponent();
        }
        public void nextButtonViernes_Click(object sender, EventArgs e)
        {
            //desayunos
            if (huevoChorizoButton.Checked == true)
            {
                Meal huevosConChorizo = FoodProvider.GetHuevosConChorizo();
                desayunoViernes = huevosConChorizo;
            }
            else if (huevoJamonButton.Checked == true)
            {
                Meal huevosConJamon = FoodProvider.GetHuevosConJamon();
                desayunoViernes = huevosConJamon;
                //huevosConJamon.MealIngredients.ForEach(i => desayunoMensaje += i.IngredientName.ToString());
            }
            else if (colacheButton.Checked == true)
            {
                Meal colache = FoodProvider.GetColache();
                desayunoViernes = colache;
            }
            else if (chilaquilesButton.Checked == true)
            {
                Meal chilaquiles = FoodProvider.GetChilaquiles();
                desayunoViernes = chilaquiles;
            }
            else
            {
                Meal omelette = FoodProvider.GetOmelette();
                desayunoViernes = omelette;
            }
            //comidas
            if (vampiroButton.Checked == true)
            {
                Meal tacosVampiro = FoodProvider.GetTacosVampiros();
                comidaViernes = tacosVampiro;
            }
            else if (atunButton.Checked == true)
            {
                Meal atun = FoodProvider.GetEnsaladaAtun();
                comidaViernes = atun;
            }
            else if (tingaButton.Checked == true)
            {
                Meal tinga = FoodProvider.GetTostadasTinga();
                comidaViernes = tinga;
            }
            else if (polloVerdurasButton.Checked == true)
            {
                Meal polloVerduras = FoodProvider.GetpolloConVerduras();
                comidaViernes = polloVerduras;
            }
            else
            {
                Meal enchiladas = FoodProvider.GetEnchiladasVerdes();
                comidaViernes = enchiladas;
            }
            //cenas
            if (toastbutton.Checked == true)
            {
                Meal toast = FoodProvider.GetToast();
                cenaViernes = toast;
            }
            else if (huevoEstrelladoButton.Checked == true)
            {
                Meal huevoEstrellado = FoodProvider.GetHuevoEstrellado();
                cenaViernes = huevoEstrellado;
            }
            else if (sandwichButton.Checked == true)
            {
                Meal sandwich = FoodProvider.GetSandwich();
                cenaViernes = sandwich;
            }
            else if (cerealButton.Checked == true)
            {
                Meal cereal = FoodProvider.GetCerealconLeche();
                cenaViernes = cereal;
            }
            else
            {
                Meal huevoRevuelto = FoodProvider.GetHuevosConJamon();
                cenaViernes = huevoRevuelto;
            }
            this.Hide();
            //SeleccionMenuViernes seleccionMenuViernes = new SeleccionMenuViernes();
            //seleccionMenuViernes.ShowDialog();
            ResumenPlan resumenPlan = new ResumenPlan();
            resumenPlan.ShowDialog();
        }
        public static Meal GetDesayunoViernes()
        {
            return desayunoViernes;
        }
        public static Meal GetComidaViernes()
        {
            return comidaViernes;
        }
        public static Meal GetCenaViernes()
        {
            return cenaViernes;
        }
    }
}