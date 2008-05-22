package facturas.bizzRule;

import java.util.Collection;

public interface IFactura {
	public String getCif();

	public void setCif(String cif);

	public String getDireccion();

	public void setDireccion(String direccion);

	public String getFecha();

	public void setFecha(String fecha);

	public String getNombreCompanyia();

	public void setNombreCompanyia(String nombreCompanyia);

	public String getTelefono();

	public void setTelefono(String Telefono);

	public String getCodigoPostal();

	public void setCodigoPostal(String CodigoPostal);

	public String getCiudad();

	public void setCiudad(String Ciudad);

	public int getNumeroFactura();

	public void setNumeroFactura(int numeroFactura);

	public Collection<ILineaFactura> getLineaFacturas();

	public float CalcularTotal();

	public float CalcularIVA();

	public float CalcularPagoIVA();

	public void addLineaFactura(ILineaFactura linea);
}
