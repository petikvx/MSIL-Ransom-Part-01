using System;
using System.Dynamic;
using ns0;
using ns12;
using ns18;
using ns9;

namespace ns4;

internal class Class22 : Class9
{
	public override bool CanWrite => false;

	public override void vmethod_0(Class38 class38_0, object? object_0, Class34 class34_0)
	{
	}

	public override object? vmethod_1(Class29 class29_0, Type type_0, object? object_0, Class34 class34_0)
	{
		return Class7.smethod_758(this, class29_0);
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(ExpandoObject);
	}
}
