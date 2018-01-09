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

namespace PL_VetSpa.Inventarios
{
    public partial class frm_Producto : Form
    {
        public frm_Producto()
        {
            InitializeComponent();
        }

        #region Variables Globales

        public cls_Producto_DAL Obj_Producto_DAL = new cls_Producto_DAL();
        cls_Producto_BLL Obj_Producto_BLL = new cls_Producto_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        public void Pintar_Controles()
        {
            if (Obj_Producto_DAL.cFlagAxion == 'I')
            {
                txtCodProdServ.Text = string.Empty;
                txtDescProdServ.Text = string.Empty;
                cmbxTipProd.Enabled = true;
                txtCostRepIni.Text = string.Empty;
                txtCantIniProd.Text = string.Empty;
                ckbxImpuesto.Enabled = true;
                dtpkFechCaduc.Enabled = true;
                dtpkFechCaduc.Value = DateTime.Now;
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
                txtCodProdServ.Text = Obj_Producto_DAL.iCodArt.ToString();
                txtDescProdServ.Text = Obj_Producto_DAL.sDescArt;
                if (Obj_Producto_DAL.cTipArt == 'P' || Obj_Producto_DAL.cTipArt == 'p')
                {
                    cmbxTipProd.SelectedText = "Producto";
                }
                if (Obj_Producto_DAL.cTipArt == 'S' || Obj_Producto_DAL.cTipArt == 's')
                {
                    cmbxTipProd.SelectedText = "Servicio";
                }
                cmbxTipProd.Enabled = true;
                txtCostRepIni.Text = Obj_Producto_DAL.fCostArt.ToString();
                txtCantIniProd.Text = Obj_Producto_DAL.iCantProd.ToString();
                ckbxImpuesto.Enabled = false;
                if (Obj_Producto_DAL.bImpuArt == 1)
                {
                    ckbxImpuesto.Checked = true;
                }
                else
                {
                    ckbxImpuesto.Checked = false;
                }
                txtPrecProdServ.Text = Obj_Producto_DAL.fPrecArt.ToString();
                dtpkFechCaduc.Enabled = false;
                dtpkFechCaduc.Value = Obj_Producto_DAL.dtFechaCaduc;
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = Obj_Producto_DAL.dtFechaCreac;
                txtUsuCreac.Text = Obj_Producto_DAL.sUsuCreac;
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frm_Producto_Load(object sender, EventArgs e)
        {
            Pintar_Controles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;

            if (Obj_Producto_DAL.cFlagAxion == 'I')
            {
                if (txtCodProdServ.Text != string.Empty || txtDescProdServ.Text != string.Empty || 
                    txtCostRepIni.Text != string.Empty || txtCantIniProd.Text != string.Empty)
                {
                    Obj_Producto_DAL.iCodArt = Convert.ToInt32(txtCodProdServ.Text.Trim());
                    Obj_Producto_DAL.sDescArt = txtDescProdServ.Text.Trim();
                    if (cmbxTipProd.SelectedItem.ToString() == "Producto")
                    {
                        Obj_Producto_DAL.cTipArt = 'P';
                    }
                    if (cmbxTipProd.SelectedItem.ToString() == "Servicio")
                    {
                        Obj_Producto_DAL.cTipArt = 'S';
                    }
                    Obj_Producto_DAL.fCostArt = Convert.ToInt64(txtCostRepIni.Text.ToString().Trim());
                    Obj_Producto_DAL.iCantProd = Convert.ToInt32(txtCantIniProd.Text.ToString().Trim());
                    if (dtpkFechCaduc.Value <= DateTime.Now)
                    {
                        MessageBox.Show("La fecha de Caducidad no puede menor a la fecha actual.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);                        
                    }
                    else
                    {
                        Obj_Producto_DAL.dtFechaCaduc = dtpkFechCaduc.Value; 
                    }
                    Obj_Producto_DAL.dtFechaCaduc = dtpkFechCaduc.Value;
                    if (ckbxImpuesto.Checked == true)
                    {
                        Obj_Producto_DAL.bImpuArt = 1;
                    }
                    else
                    {
                        Obj_Producto_DAL.bImpuArt = 0;
                    }
                    Obj_Producto_DAL.sUsuCreac = Obj_Usuario_Logueado_DAL.sUsuario;
                    Obj_Producto_DAL.dtFechaCreac = dtpkFechCreac.Value;
                    Obj_Producto_DAL.bActivo = 1;
                    Obj_Producto_BLL.Crear_Productos(ref Obj_Producto_DAL, ref sMsjError);

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
                Obj_Producto_DAL.sUsuModif = Obj_Usuario_Logueado_DAL.sUsuario;
                Obj_Producto_DAL.dtFechaModif = dtpkFechCreac.Value;
                if (cmbBorradoLogico.ValueMember == "Activo")
                {
                    Obj_Producto_DAL.bActivo = 1;
                }
                else
                {
                    Obj_Producto_DAL.bActivo = 0;                    
                }

                Obj_Producto_BLL.Modificar_Productos(ref Obj_Producto_DAL, sMsjError);

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

        private void txtCodProdServ_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDescProdServ_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCostRepIni_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCantIniProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecProdServ_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
