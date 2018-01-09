using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_VetSpa.Pantallas.Cat_Mant.Facturacion
{
    public partial class frm_Fact : Form
    {
        public frm_Fact()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIDDueño.Text == "" || txtFactura.Text == "" || txtNombDuen.Text == "" || dtgvFactura.DataSource == null)
            {
                MessageBox.Show("No pueden haber espacios vacios, inserte un usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Dispose();
            }
        }

        private void btnConsIDDuen_Click(object sender, EventArgs e)
        {

        }

        private void txtIDDueño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)',') || //coma decimal
             (e.KeyChar == (char)'.')) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

               if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                   (e.KeyChar == (char)Keys.Back) || //
                   (e.KeyChar == (char)Keys.Delete) )//||
                  // (e.KeyChar == (char)'-'))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombDuen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbNomMasc_KeyPress(object sender, KeyPressEventArgs e)
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
            if //((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')//) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete) ||
                 (e.KeyChar == (char)','))//||
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if //((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')//) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

            if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete) ||
                 (e.KeyChar == (char)','))//||
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if //((e.KeyChar == (char)',') || //coma decimal
           (e.KeyChar == (char)'.')//) //no permite poner (punto)
            {
                e.Handled = true;
            }
            else

             if (((char.IsNumber(e.KeyChar))) ||  //isnumber permite enteros positivos y decimales
                 (e.KeyChar == (char)Keys.Back) || //
                 (e.KeyChar == (char)Keys.Delete)||
                 (e.KeyChar == (char)','))//||
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
