using System;
using System.Threading;

namespace Client.Modules.Implant;

internal sealed class MutexControl
{
	public static void Check()
	{
		bool createdNew = false;
		new Mutex(initiallyOwned: false, "1", out createdNew);
		if (!createdNew)
		{
			Environment.Exit(1);
		}
	}
}
