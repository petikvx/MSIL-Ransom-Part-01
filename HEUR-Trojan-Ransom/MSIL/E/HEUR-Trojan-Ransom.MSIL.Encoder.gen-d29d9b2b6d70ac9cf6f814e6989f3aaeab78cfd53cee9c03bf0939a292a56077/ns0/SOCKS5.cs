#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns0;

internal class SOCKS5 : ISOCKS
{
	private readonly byte ver = 5;

	private readonly byte cmd = 1;

	private readonly byte rsv = 0;

	private readonly byte atyp = 3;

	private readonly byte nmethods = 1;

	private readonly byte methods = 0;

	private Dictionary<byte, string> hatalarDogrulama = new Dictionary<byte, string>();

	private Dictionary<byte, string> hatalarBaglanti = new Dictionary<byte, string>();

	private string proxyIp { get; set; }

	private short proxyPort { get; set; }

	public SOCKS5(string proxyIp, short proxyPort)
	{
		this.proxyIp = proxyIp;
		this.proxyPort = proxyPort;
		hatalarDogrulama.Add(1, "GSSAPI");
		hatalarDogrulama.Add(2, "USERNAME/PASSWORD");
		hatalarDogrulama.Add(3, "to X'7F' IANA ASSIGNED");
		hatalarDogrulama.Add(128, "to X'FE' RESERVED FOR PRIVATE METHODS");
		hatalarDogrulama.Add(byte.MaxValue, "NO ACCEPTABLE METHODS");
		hatalarBaglanti.Add(1, "general SOCKS server failure");
		hatalarBaglanti.Add(2, "connection not allowed by ruleset");
		hatalarBaglanti.Add(3, "Network unreachable");
		hatalarBaglanti.Add(4, "Host unreachable");
		hatalarBaglanti.Add(5, "Connection refused");
		hatalarBaglanti.Add(6, "TTL expired");
		hatalarBaglanti.Add(7, "Command not supported");
		hatalarBaglanti.Add(8, "Address type not supported");
		hatalarBaglanti.Add(9, "to X'FF' unassigned");
	}

	public Socket SOCKSBaglan(string ip, short port)
	{
		Socket socket = null;
		try
		{
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			byte[] array = new byte[4096];
			byte b = Convert.ToByte(ip.Length);
			byte[] bytes = Encoding.Default.GetBytes(ip);
			byte[] second = BigEndian(port);
			socket.SendTimeout = 25000;
			socket.ReceiveTimeout = 25000;
			socket.Connect(new IPEndPoint(IPAddress.Parse(proxyIp), proxyPort));
			socket.Send(new byte[3] { ver, nmethods, methods });
			socket.Receive(array);
			if (array[1] != 0)
			{
				Debug.WriteLine("Hata: Vekil sunucuya bağlanılamadı: " + hatalarDogrulama[array[1]]);
				socket.Dispose();
				throw new Exception();
			}
			socket.Send(new byte[5] { ver, cmd, rsv, atyp, b }.Concat(bytes).Concat(second).ToArray());
			socket.Receive(array);
			if (array[1] != 0)
			{
				Console.WriteLine("Hata: Belirtilen sunucuya bağlanılamadı: " + hatalarBaglanti[array[1]]);
				socket.Dispose();
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
