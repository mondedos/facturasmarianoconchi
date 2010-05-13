using System;
namespace Facturas.BizzRules
{
    public interface ILineaFactura
    {
        float Cantidad { get; set; }
        string Concepto { get; set; }
        float HorasEspera { get; set; }
        float Kilometros { get; set; }
    }
}
