using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine.Transitions;

public class ColorTransition : Transition
{
	public ColorTransition(Color A, Color B)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(A, B);
	}

	public ColorTransition(Color StartPosition, Color A, Color B, TimeSpan Duration = default(TimeSpan), bool Enabled = false)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(StartPosition, A, B, Duration, Enabled);
	}

	public override object ConvertFromRaw(double[] rawValues)
	{
		checked
		{
			byte alpha = (byte)Math.Round(Math.Min(255.0, Math.Max(0.0, rawValues[0])));
			byte red = (byte)Math.Round(Math.Min(255.0, Math.Max(0.0, rawValues[1])));
			byte green = (byte)Math.Round(Math.Min(255.0, Math.Max(0.0, rawValues[2])));
			byte blue = (byte)Math.Round(Math.Min(255.0, Math.Max(0.0, rawValues[3])));
			return Color.FromArgb(alpha, red, green, blue);
		}
	}

	public override double[] ConvertToRaw(object obj)
	{
		return new double[4]
		{
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "A", new object[0], (string[])null, (Type[])null, (bool[])null)),
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "R", new object[0], (string[])null, (Type[])null, (bool[])null)),
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "G", new object[0], (string[])null, (Type[])null, (bool[])null)),
			Conversions.ToDouble(NewLateBinding.LateGet(obj, (Type)null, "B", new object[0], (string[])null, (Type[])null, (bool[])null))
		};
	}
}
