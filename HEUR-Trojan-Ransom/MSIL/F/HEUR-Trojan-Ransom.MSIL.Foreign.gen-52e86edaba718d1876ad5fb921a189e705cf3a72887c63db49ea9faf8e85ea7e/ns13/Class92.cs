using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace ns13;

internal sealed class Class92 : Class87
{
	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class92(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public override void vmethod_0()
	{
		base.Column.Type = method_0();
		base.Column.IsNumberSigned = bool_0;
		base.Column.ClrType = (bool_0 ? method_1() : method_2());
		delegate1_0 = (bool_0 ? method_3() : method_4());
		base.Column.IsPadded = !bool_0 && (base.Flags & 1) != 0;
	}

	private Enum49 method_0()
	{
		switch ((int)base.Column.Length + ((!bool_0) ? 1 : 0))
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
			return Enum49.const_1;
		case 5:
		case 6:
			return Enum49.const_2;
		case 7:
		case 8:
		case 9:
			return Enum49.const_3;
		case 10:
		case 11:
			return Enum49.const_4;
		default:
			return Enum49.const_5;
		}
	}

	private Type method_1()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
			return typeof(sbyte);
		case 5u:
		case 6u:
			return typeof(short);
		case 7u:
		case 8u:
		case 9u:
			return typeof(int);
		case 10u:
		case 11u:
			return typeof(int);
		default:
			return typeof(long);
		}
	}

	private Type method_2()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
			return typeof(byte);
		case 4u:
		case 5u:
			return typeof(ushort);
		case 6u:
		case 7u:
		case 8u:
			return typeof(uint);
		case 9u:
		case 10u:
			return typeof(uint);
		default:
			return typeof(ulong);
		}
	}

	private Delegate1 method_3()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
		case 4u:
			return method_7;
		case 5u:
		case 6u:
			return method_8;
		case 7u:
		case 8u:
		case 9u:
			return method_9;
		case 10u:
		case 11u:
			return method_9;
		default:
			return method_10;
		}
	}

	private Delegate1 method_4()
	{
		switch (base.Column.Length)
		{
		case 0u:
		case 1u:
		case 2u:
		case 3u:
			return method_11;
		case 4u:
		case 5u:
			return method_12;
		case 6u:
		case 7u:
		case 8u:
			return method_13;
		case 9u:
		case 10u:
			return method_13;
		default:
			return method_14;
		}
	}

	private long method_5(byte[] byte_0)
	{
		return new CodedInputStream(byte_0).ReadSInt64();
	}

	private ulong method_6(byte[] byte_0)
	{
		return new CodedInputStream(byte_0).ReadUInt64();
	}

	public object method_7(byte[] byte_0)
	{
		return (sbyte)method_5(byte_0);
	}

	public object method_8(byte[] byte_0)
	{
		return (short)method_5(byte_0);
	}

	public object method_9(byte[] byte_0)
	{
		return (int)method_5(byte_0);
	}

	public object method_10(byte[] byte_0)
	{
		return method_5(byte_0);
	}

	public object method_11(byte[] byte_0)
	{
		return (byte)method_6(byte_0);
	}

	public object method_12(byte[] byte_0)
	{
		return (ushort)method_6(byte_0);
	}

	public object method_13(byte[] byte_0)
	{
		return (uint)method_6(byte_0);
	}

	public object method_14(byte[] byte_0)
	{
		return method_6(byte_0);
	}

	static Class92()
	{
		Strings.CreateGetStringDelegate(typeof(Class92));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397942), getString_0(107397937)).Replace(getString_0(107397900), getString_0(107397895)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397890)))
		{
			throw new SecurityException(getString_0(107397865));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
