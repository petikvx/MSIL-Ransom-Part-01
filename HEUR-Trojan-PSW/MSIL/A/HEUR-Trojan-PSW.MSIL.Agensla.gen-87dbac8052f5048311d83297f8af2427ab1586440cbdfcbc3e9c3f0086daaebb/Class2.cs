using System;
using System.Reflection;

internal sealed class Class2
{
	internal Action method_0()
	{
		return (Action)Delegate.CreateDelegate(typeof(Action), new Class1().method_1() as MethodInfo);
	}
}
