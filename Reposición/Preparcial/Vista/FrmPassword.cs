using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
            comboBox1.DataSource = null;//Corrección (Buena práctica?): Agregado para limpiar el DataSource previo
            comboBox1.ValueMember = "Contrasena";
            comboBox1.DisplayMember = "NombreUsuario";//Corrección: Se movió para que este antes del ".DataSource"
            comboBox1.DataSource = ControladorUsuario.GetUsuarios();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()))
            {
                var obtenerUsuario = (Usuario) comboBox1.SelectedItem;

                ActualizarControlers();

                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                    txtNewPassword.Text);
                
                txtOldPassword.Clear();//Corrección estética: método ".Clear" para limpiar los textBox después
                txtNewPassword.Clear();//de modificar la contraseña
            }
            else
                MessageBox.Show("Contrasena actual incorrecta");
        }
    }
}
