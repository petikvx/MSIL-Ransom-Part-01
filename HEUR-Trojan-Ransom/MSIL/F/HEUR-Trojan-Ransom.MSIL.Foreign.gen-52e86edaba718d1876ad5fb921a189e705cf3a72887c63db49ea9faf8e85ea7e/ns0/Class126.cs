using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns0;

internal sealed class Class126
{
	private long long_0;

	public static readonly long long_1;

	public static readonly bool bool_0;

	[CompilerGenerated]
	private long long_2;

	[NonSerialized]
	internal static GetString getString_0;

	public long ElapsedMilliseconds
	{
		[CompilerGenerated]
		get
		{
			return long_2;
		}
		[CompilerGenerated]
		private set
		{
			long_2 = value;
		}
	}

	public TimeSpan Elapsed => new TimeSpan(0, 0, 0, 0, (int)ElapsedMilliseconds);

	public Class126()
	{
		ElapsedMilliseconds = 0L;
	}

	public void method_0()
	{
		long_0 = Environment.TickCount;
	}

	public void method_1()
	{
		long num = Environment.TickCount;
		long num2 = ((num < long_0) ? (2147483647L - long_0 + num) : (num - long_0));
		ElapsedMilliseconds += num2;
	}

	public void method_2()
	{
		ElapsedMilliseconds = 0L;
		long_0 = 0L;
	}

	public static Class126 smethod_0()
	{
		Class126 @class = new Class126();
		@class.method_0();
		return @class;
	}

	public static long smethod_1()
	{
		return Environment.TickCount;
	}

	private bool method_3()
	{
		return (ulong)long_0 > 0uL;
	}

	static Class126()
	{
		Strings.CreateGetStringDelegate(typeof(Class126));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398121), getString_0(107398116)).Replace(getString_0(107398079), getString_0(107398074)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398069)))
		{
			throw new SecurityException(getString_0(107398044));
		}
		long_1 = 1000L;
		bool_0 = false;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
