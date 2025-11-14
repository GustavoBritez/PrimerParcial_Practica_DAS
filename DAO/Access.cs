using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class Access
    {
        /// Primero vamos a estructurar nuestra clase Acceso al documento, osea a la base datos de texto plano
        private const string Ruta_XML = "HotelData.XML";
        public DataSet _dataSet;

        public Access ()
        {
            _dataSet = new DataSet("DatosHotel");
        
            if (File.Exists(Ruta_XML))
            {
                _dataSet.ReadXml(Ruta_XML);
            }
            else
            {
                DataInitializer.CrearTablas(_dataSet);
                GuardarDatos();
            }
        }
        public void GuardarDatos()
        {
            _dataSet.WriteXml(Ruta_XML,XmlWriteMode.WriteSchema);
        }
        public DataSet GetDataSet()
        {
            return _dataSet;
        }
    }
}
