namespace PL_VetSpa.Generales
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmFact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnNuevFact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnConsFact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInve = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoAlCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevIngr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIngComp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsComp = new System.Windows.Forms.ToolStripMenuItem();
            this.salidasDeProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevSaliProd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsSalidProd = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKardex = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsCita = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteDelDueñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevExpDuen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsExpDuen = new System.Windows.Forms.ToolStripMenuItem();
            this.expedienteDelPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevExpPac = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsExpPac = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevHistClin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsHistClin = new System.Windows.Forms.ToolStripMenuItem();
            this.examenFisicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevExamFisi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsExamFisi = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticoORecetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevDiagRec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsDiagRec = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaOCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNuevConsCIt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConsConsCit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFact,
            this.tsmiInve,
            this.tsmiConsCita,
            this.tsmiSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmFact
            // 
            this.tsmFact.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnNuevFact,
            this.tsmnConsFact});
            this.tsmFact.Image = ((System.Drawing.Image)(resources.GetObject("tsmFact.Image")));
            this.tsmFact.Name = "tsmFact";
            this.tsmFact.Size = new System.Drawing.Size(97, 20);
            this.tsmFact.Text = "Facturacion";
            // 
            // tsmnNuevFact
            // 
            this.tsmnNuevFact.Image = ((System.Drawing.Image)(resources.GetObject("tsmnNuevFact.Image")));
            this.tsmnNuevFact.Name = "tsmnNuevFact";
            this.tsmnNuevFact.Size = new System.Drawing.Size(167, 22);
            this.tsmnNuevFact.Text = "Nueva Factura";
            this.tsmnNuevFact.Click += new System.EventHandler(this.tsmnNuevFact_Click);
            // 
            // tsmnConsFact
            // 
            this.tsmnConsFact.Image = ((System.Drawing.Image)(resources.GetObject("tsmnConsFact.Image")));
            this.tsmnConsFact.Name = "tsmnConsFact";
            this.tsmnConsFact.Size = new System.Drawing.Size(167, 22);
            this.tsmnConsFact.Text = "Consultar Factura";
            this.tsmnConsFact.Click += new System.EventHandler(this.tsmnConsFact_Click);
            // 
            // tsmiInve
            // 
            this.tsmiInve.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoAlCatalogoToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.salidasDeProductoToolStripMenuItem,
            this.kardexToolStripMenuItem});
            this.tsmiInve.Image = ((System.Drawing.Image)(resources.GetObject("tsmiInve.Image")));
            this.tsmiInve.Name = "tsmiInve";
            this.tsmiInve.Size = new System.Drawing.Size(93, 20);
            this.tsmiInve.Text = "Inventarios";
            // 
            // ingresoAlCatalogoToolStripMenuItem
            // 
            this.ingresoAlCatalogoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevIngr,
            this.tsmiConsItem});
            this.ingresoAlCatalogoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ingresoAlCatalogoToolStripMenuItem.Image")));
            this.ingresoAlCatalogoToolStripMenuItem.Name = "ingresoAlCatalogoToolStripMenuItem";
            this.ingresoAlCatalogoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresoAlCatalogoToolStripMenuItem.Text = "Ingreso al Catalogo";
            // 
            // tsmiNuevIngr
            // 
            this.tsmiNuevIngr.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevIngr.Image")));
            this.tsmiNuevIngr.Name = "tsmiNuevIngr";
            this.tsmiNuevIngr.Size = new System.Drawing.Size(194, 22);
            this.tsmiNuevIngr.Text = "Nuevo Ingreso";
            this.tsmiNuevIngr.Click += new System.EventHandler(this.nuevoIngresoToolStripMenuItem_Click);
            // 
            // tsmiConsItem
            // 
            this.tsmiConsItem.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsItem.Image")));
            this.tsmiConsItem.Name = "tsmiConsItem";
            this.tsmiConsItem.Size = new System.Drawing.Size(194, 22);
            this.tsmiConsItem.Text = "Consultas de Producto";
            this.tsmiConsItem.Click += new System.EventHandler(this.consultasDeProductoToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIngComp,
            this.tsmiConsComp});
            this.comprasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("comprasToolStripMenuItem.Image")));
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // tsmiIngComp
            // 
            this.tsmiIngComp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiIngComp.Image")));
            this.tsmiIngComp.Name = "tsmiIngComp";
            this.tsmiIngComp.Size = new System.Drawing.Size(167, 22);
            this.tsmiIngComp.Text = "Ingresar Compras";
            this.tsmiIngComp.Click += new System.EventHandler(this.ingresarComprasToolStripMenuItem_Click);
            // 
            // tsmiConsComp
            // 
            this.tsmiConsComp.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsComp.Image")));
            this.tsmiConsComp.Name = "tsmiConsComp";
            this.tsmiConsComp.Size = new System.Drawing.Size(167, 22);
            this.tsmiConsComp.Text = "Consultas";
            this.tsmiConsComp.Click += new System.EventHandler(this.consultasToolStripMenuItem6_Click);
            // 
            // salidasDeProductoToolStripMenuItem
            // 
            this.salidasDeProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevSaliProd,
            this.tsmiConsSalidProd});
            this.salidasDeProductoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salidasDeProductoToolStripMenuItem.Image")));
            this.salidasDeProductoToolStripMenuItem.Name = "salidasDeProductoToolStripMenuItem";
            this.salidasDeProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.salidasDeProductoToolStripMenuItem.Text = "Salidas de producto";
            // 
            // tsmiNuevSaliProd
            // 
            this.tsmiNuevSaliProd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevSaliProd.Image")));
            this.tsmiNuevSaliProd.Name = "tsmiNuevSaliProd";
            this.tsmiNuevSaliProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiNuevSaliProd.Text = "Nueva Salida";
            this.tsmiNuevSaliProd.Click += new System.EventHandler(this.nuevaSalidaToolStripMenuItem_Click);
            // 
            // tsmiConsSalidProd
            // 
            this.tsmiConsSalidProd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsSalidProd.Image")));
            this.tsmiConsSalidProd.Name = "tsmiConsSalidProd";
            this.tsmiConsSalidProd.Size = new System.Drawing.Size(142, 22);
            this.tsmiConsSalidProd.Text = "Consultas";
            this.tsmiConsSalidProd.Click += new System.EventHandler(this.consultasToolStripMenuItem7_Click);
            // 
            // kardexToolStripMenuItem
            // 
            this.kardexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKardex});
            this.kardexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kardexToolStripMenuItem.Image")));
            this.kardexToolStripMenuItem.Name = "kardexToolStripMenuItem";
            this.kardexToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.kardexToolStripMenuItem.Text = "Kardex";
            this.kardexToolStripMenuItem.Visible = false;
            // 
            // tsmiKardex
            // 
            this.tsmiKardex.Image = ((System.Drawing.Image)(resources.GetObject("tsmiKardex.Image")));
            this.tsmiKardex.Name = "tsmiKardex";
            this.tsmiKardex.Size = new System.Drawing.Size(153, 22);
            this.tsmiKardex.Text = "Generar Kardex";
            // 
            // tsmiConsCita
            // 
            this.tsmiConsCita.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expedienteDelDueñoToolStripMenuItem,
            this.expedienteDelPacienteToolStripMenuItem,
            this.historiaClinicaToolStripMenuItem,
            this.examenFisicoToolStripMenuItem,
            this.diagnosticoORecetaToolStripMenuItem,
            this.consultaOCitaToolStripMenuItem});
            this.tsmiConsCita.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsCita.Image")));
            this.tsmiConsCita.Name = "tsmiConsCita";
            this.tsmiConsCita.Size = new System.Drawing.Size(121, 20);
            this.tsmiConsCita.Text = "Consulta o Citas";
            // 
            // expedienteDelDueñoToolStripMenuItem
            // 
            this.expedienteDelDueñoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevExpDuen,
            this.tsmiConsExpDuen});
            this.expedienteDelDueñoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expedienteDelDueñoToolStripMenuItem.Image")));
            this.expedienteDelDueñoToolStripMenuItem.Name = "expedienteDelDueñoToolStripMenuItem";
            this.expedienteDelDueñoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.expedienteDelDueñoToolStripMenuItem.Text = "Expediente del Dueño";
            // 
            // tsmiNuevExpDuen
            // 
            this.tsmiNuevExpDuen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevExpDuen.Image")));
            this.tsmiNuevExpDuen.Name = "tsmiNuevExpDuen";
            this.tsmiNuevExpDuen.Size = new System.Drawing.Size(169, 22);
            this.tsmiNuevExpDuen.Text = "Nuevo Expediente";
            this.tsmiNuevExpDuen.Click += new System.EventHandler(this.nuevoExpedienteToolStripMenuItem_Click);
            // 
            // tsmiConsExpDuen
            // 
            this.tsmiConsExpDuen.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsExpDuen.Image")));
            this.tsmiConsExpDuen.Name = "tsmiConsExpDuen";
            this.tsmiConsExpDuen.Size = new System.Drawing.Size(169, 22);
            this.tsmiConsExpDuen.Text = "Consultas";
            this.tsmiConsExpDuen.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // expedienteDelPacienteToolStripMenuItem
            // 
            this.expedienteDelPacienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevExpPac,
            this.tsmiConsExpPac});
            this.expedienteDelPacienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expedienteDelPacienteToolStripMenuItem.Image")));
            this.expedienteDelPacienteToolStripMenuItem.Name = "expedienteDelPacienteToolStripMenuItem";
            this.expedienteDelPacienteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.expedienteDelPacienteToolStripMenuItem.Text = "Expediente del Paciente";
            // 
            // tsmiNuevExpPac
            // 
            this.tsmiNuevExpPac.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevExpPac.Image")));
            this.tsmiNuevExpPac.Name = "tsmiNuevExpPac";
            this.tsmiNuevExpPac.Size = new System.Drawing.Size(169, 22);
            this.tsmiNuevExpPac.Text = "Nuevo Expediente";
            this.tsmiNuevExpPac.Click += new System.EventHandler(this.nuevoExpedienteToolStripMenuItem1_Click);
            // 
            // tsmiConsExpPac
            // 
            this.tsmiConsExpPac.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsExpPac.Image")));
            this.tsmiConsExpPac.Name = "tsmiConsExpPac";
            this.tsmiConsExpPac.Size = new System.Drawing.Size(169, 22);
            this.tsmiConsExpPac.Text = "Consultas";
            this.tsmiConsExpPac.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevHistClin,
            this.tsmiConsHistClin});
            this.historiaClinicaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("historiaClinicaToolStripMenuItem.Image")));
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            this.historiaClinicaToolStripMenuItem.Visible = false;
            // 
            // tsmiNuevHistClin
            // 
            this.tsmiNuevHistClin.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevHistClin.Image")));
            this.tsmiNuevHistClin.Name = "tsmiNuevHistClin";
            this.tsmiNuevHistClin.Size = new System.Drawing.Size(152, 22);
            this.tsmiNuevHistClin.Text = "Nueva Historia";
            this.tsmiNuevHistClin.Click += new System.EventHandler(this.nuevaHistoriaToolStripMenuItem_Click);
            // 
            // tsmiConsHistClin
            // 
            this.tsmiConsHistClin.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsHistClin.Image")));
            this.tsmiConsHistClin.Name = "tsmiConsHistClin";
            this.tsmiConsHistClin.Size = new System.Drawing.Size(152, 22);
            this.tsmiConsHistClin.Text = "Consultas";
            this.tsmiConsHistClin.Click += new System.EventHandler(this.consultasToolStripMenuItem2_Click);
            // 
            // examenFisicoToolStripMenuItem
            // 
            this.examenFisicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevExamFisi,
            this.tsmiConsExamFisi});
            this.examenFisicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("examenFisicoToolStripMenuItem.Image")));
            this.examenFisicoToolStripMenuItem.Name = "examenFisicoToolStripMenuItem";
            this.examenFisicoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.examenFisicoToolStripMenuItem.Text = "Examen Fisico";
            this.examenFisicoToolStripMenuItem.Visible = false;
            // 
            // tsmiNuevExamFisi
            // 
            this.tsmiNuevExamFisi.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevExamFisi.Image")));
            this.tsmiNuevExamFisi.Name = "tsmiNuevExamFisi";
            this.tsmiNuevExamFisi.Size = new System.Drawing.Size(153, 22);
            this.tsmiNuevExamFisi.Text = "Nuevo Examen";
            this.tsmiNuevExamFisi.Click += new System.EventHandler(this.nuevoExamenToolStripMenuItem_Click);
            // 
            // tsmiConsExamFisi
            // 
            this.tsmiConsExamFisi.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsExamFisi.Image")));
            this.tsmiConsExamFisi.Name = "tsmiConsExamFisi";
            this.tsmiConsExamFisi.Size = new System.Drawing.Size(153, 22);
            this.tsmiConsExamFisi.Text = "Consultas";
            this.tsmiConsExamFisi.Click += new System.EventHandler(this.consultasToolStripMenuItem3_Click);
            // 
            // diagnosticoORecetaToolStripMenuItem
            // 
            this.diagnosticoORecetaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevDiagRec,
            this.tsmiConsDiagRec});
            this.diagnosticoORecetaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("diagnosticoORecetaToolStripMenuItem.Image")));
            this.diagnosticoORecetaToolStripMenuItem.Name = "diagnosticoORecetaToolStripMenuItem";
            this.diagnosticoORecetaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.diagnosticoORecetaToolStripMenuItem.Text = "Diagnostico o Receta";
            // 
            // tsmiNuevDiagRec
            // 
            this.tsmiNuevDiagRec.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevDiagRec.Image")));
            this.tsmiNuevDiagRec.Name = "tsmiNuevDiagRec";
            this.tsmiNuevDiagRec.Size = new System.Drawing.Size(175, 22);
            this.tsmiNuevDiagRec.Text = "Nuevo Diagnostico";
            this.tsmiNuevDiagRec.Click += new System.EventHandler(this.nuevoDiagnosticoToolStripMenuItem_Click);
            // 
            // tsmiConsDiagRec
            // 
            this.tsmiConsDiagRec.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsDiagRec.Image")));
            this.tsmiConsDiagRec.Name = "tsmiConsDiagRec";
            this.tsmiConsDiagRec.Size = new System.Drawing.Size(175, 22);
            this.tsmiConsDiagRec.Text = "Consultas";
            this.tsmiConsDiagRec.Click += new System.EventHandler(this.consultasToolStripMenuItem4_Click);
            // 
            // consultaOCitaToolStripMenuItem
            // 
            this.consultaOCitaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevConsCIt,
            this.tsmiConsConsCit});
            this.consultaOCitaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultaOCitaToolStripMenuItem.Image")));
            this.consultaOCitaToolStripMenuItem.Name = "consultaOCitaToolStripMenuItem";
            this.consultaOCitaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultaOCitaToolStripMenuItem.Text = "Consulta o Cita";
            // 
            // tsmiNuevConsCIt
            // 
            this.tsmiNuevConsCIt.Image = ((System.Drawing.Image)(resources.GetObject("tsmiNuevConsCIt.Image")));
            this.tsmiNuevConsCIt.Name = "tsmiNuevConsCIt";
            this.tsmiNuevConsCIt.Size = new System.Drawing.Size(158, 22);
            this.tsmiNuevConsCIt.Text = "Nueva Consulta";
            this.tsmiNuevConsCIt.Click += new System.EventHandler(this.nuevaConsultaToolStripMenuItem_Click);
            // 
            // tsmiConsConsCit
            // 
            this.tsmiConsConsCit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiConsConsCit.Image")));
            this.tsmiConsConsCit.Name = "tsmiConsConsCit";
            this.tsmiConsConsCit.Size = new System.Drawing.Size(158, 22);
            this.tsmiConsConsCit.Text = "Consultas";
            this.tsmiConsConsCit.Click += new System.EventHandler(this.consultasToolStripMenuItem5_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem2});
            this.tsmiSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsmiSalir.Image")));
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(57, 20);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem2
            // 
            this.salirToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem2.Image")));
            this.salirToolStripMenuItem2.Name = "salirToolStripMenuItem2";
            this.salirToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem2.Text = "Salir";
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 454);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Menu";
            this.Text = "Pantalla de Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmFact;
        private System.Windows.Forms.ToolStripMenuItem tsmnNuevFact;
        private System.Windows.Forms.ToolStripMenuItem tsmnConsFact;
        private System.Windows.Forms.ToolStripMenuItem tsmiInve;
        private System.Windows.Forms.ToolStripMenuItem ingresoAlCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevIngr;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiIngComp;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsComp;
        private System.Windows.Forms.ToolStripMenuItem salidasDeProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevSaliProd;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsSalidProd;
        private System.Windows.Forms.ToolStripMenuItem kardexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiKardex;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsCita;
        private System.Windows.Forms.ToolStripMenuItem expedienteDelDueñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevExpDuen;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsExpDuen;
        private System.Windows.Forms.ToolStripMenuItem expedienteDelPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevExpPac;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsExpPac;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevHistClin;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsHistClin;
        private System.Windows.Forms.ToolStripMenuItem examenFisicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevExamFisi;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsExamFisi;
        private System.Windows.Forms.ToolStripMenuItem diagnosticoORecetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevDiagRec;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsDiagRec;
        private System.Windows.Forms.ToolStripMenuItem consultaOCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevConsCIt;
        private System.Windows.Forms.ToolStripMenuItem tsmiConsConsCit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem2;

    }
}