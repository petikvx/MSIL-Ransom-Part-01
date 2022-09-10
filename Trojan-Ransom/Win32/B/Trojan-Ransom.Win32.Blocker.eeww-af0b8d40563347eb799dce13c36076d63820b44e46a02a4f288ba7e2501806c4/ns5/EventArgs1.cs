using System;
using ns2;

namespace ns5;

internal sealed class EventArgs1 : EventArgs
{
	internal Class29 class29_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public void method_0()
	{
		if (bool_0)
		{
			Class25.smethod_216(class29_0);
		}
	}

	internal EventArgs1(Class29 class29_1, Exception exception_1)
	{
		class29_0 = class29_1;
		exception_0 = exception_1;
	}
}
