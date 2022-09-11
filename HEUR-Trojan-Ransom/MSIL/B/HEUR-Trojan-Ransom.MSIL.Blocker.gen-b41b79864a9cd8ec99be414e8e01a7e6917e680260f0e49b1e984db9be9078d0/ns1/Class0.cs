using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using ns2;
using ns4;
using ns6;

namespace ns1;

internal sealed class Class0 : Application
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct0
	{
		public Assembly C;
	}

	internal static int G = 2;

	internal static int K = 4;

	internal static readonly byte[] B = Class3.smethod_0();

	internal static MethodInfo C;

	public void method_0()
	{
		try
		{
			for (int i = 0; i < B.Length; i++)
			{
				Class1.smethod_0(i);
			}
		}
		catch
		{
		}
		Struct0 struct0_ = default(Struct0);
		struct0_.C = smethod_0(ref struct0_);
		GClass0.smethod_0(struct0_.C);
	}

	public static void Main()
	{
		Class0 @class = new Class0();
		try
		{
			@class.method_0();
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	internal static Assembly smethod_0(ref Struct0 struct0_0)
	{
		struct0_0.C = AppDomain.CurrentDomain.Load(B, null);
		return struct0_0.C;
	}
}
