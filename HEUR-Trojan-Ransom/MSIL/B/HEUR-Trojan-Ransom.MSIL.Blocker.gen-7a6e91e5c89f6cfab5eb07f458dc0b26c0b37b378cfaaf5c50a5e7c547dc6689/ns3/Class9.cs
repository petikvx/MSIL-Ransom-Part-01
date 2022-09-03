using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns3;

internal class Class9
{
	private Socket socket_0;

	private Socket socket_1;

	private byte[] byte_0 = new byte[1024];

	private int int_0;

	public Class9(Socket socket_2)
	{
		socket_0 = socket_2;
	}

	public void _003CdlY()
	{
		socket_0.BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_0, socket_0);
	}

	private void method_0(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				method_4(byte_0, num);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_0, (Socket)iasyncResult_0.AsyncState);
			}
			else
			{
				method_5();
			}
		}
		catch
		{
		}
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				socket_0.BeginSend(byte_0, 0, num, SocketFlags.None, method_3, socket_0);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_1, (Socket)iasyncResult_0.AsyncState);
			}
			else
			{
				method_5();
			}
		}
		catch
		{
		}
	}

	private void method_2(IAsyncResult iasyncResult_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
			((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, SocketFlags.None, method_1, (Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}

	private void method_3(IAsyncResult iasyncResult_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			((Socket)iasyncResult_0.AsyncState).EndSend(iasyncResult_0);
		}
		catch
		{
		}
	}

	private void method_4(byte[] Y5, int int_1)
	{
		try
		{
			switch (int_0)
			{
			case 0:
			{
				byte b2 = Y5[2];
				if (Y5[0] != 5)
				{
					method_5();
					break;
				}
				if (b2 != 0)
				{
					b2 = byte.MaxValue;
				}
				socket_0.BeginSend(new byte[2]
				{
					Y5[0],
					b2
				}, 0, 2, SocketFlags.None, method_3, socket_0);
				int_0++;
				break;
			}
			case 1:
			{
				IPAddress iPAddress = null;
				ushort port = 0;
				byte b = byte_0[1];
				if (b == 1)
				{
					switch (byte_0[3])
					{
					case 1:
						iPAddress = IPAddress.Parse(Y5[4] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_1() + Y5[5] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_1() + Y5[6] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_1() + Y5[7]);
						port = (ushort)(Y5[8] * 256 + Y5[9]);
						break;
					case 3:
						iPAddress = Dns.GetHostAddresses(Encoding.Default.GetString(Y5, 5, Y5[4]))[0];
						port = (ushort)(Y5[4] + 5);
						port = (ushort)(Y5[port] * 256 + Y5[port + 1]);
						break;
					}
				}
				socket_1 = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket_1.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, optionValue: true);
				IAsyncResult asyncResult = socket_1.BeginConnect(new IPEndPoint(iPAddress, port), method_2, socket_1);
				asyncResult.AsyncWaitHandle.WaitOne();
				if (socket_1.Connected)
				{
					Y5[1] = 0;
				}
				else
				{
					Y5[1] = 4;
				}
				socket_0.BeginSend(Y5, 0, int_1, SocketFlags.None, method_3, socket_0);
				int_0++;
				break;
			}
			case 2:
				socket_1.BeginSend(Y5, 0, int_1, SocketFlags.None, method_3, socket_1);
				break;
			}
		}
		catch
		{
			method_5();
		}
	}

	private void method_5()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			socket_1.Disconnect(reuseSocket: false);
			socket_0.Disconnect(reuseSocket: false);
			socket_1.Close();
			socket_0.Close();
		}
		catch
		{
		}
	}
}
