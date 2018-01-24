import java.awt.Color;
import java.awt.Graphics;
import java.io.BufferedInputStream;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;
import java.util.ArrayList;

import javax.print.DocFlavor.BYTE_ARRAY;

public class Parking implements Serializable {

	ArrayList<ClassArray<ITransport>> parking;

	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;
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

	public int putPlaneInParking(ITransport plane) throws ParkingOverflowException {
		return parking.get(currentLevel).plus(parking.get(currentLevel), plane);
	}

	public ITransport getPlaneInParking(int index) throws ParkingIndexOutOfRangeException {
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
		g.drawRect(0, 0, (countPlaces / 5) * placeWidth, 450);
		for (int i = 0; i < countPlaces / 5; i++) {
			for (int j = 0; j < 6; j++) {
				g.drawLine(i * placeWidth, j * placeHeight, i * placeWidth + 110, j * placeHeight);
			}
			g.drawLine(i * placeWidth, 0, i * placeWidth, 400);
		}

	}

	public boolean save(String fileName) throws IOException {

		FileOutputStream save = null;
		try {
			save = new FileOutputStream(fileName);
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		ObjectOutputStream obSave = new ObjectOutputStream(save);
		obSave.writeObject(parking);

		return true;
	}

	public boolean load(String filename) {
		try {
			ObjectInputStream obLoad = new ObjectInputStream(new BufferedInputStream(new FileInputStream(filename)));
			try {
				parking = (ArrayList<ClassArray<ITransport>>)obLoad.readObject();
			} catch (ClassNotFoundException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return true;
	}

}