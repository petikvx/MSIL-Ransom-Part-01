using System;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private Class13 class13_0;

	private Exception exception_0;

	private bool bool_0;

	internal bool bool_1;

	internal bool bool_2 = true;

	internal bool bool_3 = true;

	public bool TryToContinue
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	internal void method_0(bool bool_4)
	{
		bool flag = (bool_3 = bool_4);
	}

	internal void method_1()
	{
		bool_1 = true;
	}

	public bool SendReport()
	{
		if (!bool_2)
		{
			return false;
		}
		return class13_0.method_12();
	}

	internal ReportExceptionEventArgs(Class13 class13_1, Exception exception_1)
	{
		class13_0 = class13_1;
		exception_0 = exception_1;
	}
}
