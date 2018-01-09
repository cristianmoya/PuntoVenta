using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL_VetSpa.BD;
using DAL_VetSpa.BD;
using DAL_VetSpa.Cat_Mant;

namespace BLL_VetSpa.BD
{
    public class cls_BD_BLL
    {
        public void Traer_SQL_CNX(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Obj_BD_DAL.sCadenaCnx = ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString();

                Obj_BD_DAL.CNX_SQL = new SqlConnection(Obj_BD_DAL.sCadenaCnx);

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            catch (Exception ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();
            }
        }

        public void Abrir_SQL_CNX(ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                if (Obj_BD_DAL.CNX_SQL.State == ConnectionState.Closed)
                {
                    Obj_BD_DAL.CNX_SQL.Open();

                    Obj_BD_DAL.sMsjError = string.Empty;
                }
                else
                {
                    Obj_BD_DAL.sMsjError = "La conexión no puede ser abierta de nuevo, ya se encuentra en estado abierto";
                }

            }
            catch (Exception ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();
            }
        }

        public void Cerrar_SQL_CNX(ref cls_BD_DAL Obj_BD_DAL)
        {
            if (Obj_BD_DAL.CNX_SQL.State != ConnectionState.Closed)
            {
                Obj_BD_DAL.CNX_SQL.Close();

                Obj_BD_DAL.sMsjError = string.Empty;
            }
            else
            {
                Obj_BD_DAL.sMsjError = "La conexión no puede ser cerrada de nuevo, ya se encuentra en estado cerrado";
            }
        }

