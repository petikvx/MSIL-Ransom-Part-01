using System;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private Class8 class8_0;

	private Exception exception_0;

	private bool bool_0 = true;

	internal bool bool_1;

	internal bool bool_2 = true;

	internal bool bool_3;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool flag = (bool_3 = value);
		}
	}

	internal void method_0(bool bool_4)
	{
		bool_0 = bool_4;
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
		return class8_0.method_12();
	}

	internal ReportExceptionEventArgs(Class8 class8_1, Exception exception_1)
	{
		class8_0 = class8_1;
		exception_0 = exception_1;
	}
}
