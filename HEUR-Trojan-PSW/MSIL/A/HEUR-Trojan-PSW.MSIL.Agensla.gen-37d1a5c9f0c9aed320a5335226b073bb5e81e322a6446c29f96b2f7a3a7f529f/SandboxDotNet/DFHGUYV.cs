using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;
using SandboxDotNet.Helpers;
using SandboxDotNet.Perms;
using SandboxDotNet.Perms.Profiles;
using SandboxDotNet.UserInterface;

namespace SandboxDotNet;

internal class DFHGUYV
{
	private static bool _debug;

	private static void JHCDF(string[] args)
	{
		string text = "";
		string[] array = new string[1] { "" };
		Permissions permissions = new Permissions();
		Logging logging = new Logging();
		bool flag = false;
		bool flag2 = true;
		string text2 = "";
		try
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (SandboxUtils.IsFileValidExe(args[i]))
				{
					text = Path.GetFullPath(args[i]);
				}
				string text3 = args[i].TrimStart('-', '/').Trim().ToLower();
				switch (text3)
				{
				case "parameters":
					if (args.Length <= i + 1 || string.IsNullOrEmpty(args[i + 1]))
					{
						break;
					}
					goto case "p";
				case "p":
				case "params":
					array = SandboxUtils.ConvertStringArgsWithQuotes(args[i + 1]);
					i++;
					continue;
				}
				switch (text3)
				{
				default:
					if (!(text3 == "cli"))
					{
						switch (text3)
						{
						default:
							if (!(text3 == "verbose"))
							{
								if (text3 == "perms" || (text3 == "permissions" && !string.IsNullOrEmpty(args[i + 1])))
								{
									SandboxUtils.ExtractPermissions(ref permissions, args[i + 1].Split(new char[1] { ' ' }));
									i++;
									break;
								}
								switch (text3)
								{
								case "importpermissions":
									if (args.Length <= i + 1 || string.IsNullOrEmpty(args[i + 1]) || !File.Exists(args[i + 1]))
									{
										break;
									}
									goto case "import";
								case "import":
								case "importperms":
									try
									{
										permissions = new PermissionsXML(args[i + 1]).ImportPermissions();
									}
									catch (Exception)
									{
										logging.Log($"Could not import permissions from file: {args[i + 1]}", Logging.Severity.WARN);
									}
									goto end_IL_0126;
								}
								switch (text3)
								{
								case "exportpermissions":
									if (args.Length <= i + 1 || string.IsNullOrEmpty(args[i + 1]))
									{
										break;
									}
									goto case "export";
								case "export":
								case "exportperms":
									text2 = args[i + 1];
									goto end_IL_0126;
								}
								if (text3 == "nd" || text3 == "nodefaultperms" || text3 == "nodefaultpermissions")
								{
									permissions.DefaultPermissions = false;
								}
								else if (text3 == "noprofile" || text3 == "noprofiles" || text3 == "noprofileautoload")
								{
									flag2 = false;
								}
								break;
							}
							goto case "debug";
						case "debug":
						case "developer":
						case "dev":
							{
								_debug = true;
								break;
							}
							end_IL_0126:
							break;
						}
						break;
					}
					goto case "h";
				case "h":
				case "headless":
				case "noui":
					flag = true;
					break;
				}
			}
		}
		catch (Exception ex2)
		{
			string message = ((!_debug) ? $"An unexpected error occurred parsing the program arguments: {ex2.Message}" : $"An unexpected error occurred parsing the program arguments: {ex2}");
			logging.Log(message, Logging.Severity.ERROR);
		}
		logging.Log(string.Format("Program arguments loaded: ProgPath = '{0}', ProgPassThroughParams = '{1}', Headless = {2}, Debug = {3}, ProfileAutoLoad = {4}, Perms = '{5}', DefaultPerms = {6}", text, string.Join(" ", array), flag, _debug, flag2, permissions, permissions.DefaultPermissions), Logging.Severity.DEBUG);
		logging.Log("Developer Mode is enabled! Hello, World!", Logging.Severity.DEBUG);
		try
		{
			if (!string.IsNullOrWhiteSpace(text2))
			{
				permissions.GeneratePermissionSet(ignoreCurrentExePath: true);
				new PermissionsXML(text2).ExportPermissions(permissions);
				logging.Log($"Permissions successfully exported to: {text2}", Logging.Severity.DEBUG);
			}
		}
		catch (Exception)
		{
			logging.Log($"Could not export permissions to file: {text2}", Logging.Severity.WARN);
		}
		if (flag)
		{
			if (!string.IsNullOrWhiteSpace(text))
			{
				logging.UseMainConsole = true;
				logging.Log("Running in headless mode!", Logging.Severity.DEBUG);
				permissions.SetExecutablePath(text);
				Sandbox sandbox = new Sandbox(text, array, permissions.GeneratePermissionSet())
				{
					Logger = logging
				};
				try
				{
					int num = sandbox.ExecuteUntrustedExecutable();
					logging.Log($"Program exited with exit code {num}");
				}
				catch (SecurityException ex4)
				{
					new PermissionSet(PermissionState.Unrestricted).Assert();
					logging.Log(ex4.ToString(), Logging.Severity.ERROR);
					CodeAccessPermission.RevertAssert();
				}
				catch (Exception ex5)
				{
					if (_debug)
					{
						logging.Log(ex5.ToString(), Logging.Severity.ERROR);
					}
					else
					{
						logging.Log(ex5.Message, Logging.Severity.ERROR);
						logging.Log("Full error messages are only shown in debug mode.");
					}
				}
			}
			else
			{
				logging.Log("Please provide the path to the executable you want to run!");
			}
			logging.Log("You are using a debug build! Console has been held open for debugging purposes!", Logging.Severity.WARN);
			Console.ReadKey();
		}
		else
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new SandboxDotNet.UserInterface.SandboxDotNet(text, array, permissions, logging, flag2));
		}
	}

	public static bool IsDevModeEnabled()
	{
		return _debug;
	}

	public static string GetVersion()
	{
		string arg = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
		return string.Format("v{0}-{1}", arg, "DEV_20210310-1");
	}
}
