using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Inventarios
{
    public class cls_Producto_DAL
    {
        #region Variables

        private int _iCodArt,
                    _iCantProd;

        private String _sDescArt,
                       _sUsuModif,
                       _sUsuCreac;

        private float   _fCostArt,
                        _fPrecArt;

        private DateTime _dtFechaCreac, 
                         _dtFechaModif,
                         _dtFechaCaduc;

        private byte _bActivo,
                     _bImpuArt;

        private char _cFlagAxion, _cFlagEstAxion, _cTipArt;

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
        
        public DateTime dtFechaCaduc
        {
            get { return _dtFechaCaduc; }
            set { _dtFechaCaduc = value; }
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

        public int iCodArt
        {
            get { return _iCodArt; }
            set { _iCodArt = value; }
        }

        public int iCantProd
        {
            get { return _iCantProd; }
            set { _iCantProd = value; }
        }
        
        public String sDescArt
        {
            get { return _sDescArt; }
            set { _sDescArt = value; }
        }

        public char cTipArt
        {
            get { return _cTipArt; }
            set { _cTipArt = value; }
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

        public float fCostArt
        {
            get { return _fCostArt; }
            set { _fCostArt = value; }
        }

        public byte bImpuArt
        {
            get { return _bImpuArt; }
            set { _bImpuArt = value; }
        }

        public float fPrecArt
        {
            get { return _fPrecArt; }
            set { _fPrecArt = value; }
        }

        #endregion
    }
}

