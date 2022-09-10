using System;

namespace UsingThreads;

public class MyThread
{
	private string data;

	public MyThread(string data)
	{
		this.data = data;
	}

	public void ThreadMain()
	{
		Console.WriteLine("Running in a thread, data: {0}", data);
	}
}
