using System;
using System.Runtime.CompilerServices;
using ns4;

namespace ns2;

[GAttribute0(14)]
public class GEventArgs1 : EventArgs
{
	private GClass2 gclass2_0 = null;

	private Exception exception_0 = null;

	private bool bool_0 = false;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3 = false;

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
			gclass2_0.method_15();
		}
	}

	public bool method_10()
	{
		if (!bool_1)
		{
			return false;
		}
		return gclass2_0.method_16();
	}

	internal GEventArgs1(GClass2 gclass2_1, Exception exception_1)
	{
		gclass2_0 = gclass2_1;
		exception_0 = exception_1;
	}
}
