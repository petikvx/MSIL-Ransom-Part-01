using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class65
{
	private struct a875c23c
	{
		public uint ada9b86b;

		public uint affaf2ce;

		public uint df095bd5;

		public uint uint_0;
	}

	private class Class66
	{
		public Module module_0;

		public int int_0;

		public MemberInfo memberInfo_0;

		[SpecialName]
		public MemberInfo ca92bbe2()
		{
			return memberInfo_0 ?? (memberInfo_0 = module_0.ResolveMember(int_0));
		}
	}

	private Dictionary<uint, Class66> fd32c666;

	private Dictionary<uint, string> b305aa8d;

	private Dictionary<uint, Struct5> dictionary_0;

	private static Dictionary<Module, Class65> dictionary_1 = new Dictionary<Module, Class65>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module module_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* bfb92811;

	[SpecialName]
	public Module method_0()
	{
		return module_0;
	}

	[SpecialName]
	private void method_1(Module module_1)
	{
		module_0 = module_1;
	}

	public unsafe Class65(Module module_1, void* pVoid_0)
	{
		if (((a875c23c*)pVoid_0)->ada9b86b != 1145980749)
		{
			throw new InvalidProgramException();
		}
		fd32c666 = new Dictionary<uint, Class66>();
		b305aa8d = new Dictionary<uint, string>();
		dictionary_0 = new Dictionary<uint, Struct5>();
		byte* pByte_ = (byte*)pVoid_0 + sizeof(a875c23c);
		for (int i = 0; i < ((a875c23c*)pVoid_0)->affaf2ce; i++)
		{
			uint key = Class1.smethod_0(ref pByte_);
			int int_ = (int)Class1.cf9dab39(Class1.smethod_0(ref pByte_));
			fd32c666[key] = new Class66
			{
				module_0 = module_1,
				int_0 = int_
			};
		}
		for (int j = 0; j < ((a875c23c*)pVoid_0)->df095bd5; j++)
		{
			uint key2 = Class1.smethod_0(ref pByte_);
			uint num = Class1.smethod_0(ref pByte_);
			b305aa8d[key2] = new string((char*)pByte_, 0, (int)num);
			pByte_ += num << 1;
		}
		for (int k = 0; k < ((a875c23c*)pVoid_0)->uint_0; k++)
		{
			dictionary_0[Class1.smethod_0(ref pByte_)] = new Struct5(ref pByte_, module_1);
		}
		method_2((byte*)pVoid_0);
		method_1(module_1);
		dictionary_1[module_1] = this;
	}

	public static Class65 smethod_0(Module module_1)
	{
		Class65 value;
		lock (dictionary_1)
		{
			if (!dictionary_1.TryGetValue(module_1, out value))
			{
				Class65 class2 = (dictionary_1[module_1] = Class67.smethod_0(module_1));
				value = class2;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* e6f174bf()
	{
		return bfb92811;
	}

	[SpecialName]
	public unsafe void method_2(byte* pByte_0)
	{
		bfb92811 = pByte_0;
	}

	public MemberInfo method_3(uint uint_0)
	{
		return fd32c666[uint_0].ca92bbe2();
	}

	public string method_4(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return b305aa8d[uint_0];
	}

	public Struct5 method_5(uint uint_0)
	{
		return dictionary_0[uint_0];
	}
}
