using System;
using System.Threading;

public class GClass1
{
	private readonly object object_0 = new object();

	private bool bool_0;

	public void method_0()
	{
		Monitor.Enter(object_0);
		if (bool_0 || 1 == 0)
		{
			Monitor.Exit(object_0);
			throw new InvalidOperationException("Recursive calls not allowed");
		}
		bool_0 = true;
	}

	public void method_1()
	{
		if (!bool_0 && 0 == 0)
		{
			throw new InvalidOperationException("Not locked");
		}
		bool_0 = false;
		Monitor.Exit(object_0);
	}
}
