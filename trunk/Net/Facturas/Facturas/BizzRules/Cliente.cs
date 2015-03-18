namespace Facturas.BizzRules
{
    public class Cliente
    {
        #region Propiedades

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }
        public string Cif { get; set; }

        public byte[] ModeloDocumento { get; set; }

        #endregion

        #region Constructores

        public Cliente()
        {
            ModeloDocumento = new byte[0];
        }

        #endregion
    }
}
