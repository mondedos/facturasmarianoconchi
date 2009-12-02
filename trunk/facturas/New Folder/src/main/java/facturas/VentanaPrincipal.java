package facturas;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.GridBagConstraints;
import java.awt.Insets;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.text.NumberFormat;

import javax.swing.CellEditor;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFormattedTextField;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.JTextArea;
import javax.swing.JTextField;
import javax.swing.JToolBar;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableColumn;
import javax.swing.table.TableModel;
import javax.swing.text.MaskFormatter;

import facturas.PDF.PDFGeneador;
import facturas.bizzRule.FacturaHelperFactory;
import facturas.bizzRule.IFactura;
import facturas.bizzRule.ILineaFactura;
import facturas.swing.estilos.JTexAreaEditor;
import facturas.swing.estilos.Util;

public class VentanaPrincipal extends JFrame {

	public static int DIGITOS_TELEFONO = 13;

	private String _valorfila = "";

	private static final long serialVersionUID = 1L;

	private Object[] columnNames = { "Descripción", "KM", "€/KM",
			"Horas de espera", "Cantidad" };

	private BorderLayout layoutMain = new BorderLayout();

	private JPanel panelCenter = new JPanel();

	private JMenuBar menuBar = new JMenuBar();

	private JMenu menuFile = new JMenu();

	private JMenuItem menuFileExit = new JMenuItem();

	private JMenu menuHelp = new JMenu();

	private JMenuItem menuHelpAbout = new JMenuItem();

	private JLabel statusBar = new JLabel();

	private JToolBar toolBar = new JToolBar();

	private JButton buttonOpen = new JButton();

	private JButton buttonClose = new JButton();

	private JButton buttonHelp = new JButton();

	private ImageIcon imageOpen = new ImageIcon(VentanaPrincipal.class
			.getResource("openfile.gif"));

	private ImageIcon imageClose = new ImageIcon(VentanaPrincipal.class
			.getResource("closefile.gif"));

	private ImageIcon imageHelp = new ImageIcon(VentanaPrincipal.class
			.getResource("help.gif"));

	private JPanel jPanel1 = new JPanel();

	private JLabel jLabelNombreCompanyia = new JLabel();

	private JTextField nombreCompanyiajTextField1 = new JTextField();

	private JLabel jLabelDireccion = new JLabel();

	private JTextArea direccionCompnanyia = new JTextArea(10,10);

	private JLabel jLabelNumeroFactura = new JLabel();

	private JFormattedTextField numeroFacturajTextField1 = new JFormattedTextField(
			NumberFormat.getNumberInstance());

	private JLabel jLabelFecha = new JLabel();

	private JFormattedTextField fechajTextField = new JFormattedTextField(
			createFormatter("##/##/####"));

	private JLabel jLabelCIF = new JLabel();

	private JTextField cifjTextField2 = new JTextField();

	private DefaultTableModel modelo = new DefaultTableModel(columnNames, 0);

	private JTable jTable1 = new JTable(modelo);

	private JScrollPane jScrollPane1 = new JScrollPane();

	private JScrollPane jScrollPaneTabla = new JScrollPane();

	private JButton jButton1 = new JButton();

	private JButton insertarjButton = new JButton();

	private JTextField ciudadjTextField = new JTextField();

	private JLabel jLabel6 = new JLabel();

	private JLabel jLabel7 = new JLabel();

	private JTextField codigoPostaljTextField = new JFormattedTextField(
			createFormatter("#####"));

	private JTextField telefonojTextField = new JFormattedTextField(
			createFormatter(Util.PadLeft('#', DIGITOS_TELEFONO)));

	private JLabel jLabel8Telefono = new JLabel();

	private JScrollPane scrollPane=new JScrollPane(direccionCompnanyia, JScrollPane.VERTICAL_SCROLLBAR_ALWAYS, JScrollPane.HORIZONTAL_SCROLLBAR_ALWAYS);
	
