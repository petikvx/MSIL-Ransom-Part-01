using System;
using System.ComponentModel;

namespace SniperTower;

public class GClass0 : Component
{
	private IContainer icontainer_0 = null;

	public static string smethod_0()
	{
		for (int i = 0; i < 1; i++)
		{
			Console.Write("");
		}
		return "ssssssssssssss" + GClass4.smethod_0().ToLower() + "There is no god ;)";
	}

	public GClass0()
	{
		method_0();
		smethod_0();
	}

	public GClass0(IContainer icontainer_1)
	{
		icontainer_1.Add(this);
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}
}
