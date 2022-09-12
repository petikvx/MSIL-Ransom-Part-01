using System;
using System.Threading;

namespace WindowsFormsApp1;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Console.WriteLine(Wrong.SForStrring());
			}
		}).Start();
		Thread.Sleep(-1);
	}
}
