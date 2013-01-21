namespace Facturas.BizzRules
{
    public class LineaFactura : ILineaFactura
    {
        #region Atributos

        private string _concepto;
        private decimal _kilometros;
        private decimal _horasEspera;
        private decimal _cantidad;
        private decimal _kilometrosEuros;
        private decimal _horasEuros;
        #endregion

        #region Propiedades

        public string Concepto
        {
            get { return _concepto; }
            set
            {
                _concepto = value;
                RaisePropertyChanged("Concepto");
            }
        }

        public decimal Kilometros
        {
            get { return _kilometros; }
            set
            {
                _kilometros = value;
                RaisePropertyChanged("Kilometros");
            }
        }

        public decimal HorasEspera
        {
            get { return _horasEspera; }
            set
            {
                _horasEspera = value;
                RaisePropertyChanged("HorasEspera");
            }
        }

        public decimal Cantidad
        {
            get { return _cantidad; }
            set
            {
                _cantidad = value;
                RaisePropertyChanged("Cantidad");
            }
        }

        public decimal KilometrosEuros
        {
            get { return _kilometrosEuros; }
            set
            {
                _kilometrosEuros = value;
                RaisePropertyChanged("KilometrosEuros");
            }
        }

        public decimal HorasEuros
        {
            get { return _horasEuros; }
            set
            {
                _horasEuros = value;
                RaisePropertyChanged("HorasEuros");
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
    }
}
