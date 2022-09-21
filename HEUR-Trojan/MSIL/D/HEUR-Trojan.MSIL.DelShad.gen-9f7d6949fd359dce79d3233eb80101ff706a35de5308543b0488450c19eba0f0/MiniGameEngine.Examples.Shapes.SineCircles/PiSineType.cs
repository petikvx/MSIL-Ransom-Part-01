using System;
using System.Drawing;

namespace MiniGameEngine.Examples.Shapes.SineCircles;

public class PiSineType : SineCircleType
{
	public PiSineType(SineCircle parent)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(parent);
	}

	public override Point getPath(int Degree)
	{
		double radius = sineCircle_0.radius + (double)sineCircle_0.frequency * Math.Cos(Math.PI * Circle.getRadians(Degree)) * Math.Cos(Math.PI + (double)sineCircle_0.depth * Circle.getRadians(Degree));
		return Circle.getPoint(radius, Circle.getRadians(Degree) + Circle.getRadians(sineCircle_0.Rotation), sineCircle_0.Position);
	}
}
