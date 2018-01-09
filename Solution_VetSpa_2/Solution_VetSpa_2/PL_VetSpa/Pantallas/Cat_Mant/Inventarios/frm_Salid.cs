using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_VetSpa.Cat_Mant.Inventarios;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Seguridad;
using BLL_VetSpa.Cat_Mant.Inventarios;
using BLL_VetSpa.BD;

namespace PL_VetSpa.Pantallas.Cat_Mant.Inventarios
{
    public partial class frm_Salid : Form
    {
        public frm_Salid()
        {
            InitializeComponent();
        }

        #region Variables Globales

        public cls_Salidas_DAL Obj_Salidas_DAL = new cls_Salidas_DAL();
        cls_Salidas_BLL Obj_Salidas_BLL = new cls_Salidas_BLL();
        cls_Usuario_DAL Obj_Usuario_DAL = new cls_Usuario_DAL();

        #endregion

        public void Pintar_Controles()
        {
            if (Obj_Salidas_DAL.cFlagAxion == 'I')
            {
                txtCodProd.Text = string.Empty;
                txtDescProd.Text = string.Empty;
                txtNumDoc.Text = string.Empty;
                txtCant.Text = string.Empty;
                txtCostEgre.Enabled = true;
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = DateTime.Now;
                txtUsuCreac.Text = Obj_Usuario_DAL.sNombEmpl;
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
                txtCodProd.Text = Obj_Salidas_DAL.iCodArt.ToString();
                txtDescProd.Text = Obj_Salidas_DAL.sDescArt;
                txtNumDoc.Text = Obj_Salidas_DAL.sNumDoc.ToString();
                txtCant.Text = Obj_Salidas_DAL.dCantProd.ToString();
                txtCostEgre.Text = Obj_Salidas_DAL.dCostIngr.ToString();
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = Obj_Salidas_DAL.dtFechaCreac;
                txtUsuCreac.Text = Obj_Usuario_DAL.sNombEmpl;
                txtUsuCreac.Enabled = false;
                txtUsuCreac.ReadOnly = true;
                lblFechMod.Visible = true;
                dtpkFechModif.Visible = true;
                dtpkFechModif.Value = DateTime.Now;
                lblUsuMod.Visible = true;
                txtUsuModif.Visible = true;
                lblBorradoLogico.Visible = true;
                cmbBorradoLogico.Visible = true;
            }
        }

        private void frm_Salid_Load(object sender, EventArgs e)
        {
            Pintar_Controles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;

            if (Obj_Salidas_DAL.cFlagAxion == 'I')
            {
                if (txtCodProd.Text != string.Empty || txtDescProd.Text != string.Empty || txtNumDoc.Text != string.Empty ||
                    txtCostEgre.Text != string.Empty || txtCant.Text != string.Empty)
                {
                    Obj_Salidas_DAL.iCodArt = Convert.ToInt32(txtCodProd.Text.Trim());
                    Obj_Salidas_DAL.sDescArt = txtDescProd.Text.Trim();
                    Obj_Salidas_DAL.sNumDoc = txtNumDoc.Text.Trim();
                    Obj_Salidas_DAL.dCostIngr = Convert.ToDecimal(txtCostEgre.Text.ToString().Trim());
                    Obj_Salidas_DAL.dCantProd = Convert.ToDecimal(txtCant.Text.ToString().Trim());
                    Obj_Salidas_DAL.sUsuCreac = Obj_Usuario_DAL.sNombUsua;
                    Obj_Salidas_DAL.dtFechaCreac = dtpkFechCreac.Value;
                    Obj_Salidas_DAL.bActivo = 1;
                    Obj_Salidas_BLL.Crear_Salida(ref Obj_Salidas_DAL, ref sMsjError);

                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Felicidades los datos se han insertado correctamente", "INSERTAR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al insertar una nueva Carrera" + " [" + sMsjError + " ]", "ERROR",
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
                Obj_Salidas_DAL.sUsuModif = Obj_Usuario_DAL.sNombUsua;
                Obj_Salidas_DAL.dtFechaModif = dtpkFechCreac.Value;
                if (cmbBorradoLogico.ValueMember == "Activo")
                {
                    Obj_Salidas_DAL.bActivo = 1;
                }
                else
                {
                    Obj_Salidas_DAL.bActivo = 0;
                }

                Obj_Salidas_BLL.Modificar_Salidas(ref Obj_Salidas_DAL, sMsjError);

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

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
             (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

               if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDescProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == (char)',') || //coma decimal
                 (e.KeyChar == (char)'.')) //no permite poner (punto)
                {
                    e.Handled = true;
                }
                else

                   if (((char.IsLetter(e.KeyChar))) ||
                (((char.IsNumber(e.KeyChar))) ||//isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))) //||
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == (char)',') || //coma decimal
                 (e.KeyChar == (char)'.')) //no permite poner (punto)
                {
                    e.Handled = true;
                }
                else

                   if ((char.IsNumber(e.KeyChar)) ||//isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))//||
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == (char)',') || //coma decimal
                 (e.KeyChar == (char)'.')) //no permite poner (punto)
                {
                    e.Handled = true;
                }
                else

                   if ((char.IsNumber(e.KeyChar)) ||//isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))//||
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txtCostEgre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar == (char)',') || //coma decimal
                 (e.KeyChar == (char)'.')) //no permite poner (punto)
                {
                    e.Handled = true;
                }
                else

                   if ((char.IsNumber(e.KeyChar)) ||//isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))//||
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
}
