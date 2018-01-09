using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_VetSpa.BD;
using BLL_VetSpa.Cat_Mant.Facturacion;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Facturacion;

namespace PL_VetSpa.Pantallas.Cat_Mant.Facturacion
{
    public partial class frm_List_Fact : Form
    {
        public frm_List_Fact()
        {
            InitializeComponent();
        }

        #region Variables Globales

        cls_Factura_BLL Obj_Facturas_BLL = new cls_Factura_BLL();

        #endregion

        private void tsbtn_Cargar_Click(object sender, EventArgs e)
        {
            Cargar_Facturas();
        }

        private void Cargar_Facturas()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtFacturas = new DataTable();

            #endregion

            Obj_Facturas_BLL.Listar_Facturas(ref dtFacturas, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Facturas.DataSource = null;
                dgv_Mostrar_Facturas.DataSource = dtFacturas;
            }
            else
            {
                dgv_Mostrar_Facturas.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Productos.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Filtrar_Facturas()
        {
            if (txt_filtar.Text.Trim() == string.Empty)
            {
                Cargar_Facturas();
            }
            else
            {
                DataTable dtFacturas = new DataTable();
                string sMsjError = string.Empty;

                Obj_Facturas_BLL.Filtrar_Facturas(ref dtFacturas, txt_filtar.Text.Trim(), ref sMsjError);

                if (sMsjError == string.Empty)
                {
                    dgv_Mostrar_Facturas.DataSource = null;
                    dgv_Mostrar_Facturas.DataSource = dtFacturas;
                }

                else
                {
                    dgv_Mostrar_Facturas.DataSource = null;

                    MessageBox.Show("Se presentó un error al Filtrar los Productos.\n\nDesc. Error = " + sMsjError,
                    "ERROR EN LISTAR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_Fact Facturas = new frm_Fact();
            cls_Factura_DAL Obj_Facturas_DAL = new cls_Factura_DAL();
            Obj_Facturas_DAL.cFlagAxion = 'I';
  /*          Facturas.Obj_Facturas_DAL = Obj_Facturas_DAL;*/
            Facturas.ShowDialog();
        }

        private void tsbtn_Modificar_Click(object sender, EventArgs e)
        {

            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_Fact Modif_Fact = new PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_Fact();

            cls_Factura_DAL Obj_Facturas_DAL = new cls_Factura_DAL();
            Obj_Facturas_DAL.cFlagEstAxion = 'U';

            if (dgv_Mostrar_Facturas.SelectedRows != null)
            {
                if (dgv_Mostrar_Facturas.Rows.Count > 0)
                {
                    Obj_Facturas_DAL.iNumFact = Convert.ToInt32(dgv_Mostrar_Facturas.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    Obj_Facturas_DAL.bActivo = Convert.ToByte(dgv_Mostrar_Facturas.SelectedRows[0].Cells[1].Value.ToString().Trim());
                    Obj_Facturas_DAL.sUsuModif = dgv_Mostrar_Facturas.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    Obj_Facturas_DAL.dtFechaCreac = Convert.ToDateTime(dgv_Mostrar_Facturas.SelectedRows[0].Cells[3].Value.ToString().Trim());
                    if (dgv_Mostrar_Facturas.SelectedRows[0].Cells[9].Value.ToString().Trim() == string.Empty)
                    {
                        Obj_Facturas_DAL.dtFechaModif = DateTime.Now;
                    }
                    else
                    {
                        Obj_Facturas_DAL.dtFechaModif =
                        Convert.ToDateTime(dgv_Mostrar_Facturas.SelectedRows[0].Cells[9].Value.ToString().Trim());

                    }

/*                    Modif_Fact.Obj_Facturas_DAL = Obj_Facturas_DAL;*/
                    Modif_Fact.ShowDialog();
                    Cargar_Facturas();
                }
                else
                {
                    MessageBox.Show("No puede modificar valores ya que no hay nada seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("No puede modificar valores ya que no hay nada seleccionado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void tsbtn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtn_Cargar_Click_1(object sender, EventArgs e)
        {
            Cargar_Facturas();
        }

        private void tsbtn_Nuevo_Click_1(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_Fact Facturas = new frm_Fact();
            cls_Factura_DAL Obj_Facturas_DAL = new cls_Factura_DAL();
            Obj_Facturas_DAL.cFlagAxion = 'I';
            /*          Facturas.Obj_Facturas_DAL = Obj_Facturas_DAL;*/
            Facturas.ShowDialog();
        }

        private void tsbtn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void frm_List_Fact_Load(object sender, EventArgs e)
        {
            Cargar_Facturas();
        }
    }
}
