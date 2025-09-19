using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace Geometry
{
    internal class Circle:Shape, IHaveDiameter
    {
        double radius;
        public double Radius
        {
            get => radius;
            set => radius = FilterSize(value);
        }
        public Circle
            (
            double radius,
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            Radius = radius;
        }
        public double GetDiameter() => 2 * Radius;
        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
        public override double GetPerimeter() => 2 * Math.PI * Radius;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawEllipse(pen, StartX, StartY, 2 * (float)Radius, 2 * (float)Radius);
            DrawDiameter(e);
        }
        public void DrawDiameter(System.Windows.Forms.PaintEventArgs e)
        {
            int dx = (int)(Radius * (1 - 1 / Math.Sqrt(2)));
            e.Graphics.DrawLine
            (
            new Pen(Color, 1),
            StartX + dx, StartY + dx,
                    StartX + (int)GetDiameter() - dx, StartY + (int)GetDiameter() - dx
                );
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Радиус круга: {Radius}");
            base.Info(e);
        }
    }
}
