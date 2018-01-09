namespace PL_VetSpa.Pantallas.Cat_Mant.Facturacion
{
    partial class frm_Fact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Fact));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsIDDuen = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtgvFactura = new System.Windows.Forms.DataGridView();
            this.clmCodigo_de_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNomMasc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombDuen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDDueño = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsFact = new System.Windows.Forms.Button();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(160, 458);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 43);
            this.btnCancelar.TabIndex = 118;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(29, 459);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 43);
            this.btnGuardar.TabIndex = 117;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(215, 216);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 116;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(148, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 115;
            this.label11.Text = "Fecha:";
            // 
            // btnConsIDDuen
            // 
            this.btnConsIDDuen.BackColor = System.Drawing.Color.Transparent;
            this.btnConsIDDuen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsIDDuen.BackgroundImage")));
            this.btnConsIDDuen.Location = new System.Drawing.Point(495, 133);
            this.btnConsIDDuen.Name = "btnConsIDDuen";
            this.btnConsIDDuen.Size = new System.Drawing.Size(25, 23);
            this.btnConsIDDuen.TabIndex = 114;
            this.btnConsIDDuen.UseVisualStyleBackColor = false;
            this.btnConsIDDuen.Click += new System.EventHandler(this.btnConsIDDuen_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(401, 482);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 20);
            this.textBox3.TabIndex = 113;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(340, 485);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 112;
            this.label10.Text = "Total:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 459);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 111;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 110;
            this.label9.Text = "Impuesto de Ventas:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 437);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 109;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 108;
            this.label8.Text = "Sub Total:";
            // 
            // dtgvFactura
            // 
            this.dtgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo_de_Producto,
            this.clmDescripcion,
            this.clmCantidad,
            this.clmCosto});
            this.dtgvFactura.Location = new System.Drawing.Point(29, 247);
            this.dtgvFactura.Name = "dtgvFactura";
            this.dtgvFactura.Size = new System.Drawing.Size(646, 180);
            this.dtgvFactura.TabIndex = 107;
            // 
            // clmCodigo_de_Producto
            // 
            this.clmCodigo_de_Producto.FillWeight = 200F;
            this.clmCodigo_de_Producto.HeaderText = "Codigo de Producto";
            this.clmCodigo_de_Producto.Name = "clmCodigo_de_Producto";
            this.clmCodigo_de_Producto.Width = 150;
            // 
            // clmDescripcion
            // 
            this.clmDescripcion.FillWeight = 200F;
            this.clmDescripcion.HeaderText = "Descripcion del Producto";
            this.clmDescripcion.Name = "clmDescripcion";
            this.clmDescripcion.Width = 150;
            // 
            // clmCantidad
            // 
            this.clmCantidad.FillWeight = 200F;
            this.clmCantidad.HeaderText = "Cantidad";
            this.clmCantidad.Name = "clmCantidad";
            this.clmCantidad.Width = 150;
            // 
            // clmCosto
            // 
            this.clmCosto.FillWeight = 200F;
            this.clmCosto.HeaderText = "Costo";
            this.clmCosto.Name = "clmCosto";
            this.clmCosto.Width = 150;
            // 
            // cmbNomMasc
            // 
            this.cmbNomMasc.FormattingEnabled = true;
            this.cmbNomMasc.Location = new System.Drawing.Point(215, 189);
            this.cmbNomMasc.Name = "cmbNomMasc";
            this.cmbNomMasc.Size = new System.Drawing.Size(274, 21);
            this.cmbNomMasc.TabIndex = 106;
            this.cmbNomMasc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbNomMasc_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Nombre Mascota:";
            // 
            // txtNombDuen
            // 
            this.txtNombDuen.Location = new System.Drawing.Point(215, 160);
            this.txtNombDuen.Name = "txtNombDuen";
            this.txtNombDuen.Size = new System.Drawing.Size(274, 20);
            this.txtNombDuen.TabIndex = 104;
            this.txtNombDuen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombDuen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Nombre:";
            // 
            // txtIDDueño
            // 
            this.txtIDDueño.Location = new System.Drawing.Point(215, 133);
            this.txtIDDueño.Name = "txtIDDueño";
            this.txtIDDueño.Size = new System.Drawing.Size(274, 20);
            this.txtIDDueño.TabIndex = 102;
            this.txtIDDueño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDDueño_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 101;
            this.label5.Text = "ID Dueño:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Mall American Oulet ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Cedula Jurídica:  3-1234-1234-12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "VetSpa S.A.";
            // 
            // btnConsFact
            // 
            this.btnConsFact.BackColor = System.Drawing.Color.Transparent;
            this.btnConsFact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsFact.BackgroundImage")));
            this.btnConsFact.Location = new System.Drawing.Point(242, 23);
            this.btnConsFact.Name = "btnConsFact";
            this.btnConsFact.Size = new System.Drawing.Size(25, 23);
            this.btnConsFact.TabIndex = 96;
            this.btnConsFact.UseVisualStyleBackColor = false;
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(125, 23);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(111, 20);
            this.txtFactura.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 94;
            this.label1.Text = "Numero de Factura";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(543, 17);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 103);
            this.picLogo.TabIndex = 100;
            this.picLogo.TabStop = false;
            // 
            // frm_Fact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 523);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnConsIDDuen);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtgvFactura);
            this.Controls.Add(this.cmbNomMasc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombDuen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIDDueño);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsFact);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Fact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Facturación";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsIDDuen;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtgvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo_de_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCosto;
        private System.Windows.Forms.ComboBox cmbNomMasc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombDuen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIDDueño;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsFact;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}