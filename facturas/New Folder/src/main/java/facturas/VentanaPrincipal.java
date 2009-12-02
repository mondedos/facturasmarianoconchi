package facturas;

import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Rectangle;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.beans.XMLDecoder;
import java.beans.XMLEncoder;
import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;

import javax.swing.CellEditor;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFileChooser;
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
import javax.swing.filechooser.FileFilter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableColumn;
import javax.swing.table.TableModel;
import javax.swing.text.JTextComponent;
import javax.swing.text.MaskFormatter;

import facturas.PDF.PDFGeneador;
import facturas.beans.FichaCliente;
import facturas.bizzRule.FacturaHelperFactory;
import facturas.bizzRule.IFactura;
import facturas.bizzRule.ILineaFactura;
import facturas.swing.estilos.JTexAreaEditor;
import facturas.swing.estilos.Util;

public class VentanaPrincipal extends JFrame {

	public static int DIGITOS_TELEFONO = 9;
	private static final int SEPARACION_X = 10;
	private static final int SEPARACION_Y = 10;
	private static final String TIPOFICHEROEXPEDIENTE = ".xml";

	private static final long serialVersionUID = 1L;

	private String _valorfila = "";

	private JButton buttonClose = new JButton();

	private JButton buttonHelp = new JButton();

	private JButton buttonOpen = new JButton();

	private JTextField cifjTextField2 = new JFormattedTextField(
			createFormatter("A#######A"));

	private JTextField ciudadjTextField = new JTextField();

	private JTextField codigoPostaljTextField = new JFormattedTextField(
			createFormatter("#####"));

	private Object[] columnNames = { "Descripción", "KM", "€/KM",
			"Horas de espera", "Cantidad" };

	private JTextArea direccionCompnanyia = new JTextArea(10, 10);

	private JFormattedTextField fechajTextField = new JFormattedTextField(
			createFormatter("##/##/####", true));

	private ImageIcon imageClose = new ImageIcon(VentanaPrincipal.class
			.getResource("closefile.gif"));

	private ImageIcon imageHelp = new ImageIcon(VentanaPrincipal.class
			.getResource("help.gif"));

	private ImageIcon imageOpen = new ImageIcon(VentanaPrincipal.class
			.getResource("openfile.gif"));

	private JButton insertarjButton = new JButton();

	private JButton jButton1 = new JButton();

	private JLabel jLabel6Ciudad = new JLabel();

	private JLabel jLabel7CP = new JLabel();

	private JLabel jLabel8Telefono = new JLabel();

	private JLabel jLabelCIF = new JLabel();

	private JLabel jLabelDireccion = new JLabel();

	private JLabel jLabelFecha = new JLabel();

	private JLabel jLabelNombreCompanyia = new JLabel();

	private JLabel jLabelNumeroFactura = new JLabel();

	private JPanel jPanel1 = new JPanel();

	private JScrollPane jScrollPane1 = new JScrollPane();

	private JScrollPane jScrollPaneTabla = new JScrollPane();

	private BorderLayout layoutMain = new BorderLayout();

	private JMenuBar menuBar = new JMenuBar();

	private JMenu menuFile = new JMenu();

	private JMenuItem menuFileExit = new JMenuItem();

	private JMenu menuHelp = new JMenu();

	private JMenuItem menuHelpAbout = new JMenuItem();

	private DefaultTableModel modelo = new DefaultTableModel(columnNames, 0);
	private JTable jTable1 = new JTable(modelo);

	private JTextField nombreCompanyiajTextField1 = new JTextField();

	private JTextField numeroFacturajTextField1 = new JTextField();

	private JPanel panelCenter = new JPanel();

	private JScrollPane scrollPane = new JScrollPane(direccionCompnanyia);

	private JLabel statusBar = new JLabel();

	private JTextField telefonojTextField = new JFormattedTextField(
			createFormatter(Util.PadLeft('#', DIGITOS_TELEFONO)));

	private JToolBar toolBar = new JToolBar();

