using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using Google.Protobuf;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns14;

namespace ns13;

internal sealed class Class94 : Class87
{
	[NonSerialized]
	internal static GetString getString_0;

	public override void vmethod_0()
	{
		base.Column.Type = method_0();
		base.Column.ClrType = typeof(DateTime);
		delegate1_0 = method_1;
	}

	private Enum49 method_0()
	{
		if ((base.Flags & (true ? 1u : 0u)) != 0)
		{
			return Enum49.const_15;
		}
		if (base.Column.Length == 10)
		{
			return Enum49.const_13;
		}
		return Enum49.const_14;
	}

	public object method_1(byte[] byte_0)
	{
		CodedInputStream codedInputStream = new CodedInputStream(byte_0);
		ulong num = 0uL;
		ulong num2 = 0uL;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		ulong num7 = codedInputStream.ReadUInt64();
		num = codedInputStream.ReadUInt64();
		num2 = codedInputStream.ReadUInt64();
		if (!codedInputStream.IsAtEnd)
		{
			num3 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num4 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num5 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num6 = codedInputStream.ReadInt64();
		}
		return new DateTime((int)num7, (int)num, (int)num2, (int)num3, (int)num4, (int)num5).AddTicks(num6 * 10L);
	}

	static Class94()
	{
		Strings.CreateGetStringDelegate(typeof(Class94));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397945), getString_0(107397940)).Replace(getString_0(107397903), getString_0(107397898)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397893)))
		{
			throw new SecurityException(getString_0(107397868));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
