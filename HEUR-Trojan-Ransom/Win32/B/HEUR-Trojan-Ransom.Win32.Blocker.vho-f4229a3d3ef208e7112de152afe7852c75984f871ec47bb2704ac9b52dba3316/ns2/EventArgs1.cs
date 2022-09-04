using System;
using ns3;
using ns5;

namespace ns2;

internal class EventArgs1 : EventArgs
{
	internal Class28 class28_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public void method_0()
	{
		if (bool_0)
		{
			Class24.smethod_28(class28_0);
		}
	}

	internal EventArgs1(Class28 class28_1, Exception exception_1)
	{
		class28_0 = class28_1;
		exception_0 = exception_1;
	}
}
