#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns0;

internal class SOCKS4a : ISOCKS
{
	private readonly byte vn = 4;

	private readonly byte cd = 1;

	private readonly byte userid = 0;

	private Dictionary<byte, string> hatalar = new Dictionary<byte, string>();

	private string proxyIp { get; set; }

	private short proxyPort { get; set; }

	public SOCKS4a(string proxyIp, short proxyPort)
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
			byte[] second = BigEndian(port);
			byte[] bytes = Encoding.Default.GetBytes(ip);
			socket.SendTimeout = 25000;
			socket.ReceiveTimeout = 25000;
			socket.Connect(new IPEndPoint(IPAddress.Parse(proxyIp), proxyPort));
			socket.Send(new byte[2] { vn, cd }.Concat(second).Concat(new byte[4] { 0, 0, 0, 1 }).Concat(new byte[1] { userid })
				.Concat(bytes)
				.Concat(new byte[1])
				.ToArray());
			socket.Receive(array);
			if (array[1] != 90)
			{
				Debug.WriteLine("Hata: Bir sorun oluştu: " + hatalar[array[1]]);
				throw new Exception();
			}
		}
		catch
		{
			socket.Dispose();
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
