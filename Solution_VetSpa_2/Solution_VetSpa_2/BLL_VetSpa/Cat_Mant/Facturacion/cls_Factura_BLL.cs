using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL_VetSpa.Cat_Mant.Facturacion;
using BLL_VetSpa.Generales;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Facturacion;

namespace BLL_VetSpa.Cat_Mant.Facturacion
{
    public class cls_Factura_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Factura_DAL Obj_Factura_DAL = new cls_Factura_DAL();

        #endregion
        public void Listar_Facturas(ref DataTable dtFacturas, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarFactura", "Facturas", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtFacturas = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtFacturas = new DataTable();
            }
        }

        public void Filtrar_Facturas(ref DataTable dtFacturas, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@Numero_Factura", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_filtrarfacturas", "Facturas", dtParametros, ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    sMsjError = string.Empty;
                    dtFacturas = Obj_BD_DAL.DS.Tables[0];
                }
                else
                {
                    sMsjError = Obj_BD_DAL.sMsjError;
                    dtFacturas = new DataTable();
                }
            }
            else
            {
                sMsjError = "Se presento un erro ala hora de crear el data table";
            }
        }

        public void Crear_Facturas(ref cls_Factura_DAL Obj_Facturas_DAL, ref string sMsjError)
        {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();


                dtParametros.Rows.Add("@idcliente", 2, Obj_Facturas_DAL.sIDClient.ToString().Trim());
                dtParametros.Rows.Add("@consec_diagnostico", 1, Obj_Facturas_DAL.iConsDiag.ToString().Trim());
                dtParametros.Rows.Add("@impuesto", 6, Obj_Facturas_DAL.dImpuesto.ToString().Trim());
                dtParametros.Rows.Add("@fecha", 7, Obj_Facturas_DAL.dtFechaModif.ToString().Trim());
                dtParametros.Rows.Add("@usuariocreacion", 2, Obj_Facturas_DAL.sUsuCreac.ToString().Trim());
                dtParametros.Rows.Add("@subtotal", 6, Obj_Facturas_DAL.dSubtotal.ToString().Trim());
                dtParametros.Rows.Add("@total", 6, Obj_Facturas_DAL.dTotal.ToString().Trim());
                dtParametros.Rows.Add("@activo", 2, Obj_Facturas_DAL.bActivo.ToString().Trim());
            }


            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_Insertarfactura", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Facturas_DAL.cFlagAxion = 'I';
                Obj_Facturas_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Facturas_DAL.cFlagAxion = 'U';
                Obj_Facturas_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Facturas(ref cls_Factura_DAL Obj_Facturas_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@numFactura", 1, Obj_Facturas_DAL.iNumFact.ToString().Trim());
                dtParametros.Rows.Add("@activo", 2, Obj_Facturas_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@FecModificacion", 7, Obj_Facturas_DAL.dtFechaModif.ToString().Trim());
                dtParametros.Rows.Add("@UsuModificacion", 2, Obj_Facturas_DAL.sUsuModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_ActualizarFactura", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Facturas_DAL.cFlagAxion = 'U';
                Obj_Facturas_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Facturas_DAL.cFlagAxion = 'U';
                Obj_Facturas_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
