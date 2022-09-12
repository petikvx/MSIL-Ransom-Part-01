using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Gecko;

public static class XULRunnerLocator
{
	private static string DirectoryOfTheApplicationExecutable
	{
		get
		{
			string absolutePath;
			if (Assembly.GetEntryAssembly() == null)
			{
				absolutePath = new Uri(Assembly.GetExecutingAssembly().CodeBase).AbsolutePath;
				absolutePath = Uri.UnescapeDataString(absolutePath);
			}
			else
			{
				absolutePath = AppDomain.CurrentDomain.BaseDirectory;
			}
			return Directory.GetParent(absolutePath)!.FullName;
		}
	}

	private static string FindSpecialXulRunnerDirectory(string applicationPath, string hintPath)
	{
		string pathRoot = Path.GetPathRoot(applicationPath);
		string text = applicationPath;
		string text2;
		while (true)
		{
			if (!pathRoot.Equals(text, StringComparison.CurrentCultureIgnoreCase))
			{
				text2 = Path.Combine(text, hintPath);
				if (Directory.Exists(text2))
				{
					break;
				}
				text = Path.GetDirectoryName(text);
				continue;
			}
			return null;
		}
		return text2;
	}

	private static string GetXULRunnerLocationLinux(string hintPath)
	{
		string environmentVariable = Environment.GetEnvironmentVariable("MOZ_PATH");
		if (environmentVariable != null && Directory.Exists(environmentVariable))
		{
			return environmentVariable;
		}
		string text = FindSpecialXulRunnerDirectory(DirectoryOfTheApplicationExecutable, hintPath);
		if (text != null)
		{
			return text;
		}
		string text2 = typeof(XULRunnerLocator).Assembly.GetName().Version!.Major.ToString();
		string[] array = new string[3]
		{
			"/usr/lib/xulrunner-geckofx-" + text2,
			"/usr/lib/xulrunner-" + text2,
			"/usr/lib/firefox"
		};
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (Directory.Exists(array[num]))
				{
					break;
				}
				num++;
				continue;
			}
			throw new ApplicationException("/usr/lib/firefox doesn't exist");
		}
		return array[num];
	}

	private static string GetXULRunnerLocationWindows(string hintPath)
	{
		string text = FindSpecialXulRunnerDirectory(DirectoryOfTheApplicationExecutable, hintPath);
		if (text != null)
		{
			return text;
		}
		string text2 = typeof(XULRunnerLocator).Assembly.GetName().Version!.Major.ToString();
		string[] source = new string[4]
		{
			"Mozilla Firefox " + text2 + ".0",
			"Mozilla Firefox " + text2 + ".0a",
			"Mozilla Firefox " + text2,
			"Mozilla Firefox"
		};
		string programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
		return source.Select((string t) => Path.Combine(programFiles, t)).FirstOrDefault(Directory.Exists);
	}

	public static string GetXULRunnerLocation(string hintPath = "PutXulRunnerFolderHere/xulrunner")
	{
		return Xpcom.IsLinux ? GetXULRunnerLocationLinux(hintPath) : GetXULRunnerLocationWindows(hintPath);
	}

	public static string GeckoHintPath(string version)
	{
		string codeBase = Assembly.GetExecutingAssembly().CodeBase;
		UriBuilder uriBuilder = new UriBuilder(codeBase);
		string path = Uri.UnescapeDataString(uriBuilder.Path);
		string text = (Xpcom.Is32Bit ? "32" : "64");
		string text2 = (Xpcom.IsLinux ? "Linux" : "Windows");
		string text3 = string.Join(".", text, text2, version);
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(path));
		do
		{
			directoryInfo = directoryInfo.Parent;
			string text4 = Path.Combine(directoryInfo.FullName, Path.Combine("packages", "Geckofx45." + text3, "content", "Firefox"));
			if (!Directory.Exists(text4))
			{
				text4 = Path.Combine(directoryInfo.FullName, Path.Combine("packages", "Geckofx45." + text3.TrimEnd(new char[1] { '0' }).TrimEnd(new char[1] { '.' }), "content", "Firefox"));
				if (Directory.Exists(text4))
				{
					return text4;
				}
				continue;
			}
			return text4;
		}
		while (directoryInfo.Parent != null);
		return "PutXulRunnerFolderHere/xulrunner";
	}
}
