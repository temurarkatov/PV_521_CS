using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
	abstract internal class Triengle:Shape
	{
		public abstract double GetHeight();
		public Triengle(int startX, int startY, int lineWidth, System.Drawing.Color color) :
			base(startX, startY, lineWidth, color){ }

		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Высота треугольника: {GetHeight()}");
			base.Info(e);
		}
	}
}
