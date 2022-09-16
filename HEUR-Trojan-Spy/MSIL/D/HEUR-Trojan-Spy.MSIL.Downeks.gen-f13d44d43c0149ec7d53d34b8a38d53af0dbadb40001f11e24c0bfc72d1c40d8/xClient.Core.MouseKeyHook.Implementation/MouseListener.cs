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

	private static MouseListener GFuVHGDtaR3bxR2C8ii;

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
		kfoaVWG6XFBMNwriq27();
	}

	internal static void GqDy2oDPgjCF3ytvFwu()
	{
	}

	internal static void acJ6eaDeLwtiQyJqyEF()
	{
	}

	internal static bool ps4pM9DUb3dnWqNcLRL()
	{
		return true;
	}

	internal static MouseListener uO8IwRDTDpMB1ADlkpS()
	{
		return null;
	}

	internal static object a0OGHUD2EKspm7WQnnl(object object_0, Struct1 data)
	{
		return null;
	}

	internal static bool hChmhID0J84qI9E1g8N(object object_0)
	{
		return true;
	}

	internal static bool qOT0dLDKDJuMYmDUAjU(object object_0)
	{
		return true;
	}

	internal static bool VqweDhDByd9ZYL67cVG(object object_0)
	{
		return true;
	}

	internal static Struct4 mIxTeJDN6yf9uwFw5Yi(object object_0)
	{
		return (Struct4)(object)null;
	}

	internal static bool t4N4ADDZYmxjClMeHcy(object object_0)
	{
		return true;
	}

	internal static void vjQwjqDQs0n8itH0le3(object object_0, object object_1)
	{
	}

	internal static void gtvmKBDjlSYTWPwN6Y8(object object_0, object object_1)
	{
	}

	internal static void f6M3VQDsiosWdsEAobV(object object_0, object object_1)
	{
	}

	internal static int CxeDmRDd8tSGD2PjvBs(object object_0)
	{
		return 0;
	}

	internal static MouseButtons RFCZFLDAFOdlLSuuCdT(object object_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return (MouseButtons)(object)null;
	}

	internal static void ohMcH5D3h5nDsg3kydO(object object_0, MouseButtons element)
	{
	}

	internal static bool MVmeFRD1eQ8wAOUo3gi(object object_0, MouseButtons element)
	{
		return true;
	}

	internal static void ann3gjDqU1OdjEaWpj6(object object_0, object object_1)
	{
	}

	internal static void AX9q90Dbgg7fg4hx3GE(object object_0, object object_1)
	{
	}

	internal static void SWvxeND7peblRrFQWLV(object object_0, MouseButtons element)
	{
	}

	internal static object iLtLNBDukSMrW69PIWT(object object_0)
	{
		return null;
	}

	internal static void MdbMfoDzBlfUPH46lu4(object object_0, object object_1)
	{
	}

	internal static bool QHbq1iGFFyMhOWqlu6k(Struct4 a, Struct4 b)
	{
		return true;
	}

	internal static object uNnBiJGCOIG7ItJUl5v(object object_0, object object_1)
	{
		return null;
	}

	internal static object DrNT2YGW7TRAC1nevhn(object object_0, object object_1)
	{
		return null;
	}

	internal static void CXXTFtGoJFFbvT4yIYn(object object_0, object object_1, object object_2)
	{
	}

	internal static void kfoaVWG6XFBMNwriq27()
	{
	}
}
