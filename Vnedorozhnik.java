import java.awt.Color;
import java.awt.Graphics;

public class Vnedorozhnik extends Car {

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
}