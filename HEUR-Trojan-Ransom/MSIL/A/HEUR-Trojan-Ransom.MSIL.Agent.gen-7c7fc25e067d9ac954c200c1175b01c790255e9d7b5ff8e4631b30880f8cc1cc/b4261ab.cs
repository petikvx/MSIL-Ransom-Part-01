using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class b4261ab
{
	private struct Struct3
	{
		public uint d01ec3cc;

		public uint uint_0;

		public uint e29cbade;

		public uint uint_1;
	}

	private class Class64
	{
		public Module module_0;

		public int feaeb7a9;

		public MemberInfo b7fc9cf4;

		[SpecialName]
		public MemberInfo e1a0661f()
		{
			return b7fc9cf4 ?? (b7fc9cf4 = module_0.ResolveMember(feaeb7a9));
		}
	}

	private Dictionary<uint, Class64> a9eaf6b3;

	private Dictionary<uint, string> dictionary_0;

	private Dictionary<uint, Struct4> f03d595d;

	private static Dictionary<Module, b4261ab> dictionary_1 = new Dictionary<Module, b4261ab>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module d3459397;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* pByte_0;

	[SpecialName]
	public Module cb6b0b0e()
	{
		return d3459397;
	}

	[SpecialName]
	private void method_0(Module module_0)
	{
		d3459397 = module_0;
	}

	public unsafe b4261ab(Module module_0, void* pVoid_0)
	{
		if (((Struct3*)pVoid_0)->d01ec3cc != 1145980749)
		{
			throw new InvalidProgramException();
		}
		a9eaf6b3 = new Dictionary<uint, Class64>();
		dictionary_0 = new Dictionary<uint, string>();
		f03d595d = new Dictionary<uint, Struct4>();
		byte* ptr = (byte*)pVoid_0 + sizeof(Struct3);
		for (int i = 0; i < ((Struct3*)pVoid_0)->uint_0; i++)
		{
			uint key = b23ec9a0.fe94f07f(ref ptr);
			int feaeb7a = (int)b23ec9a0.fe38c3d2(b23ec9a0.fe94f07f(ref ptr));
			a9eaf6b3[key] = new Class64
			{
				module_0 = module_0,
				feaeb7a9 = feaeb7a
			};
		}
		for (int j = 0; j < ((Struct3*)pVoid_0)->e29cbade; j++)
		{
			uint key2 = b23ec9a0.fe94f07f(ref ptr);
			uint num = b23ec9a0.fe94f07f(ref ptr);
			dictionary_0[key2] = new string((char*)ptr, 0, (int)num);
			ptr += num << 1;
		}
		for (int k = 0; k < ((Struct3*)pVoid_0)->uint_1; k++)
		{
			f03d595d[b23ec9a0.fe94f07f(ref ptr)] = new Struct4(ref ptr, module_0);
		}
		method_1((byte*)pVoid_0);
		method_0(module_0);
		dictionary_1[module_0] = this;
	}

	public static b4261ab smethod_0(Module module_0)
	{
		b4261ab value;
		lock (dictionary_1)
		{
			if (!dictionary_1.TryGetValue(module_0, out value))
			{
				b4261ab b4261ab3 = (dictionary_1[module_0] = Class65.c6db7646(module_0));
				value = b4261ab3;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* b6037d70()
	{
		return pByte_0;
	}

	[SpecialName]
	public unsafe void method_1(byte* pByte_1)
	{
		pByte_0 = pByte_1;
	}

	public MemberInfo method_2(uint uint_0)
	{
		return a9eaf6b3[uint_0].e1a0661f();
	}

	public string method_3(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return dictionary_0[uint_0];
	}

	public Struct4 method_4(uint uint_0)
	{
		return f03d595d[uint_0];
	}
}
