import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.Component;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;
import java.awt.Font;


public class Main {
private JFrame frame;
private JTextField textMaxSpeed;
private JTextField textCountToplivo;
private JTextField textWeight;
private JTextField textCountPassengers;

Color color;
Color dopColor;
int maxSpeed;
int weight;
int countPassengers;
int countToplivo;
boolean sideBamper;
boolean Zapaska;
boolean kolesa;

private ITransport interTran;
private Frame btnColor;
private Frame btnSelectFigtherColor;

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
	color = Color.RED;
	dopColor = Color.BLACK;
	maxSpeed = 150;
	countToplivo = 9;
	weight = 1500;
	countPassengers = 5;

	initialize();

}

/**
 * Initialize the contents of the frame.
 */
private void initialize() {
	frame = new JFrame();
	frame.setBounds(100, 100, 857, 552);
	frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
	frame.getContentPane().setLayout(null);

	textMaxSpeed = new JTextField();
	textMaxSpeed.setBounds(106, 227, 86, 20);
	frame.getContentPane().add(textMaxSpeed);
	textMaxSpeed.setColumns(10);

	textCountToplivo = new JTextField();
	textCountToplivo.setBounds(106, 261, 86, 20);
	frame.getContentPane().add(textCountToplivo);
	textCountToplivo.setColumns(10);

	textWeight = new JTextField();
	textWeight.setBounds(353, 227, 86, 20);
	frame.getContentPane().add(textWeight);
	textWeight.setColumns(10);

	textCountPassengers = new JTextField();
	textCountPassengers.setBounds(368, 261, 86, 20);
	frame.getContentPane().add(textCountPassengers);
	textCountPassengers.setColumns(10);

	JPanel panel = new JPanel();
	panel.setBounds(10, 11, 547, 195);
	frame.getContentPane().add(panel);

	JCheckBox checkBamper = new JCheckBox("Бампера");
	checkBamper.setBounds(548, 226, 97, 23);
	frame.getContentPane().add(checkBamper);

	JCheckBox checkZapaska = new JCheckBox("Запаска");
	checkZapaska.setBounds(548, 260, 97, 23);
	frame.getContentPane().add(checkZapaska);

	JCheckBox checkKolesa = new JCheckBox("Колеса");
	checkKolesa.setBounds(548, 292, 97, 23);
	frame.getContentPane().add(checkKolesa);

	JButton btnDrawPlane = new JButton("Задать авто");
	btnDrawPlane.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {

			if (checkFields()) {
				interTran = new Car(maxSpeed, countToplivo, countPassengers, weight, color);

				Graphics gr = panel.getGraphics();
				gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				interTran.draw(gr);

			}

		}
	});
	btnDrawPlane.setBounds(569, 100, 138, 37);
	frame.getContentPane().add(btnDrawPlane);

	JButton btnDrawVnedorozhnik = new JButton("Задать Внедорожник");
	btnDrawVnedorozhnik.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			if (checkFields()) {
				sideBamper = checkBamper.isSelected();
				Zapaska = checkZapaska.isSelected();
				kolesa = checkKolesa.isSelected();
				interTran = new Vnedorozhnik (countPassengers, countToplivo, weight, maxSpeed, color, Zapaska, kolesa, sideBamper, color);

				Graphics gr = panel.getGraphics();
				gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				interTran.draw(gr);
			}

		}
	});
	btnDrawVnedorozhnik.setBounds(569, 50, 162, 37);
	frame.getContentPane().add(btnDrawVnedorozhnik);

	JButton btnColor = new JButton("Цвет");
	btnColor.setForeground(color);
	btnColor.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent arg0) {

			Color initialBackground = btnColor.getForeground();
			Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
			if (foreground != null) {
				btnColor.setForeground(foreground);
			}
			color = foreground;
		}
	});
	btnColor.setBounds(183, 315, 115, 23);
	frame.getContentPane().add(btnColor);

	JButton btnMove = new JButton("Движение");
	btnMove.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {

			if (interTran != null) {
				Graphics gr = panel.getGraphics();
				gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
				interTran.move(gr);
			}
		}
	});
	btnMove.setBounds(569, 13, 100, 23);
	frame.getContentPane().add(btnMove);

	JButton btnSelectFigtherColor = new JButton("Доп цвет");
	btnSelectFigtherColor.setForeground(dopColor);
	btnSelectFigtherColor.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {

			Color initialBackground = btnSelectFigtherColor.getForeground();
			Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
			if (foreground != null) {
				btnSelectFigtherColor.setForeground(foreground);
			}
			dopColor = foreground;
		}
	});
	btnSelectFigtherColor.setBounds(643, 260, 166, 23);
	frame.getContentPane().add(btnSelectFigtherColor);

	JLabel lblNewLabel = new JLabel("Скорость");
	lblNewLabel.setBounds(20, 229, 86, 17);
	frame.getContentPane().add(lblNewLabel);

	JLabel lblNewLabel_1 = new JLabel("Топливо");
	lblNewLabel_1.setBounds(10, 264, 74, 14);
	frame.getContentPane().add(lblNewLabel_1);

	JLabel texteight = new JLabel("Вес");
	texteight.setBounds(290, 230, 46, 14);
	frame.getContentPane().add(texteight);

	JLabel lblNewLabel_3 = new JLabel("Пасажиры");
	lblNewLabel_3.setBounds(290, 264, 66, 14);
	frame.getContentPane().add(lblNewLabel_3);

}

private boolean checkParse(String str) {
	try {
		Integer.parseInt(str);
	} catch (NumberFormatException e) {
		return false;
	}

	return true;
}

private boolean checkFields() {
	if (checkParse(textMaxSpeed.getText()))
		maxSpeed = Integer.parseInt(textMaxSpeed.getText());
	if (checkParse(textCountToplivo.getText()))
		countToplivo = Integer.parseInt(textCountToplivo.getText());
	if (checkParse(textWeight.getText()))
		weight = Integer.parseInt(textWeight.getText());
	if (checkParse(textCountPassengers.getText()))
		countPassengers = Integer.parseInt(textCountPassengers.getText());

	System.out.println(maxSpeed + " " + countToplivo + " " + weight + " " + countPassengers);

	return true;
}
}
