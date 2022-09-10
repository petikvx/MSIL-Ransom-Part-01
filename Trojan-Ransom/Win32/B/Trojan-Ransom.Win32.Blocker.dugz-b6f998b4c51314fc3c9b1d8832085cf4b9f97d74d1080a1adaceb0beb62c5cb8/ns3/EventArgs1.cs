using System;
using System.Runtime.CompilerServices;

namespace ns3;

internal sealed class EventArgs1 : EventArgs
{
	private Class25 class25_0;

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
		return class25_0.method_17();
	}

	internal EventArgs1(Class25 class25_1, Exception exception_1)
	{
		class25_0 = class25_1;
		exception_0 = exception_1;
	}
}
