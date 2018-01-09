using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VetSpa.Pantallas.Cat_Mant.Consulta
{
    public partial class frm_Hitoria_Clinica : Form
    {
        public frm_Hitoria_Clinica()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtTipoVac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsLetterOrDigit(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
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

        private void txtTipParacito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsLetterOrDigit(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
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

        private void txtTipAlimIng_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCirug_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
