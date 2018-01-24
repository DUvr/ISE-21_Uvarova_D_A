
import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Vnedorozhnik extends Car implements Serializable {

	private boolean sideBamper;
	private boolean Zapaska;
	private boolean kolesa;

	private Color dopColor;

	public Vnedorozhnik(int maxSpeed, int countToplivo, int countPassengers, int weight, Color colorCar, boolean bamper,
			boolean zapaska, boolean kolesa, Color dopcolor) {
		super(maxSpeed, countToplivo, countPassengers, weight, colorCar);
		// TODO Auto-generated constructor stub
		this.sideBamper = bamper;
		this.Zapaska = zapaska;
		this.kolesa = kolesa;
		this.dopColor = dopcolor;

	}

	protected void drawCarPlane(Graphics g) {
		super.drawCarPlane(g);
		g.setColor(dopColor);

		if (sideBamper) {

			g.setColor(Color.BLACK);
			g.fillRect(startX -25 , startY, 20, 100);
            g.fillOval(startX - 27, startY - 10, 20, 20);
            g.fillOval(startX - 27, startY+90 , 20, 15);

            g.fillRect(startX + 212, startY, 15, 100);
            g.fillOval(startX +212, startY - 10, 15, 20);
            g.fillOval(startX +212, startY + 90, 15, 15);

		}
		if (Zapaska) {
			g.setColor(dopColor);
			g.fillRect(startX -25, startY+25, 15, 50);
			g.drawRect(startX - 25, startY+25, 15, 50);

		}
		if (kolesa) {
			g.setColor(Color.darkGray);
			 g.fillRect(startX + 10, startY - 10, 40, 10);
             g.fillRect(startX + 160, startY -10, 40, 10);

             g.fillRect(startX + 10, startY + 100, 40, 10);
             g.fillRect(startX + 160, startY + 100, 40, 10);

		}

	}
	public void setColorGruz(Color f) {
		dopColor = f;
	}
	private void writeObject(ObjectOutputStream s) throws IOException {
		s.defaultWriteObject();
		s.writeInt(colorBody.getRed());
		s.writeInt(colorBody.getGreen());
		s.writeInt(colorBody.getBlue());
		s.writeInt(dopColor.getRed());
		s.writeInt(dopColor.getGreen());
		s.writeInt(dopColor.getBlue());
	}
	private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
		 s.defaultReadObject();
		 int red = s.readInt();
		 int green = s.readInt();
		 int blue = s.readInt();
		 colorBody = new Color(red, green, blue);
		 int red1 = s.readInt();
		 int green1 = s.readInt();
		 int blue1 = s.readInt();
		 dopColor = new Color(red1, green1, blue1);
	}
	public String getInfo() {
		// TODO Auto-generated method stub

		return maxSpeed + ";" + countToplivo + ";" + weight + ";" + colorBody + ";" + countPassengers + ";" + Zapaska + ";" + sideBamper+ ";"
				+ kolesa+ ";" +dopColor;

	}
}