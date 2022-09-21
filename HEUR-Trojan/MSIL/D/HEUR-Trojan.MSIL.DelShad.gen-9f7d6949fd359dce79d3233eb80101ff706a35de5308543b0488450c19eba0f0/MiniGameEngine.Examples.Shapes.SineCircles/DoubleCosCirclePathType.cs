using System;
using System.Drawing;

namespace MiniGameEngine.Examples.Shapes.SineCircles;

public class DoubleCosCirclePathType : SineCircleType
{
	public DoubleCosCirclePathType(SineCircle parent)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(parent);
	}

	public override Point getPath(int Degree)
	{
		double radius = sineCircle_0.radius + checked((double)sineCircle_0.frequency * Math.Cos(sineCircle_0.depth * Degree + Degree) * Math.Sin(sineCircle_0.depth * Degree - Degree));
		return Circle.getPoint(radius, Circle.getRadians(Degree) + Circle.getRadians(sineCircle_0.Rotation), sineCircle_0.Position);
	}
}
