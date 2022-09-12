#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace ns0;

internal class SOCKS4 : ISOCKS
{
	private readonly byte vn = 4;

	private readonly byte cd = 1;

	private readonly byte userid = 0;

	private Dictionary<byte, string> hatalar = new Dictionary<byte, string>();

	private string proxyIp { get; set; }

	private short proxyPort { get; set; }

	public SOCKS4(string proxyIp, short proxyPort)
	{
		this.proxyIp = proxyIp;
		this.proxyPort = proxyPort;
		hatalar.Add(91, "request rejected or failed");
		hatalar.Add(92, "request rejected becasue SOCKS server cannot connect to identd on the client");
		hatalar.Add(93, "request rejected because the client program and identd report different user - ids.");
	}

	public Socket SOCKSBaglan(string ip, short port)
	{
		Socket socket = null;
		try
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			byte[] array = new byte[4096];
			Convert.ToByte(ip.Length);
			byte[] addressBytes = IPAddress.Parse(ip).GetAddressBytes();
			byte[] second = BigEndian(port);
			socket.SendTimeout = 25000;
			socket.ReceiveTimeout = 25000;
			socket.Connect(new IPEndPoint(IPAddress.Parse(proxyIp), proxyPort));
			socket.Send(new byte[2] { vn, cd }.Concat(second).Concat(addressBytes).Concat(new byte[1] { userid })
				.ToArray());
			socket.Receive(array);
			if (array[1] != 90)
			{
				Debug.WriteLine("Hata: Bir sorun oluştu: " + hatalar[array[1]]);
				socket.Dispose();
				throw new Exception();
			}
		}
		catch
		{
			socket.Dispose();
			Console.WriteLine("Disposed");
			throw new Exception();
		}
		return socket;
	}

	private byte[] BigEndian(short port)
	{
		return new byte[2]
		{
			(byte)(port >> 8),
			(byte)port
		};
	}
}
