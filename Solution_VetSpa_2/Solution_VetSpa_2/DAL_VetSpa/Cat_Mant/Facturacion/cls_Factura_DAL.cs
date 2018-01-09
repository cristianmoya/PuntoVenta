using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Facturacion
{
    public class cls_Factura_DAL
    {
        #region Variables

        private int _iNumFact,
                    _iConsDiag;

        private String _sIDClient,
                       _sUsuCreac,
                       _sUsuModif;

        private double _dImpuesto,
                        _dSubtotal,
                        _dTotal;

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

        public int iNumFact
        {
            get { return _iNumFact; }
            set { _iNumFact = value; }
        }

        public string sIDClient
        {
            get { return _sIDClient; }
            set { _sIDClient = value; }
        }

        public int iConsDiag
        {
            get { return _iConsDiag; }
            set { _iConsDiag = value; }
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

        public double dImpuesto
        {
            get { return _dImpuesto; }
            set { _dImpuesto = value; }
        }

        public double dSubtotal
        {
            get { return _dSubtotal; }
            set { _dSubtotal = value; }
        }

        public double dTotal
        {
            get { return _dTotal; }
            set { _dTotal = value; }
        }

        #endregion
    }
}
