using System;
using Microsoft.VisualBasic.CompilerServices;

namespace MiniGameEngine.Transitions;

public class DoubleTransition : Transition
{
	public DoubleTransition(double A, double B)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(A, B);
	}

	public DoubleTransition(double StartPosition, double A, double B, TimeSpan Duration = default(TimeSpan), bool Enabled = false)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(StartPosition, A, B, Duration, Enabled);
	}

	public override object ConvertFromRaw(double[] rawValues)
	{
		return rawValues[0];
	}

	public override double[] ConvertToRaw(object obj)
	{
		return new double[1] { Conversions.ToDouble(obj) };
	}
}
