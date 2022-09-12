using System;
using ns4;
using ns6;

namespace ns3;

internal sealed class EventArgs1 : EventArgs
{
	internal Class26 class26_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public void method_0()
	{
		if (bool_0)
		{
			Class3.smethod_115(class26_0);
		}
	}

	internal EventArgs1(Class26 class26_1, Exception exception_1)
	{
		class26_0 = class26_1;
		exception_0 = exception_1;
	}
}
