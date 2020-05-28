using System.ComponentModel;

namespace DARP_00026919_2EP
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAdmin = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrarU = new System.Windows.Forms.Button();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpNegocios = new System.Windows.Forms.TabPage();
            this.btnMostrarN = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEliminarN = new System.Windows.Forms.Button();
            this.cmbNegocio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtNegocio = new System.Windows.Forms.TextBox();
            this.btnAgregarN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpProductos = new System.Windows.Forms.TabPage();
            this.btnMostrarP = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbNegocioEP = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNegocioP = new System.Windows.Forms.ComboBox();
            this.tpOrdenes = new System.Windows.Forms.TabPage();
            this.btnMostrarO = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cmbNegocio2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabAdmin.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tpNegocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tpOrdenes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.tpHome);
            this.tabAdmin.Controls.Add(this.tabPage2);
            this.tabAdmin.Controls.Add(this.tpNegocios);
            this.tabAdmin.Controls.Add(this.tpProductos);
            this.tabAdmin.Controls.Add(this.tpOrdenes);
            this.tabAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.SelectedIndex = 0;
            this.tabAdmin.Size = new System.Drawing.Size(749, 577);
            this.tabAdmin.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Location = new System.Drawing.Point(4, 24);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(741, 549);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminarU);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnMostrarU);
            this.tabPage2.Controls.Add(this.btnAgregarU);
            this.tabPage2.Controls.Add(this.txtUsuario);
            this.tabPage2.Controls.Add(this.txtApellido);
            this.tabPage2.Controls.Add(this.txtNombre);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(741, 549);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(570, 510);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(162, 31);
            this.btnEliminarU.TabIndex = 12;
            this.btnEliminarU.Text = "Eliminar usuario";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCliente);
            this.groupBox1.Controls.Add(this.radAdmin);
            this.groupBox1.Location = new System.Drawing.Point(408, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 57);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de usuario";
            // 
            // radCliente
            // 
            this.radCliente.Location = new System.Drawing.Point(157, 16);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(104, 24);
            this.radCliente.TabIndex = 10;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            // 
            // radAdmin
            // 
            this.radAdmin.Location = new System.Drawing.Point(15, 16);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(104, 24);
            this.radAdmin.TabIndex = 9;
            this.radAdmin.TabStop = true;
            this.radAdmin.Text = "Administrador";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 284);
            this.dataGridView1.TabIndex = 8;
            // 
            // btnMostrarU
            // 
            this.btnMostrarU.Location = new System.Drawing.Point(20, 175);
            this.btnMostrarU.Name = "btnMostrarU";
            this.btnMostrarU.Size = new System.Drawing.Size(97, 39);
            this.btnMostrarU.TabIndex = 7;
            this.btnMostrarU.Text = "Mostrar usuarios";
            this.btnMostrarU.UseVisualStyleBackColor = true;
            this.btnMostrarU.Click += new System.EventHandler(this.btnMostrarU_Click);
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Location = new System.Drawing.Point(518, 148);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(115, 45);
            this.btnAgregarU.TabIndex = 6;
            this.btnAgregarU.Text = "Agregar usuario";
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(518, 43);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(171, 23);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(107, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(171, 23);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(107, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(171, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(373, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpNegocios
            // 
            this.tpNegocios.Controls.Add(this.btnMostrarN);
            this.tpNegocios.Controls.Add(this.dataGridView2);
            this.tpNegocios.Controls.Add(this.groupBox3);
            this.tpNegocios.Controls.Add(this.groupBox2);
            this.tpNegocios.Location = new System.Drawing.Point(4, 24);
            this.tpNegocios.Name = "tpNegocios";
            this.tpNegocios.Size = new System.Drawing.Size(741, 549);
            this.tpNegocios.TabIndex = 2;
            this.tpNegocios.Text = "Negocios";
            this.tpNegocios.UseVisualStyleBackColor = true;
            // 
            // btnMostrarN
            // 
            this.btnMostrarN.Location = new System.Drawing.Point(500, 23);
            this.btnMostrarN.Name = "btnMostrarN";
            this.btnMostrarN.Size = new System.Drawing.Size(133, 43);
            this.btnMostrarN.TabIndex = 11;
            this.btnMostrarN.Text = "Mostrar negocios";
            this.btnMostrarN.UseVisualStyleBackColor = true;
            this.btnMostrarN.Click += new System.EventHandler(this.btnMostrarN_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(357, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(381, 477);
            this.dataGridView2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarN);
            this.groupBox3.Controls.Add(this.cmbNegocio);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(27, 327);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 200);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar negocio";
            // 
            // btnEliminarN
            // 
            this.btnEliminarN.Location = new System.Drawing.Point(76, 120);
            this.btnEliminarN.Name = "btnEliminarN";
            this.btnEliminarN.Size = new System.Drawing.Size(134, 60);
            this.btnEliminarN.TabIndex = 6;
            this.btnEliminarN.Text = "Eliminar negocio";
            this.btnEliminarN.UseVisualStyleBackColor = true;
            this.btnEliminarN.Click += new System.EventHandler(this.btnEliminarN_Click);
            // 
            // cmbNegocio
            // 
            this.cmbNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocio.FormattingEnabled = true;
            this.cmbNegocio.Location = new System.Drawing.Point(16, 77);
            this.cmbNegocio.Name = "cmbNegocio";
            this.cmbNegocio.Size = new System.Drawing.Size(258, 23);
            this.cmbNegocio.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(94, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 45);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre del negocio:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.txtNegocio);
            this.groupBox2.Controls.Add(this.btnAgregarN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 292);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar negocio";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 89);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // txtNegocio
            // 
            this.txtNegocio.Location = new System.Drawing.Point(141, 40);
            this.txtNegocio.Name = "txtNegocio";
            this.txtNegocio.Size = new System.Drawing.Size(185, 23);
            this.txtNegocio.TabIndex = 2;
            // 
            // btnAgregarN
            // 
            this.btnAgregarN.Location = new System.Drawing.Point(77, 219);
            this.btnAgregarN.Name = "btnAgregarN";
            this.btnAgregarN.Size = new System.Drawing.Size(134, 60);
            this.btnAgregarN.TabIndex = 7;
            this.btnAgregarN.Text = "Agregar negocio";
            this.btnAgregarN.UseVisualStyleBackColor = true;
            this.btnAgregarN.Click += new System.EventHandler(this.btnAgregarN_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descripción del negocio:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre del negocio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpProductos
            // 
            this.tpProductos.Controls.Add(this.label11);
            this.tpProductos.Controls.Add(this.cmbNegocio2);
            this.tpProductos.Controls.Add(this.btnMostrarP);
            this.tpProductos.Controls.Add(this.dataGridView3);
            this.tpProductos.Controls.Add(this.groupBox5);
            this.tpProductos.Controls.Add(this.groupBox4);
            this.tpProductos.Location = new System.Drawing.Point(4, 24);
            this.tpProductos.Name = "tpProductos";
            this.tpProductos.Size = new System.Drawing.Size(741, 549);
            this.tpProductos.TabIndex = 3;
            this.tpProductos.Text = "Productos";
            this.tpProductos.UseVisualStyleBackColor = true;
            // 
            // btnMostrarP
            // 
            this.btnMostrarP.Location = new System.Drawing.Point(612, 20);
            this.btnMostrarP.Name = "btnMostrarP";
            this.btnMostrarP.Size = new System.Drawing.Size(121, 50);
            this.btnMostrarP.TabIndex = 3;
            this.btnMostrarP.Text = "Mostar todos  productos";
            this.btnMostrarP.UseVisualStyleBackColor = true;
            this.btnMostrarP.Click += new System.EventHandler(this.btnMostrarP_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(360, 76);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(378, 470);
            this.dataGridView3.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.cmbProducto);
            this.groupBox5.Controls.Add(this.btnEliminarP);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.cmbNegocioEP);
            this.groupBox5.Location = new System.Drawing.Point(31, 305);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(266, 222);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar producto";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(83, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 5;
            this.label10.Text = "Producto:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(6, 117);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(254, 23);
            this.cmbProducto.TabIndex = 4;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Location = new System.Drawing.Point(73, 162);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(110, 55);
            this.btnEliminarP.TabIndex = 3;
            this.btnEliminarP.Text = "Eliminar producto";
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(73, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 1;
            this.label8.Text = "Negocio:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNegocioEP
            // 
            this.cmbNegocioEP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioEP.FormattingEnabled = true;
            this.cmbNegocioEP.Location = new System.Drawing.Point(5, 55);
            this.cmbNegocioEP.Name = "cmbNegocioEP";
            this.cmbNegocioEP.Size = new System.Drawing.Size(255, 23);
            this.cmbNegocioEP.TabIndex = 0;
            this.cmbNegocioEP.SelectedIndexChanged += new System.EventHandler(this.cmbNegocioEP_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtProducto);
            this.groupBox4.Controls.Add(this.btnAgregarP);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbNegocioP);
            this.groupBox4.Location = new System.Drawing.Point(31, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 237);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar producto";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(73, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Producto:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(6, 130);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(255, 23);
            this.txtProducto.TabIndex = 3;
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Location = new System.Drawing.Point(73, 175);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(110, 55);
            this.btnAgregarP.TabIndex = 2;
            this.btnAgregarP.Text = "Agregar producto";
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(73, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Negocio:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbNegocioP
            // 
            this.cmbNegocioP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocioP.FormattingEnabled = true;
            this.cmbNegocioP.Location = new System.Drawing.Point(6, 54);
            this.cmbNegocioP.Name = "cmbNegocioP";
            this.cmbNegocioP.Size = new System.Drawing.Size(255, 23);
            this.cmbNegocioP.TabIndex = 0;
            // 
            // tpOrdenes
            // 
            this.tpOrdenes.Controls.Add(this.btnMostrarO);
            this.tpOrdenes.Controls.Add(this.dataGridView4);
            this.tpOrdenes.Location = new System.Drawing.Point(4, 24);
            this.tpOrdenes.Name = "tpOrdenes";
            this.tpOrdenes.Size = new System.Drawing.Size(741, 549);
            this.tpOrdenes.TabIndex = 4;
            this.tpOrdenes.Text = "Órdenes";
            this.tpOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnMostrarO
            // 
            this.btnMostrarO.Location = new System.Drawing.Point(8, 202);
            this.btnMostrarO.Name = "btnMostrarO";
            this.btnMostrarO.Size = new System.Drawing.Size(122, 40);
            this.btnMostrarO.TabIndex = 1;
            this.btnMostrarO.Text = "Mostar órdenes";
            this.btnMostrarO.UseVisualStyleBackColor = true;
            this.btnMostrarO.Click += new System.EventHandler(this.btnMostrarO_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(3, 248);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(735, 298);
            this.dataGridView4.TabIndex = 0;
            // 
            // cmbNegocio2
            // 
            this.cmbNegocio2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocio2.FormattingEnabled = true;
            this.cmbNegocio2.Location = new System.Drawing.Point(360, 47);
            this.cmbNegocio2.Name = "cmbNegocio2";
            this.cmbNegocio2.Size = new System.Drawing.Size(194, 23);
            this.cmbNegocio2.TabIndex = 4;
            this.cmbNegocio2.SelectedIndexChanged += new System.EventHandler(this.cmbNegocio2_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(360, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 23);
            this.label11.TabIndex = 5;
            this.label11.Text = "Mostrar productos de:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 577);
            this.Controls.Add(this.tabAdmin);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabAdmin.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tpNegocios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tpOrdenes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabControl tabAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.Button btnMostrarU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tpProductos;
        private System.Windows.Forms.TabPage tpNegocios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnMostrarP;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnMostrarN;
        private System.Windows.Forms.Button btnAgregarN;
        private System.Windows.Forms.Button btnEliminarN;
        private System.Windows.Forms.TabPage tpOrdenes;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button btnMostrarO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbNegocioEP;
        private System.Windows.Forms.ComboBox cmbNegocioP;
        private System.Windows.Forms.ComboBox cmbNegocio;
        private System.Windows.Forms.TextBox txtNegocio;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ComboBox cmbNegocio2;
        private System.Windows.Forms.Label label11;
    }
}