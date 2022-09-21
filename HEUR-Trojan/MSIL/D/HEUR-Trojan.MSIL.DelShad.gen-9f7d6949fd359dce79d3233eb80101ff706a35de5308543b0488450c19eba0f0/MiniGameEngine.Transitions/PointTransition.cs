using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine.Transitions;

public class PointTransition : Transition
{
	public PointTransition(Point A, Point B)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(A, B);
	}

	public PointTransition(Point StartPosition, Point A, Point B, TimeSpan Duration = default(TimeSpan), bool Enabled = false)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(StartPosition, A, B, Duration, Enabled);
	}

	public override object ConvertFromRaw(double[] rawValues)
	{
		return checked(new Point((int)Math.Round(rawValues[0]), (int)Math.Round(rawValues[1])));
	}

	public override double[] ConvertToRaw(object obj)
	{
		return new double[2]
		{
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "X", new object[0], (string[])null, (Type[])null, (bool[])null)),
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "Y", new object[0], (string[])null, (Type[])null, (bool[])null))
		};
	}
}
