using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using MiniGameEngine.Examples.Shapes;

namespace MiniGameEngine.Examples.Droplets;

public abstract class Droplets
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Scene scene_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TimeSpan timeSpan_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color color_0;

	public int dropletCount
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int dropletRadius
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public TimeSpan MovementDuration
	{
		[CompilerGenerated]
		get
		{
			return timeSpan_0;
		}
		[CompilerGenerated]
		set
		{
			timeSpan_0 = value;
		}
	}

	public Color dropletColor
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

	[SpecialName]
	[CompilerGenerated]
	internal Scene method_0()
	{
		return scene_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(Scene AutoPropertyValue)
	{
		scene_0 = AutoPropertyValue;
	}

	public Droplets(Scene Scene)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		dropletCount = 5;
		dropletRadius = 25;
		MovementDuration = TimeSpan.FromMilliseconds(800.0);
		dropletColor = Color.White;
		method_1(Scene);
	}

	public void Spawn(Point Center)
	{
		_ = new Color[6]
		{
			Color.Red,
			Color.Green,
			Color.Blue,
			Color.Yellow,
			Color.Orange,
			Color.Purple
		};
		checked
		{
			dropletRadius = (int)Math.Floor(new Random().NextDouble() * 85.0 + 15.0);
			dropletColor = Color.LightSkyBlue;
			int num = dropletCount;
			for (int i = 1; i <= num; i++)
			{
				Circle currentCircle = new Circle(Center, 1.0)
				{
					lineColor = dropletColor,
					lineWidth = 1
				};
				method_0().add(currentCircle);
				vmethod_0(i, ref currentCircle);
			}
		}
	}

	internal abstract void vmethod_0(int i, ref Circle currentCircle);
}
