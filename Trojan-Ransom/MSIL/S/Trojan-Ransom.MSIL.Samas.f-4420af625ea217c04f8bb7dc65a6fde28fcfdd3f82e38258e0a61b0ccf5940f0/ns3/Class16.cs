using System;
using ns1;
using ns8;

namespace ns3;

internal sealed class Class16 : Class15
{
	public Class16()
		: base(UIntPtr.Zero)
	{
	}

	public Class16(UIntPtr uintptr_1)
		: base(uintptr_1)
	{
	}

	public override void System_002EIDisposable_002EDispose()
	{
		Class18.smethod_0(base.HKey);
	}

	public override object vmethod_0(string string_0)
	{
		return Class18.GetValue(base.HKey, string_0);
	}

	public override bool vmethod_1(string string_0, out object object_0)
	{
		object_0 = Class18.GetValue(base.HKey, string_0);
		return object_0 != null;
	}
}
