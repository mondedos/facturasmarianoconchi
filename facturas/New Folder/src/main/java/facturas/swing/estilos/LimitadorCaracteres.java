/**
 * 
 */
package facturas.swing.estilos;

import java.awt.Toolkit;

import javax.swing.text.AttributeSet;
import javax.swing.text.BadLocationException;
import javax.swing.text.PlainDocument;

/**
 * @author riprimen
 * 
 */
public class LimitadorCaracteres extends PlainDocument {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1030727068760727891L;
	private int caracteresMaximos = 0;

	public LimitadorCaracteres(int maximo) {
		caracteresMaximos = maximo;
	}

	/*
	 * (non-Javadoc)
	 * 
	 * @see javax.swing.text.AbstractDocument#insertString(int,
	 * java.lang.String, javax.swing.text.AttributeSet)
	 */
	@Override
	public void insertString(int offs, String str, AttributeSet a)
			throws BadLocationException {
		if ((getLength() + str.length()) <= caracteresMaximos)
			super.insertString(offs, str, a);
		else
			Toolkit.getDefaultToolkit().beep();
	}

	/**
	 * @param caracteresMaximos
	 *            the caracteresMaximos to set
	 */
	public void setCaracteresMaximos(int caracteresMaximos) {
		this.caracteresMaximos = caracteresMaximos;
	}

	/**
	 * @return the caracteresMaximos
	 */
	public int getCaracteresMaximos() {
		return caracteresMaximos;
	}

}
