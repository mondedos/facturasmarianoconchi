/**
 *
 */
package facturas.bizzRule;

/**
 * @author ricardo
 *
 */
public class FacturaHelperFactory {
	/**
	 * Crea una instancia de linea de factura
	 *
	 * @return linea de factura
	 */
	public static ILineaFactura createLineaFactura() {
		return new LineaFactura();
	}

	/**
	 * Crea una factura en blanco.
	 *
	 * @return
	 */
	public static IFactura createFactura() {
		return new Factura();
	}

}
