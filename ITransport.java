import java.awt.Color;
import java.awt.Graphics;

public interface ITransport {
	void draw(Graphics g);

	void move(Graphics g);

	void setPosition(int x, int y);

	void loadPassenger(int count);

	void load—apacity(int count);

	int getPassenger();

	int get—apacity();
	void setMainColor(Color color);
	String getInfo();
}