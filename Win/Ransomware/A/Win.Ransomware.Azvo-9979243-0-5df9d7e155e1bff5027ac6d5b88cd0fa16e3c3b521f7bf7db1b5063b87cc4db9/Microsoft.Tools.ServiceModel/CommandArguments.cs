using System;
using System.Globalization;
using System.ServiceModel.Install;

namespace Microsoft.Tools.ServiceModel;

internal class CommandArguments
{
	private bool applyToConfig;

	private bool applyToScriptMaps;

	private bool displayHelp;

	private bool displayLogo;

	private InstallAction installAction;

	private OutputLevel outputLevel;

	private bool recursive;

	private bool requireConfirmation;

	private bool runInstallScript;

	private string scriptMapPath;

	private bool updateScriptMaps;

	internal bool ApplyToConfig => applyToConfig;

	internal bool ApplyToScriptMaps => applyToScriptMaps;

	internal bool DisplayHelp => displayHelp;

	internal bool DisplayLogo => displayLogo;

	internal InstallAction InstallAction => installAction;

	internal OutputLevel OutputLevel => outputLevel;

	internal bool Recursive => recursive;

	internal bool RequireConfirmation => requireConfirmation;

	internal bool RunInstallScript => runInstallScript;

	internal string ScriptMapPath => scriptMapPath;

	internal bool UpdateScriptMaps => updateScriptMaps;

	internal CommandArguments(string[] args)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Invalid comparison between I4 and Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f3: Invalid comparison between I4 and Unknown
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Invalid comparison between I4 and Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		bool flag2 = false;
		updateScriptMaps = false;
		recursive = false;
		scriptMapPath = null;
		displayHelp = false;
		displayLogo = true;
		requireConfirmation = true;
		outputLevel = (OutputLevel)1;
		installAction = (InstallAction)0;
		applyToConfig = false;
		applyToScriptMaps = false;
		runInstallScript = false;
		if (args.Length == 0)
		{
			displayHelp = true;
			return;
		}
		foreach (string text in args)
		{
			if (text.StartsWith("/", StringComparison.Ordinal) || text.StartsWith("-", StringComparison.Ordinal))
			{
				string text2 = text.Substring(1);
				string text3 = null;
				int num = text2.IndexOf(':');
				if (-1 != num)
				{
					text3 = text2.Substring(num + 1);
					text2 = text2.Substring(0, num);
				}
				switch (text2.ToLower(CultureInfo.CurrentCulture))
				{
				case "i":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)1;
					updateScriptMaps = false;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "ir":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)1;
					updateScriptMaps = false;
					applyToConfig = true;
					applyToScriptMaps = false;
					break;
				case "iru":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)1;
					updateScriptMaps = false;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "u":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)2;
					updateScriptMaps = true;
					recursive = true;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "ua":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)2;
					updateScriptMaps = false;
					recursive = true;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "r":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)3;
					updateScriptMaps = true;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "s":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)1;
					flag = true;
					recursive = true;
					scriptMapPath = text3;
					applyToConfig = false;
					applyToScriptMaps = true;
					break;
				case "sn":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)1;
					flag = true;
					recursive = false;
					scriptMapPath = text3;
					applyToConfig = false;
					applyToScriptMaps = true;
					break;
				case "k":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)2;
					flag2 = true;
					recursive = true;
					scriptMapPath = text3;
					applyToConfig = false;
					applyToScriptMaps = true;
					break;
				case "kn":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)2;
					flag2 = true;
					recursive = false;
					scriptMapPath = text3;
					applyToConfig = false;
					applyToScriptMaps = true;
					break;
				case "lv":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)4;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					recursive = true;
					break;
				case "lk":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)5;
					applyToConfig = false;
					applyToScriptMaps = true;
					recursive = true;
					break;
				case "vi":
					if ((int)installAction != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					}
					installAction = (InstallAction)6;
					applyToConfig = true;
					applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
					break;
				case "x":
					runInstallScript = true;
					break;
				case "q":
					if (1 != (int)outputLevel && (int)outputLevel != 0)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOutputError"));
					}
					outputLevel = (OutputLevel)0;
					break;
				case "v":
					if (1 != (int)outputLevel && 2 != (int)outputLevel)
					{
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOutputError"));
					}
					outputLevel = (OutputLevel)2;
					break;
				case "y":
					requireConfirmation = false;
					break;
				case "nologo":
					displayLogo = false;
					break;
				case "?":
				case "h":
				case "help":
					displayHelp = true;
					return;
				default:
					throw new ApplicationException(SR.GetString("ServiceModelRegUnknownOptionError", text2));
				}
				continue;
			}
			throw new ApplicationException(SR.GetString("ServiceModelRegUnknownOptionError", text));
		}
		if ((int)installAction == 0)
		{
			throw new ApplicationException(SR.GetString("ServiceModelRegNoOptionsError"));
		}
		if ((!flag && !flag2) || (!IisHelper.get_ShouldInstallIis() && !IisHelper.get_ShouldInstallWas()) || scriptMapPath != null)
		{
			return;
		}
		throw new NullReferenceException(SR.GetString("ServiceModelRegNullScriptMapPath"));
	}

	internal static void DisplayUsage()
	{
		Console.WriteLine(SR.GetString("HelpDescription"));
		Console.WriteLine(SR.GetString("HelpUsage", "ServiceModelReg.exe"));
		Console.WriteLine(SR.GetString("HelpInstall", "-i"));
		Console.WriteLine(SR.GetString("HelpInstallRegister", "-ir"));
		Console.WriteLine(SR.GetString("HelpInstallNoUpdate", "-iru"));
		Console.WriteLine(SR.GetString("HelpUninstall", "-u"));
		Console.WriteLine(SR.GetString("HelpUninstallAll", "-ua"));
		Console.WriteLine(SR.GetString("HelpReinstall", "-r"));
		Console.WriteLine(SR.GetString("HelpInstallRunWCFInstaller", "-x"));
		Console.WriteLine(SR.GetString("HelpInstallScriptMapsRecursively", "-s"));
		Console.WriteLine(SR.GetString("HelpInstallScriptMapsNonRecursively", "-sn"));
		Console.WriteLine(SR.GetString("HelpRemoveScriptMapsRecursively", "-k"));
		Console.WriteLine(SR.GetString("HelpRemoveScriptMapsNonRecursively", "-kn"));
		Console.WriteLine(SR.GetString("HelpListVersions", "-lv"));
		Console.WriteLine(SR.GetString("HelpListScriptMaps", "-lk"));
		Console.WriteLine(SR.GetString("HelpVerify", "-vi"));
		Console.WriteLine(SR.GetString("HelpConfirmation", "-y"));
		Console.WriteLine(SR.GetString("HelpQuiet", "-q"));
		Console.WriteLine(SR.GetString("HelpVerbose", "-v"));
		Console.WriteLine(SR.GetString("HelpNoLogo", "-nologo"));
		Console.WriteLine(SR.GetString("HelpDisplayHelp", "-?"));
	}
}
