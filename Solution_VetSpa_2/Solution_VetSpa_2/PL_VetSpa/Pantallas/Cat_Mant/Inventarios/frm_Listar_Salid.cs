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
    public partial class frm_Listar_Salid : Form
    {
        public frm_Listar_Salid()
        {
            InitializeComponent();
        }
        cls_Salidas_BLL Obj_Salidas_BLL = new cls_Salidas_BLL();

        private void Cargar_Salidas()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtSalidas = new DataTable();

            #endregion

            Obj_Salidas_BLL.Listar_Salidas(ref dtSalidas, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Facturas.DataSource = null;
                dgv_Mostrar_Facturas.DataSource = dtSalidas;
            }
            else
            {
                dgv_Mostrar_Facturas.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Productos.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtn_Cargar_Click(object sender, EventArgs e)
        {
            Cargar_Salidas();
        }

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Inventarios.frm_Salid Salidas =
            new Pantallas.Cat_Mant.Inventarios.frm_Salid();
            DAL_VetSpa.Cat_Mant.Inventarios.cls_Salidas_DAL Obj_Salidas_DAL =
            new DAL_VetSpa.Cat_Mant.Inventarios.cls_Salidas_DAL();
            Obj_Salidas_DAL.cFlagAxion = 'I';
            Salidas.Obj_Salidas_DAL = Obj_Salidas_DAL;
            Salidas.Show();
        }

        private void frm_Listar_Salid_Load(object sender, EventArgs e)
        {
            Cargar_Salidas();
        }
    }
}
