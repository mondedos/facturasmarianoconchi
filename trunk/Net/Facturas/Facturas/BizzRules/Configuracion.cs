using System;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Facturas.BizzRules
{
    public class Configuracion : IDXDataErrorInfo
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

        #region Implementation of IDXDataErrorInfo

        /// <summary>
        /// <para>
        /// When implemented by a class, this method returns information on an error associated with a specific business object's property.
        /// </para>
        /// </summary>
        /// <param name="propertyName">A string that identifies the name of the property for which information on an error is to be returned.
        ///             </param><param name="info">An <see cref="T:DevExpress.XtraEditors.DXErrorProvider.ErrorInfo"/> object that contains information on an error.
        ///             </param>
        public void GetPropertyError(string propertyName, ErrorInfo info)
        {
            if (propertyName.Equals("Licencia") && string.IsNullOrWhiteSpace(Licencia))
            {
                info.ErrorText = "Debes introducir un número de licencia.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Nombre") && string.IsNullOrWhiteSpace(Nombre))
            {
                info.ErrorText = "Debes indicar un nombre.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("PoblacionCp") && string.IsNullOrWhiteSpace(PoblacionCp))
            {
                info.ErrorText = "Debes indicar una población.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Direccion") && string.IsNullOrWhiteSpace(Direccion))
            {
                info.ErrorText = "Debes indicar una dirección.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Telefono") && string.IsNullOrWhiteSpace(Telefono))
            {
                info.ErrorText = "Debes indicar un número de teléfono.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Movil") && string.IsNullOrWhiteSpace(Movil))
            {
                info.ErrorText = "Debes indicar un número de teléfono movil.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Email") && string.IsNullOrWhiteSpace(Email))
            {
                info.ErrorText = "Debes indicar un email.";
                info.ErrorType = ErrorType.Critical;
                return;
            }
            if (propertyName.Equals("Cif"))
            {
                if (string.IsNullOrWhiteSpace(Cif))
                {
                    info.ErrorText = "Debes indicar un CIF.";
                    info.ErrorType = ErrorType.Critical;
                    return;
                }
                try
                {
                    if (!CifNifValidador.ValidarCifNifNie(Cif))
                    {
                        info.ErrorText = "El CIF no es válido";
                        info.ErrorType = ErrorType.Critical;
                        return;
                    }
                }
                catch (ArgumentException exception)
                {
                    info.ErrorText = exception.Message;
                    info.ErrorType = ErrorType.Critical;
                    return;
                }
                
            }
            if (propertyName.Equals("Ccc"))
            {
                if (string.IsNullOrWhiteSpace(Ccc))
                {
                    info.ErrorText = "Debes indicar una cuenta bancaria.";
                    info.ErrorType = ErrorType.Critical;
                    return;
                }
                try
                {
                    if (!CuentaBancariaValidador.ValidaCuentaBancaria(Ccc))
                    {
                        info.ErrorText = "La cuenta Bancaria Introducida no es válida";
                        info.ErrorType = ErrorType.Critical;
                        return;
                    }
                }
                catch (ArgumentException exception)
                {
                    info.ErrorText = exception.Message;
                    info.ErrorType = ErrorType.Critical;
                    return;
                }
                
            }

        }

        /// <summary>
        /// <para>
        /// When implemented by a class, this method returns information on an error associated with a business object.
        /// </para>
        /// </summary>
        /// <param name="info">An <see cref="T:DevExpress.XtraEditors.DXErrorProvider.ErrorInfo"/> object that contains information on an error.
        ///             </param>
        public void GetError(ErrorInfo info)
        {
            GetPropertyError("Licencia", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Nombre", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("PoblacionCp", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Direccion", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Telefono", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Movil", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Email", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Cif", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Ccc", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("Iva", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("EurosKilometros", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("EurosHora", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("NilvelLmFondo", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("TablaBorde", info); if (info.ErrorType == ErrorType.Critical) return;
            GetPropertyError("UltimaFactura", info); if (info.ErrorType == ErrorType.Critical) return;
        }

        #endregion
    }
}