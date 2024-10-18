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
	internal class Triangle:Shape
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
		public Triangle(
			double width, double height,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(startX, startY, lineWidth, color)
		{
			Width = width;
			Height = height;
		}
		public override double GetArea() => (Width * Height) / 2;
		public override double GetPerimeter() => Width + 2 * Math.Sqrt(Math.Pow((Width/2),2) + Math.Pow(Height, 2));
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawPolygon(pen, new PointF[3] { new PointF((float)StartX, (float)(StartY + Height)), new PointF((float)(StartX + Width), (float)(StartY + Height)), new PointF((float)(StartX + (Width)/2), (float)StartY) });
		}
	}
}
