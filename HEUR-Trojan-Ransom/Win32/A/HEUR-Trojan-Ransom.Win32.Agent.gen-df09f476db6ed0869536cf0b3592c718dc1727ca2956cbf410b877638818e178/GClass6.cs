using System;
using System.Runtime.CompilerServices;

public class GClass6 : GClass5
{
	private bool bool_0;

	public override bool vmethod_0(GClass15 gclass15_0)
	{
		if (gclass15_0.method_4().Contains("74.125.224"))
		{
			Console.WriteLine("Redirecting traffic from {0} to yahoo.com.", gclass15_0.method_4());
			gclass15_0.method_5("www.yahoo.com");
			gclass15_0.method_1((GEnum6)3);
		}
		return true;
	}

	[SpecialName]
	public override bool imethod_0()
	{
		return bool_0;
	}

	[SpecialName]
	public override void imethod_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public GClass6()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
