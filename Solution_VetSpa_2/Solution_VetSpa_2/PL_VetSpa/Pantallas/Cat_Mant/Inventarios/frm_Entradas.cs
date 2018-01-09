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
    public partial class frm_Entradas : Form
    {
        public frm_Entradas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Variables Globales

        public cls_Entrada_Prod_DAL Obj_Entrada_Producto_DAL = new cls_Entrada_Prod_DAL();
        cls_Entrada_Prod_BLL Obj_Entrada_Producto_BLL = new cls_Entrada_Prod_BLL();
        public cls_Login_DAL Obj_Usuario_Logueado_DAL = new cls_Login_DAL();

        #endregion

        public void Pintar_Controles()
        {
            if (Obj_Entrada_Producto_DAL.cFlagAxion == 'I')
            {
                txtCodProd.Text = string.Empty;
                txtDescProd.Text = string.Empty;
                txtNumDoc.Text = string.Empty;
                txtCantIniProd.Text = string.Empty;
                txtCostIngre.Enabled = true;
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
                txtCodProd.Text = Obj_Entrada_Producto_DAL.iCodArt.ToString();
                txtDescProd.Text = Obj_Entrada_Producto_DAL.sDescArt;
                txtNumDoc.Text = Obj_Entrada_Producto_DAL.sNumDoc.ToString();
                txtCantIniProd.Text = Obj_Entrada_Producto_DAL.iCantProd.ToString();
                txtCostIngre.Text = Obj_Entrada_Producto_DAL.fCostIngr.ToString();
                dtpkFechCreac.Visible = true;
                dtpkFechCreac.Enabled = false;
                dtpkFechCreac.Value = Obj_Entrada_Producto_DAL.dtFechaCreac;
                txtUsuCreac.Text = Obj_Entrada_Producto_DAL.sUsuCreac;
                txtUsuCreac.Enabled = false;
                txtUsuCreac.ReadOnly = true;
                lblFechMod.Visible = true;
                dtpkFechModif.Visible = true;
                dtpkFechModif.Value = DateTime.Now;
                lblUsuMod.Visible = true;
                txtUsuModif.Visible = true;
                txtUsuModif.Text = Obj_Usuario_Logueado_DAL.sUsuario;
                lblBorradoLogico.Visible = true;
                cmbBorradoLogico.Visible = true;
            }
        }

        private void frm_Entradas_Load(object sender, EventArgs e)
        {
            Pintar_Controles();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            if ((txtCodProd.Text.Trim() != string.Empty) &&
              (txtDescProd.Text.Trim() != string.Empty) &&
              (txtNumDoc.Text.Trim() != string.Empty) &&
              (txtCostIngre.Text.Trim() != string.Empty) &&
              (txtCantIniProd.Text.Trim() != string.Empty))


            {
                if (Obj_Entrada_Producto_DAL.cFlagAxion == 'I')
                {
                    if (txtCodProd.Text != string.Empty || txtDescProd.Text != string.Empty || txtNumDoc.Text != string.Empty ||
                        txtCostIngre.Text != string.Empty || txtCantIniProd.Text != string.Empty)
                    {
                        Obj_Entrada_Producto_DAL.iCodArt = Convert.ToInt32(txtCodProd.Text.Trim());
                        Obj_Entrada_Producto_DAL.sDescArt = txtDescProd.Text.Trim();
                        Obj_Entrada_Producto_DAL.sNumDoc = txtNumDoc.Text.Trim();
                        Obj_Entrada_Producto_DAL.fCostIngr = Convert.ToInt64(txtCostIngre.Text.ToString().Trim());
                        Obj_Entrada_Producto_DAL.iCantProd = Convert.ToInt32(txtCantIniProd.Text.ToString().Trim());
                        Obj_Entrada_Producto_DAL.sUsuCreac = Obj_Usuario_Logueado_DAL.sUsuario;
                        Obj_Entrada_Producto_DAL.dtFechaCreac = dtpkFechCreac.Value;
                        Obj_Entrada_Producto_DAL.bActivo = 1;
                        Obj_Entrada_Producto_BLL.Crear_Entrada(ref Obj_Entrada_Producto_DAL, ref sMsjError);

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
                    Obj_Entrada_Producto_DAL.sUsuModif = Obj_Entrada_Producto_DAL.sUsuCreac;
                    Obj_Entrada_Producto_DAL.dtFechaModif = dtpkFechCreac.Value;
                    if (cmbBorradoLogico.ValueMember == "Activo")
                    {
                        Obj_Entrada_Producto_DAL.bActivo = 1;
                    }
                    else
                    {
                        Obj_Entrada_Producto_DAL.bActivo = 0;
                    }

                    Obj_Entrada_Producto_BLL.Modificar_Entradas(ref Obj_Entrada_Producto_DAL, sMsjError);

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

            else
            {
                MessageBox.Show("Tiene valors en Blanco \n\nDebe completar los datos solicitados",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
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
                   (e.KeyChar == (char)Keys.Delete) ||
                   (e.KeyChar == (char)'-'))
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
            if 
                ((e.KeyChar == (char)',') || //coma decimal
             (e.KeyChar == (char)'.')) //no permite poner (punto)

            {

                e.Handled = true;
            }
            else

               if (((char.IsLetter(e.KeyChar))) ||
                (((char.IsNumber(e.KeyChar))) ||//isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete))) //||
                   //(e.KeyChar == (char)'-')))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
             (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

               if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete) )
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
                   (e.KeyChar == (char)Keys.Delete) ||
                   (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCostIngre_KeyPress(object sender, KeyPressEventArgs e)
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