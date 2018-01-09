using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_VetSpa.Cat_Mant.Consulta;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Seguridad;
using BLL_VetSpa.Cat_Mant.Consulta;
using BLL_VetSpa.BD;

namespace PL_VetSpa.Pantallas.Cat_Mant.Consulta
{
    public partial class frm_Exp_Duen : Form
    {
        public frm_Exp_Duen()
        {
            InitializeComponent();
        }

        #region Variables Globales

        public cls_Exp_Duen_DAL Obj_Exp_Duen_DAL = new cls_Exp_Duen_DAL();
        cls_Exp_Duen_BLL Obj_Exp_Duen_BLL = new cls_Exp_Duen_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        #region Pintar Cotroles

        public void Pintar_Controles()
        {
            if (Obj_Exp_Duen_DAL.cFlagAxion == 'I')
            {
                txtIDDuen.Text = string.Empty;
                txtNombDuen.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtTelFijo.Text = string.Empty;
                txtDirExac.Text = string.Empty;
                txtEmail.Text = string.Empty;
                cmbStatus.Enabled = true;
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = DateTime.Now;
                txtUsuCreac.Text = Obj_Usuario_Logueado_DAL.sUsuario;
                txtUsuCreac.Enabled = false;
                txtUsuCreac.ReadOnly = true;
                lblFechMod.Visible = false;
                dtpkFechModif.Visible = false;
                lblUsuMod.Visible = false;
                txtUsuModif.Visible = false;
                lblBorradoLogico.Visible = false;
                cmbBorradoLogico.Visible = false;
            }
            else
            {
                txtIDDuen.Text = Obj_Exp_Duen_DAL.sIDDuen.ToString();
                txtNombDuen.Text = Obj_Exp_Duen_DAL.sNombDuen;
                txtCelular.Text = Obj_Exp_Duen_DAL.sCelular.ToString();
                txtTelFijo.Text = Obj_Exp_Duen_DAL.sTelFijo.ToString();
                txtDirExac.Text = Obj_Exp_Duen_DAL.sDireccion.ToString();
                txtEmail.Text = Obj_Exp_Duen_DAL.sCorreo.ToString();
                if (Obj_Exp_Duen_DAL.bActivo == 1)
                {
                    cmbStatus.SelectedText = "Activo";
                }
                if (Obj_Exp_Duen_DAL.bActivo == 0)
                {
                    cmbStatus.SelectedText = "Inactivo";
                }
                cmbStatus.Enabled = true;

                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = Obj_Exp_Duen_DAL.dtFechaCreac;
                txtUsuCreac.Text = Obj_Exp_Duen_DAL.sUsuCreac;
                txtUsuCreac.Enabled = false;
                txtUsuCreac.ReadOnly = true;
                lblFechMod.Visible = true;
                dtpkFechModif.Visible = true;
                dtpkFechModif.Value = DateTime.Now;
                dtpkFechModif.Enabled = false;
                lblUsuMod.Visible = true;
                txtUsuModif.Visible = true;
                txtUsuModif.Enabled = false;
                txtUsuModif.Text = Obj_Usuario_Logueado_DAL.sUsuario;
                lblBorradoLogico.Visible = true;
                cmbBorradoLogico.Visible = true;
            }
        }

        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_Exp_Duen_Load(object sender, EventArgs e)
        {
            Pintar_Controles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;

            if (Obj_Exp_Duen_DAL.cFlagAxion == 'I')
            {
                if (txtIDDuen.Text != string.Empty || txtNombDuen.Text != string.Empty || txtCelular.Text != string.Empty 
                    || txtTelFijo.Text != string.Empty || txtDirExac.Text != string.Empty || txtEmail.Text != string.Empty)
                {
                    Obj_Exp_Duen_DAL.sIDDuen = txtIDDuen.Text.Trim();
                    Obj_Exp_Duen_DAL.sNombDuen = txtNombDuen.Text.Trim();
                    Obj_Exp_Duen_DAL.sCelular = txtCelular.Text.ToString().Trim();
                    Obj_Exp_Duen_DAL.sTelFijo = txtTelFijo.Text.ToString().Trim();
                    Obj_Exp_Duen_DAL.sDireccion = txtDirExac.Text.ToString().Trim();
                    Obj_Exp_Duen_DAL.sCorreo = txtEmail.Text.ToString().Trim();
                    Obj_Exp_Duen_DAL.bActivo = 1;
                    Obj_Exp_Duen_DAL.sUsuCreac = Obj_Usuario_Logueado_DAL.sUsuario;
                    Obj_Exp_Duen_DAL.dtFechaCreac = dtpkFechCreac.Value;
                    
                    Obj_Exp_Duen_BLL.Crear_Expedientes(ref Obj_Exp_Duen_DAL, ref sMsjError);

                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Felicidades los datos se han insertado correctamente", "INSERTAR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al insertar el Producto" + " [" + sMsjError + " ]", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Pintar_Controles();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos solicitados", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Obj_Exp_Duen_DAL.sUsuModif = Obj_Usuario_Logueado_DAL.sUsuario;
                Obj_Exp_Duen_DAL.dtFechaModif = dtpkFechCreac.Value;
                if (cmbBorradoLogico.ValueMember == "Activo")
                {
                    Obj_Exp_Duen_DAL.bActivo = 1;
                }
                else
                {
                    Obj_Exp_Duen_DAL.bActivo = 0;
                }

                Obj_Exp_Duen_BLL.Modificar_Expedientes(ref Obj_Exp_Duen_DAL, sMsjError);

                if (sMsjError == string.Empty)
                {

                    MessageBox.Show("Felicidades los datos se han modificado correctamente", "MODIFICAR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos solicitados", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Pintar_Controles();
            }
        }
    }
}
