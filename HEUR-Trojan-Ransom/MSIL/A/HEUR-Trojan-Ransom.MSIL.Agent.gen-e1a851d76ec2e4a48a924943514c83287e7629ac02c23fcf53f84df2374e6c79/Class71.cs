using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class71
{
	private Module b5aeff63;

	private readonly int[] int_0;

	private readonly int int_1;

	private Type[] ff22a11d;

	private Type b937afd8;

	public byte byte_0;

	public unsafe Class71(ref byte* pByte_0, Module module_0)
	{
		b5aeff63 = module_0;
		byte_0 = *(pByte_0++);
		int_0 = new int[Class1.smethod_0(ref pByte_0)];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = (int)Class1.smethod_1(Class1.smethod_0(ref pByte_0));
		}
		int_1 = (int)Class1.smethod_1(Class1.smethod_0(ref pByte_0));
	}

	[SpecialName]
	public Type[] d379c4d9()
	{
		if (ff22a11d != null)
		{
			return ff22a11d;
		}
		Type[] array = new Type[int_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = b5aeff63.ResolveType(int_0[i]);
		}
		ff22a11d = array;
		return array;
	}

	[SpecialName]
	public Type b73d6864()
	{
		return b937afd8 ?? (b937afd8 = b5aeff63.ResolveType(int_1));
	}
}
