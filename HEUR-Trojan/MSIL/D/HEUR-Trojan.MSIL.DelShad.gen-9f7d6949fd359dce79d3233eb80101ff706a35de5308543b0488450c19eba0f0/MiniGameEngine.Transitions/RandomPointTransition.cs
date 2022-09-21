using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class RandomPointTransition : PointTransition
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point point_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point point_1;

	private Random random_0;

	public Point minPosition
	{
		[CompilerGenerated]
		get
		{
			return point_0;
		}
		[CompilerGenerated]
		set
		{
			point_0 = value;
		}
	}

	public Point maxPosition
	{
		[CompilerGenerated]
		get
		{
			return point_1;
		}
		[CompilerGenerated]
		set
		{
			point_1 = value;
		}
	}

	public RandomPointTransition(Point minPosition, Point maxPosition)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(minPosition, maxPosition);
		base.OnRepeat += RandomPointTransition_OnRepeat;
		base.OnReverse += RandomPointTransition_OnReverse;
		random_0 = new Random(new Random().Next(0, int.MaxValue));
		this.minPosition = minPosition;
		this.maxPosition = maxPosition;
	}

	public RandomPointTransition(Point startPosition, Point minPosition, Point maxPosition)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(startPosition, minPosition, maxPosition);
		base.OnRepeat += RandomPointTransition_OnRepeat;
		base.OnReverse += RandomPointTransition_OnReverse;
		random_0 = new Random(new Random().Next(0, int.MaxValue));
		this.minPosition = minPosition;
		this.maxPosition = maxPosition;
	}

	private void RandomPointTransition_OnRepeat(object object_3)
	{
		base.A = RuntimeHelpers.GetObjectValue(base.B);
		base.B = new Point(random_0.Next(minPosition.X, maxPosition.X), random_0.Next(minPosition.Y, maxPosition.Y));
	}

	private void RandomPointTransition_OnReverse(TransitionDirection transitionDirection_1, TransitionDirection transitionDirection_2)
	{
		if (transitionDirection_1 == TransitionDirection.Forward)
		{
			base.B = new Point(random_0.Next(minPosition.X, maxPosition.X), random_0.Next(minPosition.Y, maxPosition.Y));
		}
		else
		{
			base.A = new Point(random_0.Next(minPosition.X, maxPosition.X), random_0.Next(minPosition.Y, maxPosition.Y));
		}
	}
}
