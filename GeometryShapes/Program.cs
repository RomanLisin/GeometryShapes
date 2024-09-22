using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Net.Security;
using System.Windows.Forms;

namespace GeometryShapes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DrawingFigure figure = new DrawingFigure();

			figure.ShowDialog();
		}

	}
}
