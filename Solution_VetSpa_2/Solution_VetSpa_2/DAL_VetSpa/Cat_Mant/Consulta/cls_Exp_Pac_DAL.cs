using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Exp_Pac_DAL
    {
        #region Variables

        private String _sIDPaciente,
                       _sIDDuen,
                       _sNombPac,
                       _sRaza,
                       _sUsuCreac,
                       _sUsuModif;

        private DateTime _dtFechaCreac, _dtFechaModif;

        private decimal _dEdad;

        private int _iConsPac,
                    _iEspecie,
                    _iSexo;

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

        public string sNombPac
        {
            get { return _sNombPac; }
            set { _sNombPac = value; }
        }

        public string sIDDuen
        {
            get { return _sIDDuen; }
            set { _sIDDuen = value; }
        }

        public string sIDPaciente
        {
            get { return _sIDPaciente; }
            set { _sIDPaciente = value; }
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

        public decimal dEdad
        {
            get { return _dEdad; }
            set { _dEdad = value; }
        }

        public int iConsPac
        {
            get { return _iConsPac; }
            set { _iConsPac = value; }
        }

        public int iEspecie
        {
            get { return _iEspecie; }
            set { _iEspecie = value; }
        }
        
        public int iSexo
        {
            get { return _iSexo; }
            set { _iSexo = value; }
        }

        public string sRaza
        {
            get { return _sRaza; }
            set { _sRaza = value; }
        }

        #endregion
    }
}
