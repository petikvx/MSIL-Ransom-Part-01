using System;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ATI.ACE.CCCInstall.Tasks;
using Microsoft.Win32;
using MsGac.Fusion.Native;

namespace ATI.ACE.CCCInstall;

internal class CCCInstall
{
	private const int MAX_NUM_ARGS = 4;

	private const int MIN_NUM_ARGS = 1;

	private const string ACE_PACKAGE_REGKEY32 = "SOFTWARE\\ATI\\ACE";

	private const string ACE_PACKAGE_REGKEY64 = "SOFTWARE\\Wow6432Node\\ATI\\ACE";

	private const string INSTALL_BRANDING_REGKEY = "SOFTWARE\\ATI Technologies\\Install\\ccc-branding";

	private const string REGKEY_LOCATION = "Location";

	private const string REGKEY_INSTALLDIR = "InstallDir";

	private const string ARG_NGEN_UPDATE = "ngen:update";

	private const string ARG_NGEN_INSTALL = "ngen:i";

	private const string ARG_GAC_INSTALL = "gac:i";

	private const string ARG_NGEN_UNINSTALL = "ngen:u";

	private const string ARG_GAC_UNINSTALL = "gac:u";

	private const string ARG_ALL_INSTALL = "all:i";

	private const string ARG_ALL_UNINSTALL = "all:u";

	private const string ARG_CREATEREG = "createreg";

	private const string ARG_CREATEVERSION = "createversion";

	private const string ARG_FILE = "-f";

	private const string ARG_BYPACKAGE = "-p";

	private const string ARG_ALLPACKAGES = "-a";

	private const string ARG_FORCEALLPACKAGES = "-fa";

	private const string ARG_FORCEBRANDING = "-fb";

	private const string ARG_NOLOG = "/nolog";

	private const int ACTION = 0;

	private const int SPEC = 1;

	private const int OPTIONAL_ARG = 2;

	private const string ARG_TOKEN = "90ba9c70f846762e";

	private const string ARG_BRANDING = "Branding";

	private const string ARG_CCCBRANDING = "ccc-branding";

	private string[] args;

	private CCCInstallLog Log;

	private bool showLog = true;

	private static bool allPackages;

	private static bool gacInstall;

	private static bool gacUninstall;

	private static string AceRegKey
	{
		get
		{
			if (IntPtr.Size == 8)
			{
				return "SOFTWARE\\Wow6432Node\\ATI\\ACE";
			}
			return "SOFTWARE\\ATI\\ACE";
		}
	}

