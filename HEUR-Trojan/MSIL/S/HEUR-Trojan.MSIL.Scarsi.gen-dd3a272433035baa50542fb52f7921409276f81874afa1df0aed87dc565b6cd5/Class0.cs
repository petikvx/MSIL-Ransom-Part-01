using System;
using System.Reflection;

internal sealed class Class0
{
	private static void Main()
	{
		new Class3();
		smethod_0()();
	}

	private static Action smethod_0()
	{
		return (Action)Delegate.CreateDelegate(typeof(Action), smethod_1() as MethodInfo);
	}

	private static object smethod_1()
	{
		return new Class3().method_0().GetType("Pewzvfaw.Fplqylgofg")!.GetMethod("Kgxrtfnqholq");
	}
}
