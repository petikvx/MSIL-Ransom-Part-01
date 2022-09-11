using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal static class Class8
{
	[Serializable]
	internal enum StackCrawlMark
	{
		LookForMe,
		LookForMyCaller,
		LookForMyCallersCaller,
		LookForThread
	}

	internal struct Struct0
	{
		private IntPtr intptr_0;

		internal Struct0(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
		}
	}

	internal struct Struct1
	{
		private IntPtr intptr_0;

		internal Struct1(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
		}
	}

	internal struct Struct2
	{
		private IntPtr intptr_0;

		internal Struct2(IntPtr intptr_1)
		{
			intptr_0 = intptr_1;
		}
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 324)]
	private struct Struct3
	{
	}

	internal const string string_0 = "QCall";

	private static readonly Array array_0;

	private static readonly object object_0 = new char[162];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	[SecurityCritical]
	internal static Struct2 smethod_0(ref string string_1)
	{
		return new Struct2(smethod_6(ref string_1));
	}

	[SecurityCritical]
	internal static Struct1 smethod_1<T>(ref T gparam_0) where T : class
	{
		return new Struct1(smethod_6(ref gparam_0));
	}

	[SecurityCritical]
	internal static Struct0 smethod_2(ref StackCrawlMark stackCrawlMark_0)
	{
		return new Struct0(smethod_6(ref stackCrawlMark_0));
	}

	[SecurityCritical]
	internal static T smethod_3<T>(object object_2) where T : class
	{
		throw new InvalidOperationException();
	}

	internal static int smethod_4<T>(T gparam_0) where T : struct
	{
		throw new InvalidOperationException();
	}

	internal static long smethod_5<T>(T gparam_0) where T : struct
	{
		throw new InvalidOperationException();
	}

	[SecurityCritical]
	internal static IntPtr smethod_6<T>(ref T gparam_0)
	{
		throw new InvalidOperationException();
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern void smethod_7(object[] object_2, int int_0, object object_3);

	[SecurityCritical]
	internal static Class7 n2xuuyH8baEPSPhhaVTawoKqxzbZi4gkybW4iLqzpDnZP9DvjRs4KfzdboBcaCEMmiPwqcPoVMNPBIPtfbSUBGvQw5vn0jl96PY2kX57s10k4eHzsl7geq3MfbJEfI9lrzsCYQI88xRUnQ66mOWm(object object_2)
	{
		return smethod_3<Class7>(object_2);
	}

	static Class8()
	{
		char[] array = new char[8];
		array[0] = '㋆';
		array[7] = '㇠';
		array[1] = 'ᒀ';
		array[2] = 'థ';
		array[4] = 'Ӑ';
		array[6] = '㛏';
		array[3] = '㬃';
		array[5] = '¶';
		object_1 = new string[13];
		array_0 = array;
	}
}
