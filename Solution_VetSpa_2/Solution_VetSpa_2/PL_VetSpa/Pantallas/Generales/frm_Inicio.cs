using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL_VetSpa.Seguridad;

namespace PL_VetSpa.Generales
{
    public partial class frm_Inicio : Form
    {
        public frm_Inicio()
        {
            InitializeComponent();
        }

        private void frm_Inicio_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login Login = new frm_Login();
            Login.StartPosition = FormStartPosition.CenterParent;
            Login.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_Login Login = new frm_Login();
            Login.StartPosition = FormStartPosition.CenterParent;
            Login.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
