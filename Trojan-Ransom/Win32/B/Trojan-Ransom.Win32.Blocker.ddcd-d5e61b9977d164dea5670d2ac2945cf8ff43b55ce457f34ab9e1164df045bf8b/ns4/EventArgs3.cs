using System;
using System.Runtime.CompilerServices;

namespace ns4;

internal sealed class EventArgs3 : EventArgs
{
	private Class18 class18_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

	[SpecialName]
	public Exception method_0()
	{
		return exception_0;
	}

	[SpecialName]
	public bool method_1()
	{
		return bool_0;
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_1;
	}

	[SpecialName]
	public bool method_3()
	{
		return bool_2;
	}

	internal void method_4()
	{
		bool_0 = true;
	}

	internal void method_5()
	{
		bool_1 = false;
	}

	internal void method_6()
	{
		bool_2 = false;
	}

	[SpecialName]
	public bool method_7()
	{
		return bool_3;
	}

	[SpecialName]
	public void method_8(bool bool_4)
	{
		bool_3 = bool_4;
	}

	public void method_9()
	{
		if (bool_0)
		{
			class18_0.method_18();
		}
	}

	public bool method_10()
	{
		if (!bool_1)
		{
			return false;
		}
		return class18_0.method_19();
	}

	internal EventArgs3(Class18 class18_1, Exception exception_1)
	{
		class18_0 = class18_1;
		exception_0 = exception_1;
	}
}
