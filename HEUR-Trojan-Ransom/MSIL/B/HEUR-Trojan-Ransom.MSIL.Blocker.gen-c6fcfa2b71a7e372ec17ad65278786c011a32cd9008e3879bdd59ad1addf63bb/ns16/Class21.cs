using System;
using System.Dynamic;
using ns1;
using ns13;
using ns3;
using ns9;

namespace ns16;

internal class Class21 : Class8
{
	public override bool CanWrite => false;

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		return Class131.smethod_678(this, class28_0);
	}

	public override bool vmethod_2(Type type_0)
	{
		return type_0 == typeof(ExpandoObject);
	}
}
