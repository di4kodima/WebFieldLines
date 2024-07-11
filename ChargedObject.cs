using System.Drawing;

namespace BlazorApp3
{
	public abstract class ChargedObject
	{
		protected ChargedObject(Point position, double charge)
		{
			Position = position;
			Charge = charge;
		}

		public double Charge { get; set; }
		public Point Position { get; set; }

		public abstract double GetField(double x, double y);
	}
}
