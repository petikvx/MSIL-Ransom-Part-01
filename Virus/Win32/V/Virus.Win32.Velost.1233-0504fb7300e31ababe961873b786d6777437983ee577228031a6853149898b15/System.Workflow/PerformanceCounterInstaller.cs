using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace System.Workflow;

internal class PerformanceCounterInstaller
{
	private const string REGISTRY_PERFLIB_ROOT = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Perflib";

	private const string REGISTRY_SERVICES_ROOT = "SYSTEM\\CurrentControlSet\\Services";

	private string[] legacyPerfCounterDriverNames;

	private string[] perfCounterDriverNames;

	private string[] perfCounterIniFiles;

	private string[] perfCounterRegFiles;

	public static void Main(string[] args)
	{
		PerformanceCounterInstaller performanceCounterInstaller = new PerformanceCounterInstaller();
		if (args.Length != 0)
		{
			switch (args[0])
			{
			case "uninstall":
				performanceCounterInstaller.Uninstall();
				break;
			case "install":
				performanceCounterInstaller.Install();
				break;
			}
		}
	}

	internal PerformanceCounterInstaller()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
		directoryName += "\\";
		perfCounterIniFiles = new string[1] { Path.Combine(directoryName, "PerfCounters.ini") };
		perfCounterRegFiles = new string[1] { Path.Combine(directoryName, "PerfCounters.reg") };
		legacyPerfCounterDriverNames = new string[0];
		perfCounterDriverNames = new string[perfCounterIniFiles.Length];
		for (int i = 0; i < perfCounterIniFiles.Length; i++)
		{
			string path = perfCounterIniFiles[i];
			using StreamReader streamReader = new StreamReader(path);
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				if (text.StartsWith("drivername=", StringComparison.InvariantCultureIgnoreCase))
				{
					perfCounterDriverNames[i] = text.Substring(text.IndexOf('=') + 1);
				}
			}
		}
	}

	internal void Install()
	{
		int num = 0;
		int num2;
		while (true)
		{
			if (num >= perfCounterDriverNames.Length)
			{
				return;
			}
			string driver = perfCounterDriverNames[num];
			string text = perfCounterRegFiles[num];
			string text2 = perfCounterIniFiles[num];
			if (!IsDriverInstalled(driver))
			{
				Process process = new Process();
				process.StartInfo = new ProcessStartInfo("regedit.exe", " /s \"" + text + "\"");
				process.Start();
				process.WaitForExit();
				num2 = NativeMethods.LoadPerfCounterTextStrings(" \"" + text2 + "\"", quietMode: true);
				if (num2 != 0)
				{
					break;
				}
			}
			num++;
		}
		throw new Win32Exception(num2);
	}

	private bool IsDriverInstalled(string driver)
	{
		bool result = false;
		using RegistryKey registryKey = Registry.LocalMachine;
		using RegistryKey registryKey2 = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + driver + "\\Performance");
		if (registryKey2 != null)
		{
			return true;
		}
		return result;
	}

	internal void Uninstall()
	{
		string[] array = perfCounterDriverNames;
		foreach (string text in array)
		{
			if (IsDriverInstalled(text))
			{
				int num = NativeMethods.UnloadPerfCounterTextStrings(" \"" + text + "\"", quietMode: true);
				if (num != 0)
				{
					throw new Win32Exception(num);
				}
				using RegistryKey registryKey = Registry.LocalMachine;
				registryKey.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Services\\" + text);
			}
		}
		UninstallLegacyDrivers();
	}

	private void UninstallLegacyDrivers()
	{
		string[] array = legacyPerfCounterDriverNames;
		int num = 0;
		int num2;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			string text = array[num];
			if (IsDriverInstalled(text))
			{
				num2 = NativeMethods.UnloadPerfCounterTextStrings(" \"" + text + "\"", quietMode: true);
				if (num2 != 0)
				{
					break;
				}
				using RegistryKey registryKey = Registry.LocalMachine;
				registryKey.DeleteSubKeyTree("SYSTEM\\CurrentControlSet\\Services\\" + text);
			}
			num++;
		}
		throw new Win32Exception(num2);
	}
}
