using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class UserAddress : UserControl
    {
        private AppUser usuario;
        public UserAddress(AppUser user)
        {
            usuario = user;
            InitializeComponent();
            ActualizaControles(usuario.idUser);
        }
        
        private void ActualizaControles(int idUser)
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox2.DisplayMember = "address";
            comboBox1.DataSource = Connection.ExecuteQuery($"SELECT ad.idAddress, ad.address " +
                                                              $"FROM ADDRESS ad " +
                                                              $"WHERE idUser = {idUser};");
            
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "idAddress";
            comboBox2.DisplayMember = "address";
            comboBox1.DataSource = Connection.ExecuteQuery($"SELECT ad.idAddress, ad.address " +
                                                           $"FROM ADDRESS ad " +
                                                           $"WHERE idUser = {idUser};");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                AddressQuery.newAddress(richTextBox1.Text, usuario.idUser);
                ActualizaControles(usuario.idUser);

                MessageBox.Show("Dirección almacenada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Address ad = (Address) comboBox1.SelectedItem;
                AddressQuery.updateAddress(richTextBox2.Text, ad.idAddress);

                MessageBox.Show("Dirección modificada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Address ad = (Address) comboBox1.SelectedItem;
                AddressQuery.deleteAddress(ad.idAddress);

                MessageBox.Show("Dirección elimininada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }
    }
}