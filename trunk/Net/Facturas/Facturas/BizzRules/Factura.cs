using System;
using System.Collections.Generic;

using System.Text;
using System.Xml.Serialization;

namespace Facturas.BizzRules
{
    public class Factura : IFactura
    {
        public Factura()
        {
            Lineas = new List<ILineaFactura>();
        }
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Cif { get; set; }
        
        [XmlIgnore]
        public List<ILineaFactura> Lineas { get; private set; }

        
    }
}
