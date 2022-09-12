using System;
using System.Runtime.CompilerServices;

namespace ns1;

internal abstract class Class15 : IDisposable
{
	[CompilerGenerated]
	private UIntPtr uintptr_0;

	public UIntPtr HKey
	{
		[CompilerGenerated]
		get
		{
			return uintptr_0;
		}
		[CompilerGenerated]
		set
		{
			uintptr_0 = value;
		}
	}

	public Class15(UIntPtr uintptr_1)
	{
		HKey = uintptr_1;
	}

	public abstract object vmethod_0(string string_0);

	public abstract bool vmethod_1(string string_0, out object object_0);

	abstract void IDisposable.Dispose();
}
