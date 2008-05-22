package facturas.PDF;

import java.io.OutputStream;
import java.io.UnsupportedEncodingException;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

import org.apache.commons.io.IOUtils;
import org.apache.fop.apps.FOUserAgent;
import org.apache.fop.apps.MimeConstants;

import facturas.bizzRule.IFactura;
import facturas.bizzRule.ILineaFactura;

public class PDFGeneador {

	private static String ccc = "0182-5819-51-0206905579", lm = "1279",
			dni = "28685953P";

	private IFactura _factura;

	/**
	 * @return the _factura
	 */
	public IFactura get_factura() {
		return _factura;
	}

	/**
	 * @param _factura
	 *            the _factura to set
	 */
	public void set_factura(IFactura _factura) {
		this._factura = _factura;
	}

	public void init() {
		if (_factura != null) {
			String[] args = { "aaaa.fo",
					"factura-" + _factura.getNumeroFactura() + ".pdf" };

			startFOP(args);
		}
	}

	/**
	 * @return true if FOP's dependecies are available in the current
	 *         ClassLoader setup.
	 */
	public boolean checkDependencies() {
		try {
			// System.out.println(Thread.currentThread().getContextClassLoader());
			Class clazz = Class.forName("org.apache.commons.io.IOUtils");
			if (clazz != null) {
				clazz = Class
						.forName("org.apache.avalon.framework.configuration.Configuration");
			}
			return (clazz != null);
		} catch (Exception e) {
			return false;
		}
	}

	/**
	 * Executes FOP with the given ClassLoader setup.
	 *
	 * @param args
	 *            command-line arguments
	 */
	public void startFOP(String[] args) {
		// System.out.println("static CCL: "
		// + Thread.currentThread().getContextClassLoader().toString());
		// System.out.println("static CL: " +
		// Fop.class.getClassLoader().toString());
		CommandLineOptions options = null;
		FOUserAgent foUserAgent = null;
		OutputStream out = null;

		try {
			options = new CommandLineOptions(this);
			options.parse(args);

			foUserAgent = options.getFOUserAgent();
			String outputFormat = options.getOutputFormat();

			try {
				if (options.getOutputFile() != null) {
					out = new java.io.BufferedOutputStream(
							new java.io.FileOutputStream(options
									.getOutputFile()));
					foUserAgent.setOutputFile(options.getOutputFile());
				}
				if (!MimeConstants.MIME_XSL_FO.equals(outputFormat)) {
					options.getInputHandler().renderTo(foUserAgent,
							outputFormat, out);
				} else {
					options.getInputHandler().transformTo(out);
				}
			} finally {
				IOUtils.closeQuietly(out);
			}

			// System.exit(0) called to close AWT/SVG-created threads, if any.
			// AWTRenderer closes with window shutdown, so exit() should not
			// be called here
			if (!MimeConstants.MIME_FOP_AWT_PREVIEW.equals(outputFormat)) {
				if (manejador != null)
					manejador.informar(true);
			}
		} catch (Exception e) {
			if (options != null) {
				options.getLogger().error("Exception", e);
			}
			if (options.getOutputFile() != null) {
				options.getOutputFile().delete();
			}
			if (manejador != null)
				manejador.informar(false);
		}
	}

	IPDFLisener manejador;

