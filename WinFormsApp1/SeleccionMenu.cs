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
    public partial class SeleccionMenu : Form
    {
        public SeleccionMenu()
        {
            InitializeComponent();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ResumenPlan resumenPlan = new ResumenPlan();
            resumenPlan.ShowDialog();
        }
    }
}
