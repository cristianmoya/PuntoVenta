using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Diagnostico_DALL
    {
        private string _sidpaciente,
                      _sdiagnostico,
                      _splanterapuetico,
                       _susuariocreacion,
                      _usuario_modificacion;

        private int _icodigoProd1,
                    _icantidad1,
                    _icodigoProd2,
                    _icantidad2,
                    _icodigoProd3,
                    _icantidad3,
                    _icodigoProd4,
                    _icantidad4;




        private DateTime _dfecha, dfechacreacion, dfechamodificacion;
        private TimeSpan _thora;

        private byte _bActivo;

        private char _cFlagAxion, _cFlagEstAxion;

        public string Sidpaciente
        {
            get
            {
                return _sidpaciente;
            }

            set
            {
                _sidpaciente = value;
            }
        }

        public string Sdiagnostico
        {
            get
            {
                return _sdiagnostico;
            }

            set
            {
                _sdiagnostico = value;
            }
        }

        public string Splanterapuetico
        {
            get
            {
                return _splanterapuetico;
            }

            set
            {
                _splanterapuetico = value;
            }
        }

        public string Susuariocreacion
        {
            get
            {
                return _susuariocreacion;
            }

            set
            {
                _susuariocreacion = value;
            }
        }

        public string Usuario_modificacion
        {
            get
            {
                return _usuario_modificacion;
            }

            set
            {
                _usuario_modificacion = value;
            }
        }

        public int IcodigoProd1
        {
            get
            {
                return _icodigoProd1;
            }

            set
            {
                _icodigoProd1 = value;
            }
        }

        public int Icantidad1
        {
            get
            {
                return _icantidad1;
            }

            set
            {
                _icantidad1 = value;
            }
        }

        public int IcodigoProd2
        {
            get
            {
                return _icodigoProd2;
            }

            set
            {
                _icodigoProd2 = value;
            }
        }

        public int Icantidad2
        {
            get
            {
                return _icantidad2;
            }

            set
            {
                _icantidad2 = value;
            }
        }

        public int IcodigoProd3
        {
            get
            {
                return _icodigoProd3;
            }

            set
            {
                _icodigoProd3 = value;
            }
        }

        public int Icantidad3
        {
            get
            {
                return _icantidad3;
            }

            set
            {
                _icantidad3 = value;
            }
        }

        public int IcodigoProd4
        {
            get
            {
                return _icodigoProd4;
            }

            set
            {
                _icodigoProd4 = value;
            }
        }

        public int Icantidad4
        {
            get
            {
                return _icantidad4;
            }

            set
            {
                _icantidad4 = value;
            }
        }

        public DateTime Dfecha
        {
            get
            {
                return _dfecha;
            }

            set
            {
                _dfecha = value;
            }
        }

        public DateTime Dfechacreacion
        {
            get
            {
                return dfechacreacion;
            }

            set
            {
                dfechacreacion = value;
            }
        }

        public DateTime Dfechamodificacion
        {
            get
            {
                return dfechamodificacion;
            }

            set
            {
                dfechamodificacion = value;
            }
        }

        public TimeSpan Thora
        {
            get
            {
                return _thora;
            }

            set
            {
                _thora = value;
            }
        }

        public byte BActivo
        {
            get
            {
                return _bActivo;
            }

            set
            {
                _bActivo = value;
            }
        }

        public char CFlagAxion
        {
            get
            {
                return _cFlagAxion;
            }

            set
            {
                _cFlagAxion = value;
            }
        }

        public char CFlagEstAxion
        {
            get
            {
                return _cFlagEstAxion;
            }

            set
            {
                _cFlagEstAxion = value;
            }
        }
    }
}
