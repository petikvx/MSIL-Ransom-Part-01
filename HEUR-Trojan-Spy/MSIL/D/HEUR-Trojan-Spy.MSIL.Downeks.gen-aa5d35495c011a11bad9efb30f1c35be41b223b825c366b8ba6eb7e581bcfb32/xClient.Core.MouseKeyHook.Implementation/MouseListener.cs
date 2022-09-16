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

	internal static MouseListener BsYDyG1FxnQTb4bUudU;

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
		yjwSB41BRnPRoYLgXpv();
	}

	internal static void NqSJXY1aMgwCjIrUTWR()
	{
	}

	internal static bool AAKJrC1lSsKGTPS4Nea()
	{
		return true;
	}

	internal static MouseListener anqGKR1gKSVBHxtZEle()
	{
		return null;
	}

	internal static object BdZlu51jg2IfUc0svT3(object object_0, Struct1 data)
	{
		return null;
	}

	internal static bool gkFrej1ni9yA51m3AQB(object object_0)
	{
		return true;
	}

	internal static bool nKVMic12REQFgHHXkff(object object_0)
	{
		return true;
	}

	internal static Struct4 hFMeFP1wNY722aUTY5a(object object_0)
	{
		return (Struct4)(object)null;
	}

	internal static bool zjmXYr1SSEdWHkkvJCX(object object_0)
	{
		return true;
	}

	internal static void pbfZZB1UqgNVNGWfPec(object object_0, object object_1)
	{
	}

	internal static void PIZ8h714vWTZvc8mJkK(object object_0, object object_1)
	{
	}

	internal static int yjkyeR178CMeAP7hqMF(object object_0)
	{
		return 0;
	}

	internal static MouseButtons oU87hh15SB1syBtjiEH(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (MouseButtons)(object)null;
	}

	internal static void w9Fh6t1G6A4ZTZu57Ae(object object_0, object object_1)
	{
	}

	internal static void SkSWdN1oG9JPdX1TMXE(object object_0, MouseButtons element)
	{
	}

	internal static object zsyhfv1fKy56s5SYG5m(object object_0)
	{
		return null;
	}

	internal static void dbgPxw1TTeR80MVfEdJ(object object_0, object object_1)
	{
	}

	internal static void MobWo51sfn27771dOB9(object object_0, object object_1)
	{
	}

	internal static bool f8TNqk1iOmHUek1cYcr(Struct4 a, Struct4 b)
	{
		return true;
	}

	internal static object XPGM8u1Ir6hnvJRvZAT(object object_0, object object_1)
	{
		return null;
	}

	internal static object ffEMA81KHDVp4UcHOCM(object object_0, object object_1)
	{
		return null;
	}

	internal static void PRoGce1bxChH0jTFUfa(object object_0, object object_1, object object_2)
	{
	}

	internal static void yjwSB41BRnPRoYLgXpv()
	{
	}
}
