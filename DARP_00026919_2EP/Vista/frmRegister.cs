using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            PrepararLista();
        }

        private List<AppUser> PrepararLista()
        {
            List<AppUser> listaUsuarios = AppUserQuery.getLista();

            return listaUsuarios;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<AppUser> lista = PrepararLista();

            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") || textBox5.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                bool flag = true;
                try
                {
                    foreach (AppUser au in lista)
                        if (textBox3.Text.Equals(au.username))
                        {
                            flag = false;
                            break;
                        }

                    if (flag)
                    {
                        AppUser nuevo = new AppUser();
                        nuevo.fullname = textBox1.Text + " " + textBox2.Text;
                        nuevo.username = textBox3.Text;
                        nuevo.password = textBox4.Text;

                        if (textBox4.Text.Equals(textBox5.Text))
                        {
                            AppUserQuery.newUser(nuevo);
                            MessageBox.Show("Registro completo");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                        }
                        else MessageBox.Show("Las contraseñas no coinciden");
                    }
                    else
                        MessageBox.Show("El nombre de usuario ya existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea regresar?", 
                "Regresar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                try
                {
                    e.Cancel = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }
    }
}