using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class RandomDoubleTransition : DoubleTransition
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double double_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double double_1;

	private Random random_0;

	public double minDouble
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
		[CompilerGenerated]
		set
		{
			double_0 = value;
		}
	}

	public double maxDouble
	{
		[CompilerGenerated]
		get
		{
			return double_1;
		}
		[CompilerGenerated]
		set
		{
			double_1 = value;
		}
	}

	public RandomDoubleTransition(double minDouble, double maxDouble)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(minDouble, maxDouble);
		base.OnRepeat += RandomDoubleTransition_OnRepeat;
		base.OnReverse += RandomDoubleTransition_OnReverse;
		random_0 = new Random();
		this.minDouble = minDouble;
		this.maxDouble = maxDouble;
	}

	public RandomDoubleTransition(double currentDouble, double minDouble, double maxDouble)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(currentDouble, minDouble, maxDouble);
		base.OnRepeat += RandomDoubleTransition_OnRepeat;
		base.OnReverse += RandomDoubleTransition_OnReverse;
		random_0 = new Random();
		this.minDouble = minDouble;
		this.maxDouble = maxDouble;
	}

	private void RandomDoubleTransition_OnRepeat(object object_3)
	{
		base.A = RuntimeHelpers.GetObjectValue(base.B);
		base.B = random_0.NextDouble() * maxDouble + minDouble;
	}

	private void RandomDoubleTransition_OnReverse(TransitionDirection transitionDirection_1, TransitionDirection transitionDirection_2)
	{
		if (transitionDirection_1 == TransitionDirection.Forward)
		{
			base.B = random_0.NextDouble() * maxDouble + minDouble;
		}
		else
		{
			base.A = random_0.NextDouble() * maxDouble + minDouble;
		}
	}
}
