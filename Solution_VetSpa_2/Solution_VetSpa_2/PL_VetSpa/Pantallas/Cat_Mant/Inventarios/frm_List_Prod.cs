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
using DAL_VetSpa.Cat_Mant.Seguridad;

namespace PL_VetSpa.Pantallas.Cat_Mant.Inventarios
{
    public partial class frm_List_Prod : Form
    {
        public frm_List_Prod()
        {
            InitializeComponent();
        }

        #region Variables Globales

        cls_Producto_BLL Obj_Producto_BLL = new cls_Producto_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        private void tsbtn_Cargar_Click(object sender, EventArgs e)
        {
            Cargar_Productos();
        }

        private void Cargar_Productos()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtFacturas = new DataTable();

            #endregion

            Obj_Producto_BLL.Listar_Productos(ref dtFacturas, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Productos.DataSource = null;
                dgv_Mostrar_Productos.DataSource = dtFacturas;
            }
            else
            {
                dgv_Mostrar_Productos.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Productos.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Filtrar_Productos()
        {
            if (txt_filtar.Text.Trim() == string.Empty)
            {
                Cargar_Productos();
            }
            else
            {
                DataTable dtProductos = new DataTable();
                string sMsjError = string.Empty;

                Obj_Producto_BLL.Filtrar_Productos(ref dtProductos, txt_filtar.Text.Trim(), ref sMsjError);

                if (sMsjError == string.Empty)
                {
                    dgv_Mostrar_Productos.DataSource = null;
                    dgv_Mostrar_Productos.DataSource = dtProductos;
                }

                else
                {
                    dgv_Mostrar_Productos.DataSource = null;

                    MessageBox.Show("Se presentó un error al Filtrar los Productos.\n\nDesc. Error = " + sMsjError,
                    "ERROR EN LISTAR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void tsbtn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtn_Nuevo_Click_1(object sender, EventArgs e)
        {
            PL_VetSpa.Inventarios.frm_Producto Producto = new PL_VetSpa.Inventarios.frm_Producto();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Producto_DAL Obj_Producto_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Producto_DAL();
            Obj_Producto_DAL.cFlagAxion = 'I';
            Producto.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
            Producto.Obj_Producto_DAL = Obj_Producto_DAL;
            Producto.Show();
        }

        private void tsbtn_Modificar_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Inventarios.frm_Producto Modif_Prod =
            new PL_VetSpa.Inventarios.frm_Producto();

            cls_Producto_DAL Obj_Producto_DAL = new cls_Producto_DAL();
            Obj_Producto_DAL.cFlagEstAxion = 'U';

            if (dgv_Mostrar_Productos.SelectedRows != null)
            {
                if (dgv_Mostrar_Productos.Rows.Count > 0)
                {
                    Obj_Producto_DAL.iCodArt = Convert.ToInt32(dgv_Mostrar_Productos.SelectedRows[0].Cells[0].Value.ToString().Trim());
                    Obj_Producto_DAL.sDescArt = dgv_Mostrar_Productos.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    Obj_Producto_DAL.fCostArt = Convert.ToInt64(dgv_Mostrar_Productos.SelectedRows[0].Cells[2].Value.ToString().Trim());
                    if (dgv_Mostrar_Productos.SelectedRows[0].Cells[3].Value.ToString().Trim() == "true")
                    {
                        Obj_Producto_DAL.bImpuArt = 1;
                    }
                    else
                    {
                        Obj_Producto_DAL.bImpuArt = 0;
                    }
                    Obj_Producto_DAL.fPrecArt = Convert.ToInt64(dgv_Mostrar_Productos.SelectedRows[0].Cells[4].Value.ToString().Trim());
                    Obj_Producto_DAL.dtFechaCaduc = Convert.ToDateTime(dgv_Mostrar_Productos.SelectedRows[0].Cells[5].Value.ToString().Trim());
                    Obj_Producto_DAL.iCantProd = Convert.ToInt32(dgv_Mostrar_Productos.SelectedRows[0].Cells[6].Value.ToString().Trim());
                    Obj_Producto_DAL.cTipArt = Convert.ToChar(dgv_Mostrar_Productos.SelectedRows[0].Cells[7].Value.ToString().Trim());
                    Obj_Producto_DAL.sUsuCreac = dgv_Mostrar_Productos.SelectedRows[0].Cells[8].Value.ToString().Trim();
                    Obj_Producto_DAL.dtFechaCreac = Convert.ToDateTime(dgv_Mostrar_Productos.SelectedRows[0].Cells[9].Value.ToString().Trim());
                    Obj_Producto_DAL.sUsuModif = dgv_Mostrar_Productos.SelectedRows[0].Cells[10].Value.ToString().Trim();
                    if (dgv_Mostrar_Productos.SelectedRows[0].Cells[11].Value.ToString().Trim() == null)
                    {
                        Obj_Producto_DAL.dtFechaModif = DateTime.Now;
                    }
                    if (dgv_Mostrar_Productos.SelectedRows[0].Cells[12].Value.ToString().Trim() == "Activo")
                    {
                        Obj_Producto_DAL.bActivo = 1;
                    }
                    else
                    {
                        Obj_Producto_DAL.bActivo = 0;
                    }
                    Modif_Prod.Obj_Producto_DAL = Obj_Producto_DAL;
                    Modif_Prod.Obj_Usuario_Logueado_DAL = Obj_Usuario_Logueado_DAL;
                    Modif_Prod.ShowDialog();
                    Cargar_Productos();
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

        private void tsbtn_salir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_List_Prod_Load(object sender, EventArgs e)
        {
            Cargar_Productos();
        }
    }
}
