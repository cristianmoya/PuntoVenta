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
using BLL_VetSpa.Cat_Mant.Consulta;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Inventarios;
using DAL_VetSpa.Cat_Mant.Seguridad;
using DAL_VetSpa.Cat_Mant.Consulta;

namespace PL_VetSpa.Pantallas.Cat_Mant.Consulta
{
    public partial class frm_List_Citas : Form
    {
        public frm_List_Citas()
        {
            InitializeComponent();
        }

        cls_Cita_BLL Obj_Cita_BLL = new cls_Cita_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();
        private void tsbtn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cargar_Citas()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtCitas = new DataTable();

            #endregion

            Obj_Cita_BLL.Listar_Citas(ref dtCitas, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Facturas.DataSource = null;
                dgv_Mostrar_Facturas.DataSource = dtCitas;
            }
            else
            {
                dgv_Mostrar_Facturas.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Productos.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_List_Citas_Load(object sender, EventArgs e)
        {
            Cargar_Citas();
        }

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Cita Citas =
           new Pantallas.Cat_Mant.Consulta.frm_Cita();
            Citas.Show();
        }
    }
}
