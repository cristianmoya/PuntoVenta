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
    public class cls_Entrada_Prod_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Entrada_Prod_DAL Obj_Entrada_DAL = new cls_Entrada_Prod_DAL();

        #endregion
        
        public void Listar_Entradas(ref DataTable dtEntradas, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarentradas", "Entradas", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtEntradas = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtEntradas = new DataTable();
            }
        }

        public void Filtrar_Entradas(ref DataTable dtEntradas, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@consec_entada", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarentradas", "Entradas", dtParametros, ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    sMsjError = string.Empty;
                    dtEntradas = Obj_BD_DAL.DS.Tables[0];
                }
                else
                {
                    sMsjError = Obj_BD_DAL.sMsjError;
                    dtEntradas = new DataTable();
                }
            }
            else
            {
                sMsjError = "Se presento un erro ala hora de crear el data table";
            }
        }

        public void Crear_Entrada(ref cls_Entrada_Prod_DAL Obj_Entrada_Prod_DAL, ref string sMsjError)
        {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();

                dtParametros.Rows.Add("@consec_entrada", 2, Obj_Entrada_Prod_DAL.iConsEntr.ToString().Trim());
                dtParametros.Rows.Add("@codigo_articulo", 1, Obj_Entrada_Prod_DAL.iCodArt.ToString().Trim());
                dtParametros.Rows.Add("@numero_documento", 2, Obj_Entrada_Prod_DAL.sNumDoc.ToString().Trim());
                dtParametros.Rows.Add("@cantidad", 1, Obj_Entrada_Prod_DAL.iCantProd.ToString().Trim());
                dtParametros.Rows.Add("@costo_ingreso", 9, Obj_Entrada_Prod_DAL.fCostIngr.ToString().Trim());
                dtParametros.Rows.Add("@activo", 10, Obj_Entrada_Prod_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@fecha_creacion", 7, Obj_Entrada_Prod_DAL.dtFechaCreac.ToString().Trim());
                dtParametros.Rows.Add("@usuario_creacion", 2, Obj_Entrada_Prod_DAL.sUsuCreac.ToString().Trim());
                dtParametros.Rows.Add("@Descripcion_Producto", 2, Obj_Entrada_Prod_DAL.sDescArt.ToString().Trim());

            }


            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_InsertarEntrada", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Entrada_Prod_DAL.cFlagAxion = 'I';
                Obj_Entrada_Prod_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Entrada_Prod_DAL.cFlagAxion = 'U';
                Obj_Entrada_Prod_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Entradas(ref cls_Entrada_Prod_DAL Obj_Entrada_Prod_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@consec_entrada", 2, Obj_Entrada_Prod_DAL.iConsEntr.ToString().Trim());
                dtParametros.Rows.Add("@activo", 6, Obj_Entrada_Prod_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@", 6, Obj_Entrada_Prod_DAL.sUsuModif.ToString().Trim());
                dtParametros.Rows.Add("@fecha_modificacion", 6, Obj_Entrada_Prod_DAL.dtFechaModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_Actualizarentrada", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Entrada_Prod_DAL.cFlagAxion = 'U';
                Obj_Entrada_Prod_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Entrada_Prod_DAL.cFlagAxion = 'U';
                Obj_Entrada_Prod_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
