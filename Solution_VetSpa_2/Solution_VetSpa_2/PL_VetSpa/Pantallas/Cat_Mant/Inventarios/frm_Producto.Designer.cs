namespace PL_VetSpa.Inventarios
{
    partial class frm_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Producto));
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescProdServ = new System.Windows.Forms.TextBox();
            this.txtCodProdServ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCostRepIni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantIniProd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckbxImpuesto = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkFechCaduc = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpkFechCreac = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpkFechModif = new System.Windows.Forms.DateTimePicker();
            this.lblFechMod = new System.Windows.Forms.Label();
            this.txtUsuCreac = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUsuModif = new System.Windows.Forms.TextBox();
            this.lblUsuMod = new System.Windows.Forms.Label();
            this.cmbBorradoLogico = new System.Windows.Forms.ComboBox();
            this.lblBorradoLogico = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecProdServ = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbxTipProd = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "Costo de Reposicion Inicial:";
            // 
            // txtDescProdServ
            // 
            this.txtDescProdServ.Location = new System.Drawing.Point(220, 91);
            this.txtDescProdServ.Name = "txtDescProdServ";
            this.txtDescProdServ.Size = new System.Drawing.Size(274, 20);
            this.txtDescProdServ.TabIndex = 65;
            this.txtDescProdServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescProdServ_KeyPress);
            // 
            // txtCodProdServ
            // 
            this.txtCodProdServ.Location = new System.Drawing.Point(220, 66);
            this.txtCodProdServ.Name = "txtCodProdServ";
            this.txtCodProdServ.Size = new System.Drawing.Size(274, 20);
            this.txtCodProdServ.TabIndex = 63;
            this.txtCodProdServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodProdServ_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 62;
            this.label5.Text = "Codigo de Producto o Servicio:";
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLogo.Location = new System.Drawing.Point(554, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 103);
            this.picLogo.TabIndex = 61;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(209, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 78;
            this.label1.Text = "Ingreso de Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Descripcion del Producto o Servicio:";
            // 
            // txtCostRepIni
            // 
            this.txtCostRepIni.Location = new System.Drawing.Point(220, 150);
            this.txtCostRepIni.Name = "txtCostRepIni";
            this.txtCostRepIni.Size = new System.Drawing.Size(274, 20);
            this.txtCostRepIni.TabIndex = 80;
            this.txtCostRepIni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostRepIni_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 81;
            this.label3.Text = "colones.";
            // 
            // txtCantIniProd
            // 
            this.txtCantIniProd.Location = new System.Drawing.Point(220, 175);
            this.txtCantIniProd.Name = "txtCantIniProd";
            this.txtCantIniProd.Size = new System.Drawing.Size(274, 20);
            this.txtCantIniProd.TabIndex = 83;
            this.txtCantIniProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantIniProd_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 82;
            this.label4.Text = "Cantidad Inicial de Producto:";
            // 
            // ckbxImpuesto
            // 
            this.ckbxImpuesto.AutoSize = true;
            this.ckbxImpuesto.Location = new System.Drawing.Point(221, 215);
            this.ckbxImpuesto.Name = "ckbxImpuesto";
            this.ckbxImpuesto.Size = new System.Drawing.Size(151, 17);
            this.ckbxImpuesto.TabIndex = 84;
            this.ckbxImpuesto.Text = "Tributa Impuesto de Venta";
            this.ckbxImpuesto.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Fecha de Caducidad:";
            // 
            // dtpkFechCaduc
            // 
            this.dtpkFechCaduc.Location = new System.Drawing.Point(220, 278);
            this.dtpkFechCaduc.MinDate = new System.DateTime(2017, 12, 11, 21, 31, 11, 0);
            this.dtpkFechCaduc.Name = "dtpkFechCaduc";
            this.dtpkFechCaduc.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechCaduc.TabIndex = 86;
            this.dtpkFechCaduc.Value = new System.DateTime(2017, 12, 11, 21, 31, 11, 0);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(554, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 122);
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 88;
            this.label8.Text = "Fecha de Creacion:";
            // 
            // dtpkFechCreac
            // 
            this.dtpkFechCreac.Location = new System.Drawing.Point(219, 306);
            this.dtpkFechCreac.MinDate = new System.DateTime(2017, 12, 11, 0, 0, 0, 0);
            this.dtpkFechCreac.Name = "dtpkFechCreac";
            this.dtpkFechCreac.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechCreac.TabIndex = 89;
            this.dtpkFechCreac.Value = new System.DateTime(2017, 12, 11, 0, 0, 0, 0);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(220, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 43);
            this.btnGuardar.TabIndex = 90;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(406, 455);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 43);
            this.btnCancelar.TabIndex = 91;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpkFechModif
            // 
            this.dtpkFechModif.Location = new System.Drawing.Point(219, 335);
            this.dtpkFechModif.MinDate = new System.DateTime(2017, 12, 11, 0, 0, 0, 0);
            this.dtpkFechModif.Name = "dtpkFechModif";
            this.dtpkFechModif.Size = new System.Drawing.Size(200, 20);
            this.dtpkFechModif.TabIndex = 93;
            this.dtpkFechModif.Value = new System.DateTime(2017, 12, 11, 0, 0, 0, 0);
            // 
            // lblFechMod
            // 
            this.lblFechMod.AutoSize = true;
            this.lblFechMod.Location = new System.Drawing.Point(74, 335);
            this.lblFechMod.Name = "lblFechMod";
            this.lblFechMod.Size = new System.Drawing.Size(118, 13);
            this.lblFechMod.TabIndex = 92;
            this.lblFechMod.Text = "Fecha de Modificacion:";
            // 
            // txtUsuCreac
            // 
            this.txtUsuCreac.Location = new System.Drawing.Point(219, 362);
            this.txtUsuCreac.Name = "txtUsuCreac";
            this.txtUsuCreac.Size = new System.Drawing.Size(274, 20);
            this.txtUsuCreac.TabIndex = 95;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 94;
            this.label10.Text = "Usuario de Creacion:";
            // 
            // txtUsuModif
            // 
            this.txtUsuModif.Location = new System.Drawing.Point(219, 390);
            this.txtUsuModif.Name = "txtUsuModif";
            this.txtUsuModif.Size = new System.Drawing.Size(274, 20);
            this.txtUsuModif.TabIndex = 97;
            // 
            // lblUsuMod
            // 
            this.lblUsuMod.AutoSize = true;
            this.lblUsuMod.Location = new System.Drawing.Point(64, 390);
            this.lblUsuMod.Name = "lblUsuMod";
            this.lblUsuMod.Size = new System.Drawing.Size(124, 13);
            this.lblUsuMod.TabIndex = 96;
            this.lblUsuMod.Text = "Usuario de Modificacion:";
            // 
            // cmbBorradoLogico
            // 
            this.cmbBorradoLogico.AutoCompleteCustomSource.AddRange(new string[] {
            "Activar",
            "Inactivar"});
            this.cmbBorradoLogico.DisplayMember = "Activo";
            this.cmbBorradoLogico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorradoLogico.FormattingEnabled = true;
            this.cmbBorradoLogico.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbBorradoLogico.Location = new System.Drawing.Point(220, 421);
            this.cmbBorradoLogico.Name = "cmbBorradoLogico";
            this.cmbBorradoLogico.Size = new System.Drawing.Size(121, 21);
            this.cmbBorradoLogico.TabIndex = 101;
            // 
            // lblBorradoLogico
            // 
            this.lblBorradoLogico.AutoSize = true;
            this.lblBorradoLogico.Location = new System.Drawing.Point(109, 424);
            this.lblBorradoLogico.Name = "lblBorradoLogico";
            this.lblBorradoLogico.Size = new System.Drawing.Size(82, 13);
            this.lblBorradoLogico.TabIndex = 100;
            this.lblBorradoLogico.Text = "Borrado Logico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 104;
            this.label9.Text = "colones.";
            // 
            // txtPrecProdServ
            // 
            this.txtPrecProdServ.Location = new System.Drawing.Point(220, 252);
            this.txtPrecProdServ.Name = "txtPrecProdServ";
            this.txtPrecProdServ.Size = new System.Drawing.Size(274, 20);
            this.txtPrecProdServ.TabIndex = 103;
            this.txtPrecProdServ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecProdServ_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 255);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "Precio del Producto o Servicio:";
            // 
            // cmbxTipProd
            // 
            this.cmbxTipProd.AutoCompleteCustomSource.AddRange(new string[] {
            "Activar",
            "Inactivar"});
            this.cmbxTipProd.DisplayMember = "Activo";
            this.cmbxTipProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipProd.FormattingEnabled = true;
            this.cmbxTipProd.Items.AddRange(new object[] {
            "Producto",
            "Servicio"});
            this.cmbxTipProd.Location = new System.Drawing.Point(221, 119);
            this.cmbxTipProd.Name = "cmbxTipProd";
            this.cmbxTipProd.Size = new System.Drawing.Size(121, 21);
            this.cmbxTipProd.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(163, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 105;
            this.label12.Text = "Tipo:";
            // 
            // frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 506);
            this.Controls.Add(this.cmbxTipProd);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrecProdServ);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbBorradoLogico);
            this.Controls.Add(this.lblBorradoLogico);
            this.Controls.Add(this.txtUsuModif);
            this.Controls.Add(this.lblUsuMod);
            this.Controls.Add(this.txtUsuCreac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpkFechModif);
            this.Controls.Add(this.lblFechMod);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpkFechCreac);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtpkFechCaduc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ckbxImpuesto);
            this.Controls.Add(this.txtCantIniProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostRepIni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescProdServ);
            this.Controls.Add(this.txtCodProdServ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Producto";
            this.Text = "Pantalla Ingreso de Productos";
            this.Load += new System.EventHandler(this.frm_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescProdServ;
        private System.Windows.Forms.TextBox txtCodProdServ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCostRepIni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantIniProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbxImpuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkFechCaduc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpkFechCreac;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpkFechModif;
        private System.Windows.Forms.Label lblFechMod;
        private System.Windows.Forms.TextBox txtUsuCreac;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUsuModif;
        private System.Windows.Forms.Label lblUsuMod;
        private System.Windows.Forms.ComboBox cmbBorradoLogico;
        private System.Windows.Forms.Label lblBorradoLogico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecProdServ;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbxTipProd;
        private System.Windows.Forms.Label label12;
    }
}