using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class61
{
	private Module module_0;

	private readonly int[] a17789bf;

	private readonly int int_0;

	private Type[] type_0;

	private Type type_1;

	public byte cf40b163;

	public unsafe Class61(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		cf40b163 = *(pByte_0++);
		a17789bf = new int[Class1.smethod_0(ref pByte_0)];
		for (int i = 0; i < a17789bf.Length; i++)
		{
			a17789bf[i] = (int)Class1.fd58900f(Class1.smethod_0(ref pByte_0));
		}
		int_0 = (int)Class1.fd58900f(Class1.smethod_0(ref pByte_0));
	}

	[SpecialName]
	public Type[] c7148f45()
	{
		if (type_0 != null)
		{
			return type_0;
		}
		Type[] array = new Type[a17789bf.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(a17789bf[i]);
		}
		type_0 = array;
		return array;
	}

	[SpecialName]
	public Type method_0()
	{
		return type_1 ?? (type_1 = module_0.ResolveType(int_0));
	}
}