	public String createString() {
		StringBuffer sf = new StringBuffer();
		sf
				.append("<fo:root xmlns:fo=\"http://www.w3.org/1999/XSL/Format\"><fo:layout-master-set><fo:simple-page-master master-name=\"simple\" page-height=\"29.7cm\" page-width=\"21cm\"");
		sf
				.append(" margin-top=\"1cm\" margin-bottom=\"2cm\" margin-left=\"2.5cm\" margin-right=\"2.5cm\"><fo:region-body region-name=\"cuerpo\" margin-top=\"3cm\"/><fo:region-before extent=\"3cm\"/>");
		sf.append("<fo:region-after region-name=\"Footer\" extent=\"0.7in\" padding=\"0\" precedence=\"true\" /></fo:simple-page-master>");
		sf
				.append("</fo:layout-master-set><fo:page-sequence master-reference=\"simple\">");
		sf.append("<fo:static-content flow-name=\"Footer\"><fo:block-container position=\"absolute\" top=\"10pt\" left=\"30pt\" height=\"14pt\" width=\"100%\" ><fo:block text-align=\"right\" font=\"8pt Arial\">");
		sf.append(firmar());
		sf.append("</fo:block></fo:block-container></fo:static-content>");
		sf.append("<fo:flow flow-name=\"cuerpo\">");

		sf
				.append("<fo:block-container position=\"absolute\" top=\"10pt\" left=\"30pt\" height=\"14pt\" width=\"100%\" >");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");
		sf
		.append("<fo:block font=\"72pt Arial\" color=\"rgb(240,240,240)\">L.M.");
		sf.append(lm);
		sf.append("</fo:block>");

		sf.append("</fo:block-container>");

		sf
				.append("<fo:block font-size=\"18pt\" font-family=\"sans-serif\" line-height=\"24pt\" ");
		sf
				.append("                space-after.optimum=\"15pt\" text-align=\"center\" padding-top=\"3pt\">FACTURA TAXI Mariano</fo:block> ");
		sf
				.append("<fo:block font-size=\"12pt\" font-family=\"sans-serif\" line-height=\"15pt\" space-after.optimum=\"3pt\" text-align=\"justify\"> FECHA: "
						+ _factura.getFecha() + "<fo:block/> FACTURA ");
		sf.append("Nº: ");
		sf.append(_factura.getNumeroFactura());
		sf.append("</fo:block> ");
		sf
				.append("<fo:block font-size=\"12pt\" font-family=\"sans-serif\" line-height=\"15pt\" space-after.optimum=\"3pt\" text-align=\"justify\"><fo:inline font-weight=\"bold\" ");
		sf.append("    >Licencia Municipal ");
		sf.append(lm);
		sf.append("</fo:inline><fo:block/>Manuel Prieto Gallego<fo:block/> ");
		sf
				.append("C/ Sector Triángulo Nº 12 8º A<fo:block/> Dos Hermanas, 41089<fo:block/> Teléfono: 954120606<fo:block/> Móvil: 617637215<fo:block/> NIF: 75392444P<fo:block/> CCC: ");
		sf
				.append(ccc
						+ "</fo:block><fo:block font-size=\"12pt\" font-family=\"sans-serif\" line-height=\"15pt\" ");
		sf
				.append("space-after.optimum=\"3pt\" text-align=\"justify\"><fo:inline font-weight=\"bold\" >FACTURAR A:</fo:inline><fo:block/> Nombre: "
						+ _factura.getNombreCompanyia() + "<fo:block/> ");
		sf.append("Dirección: " + _factura.getDireccion());
		sf.append("<fo:block/> Ciudad: " + _factura.getCiudad()
				+ "<fo:block/> Código Postal: " + _factura.getCodigoPostal()
				+ "<fo:block/> Teléfono: " + _factura.getTelefono()
				+ "<fo:block/>CIF/NIF: " + _factura.getCif() + "<fo:block/> ");
		sf.append(" </fo:block> ");
		sf.append("<fo:table table-layout=\"fixed\" width=\"100%\"> ");
		sf
				.append("<fo:table-header background-color=\"rgb(180,180,180)\" border=\"1pt solid black\"> ");
		sf
				.append("    <fo:table-row display-align=\"center\" background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("        <fo:table-cell display-align=\"center\" number-columns-spanned=\"3\" ");
		sf
				.append("            border=\"1pt solid black\" background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("            <fo:block display-align=\"center\" background-color=\"rgb(180,180,180)\" ");
		sf.append("                >Descripción</fo:block> ");
		sf.append("        </fo:table-cell> ");
		sf
				.append("        <fo:table-cell display-align=\"center\" border=\"1pt solid black\" ");
		sf.append("            background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("            <fo:block display-align=\"center\">KM</fo:block> ");
		sf.append("        </fo:table-cell> ");
		sf
				.append("   <fo:table-cell display-align=\"center\" border=\"1pt solid black\" ");
		sf.append("            background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("            <fo:block display-align=\"center\">€/KM</fo:block> ");
		sf.append("        </fo:table-cell> ");
		sf
				.append("        <fo:table-cell display-align=\"center\" border=\"1pt solid black\" ");
		sf.append("            background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("            <fo:block display-align=\"center\">Hoas de espera</fo:block> ");
		sf.append("        </fo:table-cell> ");
		sf
				.append("        <fo:table-cell display-align=\"center\" border=\"1pt solid black\" ");
		sf.append("            background-color=\"rgb(180,180,180)\"> ");
		sf
				.append("            <fo:block display-align=\"center\">Cantidad</fo:block> ");
		sf
				.append("        </fo:table-cell></fo:table-row></fo:table-header><fo:table-body> ");
		// filas añadidas automáticamente
		rellenarTabla(sf);
		sf
				.append("<fo:table-row><fo:table-cell number-columns-spanned=\"4\"> ");
		sf
				.append("<fo:block/></fo:table-cell><fo:table-cell number-columns-spanned=\"2\" border=\"1pt solid black\"> ");
		sf
				.append("<fo:block>SUBTOTAL</fo:block></fo:table-cell><fo:table-cell border=\"1pt solid black\"> ");
		sf.append("<fo:block>");
		sf.append(floattoString(_factura.CalcularIVA()));
		sf.append("€</fo:block> ");
		sf
				.append("</fo:table-cell> </fo:table-row><fo:table-row><fo:table-cell number-columns-spanned=\"4\"> ");
		sf
				.append("<fo:block/> </fo:table-cell><fo:table-cell number-columns-spanned=\"2\" border=\"1pt solid black\"> ");
		sf
				.append("<fo:block>IVA</fo:block></fo:table-cell><fo:table-cell border=\"1pt solid black\"> ");
		sf.append("            <fo:block>");
		sf.append(floattoString(_factura.CalcularPagoIVA()));
		sf.append("€</fo:block> ");
		sf
				.append("</fo:table-cell></fo:table-row><fo:table-row><fo:table-cell number-columns-spanned=\"4\"><fo:block/> ");
		sf
				.append("</fo:table-cell><fo:table-cell number-columns-spanned=\"2\" border=\"1pt solid black\"> ");
		sf.append("<fo:block>TOTAL</fo:block></fo:table-cell> ");
		sf.append("<fo:table-cell border=\"1pt solid black\"> ");
		sf.append("<fo:block>");
		sf.append(floattoString(_factura.CalcularTotal()));
		sf
				.append("€</fo:block></fo:table-cell></fo:table-row></fo:table-body></fo:table>");

		sf.append("</fo:flow>");

		sf.append("</fo:page-sequence></fo:root>");

		return sf.toString();
	}

