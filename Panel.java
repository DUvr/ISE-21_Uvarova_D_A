import java.awt.Graphics;

import javax.swing.JPanel;

public class Panel extends JPanel{
	
	Parking a;
	public Panel(Parking ae) {
		this.a=ae;
	}
	
	public void paint(Graphics g) {
		g.clearRect(0, 0, this.getWidth(), this.getHeight());
		a.draw(g, this.getWidth(), this.getHeight());
	}
}