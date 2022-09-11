using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace hidden_tear_decrypter;

public class Form1 : Form
{
	private string userName = Environment.UserName;

	private string userDir = "C:\\Users\\";

	private IContainer components = null;

	private TextBox textBox1;

	private Label label1;

	private Button button1;

	private Label label2;

	private Label label3;

	public Form1()
	{
		InitializeComponent();
	}

	public byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
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
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void DecryptFile(string file, string password)
	{
		byte[] bytesToBeDecrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = AES_Decrypt(bytesToBeDecrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		string extension = Path.GetExtension(file);
		string destFileName = file.Substring(0, file.Length - extension.Length);
		File.Move(file, destFileName);
	}

	public void DecryptDirectory(string location)
	{
		string text = ((Control)textBox1).get_Text();
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			string extension = Path.GetExtension(files[i]);
			if (extension == ".locked")
			{
				DecryptFile(files[i], text);
			}
		}
		for (int i = 0; i < directories.Length; i++)
		{
			DecryptDirectory(directories[i]);
		}
		((Control)label3).set_Visible(true);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string text = "\\Desktop";
		string location = userDir + userName + text;
		DecryptDirectory(location);
	}

	private void Form1_Load(object sender, EventArgs e)
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
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0307: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		textBox1 = new TextBox();
		label1 = new Label();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Location(new Point(83, 15));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(152, 20));
		((Control)textBox1).set_TabIndex(0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(21, 18));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(56, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Password:");
		((Control)button1).set_Location(new Point(24, 41));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(211, 31));
		((Control)button1).set_TabIndex(2);
		((Control)button1).set_Text("Decrypt My Files");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(30, 112));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(196, 26));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("hidden tear decrypter\r\ncoded by Utku Sen(Jani) / utkusen.com");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)label3).set_ForeColor(Color.ForestGreen);
		((Control)label3).set_Location(new Point(66, 75));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(123, 20));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Files Decrypted!");
		((Control)label3).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(256, 156));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("ht decrypter");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
