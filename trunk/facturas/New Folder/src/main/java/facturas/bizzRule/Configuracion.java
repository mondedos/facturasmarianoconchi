package facturas.bizzRule;

public class Configuracion {
	private static Configuracion _instance = null;

	private static Object o = new Object();

	public static Configuracion getInstance() {
		synchronized (o) {
			if (_instance == null)
				_instance = new Configuracion();
		}
		return _instance;
	}

	private float _iva = 0.07F;

	/**
	 * @return the _iva
	 */
	public float get_iva() {
		return _iva;
	}

	/**
	 * @param _iva
	 *            the _iva to set
	 */
	public void set_iva(float _iva) {
		this._iva = _iva;
	}

}
