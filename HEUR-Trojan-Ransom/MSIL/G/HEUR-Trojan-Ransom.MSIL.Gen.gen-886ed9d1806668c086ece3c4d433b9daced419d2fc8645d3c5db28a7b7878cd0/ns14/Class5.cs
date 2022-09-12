using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns49;

namespace ns14;

internal class Class5
{
	internal class Class6 : IDisposable
	{
		private IntPtr intptr_0;

		internal static object object_0;

		[DllImport("FaresGames.dll")]
		private static extern IntPtr CreateInstance(uint uint_0);

		[DllImport("FaresGames.dll")]
		private static extern void DeleteInstance(IntPtr intptr_1);

		[DllImport("FaresGames.dll")]
		private static extern bool RWVM(IntPtr intptr_1, UIntPtr uintptr_0, [Out] byte[] byte_0, UIntPtr uintptr_1, out ulong ulong_0, bool bool_0 = true, bool bool_1 = false);

		public Class6(int int_0)
		{
		}

		public bool method_0(ulong ulong_0, out byte[] byte_0, int int_0, out ulong ulong_1)
		{
			return true;
		}

		public bool method_1(ulong ulong_0, byte[] byte_0, out ulong ulong_1)
		{
			return true;
		}

		public void Dispose()
		{
		}

		static Class6()
		{
			Class25.smethod_22();
			smethod_2();
		}

		internal static bool smethod_0()
		{
			return true;
		}

		internal static Class6 smethod_1()
		{
			return null;
		}

		internal static void smethod_2()
		{
		}
	}

	private static class Class7
	{
		internal struct Struct11
		{
			public IntPtr intptr_0;

			public IntPtr intptr_1;

			public uint uint_0;

			public IntPtr intptr_2;

			public uint uint_1;

			public uint uint_2;

			public uint uint_3;
		}

		[DllImport("kernel32.dll")]
		public static extern bool ReadProcessMemory(IntPtr intptr_0, long long_0, byte[] byte_0, int int_0, int int_1 = 0);

		[DllImport("kernel32.dll")]
		internal static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out Struct11 struct11_0, uint uint_0);

		static Class7()
		{
			Class25.smethod_22();
			smethod_0();
		}

		internal static void smethod_0()
		{
		}
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IntPtr intptr_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte[] byte_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private long long_0;

	private Class7.Struct11 struct11_0;

	private static byte byte_1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Dictionary<string, string> dictionary_0;

	private static object object_0;

	[SpecialName]
	[CompilerGenerated]
	private IntPtr method_0()
	{
		return (IntPtr)(object)null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(IntPtr intptr_1)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private byte[] method_2()
	{
		return null;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(byte[] byte_2)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_4()
	{
		return 0L;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_5(long long_1)
	{
	}

	[SpecialName]
	[CompilerGenerated]
	private Dictionary<string, string> method_6()
	{
		return null;
	}

	public Class5(IntPtr intptr_1)
	{
	}

	public bool method_7(ProcessModule processModule_0)
	{
		return true;
	}

	public void method_8(string string_0, string string_1)
	{
	}

	private bool method_9(int int_0, byte[] byte_2)
	{
		return true;
	}

	private bool method_10(int int_0, byte[] byte_2, byte[] byte_3)
	{
		return true;
	}

	public long method_11(string string_0, out long long_1)
	{
		return 0L;
	}

	public long[] method_12(string string_0, long long_1 = 0L, long long_2 = 2147483647L)
	{
		return null;
	}

	public Dictionary<string, long> method_13(out long long_1)
	{
		return null;
	}

	private byte[] method_14(string string_0)
	{
		return null;
	}

	static Class5()
	{
		Class25.smethod_22();
		Class25.smethod_13();
		Delegate11.smethod_0(Delegate11.delegate11_0);
		Delegate11.smethod_0(Delegate11.delegate11_2);
		byte_1 = 63;
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Class5 smethod_1()
	{
		return null;
	}

	internal static void smethod_2(object object_1)
	{
	}

	internal static object smethod_3(object object_1)
	{
		return null;
	}

	internal static object smethod_4(object object_1)
	{
		return null;
	}
}
