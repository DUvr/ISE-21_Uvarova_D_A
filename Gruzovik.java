
import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Gruzovik extends Car implements Serializable {

	private boolean bamper;
	private boolean kuzov;
	private boolean kolesa;

	transient private Color colorGruz;

	public Gruzovik(int maxSpeed, int count—apacitys, int countPassengers, int weight, Color colorCar, boolean bamper,
			boolean kuzov, boolean kolesa, Color colorGruz) {
		super(maxSpeed, count—apacitys, countPassengers, weight, colorCar);
		// TODO Auto-generated constructor stub
		this.bamper = bamper;
		this.kuzov = bamper;
		this.kolesa = kolesa;
		this.colorGruz = colorGruz;

	}

	protected void drawCarPlane(Graphics g) {
		super.drawCarPlane(g);
		g.setColor(colorGruz);

		if (bamper) {

			g.setColor(Color.BLACK);
			g.drawOval(startX + 80, startY - 6, 20, 20);
			g.drawOval(startX + 80, startY + 35, 20, 20);
			g.drawOval(startX - 57, startY - 6, 70, 20);
			g.drawOval(startX - 57, startY + 35, 70, 20);
			g.drawRect(startX + 80, startY - 6, 15, 15);
			g.drawRect(startX + 80, startY + 40, 15, 15);
			g.drawRect(startX, startY - 6, 14, 15);
			g.drawRect(startX, startY + 40, 14, 15);

			g.setColor(colorGruz);
			g.fillOval(startX + 80, startY - 5, 20, 20);
			g.fillOval(startX + 80, startY + 35, 20, 20);
			g.fillRect(startX + 75, startY, 25, 40);
			g.fillRect(startX + 80, startY - 5, 15, 15);
			g.fillRect(startX + 80, startY + 40, 15, 15);
			g.setColor(colorGruz);
			g.fillOval(startX - 57, startY - 5, 70, 20);
			g.fillOval(startX - 57, startY + 35, 70, 20);
			g.fillOval(startX - 5, startY, 25, 40);
			g.fillOval(startX, startY - 5, 15, 15);
			g.fillOval(startX, startY + 40, 15, 15);

		}
		if (kuzov) {
			g.setColor(colorGruz);
			g.fillRect(startX - 55, startY, 60, 50);
			g.setColor(Color.BLACK);
			g.drawRect(startX - 55, startY, 60, 50);

		}
		if (kolesa) {
			g.setColor(Color.BLACK);
			g.drawRect(startX + 25, startY - 6, 39, 10);
			g.drawRect(startX + 25, startY + 45, 39, 10);

			g.setColor(colorGruz);
			g.fillRect(startX + 25, startY - 5, 40, 10);
			g.fillRect(startX + 25, startY + 45, 40, 10);

		}

	}
	public void setColorGruz(Color f) {
		colorGruz = f;
	}
	private void writeObject(ObjectOutputStream s) throws IOException {
		s.defaultWriteObject();
		s.writeInt(colorBody.getRed());
		s.writeInt(colorBody.getGreen());
		s.writeInt(colorBody.getBlue());
		s.writeInt(colorGruz.getRed());
		s.writeInt(colorGruz.getGreen());
		s.writeInt(colorGruz.getBlue());
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
		 colorGruz = new Color(red1, green1, blue1);
	}
	public String getInfo() {
		// TODO Auto-generated method stub

		return maxSpeed + ";" + count—apacitys + ";" + weight + ";" + colorBody + ";" + countPassengers + ";" + bamper + ";" + bamper+ ";"
				+ kolesa+ ";" +colorGruz;

	}
}