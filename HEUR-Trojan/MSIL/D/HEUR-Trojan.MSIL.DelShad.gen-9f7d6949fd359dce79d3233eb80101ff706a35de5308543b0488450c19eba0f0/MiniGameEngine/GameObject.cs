using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using MiniGameEngine.Transitions;

namespace MiniGameEngine;

public abstract class GameObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool xYoUiFwIme;

	public readonly string ID;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Point point_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int int_0;

	private TransitionProperty transitionProperty_0;

	private TransitionProperty transitionProperty_1;

	private int int_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	public Point Position
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

	public int Rotation
	{
		get
		{
			return method_2();
		}
		set
		{
			method_3(Math.Min(360, Math.Max(0, value)));
		}
	}

	public TransitionProperty PositionProperty => transitionProperty_0;

	public TransitionProperty RotationProperty => transitionProperty_1;

	public int zIndex
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public bool Visible
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	internal bool method_0()
	{
		return xYoUiFwIme;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(bool AutoPropertyValue)
	{
		xYoUiFwIme = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private int method_2()
	{
		return int_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(int AutoPropertyValue)
	{
		int_0 = AutoPropertyValue;
	}

	public void Pause()
	{
		method_1(AutoPropertyValue: true);
	}

	public void Resume()
	{
		method_1(AutoPropertyValue: false);
	}

	public void Show()
	{
		Visible = true;
	}

	public void Hide()
	{
		Visible = false;
	}

	public GameObject()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		method_1(AutoPropertyValue: false);
		ID = Guid.NewGuid().ToString();
		Position = new Point(0, 0);
		method_3(0);
		GameObject Reference = this;
		transitionProperty_0 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			object value = Transition.Value;
			Position = ((value != null) ? ((Point)value) : default(Point));
		});
		Reference = this;
		transitionProperty_1 = new TransitionProperty(ref Reference, delegate(ref Transition Transition)
		{
			Rotation = Conversions.ToInteger(Transition.Value);
		});
		int_1 = 0;
		Visible = true;
	}

	public void sendToTop()
	{
		throw new NotImplementedException();
	}

	public void sendToBottom()
	{
		throw new NotImplementedException();
	}

	public abstract void Render(Graphics Graphics);

	public abstract void Update(double delta);
}
