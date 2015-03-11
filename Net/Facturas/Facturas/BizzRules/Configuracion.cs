using System;
using DevExpress.XtraEditors.DXErrorProvider;

namespace Facturas.BizzRules
{
    public class Configuracion : IDXDataErrorInfo
    {
        #region Atributos

        private string _licencia;
        private string _nombre;
        private string _poblacionCp;
        private string _direccion;
        private string _telefono;
        private string _movil;
        private string _email;
        private string _cif;
        private string _ccc;
        private decimal _iva;
        private decimal _eurosKilometros;
        private decimal _eurosHora;
        private int _nilvelLmFondo;
        private decimal _tablaBorde;
        private int _ultimaFactura;
        private string _iban;
        private string _textoFirma;

        #endregion

        #region Propiedades

        public string TextoFirma
        {
            get { return _textoFirma; }
            set
            {
                _textoFirma = value;
                RaisePropertyChanged("TextoFirma");
            }
        }

        public string Licencia
        {
            get { return _licencia; }
            set
            {
                _licencia = value;
                RaisePropertyChanged("Licencia");
            }
        }

        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                RaisePropertyChanged("Nombre");
            }
        }

        public string PoblacionCp
        {
            get { return _poblacionCp; }
            set
            {
                _poblacionCp = value;
                RaisePropertyChanged("PoblacionCp");
            }
        }

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                _direccion = value;
                RaisePropertyChanged("Direccion");
            }
        }

        public string Telefono
        {
            get { return _telefono; }
            set
            {
                _telefono = value;
                RaisePropertyChanged("Telefono");
            }
        }

        public string Movil
        {
            get { return _movil; }
            set
            {
                _movil = value;
                RaisePropertyChanged("Movil");
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                RaisePropertyChanged("Email");
            }
        }

        public string Cif
        {
            get { return _cif; }
            set
            {
                _cif = value;
                RaisePropertyChanged("Cif");
            }
        }

        public string Ccc
        {
            get { return _ccc; }
            set
            {
                _ccc = value;
                RaisePropertyChanged("Ccc");
            }
        }

        public string Iban
        {
            get { return _iban; }
            set
            {
                _iban = value;
                RaisePropertyChanged("Iban");
            }
        }

        public decimal Iva
        {
            get { return _iva; }
            set
            {
                _iva = value;
                RaisePropertyChanged("Iva");
            }
        }

        public decimal EurosKilometros
        {
            get { return _eurosKilometros; }
            set
            {
                _eurosKilometros = value;
                RaisePropertyChanged("EurosKilometros");
            }
        }

        public decimal EurosHora
        {
            get { return _eurosHora; }
            set
            {
                _eurosHora = value;
                RaisePropertyChanged("EurosHora");
            }
        }

        public int NilvelLmFondo
        {
            get { return _nilvelLmFondo; }
            set
            {
                _nilvelLmFondo = value;
                RaisePropertyChanged("NilvelLmFondo");
            }
        }

        public decimal TablaBorde
        {
            get { return _tablaBorde; }
            set
            {
                _tablaBorde = value;
                RaisePropertyChanged("TablaBorde");
            }
        }

        public int UltimaFactura
        {
            get { return _ultimaFactura; }
            set
            {
                _ultimaFactura = value;
                RaisePropertyChanged("UltimaFactura");
            }
        }
        #endregion


        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

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
            if (propertyName.Equals("Iban"))
            {
                if (string.IsNullOrWhiteSpace(Iban))
                {
                    info.ErrorText = "Debes indicar el código IBAN de la cuenta bancaria.";
                    info.ErrorType = ErrorType.Critical;
                    return;
                }
                try
                {
                    BizzRules.Iban.CheckIban(Iban, true, info);
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
            GetPropertyError("Iban", info); if (info.ErrorType == ErrorType.Critical) return;
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