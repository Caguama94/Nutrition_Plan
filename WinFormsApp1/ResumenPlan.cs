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
        }
        private void resumenConfirmarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListaDeCompra listaDeCompra = new ListaDeCompra();
            listaDeCompra.ShowDialog();
        }
    }
}
