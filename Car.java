import java.awt.Color;
import java.awt.Graphics;

public class Car extends Vehicle {

	public Car(int maxSpeed, int countToplivo, int countPassengers, int weight, Color colorCar) {
		this.maxSpeed = maxSpeed;
		this.countToplivo = countToplivo;
		this.weight = weight;
		this.color = colorCar;
		this.countPassengers = countPassengers;

		startX = 80;
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

	protected void setcountToplivo(int h) {
		// TODO Auto-generated method stub
		if (h > 0 && h < 40)
			super.countToplivo = h;
		else
			super.countToplivo = 15;
	}

	@Override
	public int getcountToplivo() {
		// TODO Auto-generated method stub
		return super.countToplivo;
	}

	@Override
	public void move(Graphics g) {
		// TODO Auto-generated method stub
		startX += (int) (getmaxSpeed() * 50 / getWeight() / (countToplivo == 0 ? 1 : countToplivo));
		draw(g);
	}

	@Override
	public void draw(Graphics g) {
		// TODO Auto-generated method stub
		drawCarPlane(g);
	}

	protected void drawCarPlane(Graphics g) {
		
		// кузов
		g.setColor(color);
        g.fillRect(startX, startY, 100, 50);
        g.fillRect(startX + 180, startY , 30, 100);
		

		// стекла
		g.setColor(Color.BLUE);
		g.fillRect(startX-10, startY, 10, 100);
        g.fillRect(startX + 150, startY, 30, 100);

		// выделяем рамкой крышу
		g.setColor(Color.BLACK);
		 g.drawRect(startX, startY, 150, 100);
         g.drawRect(startX + 180, startY, 30, 100);
         g.drawRect(startX-10, startY, 220, 100);
         
       //фары
         g.setColor(Color.YELLOW);
         g.fillRect(startX+200, startY, 10, 30);
         g.fillRect(startX + 200, startY+70, 10, 30);
         g.setColor(Color.RED);
         g.fillRect(startX -15, startY, 5, 20);
         g.fillRect(startX -15, startY+80 , 5, 20);

	}

	@Override
	public void loadPassenger(int count) {
		// TODO Auto-generated method stub

	}

	@Override
	public void loadToplivo(int count) {
		// TODO Auto-generated method stub

	}

	@Override
	public int getPassenger() {
		// TODO Auto-generated method stub
		return 0;
	}

	@Override
	public int getToplivo() {
		// TODO Auto-generated method stub
		return 0;
	}

}