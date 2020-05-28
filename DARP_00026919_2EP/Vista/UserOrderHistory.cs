using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class UserOrderHistory : UserControl
    {
        private AppUser usuario;
        public UserOrderHistory(AppUser user)
        {
            usuario = user;
            InitializeComponent();
            ActualizaControles();
        }
        
        private void ActualizaControles()
        {
            List<Business> listaB = BusinessQuery.getLista();

            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idBusiness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = listaB;

            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idProduct";
            cmbProducto.DisplayMember = "name";
            cmbProducto.DataSource = ProductQuery.getLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Connection.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, pr.name, au.fullname, ad.address " +
                                                 $"FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                 $"WHERE ao.idProduct = pr.idProduct " +
                                                 $"AND ao.idAddress = ad.idAddress " +
                                                 $"AND ad.idUser = au.idUser " +
                                                 $"AND au.idUser = {usuario.idUser}");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cmbNegocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarProducto((Business) cmbNegocio.SelectedItem);
        }
        
        private void ActualizarProducto(Business bu)
        {
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idProduct";
            cmbProducto.DisplayMember = "name";
            cmbProducto.DataSource = Connection.ExecuteQuery($"SELECT p.idProduct, p.name " +
                                                             $"FROM PRODUCT p " +
                                                             $"WHERE idBusiness = {bu.idBusiness}");
            
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idProduct";
            cmbProducto.DisplayMember = "idProduct";
            cmbProducto.DataSource = Connection.ExecuteQuery($"SELECT p.idProduct, p.name " +
                                                             $"FROM PRODUCT p " +
                                                             $"WHERE idBusiness = {bu.idBusiness}");
        }
        
        
    }
}