using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class ff656cf5
{
	private Module module_0;

	private readonly int[] faf3f382;

	private readonly int f58a1cf9;

	private Type[] type_0;

	private Type b75ec593;

	public byte byte_0;

	public unsafe ff656cf5(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		byte_0 = *(pByte_0++);
		faf3f382 = new int[Class1.a9a9e53f(ref pByte_0)];
		for (int i = 0; i < faf3f382.Length; i++)
		{
			faf3f382[i] = (int)Class1.ee8db192(Class1.a9a9e53f(ref pByte_0));
		}
		f58a1cf9 = (int)Class1.ee8db192(Class1.a9a9e53f(ref pByte_0));
	}

	[SpecialName]
	public Type[] method_0()
	{
		if (type_0 != null)
		{
			return type_0;
		}
		Type[] array = new Type[faf3f382.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(faf3f382[i]);
		}
		type_0 = array;
		return array;
	}

	[SpecialName]
	public Type method_1()
	{
		return b75ec593 ?? (b75ec593 = module_0.ResolveType(f58a1cf9));
	}
}
