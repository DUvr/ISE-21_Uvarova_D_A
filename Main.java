
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Font;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JList;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;

import java.awt.event.ActionListener;
import java.awt.event.ActionEvent;





public class Main {
	private JFrame frame;
	Parking parking;

	private Frame btnColor;
	private Frame btnSelectGruzovikColor;
	private JTextField numPlace;
	JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;
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
	
		initialize();
	    
		for (int i = 0; i < 5; i++) {
			elements[i] = "Уровень " + (i+1);
		}

		listLevels.setSelectedIndex(parking.getCurrentLevel());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1420, 852);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		

		JPanel panel = new Panel(parking);
		panel.setBounds(12, 11, 986, 474);
		frame.getContentPane().add(panel);
		
		

		JButton btnSetPlane = new JButton("Припарковать авто");
		btnSetPlane.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null, "Выберите основной цвет", null);
				if (colorDialog != null) {
					ITransport plane = new Car(1000, 100, 30, 30, colorDialog);
					int place = parking.putPlaneInParking(plane);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "Ваше место: " + place);
				}

			}
		});
		btnSetPlane.setBounds(1026, 107, 199, 39);
		frame.getContentPane().add(btnSetPlane);

		JButton btnSetVnedorozhnik = new JButton("\u041F\u0440\u0438\u043F\u0430\u0440\u043A\u043E\u0432\u0430\u0442\u044C \u0432\u043D\u0435\u0434\u043E\u0440\u043E\u0436\u043D\u0438\u043A");
		btnSetVnedorozhnik.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		btnSetVnedorozhnik.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "Выберите основной цвет", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null, "Выберите дополительный цвет", null);
					if (colorDialog != null) {
						ITransport plane = new  Vnedorozhnik(1000, 100, 30, 30, colorDialog1, true, true,true, colorDialog);
						int place = parking.putPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "Ваше место: " + place);
					}
				}

				

			}
		});
		btnSetVnedorozhnik.setBounds(1026, 195, 266, 39);
		frame.getContentPane().add(btnSetVnedorozhnik);

		JPanel panelTake = new JPanel();
		panelTake.setForeground(Color.BLACK);
		panelTake.setBackground(Color.WHITE);
		panelTake.setBounds(1026, 357, 291, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("Забрать машину");
		btnTake.setForeground(Color.BLUE);
		btnTake.setBackground(Color.LIGHT_GRAY);
		btnTake.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnTake.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {
				
				if(checkPlace(numPlace.getText())) {
					ITransport plane = parking.getPlaneInParking(Integer.parseInt(numPlace.getText()));
					Graphics gr = panelTake.getGraphics();
					gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
					plane.setPosition(60, 5);
					plane.draw(gr);
					panel.repaint();
				}
				
			}
		});
		btnTake.setBounds(1154, 269, 163, 62);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("Место:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblNewLabel.setForeground(Color.MAGENTA);
		lblNewLabel.setBounds(899, 336, 57, 33);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setFont(new Font("Tahoma", Font.PLAIN, 15));
		numPlace.setBounds(1026, 287, 86, 28);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);
		
	
	
	listLevels = new JList(elements);
	listLevels.setForeground(Color.BLUE);
	listLevels.setFont(new Font("Tahoma", Font.PLAIN, 12));
	listLevels.setBackground(Color.LIGHT_GRAY);
	listLevels.setBounds(1246, 11, 144, 135);
	frame.getContentPane().add(listLevels);

	JButton btnLevelDown = new JButton("<<");
	btnLevelDown.setBackground(Color.LIGHT_GRAY);
	btnLevelDown.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent arg0) {
			parking.levelDown();
			listLevels.setSelectedIndex(parking.getCurrentLevel());
			panel.repaint();
		}
	});
	btnLevelDown.setBounds(1246, 159, 71, 23);
	frame.getContentPane().add(btnLevelDown);

	JButton btnLevelUp = new JButton(">>");
	btnLevelUp.setBackground(Color.LIGHT_GRAY);
	btnLevelUp.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			parking.levelUp();
			listLevels.setSelectedIndex(parking.getCurrentLevel());
			panel.repaint();
		}
	});
	btnLevelUp.setBounds(1319, 159, 71, 23);
	frame.getContentPane().add(btnLevelUp);

}
	
	private boolean checkPlace(String str) {
		try {
			Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
		}

		if(Integer.parseInt(str)>20) return false;
		return true;
	}

	
}