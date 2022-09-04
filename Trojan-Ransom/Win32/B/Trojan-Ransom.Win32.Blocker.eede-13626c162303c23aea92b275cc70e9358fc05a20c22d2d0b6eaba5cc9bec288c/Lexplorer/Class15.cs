using System;
using System.Collections.Generic;
using System.Threading;

namespace Lexplorer;

internal class Class15 : Class13
{
	private Class5 inactivityDetector = new Class5();

	public Class15()
	{
		methodTable = new Dictionary<string, ExecutionMethodDelegate>();
		methodTable.Add("SET", Set);
	}

	protected bool Set(Class10 props, bool forced)
	{
		int num = int.Parse(props["V"]);
		int num2 = 0;
		do
		{
			num2 += 200;
			Thread.Sleep(200);
			if (!IsNoUserActivity(150) && !forced)
			{
				return false;
			}
		}
		while (num2 < num);
		return true;
	}

	private bool IsNoUserActivity(int periodMilliseconds)
	{
		object obj = inactivityDetector.GetInactiveTime();
		if (obj != null)
		{
			return ((TimeSpan)obj).TotalMilliseconds >= (double)periodMilliseconds;
		}
		return false;
	}

	public override string ToString()
	{
		return $"Command type: DELAY, Method={base.ExecutionMethodName}";
	}
}
