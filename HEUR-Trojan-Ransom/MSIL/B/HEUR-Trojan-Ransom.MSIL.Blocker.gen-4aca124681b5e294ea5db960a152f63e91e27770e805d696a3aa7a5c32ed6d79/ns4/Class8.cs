using System;
using ns9;

namespace ns4;

internal sealed class Class8 : Class7
{
	public Class8(UIntPtr uintptr_1)
		: base(uintptr_1)
	{
	}

	public override void System_002EIDisposable_002EDispose()
	{
		Class10.smethod_2(method_0());
	}

	public override object vmethod_0(string string_0)
	{
		return Class10.smethod_1(method_0(), string_0);
	}

	public override bool vmethod_1(string string_0, out object object_0)
	{
		object_0 = Class10.smethod_1(method_0(), string_0);
		return object_0 != null;
	}
}
