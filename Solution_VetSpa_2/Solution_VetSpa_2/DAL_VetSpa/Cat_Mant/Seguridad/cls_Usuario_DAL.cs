using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Seguridad
{
    public class cls_Usuario_DAL
    {
        #region Variables

        private int _iRol;

        private String _sNombEmpl,
                       _sNombUsua,
                       _sContrase,
                       _sUsuModif,
                       _sUsuCreac;

        private byte _bActivo;

        private DateTime _dtFechaModif,
                         _dtFechaCreac;

        private char _cFlagAxion, 
                     _cFlagEstAxion;

        #endregion

        #region Metodos Get y Set

        public char cFlagEstAxion
        {
            get { return _cFlagEstAxion; }
            set { _cFlagEstAxion = value; }
        }

        public char cFlagAxion
        {
            get { return _cFlagAxion; }
            set { _cFlagAxion = value; }
        }

        public byte bActivo
        {
            get { return _bActivo; }
            set { _bActivo = value; }
        }

        public DateTime dtFechaCreac
        {
            get { return _dtFechaCreac; }
            set { _dtFechaCreac = value; }
        }

        public DateTime dtFechaModif
        {
            get { return _dtFechaModif; }
            set { _dtFechaModif = value; }
        }

        public int iRol
        {
            get { return _iRol; }
            set { _iRol = value; }
        }

        public string sNombEmpl
        {
            get { return _sNombEmpl; }
            set { _sNombEmpl = value; }
        }

        public String sNombUsua
        {
            get { return _sNombUsua; }
            set { _sNombUsua = value; }
        }

        public String sContrase
        {
            get { return _sContrase; }
            set { _sContrase = value; }
        }


        public String sUsuModif
        {
            get { return _sUsuModif; }
            set { _sUsuModif = value; }
        }

        public String sUsuCreac
        {
            get { return _sUsuCreac; }
            set { _sUsuCreac = value; }
        }

        #endregion
    }
}
