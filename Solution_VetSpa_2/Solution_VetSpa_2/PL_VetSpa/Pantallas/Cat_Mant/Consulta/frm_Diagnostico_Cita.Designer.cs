namespace PL_VetSpa.Pantallas.Cat_Mant.Consulta
{
    partial class frm_Diagnostico_Cita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Diagnostico_Cita));
            this.lstbxTerapia = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.lstbxMotiv = new System.Windows.Forms.ListBox();
            this.txtUsuModif = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsuCreac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpkFechModif = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtpkFechCreac = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvReceta = new System.Windows.Forms.DataGridView();
            this.clmCodigo_de_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIDPacie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombPacie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbxTerapia
            // 
            this.lstbxTerapia.AccessibleName = "";
            this.lstbxTerapia.FormattingEnabled = true;
            this.lstbxTerapia.Location = new System.Drawing.Point(222, 221);
            this.lstbxTerapia.Name = "lstbxTerapia";
            this.lstbxTerapia.Size = new System.Drawing.Size(492, 82);
            this.lstbxTerapia.TabIndex = 231;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(168, 253);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 230;
            this.label21.Text = "Terapia:";
            // 
            // lstbxMotiv
            // 
            this.lstbxMotiv.AccessibleName = "lstbxMotiv";
            this.lstbxMotiv.FormattingEnabled = true;
            this.lstbxMotiv.Location = new System.Drawing.Point(222, 120);
            this.lstbxMotiv.Name = "lstbxMotiv";
            this.lstbxMotiv.Size = new System.Drawing.Size(492, 95);
            this.lstbxMotiv.TabIndex = 204;
            // 
            // txtUsuModif
            // 
            this.txtUsuModif.Location = new System.Drawing.Point(222, 565);
            this.txtUsuModif.Name = "txtUsuModif";
            this.txtUsuModif.Size = new System.Drawing.Size(274, 20);
            this.txtUsuModif.TabIndex = 201;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 13);
            this.label11.TabIndex = 200;
            this.label11.Text = "Usuario de Modificacion:";
            // 
            // txtUsuCreac
            // 
            this.txtUsuCreac.Location = new System.Drawing.Point(222, 537);
            this.txtUsuCreac.Name = "txtUsuCreac";
            this.txtUsuCreac.Size = new System.Drawing.Size(274, 20);
            this.txtUsuCreac.TabIndex = 199;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 536);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 198;
            this.label10.Text = "Usuario de Creacion:";
            // 
            // dtpkFechModif
            // 
            this.dtpkFechModif.Location = new System.Drawing.Point(222, 510);
            this.dtpkFechModif.Name = "dtpkFechModif";
            this.dtpkFechModif.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechModif.TabIndex = 197;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 196;
            this.label9.Text = "Fecha de Modificacion:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(627, 542);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 43);
            this.btnCancelar.TabIndex = 195;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(627, 487);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 43);
            this.btnGuardar.TabIndex = 194;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // dtpkFechCreac
            // 
            this.dtpkFechCreac.Location = new System.Drawing.Point(222, 481);
            this.dtpkFechCreac.Name = "dtpkFechCreac";
            this.dtpkFechCreac.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechCreac.TabIndex = 193;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 192;
            this.label8.Text = "Fecha de Creacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 38);
            this.label1.TabIndex = 190;
            this.label1.Text = "Diagnostico o Terapia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 189;
            this.label5.Text = "Diagnostico:";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(12, 7);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 103);
            this.picLogo.TabIndex = 188;
            this.picLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(113, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 38);
            this.label2.TabIndex = 241;
            this.label2.Text = "Receta";
            // 
            // dtgvReceta
            // 
            this.dtgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo_de_Producto,
            this.clmDescripcion,
            this.clmCantidad});
            this.dtgvReceta.Location = new System.Drawing.Point(222, 309);
            this.dtgvReceta.Name = "dtgvReceta";
            this.dtgvReceta.Size = new System.Drawing.Size(492, 166);
            this.dtgvReceta.TabIndex = 242;
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
            // txtIDPacie
            // 
            this.txtIDPacie.Location = new System.Drawing.Point(358, 63);
            this.txtIDPacie.Name = "txtIDPacie";
            this.txtIDPacie.Size = new System.Drawing.Size(274, 20);
            this.txtIDPacie.TabIndex = 244;
            this.txtIDPacie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDPacie_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 243;
            this.label3.Text = "ID Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 245;
            this.label4.Text = "Nombre Paciente:";
            // 
            // txtNombPacie
            // 
            this.txtNombPacie.Location = new System.Drawing.Point(358, 94);
            this.txtNombPacie.Name = "txtNombPacie";
            this.txtNombPacie.Size = new System.Drawing.Size(274, 20);
            this.txtNombPacie.TabIndex = 246;
            this.txtNombPacie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombPacie_KeyPress);
            // 
            // frm_Diagnostico_Cita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 611);
            this.Controls.Add(this.txtNombPacie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDPacie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbxTerapia);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lstbxMotiv);
            this.Controls.Add(this.txtUsuModif);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtUsuCreac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpkFechModif);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpkFechCreac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Diagnostico_Cita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla de Diagnostico";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxTerapia;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lstbxMotiv;
        private System.Windows.Forms.TextBox txtUsuModif;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUsuCreac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpkFechModif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DateTimePicker dtpkFechCreac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo_de_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCantidad;
        private System.Windows.Forms.TextBox txtIDPacie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombPacie;
    }
}