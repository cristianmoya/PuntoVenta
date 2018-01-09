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
using BLL_VetSpa.Cat_Mant.Inventarios;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Inventarios;

namespace PL_VetSpa.Pantallas.Cat_Mant.Inventarios
{
    public partial class frm_List_Entradas : Form
    {
        public frm_List_Entradas()
        {
            InitializeComponent();
        }

        #region Variables Globales

        cls_Entrada_Prod_BLL Obj_Entradas_BLL = new cls_Entrada_Prod_BLL();

        #endregion

        private void Cargar_Entradas()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtFacturas = new DataTable();

            #endregion

            Obj_Entradas_BLL.Listar_Entradas(ref dtFacturas, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Entradas.DataSource = null;
                dgv_Mostrar_Entradas.DataSource = dtFacturas;
            }
            else
            {
                dgv_Mostrar_Entradas.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Productos.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_List_Entradas_Load(object sender, EventArgs e)
        {
            Cargar_Entradas();
        }

        private void tsbtn_Cargar_Click(object sender, EventArgs e)
        {
            Cargar_Entradas();
        }

        private void tsbtn_Modificar_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_List_Fact Modif_Entradas =
            new PL_VetSpa.Pantallas.Cat_Mant.Facturacion.frm_List_Fact();

            cls_Producto_DAL Obj_Producto_DAL = new cls_Producto_DAL();
            Obj_Producto_DAL.cFlagEstAxion = 'U';

            if (dgv_Mostrar_Entradas.SelectedRows != null)
            {
                if (dgv_Mostrar_Entradas.Rows.Count > 0)
                {
                    Obj_Producto_DAL.iCodArt = Convert.ToInt32(dgv_Mostrar_Entradas.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    Obj_Producto_DAL.bActivo = Convert.ToByte(dgv_Mostrar_Entradas.SelectedRows[0].Cells[8].Value.ToString().Trim());
                    Obj_Producto_DAL.sUsuModif = dgv_Mostrar_Entradas.SelectedRows[0].Cells[12].Value.ToString().Trim();
                    Obj_Producto_DAL.dtFechaModif = Convert.ToDateTime(dgv_Mostrar_Entradas.SelectedRows[0].Cells[13].Value.ToString().Trim());
                    Modif_Entradas.ShowDialog();
                    Cargar_Entradas();
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

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Entradas Entradas =
            new Pantallas.Cat_Mant.Inventarios.frm_Entradas();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Entrada_Prod_DAL Obj_Entrada_Producto_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Entrada_Prod_DAL();
            Obj_Entrada_Producto_DAL.cFlagAxion = 'I';
            Entradas.Obj_Entrada_Producto_DAL = Obj_Entrada_Producto_DAL;
            Entradas.Show();
        }
    }
}
