using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class EventArgs1 : EventArgs
{
	private Class23 class23_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

	internal EventArgs1(Class23 CO_, Exception CO_)
	{
		class23_0 = CO_;
		exception_0 = CO_;
	}

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

	internal void method_4(bool CO_)
	{
		bool_2 = CO_;
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
	public void method_7(bool CO_)
	{
		bool_3 = CO_;
	}

	public void method_8()
	{
		if (bool_0)
		{
			class23_0.method_21();
		}
	}

	public bool method_9(string CO_)
	{
		if (File.Exists(CO_))
		{
			File.Delete(CO_);
		}
		return class23_0.method_22(CO_);
	}

	public bool method_10()
	{
		if (!bool_1)
		{
			return false;
		}
		return class23_0.method_17();
	}
}
