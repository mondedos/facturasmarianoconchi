using System;
namespace Facturas.BizzRules
{
    public interface IFactura
    {
        string Cif { get; set; }
        string Ciudad { get; set; }
        string CodigoPostal { get; set; }
        string Direccion { get; set; }
        DateTime Fecha { get; set; }
        System.Collections.Generic.List<ILineaFactura> Lineas { get; }
        string Nombre { get; set; }
        int Numero { get; set; }
        string Telefono { get; set; }
    }
}
