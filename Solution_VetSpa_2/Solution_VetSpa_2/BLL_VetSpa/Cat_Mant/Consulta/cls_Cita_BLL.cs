using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_VetSpa.Cat_Mant.Consulta;
using BLL_VetSpa.Generales;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant.Consulta;
using DAL_VetSpa.Cat_Mant.Seguridad;
using System.Data;

namespace BLL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Cita_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Cita_DAL Obj_Citas_DAL = new cls_Cita_DAL();
        #endregion

        public void Listar_Citas(ref DataTable dtCitas, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarCitas", "Citas", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtCitas = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtCitas = new DataTable();
            }
        }
    }
}
