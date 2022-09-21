using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using MiniGameEngine.Examples.Shapes.SineCircles;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Shapes;

public class SineCircle : Circle
{
	private TransitionProperty transitionProperty_6;

	private TransitionProperty transitionProperty_7;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_4;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private SineCircleType sineCircleType_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_1;

	public TransitionProperty FrequencyProperty => transitionProperty_6;

	public TransitionProperty DepthProperty => transitionProperty_7;

	public int frequency
	{
		get
		{
			return method_4();
		}
		set
		{
			if (method_4() != value)
			{
				method_5(value);
			}
		}
	}

	public int depth
	{
		get
		{
			return method_6();
		}
		set
		{
			if (method_6() != value)
			{
				method_7(value);
			}
		}
	}

	public int maxDegrees
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
		[CompilerGenerated]
		set
		{
			int_5 = value;
		}
	}

	public SineCircleType type
	{
		get
		{
			return method_8();
		}
		set
		{
			method_9(value);
		}
	}

	public bool Closed
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public SineCircle(Point Position, double Radius, int Frequency, int Depth)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Position, Radius);
		GameObject Reference = this;
		transitionProperty_6 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			frequency = Conversions.ToInteger(Transition.Value);
		});
		Reference = this;
		transitionProperty_7 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			depth = Conversions.ToInteger(Transition.Value);
		});
		maxDegrees = 360;
		method_9(new NormalSineCirclePathType(this));
		Closed = true;
		base.radius = checked((int)Math.Round(Radius));
		base.Position = Position;
		method_5(Frequency);
		method_7(Depth);
	}

	public new string ToString()
	{
		return $"Position:{base.Position},Rotation {base.Rotation},Radius:{base.radius:N2},Frequency:{frequency},Depth:{depth},Type:{type.GetType().Name}";
	}

	[SpecialName]
	[CompilerGenerated]
	private int method_4()
	{
		return int_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_5(int AutoPropertyValue)
	{
		int_3 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private int method_6()
	{
		return int_4;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_7(int AutoPropertyValue)
	{
		int_4 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private SineCircleType method_8()
	{
		return sineCircleType_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_9(SineCircleType AutoPropertyValue)
	{
		sineCircleType_0 = AutoPropertyValue;
	}

	public override void Render(Graphics Graphics)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		if (Closed)
		{
			Graphics.FillClosedCurve((Brush)new SolidBrush(base.fillColor), getPath());
			Graphics.DrawClosedCurve(new Pen(base.lineColor, (float)base.lineWidth), getPath());
		}
		else
		{
			Graphics.DrawCurve(new Pen(base.lineColor, (float)base.lineWidth), getPath());
		}
	}

	public PointF[] getPath()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		List<Point> list = new List<Point>();
		int num = maxDegrees;
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			list.Add(type.getPath(i));
		}
		GraphicsPath val = new GraphicsPath();
		val.AddCurve(list.ToArray());
		return val.get_PathPoints();
	}
}
