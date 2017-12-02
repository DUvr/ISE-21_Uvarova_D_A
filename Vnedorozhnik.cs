﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class Vnedorozhnik : Car
    {
        private bool sideBamper;
        private bool Zapaska;
        private bool Koleso;
        private Color dopColor;
        public Vnedorozhnik(int maxSpeed, int maxCountPassenger, int maxCountToplivo, double weight, Color color,
        bool frontSpoiler, bool backSpoiler, bool sideSpoiler, Color dopColor) : 
base(maxSpeed, maxCountPassenger, maxCountToplivo, weight, color) 
{
            this.sideBamper= frontSpoiler;
            this.Zapaska = backSpoiler;
            this.Koleso = sideSpoiler;
            this.dopColor = dopColor;
        }
        protected override void drawLightCar(Graphics g)
        {
            if (sideBamper)
            {
                Brush spoiler = new SolidBrush(dopColor);
                
                g.FillRectangle(spoiler, startPosX -25 , startPosY, 20, 100);
                g.FillEllipse(spoiler, startPosX - 27, startPosY - 10, 20, 20);
                g.FillEllipse(spoiler, startPosX - 27, startPosY+90 , 20, 15);

                g.FillRectangle(spoiler, startPosX + 212, startPosY, 15, 100);
                g.FillEllipse(spoiler, startPosX +212, startPosY - 10, 15, 20);
                g.FillEllipse(spoiler, startPosX +212, startPosY + 90, 15, 15);
            }
            if (Koleso)
            {
                
                Brush brB = new SolidBrush(Color.Brown);
                g.FillRectangle(brB, startPosX + 10, startPosY - 10, 40, 10);
                g.FillRectangle(brB, startPosX + 160, startPosY -10, 40, 10);

                g.FillRectangle(brB, startPosX + 10, startPosY + 100, 40, 10);
                g.FillRectangle(brB, startPosX + 160, startPosY + 100, 40, 10);

            }
            base.drawLightCar(g);
            if (Zapaska)
            {
                Brush sp = new SolidBrush(ColorBody);
                g.FillRectangle(sp, startPosX -25, startPosY+25, 15, 50);
                Pen pen = new Pen(Color.Black);
                g.DrawRectangle(pen, startPosX - 25, startPosY+25, 15, 50);
            }
        }

    public void SetDopColor(Color color)
        {
            dopColor = color;

        }

}
}
