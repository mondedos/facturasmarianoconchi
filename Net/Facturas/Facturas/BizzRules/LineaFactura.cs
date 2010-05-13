using System;
using System.Collections.Generic;

using System.Text;

namespace Facturas.BizzRules
{
    public class LineaFactura : ILineaFactura
    {
        public string Concepto { get; set; }
        public float Kilometros { get; set; }
        public float HorasEspera { get; set; }
        public float Cantidad { get; set; }

    }
}
