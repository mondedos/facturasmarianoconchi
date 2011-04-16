﻿namespace Facturas.BizzRules
{
    public class LineaFactura : ILineaFactura
    {
        public string Concepto { get; set; }
        public decimal Kilometros { get; set; }
        public decimal HorasEspera { get; set; }
        public decimal Cantidad { get; set; }
        public decimal KilometrosEuros { get; set; }
        public decimal HorasEuros { get; set; }

    }
}
