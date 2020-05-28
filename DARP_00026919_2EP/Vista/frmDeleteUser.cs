using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
            PreparaLista();
        }

        private List<AppUser> PreparaLista()
        {
            List<AppUser> lista = AppUserQuery.getLista();

            return lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<AppUser> lista = PreparaLista();

            bool flag = true;
            foreach (var au in lista)
            {
                if (textBox1.Text.Equals(au.username))
                {
                    if (MessageBox.Show("¿Seguro que desea eliminar a " + au.username + "?", 
                        "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            AppUserQuery.deleteUser(au.idUser);
                            MessageBox.Show("Usuario eliminado");
                            flag = false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ocurrió un error", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            if (flag)
                MessageBox.Show("No se encontró al usuario");
        }
    }
}