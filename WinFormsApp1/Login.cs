using Programa_Dieta;
using Programa_Dieta.Constantes;
using Programa_Dieta.Entidades;

namespace WinFormsApp1
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

            userBox.Select();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (userBox.Text != Usuarios.UsuarioAdmin.Username)
            {
                loginWarningLabel.Visible = true;
                return;
            }
            if (passwordBox.Text != Usuarios.UsuarioAdmin.Password)
            {
                loginWarningLabel.Visible = true;
                return;
            }

            string mensaje = "Login exitoso";
            string caption = "Login";
            loginWarningLabel.Visible = false;
            MessageBoxButtons mensajeBotones = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, mensajeBotones);
            if (result == DialogResult.OK)
            {
                this.Hide();
                SeleccionMenuLunes seleccionMenu = new SeleccionMenuLunes();
                seleccionMenu.ShowDialog();
                this.Close();

            }

        }
    }
}