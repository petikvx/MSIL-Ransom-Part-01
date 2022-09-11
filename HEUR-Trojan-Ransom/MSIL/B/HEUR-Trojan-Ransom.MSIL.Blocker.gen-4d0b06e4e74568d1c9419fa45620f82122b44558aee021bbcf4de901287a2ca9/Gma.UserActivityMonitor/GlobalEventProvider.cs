using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Gma.UserActivityMonitor;

public class GlobalEventProvider : Component
{
	protected override bool CanRaiseEvents => true;

	private event MouseEventHandler m_MouseMove
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseMove, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseMove, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseMove
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_MouseMove == null)
			{
				HookManager.MouseMove += new MouseEventHandler(HookManager_MouseMove);
			}
			m_MouseMove += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_MouseMove -= value;
			if (this.m_MouseMove == null)
			{
				HookManager.MouseMove -= new MouseEventHandler(HookManager_MouseMove);
			}
		}
	}

	private event MouseEventHandler m_MouseClick
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseClick
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_MouseClick == null)
			{
				HookManager.MouseClick += new MouseEventHandler(HookManager_MouseClick);
			}
			m_MouseClick += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_MouseClick -= value;
			if (this.m_MouseClick == null)
			{
				HookManager.MouseClick -= new MouseEventHandler(HookManager_MouseClick);
			}
		}
	}

	private event MouseEventHandler m_MouseDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseDown
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_MouseDown == null)
			{
				HookManager.MouseDown += new MouseEventHandler(HookManager_MouseDown);
			}
			m_MouseDown += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_MouseDown -= value;
			if (this.m_MouseDown == null)
			{
				HookManager.MouseDown -= new MouseEventHandler(HookManager_MouseDown);
			}
		}
	}

	private event MouseEventHandler m_MouseUp
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseUp
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_MouseUp == null)
			{
				HookManager.MouseUp += new MouseEventHandler(HookManager_MouseUp);
			}
			m_MouseUp += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_MouseUp -= value;
			if (this.m_MouseUp == null)
			{
				HookManager.MouseUp -= new MouseEventHandler(HookManager_MouseUp);
			}
		}
	}

	private event MouseEventHandler m_MouseDoubleClick
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.m_MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseDoubleClick
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_MouseDoubleClick == null)
			{
				HookManager.MouseDoubleClick += new MouseEventHandler(HookManager_MouseDoubleClick);
			}
			m_MouseDoubleClick += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_MouseDoubleClick -= value;
			if (this.m_MouseDoubleClick == null)
			{
				HookManager.MouseDoubleClick -= new MouseEventHandler(HookManager_MouseDoubleClick);
			}
		}
	}

	private event EventHandler<MouseEventExtArgs> m_MouseMoveExt;

	public event EventHandler<MouseEventExtArgs> MouseMoveExt
	{
		add
		{
			if (this.m_MouseMoveExt == null)
			{
				HookManager.MouseMoveExt += HookManager_MouseMoveExt;
			}
			m_MouseMoveExt += value;
		}
		remove
		{
			m_MouseMoveExt -= value;
			if (this.m_MouseMoveExt == null)
			{
				HookManager.MouseMoveExt -= HookManager_MouseMoveExt;
			}
		}
	}

	private event EventHandler<MouseEventExtArgs> m_MouseClickExt;

	public event EventHandler<MouseEventExtArgs> MouseClickExt
	{
		add
		{
			if (this.m_MouseClickExt == null)
			{
				HookManager.MouseClickExt += HookManager_MouseClickExt;
			}
			m_MouseClickExt += value;
		}
		remove
		{
			m_MouseClickExt -= value;
			if (this.m_MouseClickExt == null)
			{
				HookManager.MouseClickExt -= HookManager_MouseClickExt;
			}
		}
	}

	private event KeyPressEventHandler m_KeyPress
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = this.m_KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyPress, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyPressEventHandler val = this.m_KeyPress;
			KeyPressEventHandler val2;
			do
			{
				val2 = val;
				KeyPressEventHandler value2 = (KeyPressEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyPress, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_KeyPress == null)
			{
				HookManager.KeyPress += new KeyPressEventHandler(HookManager_KeyPress);
			}
			m_KeyPress += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_KeyPress -= value;
			if (this.m_KeyPress == null)
			{
				HookManager.KeyPress -= new KeyPressEventHandler(HookManager_KeyPress);
			}
		}
	}

	private event KeyEventHandler m_KeyUp
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.m_KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.m_KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler KeyUp
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_KeyUp == null)
			{
				HookManager.KeyUp += new KeyEventHandler(HookManager_KeyUp);
			}
			m_KeyUp += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_KeyUp -= value;
			if (this.m_KeyUp == null)
			{
				HookManager.KeyUp -= new KeyEventHandler(HookManager_KeyUp);
			}
		}
	}

	private event KeyEventHandler m_KeyDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.m_KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.m_KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.m_KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler KeyDown
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (this.m_KeyDown == null)
			{
				HookManager.KeyDown += new KeyEventHandler(HookManager_KeyDown);
			}
			m_KeyDown += value;
		}
		remove
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected O, but got Unknown
			m_KeyDown -= value;
			if (this.m_KeyDown == null)
			{
				HookManager.KeyDown -= new KeyEventHandler(HookManager_KeyDown);
			}
		}
	}

	private void HookManager_MouseMove(object sender, MouseEventArgs e)
	{
		if (this.m_MouseMove != null)
		{
			this.m_MouseMove.Invoke((object)this, e);
		}
	}

	private void HookManager_MouseClick(object sender, MouseEventArgs e)
	{
		if (this.m_MouseClick != null)
		{
			this.m_MouseClick.Invoke((object)this, e);
		}
	}

	private void HookManager_MouseDown(object sender, MouseEventArgs e)
	{
		if (this.m_MouseDown != null)
		{
			this.m_MouseDown.Invoke((object)this, e);
		}
	}

	private void HookManager_MouseUp(object sender, MouseEventArgs e)
	{
		if (this.m_MouseUp != null)
		{
			this.m_MouseUp.Invoke((object)this, e);
		}
	}

	private void HookManager_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (this.m_MouseDoubleClick != null)
		{
			this.m_MouseDoubleClick.Invoke((object)this, e);
		}
	}

	private void HookManager_MouseMoveExt(object sender, MouseEventExtArgs e)
	{
		if (this.m_MouseMoveExt != null)
		{
			this.m_MouseMoveExt(this, e);
		}
	}

	private void HookManager_MouseClickExt(object sender, MouseEventExtArgs e)
	{
		if (this.m_MouseClickExt != null)
		{
			this.m_MouseClickExt(this, e);
		}
	}

	private void HookManager_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (this.m_KeyPress != null)
		{
			this.m_KeyPress.Invoke((object)this, e);
		}
	}

	private void HookManager_KeyUp(object sender, KeyEventArgs e)
	{
		if (this.m_KeyUp != null)
		{
			this.m_KeyUp.Invoke((object)this, e);
		}
	}

	private void HookManager_KeyDown(object sender, KeyEventArgs e)
	{
		this.m_KeyDown.Invoke((object)this, e);
	}
}
