using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class KeyListener : BaseListener, IKeyboardEvents
{
	public event KeyEventHandler KeyDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = this.KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyPress, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = this.KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyPress, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler KeyUp
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyUp, value2, val2);
			}
			while (val != val2);
		}
	}

	protected KeyListener(Subscribe subscribe)
		: base(subscribe)
	{
	}

	public void InvokeKeyDown(KeyEventArgsExt e)
	{
		KeyEventHandler keyDown = this.KeyDown;
		if (keyDown != null && !((KeyEventArgs)e).get_Handled() && e.IsKeyDown)
		{
			keyDown.Invoke((object)this, (KeyEventArgs)(object)e);
		}
	}

	public void InvokeKeyPress(KeyPressEventArgsExt e)
	{
		KeyPressEventHandler keyPress = this.KeyPress;
		if (keyPress != null && !((KeyPressEventArgs)e).get_Handled() && !e.IsNonChar)
		{
			keyPress.Invoke((object)this, (KeyPressEventArgs)(object)e);
		}
	}

	public void InvokeKeyUp(KeyEventArgsExt e)
	{
		KeyEventHandler keyUp = this.KeyUp;
		if (keyUp != null && !((KeyEventArgs)e).get_Handled() && e.IsKeyUp)
		{
			keyUp.Invoke((object)this, (KeyEventArgs)(object)e);
		}
	}

	protected override bool Callback(CallbackData data)
	{
		KeyEventArgsExt downUpEventArgs = GetDownUpEventArgs(data);
		IEnumerable<KeyPressEventArgsExt> pressEventArgs = GetPressEventArgs(data);
		InvokeKeyDown(downUpEventArgs);
		foreach (KeyPressEventArgsExt item in pressEventArgs)
		{
			InvokeKeyPress(item);
		}
		InvokeKeyUp(downUpEventArgs);
		return !((KeyEventArgs)downUpEventArgs).get_Handled();
	}

	protected abstract IEnumerable<KeyPressEventArgsExt> GetPressEventArgs(CallbackData data);

	protected abstract KeyEventArgsExt GetDownUpEventArgs(CallbackData data);
}
