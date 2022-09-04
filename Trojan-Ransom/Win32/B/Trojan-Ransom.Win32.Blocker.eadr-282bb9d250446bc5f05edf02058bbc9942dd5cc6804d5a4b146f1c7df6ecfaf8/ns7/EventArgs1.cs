using System;
using System.Runtime.CompilerServices;

namespace ns7;

internal class EventArgs1 : EventArgs
{
	private Class21 class21_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

	internal void method_0(bool bool_4)
	{
		bool_2 = bool_4;
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_3;
	}

	[SpecialName]
	public void method_3(bool bool_4)
	{
		bool_3 = bool_4;
	}

	public bool method_4()
	{
		if (!bool_1)
		{
			return false;
		}
		return class21_0.method_17();
	}

	internal EventArgs1(Class21 class21_1, Exception exception_1)
	{
		class21_0 = class21_1;
		exception_0 = exception_1;
	}
}
