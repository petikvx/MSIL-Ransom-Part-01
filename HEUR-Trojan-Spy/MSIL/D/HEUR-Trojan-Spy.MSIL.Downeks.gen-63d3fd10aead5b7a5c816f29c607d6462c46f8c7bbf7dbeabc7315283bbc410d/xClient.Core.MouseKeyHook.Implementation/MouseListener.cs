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

	private static MouseListener Nirt8niUjj2Y8UYQ2PQ;

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
		mXKvBSi0PVX1HpWCOjR();
	}

	internal static void mxHNR5icxtx6WyTtawb()
	{
	}

	internal static void jiTJQ8isNE7G0G5AWF2()
	{
	}

	internal static bool yhGAy2im8WHhm6lt7ef()
	{
		return true;
	}

	internal static MouseListener JIDhHbi38jfgCQ6VC7w()
	{
		return null;
	}

	internal static object PpladWiJAQDamTXIqSf(object object_0, Struct1 data)
	{
		return null;
	}

	internal static bool IRvrS0iGUcH0JArUTQh(object object_0)
	{
		return true;
	}

	internal static bool QiURJ3i7QEwCcWPUwKy(object object_0)
	{
		return true;
	}

	internal static bool k9EXYQiYjgERAdw2k0u(object object_0)
	{
		return true;
	}

	internal static Struct4 eqoymUiwRAagUTXTca8(object object_0)
	{
		return (Struct4)(object)null;
	}

	internal static bool tOl0QTi80qUpfLt1bYV(object object_0)
	{
		return true;
	}

	internal static void oqWIhLi67UI7tt1vZ64(object object_0, object object_1)
	{
	}

	internal static void mcArMcinQ8rnvxvhnb2(object object_0, object object_1)
	{
	}

	internal static void vqRQj3iDLZBSIBETHuO(object object_0, object object_1)
	{
	}

	internal static int E4TgrlijK8PwkyDTDBN(object object_0)
	{
		return 0;
	}

	internal static void gt85nyiNPdVPrmuOjgR(object object_0, MouseButtons element)
	{
	}

	internal static MouseButtons LmeFqyivP2oOBDRRi3U(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (MouseButtons)(object)null;
	}

	internal static bool dQRRmjiuWX0mkXxbkTC(object object_0, MouseButtons element)
	{
		return true;
	}

	internal static void jdcTqRirhKXup97Z04S(object object_0, object object_1)
	{
	}

	internal static void oPJrdSiobq4x1MdTrxZ(object object_0, object object_1)
	{
	}

	internal static void lNYMGpid4jS4t4srURR(object object_0, MouseButtons element)
	{
	}

	internal static void WHcp80ifyCv5GdViUum(object object_0, object object_1)
	{
	}

	internal static object qLo6iviKjWwXIyTHOh1(object object_0, object object_1)
	{
		return null;
	}

	internal static object T0mo0XihfGXch2y6yT0(object object_0, object object_1)
	{
		return null;
	}

	internal static void vtWvl2iCIuLywSi4dP0(object object_0, object object_1, object object_2)
	{
	}

	internal static void mXKvBSi0PVX1HpWCOjR()
	{
	}
}