	private static void Main(string[] args)
	{
		new CCCInstall(args);
		try
		{
			if (allPackages)
			{
				if (gacInstall)
				{
					(Registry.LocalMachine.CreateSubKey(AceRegKey, RegistryKeyPermissionCheck.ReadWriteSubTree)?.CreateSubKey("Assemblies", RegistryKeyPermissionCheck.ReadWriteSubTree))?.CreateSubKey("Installed");
				}
				else if (gacUninstall)
				{
					(Registry.LocalMachine.OpenSubKey(AceRegKey)?.OpenSubKey("Assemblies", writable: true))?.DeleteSubKey("Installed", throwOnMissingSubKey: false);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public CCCInstall(string[] argsParam)
	{
		if (argsParam.Length < 1)
		{
			ShowInvalidFormatError();
		}
		if (argsParam[^1].Equals("/nolog", StringComparison.InvariantCultureIgnoreCase))
		{
			showLog = false;
			args = new string[argsParam.Length - 1];
			for (int i = 0; i < argsParam.Length - 1; i++)
			{
				args[i] = argsParam[i];
			}
		}
		else
		{
			args = argsParam;
		}
		if (args.Length < 1 || args.Length > 4)
		{
			ShowInvalidFormatError();
		}
		Log = new CCCInstallLog(showLog);
		try
		{
			Log.LogMessage("ARGS passed: " + string.Join(" ", argsParam));
			if (args[0].Equals("createreg", StringComparison.InvariantCultureIgnoreCase))
			{
				ParseSpecArg(new RegistryTasks(Log, Action.CreateReg));
			}
			else if (args[0].Equals("createversion", StringComparison.InvariantCultureIgnoreCase) && args[1].Equals("-f", StringComparison.InvariantCultureIgnoreCase))
			{
				ITask task = new VersionTasks(Log, Action.CreateVersion);
				task.Run(args[2]);
			}
			else if (args[0].Equals("ngen:update", StringComparison.InvariantCultureIgnoreCase))
			{
				ITask task2 = new NgenTasks(Log, Action.UpdateNgen);
				task2.Run("");
			}
			else if (args[0].Equals("gac:i", StringComparison.InvariantCultureIgnoreCase))
			{
				gacInstall = true;
				ParseSpecArg(new GACTasks(Log, Action.InstallGAC));
			}
			else if (args[0].Equals("gac:u", StringComparison.InvariantCultureIgnoreCase))
			{
				gacUninstall = true;
				ParseSpecArg(new GACTasks(Log, Action.UninstallGAC));
			}
			else if (args[0].Equals("ngen:i", StringComparison.InvariantCultureIgnoreCase))
			{
				ParseSpecArg(new NgenTasks(Log, Action.InstallNGen));
			}
			else if (args[0].Equals("ngen:u", StringComparison.InvariantCultureIgnoreCase))
			{
				ParseSpecArg(new NgenTasks(Log, Action.UninstallNGen));
			}
			else if (args[0].Equals("all:i", StringComparison.InvariantCultureIgnoreCase))
			{
				gacInstall = true;
				ParseSpecArg(new GACTasks(Log, Action.InstallGAC));
				ParseSpecArg(new NgenTasks(Log, Action.InstallNGen));
				ParseSpecArg(new RegistryTasks(Log, Action.CreateReg));
			}
			else if (args[0].Equals("all:u", StringComparison.InvariantCultureIgnoreCase))
			{
				gacUninstall = true;
				ParseSpecArg(new NgenTasks(Log, Action.UninstallNGen));
				ParseSpecArg(new GACTasks(Log, Action.UninstallGAC));
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		finally
		{
			if (showLog && Log != null)
			{
				Log.LogFinished();
			}
		}
	}

	private void RunOnPackage(string packageName, ITask task)
	{
		string text = AceRegKey + "\\Packages\\" + packageName;
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey(text, writable: false);
			if (registryKey == null)
			{
				Log.LogMessage("Error: The registry key " + text + " does not exist.");
			}
			else if (!(registryKey.GetValue("Location") is string text2))
			{
				Log.LogMessage(string.Format("Error: The registry key {0}\\{1} does not exist.", text, "Location"));
			}
			else
			{
				task.Run(text2 + "\\Install.xml");
			}
		}
		catch (Exception e)
		{
			Log.LogException(e);
		}
		finally
		{
			registryKey?.Close();
		}
	}

	private StringCollection GetLanguages(RegistryKey ACEKey)
	{
		StringCollection stringCollection = new StringCollection();
		if (ACEKey == null)
		{
			Log.LogMessage(string.Concat("Error: The registry key ", ACEKey, " does not exist."));
			return stringCollection;
		}
		try
		{
			RegistryKey registryKey = ACEKey.OpenSubKey("Languages", writable: false);
			if (registryKey == null)
			{
				Log.LogMessage(string.Concat("Error: The registry key ", ACEKey, "\\Languages does not exist."));
				return stringCollection;
			}
			string[] subKeyNames = registryKey.GetSubKeyNames();
			if (subKeyNames.Length > 0)
			{
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					if (!subKeyNames[i].Equals("en-US"))
					{
						stringCollection.Add(subKeyNames[i]);
					}
				}
				return stringCollection;
			}
			return stringCollection;
		}
		catch (Exception e)
		{
			Log.LogException(e);
			return stringCollection;
		}
	}

	private void RunOnAllPackages(ITask task)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey(AceRegKey, writable: false);
			if (registryKey == null)
			{
				Log.LogMessage("Error: The registry key " + AceRegKey + " does not exist.");
				return;
			}
			StringCollection languages = GetLanguages(registryKey);
			RegistryKey registryKey2 = registryKey.OpenSubKey("Packages", writable: false);
			if (registryKey2 == null)
			{
				Log.LogMessage("Error: The registry key " + AceRegKey + "\\Packages does not exist.");
				return;
			}
			string[] subKeyNames = registryKey2.GetSubKeyNames();
			foreach (string name in subKeyNames)
			{
				RegistryKey registryKey3 = null;
				try
				{
					registryKey3 = registryKey2.OpenSubKey(name);
					if (registryKey3 == null)
					{
						continue;
					}
					string text = registryKey3.GetValue("Location") as string;
					string filePath = text + "\\Install.xml";
					task.Run(filePath);
					StringEnumerator enumerator = languages.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							string filePath2 = $"{text}\\{current}\\Install.xml";
							task.Run(filePath2);
						}
					}
					finally
					{
						if (enumerator is IDisposable disposable)
						{
							disposable.Dispose();
						}
					}
				}
				catch (Exception e)
				{
					Log.LogException(e);
				}
			}
		}
		catch (Exception e2)
		{
			Log.LogException(e2);
		}
		finally
		{
			registryKey?.Close();
		}
	}

