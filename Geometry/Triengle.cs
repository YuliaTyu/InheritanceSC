using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Geometry
{
    internal class Triengle:Shape
    {
        double triangleBase;
        double triangleSide;
        //Height - высота???????
        public double TriangleBase
        {
            get => triangleBase;
            set => triangleBase = FilterSize(value);
        }
        public double TriangleSide
        {
            get => triangleSide;
            set => triangleSide = FilterSize(value);
        }
        public Triengle
            (
            double triangleBase, double triangleSide,
            int startX, int startY, int lineWidth, Color color
            ) : base(startX, startY, lineWidth, color)
        {
            TriangleBase = triangleBase;
            TriangleSide = triangleSide;
        }
       
        public override double GetArea() => triangleBase * TriangleSide/2;
        public override double GetPerimeter() => TriangleBase + TriangleSide * 2;
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
           
        
        }
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Размер стороны: {TriangleSide}");
            Console.WriteLine($"Размер основания: {TriangleBase}");
            base.Info(e);
        }

    }
}
