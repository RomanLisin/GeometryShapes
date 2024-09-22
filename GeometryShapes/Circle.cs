using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
	public class Circle : Figure
	{
		double Radius {  get; set; }
		public Circle(double radius,Color color):base(color)
		{ 
			this.Radius = radius;
		}

		public override double Area()
		{
			return Math.PI*Radius*Radius;
		}

		public override double Perimeter()
		{
			return 2 * Math.PI * Radius;
		}

		public override void DrawFigure(Graphics g, int x, int y)
		{
			using(Pen pen =  GetPen())
			using(Brush brush = GetBrush(ColorFig))
			{
				g.DrawEllipse(pen, x, y, (float)(Radius * 2), (float)(Radius * 2));
				g.FillEllipse(brush, x, y, (float)(Radius * 2), (float)(Radius * 2));
			}
			DrawText(g,$"Круг\nПлощадь: {Area()}, \nПериметр: {Perimeter()}",x,y+(int)(Radius * 2)+20);
		}

	}
}
