
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Font;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
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
		parking = new Parking();
	
		initialize();
	    
	    
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1191, 852);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		

		JPanel panel = new Panel(parking);
		panel.setBounds(10, 11, 986, 474);
		frame.getContentPane().add(panel);
		
		

		JButton btnSetPlane = new JButton("������������ ����");
		btnSetPlane.setFont(new Font("Tahoma", Font.PLAIN, 16));
		btnSetPlane.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null, "�������� �������� ����", null);
				if (colorDialog != null) {
					ITransport plane = new Car(1000, 100, 30, 30, colorDialog);
					int place = parking.putPlaneInParking(plane);
					panel.repaint();
					JOptionPane.showMessageDialog(null, "���� �����: " + place);
				}

			}
		});
		btnSetPlane.setBounds(86, 498, 199, 39);
		frame.getContentPane().add(btnSetPlane);

		JButton btnSetGruzovik = new JButton("\u041F\u0440\u0438\u043F\u0430\u0440\u043A\u043E\u0432\u0430\u0442\u044C \u0432\u043D\u0435\u0434\u043E\u0440\u043E\u0436\u043D\u0438\u043A");
		btnSetGruzovik.setFont(new Font("Tahoma", Font.PLAIN, 16));
		
		btnSetGruzovik.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "�������� �������� ����", null);
				if (colorDialog1 != null) {
					Color colorDialog = JColorChooser.showDialog(null, "�������� ������������� ����", null);
					if (colorDialog != null) {
						ITransport plane = new  Vnedorozhnik(1000, 100, 30, 30, colorDialog1, true, true,true, colorDialog);
						int place = parking.putPlaneInParking(plane);
						panel.repaint();
						JOptionPane.showMessageDialog(null, "���� �����: " + place);
					}
				}

				

			}
		});
		btnSetGruzovik.setBounds(408, 498, 291, 39);
		frame.getContentPane().add(btnSetGruzovik);

		JPanel panelTake = new JPanel();
		panelTake.setForeground(Color.BLACK);
		panelTake.setBackground(Color.WHITE);
		panelTake.setBounds(548, 599, 291, 170);
		frame.getContentPane().add(panelTake);

		JButton btnTake = new JButton("������� ������");
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
		btnTake.setBounds(266, 599, 163, 62);
		frame.getContentPane().add(btnTake);

		JLabel lblNewLabel = new JLabel("�����:");
		lblNewLabel.setFont(new Font("Tahoma", Font.PLAIN, 16));
		lblNewLabel.setForeground(Color.MAGENTA);
		lblNewLabel.setBounds(899, 336, 57, 33);
		frame.getContentPane().add(lblNewLabel);

		numPlace = new JTextField();
		numPlace.setFont(new Font("Tahoma", Font.PLAIN, 15));
		numPlace.setBounds(103, 599, 86, 28);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);
		
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