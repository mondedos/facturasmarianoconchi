/**
 * 
 */
package facturas.swing.estilos;

import java.awt.Component;
import java.util.EventObject;

import javax.swing.AbstractCellEditor;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextArea;
import javax.swing.event.CellEditorListener;
import javax.swing.table.TableCellEditor;

/**
 * @author riprimen
 * 
 */
public class JTexAreaEditor extends AbstractCellEditor implements
		TableCellEditor {
	/**
	 * 
	 */
	private static final long serialVersionUID = 8240798288327142364L;
	private JTextArea textArea;
	private JScrollPane scrollPane;

	public JTexAreaEditor() {
		textArea = new JTextArea();
		scrollPane = new JScrollPane(textArea);
	}

	/*
	 * (non-Javadoc)
	 * 
	 * @see
	 * javax.swing.table.TableCellEditor#getTableCellEditorComponent(javax.swing
	 * .JTable, java.lang.Object, boolean, int, int)
	 */
	@Override
	public Component getTableCellEditorComponent(JTable table, Object value,
			boolean isSelected, int row, int column) {
		String valor = (String) value;

		if (valor.length() == 0) {
			textArea.setText("Escribe aqui");
		}

		textArea.setText((String) value);
		return scrollPane;
	}

	/*
	 * (non-Javadoc)
	 * 
	 * @see javax.swing.CellEditor#getCellEditorValue()
	 */
	@Override
	public Object getCellEditorValue() {
		return textArea.getText();
	}
	
	public boolean isCellEditable(EventObject anEvent)  
    {  
        return true;  
    }  
    public void removeCellEditorListener(CellEditorListener l) { }  
    public boolean shouldSelectCell(EventObject anEvent)  
    {  
        return true;  
    }  
    public boolean stopCellEditing()  
    {  
        return true;  
    }  
    public void addCellEditorListener(CellEditorListener l) { }  
    public void cancelCellEditing() { }  
}
