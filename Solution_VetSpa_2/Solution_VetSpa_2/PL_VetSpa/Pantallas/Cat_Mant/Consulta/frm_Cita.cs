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
    public partial class frm_Cita : Form
    {
        public frm_Cita()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtIDDueno_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
