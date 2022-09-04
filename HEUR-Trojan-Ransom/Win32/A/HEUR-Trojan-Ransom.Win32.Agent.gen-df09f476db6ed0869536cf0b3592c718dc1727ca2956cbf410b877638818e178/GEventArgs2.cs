using System;
using System.Runtime.CompilerServices;

public class GEventArgs2 : EventArgs
{
	[CompilerGenerated]
	private GClass16 gclass16_0;

	[SpecialName]
	[CompilerGenerated]
	public GClass16 method_0()
	{
		return gclass16_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(GClass16 gclass16_1)
	{
		gclass16_0 = gclass16_1;
	}

	public GEventArgs2(GClass16 gclass16_1)
	{
		Class51.smethod_0();
		base._002Ector();
		method_1(gclass16_1);
	}
}
