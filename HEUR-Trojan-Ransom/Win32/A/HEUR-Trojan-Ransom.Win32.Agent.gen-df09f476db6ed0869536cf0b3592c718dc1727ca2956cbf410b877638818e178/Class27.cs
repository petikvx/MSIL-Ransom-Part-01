using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class27 : Class26
{
	private List<GClass2> list_0;

	private GClass2 gclass2_0;

	public Class27(WebRequest webRequest_1, AsyncCallback asyncCallback_1, object object_1)
	{
		Class51.smethod_0();
		base._002Ector(webRequest_1, asyncCallback_1, object_1);
		list_0 = new List<GClass2>();
	}

	[SpecialName]
	public List<GClass2> method_10()
	{
		return list_0;
	}

	[SpecialName]
	public GClass2 method_11()
	{
		return gclass2_0;
	}

	[SpecialName]
	public void method_12(GClass2 gclass2_1)
	{
		gclass2_0 = gclass2_1;
	}
}
