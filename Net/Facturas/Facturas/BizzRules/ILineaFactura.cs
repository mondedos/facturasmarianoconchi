using System;
namespace Facturas.BizzRules
{
    public interface ILineaFactura
    {
        decimal Cantidad { get; set; }
        string Concepto { get; set; }
        decimal HorasEspera { get; set; }
        decimal Kilometros { get; set; }
        decimal KilometrosEuros { get; set; }
        decimal HorasEuros { get; set; }
    }
}
