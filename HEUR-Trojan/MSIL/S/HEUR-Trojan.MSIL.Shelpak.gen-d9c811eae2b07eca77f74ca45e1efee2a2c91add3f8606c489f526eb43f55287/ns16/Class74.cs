using System;
using System.Threading;

namespace ns16;

internal sealed class Class74
{
	public static void smethod_0()
	{
		bool createdNew = false;
		new Mutex(initiallyOwned: false, "1", out createdNew);
		if (!createdNew)
		{
			Environment.Exit(1);
		}
	}
}
