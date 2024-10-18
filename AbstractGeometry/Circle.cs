using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle:Shape
	{
		double radius;
		public double Radius
		{
			get => radius;
			set => radius = SizeFilter(value);
		}
		public Circle(
			double radius,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(startX, startY, lineWidth, color)
		{
			Radius = radius;
		}
		public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
		public override double GetPerimeter() => 2 * Math.PI * Radius;
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			//e.Graphics.DrawRectangle(pen, (int)StartX, (int)StartY, (int)Side, (int)Side);
			e.Graphics.DrawEllipse(pen, new RectangleF((int)StartX, (int)StartY, (int)(2 * Radius), (int)(2 * Radius)));
		}
	}
}
