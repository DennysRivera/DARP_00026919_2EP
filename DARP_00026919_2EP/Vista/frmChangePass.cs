﻿using System;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmChangePass : Form
    {
        private AppUser usuario;
        public frmChangePass(AppUser user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(usuario.password))
            {
                if (textBox1.Text.Equals(textBox2.Text))
                    MessageBox.Show("La nueva contraseña no puede ser la misma que la actual");

                if (textBox2.Text.Equals(textBox3.Text))
                {
                    AppUserQuery.updatePass(usuario.username, textBox2.Text);
                    MessageBox.Show("Nueva contraseña establecida");
                }
            }
            else
                MessageBox.Show("No se reconoció esta conotraseña");
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