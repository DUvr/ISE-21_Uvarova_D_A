import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.filechooser.FileNameExtensionFilter;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.util.Vector;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;
import javax.swing.JList;
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;

public class Main {

	private JFrame frame;
	Parking parking;

	private Frame btnColor;
	private Frame btnSelectGruzColor;
	private JTextField numPlace;
	JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;
	SelectPlane select;
	private static Logger log;

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		parking = new Parking(5);

		log = Logger.getLogger(Main.class.getName());
		FileHandler fh = null;
		try {
			fh = new FileHandler("D:\\log.txt");
		} catch (SecurityException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		log.addHandler(fh);
		initialize();
		for (int i = 0; i < 5; i++) {
			elements[i] = "Уровень " + (i + 1);
		}

		listLevels.setSelectedIndex(parking.getCurrentLevel());

	}

	/**
	 * Initialize the contents of the frame.
	 */

	public void getPlane() {
		select = new SelectPlane(frame);
		if (select.res()) {
			ITransport plane = select.getPlane();
			int place = 0;
			try {
				place = parking.putPlaneInParking(plane);
				log.log(Level.INFO, "Поставили Автомобиль на место " + place);
			} catch (ParkingOverflowException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
				JOptionPane.showMessageDialog(null, "Ошибка переполнения");
			} catch (Exception ex) {
				JOptionPane.showMessageDialog(null, "Общая ошибка");
			}
			panel.repaint();
			System.out.println("Your place: " + place);
		}
	}

	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1164, 610);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		panel = new Panel(parking);
		panel.setBounds(10, 26, 854, 484);
		frame.getContentPane().add(panel);

		JPanel panelTake = new JPanel();
		panelTake.setBounds(901, 11, 237, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать авто");
		btnTake.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				if (checkPlace(numPlace.getText())) {
					ITransport plane = null;
					try {
						plane = parking.getPlaneInParking(Integer.parseInt(numPlace.getText()));
						log.log(Level.INFO, "Забрали автомобиль с места " + numPlace.getText());
					} catch (ParkingIndexOutOfRangeException e) {
						// TODO Auto-generated catch block
						JOptionPane.showMessageDialog(null, "Неверный номер");
					} catch (Exception ex) {
						JOptionPane.showMessageDialog(null, "Общая ошибка");
					}
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
					plane.setPosition(50, 5);
					plane.draw(gr);
					panel.repaint();
				}

			}
		});
		btnTake.setBounds(901, 233, 153, 29);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место");
		lblNewLabel.setBounds(912, 205, 46, 14);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setBounds(968, 202, 86, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

		listLevels = new JList(elements);
		listLevels.setBounds(891, 373, 153, 111);
		frame.getContentPane().add(listLevels);

		JButton btnLevelDown = new JButton("<<");
		btnLevelDown.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				parking.levelDown();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				log.log(Level.INFO, "Спустились на уровень ниже");
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(869, 495, 89, 23);
		frame.getContentPane().add(btnLevelDown);

		JButton btnLevelUp = new JButton(">>");
		btnLevelUp.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				parking.levelUp();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				log.log(Level.INFO, "Поднялись на уровень выше");
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(973, 495, 89, 23);
		frame.getContentPane().add(btnLevelUp);

		JButton btnGetPlane = new JButton("Припарковать авто");
		btnGetPlane.addActionListener(new ActionListener() {
			@SuppressWarnings("deprecation")
			public void actionPerformed(ActionEvent e) {
				getPlane();
			}
		});
		btnGetPlane.setBounds(901, 300, 153, 40);
		frame.getContentPane().add(btnGetPlane);

		JMenuBar menuBar = new JMenuBar();
		JMenu menu = new JMenu("File");
		frame.setJMenuBar(menuBar);
		menuBar.add(menu);
		JMenuItem menuSave = new JMenuItem("Save");
		menu.add(menuSave);
		JMenuItem menuOpen = new JMenuItem("Open");
		menu.add(menuOpen);

		menuSave.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				JFileChooser filesave = new JFileChooser();

				if (filesave.showDialog(null, "Save") == JFileChooser.APPROVE_OPTION) {
					try {
						if (parking.save(filesave.getSelectedFile().getPath()))
							if (filesave.getSelectedFile().getPath() != null) {
								System.out.println("Good");
								log.log(Level.INFO,
										"Сохранили аэродром в файл " + filesave.getSelectedFile().getName());
							}
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
			}
		});

		menuOpen.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				JFileChooser fileopen = new JFileChooser();
				if (fileopen.showDialog(null, "Open") == JFileChooser.APPROVE_OPTION) {
					if (parking.load(fileopen.getSelectedFile().getPath()))
						if (fileopen.getSelectedFile().getPath() != null) {
							System.out.println("Good");
							log.log(Level.INFO,"Загрузили аэродром из файла " + fileopen.getSelectedFile().getName());
						}
				}
				panel.repaint();
			}
		});

	}

	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if (Integer.parseInt(str) > 20)
			return false;
		return true;
	}

}