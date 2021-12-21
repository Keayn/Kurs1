using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Kyrsovai
{
    public class RotatingEmitter : Emitter
    {   
        public Point Center;
        public int CircleRadius;
        public int Angle = 1;
        public int Speed = 1; // скорость вращение частицы , начальная 1 
        
        public override void UpdateState()
        {
            X = (int)(Center.X + CircleRadius * Math.Sin(ToRadians(Angle)));
            Y = (int)(Center.Y - CircleRadius * Math.Cos(ToRadians(Angle)));
            Direction = Angle * (-1) - 180;
            Angle += Speed;
            base.UpdateState();
        }

        public override void Render(Graphics g)
        {
            base.Render(g);
            // рисуем окружность 
            g.DrawEllipse(
                new Pen(Color.Red),
                Center.X - CircleRadius,
                Center.Y - CircleRadius,
                CircleRadius * 2,
                CircleRadius * 2
            );
        }

        private static double ToRadians(int degrees)
        {
            return degrees / 180.0 * Math.PI;
        }
    }
}
