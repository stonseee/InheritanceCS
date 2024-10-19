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
			
			Rectangle rectangle = new Rectangle(100, 50, 700, 50, 3, System.Drawing.Color.Red);
			rectangle.Info(e);
			Square square = new Square(75, 900, 50, 1, System.Drawing.Color.DarkBlue);
			square.Info(e);
			Circle circle = new Circle(50, 700, 250, 5, System.Drawing.Color.Yellow);
			circle.Info(e);
			//Triangle triangle = new Triangle(200, 300, 900, 350, 3, System.Drawing.Color.Red);
			//triangle.Info(e);
		}
		[DllImport("kernel32.dll")]
		private static extern IntPtr GetConsoleWindow();

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
