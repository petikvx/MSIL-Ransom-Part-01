using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class66
{
	private struct Struct1
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;
	}

	private class Class67
	{
		public Module module_0;

		public int d2d2a69;

		public MemberInfo ae0f0b4;

		[SpecialName]
		public MemberInfo method_0()
		{
			return ae0f0b4 ?? (ae0f0b4 = module_0.ResolveMember(d2d2a69));
		}
	}

	private Dictionary<uint, Class67> e6fa8773;

	private Dictionary<uint, string> dictionary_0;

	private Dictionary<uint, Struct2> c188e81d;

	private static Dictionary<Module, Class66> dictionary_1 = new Dictionary<Module, Class66>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module module_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* d2d231ca;

	[SpecialName]
	public Module a78dacce()
	{
		return module_0;
	}

	[SpecialName]
	private void method_0(Module module_1)
	{
		module_0 = module_1;
	}

	public unsafe Class66(Module module_1, void* pVoid_0)
	{
		if (((Struct1*)pVoid_0)->uint_0 != 1145980749)
		{
			throw new InvalidProgramException();
		}
		e6fa8773 = new Dictionary<uint, Class67>();
		dictionary_0 = new Dictionary<uint, string>();
		c188e81d = new Dictionary<uint, Struct2>();
		byte* pByte_ = (byte*)pVoid_0 + sizeof(Struct1);
		for (int i = 0; i < ((Struct1*)pVoid_0)->uint_1; i++)
		{
			uint key = Class1.a9a9e53f(ref pByte_);
			int d2d2a = (int)Class1.ee8db192(Class1.a9a9e53f(ref pByte_));
			e6fa8773[key] = new Class67
			{
				module_0 = module_1,
				d2d2a69 = d2d2a
			};
		}
		for (int j = 0; j < ((Struct1*)pVoid_0)->uint_2; j++)
		{
			uint key2 = Class1.a9a9e53f(ref pByte_);
			uint num = Class1.a9a9e53f(ref pByte_);
			dictionary_0[key2] = new string((char*)pByte_, 0, (int)num);
			pByte_ += num << 1;
		}
		for (int k = 0; k < ((Struct1*)pVoid_0)->uint_3; k++)
		{
			c188e81d[Class1.a9a9e53f(ref pByte_)] = new Struct2(ref pByte_, module_1);
		}
		f8c096cf((byte*)pVoid_0);
		method_0(module_1);
		dictionary_1[module_1] = this;
	}

	public static Class66 a3d704e3(Module module_1)
	{
		Class66 value;
		lock (dictionary_1)
		{
			if (!dictionary_1.TryGetValue(module_1, out value))
			{
				Class66 class2 = (dictionary_1[module_1] = eb56e483.smethod_0(module_1));
				value = class2;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* method_1()
	{
		return d2d231ca;
	}

	[SpecialName]
	public unsafe void f8c096cf(byte* pByte_0)
	{
		d2d231ca = pByte_0;
	}

	public MemberInfo method_2(uint uint_0)
	{
		return e6fa8773[uint_0].method_0();
	}

	public string method_3(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return dictionary_0[uint_0];
	}

	public Struct2 a1cfd364(uint uint_0)
	{
		return c188e81d[uint_0];
	}
}
