using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_VetSpa.BD
{
    public class cls_BD_DAL
    {
        #region VARIABLES PRIVADAS

        string _sMsjError,
               _sCadenaCnx;

        #endregion

        #region VARIABLES PÚBLICAS

        public string sMsjError
        {
            get { return _sMsjError; }
            set { _sMsjError = value; }
        }

        public string sCadenaCnx
        {
            get { return _sCadenaCnx; }
            set { _sCadenaCnx = value; }
        }

        #endregion

        #region OBJETOS

        public SqlConnection CNX_SQL;
        public SqlCommand CMD_SQL;
        public SqlDataAdapter DA_SQL;
        public DataSet DS = new DataSet();

        #endregion

    }
}
