using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Exp_Duen_DAL
    {
        #region Variables

        private String _sIDDuen,
                       _sNombDuen,
                       _sCelular,
                       _sTelFijo,
                       _sDireccion,
                       _sCorreo,
                       _sUsuCreac,
                       _sUsuModif;

        private DateTime _dtFechaCreac, _dtFechaModif;

        private byte _bActivo;

        private char _cFlagAxion, _cFlagEstAxion;

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

        public string sNombDuen
        {
            get { return _sNombDuen; }
            set { _sNombDuen = value; }
        }

        public string sIDDuen
        {
            get { return _sIDDuen; }
            set { _sIDDuen = value; }
        }

        public string sCelular
        {
            get { return _sCelular; }
            set { _sCelular = value; }
        }

        public String sUsuCreac
        {
            get { return _sUsuCreac; }
            set { _sUsuCreac = value; }
        }

        public String sUsuModif
        {
            get { return _sUsuModif; }
            set { _sUsuModif = value; }
        }

        public string sTelFijo
        {
            get { return _sTelFijo; }
            set { _sTelFijo = value; }
        }

        public string sDireccion
        {
            get { return _sDireccion; }
            set { _sDireccion = value; }
        }

        public string sCorreo
        {
            get { return _sCorreo; }
            set { _sCorreo = value; }
        }

        #endregion
    }
}
