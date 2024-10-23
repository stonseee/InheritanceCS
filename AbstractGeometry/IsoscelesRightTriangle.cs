using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class IsoscelesRightTriangle:RightTriangle
	{
		public IsoscelesRightTriangle
			(
			double side,
			int startX, int startY, int lineWidth, System.Drawing.Color color
			) : base(side, side, startX, startY, lineWidth, color)	{ }
	}
}
