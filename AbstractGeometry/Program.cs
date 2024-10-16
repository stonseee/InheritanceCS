﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs( graphics, window_rect );
			
			//Rectangle rectangle = new Rectangle(100, 50, 100, 200, 3, System.Drawing.Color.Red);
			//rectangle.Info(e);
			//Square square = new Square(100, 100, 200, 3, System.Drawing.Color.Red);
			//square.Info(e);
			//Circle circle = new Circle(100, 100, 200, 3, System.Drawing.Color.Red);
			//circle.Info(e);
			Triangle triangle = new Triangle(200, 300, 100, 200, 3, System.Drawing.Color.Red);
			triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
