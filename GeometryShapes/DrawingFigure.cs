using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometryShapes
{
	public partial class DrawingFigure : Form
	{

		List<Figure> figures = new List<Figure>();
		private Random random = new Random();
		public DrawingFigure()
		{
			this.Text = "Figures";
			this.Size = new Size(800, 800);
			//InitializeComponent();
			InitializeFigure();
		}
		Color[] colors = {Color.Red, Color.Blue, Color.Yellow, Color.Green, Color.Purple };
		//Color nextColor = colors[random.Next(colors.Length)];
		private void InitializeFigure()
		{
			figures.Add(new Rectangle(60, 80, colors[random.Next(colors.Length)]));
			figures.Add(new Circle(50, colors[random.Next(colors.Length)]));
			figures.Add(new Triangle(100,80, colors[random.Next(colors.Length)]));
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			int x = 50, y = 30;

			// рисуем в случайном порядке
			for (int i=0;i<figures.Count;i++) 
			{
				figures[random.Next(figures.Count)].DrawFigure(g, x, y);
				y += 200;
				//if (x> this.Width -180)
				//{
				//	y = 150;
				//	x += 150;
				//}	
			}
		}
	}
}
