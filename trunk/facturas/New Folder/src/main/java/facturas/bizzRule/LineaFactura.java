/**
 *
 */
package facturas.bizzRule;

/**
 * @author ricardo
 *
 */
public class LineaFactura implements ILineaFactura  {
	String descripcion;
	float kilometros, precioKilometro,total;
	int horasEspera;
	 public LineaFactura() {
		// TODO Auto-generated constructor stub


	}


	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#getDescripcion()
	 */
	public String getDescripcion() {
		return descripcion;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#setDescripcion(java.lang.String)
	 */
	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#getHorasEspera()
	 */
	public int getHorasEspera() {
		return horasEspera;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#setHorasEspera(int)
	 */
	public void setHorasEspera(int horasEspera) {
		this.horasEspera = horasEspera;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#getKilometros()
	 */
	public float getKilometros() {
		return kilometros;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#setKilometros(float)
	 */
	public void setKilometros(float kilometros) {
		this.kilometros = kilometros;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#getPrecioKilometro()
	 */
	public float getPrecioKilometro() {
		return precioKilometro;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#setPrecioKilometro(float)
	 */
	public void setPrecioKilometro(float precioKilometro) {
		this.precioKilometro = precioKilometro;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#getTotal()
	 */
	public float getTotal() {
		return total;
	}
	/* (non-Javadoc)
	 * @see facturas.bizzRule.ILineaFactura#setTotal(float)
	 */
	public void setTotal(float total) {
		this.total = total;
	}
}
