using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public static class hE1biszR17
{
	private enum aktvJ2Vzo8
	{
		ProgramFilesX86,
		ProgramFiles,
		UserProfile,
		CommonApplicationData,
		ApplicationData,
		LocalApplicationData
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Lug2DYPHH4
	{
		public static readonly Lug2DYPHH4 oKCD737dgF = new Lug2DYPHH4();

		public static Func<string> _3Yc9sYFb36;

		public static Func<string> JfB8xggrDa;

		internal string Wjk5hIfFXU()
		{
			return _956yVTgyry();
		}

		internal string WCVmsqpVRb()
		{
			return Environment.GetEnvironmentVariable("HOME");
		}

		internal string adtowtIoJq()
		{
			return _4tymAtJgAp();
		}
	}

	private const string wuabUcnTgb = "dotnet";

	private const string DtegoBHkFl = "dotnet.exe";

	private const string qSoqBCn6U6 = "HOME";

	private const string fD3vKFVeY4 = "DOTNET_CLI_HOME";

	private const string _4bSzNjcabW = "USERPROFILE";

	private static readonly Lazy<string> _1vMSrE9KRo = new Lazy<string>(() => _4tymAtJgAp());

	public static string SX1Br5Fk1Y(YeXhnQPbgq mhBd2XQMSg)
	{
		switch (mhBd2XQMSg)
		{
		case YeXhnQPbgq.MachineWideSettingsBaseDirectory:
		{
			string text2;
			if (!l6BkPTcFbv.OoRgJZVw7H && l6BkPTcFbv.ooEPhgvzVK)
			{
				text2 = CRIcKdtTsp(aktvJ2Vzo8.ProgramFilesX86);
				if (string.IsNullOrEmpty(text2))
				{
					text2 = CRIcKdtTsp(aktvJ2Vzo8.ProgramFiles);
				}
			}
			else
			{
				text2 = CRIcKdtTsp(aktvJ2Vzo8.CommonApplicationData);
			}
			return Path.Combine(text2, "NuGet");
		}
		case YeXhnQPbgq.MachineWideConfigDirectory:
			return Path.Combine(SX1Br5Fk1Y(YeXhnQPbgq.MachineWideSettingsBaseDirectory), "Config");
		case YeXhnQPbgq.UserSettingsDirectory:
			return Path.Combine(CRIcKdtTsp(aktvJ2Vzo8.ApplicationData), "NuGet");
		case YeXhnQPbgq.NuGetHome:
			return Path.Combine(CRIcKdtTsp(aktvJ2Vzo8.UserProfile), ".nuget");
		case YeXhnQPbgq.HttpCacheDirectory:
			return Path.Combine(CRIcKdtTsp(aktvJ2Vzo8.LocalApplicationData), "NuGet", "v3-cache");
		case YeXhnQPbgq.NuGetPluginsCacheDirectory:
			return Path.Combine(CRIcKdtTsp(aktvJ2Vzo8.LocalApplicationData), "NuGet", "plugins-cache");
		case YeXhnQPbgq.DefaultMsBuildPath:
		{
			string text = CRIcKdtTsp(aktvJ2Vzo8.ProgramFilesX86);
			if (string.IsNullOrEmpty(text))
			{
				text = CRIcKdtTsp(aktvJ2Vzo8.ProgramFiles);
			}
			return Path.Combine(text, "MSBuild", "14.0", "Bin", "MSBuild.exe");
		}
		case YeXhnQPbgq.Temp:
			return Path.Combine(Path.GetTempPath(), "NuGetScratch");
		default:
			return null;
		}
	}

	private static string CRIcKdtTsp(aktvJ2Vzo8 _2wJ4WgoUE1)
	{
		Environment.SpecialFolder folder;
		switch (_2wJ4WgoUE1)
		{
		case aktvJ2Vzo8.ProgramFilesX86:
			folder = Environment.SpecialFolder.ProgramFilesX86;
			break;
		case aktvJ2Vzo8.ProgramFiles:
			folder = Environment.SpecialFolder.ProgramFiles;
			break;
		case aktvJ2Vzo8.UserProfile:
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			if (!string.IsNullOrEmpty(folderPath))
			{
				return folderPath;
			}
			return _1vMSrE9KRo.Value;
		}
		case aktvJ2Vzo8.CommonApplicationData:
			folder = Environment.SpecialFolder.CommonApplicationData;
			break;
		case aktvJ2Vzo8.ApplicationData:
			folder = Environment.SpecialFolder.ApplicationData;
			break;
		case aktvJ2Vzo8.LocalApplicationData:
			folder = Environment.SpecialFolder.LocalApplicationData;
			break;
		default:
			return null;
		}
		return Environment.GetFolderPath(folder);
	}

	private static string _4tymAtJgAp()
	{
		if (l6BkPTcFbv.ooEPhgvzVK)
		{
			return qcyjBF3j3r(() => _956yVTgyry(), "USERPROFILE");
		}
		return qcyjBF3j3r(() => Environment.GetEnvironmentVariable("HOME"), "HOME");
	}

	private static string _956yVTgyry()
	{
		string environmentVariable = Environment.GetEnvironmentVariable("USERPROFILE");
		if (!string.IsNullOrEmpty(environmentVariable))
		{
			return environmentVariable;
		}
		return Environment.GetEnvironmentVariable("HOMEDRIVE") + Environment.GetEnvironmentVariable("HOMEPATH");
	}

	private static string EEWWpyp741(Func<string> _2QKAdotSlA, string cgDl1LJOYM, string _33DAdLRjKC)
	{
		string text = _2QKAdotSlA();
		if (string.IsNullOrEmpty(text))
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.Xb2CqXy99h, cgDl1LJOYM, _33DAdLRjKC));
		}
		return text;
	}

	private static string qcyjBF3j3r(Func<string> jYNN4e1XUq, string _3O2hsLD650)
	{
		string text = jYNN4e1XUq();
		if (string.IsNullOrEmpty(text))
		{
			throw new InvalidOperationException(string.Format(CultureInfo.CurrentCulture, vK4KTOtZYy.IDxPMhbgqN, _3O2hsLD650));
		}
		return text;
	}

	public static string Gr0wP28oFK()
	{
		string? environmentVariable = Environment.GetEnvironmentVariable("PATH");
		bool isWindows = l6BkPTcFbv.ooEPhgvzVK;
		char c = (isWindows ? ';' : ':');
		string path = (isWindows ? "dotnet.exe" : "dotnet");
		string[] array = environmentVariable!.Split(new char[1] { c });
		for (int i = 0; i < array.Length; i++)
		{
			string text = Path.Combine(array[i], path);
			if (File.Exists(text))
			{
				return text;
			}
		}
		if (isWindows)
		{
			string text2 = CRIcKdtTsp(aktvJ2Vzo8.ProgramFiles);
			if (!string.IsNullOrEmpty(text2))
			{
				string text3 = Path.Combine(text2, "dotnet", "dotnet.exe");
				if (File.Exists(text3))
				{
					return text3;
				}
			}
			text2 = CRIcKdtTsp(aktvJ2Vzo8.ProgramFilesX86);
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
}
