using System.Drawing;

namespace BlazorApp3
{
	public class PointCharge : ChargedObject
	{
		public PointCharge(Point position, double charge) : base(position, charge)
		{
			base.Position = position;
			base.Charge = charge;
		}

		public override double GetField(double x, double y)
		{
			double k = 8.987551787e9;
			double r = Math.Sqrt(Math.Pow((x - Position.X), 2) + Math.Pow((y - Position.Y), 2));
			return Charge * k / (r * r);
		}
	}
}
