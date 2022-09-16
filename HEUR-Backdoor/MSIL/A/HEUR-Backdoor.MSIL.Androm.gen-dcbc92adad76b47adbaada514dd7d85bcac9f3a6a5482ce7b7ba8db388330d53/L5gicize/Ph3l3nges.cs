using System;
using System.Globalization;
using System.IO;
using Chol2tes;
using ns10;
using ns12;

namespace L5gicize;

public static class Ph3l3nges
{
	private enum We1gelike
	{
		ProgramFilesX86,
		ProgramFiles,
		UserProfile,
		CommonApplicationData,
		ApplicationData,
		LocalApplicationData
	}

	private const string Ta6ards = "dotnet";

	private const string Ri22e = "dotnet.exe";

	private const string Coniin5s = "HOME";

	private const string Re4rr4nging = "DOTNET_CLI_HOME";

	private const string string_0 = "USERPROFILE";

	private static readonly Lazy<string> R1quir1 = new Lazy<string>(() => Transfinit7());

	public static string Accred6ted(GEnum0 Bus2d)
	{
		switch (Bus2d)
		{
		default:
			return null;
		case GEnum0.MachineWideSettingsBaseDirectory:
		{
			string text2;
			if (!Unst0ck.Tende1loins && Unst0ck.Oli1odendrocyte)
			{
				text2 = To2bed(We1gelike.ProgramFilesX86);
				if (string.IsNullOrEmpty(text2))
				{
					text2 = To2bed(We1gelike.ProgramFiles);
				}
			}
			else
			{
				text2 = To2bed(We1gelike.CommonApplicationData);
			}
			return Path.Combine(text2, "NuGet");
		}
		case GEnum0.MachineWideConfigDirectory:
			return Path.Combine(Accred6ted(GEnum0.MachineWideSettingsBaseDirectory), "Config");
		case GEnum0.UserSettingsDirectory:
			return Path.Combine(To2bed(We1gelike.ApplicationData), "NuGet");
		case GEnum0.HttpCacheDirectory:
			return Path.Combine(To2bed(We1gelike.LocalApplicationData), "NuGet", "v3-cache");
		case GEnum0.NuGetHome:
			return Path.Combine(To2bed(We1gelike.UserProfile), ".nuget");
		case GEnum0.DefaultMsBuildPath:
		{
			string text = To2bed(We1gelike.ProgramFilesX86);
			if (string.IsNullOrEmpty(text))
			{
				text = To2bed(We1gelike.ProgramFiles);
			}
			return Path.Combine(text, "MSBuild", "14.0", "Bin", "MSBuild.exe");
		}
		case GEnum0.Temp:
			return Path.Combine(Path.GetTempPath(), "NuGetScratch");
		case GEnum0.NuGetPluginsCacheDirectory:
			return Path.Combine(To2bed(We1gelike.LocalApplicationData), "NuGet", "plugins-cache");
		}
	}

	private static string To2bed(We1gelike Newco7ers)
	{
		Environment.SpecialFolder folder;
		switch (Newco7ers)
		{
		default:
			return null;
		case We1gelike.ProgramFilesX86:
			folder = Environment.SpecialFolder.ProgramFilesX86;
			break;
		case We1gelike.ProgramFiles:
			folder = Environment.SpecialFolder.ProgramFiles;
			break;
		case We1gelike.UserProfile:
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			if (!string.IsNullOrEmpty(folderPath))
			{
				return folderPath;
			}
			return R1quir1.Value;
		}
		case We1gelike.CommonApplicationData:
			folder = Environment.SpecialFolder.CommonApplicationData;
			break;
		case We1gelike.ApplicationData:
			folder = Environment.SpecialFolder.ApplicationData;
			break;
		case We1gelike.LocalApplicationData:
			folder = Environment.SpecialFolder.LocalApplicationData;
			break;
		}
		return Environment.GetFolderPath(folder);
	}

	private static string Transfinit7()
	{
		if (Unst0ck.Oli1odendrocyte)
		{
			return G4lpers(() => Crudd3er(), "USERPROFILE");
		}
		return G4lpers(() => Environment.GetEnvironmentVariable("HOME"), "HOME");
	}

	private static string Crudd3er()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		if (!string.IsNullOrEmpty(environmentVariable))
		{
			return environmentVariable;
		}
		return Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH");
	}

	private static string Int6nd6d(Func<string> Vi88ane88es, string U7io7ises, string Refi2es)
	{
		string text = Vi88ane88es();
		if (string.IsNullOrEmpty(text))
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Strings.MissingRequiredEnvVarsDotnet, U7io7ises, Refi2es));
		}
		return text;
	}

	private static string G4lpers(Func<string> Melodra0atics, string Tire0omely)
	{
		string text = Melodra0atics();
		if (string.IsNullOrEmpty(text))
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, Strings.MissingRequiredEnvVar, Tire0omely));
		}
		return text;
	}

	public static string Lath8s()
	{
		string? environmentVariable = Environment.GetEnvironmentVariable("PATH");
		bool oli1odendrocyte;
		char c = ((oli1odendrocyte = Unst0ck.Oli1odendrocyte) ? ';' : ':');
		string path = (oli1odendrocyte ? "dotnet.exe" : "dotnet");
		string[] array = environmentVariable!.Split(new char[1] { c });
		int num = 0;
		string text;
		while (true)
		{
			if (num < array.Length)
			{
				text = Path.Combine(array[num], path);
				if (File.Exists(text))
				{
					break;
				}
				num++;
				continue;
			}
			if (oli1odendrocyte)
			{
				string text2 = To2bed(We1gelike.ProgramFiles);
				if (!string.IsNullOrEmpty(text2))
				{
					string text3 = Path.Combine(text2, "dotnet", "dotnet.exe");
					if (File.Exists(text3))
					{
						return text3;
					}
				}
				text2 = To2bed(We1gelike.ProgramFilesX86);
				if (!string.IsNullOrEmpty(text2))
				{
					string text4 = Path.Combine(text2, "dotnet", "dotnet.exe");
					if (File.Exists(text4))
					{
						return text4;
					}
				}
			}
			else
			{
				string text5 = "/usr/local/bin";
				if (!string.IsNullOrEmpty(text5))
				{
					string text6 = Path.Combine(text5, "dotnet");
					if (File.Exists(text6))
					{
						return text6;
					}
				}
			}
			return "dotnet";
		}
		return text;
	}
}