	public VentanaPrincipal() {
		try {
			jbInit();
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	private void jbInit() throws Exception {

		this.setJMenuBar(menuBar);
		this.getContentPane().setLayout(layoutMain);
		panelCenter.setLayout(null);
		this.setSize(new Dimension(531, 441));
		this.setTitle("Facturas Taxi. Mariano y Conchi");
		menuFile.setText("Archivo");
		menuFileExit.setText("Salir");
		menuFileExit.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent ae) {
				fileExit_ActionPerformed(ae);
			}
		});
		menuHelp.setText("Ayuda");
		menuHelpAbout.setText("Sobre");
		menuHelpAbout.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent ae) {
				helpAbout_ActionPerformed(ae);
			}
		});
		statusBar.setText("");
		buttonOpen.setToolTipText("Open File");
		buttonOpen.setIcon(imageOpen);
		buttonClose.setToolTipText("Close File");
		buttonClose.setIcon(imageClose);
		buttonHelp.setToolTipText("About");
		buttonHelp.setIcon(imageHelp);
		jPanel1.setBounds(new Rectangle(-5, 0, 530, 165));
		jPanel1.setLayout(null);
		jTable1.setShowGrid(true);
		jScrollPane1.setBounds(new Rectangle(0, 135, 490, 135));
		jScrollPane1.setBounds(new Rectangle(125, 135, 2, 2));
		jScrollPaneTabla.setBounds(new Rectangle(5, 140, 515, 175));
		jButton1.setText("Imprimir");
		jButton1.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {
				imprimirjButton_mouseClicked(e);
			}
		});
		insertarjButton.setText("Insertar Fila");
		insertarjButton.setBounds(new Rectangle(200, 330, 130, 20));
		insertarjButton.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {
				insertarjButton_mouseClicked(e);
			}
		});
		jLabelNombreCompanyia.setText("Nombre Compañía:");
		jLabelNombreCompanyia.setBounds(new Rectangle(10, 5, 165, 10));
		
		nombreCompanyiajTextField1.setBounds(105, 5, 270, 20);
		
		
		jLabelNumeroFactura.setText("Nº Factura:");
		jLabelNumeroFactura.setBounds(new Rectangle(385, nombreCompanyiajTextField1.getY(), 60, 20));

		numeroFacturajTextField1.setBounds(new Rectangle(jLabelNumeroFactura.getX()+jLabelNumeroFactura.getWidth(), nombreCompanyiajTextField1.getY(), 65, 20));
		
		
		telefonojTextField.setBounds(new Rectangle(60, 110, 110, 20));
		// telefonojTextField.setDocument( new VentanaPrincipal(13));
		jLabel8Telefono.setText("Teléfono:");
		jLabel8Telefono.setBounds(new Rectangle(5, 110, 60, 15));
		ciudadjTextField.setBounds(new Rectangle(55, 75, 110, 20));
		jLabel6.setText("Ciudad:");
		jLabel6.setBounds(new Rectangle(5, 80, 55, 15));
		jLabel7.setText("CP:");
		jLabel7.setBounds(new Rectangle(170, 75, 38, 14));
		codigoPostaljTextField.setBounds(new Rectangle(195, 75, 85, 20));


		jLabelDireccion.setText("Dirección:");
		jLabelDireccion.setBounds(new Rectangle(10, 30, 155, 15));
		direccionCompnanyia.setBounds(new Rectangle(nombreCompanyiajTextField1.getX(), 30, 350, 40));

		
		jLabelFecha.setText("Fecha de Facturación:");
		jLabelFecha.setBounds(new Rectangle(285, 75, 165, 15));
		fechajTextField.setBounds(new Rectangle(430, 75, 95, 20));
		jLabelCIF.setText("CIF/NIF:");
		jLabelCIF.setBounds(new Rectangle(240, 105, 65, 15));
		cifjTextField2.setBounds(new Rectangle(310, 100, 215, 20));
		menuFile.add(menuFileExit);
		menuBar.add(menuFile);
		menuHelp.add(menuHelpAbout);
		menuBar.add(menuHelp);
		this.getContentPane().add(statusBar, BorderLayout.SOUTH);
		toolBar.add(buttonOpen);
		toolBar.add(buttonClose);
		toolBar.add(buttonHelp);
		toolBar.add(jButton1, null);
		this.getContentPane().add(toolBar, BorderLayout.NORTH);
		this.getContentPane().add(panelCenter, BorderLayout.CENTER);
		
		jPanel1.add(jLabel8Telefono, null);
		jPanel1.add(codigoPostaljTextField, null);
		jPanel1.add(jLabel7, null);
		jPanel1.add(jLabel6, null);
		jPanel1.add(ciudadjTextField, null);
		jPanel1.add(jScrollPane1, null);
		jPanel1.add(cifjTextField2, null);
		jPanel1.add(jLabelCIF, null);
		jPanel1.add(fechajTextField, null);
		jPanel1.add(jLabelFecha, null);
		jPanel1.add(numeroFacturajTextField1, null);
		jPanel1.add(jLabelNumeroFactura, null);
		jPanel1.add(jLabelNombreCompanyia,null);
		jPanel1.add(nombreCompanyiajTextField1,null);// new GridBagConstraints(1, 0, 1,				1, 1.0, 0.0, GridBagConstraints.WEST,				GridBagConstraints.HORIZONTAL, new Insets(5, 0, 140, 0), 0, 0));
		jPanel1.add(jLabelDireccion, new GridBagConstraints(2, 0, 1, 1, 0.0, 0.0,
				GridBagConstraints.WEST, GridBagConstraints.NONE, new Insets(5,
						0, 143, 0), 0, 0));

		// jTable1
		// _panelScroll.add(jTable1);
		
		//jPanel1.add(scrollPane, new GridBagConstraints(3, 0, 1, 1,				1.0, 1.0, GridBagConstraints.CENTER, GridBagConstraints.BOTH,				new Insets(5, 0, 140, 70), 0, 0));
		scrollPane.setBounds(nombreCompanyiajTextField1.getX(), 30, 155, 40);
		jPanel1.add(scrollPane, null);
		jPanel1.add(telefonojTextField, null);
		panelCenter.add(jScrollPane1, null);
		jScrollPaneTabla.getViewport().add(jTable1, null);
		panelCenter.add(insertarjButton, null);
		panelCenter.add(jScrollPaneTabla, null);
		panelCenter.add(jPanel1, null);

		ajustarCamposTable(jTable1);

	}

	/***
	 * Crea un formateador de mascara a partir de un string
	 * 
	 * @param mascara
	 * @return MaskFormatter
	 */
	protected MaskFormatter createFormatter(String s) {
		MaskFormatter formatter = null;
		try {
			formatter = new MaskFormatter(s);

			formatter.setPlaceholderCharacter('_');
		} catch (java.text.ParseException exc) {
			System.err.println("formatter is bad: " + exc.getMessage());
			System.exit(-1);
		}
		return formatter;
	}

	/**
	 * Ajusta los campos de la tabla a la medida del formato pdf
	 * 
	 * @param table
	 */
	void ajustarCamposTable(JTable table) {
		table.setRowHeight(50);
		TableColumn column = null;
		column = table.getColumnModel().getColumn(0);
		// column.setCellRenderer(new CustomRenderer());
		column.setCellEditor(new JTexAreaEditor());
		column.setPreferredWidth(350);

		for (int i = 1; i < 5; i++) {
			column = table.getColumnModel().getColumn(i);
			column.setPreferredWidth(50);
		}

	}

	void fileExit_ActionPerformed(ActionEvent e) {
		System.exit(0);
	}

	void helpAbout_ActionPerformed(ActionEvent e) {
		JOptionPane.showMessageDialog(this,
				new VentanaPrincipal_AboutBoxPanel1(), "About",
				JOptionPane.PLAIN_MESSAGE);
	}

	private void insertarjButton_mouseClicked(MouseEvent e) {
		Object[] row = { _valorfila, _valorfila, _valorfila, _valorfila,
				_valorfila };

		modelo.addRow(row);
	}

	private void imprimirjButton_mouseClicked(MouseEvent e) {
		IFactura factura = FacturaHelperFactory.createFactura();

		boolean exito = rellenarFactura(factura);

		PDFGeneador g = new PDFGeneador();

		if (exito && g.checkDependencies()) {
			g.set_factura(factura);
			g.init();
		}
	}

	private boolean rellenarFactura(IFactura factura) {
		boolean exito = true;

		String cif, direccion, nombre, ciudad, cp, telefono, fecha;

		cif = cifjTextField2.getText();
		direccion = direccionCompnanyia.getText();
		nombre = nombreCompanyiajTextField1.getText();
		ciudad = ciudadjTextField.getText();
		cp = codigoPostaljTextField.getText();
		telefono = telefonojTextField.getText();
		fecha = fechajTextField.getText();

		if (!cif.equals("") && !direccion.equals("") && !nombre.equals("")
				&& !ciudad.equals("") && !cp.equals("") && !fecha.equals("")) {
			factura.setCif(cif);
			factura.setDireccion(direccion);
			factura.setNombreCompanyia(nombre);
			factura.setCiudad(ciudad);
			factura.setCodigoPostal(cp);
			factura.setTelefono(telefono);
			try {
				Integer numero = Integer.parseInt(numeroFacturajTextField1
						.getText());
				factura.setNumeroFactura(numero);
			} catch (NumberFormatException e) {
				factura.setNumeroFactura(0);
			}
			factura.setFecha(fecha);
		} else
			exito = false;
		if (exito) {
			rellenarLineas(factura);
		}

		return exito;
	}

	private void rellenarLineas(IFactura factura) {
		TableModel modelo = jTable1.getModel();
		int numFilas = modelo.getRowCount();

		for (int i = 0; i < numFilas; i++) {
			ILineaFactura linea = FacturaHelperFactory.createLineaFactura();

			String km = (String) modelo.getValueAt(i, 1);
			String precioKm = (String) modelo.getValueAt(i, 2);
			String horas = (String) modelo.getValueAt(i, 3);
			String total = (String) modelo.getValueAt(i, 4);

			// obtenemos el valor del textArea
			CellEditor edit = jTable1.getCellEditor(i, 0);

			linea.setDescripcion(edit.getCellEditorValue().toString());
			linea.setKilometros(toCeroF(km));
			linea.setPrecioKilometro(toCeroF(precioKm));
			linea.setHorasEspera(toCero(horas));
			linea.setTotal(toCeroF(total));

			if (!total.equals(""))
				factura.addLineaFactura(linea);
		}

	}

	/***
	 * Parsea una cadena en un float que representa kilometros
	 * 
	 * @param km
	 * @return kilometros
	 */
	private float toCeroF(String km) {
		float f;
		try {
			f = Float.parseFloat(km);
		} catch (NumberFormatException e) {
			f = 0.0F;
		}
		return f;
	}

	/***
	 * Parsea una cadena en un entero que representa kilometros
	 * 
	 * @param km
	 * @return kilometros
	 */
	private int toCero(String km) {
		int f;
		try {
			f = Integer.parseInt(km);
		} catch (NumberFormatException e) {
			f = 0;
		}
		return f;

	}
}
