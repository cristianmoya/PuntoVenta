using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Inventarios
{
    public class cls_Salidas_DAL
    {
        #region Variables

        private int _iConsSalid,
                    _iCodArt;

        private String _sNumDoc,
                       _sDescArt,
                       _sUsuModif,
                       _sUsuCreac;

        private decimal _dCostIngr,
                        _dCantProd;

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

        public int iConsSalid
        {
            get { return _iConsSalid; }
            set { _iConsSalid = value; }
        }

        public string sDescArt
        {
            get { return _sDescArt; }
            set { _sDescArt = value; }
        }

        public string sNumDoc
        {
            get { return _sNumDoc; }
            set { _sNumDoc = value; }
        }

        public int iCodArt
        {
            get { return _iCodArt; }
            set { _iCodArt = value; }
        }

        public decimal dCantProd
        {
            get { return _dCantProd; }
            set { _dCantProd = value; }
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

        public decimal dCostIngr
        {
            get { return _dCostIngr; }
            set { _dCostIngr = value; }
        }

        #endregion
    }
}
