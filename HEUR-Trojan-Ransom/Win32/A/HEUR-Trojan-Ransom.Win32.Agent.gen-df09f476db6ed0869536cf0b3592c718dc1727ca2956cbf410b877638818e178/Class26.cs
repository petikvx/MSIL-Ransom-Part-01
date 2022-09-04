using System;
using System.Net;
using System.Runtime.CompilerServices;

internal class Class26 : Class24
{
	private WebRequest webRequest_0;

	private Class34 class34_0;

	protected Class26(WebRequest webRequest_1, AsyncCallback asyncCallback_1, object object_1)
	{
		Class51.smethod_0();
		base._002Ector(asyncCallback_1, object_1);
		webRequest_0 = webRequest_1;
	}

	[SpecialName]
	internal WebRequest method_6()
	{
		return webRequest_0;
	}

	[SpecialName]
	internal void method_7(WebRequest webRequest_1)
	{
		webRequest_0 = webRequest_1;
	}

	[SpecialName]
	internal Class34 method_8()
	{
		return class34_0;
	}

	[SpecialName]
	internal void method_9(Class34 class34_1)
	{
		class34_0 = class34_1;
	}

	internal static Class26 smethod_0(Class34 class34_1, WebRequest webRequest_1, AsyncCallback asyncCallback_1, object object_1)
	{
		if (class34_1 is Class40)
		{
			return new Class27(webRequest_1, asyncCallback_1, object_1);
		}
		if (class34_1 is Class41)
		{
			Class41 @class = (Class41)class34_1;
			Class27 class2 = new Class27(webRequest_1, asyncCallback_1, object_1);
			class2.method_12(new GClass2(@class.genum1_0, 0, @class.int_0, 0));
			return class2;
		}
		return new Class26(webRequest_1, asyncCallback_1, object_1);
	}
}
