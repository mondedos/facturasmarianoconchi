namespace Facturas.BizzRules
{
    public class Configuracion
    {
        public string Licencia { get; set; }
        public string Nombre { get; set; }
        public string PoblacionCp { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Movil { get; set; }
        public string Email { get; set; }
        public string Cif { get; set; }
        public string Ccc { get; set; }

        public decimal Iva { get; set; }
        public decimal EurosKilometros { get; set; }
        public decimal EurosHora { get; set; }

        public int NilvelLmFondo { get; set; }
        public decimal TablaBorde { get; set; }
        public int UltimaFactura { get; set; }
    }
}