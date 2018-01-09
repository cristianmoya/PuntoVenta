using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BLL_VetSpa.Generales
{
    public class cls_Generales_BLL
    {
        public DataTable CrearTablaParametros()
        {
            try
            {
                DataTable dtPrametros = new DataTable("Parametros");
                dtPrametros.Columns.Add("NombParam");
                dtPrametros.Columns.Add("TipoDato", typeof(int));
                dtPrametros.Columns.Add("ValorParam");

                return dtPrametros;
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
    }
}
