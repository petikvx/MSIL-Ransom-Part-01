using System;
using ns1;
using ns5;

namespace ns8;

internal sealed class EventArgs1 : EventArgs
{
	internal Class24 class24_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public void method_0()
	{
		if (bool_0)
		{
			Class29.smethod_180(class24_0);
		}
	}

	internal EventArgs1(Class24 class24_1, Exception exception_1)
	{
		class24_0 = class24_1;
		exception_0 = exception_1;
	}
}