	private void rellenarTabla(StringBuffer sf) {

		for (ILineaFactura linea : _factura.getLineaFacturas()) {
			sf.append("<fo:table-row border=\"1pt solid black\"> ");
			sf
					.append("<fo:table-cell number-columns-spanned=\"3\" border=\"1pt solid black\"> ");
			sf.append("<fo:block>");
			sf.append(linea.getDescripcion());
			sf.append("</fo:block></fo:table-cell>");
			sf.append("<fo:table-cell border=\"1pt solid black\"><fo:block>");
			sf.append(linea.getKilometros());
			sf.append("</fo:block></fo:table-cell> ");
			sf.append("<fo:table-cell border=\"1pt solid black\"><fo:block> ");
			sf.append(floattoString(linea.getPrecioKilometro()));
			sf.append("€</fo:block></fo:table-cell> ");
			sf.append("<fo:table-cell border=\"1pt solid black\"><fo:block>");
			sf.append(linea.getHorasEspera());
			sf.append("</fo:block></fo:table-cell>");
			sf.append("<fo:table-cell border=\"1pt solid black\"><fo:block>");
			sf.append(floattoString(linea.getTotal()));
			sf.append("€</fo:block></fo:table-cell> ");
			sf.append("</fo:table-row> ");

		}
	}

	private String firmar() {
		String miFima = lm + _factura.getNumeroFactura() + ccc
				+ _factura.CalcularTotal() + _factura.getNombreCompanyia()
				+ dni;
		try {
			return SHA1(miFima);
		} catch (NoSuchAlgorithmException e) {
			// TODO Auto-generated catch block
			return "";
		} catch (UnsupportedEncodingException e) {
			// TODO Auto-generated catch block
			return "";
		}
	}

	private static String convertToHex(byte[] data) {
		StringBuffer buf = new StringBuffer();
		for (int i = 0; i < data.length; i++) {
			int halfbyte = (data[i] >>> 4) & 0x0F;
			int two_halfs = 0;
			do {
				if ((0 <= halfbyte) && (halfbyte <= 9))
					buf.append((char) ('0' + halfbyte));
				else
					buf.append((char) ('a' + (halfbyte - 10)));
				halfbyte = data[i] & 0x0F;
			} while (two_halfs++ < 1);
		}
		return buf.toString();
	}

	public static String SHA1(String text) throws NoSuchAlgorithmException,
			UnsupportedEncodingException {
		MessageDigest md;
		md = MessageDigest.getInstance("SHA-1");
		byte[] sha1hash = new byte[40];
		md.update(text.getBytes("iso-8859-1"), 0, text.length());
		sha1hash = md.digest();
		return convertToHex(sha1hash);
	}

	public static String floattoString(float cantidad) {

		int redondeo = ((int) (cantidad * 100.0F));

		float nuevaCantidad = ((float) redondeo / 100.0F);

		return "" + nuevaCantidad;
	}

	/**
	 * @return the manejador
	 */
	public IPDFLisener getManejador() {
		return manejador;
	}

	/**
	 * @param manejador
	 *            the manejador to set
	 */
	public void setManejador(IPDFLisener manejador) {
		this.manejador = manejador;
	}
}
