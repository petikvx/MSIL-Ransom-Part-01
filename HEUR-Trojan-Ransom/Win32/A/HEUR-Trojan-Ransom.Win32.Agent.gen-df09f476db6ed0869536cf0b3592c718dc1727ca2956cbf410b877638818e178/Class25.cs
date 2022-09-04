using System;
using System.Runtime.CompilerServices;

internal class Class25 : Class24
{
	private GClass2 gclass2_0;

	internal Class25(GClass2 gclass2_1, AsyncCallback asyncCallback_1, object object_1)
	{
		Class51.smethod_0();
		base._002Ector(asyncCallback_1, object_1);
		gclass2_0 = gclass2_1;
	}

	internal Class25(GEnum1 genum1_0, int int_0, int int_1, AsyncCallback asyncCallback_1, object object_1)
	{
		Class51.smethod_0();
		base._002Ector(asyncCallback_1, object_1);
		gclass2_0 = new GClass2(genum1_0, int_0, int_0, int_1);
	}

	[SpecialName]
	internal GClass2 method_6()
	{
		return gclass2_0;
	}
}