        public void Execute_NonQuery(string sNomSP, DataTable dtParametros, ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Traer_SQL_CNX(ref Obj_BD_DAL);

                Abrir_SQL_CNX(ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    Obj_BD_DAL.CMD_SQL = new SqlCommand(sNomSP, Obj_BD_DAL.CNX_SQL);

                    Obj_BD_DAL.CMD_SQL.CommandType = CommandType.StoredProcedure;

                    #region PARAMETROS SP

                    foreach (DataRow dr in dtParametros.Rows)
                    {

                        SqlParameter Parametro = new SqlParameter(dr[0].ToString(), dr[2]);

                        switch (Convert.ToInt16(dr[1].ToString()))
                        {

                            case 1:
                                Parametro.SqlDbType = SqlDbType.Int;
                                break;

                            case 2:
                                Parametro.SqlDbType = SqlDbType.VarChar;
                                break;
                            case 3:
                                Parametro.SqlDbType = SqlDbType.Char;
                                break;

                            case 4:
                                Parametro.SqlDbType = SqlDbType.NVarChar;
                                break;

                            case 5:
                                Parametro.SqlDbType = SqlDbType.NChar;
                                break;

                            case 6:
                                Parametro.SqlDbType = SqlDbType.Decimal;
                                break;

                            case 7:
                                Parametro.SqlDbType = SqlDbType.DateTime;
                                break;

                            case 8:
                                Parametro.SqlDbType = SqlDbType.Money;
                                break;

                            case 9:
                                Parametro.SqlDbType = SqlDbType.Float;
                                break;

                            case 10:
                                Parametro.SqlDbType = SqlDbType.Bit;
                                break;

                            default:

                                Parametro.SqlDbType = SqlDbType.VarChar;

                                break;
                        }

                        Obj_BD_DAL.CMD_SQL.Parameters.Add(Parametro);
                    }


                    //Tarea buscar como mandarle los Parametros en el excute_nonquery

                    #endregion


                    Obj_BD_DAL.CMD_SQL.ExecuteNonQuery();


                    Obj_BD_DAL.sMsjError = string.Empty;
                }
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();
            }
            finally
            {
                if (Obj_BD_DAL.CNX_SQL != null)
                {
                    if (Obj_BD_DAL.CNX_SQL.State != ConnectionState.Closed)
                    {
                        Obj_BD_DAL.CNX_SQL.Close();
                    }
                }
            }
        }

        public void Execute_Scalar(string sNomSP, DataTable dtParametros, ref cls_BD_DAL Obj_BD_DAL)
        {
            try
            {
                Traer_SQL_CNX(ref Obj_BD_DAL);

                Abrir_SQL_CNX(ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    Obj_BD_DAL.CMD_SQL = new SqlCommand(sNomSP, Obj_BD_DAL.CNX_SQL);

                    Obj_BD_DAL.CMD_SQL.CommandType = CommandType.StoredProcedure;

                    #region PARAMETROS SP

                    foreach (DataRow dr in dtParametros.Rows)
                    {
                        //Obj_BD_DAL.CMD_SQL.Parameters.Add(dr[0].ToString(), SqlDbType.Int,Convert.ToInt32(dr[2]));

                        SqlParameter Parametro = new SqlParameter(dr[0].ToString(), dr[2]);

                        switch (Convert.ToInt16(dr[1].ToString()))
                        {
                            case 1:
                                Parametro.SqlDbType = SqlDbType.Int;
                                break;

                            case 2:
                                Parametro.SqlDbType = SqlDbType.VarChar;
                                break;
                            case 3:
                                Parametro.SqlDbType = SqlDbType.Char;
                                break;

                            case 4:
                                Parametro.SqlDbType = SqlDbType.NVarChar;
                                break;

                            case 5:
                                Parametro.SqlDbType = SqlDbType.NChar;
                                break;

                            case 6:
                                Parametro.SqlDbType = SqlDbType.Decimal;
                                break;

                            case 7:
                                Parametro.SqlDbType = SqlDbType.DateTime;
                                break;

                            case 8:
                                Parametro.SqlDbType = SqlDbType.Money;
                                break;

                            case 9:
                                Parametro.SqlDbType = SqlDbType.Float;
                                break;

                            case 10:
                                Parametro.SqlDbType = SqlDbType.Bit;
                                break;

                            default:

                                Parametro.SqlDbType = SqlDbType.VarChar;

                                break;
                        }


                        Obj_BD_DAL.CMD_SQL.Parameters.Add(Parametro);

                    }


                    //Tarea buscar como mandarle los Parametros en el excute_nonquery
                    #endregion


                    Obj_BD_DAL.CMD_SQL.ExecuteScalar();

                    Obj_BD_DAL.sMsjError = string.Empty;
                }
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();
            }
            finally
            {
                if (Obj_BD_DAL.CNX_SQL != null)
                {
                    if (Obj_BD_DAL.CNX_SQL.State != ConnectionState.Closed)
                    {
                        Obj_BD_DAL.CNX_SQL.Close();
                    }
                }
            }
        }

        public void Execute_Fill(string sNomSP, string sNombTabla, DataTable dtParametros, ref cls_BD_DAL Obj_BD_DAL)
        {

            //cuando uso un Sql command utilizo 
            //cuando data IDataAdapter tengo Que ustilizar selectcommand
            try
            {
                Traer_SQL_CNX(ref Obj_BD_DAL);

                Abrir_SQL_CNX(ref Obj_BD_DAL);

                if (Obj_BD_DAL.sMsjError == string.Empty)
                {
                    Obj_BD_DAL.DA_SQL = new SqlDataAdapter(sNomSP, Obj_BD_DAL.CNX_SQL);

                    #region PARAMETROS SP

                    foreach (DataRow dr in dtParametros.Rows)
                    {

                        SqlParameter Parametro = new SqlParameter(dr[0].ToString(), dr[2].ToString());

                        switch (Convert.ToInt16(dr[1].ToString()))
                        {

                            case 1:
                                Parametro.SqlDbType = SqlDbType.Int;
                                break;

                            case 2:
                                Parametro.SqlDbType = SqlDbType.VarChar;
                                break;
                            case 3:
                                Parametro.SqlDbType = SqlDbType.Char;
                                break;

                            case 4:
                                Parametro.SqlDbType = SqlDbType.NVarChar;
                                break;

                            case 5:
                                Parametro.SqlDbType = SqlDbType.NChar;
                                break;

                            case 6:
                                Parametro.SqlDbType = SqlDbType.Decimal;
                                break;

                            case 7:
                                Parametro.SqlDbType = SqlDbType.DateTime;
                                break;

                            case 8:
                                Parametro.SqlDbType = SqlDbType.Money;
                                break;

                            default:

                                Parametro.SqlDbType = SqlDbType.VarChar;

                                break;
                        }

                        Obj_BD_DAL.DA_SQL.SelectCommand.Parameters.Add(Parametro);
                    }
                    #endregion

                    Obj_BD_DAL.DA_SQL.SelectCommand.CommandType = CommandType.StoredProcedure;
                    Obj_BD_DAL.DA_SQL.Fill(Obj_BD_DAL.DS, sNombTabla);
                    Obj_BD_DAL.sMsjError = string.Empty;
                }
            }
            catch (SqlException ex)
            {
                Obj_BD_DAL.sMsjError = ex.Message.ToString().Trim();
            }
            finally
            {
                if (Obj_BD_DAL.CNX_SQL != null)
                {
                    if (Obj_BD_DAL.CNX_SQL.State != ConnectionState.Closed)
                    {
                        Obj_BD_DAL.CNX_SQL.Close();
                    }
                }
            }
        }
    }
}
