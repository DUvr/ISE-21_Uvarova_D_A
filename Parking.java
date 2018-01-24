import java.awt.Color;
import java.awt.Graphics;
import java.io.Serializable;
import java.util.ArrayList;



public class Parking implements Serializable {

	ArrayList<ClassArray<ITransport>> parking;

	int countPlaces = 20;
	int placeWidth = 250;
	int placeHeight = 150;
	int currentLevel;

	public Parking(int countStages) {
		parking = new ArrayList<ClassArray<ITransport>>(countStages);
		for (int i = 0; i < countStages; i++) {
			parking.add(new ClassArray<ITransport>(countPlaces, null));
		}
	}

	public int getCurrentLevel() {
		return currentLevel;
	}

	public void levelUp() {
		if (currentLevel + 1 < parking.size())
			currentLevel++;
	}

	public void levelDown() {
		if (currentLevel > 0)
			currentLevel--;
	}

	public int putPlaneInParking(ITransport plane) {
		return parking.get(currentLevel).plus(parking.get(currentLevel), plane);
	}

	public ITransport getPlaneInParking(int index) {
		return parking.get(currentLevel).minus(parking.get(currentLevel), index);
	}

	public void draw(Graphics g, int width, int height) {
		drawMarking(g);
		for (int i = 0; i < countPlaces; i++) {
			ITransport plane = parking.get(currentLevel).getPlane(i);
			if (plane != null) {
				plane.setPosition(5 + i / 5 * placeWidth + 65, i % 5 * placeHeight + 15);
				plane.draw(g);
			}
		}

	}

	public void drawMarking(Graphics g) {
		g.setColor(Color.BLACK);
		for(int i = 0; i < countPlaces / 5; i++)
		{
			for(int j = 0; j < 6; j++)
			{
				g.drawLine( i * placeWidth+35, j * placeHeight,i * placeWidth +150, j * placeHeight);
			}
			g.drawLine( i * placeWidth+35, 0, i * placeWidth+35,800);
		}

	}

}