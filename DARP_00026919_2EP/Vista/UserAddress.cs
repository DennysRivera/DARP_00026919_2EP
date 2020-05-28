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
            comboBox1.DisplayMember = "address";
            comboBox1.DataSource = Connection.ExecuteQuery($"SELECT ad.idAddress, ad.address " +
                                                           $"FROM ADDRESS ad " +
                                                           $"WHERE idUser = {idUser};");
            
            
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "idAddress";
            comboBox2.DisplayMember = "address";
            comboBox2.DataSource = Connection.ExecuteQuery($"SELECT ad.idAddress, ad.address " +
                                                           $"FROM ADDRESS ad " +
                                                           $"WHERE idUser = {idUser};");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
                MessageBox.Show("No hay ninguna dirección");
            else
            {
                try
                {
                    AddressQuery.newAddress(textBox1.Text, usuario.idUser);
                    ActualizaControles(usuario.idUser);

                    MessageBox.Show("Dirección almacenada");
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idAddress = 0;
            if(textBox2.Text.Equals(""))
                MessageBox.Show("No hay nueva dirección");
            else
            {
                try
                {
                    List<Address> lista = AddressQuery.getLista();
                    foreach (var ad in lista)
                    {
                        if (comboBox2.Text.Equals(ad.address))
                        {
                            idAddress = ad.idAddress;
                            break;
                        }
                    }
                    AddressQuery.updateAddress(textBox2.Text, idAddress);

                    MessageBox.Show("Dirección modificada");
                    textBox2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idAddress = 0;
            try
            {
                List<Address> lista = AddressQuery.getLista();
                foreach (var ad in lista)
                {
                    if (comboBox2.Text.Equals(ad.address))
                    {
                       
                        AddressQuery.deleteAddress(ad.idAddress);
                        MessageBox.Show("Dirección elimininada");
                       
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }
    }
}