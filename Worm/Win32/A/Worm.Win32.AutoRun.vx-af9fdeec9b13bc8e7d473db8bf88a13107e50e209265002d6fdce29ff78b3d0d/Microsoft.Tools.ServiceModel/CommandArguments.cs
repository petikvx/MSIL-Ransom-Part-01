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
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Invalid comparison between I4 and Unknown
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Invalid comparison between I4 and Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Invalid comparison between I4 and Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
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
		int num = 0;
		while (true)
		{
			if (num < args.Length)
			{
				string text = args[num];
				if (text.StartsWith("/", StringComparison.Ordinal) || text.StartsWith("-", StringComparison.Ordinal))
				{
					string text2 = text.Substring(1);
					string text3 = null;
					int num2 = text2.IndexOf(':');
					if (-1 != num2)
					{
						text3 = text2.Substring(num2 + 1);
						text2 = text2.Substring(0, num2);
					}
					switch (text2.ToLower(CultureInfo.CurrentCulture))
					{
					case "i":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)1;
							updateScriptMaps = false;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "ir":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)1;
							updateScriptMaps = false;
							applyToConfig = true;
							applyToScriptMaps = false;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "iru":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)1;
							updateScriptMaps = false;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "u":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)2;
							updateScriptMaps = true;
							recursive = true;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "ua":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)2;
							updateScriptMaps = false;
							recursive = true;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "r":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)3;
							updateScriptMaps = true;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "s":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)1;
							flag = true;
							recursive = true;
							scriptMapPath = text3;
							applyToConfig = false;
							applyToScriptMaps = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "sn":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)1;
							flag = true;
							recursive = false;
							scriptMapPath = text3;
							applyToConfig = false;
							applyToScriptMaps = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "k":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)2;
							flag2 = true;
							recursive = true;
							scriptMapPath = text3;
							applyToConfig = false;
							applyToScriptMaps = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "kn":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)2;
							flag2 = true;
							recursive = false;
							scriptMapPath = text3;
							applyToConfig = false;
							applyToScriptMaps = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "lv":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)4;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							recursive = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "lk":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)5;
							applyToConfig = false;
							applyToScriptMaps = true;
							recursive = true;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "vi":
						if ((int)installAction == 0)
						{
							installAction = (InstallAction)6;
							applyToConfig = true;
							applyToScriptMaps = !IisHelper.get_ShouldInstallWas();
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOptionError"));
					case "x":
						runInstallScript = true;
						break;
					case "q":
						if (1 == (int)outputLevel || (int)outputLevel == 0)
						{
							outputLevel = (OutputLevel)0;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOutputError"));
					case "v":
						if (1 == (int)outputLevel || 2 == (int)outputLevel)
						{
							outputLevel = (OutputLevel)2;
							break;
						}
						throw new ApplicationException(SR.GetString("ServiceModelRegExclusiveOutputError"));
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
					num++;
					continue;
				}
				throw new ApplicationException(SR.GetString("ServiceModelRegUnknownOptionError", text));
			}
			if ((int)installAction == 0)
			{
				throw new ApplicationException(SR.GetString("ServiceModelRegNoOptionsError"));
			}
			if ((flag || flag2) && (IisHelper.get_ShouldInstallIis() || IisHelper.get_ShouldInstallWas()) && scriptMapPath == null)
			{
				throw new NullReferenceException(SR.GetString("ServiceModelRegNullScriptMapPath"));
			}
			break;
		}
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
