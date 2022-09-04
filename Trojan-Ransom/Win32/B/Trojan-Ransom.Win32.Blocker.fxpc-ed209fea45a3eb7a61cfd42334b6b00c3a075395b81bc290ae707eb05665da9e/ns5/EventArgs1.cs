using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns4;

namespace ns5;

internal class EventArgs1 : EventArgs
{
	private Class29 class29_0;

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

	internal void method_4(bool bool_4)
	{
		bool_2 = bool_4;
	}

	internal void method_5()
	{
		bool_0 = true;
	}

	[SpecialName]
	public bool method_6()
	{
		return bool_3;
	}

	[SpecialName]
	public void method_7(bool bool_4)
	{
		bool_3 = bool_4;
	}

	public void method_8()
	{
		if (bool_0)
		{
			class29_0.method_21();
		}
	}

	public bool method_9(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return class29_0.method_22(string_0);
	}

	public bool method_10()
	{
		if (!bool_1)
		{
			return false;
		}
		return class29_0.method_17();
	}

	internal EventArgs1(Class29 class29_1, Exception exception_1)
	{
		class29_0 = class29_1;
		exception_0 = exception_1;
	}
}
