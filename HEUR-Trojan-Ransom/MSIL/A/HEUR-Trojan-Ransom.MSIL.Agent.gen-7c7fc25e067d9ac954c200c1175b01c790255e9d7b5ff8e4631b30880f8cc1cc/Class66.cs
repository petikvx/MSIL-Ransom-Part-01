using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class66
{
	private Module module_0;

	private readonly int[] int_0;

	private readonly int int_1;

	private Type[] df865e44;

	private Type type_0;

	public byte dbc4d416;

	public unsafe Class66(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		dbc4d416 = *(pByte_0++);
		int_0 = new int[b23ec9a0.fe94f07f(ref pByte_0)];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = (int)b23ec9a0.fe38c3d2(b23ec9a0.fe94f07f(ref pByte_0));
		}
		int_1 = (int)b23ec9a0.fe38c3d2(b23ec9a0.fe94f07f(ref pByte_0));
	}

	[SpecialName]
	public Type[] method_0()
	{
		if (df865e44 != null)
		{
			return df865e44;
		}
		Type[] array = new Type[int_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(int_0[i]);
		}
		df865e44 = array;
		return array;
	}

	[SpecialName]
	public Type method_1()
	{
		return type_0 ?? (type_0 = module_0.ResolveType(int_1));
	}
}
