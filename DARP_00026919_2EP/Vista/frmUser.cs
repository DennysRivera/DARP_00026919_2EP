using System;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmUser : Form
    {
        private AppUser usuario;
        private UserControl current = null;
        public frmUser(AppUser user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UserOrder(usuario.idUser);
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }

        private void btnDireccion_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UserAddress(usuario);
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }


        private void btnHistorial_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new UserOrderHistory(usuario);
            tableLayoutPanel1.Controls.Add(current, 0, 1);
            tableLayoutPanel1.SetColumnSpan(current, 4);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
        }
        
        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.username + "?", 
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
                    MessageBox.Show("Ocurrió un error", 
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void frmUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChangePass ventana = new frmChangePass(usuario);
            ventana.ShowDialog();
        }
    }
}