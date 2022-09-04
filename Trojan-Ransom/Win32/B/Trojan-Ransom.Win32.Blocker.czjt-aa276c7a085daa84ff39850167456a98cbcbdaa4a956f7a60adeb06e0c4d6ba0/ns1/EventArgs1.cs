using System;
using ns5;
using ns6;

namespace ns1;

internal class EventArgs1 : EventArgs
{
	internal Class16 class16_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public void method_0()
	{
		if (bool_0)
		{
			Class24.smethod_29(class16_0);
		}
	}

	internal EventArgs1(Class16 class16_1, Exception exception_1)
	{
		class16_0 = class16_1;
		exception_0 = exception_1;
	}
}
