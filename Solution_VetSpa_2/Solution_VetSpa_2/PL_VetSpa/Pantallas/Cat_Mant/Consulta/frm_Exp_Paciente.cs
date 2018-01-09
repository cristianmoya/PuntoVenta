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
    public partial class frm_Exp_Paciente : Form
    {
        public frm_Exp_Paciente()
        {
            InitializeComponent();
        }

        #region Variables Globales

        public cls_Exp_Pac_DAL Obj_Exp_Pac_DAL = new cls_Exp_Pac_DAL();
        cls_Exp_Pac_BLL Obj_Exp_Pac_BLL = new cls_Exp_Pac_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        #region Pintar Cotroles

        public void Pintar_Controles()
        {
            if (Obj_Exp_Pac_DAL.cFlagAxion == 'I')
            {
                txtIDPac.Text = string.Empty;
                txtIDDuen.Text = string.Empty;
                txtConsPac.Text = string.Empty;
                txtNomPac.Text = string.Empty;
                cmbbxEspecie.ValueMember = string.Empty;
                txtEdad.Text = string.Empty;
                txtRaza.Text = string.Empty;
                cmbbxSexo.ValueMember = string.Empty;
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
                txtIDPac.Text = Obj_Exp_Pac_DAL.sIDPaciente.ToString();
                txtIDDuen.Text = Obj_Exp_Pac_DAL.sIDDuen;
                txtConsPac.Text = Obj_Exp_Pac_DAL.iConsPac.ToString();
                txtNomPac.Text = Obj_Exp_Pac_DAL.sNombPac.ToString();
                switch (Obj_Exp_Pac_DAL.iEspecie)
	            {
                    case 1:
                        cmbbxEspecie.SelectedValue.Equals("Canino");
                        break;
                    case 2:
                        cmbbxEspecie.SelectedValue.Equals("Felino");
                        break;
                    case 3:
                        cmbbxEspecie.SelectedValue.Equals("Roedor");
                        break;
		            default:
                        cmbbxEspecie.SelectedValue.Equals("Indefinido");
                        break;
	            }
                txtEdad.Text = Obj_Exp_Pac_DAL.dEdad.ToString();
                txtRaza.Text = Obj_Exp_Pac_DAL.sRaza.ToString();
                cmbbxSexo.SelectedValue.Equals(Obj_Exp_Pac_DAL.iSexo);
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = Obj_Exp_Pac_DAL.dtFechaCreac;
                txtUsuCreac.Text = Obj_Exp_Pac_DAL.sUsuCreac;
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

        private void frm_Exp_Paciente_Load(object sender, EventArgs e)
        {
            Pintar_Controles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string sMsjError = string.Empty;

            if (Obj_Exp_Pac_DAL.cFlagAxion == 'I')
            {
                if (txtIDPac.Text != string.Empty || txtIDDuen.Text != string.Empty || txtConsPac.Text != string.Empty
                    || txtNomPac.Text != string.Empty || txtEdad.Text != string.Empty || txtRaza.Text != string.Empty)
                {
                    Obj_Exp_Pac_DAL.sIDPaciente = txtIDPac.Text.Trim();
                    Obj_Exp_Pac_DAL.sIDDuen = txtIDDuen.Text.Trim();
                    Obj_Exp_Pac_DAL.iConsPac = Convert.ToInt32(txtConsPac.Text.ToString().Trim());
                    Obj_Exp_Pac_DAL.sNombPac = txtNomPac.Text.ToString().Trim();
                    if (cmbbxEspecie.SelectedValue.ToString() == "Canino")
                    {
                        Obj_Exp_Pac_DAL.iEspecie = 1;
                    }
                    if (cmbbxEspecie.SelectedValue.ToString() == "Felino")
                    {
                        Obj_Exp_Pac_DAL.iEspecie = 2;
                    }
                    else
                    {
                        Obj_Exp_Pac_DAL.iEspecie = 3;
                    }
                    Obj_Exp_Pac_DAL.dEdad = Convert.ToDecimal(txtEdad.Text.ToString().Trim());
                    Obj_Exp_Pac_DAL.sRaza = txtRaza.Text.ToString().Trim();

                    Obj_Exp_Pac_DAL.sUsuCreac = Obj_Usuario_Logueado_DAL.sUsuario;
                    Obj_Exp_Pac_DAL.dtFechaCreac = dtpkFechCreac.Value;
                    Obj_Exp_Pac_DAL.bActivo = 1;
                    Obj_Exp_Pac_BLL.Crear_Expedientes(ref Obj_Exp_Pac_DAL, ref sMsjError);

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
                Obj_Exp_Pac_DAL.sUsuModif = Obj_Usuario_Logueado_DAL.sUsuario;
                Obj_Exp_Pac_DAL.dtFechaModif = dtpkFechCreac.Value;
                if (cmbBorradoLogico.ValueMember == "Activo")
                {
                    Obj_Exp_Pac_DAL.bActivo = 1;
                }
                else
                {
                    Obj_Exp_Pac_DAL.bActivo = 0;
                }

                Obj_Exp_Pac_BLL.Modificar_Expedientes(ref Obj_Exp_Pac_DAL, sMsjError);

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

        private void txtIDPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIDDuen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtConsPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNomPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsLetter(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsLetter(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete))//||
                                                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
