using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

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

	private static MouseListener GgSt5kjEc6MLn9ehsvq;

	public event MouseEventHandler Event_3
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<GEventArgs2> Event_4
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MouseEventHandler Event_5
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MouseEventHandler Event_6
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<GEventArgs2> Event_7
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MouseEventHandler Event_8
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event EventHandler<GEventArgs2> Event_9
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MouseEventHandler Event_10
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event MouseEventHandler Event_11
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	protected MouseListener(Delegate1 subscribe)
	{
	}

	protected override bool Callback(Struct1 data)
	{
		return true;
	}

	protected abstract GEventArgs2 GetEventArgs(Struct1 data);

	protected virtual void ProcessWheel(ref GEventArgs2 e)
	{
	}

	protected virtual void ProcessDown(ref GEventArgs2 e)
	{
	}

	protected virtual void ProcessUp(ref GEventArgs2 e)
	{
	}

	private void ProcessMove(ref GEventArgs2 e)
	{
	}

	private bool HasMoved(Struct4 actualPoint)
	{
		return true;
	}

	protected virtual void OnMove(MouseEventArgs e)
	{
	}

	protected virtual void OnMoveExt(GEventArgs2 e)
	{
	}

	protected virtual void OnClick(MouseEventArgs e)
	{
	}

	protected virtual void OnDown(MouseEventArgs e)
	{
	}

	protected virtual void OnDownExt(GEventArgs2 e)
	{
	}

	protected virtual void OnUp(MouseEventArgs e)
	{
	}

	protected virtual void OnUpExt(GEventArgs2 e)
	{
	}

	protected virtual void OnWheel(MouseEventArgs e)
	{
	}

	protected virtual void OnDoubleClick(MouseEventArgs e)
	{
	}

	static MouseListener()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		k3RvEwj8W7UVHBe8VPH();
	}

	internal static void WIxRqQj2YycKX7ftkvV()
	{
	}

	internal static bool pVYl0Wjw1QYJbEjOUWF()
	{
		return true;
	}

	internal static MouseListener v00lCMjmZASB3ONNr5b()
	{
		return null;
	}

	internal static bool mJZCvAjtiQcH0WwQYyl(object object_0)
	{
		return true;
	}

	internal static Struct4 xPC308jC5ufferwVTlf(object object_0)
	{
		return (Struct4)(object)null;
	}

	internal static bool EKhml3jxWXP5UHdgZrD(object object_0)
	{
		return true;
	}

	internal static void V6yUS6jo7P0W81lbHjt(object object_0, object object_1)
	{
	}

	internal static MouseButtons onXKFFj0T22aV5DBhO3(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (MouseButtons)(object)null;
	}

	internal static int gxJlUNj1nVGIyCdRu8v(object object_0)
	{
		return 0;
	}

	internal static bool EFCj1jjIZ5tfLfVnGpZ(object object_0, MouseButtons element)
	{
		return true;
	}

	internal static void ggTLrljKyBsPAUtJLXH(object object_0, object object_1)
	{
	}

	internal static void xck6mhjOTbd49859EWc(object object_0, object object_1)
	{
	}

	internal static void iZJuMSjYx9nlsARQpkn(object object_0, object object_1)
	{
	}

	internal static void BR493Yj625fJ8NDK7Iv(object object_0, MouseButtons element)
	{
	}

	internal static object Q6Qy9bjk0W6dJgMyZSP(object object_0)
	{
		return null;
	}

	internal static void HvUBMCjsQdDecIyV9Rv(object object_0, object object_1)
	{
	}

	internal static void ofupTwjukL3KlYQLOl8(object object_0, object object_1)
	{
	}

	internal static bool UQwsXejAMLy6eZa2NqX(Struct4 a, Struct4 b)
	{
		return true;
	}

	internal static object Hq6LUUjQuqpGjpdbBg1(object object_0, object object_1)
	{
		return null;
	}

	internal static object olxt3IjT1Z3M0i4yQfE(object object_0, object object_1)
	{
		return null;
	}

	internal static void VWQ734jiTAYuyXRYXVQ(object object_0, object object_1, object object_2)
	{
	}

	internal static void k3RvEwj8W7UVHBe8VPH()
	{
	}
}
