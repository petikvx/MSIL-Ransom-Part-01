using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class be6c394c
{
	private struct baec945a
	{
		public uint uint_0;

		public uint uint_1;

		public uint aef4d34b;

		public uint uint_2;
	}

	private class b84699b5
	{
		public Module module_0;

		public int int_0;

		public MemberInfo c335b5b9;

		[SpecialName]
		public MemberInfo bbefdf90()
		{
			return c335b5b9 ?? (c335b5b9 = module_0.ResolveMember(int_0));
		}
	}

	private Dictionary<uint, b84699b5> dictionary_0;

	private Dictionary<uint, string> dictionary_1;

	private Dictionary<uint, Struct4> dictionary_2;

	private static Dictionary<Module, be6c394c> b3c2ac6d = new Dictionary<Module, be6c394c>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module c4aa22e8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* pByte_0;

	[SpecialName]
	public Module method_0()
	{
		return c4aa22e8;
	}

	[SpecialName]
	private void method_1(Module module_0)
	{
		c4aa22e8 = module_0;
	}

	public unsafe be6c394c(Module module_0, void* pVoid_0)
	{
		if (((baec945a*)pVoid_0)->uint_0 != 1145980749)
		{
			throw new InvalidProgramException();
		}
		dictionary_0 = new Dictionary<uint, b84699b5>();
		dictionary_1 = new Dictionary<uint, string>();
		dictionary_2 = new Dictionary<uint, Struct4>();
		byte* ptr = (byte*)pVoid_0 + sizeof(baec945a);
		for (int i = 0; i < ((baec945a*)pVoid_0)->uint_1; i++)
		{
			uint key = Class1.smethod_0(ref ptr);
			int int_ = (int)Class1.fd58900f(Class1.smethod_0(ref ptr));
			dictionary_0[key] = new b84699b5
			{
				module_0 = module_0,
				int_0 = int_
			};
		}
		for (int j = 0; j < ((baec945a*)pVoid_0)->aef4d34b; j++)
		{
			uint key2 = Class1.smethod_0(ref ptr);
			uint num = Class1.smethod_0(ref ptr);
			dictionary_1[key2] = new string((char*)ptr, 0, (int)num);
			ptr += num << 1;
		}
		for (int k = 0; k < ((baec945a*)pVoid_0)->uint_2; k++)
		{
			dictionary_2[Class1.smethod_0(ref ptr)] = new Struct4(ref ptr, module_0);
		}
		eee55b40((byte*)pVoid_0);
		method_1(module_0);
		b3c2ac6d[module_0] = this;
	}

	public static be6c394c smethod_0(Module module_0)
	{
		be6c394c value;
		lock (b3c2ac6d)
		{
			if (!b3c2ac6d.TryGetValue(module_0, out value))
			{
				be6c394c be6c394c3 = (b3c2ac6d[module_0] = Class60.d28b9c53(module_0));
				value = be6c394c3;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* method_2()
	{
		return pByte_0;
	}

	[SpecialName]
	public unsafe void eee55b40(byte* pByte_1)
	{
		pByte_0 = pByte_1;
	}

	public MemberInfo a9b0159f(uint uint_0)
	{
		return dictionary_0[uint_0].bbefdf90();
	}

	public string method_3(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return dictionary_1[uint_0];
	}

	public Struct4 method_4(uint uint_0)
	{
		return dictionary_2[uint_0];
	}
}
