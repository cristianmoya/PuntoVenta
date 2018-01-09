using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_VetSpa.Cat_Mant.Consulta
{
    public class cls_Cita_DAL
    {
        private string _sddueno,
                        _smotivo,
                        _susuario_creacion,
                        _usuario_modificacion;

        private int _iconsecutivo;



        private DateTime _dfecha, dfechacreacion, dfechamodificacion;
        private TimeSpan _thora;

        private byte _bActivo;

        private char _cFlagAxion, _cFlagEstAxion;

        public string Sddueno
        {
            get
            {
                return _sddueno;
            }

            set
            {
                _sddueno = value;
            }
        }

        public string Smotivo
        {
            get
            {
                return _smotivo;
            }

            set
            {
                _smotivo = value;
            }
        }

        public string Susuario_creacion
        {
            get
            {
                return _susuario_creacion;
            }

            set
            {
                _susuario_creacion = value;
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

        public int Iconsecutivo
        {
            get
            {
                return _iconsecutivo;
            }

            set
            {
                _iconsecutivo = value;
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
