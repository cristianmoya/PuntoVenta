using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_VetSpa.Cat_Mant.Consulta;
using BLL_VetSpa.Generales;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Consulta;
using DAL_VetSpa.Cat_Mant.Seguridad;

namespace BLL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Exp_Duen_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Exp_Duen_DAL Obj_Exp_Duen_DAL = new cls_Exp_Duen_DAL();

        #endregion

        public void Listar_Expedientes(ref DataTable dtProductos, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarinformacionDueno", "Expediente", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtProductos = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtProductos = new DataTable();
            }
        }

        public void Filtrar_Expedientes(ref DataTable dtExpediente, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@codigo_articulo", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarinformacionDueno", "Expediente", dtParametros, ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    sMsjError = string.Empty;
                    dtExpediente = Obj_BD_DAL.DS.Tables[0];
                }
                else
                {
                    sMsjError = Obj_BD_DAL.sMsjError;
                    dtExpediente = new DataTable();
                }
            }
            else
            {
                sMsjError = "Se presento un erro ala hora de crear el data table";
            }
        }

        public void Crear_Expedientes(ref cls_Exp_Duen_DAL Obj_Exp_Duen_DAL, ref string sMsjError)
        {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();

                dtParametros.Rows.Add("@id_dueno", 2, Obj_Exp_Duen_DAL.sIDDuen.ToString().Trim());
                dtParametros.Rows.Add("@nombre_dueno", 2, Obj_Exp_Duen_DAL.sNombDuen.ToString().Trim());
                dtParametros.Rows.Add("@celular", 2, Obj_Exp_Duen_DAL.sCelular.ToString().Trim());
                dtParametros.Rows.Add("@telefono_fijo", 2, Obj_Exp_Duen_DAL.sTelFijo.ToString().Trim());
                dtParametros.Rows.Add("@direccion", 2, Obj_Exp_Duen_DAL.sDireccion.ToString().Trim());
                dtParametros.Rows.Add("@correo", 2, Obj_Exp_Duen_DAL.sCorreo.ToString().Trim());
                dtParametros.Rows.Add("@activo", 10, Obj_Exp_Duen_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usuario_creacion", 2, Obj_Exp_Duen_DAL.sUsuCreac.ToString().Trim());
                dtParametros.Rows.Add("@fecha_creacion", 7, Obj_Exp_Duen_DAL.dtFechaCreac.ToString().Trim());
            }

                                       
            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_InsertarInformaciondueno", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Exp_Duen_DAL.cFlagAxion = 'I';
                Obj_Exp_Duen_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Exp_Duen_DAL.cFlagAxion = 'U';
                Obj_Exp_Duen_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Expedientes(ref cls_Exp_Duen_DAL Obj_Exp_Duen_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@id_dueno", 2, Obj_Exp_Duen_DAL.sIDDuen.ToString().Trim());
                dtParametros.Rows.Add("@nombre_dueno", 2, Obj_Exp_Duen_DAL.sNombDuen.ToString().Trim());
                dtParametros.Rows.Add("@celular", 2, Obj_Exp_Duen_DAL.sCelular.ToString().Trim());
                dtParametros.Rows.Add("@telefono_fijo", 2, Obj_Exp_Duen_DAL.sTelFijo.ToString().Trim());
                dtParametros.Rows.Add("@direccion", 6, Obj_Exp_Duen_DAL.sDireccion.ToString().Trim());
                dtParametros.Rows.Add("@correo", 7, Obj_Exp_Duen_DAL.sCorreo.ToString().Trim());
                dtParametros.Rows.Add("@activo", 9, Obj_Exp_Duen_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usu_modif", 2, Obj_Exp_Duen_DAL.sUsuModif.ToString().Trim());
                dtParametros.Rows.Add("@fecha_modif", 7, Obj_Exp_Duen_DAL.dtFechaModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_ActualizarInformaciondueno", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Exp_Duen_DAL.cFlagAxion = 'U';
                Obj_Exp_Duen_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Exp_Duen_DAL.cFlagAxion = 'U';
                Obj_Exp_Duen_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
