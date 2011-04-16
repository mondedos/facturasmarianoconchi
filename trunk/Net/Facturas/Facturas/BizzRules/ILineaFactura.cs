namespace Facturas.BizzRules
{
    public interface ILineaFactura
    {
        decimal Cantidad { get; }
        string Concepto { get; }
        decimal HorasEspera { get; }
        decimal Kilometros { get; }
        decimal KilometrosEuros { get; }
        decimal HorasEuros { get; }
    }
}
