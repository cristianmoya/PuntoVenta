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
    public class cls_Exp_Pac_BLL
    {
        #region VARIABLES PUBLICAS

        cls_BD_DAL Obj_BD_DAL = new cls_BD_DAL();
        cls_BD_BLL Obj_BD_BLL = new cls_BD_BLL();
        cls_Generales_BLL Obj_Generales_BLL = new cls_Generales_BLL();
        cls_Exp_Pac_DAL Obj_Exp_Pac_DAL = new cls_Exp_Pac_DAL();

        #endregion

        public void Listar_Pacientes(ref DataTable dtPacientes, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();
            DataTable dtParametros = new DataTable();

            #endregion

            Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarexpedientespacientes", "Expedientes", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                dtPacientes = Obj_BD_DAL.DS.Tables[0];
            }
            else
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                dtPacientes = new DataTable();
            }
        }

        public void Filtrar_Expedientes(ref DataTable dtProductos, string sFiltro, ref string sMsjError)
        {

            #region VARIABLES LOCALES

            Obj_BD_DAL = new cls_BD_DAL();
            Obj_BD_BLL = new cls_BD_BLL();

            #endregion

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();


            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@codigo_articulo", 2, sFiltro);
                Obj_BD_BLL.Execute_Fill("VETSPA.sp_listarexpedientespacientes", "Expedientes", dtParametros, ref Obj_BD_DAL);

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

        public void Crear_Expedientes(ref cls_Exp_Pac_DAL Obj_Exp_Pac_DAL, ref string sMsjError)
        {

            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                DataRow dr1 = dtParametros.NewRow();
                DataRow dr2 = dtParametros.NewRow();
                DataRow dr3 = dtParametros.NewRow();

                dtParametros.Rows.Add("@id_paciente", 2, Obj_Exp_Pac_DAL.sIDPaciente.ToString().Trim());
                dtParametros.Rows.Add("@id_dueno", 2, Obj_Exp_Pac_DAL.sIDDuen.ToString().Trim());
                dtParametros.Rows.Add("@consecutivo_paciente", 1, Obj_Exp_Pac_DAL.iConsPac.ToString().Trim());
                dtParametros.Rows.Add("@nombre_paciente", 2, Obj_Exp_Pac_DAL.sNombPac.ToString().Trim());
                dtParametros.Rows.Add("@especie", 1, Obj_Exp_Pac_DAL.iEspecie.ToString().Trim());
                dtParametros.Rows.Add("@edad", 6, Obj_Exp_Pac_DAL.dEdad.ToString().Trim());
                dtParametros.Rows.Add("@raza", 2, Obj_Exp_Pac_DAL.sRaza.ToString().Trim());
                dtParametros.Rows.Add("@sexo", 1, Obj_Exp_Pac_DAL.iSexo.ToString().Trim());
                dtParametros.Rows.Add("@activo", 2, Obj_Exp_Pac_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usu_creac", 2, Obj_Exp_Pac_DAL.sUsuCreac.ToString().Trim());
                dtParametros.Rows.Add("@fecha_creac", 7, Obj_Exp_Pac_DAL.dtFechaCreac.ToString().Trim());
            }


            Obj_BD_BLL.Execute_Scalar("VETSPA.sp_InsertarInformaciondueno", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = Obj_BD_DAL.sMsjError;
                Obj_Exp_Pac_DAL.cFlagAxion = 'I';
                Obj_Exp_Pac_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Exp_Pac_DAL.cFlagAxion = 'U';
                Obj_Exp_Pac_DAL.cFlagEstAxion = 'E';
            }
        }

        public void Modificar_Expedientes(ref cls_Exp_Pac_DAL Obj_Exp_Pac_DAL, string sMsjError)
        {
            DataTable dtParametros = Obj_Generales_BLL.CrearTablaParametros();

            if (dtParametros.Columns.Count == 3)
            {
                dtParametros.Rows.Add("@id_dueno", 2, Obj_Exp_Pac_DAL.sIDDuen.ToString().Trim());
                dtParametros.Rows.Add("@nombre_paciente", 2, Obj_Exp_Pac_DAL.sNombPac.ToString().Trim());
                dtParametros.Rows.Add("@especie", 1, Obj_Exp_Pac_DAL.iEspecie.ToString().Trim());
                dtParametros.Rows.Add("@edad", 6, Obj_Exp_Pac_DAL.dEdad.ToString().Trim());
                dtParametros.Rows.Add("@raza", 2, Obj_Exp_Pac_DAL.sRaza.ToString().Trim());
                dtParametros.Rows.Add("@sexo", 1, Obj_Exp_Pac_DAL.iSexo.ToString().Trim());
                dtParametros.Rows.Add("@activo", 2, Obj_Exp_Pac_DAL.bActivo.ToString().Trim());
                dtParametros.Rows.Add("@usu_modif", 2, Obj_Exp_Pac_DAL.sUsuModif.ToString().Trim());
                dtParametros.Rows.Add("@fecha_modif", 7, Obj_Exp_Pac_DAL.dtFechaModif.ToString().Trim());
            }

            Obj_BD_BLL.Execute_NonQuery("VETSPA.sp_ActualizarInformacionpaciente", dtParametros, ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError != string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Exp_Pac_DAL.cFlagAxion = 'U';
                Obj_Exp_Pac_DAL.cFlagEstAxion = 'F';
            }
            else
            {
                sMsjError = string.Empty;
                Obj_Exp_Pac_DAL.cFlagAxion = 'U';
                Obj_Exp_Pac_DAL.cFlagEstAxion = 'E';
            }
        }
    }
}
