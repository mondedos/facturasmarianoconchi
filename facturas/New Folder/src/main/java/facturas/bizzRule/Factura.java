/**
 *
 */
package facturas.bizzRule;

import java.util.ArrayList;
import java.util.Collection;

/**
 * @author ricardo
 *
 */
public class Factura implements IFactura {
	private int _numeroFactura;

	private String _nombreCompanyia;

	private String _fecha;

	private String _direccion;

	private String _cif, _telefono, _codigoPostal, _ciudad;

	private Collection<ILineaFactura> _lineas = null;

	public Factura() {
		_lineas = new ArrayList<ILineaFactura>();
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#CalcularIVA()
	 */
	public float CalcularIVA() {
		Configuracion conf = Configuracion.getInstance();
		float totalcalculado = CalcularTotal();
		float subtotal = totalcalculado / (1 + conf.get_iva());
		return subtotal;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#CalcularTotal()
	 */
	public float CalcularTotal() {
		float totalCalcular = 0;
		for (ILineaFactura liena : _lineas) {
			totalCalcular += liena.getTotal();
		}
		return totalCalcular;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getCif()
	 */
	public String getCif() {
		return _cif;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getDireccion()
	 */
	public String getDireccion() {
		return _direccion;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getFecha()
	 */
	public String getFecha() {
		return _fecha;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getLineaFacturas()
	 */
	public Collection<ILineaFactura> getLineaFacturas() {
		return _lineas;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getNombreCompanyia()
	 */
	public String getNombreCompanyia() {
		return _nombreCompanyia;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#getNumeroFactura()
	 */
	public int getNumeroFactura() {
		return _numeroFactura;
	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#setCif(java.lang.String)
	 */
	public void setCif(String cif) {
		_cif = cif;

	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#setDireccion(java.lang.String)
	 */
	public void setDireccion(String direccion) {
		_direccion = direccion;

	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#setFecha(java.util.Date)
	 */
	public void setFecha(String fecha) {
		_fecha = fecha;

	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#setNombreCompanyia(java.lang.String)
	 */
	public void setNombreCompanyia(String nombreCompanyia) {
		_nombreCompanyia = nombreCompanyia;

	}

	/*
	 * (non-Javadoc)
	 *
	 * @see facturas.bizzRule.IFactura#setNumeroFactura(int)
	 */
	public void setNumeroFactura(int numeroFactura) {
		_numeroFactura = numeroFactura;

	}

	public void addLineaFactura(ILineaFactura linea) {
		_lineas.add(linea);
	}

	public String getCodigoPostal() {
		return _codigoPostal;
	}

	public String getTelefono() {
		return _telefono;
	}

	public void setCodigoPostal(String CodigoPostal) {
		_codigoPostal = CodigoPostal;

	}

	public void setTelefono(String Telefono) {
		_telefono = Telefono;

	}

	public String getCiudad() {
		return _ciudad;
	}

	public void setCiudad(String Ciudad) {
		_ciudad = Ciudad;

	}

	public float CalcularPagoIVA() {
		float diff = CalcularTotal() - CalcularIVA();
		return diff;
	}

}
