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
    public partial class SeleccionMenuLunes : Form
    {
        public static Meal desayunoLunes;
        public static Meal comidaLunes;
        public static Meal cenaLunes;
        public SeleccionMenuLunes()
        {
            InitializeComponent();
        }        
        public void nextButtonLunes_Click(object sender, EventArgs e)
        {
            //desayunos
            if (huevoChorizoButton.Checked == true)
            {
                Meal huevosConChorizo = FoodProvider.GetHuevosConChorizo();
                desayunoLunes = huevosConChorizo;
            }
            else if (huevoJamonButton.Checked == true)
            {
                Meal huevosConJamon = FoodProvider.GetHuevosConJamon();
                desayunoLunes = huevosConJamon;
                //huevosConJamon.MealIngredients.ForEach(i => desayunoMensaje += i.IngredientName.ToString());
            }
            else if (colacheButton.Checked == true)
            {
                Meal colache = FoodProvider.GetColache();
                desayunoLunes = colache;
            }
            else if (chilaquilesButton.Checked == true)
            {
                Meal chilaquiles = FoodProvider.GetChilaquiles();
                desayunoLunes = chilaquiles;
            }
            else
            {
                Meal omelette = FoodProvider.GetOmelette();
                desayunoLunes = omelette;
            }
            //comidas
            if (vampiroButton.Checked == true)
            {
                Meal tacosVampiro = FoodProvider.GetTacosVampiros();
                comidaLunes = tacosVampiro;
            }
            else if (atunButton.Checked == true)
            {
                Meal atun = FoodProvider.GetEnsaladaAtun();
                comidaLunes = atun;
            }
            else if (tingaButton.Checked == true)
            {
                Meal tinga = FoodProvider.GetTostadasTinga();
                comidaLunes = tinga;
            }
            else if (polloVerdurasButton.Checked == true)
            {
                Meal polloVerduras = FoodProvider.GetpolloConVerduras();
                comidaLunes = polloVerduras;
            }
            else
            {
                Meal enchiladas = FoodProvider.GetEnchiladasVerdes();
                comidaLunes = enchiladas;
            }
            //cenas
            if (toastbutton.Checked == true)
            {
                Meal toast = FoodProvider.GetToast();
                cenaLunes = toast;
            }
            else if (huevoEstrelladoButton.Checked == true)
            {
                Meal huevoEstrellado = FoodProvider.GetHuevoEstrellado();
                cenaLunes = huevoEstrellado;
            }
            else if (sandwichButton.Checked == true)
            {
                Meal sandwich = FoodProvider.GetSandwich();
                cenaLunes = sandwich;
            }
            else if (cerealButton.Checked == true)
            {
                Meal cereal = FoodProvider.GetCerealconLeche();
                cenaLunes = cereal;
            }
            else
            {
                Meal huevoRevuelto = FoodProvider.GetHuevosConJamon();
                cenaLunes = huevoRevuelto;
            }
            this.Hide();
            SeleccionMenuMartes seleccionMenuMartes = new SeleccionMenuMartes();
            seleccionMenuMartes.ShowDialog();
            //ResumenPlan resumenPlan = new ResumenPlan();
            //resumenPlan.ShowDialog();
        }
        public static Meal GetDesayunoLunes()
        {
            return desayunoLunes;
        }
        public static Meal GetComidaLunes()
        {
            return comidaLunes;
        }
        public static Meal GetCenaLunes()
        {
            return cenaLunes;
        }       
    }
}