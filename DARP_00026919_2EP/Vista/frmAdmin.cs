using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public partial class frmAdmin : Form
    {
        private AppUser usuario;
        public frmAdmin(AppUser user)
        {
            InitializeComponent();
            usuario = user;
        }
        
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            ActualizaControles();
        }
        
        private void ActualizaControles()
        {
            List<Business> listaB = BusinessQuery.getLista();

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = listaB;
            
            cmbNegocio.DataSource = null;
            cmbNegocio.ValueMember = "idBusiness";
            cmbNegocio.DisplayMember = "name";
            cmbNegocio.DataSource = listaB;

            cmbNegocio2.DataSource = null;
            cmbNegocio2.ValueMember = "idBusiness";
            cmbNegocio2.DisplayMember = "name";
            cmbNegocio2.DataSource = listaB;
            
            cmbNegocioP.DataSource = null;
            cmbNegocioP.ValueMember = "idBusiness";
            cmbNegocioP.DisplayMember = "name";
            cmbNegocioP.DataSource = listaB;
            
            cmbNegocioEP.DataSource = null;
            cmbNegocioEP.ValueMember = "idBusiness";
            cmbNegocioEP.DisplayMember = "name";
            cmbNegocioEP.DataSource = listaB;

            cmbProducto.DataSource = null;
            cmbProducto.ValueMember = "idProduct";
            cmbProducto.DisplayMember = "name";
            cmbProducto.DataSource = ProductQuery.getLista();
        }
        
        private void btnMostrarU_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Connection.ExecuteQuery($"SELECT * FROM APPUSER");

                dataGridView1.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || txtUsuario.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacíos");
            }
            else
            {
                try
                {
                    AppUser nuevo = new AppUser();
                    nuevo.fullname = txtNombre.Text + " " + txtApellido.Text;
                    nuevo.username = txtUsuario.Text;
                    nuevo.password = txtUsuario.Text;
                    nuevo.admin = radAdmin.Checked;
                    AppUserQuery.newUser(nuevo);
                    
                    MessageBox.Show("Usuario creado con los datos: \nNombre de usuario: " + txtUsuario.Text +
                                    ", contraseña: " + txtUsuario.Text);

                    txtNombre.Text = "";
                    txtApellido.Text = "";
                    txtUsuario.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            frmDeleteUser ventana = new frmDeleteUser();
            ventana.ShowDialog();
        }

        private void btnAgregarN_Click(object sender, EventArgs e)
        {
            List<Business> lista = BusinessQuery.getLista();
            bool flag = true;

            foreach (var bu in lista)
                if (txtNegocio.Text.Equals(bu.name))
                {
                    flag = false;
                    break;    
                }

            if (flag)
            {
                try
                {
                    BusinessQuery.newBusiness(txtNegocio.Text, textBox1.Text);
                    MessageBox.Show("Negocio agregado");
                    ActualizaControles();
                    textBox1.Clear();
                    txtNegocio.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
            else
                MessageBox.Show("Ya hay un negocio con ese nombre");
        }

        private void btnEliminarN_Click(object sender, EventArgs e)
        {
            string name;
            try
            {
                name = cmbNegocio.Text;
                BusinessQuery.deleteBusiness(name);
                MessageBox.Show("Negocio eliminado");
                ActualizaControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }
        
        private void btnMostrarN_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Connection.ExecuteQuery($"SELECT * FROM BUSINESS");

                dataGridView2.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            try
            {
                Business bu = (Business) cmbNegocioP.SelectedItem;
                ProductQuery.newProduct(bu.idBusiness, txtProducto.Text);

                MessageBox.Show("Producto agregado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                List<Product> lista = ProductQuery.getLista();
                foreach (Product pr in lista)
                {
                    if (cmbProducto.Text.Equals(pr.name))
                    {
                        ProductQuery.deleteProduct(pr.idProduct);
                        MessageBox.Show("Se eliminó el producto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
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

        private void cmbNegocioEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarProducto((Business) cmbNegocioEP.SelectedItem);
        }
        
        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
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
        
        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbNegocio2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var bu = (Business) cmbNegocio2.SelectedItem;
                var dt = Connection.ExecuteQuery($"SELECT p.idProduct, p.name " +
                                                 $"FROM PRODUCT p " +
                                                 $"WHERE idBusiness = {bu.idBusiness}");

                dataGridView3.DataSource = dt;

                //MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnMostrarO_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = Connection.ExecuteQuery($"SELECT ao.idOrder, ao.createDate, " +
                                                 "pr.name, au.fullname, ad.address " +
                                                 "FROM APPORDER ao, ADDRESS ad, PRODUCT pr, APPUSER au " +
                                                 "WHERE ao.idProduct = pr.idProduct " +
                                                 "AND ao.idAddress = ad.idAddress " +
                                                 "AND ad.idUser = au.idUser ");

                dataGridView4.DataSource = dt;

                MessageBox.Show("Datos obtenidos exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmChangePass ventana = new frmChangePass(usuario);
            ventana.ShowDialog();
        }
    }
}