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
    public partial class SeleccionMenuMiercoles : Form
    {
        public static Meal desayunoMiercoles;
        public static Meal comidaMiercoles;
        public static Meal cenaMiercoles;
        public SeleccionMenuMiercoles()
        {
            InitializeComponent();
        }
        public void nextButtonMiercoles_Click(object sender, EventArgs e)
        {
            //desayunos
            if (huevoChorizoButton.Checked == true)
            {
                Meal huevosConChorizo = FoodProvider.GetHuevosConChorizo();
                desayunoMiercoles = huevosConChorizo;
            }
            else if (huevoJamonButton.Checked == true)
            {
                Meal huevosConJamon = FoodProvider.GetHuevosConJamon();
                desayunoMiercoles = huevosConJamon;
                //huevosConJamon.MealIngredients.ForEach(i => desayunoMensaje += i.IngredientName.ToString());
            }
            else if (colacheButton.Checked == true)
            {
                Meal colache = FoodProvider.GetColache();
                desayunoMiercoles = colache;
            }
            else if (chilaquilesButton.Checked == true)
            {
                Meal chilaquiles = FoodProvider.GetChilaquiles();
                desayunoMiercoles = chilaquiles;
            }
            else
            {
                Meal omelette = FoodProvider.GetOmelette();
                desayunoMiercoles = omelette;
            }
            //comidas
            if (vampiroButton.Checked == true)
            {
                Meal tacosVampiro = FoodProvider.GetTacosVampiros();
                comidaMiercoles = tacosVampiro;
            }
            else if (atunButton.Checked == true)
            {
                Meal atun = FoodProvider.GetEnsaladaAtun();
                comidaMiercoles = atun;
            }
            else if (tingaButton.Checked == true)
            {
                Meal tinga = FoodProvider.GetTostadasTinga();
                comidaMiercoles = tinga;
            }
            else if (polloVerdurasButton.Checked == true)
            {
                Meal polloVerduras = FoodProvider.GetpolloConVerduras();
                comidaMiercoles = polloVerduras;
            }
            else
            {
                Meal enchiladas = FoodProvider.GetEnchiladasVerdes();
                comidaMiercoles = enchiladas;
            }
            //cenas
            if (toastbutton.Checked == true)
            {
                Meal toast = FoodProvider.GetToast();
                cenaMiercoles = toast;
            }
            else if (huevoEstrelladoButton.Checked == true)
            {
                Meal huevoEstrellado = FoodProvider.GetHuevoEstrellado();
                cenaMiercoles = huevoEstrellado;
            }
            else if (sandwichButton.Checked == true)
            {
                Meal sandwich = FoodProvider.GetSandwich();
                cenaMiercoles = sandwich;
            }
            else if (cerealButton.Checked == true)
            {
                Meal cereal = FoodProvider.GetCerealconLeche();
                cenaMiercoles = cereal;
            }
            else
            {
                Meal huevoRevuelto = FoodProvider.GetHuevosConJamon();
                cenaMiercoles = huevoRevuelto;
            }
            this.Hide();
            SeleccionMenuJueves seleccionMenuJueves = new SeleccionMenuJueves();
            seleccionMenuJueves.ShowDialog();
            //ResumenPlan resumenPlan = new ResumenPlan();
            //resumenPlan.ShowDialog();
        }
        public static Meal GetDesayunoMiercoles()
        {
            return desayunoMiercoles;
        }
        public static Meal GetComidaMiercoles()
        {
            return comidaMiercoles;
        }
        public static Meal GetCenaMiercoles()
        {
            return cenaMiercoles;
        }
    }
}