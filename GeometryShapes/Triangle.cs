using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
	internal class Triangle : Figure
	{
		double A { get; set; }
		double B { get; set; }

		public Triangle(double baseLine, double heightLine, Color color) : base(color)
		{
			A = baseLine;
			B = heightLine;
		}
		public override double Area() => 0.5 * A * B;
		public override double Perimeter() => A + 2 * Math.Sqrt((A / 2) * (A / 2) + B * B);
		
		public override void DrawFigure(Graphics g, int x, int y)
		{
			string stroka = $"Треугольник \nПлощадь: {Area()},\nПериметр: {Perimeter()}";
			using (Pen pen = GetPen())
			using(Brush brush = GetBrush(ColorFig))
			{
				Point[] points =
				{
					new Point(x, y),
					new Point(x+(int)A, y),
					new Point(x+(int)(A/2), y+(int)B)
				};
				g.DrawPolygon(pen,points); 
				g.FillPolygon(brush,points);
			}
				DrawText(g,stroka, x, y+(int)B);
		}

	}
}
