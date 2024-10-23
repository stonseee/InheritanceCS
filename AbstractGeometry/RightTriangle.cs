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
	internal class RightTriangle:Triangle
	{
		double width;
		double height;
		public double Width
		{
			get => width;
			set => width = SizeFilter(value);
		}
		public double Height
		{
			get => height;
			set => height = SizeFilter(value);
		}
		public RightTriangle(
			double width, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}
		public override double GetHeight() => Height;
		public override double GetArea() => Width / 2 * GetHeight();
		public override double GetPerimeter() => 2 * (Width + Height);
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] points = new Point[]
			{
				new Point(StartX, StartY + (int)Height),
				new Point(StartX + (int)Width, StartY + (int)Height),
				new Point
				(
					StartX,
					StartY
				)
			};
			e.Graphics.DrawPolygon(pen, points);
		}
		
	}
}
