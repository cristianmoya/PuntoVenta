using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_VetSpa.Cat_Mant.Inventarios;
using BLL_VetSpa.Generales;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Inventarios;
using DAL_VetSpa.Cat_Mant.Seguridad;


namespace BLL_VetSpa.Cat_Mant.Inventarios
{
    public class cls_Producto_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Producto_DAL Obj_Producto_DAL = new cls_Producto_DAL();

        #endregion

        public void Listar_Productos(ref DataTable dtProductos, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarproducto", "Producto", dtParametros, ref Obj_BD_DAL);

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

        public void Filtrar_Productos(ref DataTable dtProductos, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@codigo_articulo", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarproductos", "Productos", dtParametros, ref Obj_BD_DAL);

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
            else
            {
                sMsjError = "Se presento un erro ala hora de crear el data table";
            }
        }

        public void Crear_Productos(ref cls_Producto_DAL Obj_Producto_DAL, ref string sMsjError)
            {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();

                dtParametros.Rows.Add("@codigo_articulo", 1, Obj_Producto_DAL.iCodArt.ToString().Trim());
                dtParametros.Rows.Add("@descripcion_articulo", 2, Obj_Producto_DAL.sDescArt.ToString().Trim());
                dtParametros.Rows.Add("@costo_articulo", 8, Obj_Producto_DAL.fCostArt.ToString().Trim());
                dtParametros.Rows.Add("@impuesto_art", 9, Obj_Producto_DAL.bImpuArt.ToString().Trim());
                dtParametros.Rows.Add("@precio_articulo", 8, Obj_Producto_DAL.fPrecArt.ToString().Trim());
                dtParametros.Rows.Add("@fecha_caducidad", 7, Obj_Producto_DAL.dtFechaCaduc.ToString().Trim());
                dtParametros.Rows.Add("@cantidad", 1, Obj_Producto_DAL.iCantProd.ToString().Trim());
                dtParametros.Rows.Add("@activo", 9, Obj_Producto_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@TIPO_ARTICULO", 3, Obj_Producto_DAL.cTipArt.ToString().Trim());
                dtParametros.Rows.Add("@fecha_creacion", 7, Obj_Producto_DAL.dtFechaCreac.ToString().Trim());
                dtParametros.Rows.Add("@usuario_creacion", 2, Obj_Producto_DAL.sUsuCreac.ToString().Trim());
            }


            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_insertarproducto", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Producto_DAL.cFlagAxion = 'I';
                Obj_Producto_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Producto_DAL.cFlagAxion = 'U';
                Obj_Producto_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Productos(ref cls_Producto_DAL Obj_Producto_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@activo", 2, Obj_Producto_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usuario_modificacion", 2, Obj_Producto_DAL.sUsuModif.ToString().Trim());
                dtParametros.Rows.Add("@fecha_modificacion", 7, Obj_Producto_DAL.dtFechaModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_Actualizarproducto", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Producto_DAL.cFlagAxion = 'U';
                Obj_Producto_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Producto_DAL.cFlagAxion = 'U';
                Obj_Producto_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
