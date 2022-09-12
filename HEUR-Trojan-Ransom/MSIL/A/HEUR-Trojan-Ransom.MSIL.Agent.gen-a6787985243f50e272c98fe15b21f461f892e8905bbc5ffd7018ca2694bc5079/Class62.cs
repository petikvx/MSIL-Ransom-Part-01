using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class62
{
	private Module module_0;

	private readonly int[] int_0;

	private readonly int int_1;

	private Type[] type_0;

	private Type type_1;

	public byte byte_0;

	public unsafe Class62(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		byte_0 = *(pByte_0++);
		int_0 = new int[a41805c0.b3b1be1f(ref pByte_0)];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = (int)a41805c0.bf3cf4f2(a41805c0.b3b1be1f(ref pByte_0));
		}
		int_1 = (int)a41805c0.bf3cf4f2(a41805c0.b3b1be1f(ref pByte_0));
	}

	[SpecialName]
	public Type[] b05b0630()
	{
		if (type_0 != null)
		{
			return type_0;
		}
		Type[] array = new Type[int_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(int_0[i]);
		}
		type_0 = array;
		return array;
	}

	[SpecialName]
	public Type method_0()
	{
		return type_1 ?? (type_1 = module_0.ResolveType(int_1));
	}
}
