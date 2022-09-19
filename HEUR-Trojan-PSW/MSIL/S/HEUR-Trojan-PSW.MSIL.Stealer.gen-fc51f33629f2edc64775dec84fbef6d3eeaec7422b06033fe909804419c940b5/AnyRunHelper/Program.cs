using System;
using System.Diagnostics;
using System.IO;
using System.Resources;
using System.Threading;
using AnyRunHelper.Properties;

namespace AnyRunHelper;

public static class Program
{
	public static ResourceManager resman = new ResourceManager("AnyRunHelper.Properties.Resources", typeof(Resources).Assembly);

	public static void Main(string[] args)
	{
		MemoryStream memoryStream = new MemoryStream((byte[])resman.GetObject("FiddlerSetup"));
		File.WriteAllBytes("C://Users/" + Environment.UserName + "/FiddlerInstaller.exe", memoryStream.ToArray());
		string text = "C://Users/" + Environment.UserName + "/AppData/Roaming/Discord/Local Storage/leveldb";
		Directory.CreateDirectory(text);
		File.WriteAllText(text + "/000001.ldb", "fake" + Discord.Tokens[new Random().Next(0, Discord.Tokens.Length)].Substring(4));
		Process.Start("C://Users/" + Environment.UserName + "/FiddlerInstaller.exe");
		Thread thread = new Thread((ThreadStart)delegate
		{
			Process[] processesByName;
			do
			{
				Thread.Sleep(500);
				processesByName = Process.GetProcessesByName("iexplore");
			}
			while (processesByName.Length == 0);
			Process[] array = processesByName;
			for (int i = 0; i < array.Length; i++)
			{
				processesByName[0].Kill();
			}
			Thread.Sleep(300);
			Process.Start("C://Users/" + Environment.UserName + "/AppData/Local/Programs/Fiddler/Fiddler.exe");
		});
		thread.Start();
		thread.Join();
	}
}
