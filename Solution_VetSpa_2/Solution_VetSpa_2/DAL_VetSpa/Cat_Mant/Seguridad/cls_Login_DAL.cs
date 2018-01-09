using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Seguridad
{
    public class cls_Login_DAL
    {
        #region Variables

        private String _sUsuario;

        private String _sContraseña;

        #endregion

        #region

        public String sUsuario
        {
            get { return _sUsuario; }
            set { _sUsuario = value; }
        }

        public String sContraseña
        {
            get { return _sContraseña; }
            set { _sContraseña = value; }
        }

        #endregion
    }
}
