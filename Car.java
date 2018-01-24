import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class Car extends Vehicle implements Serializable { 

	public Car(int maxSpeed, int countСapacitys, int countPassengers, int weight, Color colorCar) {
		this.maxSpeed = maxSpeed;
		this.countСapacitys = countСapacitys;
		this.weight = weight;
		this.colorBody = colorCar;
		this.countPassengers = countPassengers;

		startX = 60;
		startY = 100;

	}

	@Override
	protected void setmaxSpeed(int s) {
		// TODO Auto-generated method stub
		if (s > 0 && s < 250)
			super.maxSpeed = s;
		else
			super.maxSpeed = 200;
	}

	@Override
	public int getmaxSpeed() {
		// TODO Auto-generated method stub
		return super.maxSpeed;
	}

	@Override
	protected void setWeight(int w) {
		// TODO Auto-generated method stub
		if (w > 16000 && w < 35000)
			super.weight = w;
		else
			super.weight = 30000;
	}

	@Override
	public int getWeight() {
		// TODO Auto-generated method stub
		return super.weight;
	}

	@Override
	protected void setcountPassengers(int h) {
		// TODO Auto-generated method stub
		if (h > 0 && h < 8)
			super.countPassengers = h;
		else
			super.countPassengers = 5;
	}

	@Override
	public int getcountPassengers() {
		// TODO Auto-generated method stub
		return super.countPassengers;
	}

	protected void setcountСapacitys(int h) {
		// TODO Auto-generated method stub
		if (h > 0 && h < 8000)
			super.countСapacitys = h;
		else
			super.countСapacitys = 5000;
	}

	@Override
	public int getcountСapacitys() {
		// TODO Auto-generated method stub
		return super.countСapacitys;
	}

	@Override
	public void move(Graphics g) {
		// TODO Auto-generated method stub
		startX += (int) (getmaxSpeed() * 50 / getWeight() / (countСapacitys == 0 ? 1 : countСapacitys));
		draw(g);
	}

	@Override
	public void draw(Graphics g) {
		// TODO Auto-generated method stub
		drawCarPlane(g);
	}
	
	protected void drawCarPlane(Graphics g) {
		g.setColor(colorBody);
		g.drawOval(startX, startY, 20, 20);
		g.drawOval(startX, startY + 30, 20, 20);
		g.drawOval(startX + 70, startY, 20, 20);
		g.drawOval(startX + 70, startY + 30, 20, 20);
		g.drawRect(startX - 1, startY + 10, 10, 30);
		g.drawRect(startX + 80, startY + 10, 10, 30);
		g.drawRect(startX + 10, startY - 1, 70, 52);

		// задние фары
		g.setColor(Color.RED);
		g.fillOval(startX, startY, 20, 20);
		g.fillOval(startX, startY + 30, 20, 20);

		// передние фары
		g.setColor(Color.YELLOW);
		g.fillOval(startX + 70, startY, 20, 20);
		g.fillOval(startX + 70, startY + 30, 20, 20);

		// кузов
		g.setColor(colorBody);
		g.fillRect(startX - 50, startY + 10, 60, 30);
		g.fillRect(startX + 80, startY + 10, 10, 30);
		g.fillRect(startX + 10, startY, 70, 50);

		// стекла
		g.setColor(Color.BLUE);
		g.fillRect(startX + 60, startY + 5, 5, 40);
		g.fillRect(startX + 20, startY + 5, 5, 40);
		g.fillRect(startX + 25, startY + 3, 35, 2);
		g.fillRect(startX + 25, startY + 46, 35, 2);

		// выделяем рамкой крышу
		g.setColor(Color.BLACK);
		g.drawRect(startX + 25, startY + 5, 35, 40);
		g.drawRect(startX + 65, startY + 10, 25, 30);
		g.drawRect(startX, startY + 10, 15, 30);

	}
	@Override
		public String getInfo() {
			// TODO Auto-generated method stub
			return maxSpeed + ";" + countСapacitys + ";" + weight + ";" + countPassengers + ";" + colorBody;
	
		}
		
		private void writeObject(ObjectOutputStream s) throws IOException {
	        s.defaultWriteObject();
	        s.writeInt(colorBody.getRed());
	        s.writeInt(colorBody.getGreen());
	        s.writeInt(colorBody.getBlue());
	    }
	
	    private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
	        s.defaultReadObject();
	        int red = s.readInt();
	        int green = s.readInt();
	        int blue = s.readInt();
	        colorBody = new Color(red, green, blue);
	    }
	
	 

	@Override
	public void loadPassenger(int count) {
		// TODO Auto-generated method stub

	}

	@Override
	public void loadСapacity(int count) {
		// TODO Auto-generated method stub

	}

	@Override
	public int getPassenger() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int getСapacity() {
		// TODO Auto-generated method stub
		return 0;
	}

}