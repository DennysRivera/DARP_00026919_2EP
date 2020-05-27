using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
         private void btnLogin_Click(object sender, EventArgs e)
         {
             List<AppUser> listaUsuarios = AppUserQuery.getLista();

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Usuario/Contraseña no ingresado");
            }
            else
            {
                bool flag = true;
                try
                {
                    foreach (var u in listaUsuarios)
                    {
                        if (textBox1.Text.Equals(u.username))
                        {
                            if (textBox2.Text.Equals(u.password))
                            {
                                if (u.admin)
                                {
                                    frmAdmin ventana = new frmAdmin(u);
                                    ventana.Show();
                                    this.Hide();
                                    flag = false;
                                }
                                else
                                {
                                    frmUser ventana = new frmUser();
                                    ventana.Show();
                                    this.Hide();
                                    flag = false;
                                }
                            }
                            else MessageBox.Show("Contraseña incorrecta");

                            break;
                        }
                    }
                    if (flag) MessageBox.Show("No se encontró el usuario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister ventana = new frmRegister();
            ventana.ShowDialog();
        }
        
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }
    }
}