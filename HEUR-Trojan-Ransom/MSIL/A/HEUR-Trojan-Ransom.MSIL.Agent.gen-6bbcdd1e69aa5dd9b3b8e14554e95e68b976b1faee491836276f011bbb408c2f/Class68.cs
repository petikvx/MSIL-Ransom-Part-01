using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class68
{
	private Module module_0;

	private readonly int[] int_0;

	private readonly int bd7206b4;

	private Type[] f1790283;

	private Type f55f4606;

	public byte byte_0;

	public unsafe Class68(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		byte_0 = *(pByte_0++);
		int_0 = new int[Class1.smethod_0(ref pByte_0)];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = (int)Class1.cf9dab39(Class1.smethod_0(ref pByte_0));
		}
		bd7206b4 = (int)Class1.cf9dab39(Class1.smethod_0(ref pByte_0));
	}

	[SpecialName]
	public Type[] method_0()
	{
		if (f1790283 != null)
		{
			return f1790283;
		}
		Type[] array = new Type[int_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(int_0[i]);
		}
		f1790283 = array;
		return array;
	}

	[SpecialName]
	public Type method_1()
	{
		return f55f4606 ?? (f55f4606 = module_0.ResolveType(bd7206b4));
	}
}
