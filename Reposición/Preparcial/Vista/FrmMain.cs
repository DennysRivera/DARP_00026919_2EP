using Preparcial.Modelo;
using Preparcial.Controlador;
using System.Windows.Forms;
using System;

namespace Preparcial.Vista
{
    public partial class FrmMain : Form
    {
        private Usuario u;

        public FrmMain(Usuario u)
        {
            InitializeComponent();
            this.u = u;
        }

        private void bttnCreateUser_Click(object sender, EventArgs e)
        {
            if (!txtNewUser.Text.Equals(""))
            {
                ControladorUsuario.CrearUsuario(txtNewUser.Text);
                ActualizarCrearUsuario();
            }
        }

        private void ActualizarCrearUsuario()
        {
            dgvCreateUser.DataSource = ControladorUsuario.GetUsuariosTable();
        }

        private void ActualizarInventario()
        {
            dgvInventary.DataSource = ControladorInventario.GetProductosTable();
        }

        private void ActualizarOrdenes()
        {
            dgvAllOrders.DataSource = ControladorPedido.GetPedidosTable();
        }

        private void ActualizarOrdenesUsuario()
        {
            dgvMyOrders.DataSource = ControladorPedido.GetPedidosUsuarioTable(u.IdUsuario);
            cmbProductMakeOrder.DataSource = null;//Corrección (Buena práctica?): Agregado para que limpie el DataSource previo
            cmbProductMakeOrder.ValueMember = "idArticulo";//Corrección (Buena práctica?): Se cambió "idarticulo" por "idArticulo"
            cmbProductMakeOrder.DisplayMember = "producto";
            cmbProductMakeOrder.DataSource = ControladorInventario.GetProductos();
            
        }

        private void bttnAddInventary_Click(object sender, EventArgs e)
        {
            if (txtProductNameInventary.Text.Equals("") ||//Corrección: Se cambiaron operadores lógicos && por ||
                txtDescriptionInventary.Text.Equals("") ||
                txtPriceInventary.Text.Equals("") ||
                txtStockInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.AnadirProducto(txtProductNameInventary.Text, txtDescriptionInventary.Text,
                    txtPriceInventary.Text, txtStockInventary.Text);

                ActualizarInventario();
                txtProductNameInventary.Clear();//Corrección estética: Se agregó método '.Clear()' para limpiar
                txtDescriptionInventary.Clear();//las textBox después de agregar el producto
                txtPriceInventary.Clear();
                txtStockInventary.Clear();
            }
        }

        private void bttnDeleteInventary_Click(object sender, EventArgs e)
        {
            if(txtDeleteInventary.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.EliminarProducto(txtDeleteInventary.Text);
                ActualizarInventario();
                txtDeleteInventary.Clear();//Corrección estética: método ".Clear()" para limpiar la
                                           //textBox después de eliminar el producto
            }
        }

        private void bttnUpdateStockInventary_Click(object sender, EventArgs e)
        {
            if (txtUpdateStockIdInventary.Text.Equals("") || txtUpdateStockInventary.Text.Equals(""))//Corrección: Se cambió operador lógico && por ||
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorInventario.ActualizarProducto(txtUpdateStockIdInventary.Text, txtUpdateStockInventary.Text);
                ActualizarInventario();
                txtUpdateStockIdInventary.Clear();//Corrección estética: Se agregó método '.Clear()' para limpiar
                txtUpdateStockInventary.Clear();  //las textBox después de actualizar el stock
            }
        }

        private void bttnMakeOrder_Click(object sender, EventArgs e)
        {
            if (txtMakeOrderQuantity.Text.Equals(""))
                MessageBox.Show("No puede dejar campos vacios");
            else
            {
                ControladorPedido.HacerPedido(u.IdUsuario, cmbProductMakeOrder.SelectedValue.ToString(), txtMakeOrderQuantity.Text);
                MessageBox.Show("Se hizo un pedido");//Corrección estética: Aviso de pedido realizado
                ActualizarOrdenesUsuario();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name.Equals("createNewUserTab") && u.Admin)
                ActualizarCrearUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("inventaryTab") && u.Admin)
                ActualizarInventario();

            else if (tabControl1.SelectedTab.Name.Equals("createOrderTab") && !u.Admin)
                ActualizarOrdenesUsuario();

            else if (tabControl1.SelectedTab.Name.Equals("viewOrdersTab") && u.Admin)
                ActualizarOrdenes();
            else if (tabControl1.SelectedTab.Name.Equals("generalTab")){}//Corrección: Se agregó para que no lance el MessageBox al regresar al tab "General"
            
            else
            {
                MessageBox.Show("No tiene permisos para ver esta pestana");
                tabControl1.SelectedTab = tabControl1.TabPages[0];
            }

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
