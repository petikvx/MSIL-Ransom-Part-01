using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class MouseListener : BaseListener, GInterface1
{
	private readonly Class19 m_DoubleDown;

	private readonly Class19 m_SingleDown;

	private Struct4 m_PreviousPosition;

	[CompilerGenerated]
	private MouseEventHandler MouseMove;

	[CompilerGenerated]
	private EventHandler<GEventArgs2> MouseMoveExt;

	[CompilerGenerated]
	private MouseEventHandler MouseClick;

	[CompilerGenerated]
	private MouseEventHandler MouseDown;

	[CompilerGenerated]
	private EventHandler<GEventArgs2> MouseDownExt;

	[CompilerGenerated]
	private MouseEventHandler MouseUp;

	[CompilerGenerated]
	private EventHandler<GEventArgs2> MouseUpExt;

	[CompilerGenerated]
	private MouseEventHandler MouseWheel;

	[CompilerGenerated]
	private MouseEventHandler MouseDoubleClick;

	public event MouseEventHandler Event_3
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseMove, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseMove;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseMove, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<GEventArgs2> Event_4
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs2> eventHandler = MouseMoveExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseMoveExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs2> eventHandler = MouseMoveExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseMoveExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event MouseEventHandler Event_5
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseClick, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler Event_6
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseDown;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<GEventArgs2> Event_7
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs2> eventHandler = MouseDownExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseDownExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs2> eventHandler = MouseDownExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseDownExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event MouseEventHandler Event_8
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseUp;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public event EventHandler<GEventArgs2> Event_9
	{
		[CompilerGenerated]
		add
		{
			EventHandler<GEventArgs2> eventHandler = MouseUpExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseUpExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<GEventArgs2> eventHandler = MouseUpExt;
			EventHandler<GEventArgs2> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<GEventArgs2> value2 = (EventHandler<GEventArgs2>)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref MouseUpExt, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event MouseEventHandler Event_10
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseWheel, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseWheel;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseWheel, value2, val2);
			}
			while (val != val2);
		}
	}

	public event MouseEventHandler Event_11
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			MouseEventHandler val = MouseDoubleClick;
			MouseEventHandler val2;
			do
			{
				val2 = val;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref MouseDoubleClick, value2, val2);
			}
			while (val != val2);
		}
	}

	protected MouseListener(Delegate1 subscribe)
		: base(subscribe)
	{
		m_PreviousPosition = new Struct4(-1, -1);
		m_DoubleDown = new Class19();
		m_SingleDown = new Class19();
	}

	protected override bool Callback(Struct1 data)
	{
		GEventArgs2 e = GetEventArgs(data);
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

	protected abstract GEventArgs2 GetEventArgs(Struct1 data);

	protected virtual void ProcessWheel(ref GEventArgs2 e)
	{
		OnWheel((MouseEventArgs)(object)e);
	}

	protected virtual void ProcessDown(ref GEventArgs2 e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		OnDown((MouseEventArgs)(object)e);
		OnDownExt(e);
		if (!e.Handled)
		{
			if (((MouseEventArgs)e).get_Clicks() == 2)
			{
				m_DoubleDown.method_0(((MouseEventArgs)e).get_Button());
			}
			if (((MouseEventArgs)e).get_Clicks() == 1)
			{
				m_SingleDown.method_0(((MouseEventArgs)e).get_Button());
			}
		}
	}

	protected virtual void ProcessUp(ref GEventArgs2 e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (m_SingleDown.method_2(((MouseEventArgs)e).get_Button()))
		{
			OnUp((MouseEventArgs)(object)e);
			OnUpExt(e);
			if (e.Handled)
			{
				return;
			}
			OnClick((MouseEventArgs)(object)e);
			m_SingleDown.method_1(((MouseEventArgs)e).get_Button());
		}
		if (m_DoubleDown.method_2(((MouseEventArgs)e).get_Button()))
		{
			e = e.method_0();
			OnUp((MouseEventArgs)(object)e);
			OnDoubleClick((MouseEventArgs)(object)e);
			m_DoubleDown.method_1(((MouseEventArgs)e).get_Button());
		}
	}

	private void ProcessMove(ref GEventArgs2 e)
	{
		m_PreviousPosition = e.Point;
		OnMove((MouseEventArgs)(object)e);
		OnMoveExt(e);
	}

	private bool HasMoved(Struct4 actualPoint)
	{
		return Struct4.smethod_1(m_PreviousPosition, actualPoint);
	}

	protected virtual void OnMove(MouseEventArgs e)
	{
		MouseEventHandler mouseMove = MouseMove;
		if (mouseMove != null)
		{
			mouseMove.Invoke((object)this, e);
		}
	}

	protected virtual void OnMoveExt(GEventArgs2 e)
	{
		MouseMoveExt?.Invoke(this, e);
	}

	protected virtual void OnClick(MouseEventArgs e)
	{
		MouseEventHandler mouseClick = MouseClick;
		if (mouseClick != null)
		{
			mouseClick.Invoke((object)this, e);
		}
	}

	protected virtual void OnDown(MouseEventArgs e)
	{
		MouseEventHandler mouseDown = MouseDown;
		if (mouseDown != null)
		{
			mouseDown.Invoke((object)this, e);
		}
	}

	protected virtual void OnDownExt(GEventArgs2 e)
	{
		MouseDownExt?.Invoke(this, e);
	}

	protected virtual void OnUp(MouseEventArgs e)
	{
		MouseEventHandler mouseUp = MouseUp;
		if (mouseUp != null)
		{
			mouseUp.Invoke((object)this, e);
		}
	}

	protected virtual void OnUpExt(GEventArgs2 e)
	{
		MouseUpExt?.Invoke(this, e);
	}

	protected virtual void OnWheel(MouseEventArgs e)
	{
		MouseEventHandler mouseWheel = MouseWheel;
		if (mouseWheel != null)
		{
			mouseWheel.Invoke((object)this, e);
		}
	}

	protected virtual void OnDoubleClick(MouseEventArgs e)
	{
		MouseEventHandler mouseDoubleClick = MouseDoubleClick;
		if (mouseDoubleClick != null)
		{
			mouseDoubleClick.Invoke((object)this, e);
		}
	}
}
