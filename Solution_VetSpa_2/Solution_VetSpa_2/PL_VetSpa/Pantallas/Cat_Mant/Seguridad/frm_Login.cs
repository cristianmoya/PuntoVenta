using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PL_VetSpa.Generales;
using DAL_VetSpa.Cat_Mant.Seguridad;
using BLL_VetSpa.Cat_Mant.Seguridad;
using DAL_VetSpa.BD;
using BLL_VetSpa.BD; 

namespace PL_VetSpa.Seguridad
{
    public partial class frm_Login : Form
    {
        #region Variables Publicas

        cls_Login_DAL Obj_Login_DAL = new cls_Login_DAL();
        cls_Login_BLL Obj_Login_BLL = new cls_Login_BLL();
        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();

        #endregion

        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("No pueden haber espacios vacios, inserte un usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            else
            {
                string sMsjError = string.Empty;
                Obj_Login_DAL.sContraseña = txtPassword.Text.Trim();
                Obj_Login_DAL.sUsuario = txtUsuario.Text.Trim();
                Comparar_Login();
                this.Dispose();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lklblOlvContr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void Comparar_Login()
        {
            if (txtUsuario.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("No pueden haber espacios vacios, inserte un usuario y una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dtLogin = new DataTable();
                string sMsjError = string.Empty;
                Obj_Login_DAL.sUsuario = txtUsuario.Text.Trim();
                Obj_Login_DAL.sContraseña = txtPassword.Text.Trim();

                Obj_Login_BLL.CompararLogin(ref dtLogin, Obj_Login_DAL.sUsuario, Obj_Login_DAL.sContraseña, ref sMsjError);

                if (sMsjError == string.Empty)
                {
                    if (dtLogin.Rows.Count != 0)
                    {
                        if (dtLogin.Rows[0][0].ToString() == txtUsuario.Text.Trim() &&
                            dtLogin.Rows[0][1].ToString() == txtPassword.Text.Trim())
                        {
                            frm_Menu Menu = new frm_Menu();
                            Menu.Obj_Usuario_Logueado_DAL = Obj_Login_DAL;
                            switch (dtLogin.Rows[0][2].ToString())
                            {
                                case "1":
                                    Menu.Show();
                                    this.Dispose();
                                    break;
                                case "2":
                                    Menu.Show();
                                    this.Dispose();
                                    break;
                                case "3":
                                    Menu.Show();
                                    this.Dispose();
                                    break;
                                default:
                                    Menu.Show();
                                    this.Dispose();
                                    break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña incorrectos",
                        "ERROR EN LISTAR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }       
                }
            }
        }
    }
}
