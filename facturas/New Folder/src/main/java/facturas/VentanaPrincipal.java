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
import javax.swing.ImageIcon;
import javax.swing.JButton;
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

import facturas.PDF.PDFGeneador;
import facturas.bizzRule.FacturaHelperFactory;
import facturas.bizzRule.IFactura;
import facturas.bizzRule.ILineaFactura;

public class VentanaPrincipal extends JFrame {

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

	private JLabel jLabel1 = new JLabel();

	private JTextField nombreCompanyiajTextField1 = new JTextField();

	private JLabel jLabel2 = new JLabel();

	private JTextArea direccionCompnanyia = new JTextArea();

	private JLabel jLabel3 = new JLabel();

	private JTextField numeroFacturajTextField1 = new JTextField();

	private JLabel jLabel4 = new JLabel();

	private JTextField fechajTextField = new JTextField();

	private JLabel jLabel5 = new JLabel();

	private JTextField cifjTextField2 = new JTextField();

	private DefaultTableModel modelo = new DefaultTableModel(columnNames, 0);

	private JTable jTable1 = new JTable(modelo);

	private JScrollPane jScrollPane1 = new JScrollPane();

	private JScrollPane jScrollPane2 = new JScrollPane();

	private JButton jButton1 = new JButton();

	private JButton insertarjButton = new JButton();

	private JTextField ciudadjTextField = new JTextField();

	private JLabel jLabel6 = new JLabel();

	private JLabel jLabel7 = new JLabel();

	private JTextField codigoPostaljTextField = new JTextField();

	private JTextField telefonojTextField = new JTextField();

	private JLabel jLabel8 = new JLabel();

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
		jScrollPane2.setBounds(new Rectangle(5, 140, 515, 175));
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
		telefonojTextField.setBounds(new Rectangle(60, 110, 110, 20));
		jLabel8.setText("Teléfono");
		jLabel8.setBounds(new Rectangle(5, 110, 60, 15));
		ciudadjTextField.setBounds(new Rectangle(55, 75, 110, 20));
		jLabel6.setText("Ciudad");
		jLabel6.setBounds(new Rectangle(5, 80, 55, 15));
		jLabel7.setText("CP:");
		jLabel7.setBounds(new Rectangle(170, 75, 38, 14));
		codigoPostaljTextField.setBounds(new Rectangle(195, 75, 85, 20));
		jLabel1.setText("Nombre Compañia:");
		jLabel1.setBounds(new Rectangle(10, 10, 165, 10));
		nombreCompanyiajTextField1.setSize(new Dimension(7, 200));
		nombreCompanyiajTextField1.setBounds(new Rectangle(175, 5, 200, 20));
		jLabel2.setText("Dirección:");
		jLabel2.setBounds(new Rectangle(10, 30, 155, 15));
		direccionCompnanyia.setBounds(new Rectangle(175, 30, 350, 40));
		jLabel3.setText("Nº Factura");
		jLabel3.setBounds(new Rectangle(385, 5, 85, 20));
		numeroFacturajTextField1.setBounds(new Rectangle(460, 5, 65, 20));
		jLabel4.setText("Fecha de Facturación:");
		jLabel4.setBounds(new Rectangle(285, 75, 165, 15));
		fechajTextField.setBounds(new Rectangle(430, 75, 95, 20));
		jLabel5.setText("CIF/NIF");
		jLabel5.setBounds(new Rectangle(240, 105, 65, 15));
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
		nombreCompanyiajTextField1.setSize(200, 20);
		jPanel1.add(jLabel8, null);
		jPanel1.add(codigoPostaljTextField, null);
		jPanel1.add(jLabel7, null);
		jPanel1.add(jLabel6, null);
		jPanel1.add(ciudadjTextField, null);
		jPanel1.add(jScrollPane1, null);
		jPanel1.add(cifjTextField2, null);
		jPanel1.add(jLabel5, null);
		jPanel1.add(fechajTextField, null);
		jPanel1.add(jLabel4, null);
		jPanel1.add(numeroFacturajTextField1, null);
		jPanel1.add(jLabel3, null);
		jPanel1.add(jLabel1, new GridBagConstraints(0, 0, 1, 1, 0.0, 0.0,
				GridBagConstraints.WEST, GridBagConstraints.NONE, new Insets(5,
						69, 143, 0), 0, 0));
		jPanel1.add(nombreCompanyiajTextField1, new GridBagConstraints(1, 0, 1,
				1, 1.0, 0.0, GridBagConstraints.WEST,
				GridBagConstraints.HORIZONTAL, new Insets(5, 0, 140, 0), 0, 0));
		jPanel1.add(jLabel2, new GridBagConstraints(2, 0, 1, 1, 0.0, 0.0,
				GridBagConstraints.WEST, GridBagConstraints.NONE, new Insets(5,
						0, 143, 0), 0, 0));

		// jTable1
		// _panelScroll.add(jTable1);
		jPanel1.add(direccionCompnanyia, new GridBagConstraints(3, 0, 1, 1,
				1.0, 1.0, GridBagConstraints.CENTER, GridBagConstraints.BOTH,
				new Insets(5, 0, 140, 70), 0, 0));
		jPanel1.add(telefonojTextField, null);
		panelCenter.add(jScrollPane1, null);
		jScrollPane2.getViewport().add(jTable1, null);
		panelCenter.add(insertarjButton, null);
		panelCenter.add(jScrollPane2, null);
		panelCenter.add(jPanel1, null);

		ajustarCamposTable(jTable1);

	}

	/**
	 * Ajusta los campos de la tabla a la medida del formato pdf
	 *
	 * @param table
	 */
	void ajustarCamposTable(JTable table) {
		TableColumn column = null;
		column = table.getColumnModel().getColumn(0);
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
		// TODO Auto-generated method stub
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
				&& !ciudad.equals("") && !cp.equals("") && !telefono.equals("")
				&& !fecha.equals("")) {
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
			rellenarLíneas(factura);
		}

		return exito;
	}

	private void rellenarLíneas(IFactura factura) {
		TableModel modelo = jTable1.getModel();
		int numFilas = modelo.getRowCount();

		for (int i = 0; i < numFilas; i++) {
			ILineaFactura linea = FacturaHelperFactory.createLineaFactura();

			String km = (String) modelo.getValueAt(i, 1);
			String precioKm = (String) modelo.getValueAt(i, 2);
			String horas = (String) modelo.getValueAt(i, 3);
			String total = (String) modelo.getValueAt(i, 4);

			linea.setDescripcion(modelo.getValueAt(i, 0).toString());
			linea.setKilometros(toCeroF(km));
			linea.setPrecioKilometro(toCeroF(precioKm));
			linea.setHorasEspera(toCero(horas));
			linea.setTotal(toCeroF(total));

			if (!total.equals(""))
				factura.addLineaFactura(linea);
		}

	}

	private float toCeroF(String km) {
		float f;
		try {
			f = Float.parseFloat(km);
		} catch (NumberFormatException e) {
			f = 0.0F;
		}
		return f;
	}

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