	private void RunUnGacAll(ITask task)
	{
		try
		{
			Log.LogMessage("Option selected: Force remove all ATI file in the GAC");
			FusionApi.CreateAssemblyCache(out var ppAsmCache, 0u);
			int num = 0;
			string text = "";
			FusionApi.CreateAssemblyEnum(out var ppEnum, IntPtr.Zero, null, ASM_CACHE_FLAGS.ASM_CACHE_GAC, IntPtr.Zero);
			RegistryKey registryKey = null;
			RegistryKey registryKey2 = null;
			registryKey = Registry.LocalMachine.OpenSubKey(AceRegKey, writable: false);
			if (registryKey != null)
			{
				registryKey2 = registryKey.OpenSubKey("Packages", writable: false);
			}
			else
			{
				Log.LogMessage("Error: The registry key " + AceRegKey + " does not exist.");
			}
			if (registryKey2 == null)
			{
				Log.LogMessage("Error: The registry key " + AceRegKey + "\\Packages does not exist.");
			}
			else
			{
				RegistryKey registryKey3 = null;
				registryKey3 = registryKey2.OpenSubKey("Branding");
				if (registryKey3 != null)
				{
					text = registryKey3.GetValue("Location") as string;
				}
			}
			IAssemblyName ppName;
			while (ppEnum.GetNextAssembly(IntPtr.Zero, out ppName, 0u) == 0)
			{
				uint lpcwBuffer = 0u;
				ppName.GetName(ref lpcwBuffer, null);
				StringBuilder stringBuilder = new StringBuilder((int)lpcwBuffer);
				ppName.GetName(ref lpcwBuffer, stringBuilder);
				ASM_NAME[] array = (ASM_NAME[])Enum.GetValues(typeof(ASM_NAME));
				for (int i = 0; i < array.Length; i++)
				{
					uint pcbProperty = 0u;
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						ppName.GetProperty(array[i], IntPtr.Zero, ref pcbProperty);
						intPtr = Marshal.AllocHGlobal((int)pcbProperty);
						ppName.GetProperty(array[i], intPtr, ref pcbProperty);
						string text2 = null;
						if (array[i] != ASM_NAME.PUBLIC_KEY_TOKEN)
						{
							continue;
						}
						byte[] array2 = new byte[pcbProperty];
						Marshal.Copy(intPtr, array2, 0, (int)pcbProperty);
						StringBuilder stringBuilder2 = new StringBuilder((int)(2 * pcbProperty));
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.AppendFormat("{0:x2}", array2[j]);
						}
						text2 = stringBuilder2.ToString();
						if (!(text2 == "90ba9c70f846762e"))
						{
							continue;
						}
						text2 = stringBuilder.ToString();
						int num2 = args.Length;
						if (num2 > 2 && args[2] == "-b" && File.Exists(text + "\\" + text2 + ".dll"))
						{
							Log.LogMessage("Skipping Branding file: - " + text + "\\" + text2 + ".dll");
						}
						else
						{
							ppAsmCache.UninstallAssembly(0u, text2, null, out var pulDisposition);
							if (pulDisposition != 1)
							{
								Log.LogMessage("Uninstall \"" + text2 + "\" failed, ERROR!!!");
							}
							else
							{
								Log.LogMessage("Uninstall \"" + text2 + "\" success");
							}
							num++;
						}
					}
					catch
					{
					}
					finally
					{
						if (intPtr != IntPtr.Zero)
						{
							Marshal.FreeHGlobal(intPtr);
						}
					}
				}
			}
			Log.LogMessage("Total assembly removed: " + num);
		}
		catch (Exception e)
		{
			Log.LogException(e);
		}
	}

	private void RunUnGacBranding(ITask task)
	{
		try
		{
			Log.LogMessage("Option selected: Force remove all ATI branding file in the GAC");
			FusionApi.CreateAssemblyCache(out var ppAsmCache, 0u);
			int num = 0;
			string text = "";
			FusionApi.CreateAssemblyEnum(out var ppEnum, IntPtr.Zero, null, ASM_CACHE_FLAGS.ASM_CACHE_GAC, IntPtr.Zero);
			RegistryKey registryKey = null;
			string text2 = "SOFTWARE\\ATI Technologies\\Install\\ccc-branding";
			registryKey = Registry.LocalMachine.OpenSubKey(text2, writable: false);
			if (registryKey == null)
			{
				Log.LogMessage("Error: The registry key " + text2 + "\\Packages does not exist.");
			}
			else
			{
				text = registryKey.GetValue("InstallDir") as string;
			}
			if (text.Length < 1)
			{
				Log.LogMessage("ERROR, unable to locate Branding folder!!!");
				return;
			}
			IAssemblyName ppName;
			while (ppEnum.GetNextAssembly(IntPtr.Zero, out ppName, 0u) == 0)
			{
				uint lpcwBuffer = 0u;
				ppName.GetName(ref lpcwBuffer, null);
				StringBuilder stringBuilder = new StringBuilder((int)lpcwBuffer);
				ppName.GetName(ref lpcwBuffer, stringBuilder);
				ASM_NAME[] array = (ASM_NAME[])Enum.GetValues(typeof(ASM_NAME));
				for (int i = 0; i < array.Length; i++)
				{
					uint pcbProperty = 0u;
					IntPtr intPtr = IntPtr.Zero;
					try
					{
						ppName.GetProperty(array[i], IntPtr.Zero, ref pcbProperty);
						intPtr = Marshal.AllocHGlobal((int)pcbProperty);
						ppName.GetProperty(array[i], intPtr, ref pcbProperty);
						string text3 = null;
						if (array[i] != ASM_NAME.PUBLIC_KEY_TOKEN)
						{
							continue;
						}
						byte[] array2 = new byte[pcbProperty];
						Marshal.Copy(intPtr, array2, 0, (int)pcbProperty);
						StringBuilder stringBuilder2 = new StringBuilder((int)(2 * pcbProperty));
						for (int j = 0; j < array2.Length; j++)
						{
							stringBuilder2.AppendFormat("{0:x2}", array2[j]);
						}
						text3 = stringBuilder2.ToString();
						if (!(text3 == "90ba9c70f846762e"))
						{
							continue;
						}
						text3 = stringBuilder.ToString();
						if (File.Exists(text + "\\" + text3 + ".dll"))
						{
							ppAsmCache.UninstallAssembly(0u, text3, null, out var pulDisposition);
							if (pulDisposition != 1)
							{
								Log.LogMessage("Uninstall \"" + text3 + "\" failed, ERROR!!!");
								continue;
							}
							Log.LogMessage("Uninstall \"" + text3 + "\" success");
							num++;
						}
						else
						{
							Log.LogMessage("Skipping file, not branding: - " + text + "\\" + text3 + ".dll");
						}
					}
					catch
					{
					}
					finally
					{
						if (intPtr != IntPtr.Zero)
						{
							Marshal.FreeHGlobal(intPtr);
						}
					}
				}
			}
			Log.LogMessage("Total assembly removed: " + num);
		}
		catch (Exception e)
		{
			Log.LogException(e);
		}
	}

	private void RecurseOnRegKey(RegistryKey key, ITask task)
	{
		try
		{
			if (key == null)
			{
				Log.LogMessage("Error: Key is null");
				return;
			}
			string text = key.GetValue("Location", string.Empty) as string;
			if (string.IsNullOrEmpty(text))
			{
				string[] subKeyNames = key.GetSubKeyNames();
				for (int i = 0; i < subKeyNames.Length; i++)
				{
					RecurseOnRegKey(key.OpenSubKey(subKeyNames[i]), task);
				}
			}
			else
			{
				text += "\\Install.xml";
				task.Run(text);
			}
		}
		catch (Exception e)
		{
			Log.LogException(e);
		}
		finally
		{
			key?.Close();
		}
	}

	private void ParseSpecArg(ITask task)
	{
		if (args[1].Equals("-f", StringComparison.InvariantCultureIgnoreCase))
		{
			if (args.Length <= 4)
			{
				task.Run(args[2]);
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		else if (args[1].Equals("-p", StringComparison.InvariantCultureIgnoreCase))
		{
			if (args.Length <= 4)
			{
				RunOnPackage(args[2], task);
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		else if (args[1].Equals("-a", StringComparison.InvariantCultureIgnoreCase))
		{
			allPackages = true;
			if (args.Length >= 1)
			{
				RunOnAllPackages(task);
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		else if (args[1].Equals("-fa", StringComparison.InvariantCultureIgnoreCase))
		{
			gacUninstall = true;
			allPackages = true;
			if (args.Length >= 1)
			{
				RunUnGacAll(task);
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		else if (args[1].Equals("-fb", StringComparison.InvariantCultureIgnoreCase))
		{
			if (args.Length >= 1)
			{
				RunUnGacBranding(task);
			}
			else
			{
				ShowInvalidFormatError();
			}
		}
		else
		{
			ShowInvalidFormatError();
		}
	}

	private void ShowInvalidFormatError()
	{
		Console.WriteLine("ATI (R) Catalyst Control Center Utility");
		Console.WriteLine("Copyright (C) ATI Technologies 2006.");
		Console.WriteLine("");
		Console.WriteLine("Usage: CCCInstall.exe <action> <inputMode> [filePath|packageName] [noLog]");
		Console.WriteLine("");
		Console.WriteLine("Actions:");
		Console.WriteLine("  ngen:i");
		Console.WriteLine("    Adds assemblies specified in the xml file into Native Assembly Cache");
		Console.WriteLine("  ngen:u");
		Console.WriteLine("    Removes assemblies specified in the xml file from Native Assembly Cache");
		Console.WriteLine("  ngen:update");
		Console.WriteLine("    Updates the ngened images and recompiles invalidated ones.");
		Console.WriteLine("  gac:i");
		Console.WriteLine("    Adds assemblies specified in the xml file into GAC");
		Console.WriteLine("  gac:u");
		Console.WriteLine("    Removes assemblies specified in the xml file from GAC");
		Console.WriteLine("  createreg");
		Console.WriteLine("    Creates a registry containing the full name of the assemblies");
		Console.WriteLine("  createversion");
		Console.WriteLine("    Creates a dat file with the version number to be placed in the registry (-f only)");
		Console.WriteLine("    Ex: Core-Static\\CCCInstall.exe createversion -f Core-Static\\ACE.dat");
		Console.WriteLine("");
		Console.WriteLine("InputModes:");
		Console.WriteLine("  -f <filePath>");
		Console.WriteLine("    Gets list of assemblies from Install.xml at the specified path");
		Console.WriteLine("  -p <packageName>");
		Console.WriteLine("    Uses the Install.xml for the specified package referenced in the registry");
		Console.WriteLine("  -a");
		Console.WriteLine("    Reads the registry for all packages with a valid Install.xml, but skip branding");
		Console.WriteLine("  -fa");
		Console.WriteLine("    Option to remove all ATI file from the GAC without looking at XML files.");
		Console.WriteLine("  -fa -b");
		Console.WriteLine("    Option to remove all ATI file from the GAC, but skip branding files.");
		Console.WriteLine("  -fb");
		Console.WriteLine("    Option to remove all ATI branding file from the GAC without looking at XML files.");
		Console.WriteLine("");
		Console.WriteLine("NoLog:");
		Console.WriteLine("  /nolog");
		Console.WriteLine("    Suppresses log file generation");
		Console.WriteLine("");
		Console.WriteLine("");
		if (showLog && Log != null)
		{
			Log.LogMessage("Invalid syntax.");
			Log.LogFinished();
		}
		Environment.Exit(1);
	}
}
