package facturas.bizzRule;

public interface ILineaFactura {

	/**
	 * @return the descripcion
	 */
	public abstract String getDescripcion();

	/**
	 * @param descripcion the descripcion to set
	 */
	public abstract void setDescripcion(String descripcion);

	/**
	 * @return the horasEspera
	 */
	public abstract int getHorasEspera();

	/**
	 * @param horasEspera the horasEspera to set
	 */
	public abstract void setHorasEspera(int horasEspera);

	/**
	 * @return the kilometros
	 */
	public abstract float getKilometros();

	/**
	 * @param kilometros the kilometros to set
	 */
	public abstract void setKilometros(float kilometros);

	/**
	 * @return the precioKilometro
	 */
	public abstract float getPrecioKilometro();

	/**
	 * @param precioKilometro the precioKilometro to set
	 */
	public abstract void setPrecioKilometro(float precioKilometro);

	/**
	 * @return the total
	 */
	public abstract float getTotal();

	/**
	 * @param total the total to set
	 */
	public abstract void setTotal(float total);

}