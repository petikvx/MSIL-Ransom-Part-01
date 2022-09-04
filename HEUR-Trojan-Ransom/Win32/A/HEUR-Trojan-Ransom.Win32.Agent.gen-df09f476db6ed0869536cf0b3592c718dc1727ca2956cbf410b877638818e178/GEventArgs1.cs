using System;
using System.Runtime.CompilerServices;

public class GEventArgs1 : EventArgs
{
	[CompilerGenerated]
	private GClass19 gclass19_0;

	[SpecialName]
	[CompilerGenerated]
	public GClass19 method_0()
	{
		return gclass19_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(GClass19 gclass19_1)
	{
		gclass19_0 = gclass19_1;
	}

	public GEventArgs1(GClass19 gclass19_1)
	{
		Class51.smethod_0();
		base._002Ector();
		method_1(gclass19_1);
	}
}
