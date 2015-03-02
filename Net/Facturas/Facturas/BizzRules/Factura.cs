using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Facturas.BizzRules
{
    public class Factura : IFactura
    {
        #region Atributos

        private DateTime _fecha;
        private int _numero;
        private string _nombre;
        private string _direccion;
        private string _ciudad;
        private string _codigoPostal;
        private string _telefono;
        private string _cif;
        private string _unidadTramitadora;
        private string _unidadOrganica;

        #endregion

        #region Propiedades

        public decimal Total { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Iva { get; set; }

        public DateTime Fecha
        {
            get { return _fecha; }
            set
            {
                _fecha = value;
                RaisePropertyChanged("Fecha");
            }
        }

        public int Numero
        {
            get { return _numero; }
            set
            {
                _numero = value;
                RaisePropertyChanged("Numero");
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

        public string Direccion
        {
            get { return _direccion; }
            set
            {
                _direccion = value;
                RaisePropertyChanged("Direccion");
            }
        }

        public string Ciudad
        {
            get { return _ciudad; }
            set
            {
                _ciudad = value;
                RaisePropertyChanged("Ciudad");
            }
        }

        public string CodigoPostal
        {
            get { return _codigoPostal; }
            set
            {
                _codigoPostal = value;
                RaisePropertyChanged("CodigoPostal");
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

        public string Cif
        {
            get { return _cif; }
            set
            {
                _cif = value;
                RaisePropertyChanged("Cif");
            }
        }

        public string UnidadTramitadora
        {
            get { return _unidadTramitadora; }
            set
            {
                _unidadTramitadora = value;
                RaisePropertyChanged("UnidadTramitadora");
            }
        }

        public string UnidadOrganica
        {
            get { return _unidadOrganica; }
            set
            {
                _unidadOrganica = value;
                RaisePropertyChanged("UnidadOrganica");
            }
        }

        [XmlIgnore]
        public List<ILineaFactura> Lineas { get; private set; }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Factura()
        {
            Lineas = new List<ILineaFactura>();
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
