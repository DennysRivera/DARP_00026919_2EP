using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class UserOrder : UserControl
    {
        public UserOrder(int id)
        {
            InitializeComponent();
            ActualizaControles(id);
            MostrarNegocios();
            bool ableButton = ComprobarListas();
            btnOrdenar.Enabled = ableButton;
            PrepararProducts();
            PrepararAddresses();

        }
        
        private void ActualizaControles(int idUser)
        {
            List<Business> listaB = BusinessQuery.getLista();

            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idBusiness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = listaB;

            cmbDireccion.DataSource = null;
            cmbDireccion.ValueMember = "idAddress";
            cmbDireccion.DisplayMember = "address";
            cmbDireccion.DataSource = Connection.ExecuteQuery($"SELECT ad.idAddress, ad.address " +
                                                              $"FROM ADDRESS ad " +
                                                              $"WHERE idUser = {idUser};");
            
            Business bu = (Business) cmbNegocio.SelectedItem;
            ActualizarProducto(bu);
        }

        private bool ComprobarListas()
        {
            List<Business> listaB = BusinessQuery.getLista();
            List<Address> listaA = AddressQuery.getLista();
            if (listaA.Any() && listaB.Any())
                return true;
            else
                return false;
        }

        private List<Product> PrepararProducts()
        {
            List<Product> lista = ProductQuery.getLista();
            return lista;
        }
        
        private List<Address> PrepararAddresses()
        {
            List<Address> lista = AddressQuery.getLista();
            return lista;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            var listaA = PrepararAddresses();
            var listaP = PrepararProducts();
            int idAddress = 0, idProduct = 0;
            try
            {
                var createDate = DateTime.Now;
                //Address address = new Address();
                

                foreach (Address address in listaA)
                {
                    if (cmbDireccion.Text.Equals(address.address))
                    {
                        idAddress = address.idAddress;
                        break;
                    }
                }

                foreach (Product product in listaP)
                {
                    if (cmbProducto.Text.Equals(product.name))
                    {
                        idProduct = product.idProduct;
                        break;
                    }
                }

                MessageBox.Show(idAddress.ToString());
                AppOrderQuery.newOrder(createDate, Convert.ToInt32(cmbProducto.ValueMember), Convert.ToInt32(cmbProducto.ValueMember));

                MessageBox.Show("Se ha hecho la orden");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void MostrarNegocios()
        {
            try
            {
                var dt = Connection.ExecuteQuery($"SELECT * FROM BUSINESS");

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void cmbNegocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarProducto((Business) cmbNegocio.SelectedItem);
            try
            {
                var bu = (Business) cmbNegocio.SelectedItem;
                var dt = Connection.ExecuteQuery($"SELECT p.idProduct, p.name " +
                                                 $"FROM PRODUCT p " +
                                                 $"WHERE idBusiness = {bu.idBusiness}");

                dataGridView2.DataSource = dt;

                //MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
        
        private void ActualizarProducto(Business bu)
        {
            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idProduct";
            cmbProducto.DisplayMember = "name";
            cmbProducto.DataSource = Connection.ExecuteQuery($"SELECT p.idProduct, p.name " +
                                                             $"FROM PRODUCT p " +
                                                             $"WHERE idBusiness = {bu.idBusiness}");
        }
    }
}