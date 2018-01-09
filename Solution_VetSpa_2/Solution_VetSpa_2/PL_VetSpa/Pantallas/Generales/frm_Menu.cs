using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_VetSpa;
using DAL_VetSpa;
using DAL_VetSpa.Cat_Mant.Facturacion;
using PL_VetSpa.Pantallas.Cat_Mant.Facturacion;

namespace PL_VetSpa.Generales
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        #region Variables Publicas

        public DAL_VetSpa.Cat_Mant.Seguridad.cls_Login_DAL Obj_Usuario_Logueado_DAL = new DAL_VetSpa.Cat_Mant.Seguridad.cls_Login_DAL();

        #endregion

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void tsmnNuevFact_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_Fact Facturas = new frm_Fact();
            cls_Factura_DAL Obj_Facturas_DAL = new cls_Factura_DAL();
            Obj_Facturas_DAL.cFlagAxion = 'I';
            /*          Facturas.Obj_Facturas_DAL = Obj_Facturas_DAL;*/
            Facturas.ShowDialog();
        }

        private void tsmnConsFact_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_List_Fact List_Fact = 
            new PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_List_Fact();
            DAL_VetSpa.Cat_Mant.Facturacion.cls_Factura_DAL Obj_Factura_DAL =
            new DAL_VetSpa.Cat_Mant.Facturacion.cls_Factura_DAL();
            Obj_Factura_DAL.cFlagAxion = 'U';
            /*List_Fact.Obj_Factura_DAL = Obj_Factura_DAL;*/
            List_Fact.Show();
        }

        private void nuevoIngresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Inventarios.frm_Producto Producto = 
            new PL_VetSpa.Inventarios.frm_Producto();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Producto_DAL Obj_Producto_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Producto_DAL();
            Obj_Producto_DAL.cFlagAxion = 'I';
            Producto.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
            Producto.Obj_Producto_DAL = Obj_Producto_DAL;
            Producto.Show();
        }

        private void frm_Menu_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void consultasDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_List_Prod List_Prod = 
            new PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_List_Prod();
            List_Prod.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
            List_Prod.Show();
        }

        private void ingresarComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Entradas Entradas =
            new Pantallas.Cat_Mant.Inventarios.frm_Entradas();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Entrada_Prod_DAL Obj_Entrada_Producto_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Entrada_Prod_DAL();
            Obj_Entrada_Producto_DAL.cFlagAxion = 'I';
            Entradas.Obj_Entrada_Producto_DAL = Obj_Entrada_Producto_DAL;
            Entradas.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
            Entradas.Show();
        }

        private void consultasToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_List_Entradas Listar_Entradas =
            new Pantallas.Cat_Mant.Inventarios.frm_List_Entradas();

            Listar_Entradas.Show();
        }

        private void nuevaSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Salid Salidas =
            new Pantallas.Cat_Mant.Inventarios.frm_Salid();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Salidas_DAL Obj_Salidas_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Salidas_DAL();
            Obj_Salidas_DAL.cFlagAxion = 'I';
            Salidas.Obj_Salidas_DAL = Obj_Salidas_DAL;
            Salidas.Show();
        }

        private void consultasToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Listar_Salid List_Salid =
            new PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Listar_Salid();
            List_Salid.Show();
        }

        private void nuevoExpedienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Exp_Duen Expediente_Dueno = 
            new Pantallas.Cat_Mant.Consulta.frm_Exp_Duen();
            DAL_VetSpa.Cat_Mant.Consulta.cls_Exp_Duen_DAL Obj_Exp_Duen_DAL = 
            new DAL_VetSpa.Cat_Mant.Consulta.cls_Exp_Duen_DAL();
            Obj_Exp_Duen_DAL.cFlagAxion = 'I';
            Expediente_Dueno.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
            Expediente_Dueno.Obj_Exp_Duen_DAL = Obj_Exp_Duen_DAL;
            Expediente_Dueno.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Exp_Duen List_Expediente_Dueno =
            new Pantallas.Cat_Mant.Consulta.frm_List_Exp_Duen();
            List_Expediente_Dueno.Show();
        }

        private void nuevoExpedienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Exp_Paciente Expediente_Paciente =
            new Pantallas.Cat_Mant.Consulta.frm_Exp_Paciente();
            Expediente_Paciente.Show();
        }

        private void consultasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Exp_Paciente Listar_Expediente_Paciente =
            new Pantallas.Cat_Mant.Consulta.frm_List_Exp_Paciente();
            Listar_Expediente_Paciente.Show();
        }

        private void nuevaHistoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Hitoria_Clinica Historia =
            new Pantallas.Cat_Mant.Consulta.frm_Hitoria_Clinica();
            Historia.Show();
        }

        private void consultasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Historial Historia =
            new Pantallas.Cat_Mant.Consulta.frm_List_Historial();
            Historia.Show();
        }

        private void nuevoExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Examen_Fisico Examen = 
            new Pantallas.Cat_Mant.Consulta.frm_Examen_Fisico();
            Examen.Show();
        }

        private void consultasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Examen_Fisico Listar_Examen =
            new Pantallas.Cat_Mant.Consulta.frm_List_Examen_Fisico();
            Listar_Examen.Show();
        }

        private void nuevoDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Diagnostico_Cita Diagnostico =
            new Pantallas.Cat_Mant.Consulta.frm_Diagnostico_Cita();
            Diagnostico.Show();
        }

        private void consultasToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Diag_Cita Listar_Diagnostico =
            new Pantallas.Cat_Mant.Consulta.frm_List_Diag_Cita();
            Listar_Diagnostico.Show();
        }

        private void nuevaConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Cita Citas =
            new Pantallas.Cat_Mant.Consulta.frm_Cita();
            Citas.Show();
        }

        private void consultasToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_List_Citas Listar_Citas =
            new Pantallas.Cat_Mant.Consulta.frm_List_Citas();
            Listar_Citas.Show();
        }
    }
}
