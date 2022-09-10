using System;
using System.Threading;

namespace UsingThreads;

internal class Program
{
	private static void Main()
	{
		Thread thread = new Thread(Prio);
		thread.Name = "First";
		Thread thread2 = new Thread(Prio);
		thread2.Name = "Second";
		thread.Priority = ThreadPriority.Highest;
		thread2.Priority = ThreadPriority.Lowest;
		thread.Start();
		thread2.Start();
	}

	private static void Prio()
	{
		for (int i = 0; i < 10000; i++)
		{
			Console.WriteLine("{0}, {1}", Thread.CurrentThread.Name, i);
		}
	}

	private static void ThreadMain()
	{
		Console.WriteLine("Thread {0} started", Thread.CurrentThread.Name);
		Thread.Sleep(3000);
		Console.WriteLine("Thread {0} completed", Thread.CurrentThread.Name);
	}

	private static void ThreadMainWithParameters(object o)
	{
		Console.WriteLine("Running in a thread, received {0}", ((Data)o).Message);
	}
}
