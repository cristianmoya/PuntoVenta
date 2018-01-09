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
using DAL_VetSpa.Cat_Mant.Consulta;
using DAL_VetSpa.Cat_Mant.Seguridad;

namespace PL_VetSpa.Pantallas.Cat_Mant.Consulta
{
    public partial class frm_List_Exp_Paciente : Form
    {
        public frm_List_Exp_Paciente()
        {
            InitializeComponent();
        }

        #region Variables Globales

        cls_Exp_Pac_BLL Obj_Paciente_BLL = new cls_Exp_Pac_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        private void Cargar_Pacientes()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtPaciente = new DataTable();

            #endregion

            Obj_Paciente_BLL.Listar_Pacientes(ref dtPaciente, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Facturas.DataSource = null;
                dgv_Mostrar_Facturas.DataSource = dtPaciente;
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
            Cargar_Pacientes();
        }

        private void frm_List_Exp_Paciente_Load(object sender, EventArgs e)
        {
            Cargar_Pacientes();
        }
    }
}
