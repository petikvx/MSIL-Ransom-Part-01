using System;
using System.Runtime.CompilerServices;

namespace ns4;

internal abstract class Class7 : IDisposable
{
	private UIntPtr uintptr_0;

	public Class7(UIntPtr uintptr_1)
	{
		method_1(uintptr_1);
	}

	[SpecialName]
	public UIntPtr method_0()
	{
		return uintptr_0;
	}

	[SpecialName]
	public void method_1(UIntPtr uintptr_1)
	{
		uintptr_0 = uintptr_1;
	}

	public abstract object vmethod_0(string string_0);

	public abstract bool vmethod_1(string string_0, out object object_0);

	abstract void IDisposable.Dispose();
}
