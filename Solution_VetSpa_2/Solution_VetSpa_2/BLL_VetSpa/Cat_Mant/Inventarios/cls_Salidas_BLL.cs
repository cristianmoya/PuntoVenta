using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_VetSpa.Cat_Mant.Inventarios;
using BLL_VetSpa.Generales;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Inventarios;
using System.Data;


namespace BLL_VetSpa.Cat_Mant.Inventarios
{
    public class cls_Salidas_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Salidas_DAL Obj_Salidas_DAL = new cls_Salidas_DAL();

        #endregion

        public void Listar_Salidas(ref DataTable dtSalidas, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarsalidas", "Salidas", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtSalidas = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtSalidas = new DataTable();
            }
        }

        public void Filtrar_Salidas(ref DataTable dtSalidas, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@consec_salida   ", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarsalidas", "Salidas", dtParametros, ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    sMsjError = string.Empty;
                    dtSalidas = Obj_BD_DAL.DS.Tables[0];
                }
                else
                {
                    sMsjError = Obj_BD_DAL.sMsjError;
                    dtSalidas = new DataTable();
                }
            }
            else
            {
                sMsjError = "Se presento un erro ala hora de crear el data table";
            }
        }

        public void Crear_Salida(ref cls_Salidas_DAL Obj_Salidas_DAL, ref string sMsjError)
        {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();

                dtParametros.Rows.Add("@consec_entrada", 2, Obj_Salidas_DAL.iConsSalid.ToString().Trim());
                dtParametros.Rows.Add("@codigo_articulo", 1, Obj_Salidas_DAL.iCodArt.ToString().Trim());
                dtParametros.Rows.Add("@numero_documento", 6, Obj_Salidas_DAL.sNumDoc.ToString().Trim());
                dtParametros.Rows.Add("@cantidad", 7, Obj_Salidas_DAL.iConsSalid.ToString().Trim());
                dtParametros.Rows.Add("@costo_ingreso", 2, Obj_Salidas_DAL.dCostIngr.ToString().Trim());
                dtParametros.Rows.Add("@activo", 6, Obj_Salidas_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usu_creac", 6, Obj_Salidas_DAL.sUsuCreac.ToString().Trim());
                dtParametros.Rows.Add("@fecha_creac", 6, Obj_Salidas_DAL.dtFechaCreac.ToString().Trim());
            }


            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_Insertarentrada", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Salidas_DAL.cFlagAxion = 'I';
                Obj_Salidas_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Salidas_DAL.cFlagAxion = 'U';
                Obj_Salidas_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Salidas(ref cls_Salidas_DAL Obj_Salidas_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@consec_entrada", 2, Obj_Salidas_DAL.iConsSalid.ToString().Trim());
                dtParametros.Rows.Add("@activo", 6, Obj_Salidas_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usu_modif", 6, Obj_Salidas_DAL.sUsuModif.ToString().Trim());
                dtParametros.Rows.Add("@fecha_modif", 6, Obj_Salidas_DAL.dtFechaModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_Actualizarsalida", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Salidas_DAL.cFlagAxion = 'U';
                Obj_Salidas_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Salidas_DAL.cFlagAxion = 'U';
                Obj_Salidas_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
