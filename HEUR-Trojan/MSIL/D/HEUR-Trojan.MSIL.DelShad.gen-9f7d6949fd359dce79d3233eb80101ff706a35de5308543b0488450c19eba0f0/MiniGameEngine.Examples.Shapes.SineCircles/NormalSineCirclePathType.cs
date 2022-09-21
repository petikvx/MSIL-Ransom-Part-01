using System;
using System.Drawing;

namespace MiniGameEngine.Examples.Shapes.SineCircles;

public class NormalSineCirclePathType : SineCircleType
{
	public NormalSineCirclePathType(SineCircle parent)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(parent);
	}

	public override Point getPath(int Degree)
	{
		double radians = Circle.getRadians(Degree);
		double a = (sineCircle_0.radius + (double)sineCircle_0.depth * Math.Sin((double)sineCircle_0.frequency * (radians + Circle.getRadians(sineCircle_0.Rotation)))) * Math.Cos(radians) + (double)sineCircle_0.Position.X;
		double a2 = (sineCircle_0.radius + (double)sineCircle_0.depth * Math.Sin((double)sineCircle_0.frequency * (radians + Circle.getRadians(sineCircle_0.Rotation)))) * Math.Sin(radians) + (double)sineCircle_0.Position.Y;
		return checked(new Point((int)Math.Round(a), (int)Math.Round(a2)));
	}
}
