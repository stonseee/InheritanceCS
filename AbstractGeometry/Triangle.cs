using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract class Triangle:Shape
	{
		public abstract double GetHeight();
		public Triangle(int startX, int startY, int lineWidth, Color color)
			: base(startX, startY, lineWidth, color) { }
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine($"Высота треугольника: {GetHeight()}");
			base.Info(e);
		}
	}
}
