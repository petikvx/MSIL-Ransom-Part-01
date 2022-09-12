using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class f90590
{
	private struct e20f3dfe
	{
		public uint d7b64d45;

		public uint uint_0;

		public uint uint_1;

		public uint b199a212;
	}

	private class Class70
	{
		public Module b5aeff63;

		public int int_0;

		public MemberInfo de46558d;

		[SpecialName]
		public MemberInfo cdea9f14()
		{
			return de46558d ?? (de46558d = b5aeff63.ResolveMember(int_0));
		}
	}

	private Dictionary<uint, Class70> dictionary_0;

	private Dictionary<uint, string> dictionary_1;

	private Dictionary<uint, Struct3> dictionary_2;

	private static Dictionary<Module, f90590> dictionary_3 = new Dictionary<Module, f90590>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module a62501ec;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* pByte_0;

	[SpecialName]
	public Module c5b9baf()
	{
		return a62501ec;
	}

	[SpecialName]
	private void method_0(Module module_0)
	{
		a62501ec = module_0;
	}

	public unsafe f90590(Module module_0, void* pVoid_0)
	{
		if (((e20f3dfe*)pVoid_0)->d7b64d45 != 1145980749)
		{
			throw new InvalidProgramException();
		}
		dictionary_0 = new Dictionary<uint, Class70>();
		dictionary_1 = new Dictionary<uint, string>();
		dictionary_2 = new Dictionary<uint, Struct3>();
		byte* ptr = (byte*)pVoid_0 + sizeof(e20f3dfe);
		for (int i = 0; i < ((e20f3dfe*)pVoid_0)->uint_0; i++)
		{
			uint key = Class1.smethod_0(ref ptr);
			int int_ = (int)Class1.smethod_1(Class1.smethod_0(ref ptr));
			dictionary_0[key] = new Class70
			{
				b5aeff63 = module_0,
				int_0 = int_
			};
		}
		for (int j = 0; j < ((e20f3dfe*)pVoid_0)->uint_1; j++)
		{
			uint key2 = Class1.smethod_0(ref ptr);
			uint num = Class1.smethod_0(ref ptr);
			dictionary_1[key2] = new string((char*)ptr, 0, (int)num);
			ptr += num << 1;
		}
		for (int k = 0; k < ((e20f3dfe*)pVoid_0)->b199a212; k++)
		{
			dictionary_2[Class1.smethod_0(ref ptr)] = new Struct3(ref ptr, module_0);
		}
		method_2((byte*)pVoid_0);
		method_0(module_0);
		dictionary_3[module_0] = this;
	}

	public static f90590 da79a168(Module module_0)
	{
		f90590 value;
		lock (dictionary_3)
		{
			if (!dictionary_3.TryGetValue(module_0, out value))
			{
				f90590 f90592 = (dictionary_3[module_0] = e6dc7988.ac554f47(module_0));
				value = f90592;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* method_1()
	{
		return pByte_0;
	}

	[SpecialName]
	public unsafe void method_2(byte* pByte_1)
	{
		pByte_0 = pByte_1;
	}

	public MemberInfo method_3(uint uint_0)
	{
		return dictionary_0[uint_0].cdea9f14();
	}

	public string method_4(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return dictionary_1[uint_0];
	}

	public Struct3 method_5(uint uint_0)
	{
		return dictionary_2[uint_0];
	}
}
