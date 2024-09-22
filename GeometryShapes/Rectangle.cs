using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShapes
{
	public  class Rectangle : Figure
	{
		double Width {  get; set; }
		double Height { get; set; }
		public Rectangle(double width, double height,Color color):base(color)
		{
			Width = width;
			Height = height;
		}
		public override void DrawFigure(Graphics g, int x, int y)
		{
			using(Pen pen = GetPen())
			using(Brush brush = GetBrush(ColorFig))
            {
				g.DrawRectangle(pen, x, y, (float)Width, (float)Height);
				g.FillRectangle(brush, x, y,(float)Width, (float)Height);
			}

			DrawText(g, $"Прямоугольник\nПлощадь: {Area()}, \nПериметр: {Perimeter()}", x, y+(int)Height+10);
        }
		public override double Area() => Width * Height;
		public override double Perimeter() => 2 * (Width + Height);
		
	}
}
