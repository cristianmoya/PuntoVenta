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
    public partial class frm_List_Exp_Duen : Form
    {
        public frm_List_Exp_Duen()
        {
            InitializeComponent();
        }

        #region Variables Globales

        cls_Exp_Duen_BLL Obj_Exp_Duen_BLL = new cls_Exp_Duen_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        #region Cargar Expedientes

        private void Cargar_Expedientes()
        {
            #region Variables Locales

            string sMsjError = string.Empty;
            DataTable dtExpediente = new DataTable();

            #endregion

            Obj_Exp_Duen_BLL.Listar_Expedientes(ref dtExpediente, ref sMsjError);

            if (sMsjError == string.Empty)
            {
                dgv_Mostrar_Expedientes.DataSource = null;
                dgv_Mostrar_Expedientes.DataSource = dtExpediente;
            }
            else
            {
                dgv_Mostrar_Expedientes.DataSource = null;

                MessageBox.Show("Se presentó un error al Listar los Expedientes.\n\nDesc. Error = " + sMsjError,
                                "ERROR EN LISTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void tsbtn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tsbtn_Nuevo_Click(object sender, EventArgs e)
        {
            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Exp_Duen Expediente_Dueno =
            new Pantallas.Cat_Mant.Consulta.frm_Exp_Duen();
            DAL_VetSpa.Cat_Mant.Consulta.cls_Exp_Duen_DAL Obj_Exp_Duen_DAL =
            new DAL_VetSpa.Cat_Mant.Consulta.cls_Exp_Duen_DAL();
            Obj_Exp_Duen_DAL.cFlagAxion = 'I';
            Expediente_Dueno.Obj_Exp_Duen_DAL = Obj_Exp_Duen_DAL;
            Expediente_Dueno.Show();
        }

        private void tsbtn_Modificar_Click(object sender, EventArgs e)
        {

            PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Exp_Duen Modif_Exp_Duen =
            new PL_VetSpa.Pantallas.Cat_Mant.Consulta.frm_Exp_Duen();

            cls_Exp_Duen_DAL Obj_Exp_Duen_DAL = new cls_Exp_Duen_DAL();
            Obj_Exp_Duen_DAL.cFlagEstAxion = 'U';

            if (dgv_Mostrar_Expedientes.SelectedRows != null)
            {
                if (dgv_Mostrar_Expedientes.Rows.Count > 0)
                {
                    Obj_Exp_Duen_DAL.sIDDuen = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[0].Value.ToString().Trim();
                    Obj_Exp_Duen_DAL.sNombDuen = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[1].Value.ToString().Trim();
                    Obj_Exp_Duen_DAL.sCelular = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[2].Value.ToString().Trim();
                    Obj_Exp_Duen_DAL.sTelFijo = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[3].Value.ToString().Trim();
                    Obj_Exp_Duen_DAL.sDireccion = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[4].Value.ToString().Trim();
                    Obj_Exp_Duen_DAL.sCorreo = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[5].Value.ToString().Trim();
                    if (dgv_Mostrar_Expedientes.SelectedRows[0].Cells[6].Value.ToString().Trim() == "Activo")
                    {
                        Obj_Exp_Duen_DAL.bActivo = 1;
                    }
                    else
                    {
                        Obj_Exp_Duen_DAL.bActivo = 0;
                    }
                    if
                        (dgv_Mostrar_Expedientes.SelectedRows[0].Cells[7].Value.ToString().Trim() == null)
                    {
                        Obj_Exp_Duen_DAL.dtFechaCreac = DateTime.Now;
                    }
                    Obj_Exp_Duen_DAL.sUsuCreac = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[9].Value.ToString().Trim();
                    if
                        (dgv_Mostrar_Expedientes.SelectedRows[0].Cells[8].Value.ToString().Trim() == null)
                    {
                        Obj_Exp_Duen_DAL.dtFechaModif = DateTime.Now;
                    }

                    //Obj_Exp_Duen_DAL.dtFechaCreac = Convert.ToDateTime(dgv_Mostrar_Expedientes.SelectedRows[0].Cells[7].Value.ToString().Trim());
                     //Obj_Exp_Duen_DAL.dtFechaModif = Convert.ToDateTime(dgv_Mostrar_Expedientes.SelectedRows[0].Cells[8].Value.ToString().Trim());
                    Obj_Exp_Duen_DAL.sUsuModif = dgv_Mostrar_Expedientes.SelectedRows[0].Cells[10].Value.ToString().Trim();
                    Modif_Exp_Duen.Obj_Exp_Duen_DAL = Obj_Exp_Duen_DAL;
                    Modif_Exp_Duen.ShowDialog();
                    Cargar_Expedientes();
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

        private void tsbtn_Cargar_Click(object sender, EventArgs e)
        {
            Cargar_Expedientes();
        }
    }
}
