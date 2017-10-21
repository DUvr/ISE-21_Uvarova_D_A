using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    class Parking
    {
        ClassArray<ITransport> parking;
        int countPlaces = 20;
        int placesSizeWidth = 250;
        int placeSizeHight = 150;

        public Parking()
        {
            parking = new ClassArray<ITransport>(countPlaces, null);
        }
        public int PutCarInParking(ITransport car)
        {
            return parking + car;
        }
        public ITransport GetCarInParking(int ticket)
        {
            return parking - ticket;
        }
        public void Draw(Graphics g,int width, int heigt)
        {
            DrawMarking(g);
            for(int i=0;i<countPlaces;i++)
            {
                var car = parking.getObject(i);
                if (car!=null)
                {
                    car.setPosition(5 + i / 5 * placesSizeWidth + 25, i % 5 * placeSizeHight + 15);
                    car.drawCar(g);
                }
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (countPlaces / 2) * placeSizeHight, 600);
            g.DrawLine(pen, 0, placeSizeHight,50, placeSizeHight);
            g.DrawLine(pen, 0, placeSizeHight+150, 50, placeSizeHight+150);
            g.DrawLine(pen, 0, placeSizeHight+300, 50, placeSizeHight+300);
            for (int i=0;i<countPlaces/5;i++)
            {
                for (int j=0;j<6;j++)
                {
                    g.DrawLine(pen, i * placesSizeWidth+20, j * placeSizeHight,i * placesSizeWidth + 150, j * placeSizeHight);
                    
                }
                
                g.DrawLine(pen, i * placesSizeWidth+270, 0, i * placesSizeWidth+270, 700);
            }
        }
    }
}
