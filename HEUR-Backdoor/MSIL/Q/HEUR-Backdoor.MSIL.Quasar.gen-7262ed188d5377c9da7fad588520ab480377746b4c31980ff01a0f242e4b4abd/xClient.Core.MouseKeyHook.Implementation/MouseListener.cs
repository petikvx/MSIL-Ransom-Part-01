using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class MouseListener : BaseListener, IMouseEvents
{
	private readonly ButtonSet m_DoubleDown;

	private readonly ButtonSet m_SingleDown;

	private Point m_PreviousPosition;

	public event MouseEventHandler MouseMove
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseMove, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseMove, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseMoveExt;

	public event MouseEventHandler MouseClick
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseDownExt;

	public event MouseEventHandler MouseUp
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseUpExt;

	public event MouseEventHandler MouseWheel
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseWheel, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseWheel, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler MouseDoubleClick
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = this.MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
	}

	protected MouseListener(Subscribe subscribe)
		: base(subscribe)
	{
		m_PreviousPosition = new Point(-1, -1);
		m_DoubleDown = new ButtonSet();
		m_SingleDown = new ButtonSet();
	}

	protected override bool Callback(CallbackData data)
	{
		MouseEventExtArgs e = GetEventArgs(data);
		if (e.IsMouseKeyDown)
		{
			ProcessDown(ref e);
		}
		if (e.IsMouseKeyUp)
		{
			ProcessUp(ref e);
		}
		if (e.WheelScrolled)
		{
			ProcessWheel(ref e);
		}
		if (HasMoved(e.Point))
		{
			ProcessMove(ref e);
		}
		return !e.Handled;
	}

	protected abstract MouseEventExtArgs GetEventArgs(CallbackData data);

	protected virtual void ProcessWheel(ref MouseEventExtArgs e)
	{
		OnWheel((MouseEventArgs)(object)e);
	}

	protected virtual void ProcessDown(ref MouseEventExtArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		OnDown((MouseEventArgs)(object)e);
		OnDownExt(e);
		if (!e.Handled)
		{
			if (((MouseEventArgs)e).get_Clicks() == 2)
			{
				m_DoubleDown.Add(((MouseEventArgs)e).get_Button());
			}
			if (((MouseEventArgs)e).get_Clicks() == 1)
			{
				m_SingleDown.Add(((MouseEventArgs)e).get_Button());
			}
		}
	}

	protected virtual void ProcessUp(ref MouseEventExtArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (m_SingleDown.Contains(((MouseEventArgs)e).get_Button()))
		{
			OnUp((MouseEventArgs)(object)e);
			OnUpExt(e);
			if (e.Handled)
			{
				return;
			}
			OnClick((MouseEventArgs)(object)e);
			m_SingleDown.Remove(((MouseEventArgs)e).get_Button());
		}
		if (m_DoubleDown.Contains(((MouseEventArgs)e).get_Button()))
		{
			e = e.ToDoubleClickEventArgs();
			OnUp((MouseEventArgs)(object)e);
			OnDoubleClick((MouseEventArgs)(object)e);
			m_DoubleDown.Remove(((MouseEventArgs)e).get_Button());
		}
	}

	private void ProcessMove(ref MouseEventExtArgs e)
	{
		m_PreviousPosition = e.Point;
		OnMove((MouseEventArgs)(object)e);
		OnMoveExt(e);
	}

	private bool HasMoved(Point actualPoint)
	{
		return m_PreviousPosition != actualPoint;
	}

	protected virtual void OnMove(MouseEventArgs e)
	{
		MouseEventHandler mouseMove = this.MouseMove;
		if (mouseMove != null)
		{
			mouseMove.Invoke((object)this, e);
		}
	}

	protected virtual void OnMoveExt(MouseEventExtArgs e)
	{
		this.MouseMoveExt?.Invoke(this, e);
	}

	protected virtual void OnClick(MouseEventArgs e)
	{
		MouseEventHandler mouseClick = this.MouseClick;
		if (mouseClick != null)
		{
			mouseClick.Invoke((object)this, e);
		}
	}

	protected virtual void OnDown(MouseEventArgs e)
	{
		MouseEventHandler mouseDown = this.MouseDown;
		if (mouseDown != null)
		{
			mouseDown.Invoke((object)this, e);
		}
	}

	protected virtual void OnDownExt(MouseEventExtArgs e)
	{
		this.MouseDownExt?.Invoke(this, e);
	}

	protected virtual void OnUp(MouseEventArgs e)
	{
		MouseEventHandler mouseUp = this.MouseUp;
		if (mouseUp != null)
		{
			mouseUp.Invoke((object)this, e);
		}
	}

	protected virtual void OnUpExt(MouseEventExtArgs e)
	{
		this.MouseUpExt?.Invoke(this, e);
	}

	protected virtual void OnWheel(MouseEventArgs e)
	{
		MouseEventHandler mouseWheel = this.MouseWheel;
		if (mouseWheel != null)
		{
			mouseWheel.Invoke((object)this, e);
		}
	}

	protected virtual void OnDoubleClick(MouseEventArgs e)
	{
		MouseEventHandler mouseDoubleClick = this.MouseDoubleClick;
		if (mouseDoubleClick != null)
		{
			mouseDoubleClick.Invoke((object)this, e);
		}
	}
}
