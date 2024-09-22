using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GeometryShapes
{
	public abstract class Figure
	{
		public Color ColorFig { get; set; }
		public Figure(Color color) 
		{
			ColorFig = color;
		}
		public abstract double Area();
		public abstract double Perimeter();
		public abstract void DrawFigure(Graphics g, int x, int y);
		
		protected Pen GetPen() => new Pen(Color.Black, 2);  // создание пера (контура)
		protected Brush GetBrush(Color color) => new SolidBrush(ColorFig); // создание кисти (заливки)

		protected void DrawText(Graphics g, string text, int x, int y)
		{
			using (Brush textBrush = new SolidBrush(Color.Black))
			using (Font font = new Font("Arial", 12))
			{
				g.DrawString(text, font, textBrush, x, y); // рисуем текст
			}
		}
	}
}
