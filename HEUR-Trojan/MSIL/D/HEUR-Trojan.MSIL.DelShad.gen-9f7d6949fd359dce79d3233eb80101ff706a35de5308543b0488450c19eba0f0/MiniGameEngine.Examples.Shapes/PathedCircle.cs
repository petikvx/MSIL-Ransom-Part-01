using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Shapes;

public class PathedCircle : GameObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color color_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color color_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_2;

	private TransitionProperty transitionProperty_2;

	private TransitionProperty transitionProperty_3;

	private TransitionProperty vUbtbIgmVK;

	private TransitionProperty transitionProperty_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double double_0;

	public Color fillColor
	{
		[CompilerGenerated]
		get
		{
			return color_0;
		}
		[CompilerGenerated]
		set
		{
			color_0 = value;
		}
	}

	public Color lineColor
	{
		[CompilerGenerated]
		get
		{
			return color_1;
		}
		[CompilerGenerated]
		set
		{
			color_1 = value;
		}
	}

	public int lineWidth
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public TransitionProperty ColorProperty => transitionProperty_2;

	public TransitionProperty FillProperty => transitionProperty_3;

	public TransitionProperty RadiusProperty => vUbtbIgmVK;

	public TransitionProperty lineWidthProperty => transitionProperty_4;

	public double circumference => Math.PI * diameter;

	public double area => Math.PI * (radius * radius);

	public double radius
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

	public double diameter
	{
		get
		{
			return radius * 2.0;
		}
		set
		{
			radius = value / 2.0;
		}
	}

	public PathedCircle(Point position, double radius)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		fillColor = Color.Transparent;
		lineColor = Color.Black;
		lineWidth = 1;
		GameObject Reference = this;
		transitionProperty_2 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			object value2 = Transition.Value;
			lineColor = ((value2 != null) ? ((Color)value2) : default(Color));
		});
		Reference = this;
		transitionProperty_3 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			object value = Transition.Value;
			fillColor = ((value != null) ? ((Color)value) : default(Color));
		});
		Reference = this;
		vUbtbIgmVK = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			this.radius = Conversions.ToDouble(Transition.Value);
		});
		Reference = this;
		transitionProperty_4 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			lineWidth = Conversions.ToInteger(Transition.Value);
		});
		base.Position = position;
		this.radius = radius;
	}

	public GraphicsPath getPath()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		List<PointF> list = new List<PointF>();
		int num = 0;
		do
		{
			list.Add(getPoint(radius, getRadians(num), base.Position));
			num = checked(num + 360);
		}
		while (num <= 360);
		GraphicsPath val = new GraphicsPath();
		val.AddCurve(list.ToArray());
		return val;
	}

	public static Point getPoint(double radius, double radians, Point origin)
	{
		double a = radius * Math.Cos(radians) + (double)origin.X;
		double a2 = radius * Math.Sin(radians) + (double)origin.Y;
		return checked(new Point((int)Math.Round(a), (int)Math.Round(a2)));
	}

	public static double getRadians(double degrees)
	{
		return degrees * (Math.PI / 180.0);
	}

	public static double getDegrees(double radians)
	{
		return radians * (180.0 / Math.PI);
	}

	public override void Render(Graphics Graphics)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Graphics.DrawClosedCurve(new Pen(lineColor), getPath().get_PathPoints());
		Graphics.FillClosedCurve((Brush)new SolidBrush(fillColor), getPath().get_PathPoints());
	}

	public bool inBoundries(Point Point)
	{
		double num = checked(Math.Pow(base.Position.X - Point.X, 2.0) + Math.Pow(base.Position.Y - Point.Y, 2.0));
		return num <= Math.Pow(radius, 2.0);
	}

	public override void Update(double delta)
	{
	}
}
