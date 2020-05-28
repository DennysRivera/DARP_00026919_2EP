using System.ComponentModel;

namespace DARP_00026919_2EP
{
    partial class UserOrderHistory
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbNegocio = new System.Windows.Forms.ComboBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEliminarO = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(573, 234);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbNegocio
            // 
            this.cmbNegocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegocio.FormattingEnabled = true;
            this.cmbNegocio.Location = new System.Drawing.Point(15, 63);
            this.cmbNegocio.Name = "cmbNegocio";
            this.cmbNegocio.Size = new System.Drawing.Size(170, 23);
            this.cmbNegocio.TabIndex = 1;
            this.cmbNegocio.SelectedIndexChanged += new System.EventHandler(this.cmbNegocio_SelectedIndexChanged);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(15, 63);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(170, 23);
            this.cmbProducto.TabIndex = 2;
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(45, 45);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 23);
            this.cmbID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Negocio:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(45, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID de la orden:";
            // 
            // btnEliminarO
            // 
            this.btnEliminarO.Location = new System.Drawing.Point(45, 83);
            this.btnEliminarO.Name = "btnEliminarO";
            this.btnEliminarO.Size = new System.Drawing.Size(128, 59);
            this.btnEliminarO.TabIndex = 7;
            this.btnEliminarO.Text = "Eliminar orden";
            this.btnEliminarO.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbNegocio);
            this.groupBox1.Location = new System.Drawing.Point(8, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por negocio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cmbProducto);
            this.groupBox2.Location = new System.Drawing.Point(8, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 93);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por producto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminarO);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbID);
            this.groupBox3.Location = new System.Drawing.Point(344, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 152);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar orden";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "Mostrar órdenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserOrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserOrderHistory";
            this.Size = new System.Drawing.Size(577, 502);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbNegocio;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbID;
    }
}