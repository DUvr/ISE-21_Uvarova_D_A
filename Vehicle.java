import java.awt.Color;
import java.awt.Graphics;

public abstract class Vehicle implements ITransport {

	protected int startX;
	protected int startY;
	public int maxSpeed;
	public int weight;
	public int countPassengers;

	public int count—apacitys;
	transient public Color colorBody;

	protected abstract void setmaxSpeed(int s);

	public abstract int getmaxSpeed();

	protected abstract void setWeight(int w);

	public abstract int getWeight();

	protected abstract void setcountPassengers(int h);

	public abstract int getcountPassengers();

	protected abstract void setcount—apacitys(int h);

	public abstract int getcount—apacitys();

	public abstract void move(Graphics g);

	public abstract void draw(Graphics g);

	public void setPosition(int x, int y) {
		startX = x;
		startY = y;
	}
	public void setMainColor(Color c) {
		colorBody = c;
	}
	public abstract String getInfo();
}