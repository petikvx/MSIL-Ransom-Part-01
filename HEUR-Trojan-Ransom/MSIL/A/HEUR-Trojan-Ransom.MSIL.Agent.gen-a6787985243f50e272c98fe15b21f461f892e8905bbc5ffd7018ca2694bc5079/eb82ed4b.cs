using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class eb82ed4b
{
	private struct b674d681
	{
		public uint uint_0;

		public uint uint_1;

		public uint edf7d9fe;

		public uint uint_2;
	}

	private class f3d659e0
	{
		public Module module_0;

		public int ddf20649;

		public MemberInfo memberInfo_0;

		[SpecialName]
		public MemberInfo cd00c3bf()
		{
			return memberInfo_0 ?? (memberInfo_0 = module_0.ResolveMember(ddf20649));
		}
	}

	private Dictionary<uint, f3d659e0> dictionary_0;

	private Dictionary<uint, string> dictionary_1;

	private Dictionary<uint, Struct3> b2dc99fd;

	private static Dictionary<Module, eb82ed4b> dictionary_2 = new Dictionary<Module, eb82ed4b>();

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Module ca0bd37;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private unsafe byte* pByte_0;

	[SpecialName]
	public Module method_0()
	{
		return ca0bd37;
	}

	[SpecialName]
	private void method_1(Module module_0)
	{
		ca0bd37 = module_0;
	}

	public unsafe eb82ed4b(Module module_0, void* pVoid_0)
	{
		if (((b674d681*)pVoid_0)->uint_0 != 1145980749)
		{
			throw new InvalidProgramException();
		}
		dictionary_0 = new Dictionary<uint, f3d659e0>();
		dictionary_1 = new Dictionary<uint, string>();
		b2dc99fd = new Dictionary<uint, Struct3>();
		byte* ptr = (byte*)pVoid_0 + sizeof(b674d681);
		for (int i = 0; i < ((b674d681*)pVoid_0)->uint_1; i++)
		{
			uint key = a41805c0.b3b1be1f(ref ptr);
			int ddf = (int)a41805c0.bf3cf4f2(a41805c0.b3b1be1f(ref ptr));
			dictionary_0[key] = new f3d659e0
			{
				module_0 = module_0,
				ddf20649 = ddf
			};
		}
		for (int j = 0; j < ((b674d681*)pVoid_0)->edf7d9fe; j++)
		{
			uint key2 = a41805c0.b3b1be1f(ref ptr);
			uint num = a41805c0.b3b1be1f(ref ptr);
			dictionary_1[key2] = new string((char*)ptr, 0, (int)num);
			ptr += num << 1;
		}
		for (int k = 0; k < ((b674d681*)pVoid_0)->uint_2; k++)
		{
			b2dc99fd[a41805c0.b3b1be1f(ref ptr)] = new Struct3(ref ptr, module_0);
		}
		ffb367af((byte*)pVoid_0);
		method_1(module_0);
		dictionary_2[module_0] = this;
	}

	public static eb82ed4b c8dafbc3(Module module_0)
	{
		eb82ed4b value;
		lock (dictionary_2)
		{
			if (!dictionary_2.TryGetValue(module_0, out value))
			{
				eb82ed4b eb82ed4b3 = (dictionary_2[module_0] = b5508b63.smethod_0(module_0));
				value = eb82ed4b3;
				return value;
			}
		}
		return value;
	}

	[SpecialName]
	public unsafe byte* f1a90190()
	{
		return pByte_0;
	}

	[SpecialName]
	public unsafe void ffb367af(byte* pByte_1)
	{
		pByte_0 = pByte_1;
	}

	public MemberInfo d3f1f142(uint uint_0)
	{
		return dictionary_0[uint_0].cd00c3bf();
	}

	public string f54a7fb9(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return dictionary_1[uint_0];
	}

	public Struct3 d92c25c4(uint uint_0)
	{
		return b2dc99fd[uint_0];
	}
}