	public VentanaPrincipal() {
		try {
			jbInit();
		} catch (Exception e) {
			e.printStackTrace();
		}
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

	/***
	 * Crea un formateador de mascara a partir de un string
	 * 
	 * @param mascara
	 * @return MaskFormatter
	 */
	protected MaskFormatter createFormatter(String s) {
		return createFormatter(s, false);
	}

	protected MaskFormatter createFormatter(String s, boolean mostrarMascara) {
		MaskFormatter formatter = null;
		try {
			formatter = new MaskFormatter(s);

			if (mostrarMascara) {
				formatter.setPlaceholderCharacter('_');
			}
		} catch (java.text.ParseException exc) {
			System.err.println("formatter is bad: " + exc.getMessage());
			System.exit(-1);
		}
		return formatter;
	}

	void fileExit_ActionPerformed(ActionEvent e) {
		System.exit(0);
	}

	void helpAbout_ActionPerformed(ActionEvent e) {
		JOptionPane.showMessageDialog(this,
				new VentanaPrincipal_AboutBoxPanel1(), "About",
				JOptionPane.PLAIN_MESSAGE);
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

	private void insertarjButton_mouseClicked(MouseEvent e) {
		Object[] row = { _valorfila, _valorfila, _valorfila, _valorfila,
				_valorfila };

		modelo.addRow(row);
	}

	private void jbInit() throws Exception {

		this.setJMenuBar(menuBar);
		this.getContentPane().setLayout(layoutMain);
		panelCenter.setLayout(null);

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
		buttonOpen.setToolTipText("Abrir Ficha Cliente");
		buttonOpen.setIcon(imageOpen);
		buttonOpen.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {
				abrirFicheroExpediente();
			}

		});

		buttonClose.setToolTipText("Guardar Ficha Cliente");
		buttonClose.setIcon(imageClose);
		buttonClose.addMouseListener(new MouseAdapter() {
			@Override
			public void mouseClicked(MouseEvent e) {

				if (validarMinimosRellenos()) {
					preguntarGuardar();
				}
			}

		});

		buttonHelp.setToolTipText("About");
		buttonHelp.setIcon(imageHelp);
		jPanel1.setBounds(new Rectangle(-5, 0, 530, 165));
		jPanel1.setLayout(null);
		jTable1.setShowGrid(true);
		jScrollPane1.setBounds(new Rectangle(0, 135, 490, 135));
		jScrollPane1.setBounds(new Rectangle(125, 135, 2, 2));

		jButton1.setText("Imprimir");
		jButton1.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {
				imprimirjButton_mouseClicked(e);
			}
		});
		insertarjButton.setText("Insertar Fila");

		insertarjButton.addMouseListener(new MouseAdapter() {
			public void mouseClicked(MouseEvent e) {
				insertarjButton_mouseClicked(e);
			}
		});

		ponerTextoLabel(jLabelNombreCompanyia, nombreCompanyiajTextField1,
				"Nombre Compañía");
		jLabelNombreCompanyia.setBounds(new Rectangle(10, 5, 95, 20));

		nombreCompanyiajTextField1.setBounds(jLabelNombreCompanyia.getX()
				+ jLabelNombreCompanyia.getWidth(), jLabelNombreCompanyia
				.getY(), 270, jLabelNombreCompanyia.getHeight());

		ponerTextoLabel(jLabelNumeroFactura, numeroFacturajTextField1,
				"Nº Factura");
		jLabelNumeroFactura.setBounds(new Rectangle(nombreCompanyiajTextField1
				.getX()
				+ nombreCompanyiajTextField1.getWidth() + SEPARACION_X,
				nombreCompanyiajTextField1.getY(), 60, jLabelNombreCompanyia
						.getHeight()));

		numeroFacturajTextField1.setBounds(new Rectangle(jLabelNumeroFactura
				.getX()
				+ jLabelNumeroFactura.getWidth(), nombreCompanyiajTextField1
				.getY(), 65, jLabelNombreCompanyia.getHeight()));

		ponerTextoLabel(jLabelDireccion, direccionCompnanyia, "Dirección");
		jLabelDireccion.setBounds(new Rectangle(jLabelNombreCompanyia.getX(),
				jLabelNombreCompanyia.getHeight() + SEPARACION_Y, 155,
				jLabelNombreCompanyia.getHeight()));
		// direccionCompnanyia.setBounds(new
		// Rectangle(nombreCompanyiajTextField1.getX(), jLabelDireccion.getY(),
		// 350, 40));
		scrollPane.setBounds(nombreCompanyiajTextField1.getX(), jLabelDireccion
				.getY(), 155, 60);

		ponerTextoLabel(jLabel6Ciudad, ciudadjTextField, "Ciudad");
		jLabel6Ciudad.setBounds(new Rectangle(jLabelDireccion.getX(),
				scrollPane.getY() + scrollPane.getHeight() + SEPARACION_Y, 50,
				jLabelNombreCompanyia.getHeight()));
		ciudadjTextField.setBounds(new Rectangle(jLabel6Ciudad.getX()
				+ jLabel6Ciudad.getWidth(), jLabel6Ciudad.getY(), 110,
				jLabelNombreCompanyia.getHeight()));

		ponerTextoLabel(jLabel7CP, codigoPostaljTextField, "CP");
		jLabel7CP.setBounds(new Rectangle(ciudadjTextField.getX()
				+ ciudadjTextField.getWidth() + SEPARACION_X, ciudadjTextField
				.getY(), 45, jLabelNombreCompanyia.getHeight()));
		codigoPostaljTextField.setBounds(new Rectangle(jLabel7CP.getX()
				+ jLabel7CP.getWidth(), jLabel7CP.getY(), 85,
				jLabelNombreCompanyia.getHeight()));

		ponerTextoLabel(jLabelFecha, fechajTextField, "Fecha de Facturación");
		jLabelFecha.setBounds(new Rectangle(codigoPostaljTextField.getX()
				+ codigoPostaljTextField.getWidth() + SEPARACION_X,
				codigoPostaljTextField.getY(), 110, jLabelNombreCompanyia
						.getHeight()));
		fechajTextField.setBounds(new Rectangle(jLabelFecha.getX()
				+ jLabelFecha.getWidth(), jLabelFecha.getY(), 70,
				jLabelNombreCompanyia.getHeight()));

		ponerTextoLabel(jLabel8Telefono, telefonojTextField, "Teléfono");
		jLabel8Telefono
				.setBounds(new Rectangle(jLabel6Ciudad.getX(), jLabel6Ciudad
						.getY()
						+ jLabel6Ciudad.getHeight() + SEPARACION_Y,
						jLabel6Ciudad.getWidth(), jLabel6Ciudad.getHeight()));
		telefonojTextField
				.setBounds(new Rectangle(jLabel8Telefono.getX()
						+ jLabel8Telefono.getWidth(), jLabel8Telefono.getY(),
						ciudadjTextField.getWidth(), jLabelNombreCompanyia
								.getHeight()));
		// telefonojTextField.setDocument( new VentanaPrincipal(13));

		ponerTextoLabel(jLabelCIF, cifjTextField2, "CIF/NIF");
		jLabelCIF.setBounds(new Rectangle(telefonojTextField.getX()
				+ telefonojTextField.getWidth() + SEPARACION_X, jLabel8Telefono
				.getY(), 45, jLabelNombreCompanyia.getHeight()));
		cifjTextField2.setBounds(new Rectangle(jLabelCIF.getX()
				+ jLabelCIF.getWidth(), jLabelCIF.getY(),
				codigoPostaljTextField.getWidth(), jLabelNombreCompanyia
						.getHeight()));

		jScrollPaneTabla.setBounds(new Rectangle(jLabel8Telefono.getX(),
				jLabelCIF.getY() + jLabelCIF.getHeight() + SEPARACION_Y, 505,
				175));

		insertarjButton.setBounds(new Rectangle(200, jScrollPaneTabla.getY()
				+ jScrollPaneTabla.getHeight() + SEPARACION_Y, 130, 20));

		this.setSize(new Dimension(531, 451));

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
		jPanel1.add(jLabel7CP, null);
		jPanel1.add(jLabel6Ciudad, null);
		jPanel1.add(ciudadjTextField, null);
		jPanel1.add(jScrollPane1, null);
		jPanel1.add(cifjTextField2, null);
		jPanel1.add(jLabelCIF, null);
		jPanel1.add(fechajTextField, null);
		jPanel1.add(jLabelFecha, null);
		jPanel1.add(numeroFacturajTextField1, null);
		jPanel1.add(jLabelNumeroFactura, null);
		jPanel1.add(jLabelNombreCompanyia, null);
		jPanel1.add(nombreCompanyiajTextField1, null);

		jPanel1.add(jLabelDireccion, null);

		// jTable1
		// _panelScroll.add(jTable1);

		// jPanel1.add(scrollPane, new GridBagConstraints(3, 0, 1, 1, 1.0, 1.0,
		// GridBagConstraints.CENTER, GridBagConstraints.BOTH, new Insets(5, 0,
		// 140, 70), 0, 0));
		// scrollPane.setBounds(nombreCompanyiajTextField1.getX(), 30, 155, 40);
		jPanel1.add(scrollPane, null);
		jPanel1.add(telefonojTextField, null);
		panelCenter.add(jScrollPane1, null);
		jScrollPaneTabla.getViewport().add(jTable1, null);
		panelCenter.add(insertarjButton, null);
		panelCenter.add(jScrollPaneTabla, null);
		panelCenter.add(jPanel1, null);

		ajustarCamposTable(jTable1);

	}

	private void ponerTextoLabel(JLabel label, JTextComponent texto,
			String string) {
		label.setText(string + ":");
		texto.setToolTipText(string);
	}

	/***
	 * Asigna valores a los miembros de una factura, según los datos recogidos
	 * del formulario.
	 * 
	 * @param factura
	 * @return
	 */
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

		if (validarMinimosRellenos() && !fecha.equals("")) {
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
				JOptionPane
						.showMessageDialog(null,
								"El número de factura debe ser un número entero positivo.");
				exito = false;
			}
			factura.setFecha(fecha);
		} else
			exito = false;
		if (exito) {
			rellenarLineas(factura);
		}

		return exito;
	}

	/***
	 * Valida si podemos continuar con las operaciones en función de los
	 * parametros de entrada
	 * 
	 * @return
	 */
	private boolean validarMinimosRellenos() {
		String cif, direccion, nombre, ciudad, cp;

		cif = cifjTextField2.getText();
		direccion = direccionCompnanyia.getText();
		nombre = nombreCompanyiajTextField1.getText();
		ciudad = ciudadjTextField.getText();
		cp = codigoPostaljTextField.getText();
		return !cif.equals("") && !direccion.equals("") && !nombre.equals("")
				&& !ciudad.equals("") && !cp.equals("");
	}

	private void abrirFicheroExpediente() {
		JFileChooser fc = crearDialogoFichero();
		fc.showOpenDialog(this);

		if (fc.getSelectedFile() != null) {

			obtenerExpediente(fc.getSelectedFile().getAbsolutePath());
		}

	}

	private void preguntarGuardar() {
		JFileChooser fc = crearDialogoFichero();
		fc.showSaveDialog(this);

		if (fc.getSelectedFile() != null) {

			String fichero = fc.getSelectedFile().getAbsolutePath();
			if (!fichero.toLowerCase().endsWith(TIPOFICHEROEXPEDIENTE)) {
				fichero += TIPOFICHEROEXPEDIENTE;
			}

			guardarFicha(fichero);
		}
	}

	private JFileChooser crearDialogoFichero() {
		JFileChooser fc = new JFileChooser() {
			/**
			 * 
			 */
			private static final long serialVersionUID = -6962615330830525359L;

			@Override
			public void approveSelection() {
				File f = getSelectedFile();
				if (f.exists() && getDialogType() == SAVE_DIALOG) {
					int result = JOptionPane
							.showConfirmDialog(
									getTopLevelAncestor(),
									"El archivo seleccionado ya existe. ¿Desea sobreescribirlo?",
									"El archivo ya existe",
									JOptionPane.YES_NO_CANCEL_OPTION,
									JOptionPane.QUESTION_MESSAGE);
					switch (result) {
					case JOptionPane.YES_OPTION:
						super.approveSelection();
						return;
					case JOptionPane.NO_OPTION:
						return;
					case JOptionPane.CANCEL_OPTION:
						cancelSelection();
						return;
					}
				}
				super.approveSelection();
			}
		};

		fc.setFileFilter(new FileFilter() {

			@Override
			public String getDescription() {
				return "Ficheros de Fichas de cliente";
			}

			@Override
			public boolean accept(File f) {
				return f.isDirectory()
						|| f.getName().toLowerCase().endsWith(
								TIPOFICHEROEXPEDIENTE);
			}
		});
		return fc;
	}

	private void guardarFicha(String fichero) {
		FichaCliente ficha = new FichaCliente();
		String cif, direccion, nombre, ciudad, cp;

		cif = cifjTextField2.getText();
		direccion = direccionCompnanyia.getText();
		nombre = nombreCompanyiajTextField1.getText();
		ciudad = ciudadjTextField.getText();
		cp = codigoPostaljTextField.getText();

		ficha.setCif(cif);
		ficha.setDireccion(direccion);
		ficha.setNombre(nombre);
		ficha.setCiudad(ciudad);
		ficha.setCodigoPostal(cp);

		if (!telefonojTextField.getText().equals(
				Util.PadLeft('_', DIGITOS_TELEFONO))) {
			ficha.setTelefono(telefonojTextField.getText());
		}

		try {
			XMLEncoder cofificador = new XMLEncoder(new BufferedOutputStream(
					new FileOutputStream(fichero)));

			cofificador.writeObject(ficha);
			cofificador.close();
		} catch (FileNotFoundException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}

	}

	private void obtenerExpediente(String fichero) {
		try {
			XMLDecoder dec = new XMLDecoder(new BufferedInputStream(
					new FileInputStream(fichero)));

			FichaCliente ficha = (FichaCliente) dec.readObject();
			dec.close();

			cifjTextField2.setText(ficha.getCif());
			direccionCompnanyia.setText(ficha.getDireccion());
			nombreCompanyiajTextField1.setText(ficha.getNombre());
			ciudadjTextField.setText(ficha.getCiudad());
			codigoPostaljTextField.setText(ficha.getCodigoPostal());

			telefonojTextField.setText(ficha.getTelefono());

		} catch (FileNotFoundException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} catch (java.util.NoSuchElementException e) {
			JOptionPane.showMessageDialog(null, String.format(
					"El fichero %s no es un fichero de Ficha de cliente",
					fichero));
		}
	}

	/***
	 * Crea una instancia de linea de factura, por cada fila que contenga la
	 * tabla.
	 * 
	 * @param factura
	 */
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
}
