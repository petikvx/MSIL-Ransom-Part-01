using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns3;

internal class Class3
{
	private Socket socket_0;

	private Socket socket_1;

	private byte[] _003CP = new byte[1024];

	private int int_0;

	public Class3(Socket socket_2)
	{
		socket_0 = socket_2;
	}

	public void method_0()
	{
		socket_0.BeginReceive(_003CP, 0, _003CP.Length, SocketFlags.None, method_1, socket_0);
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				method_5(_003CP, num);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(_003CP, 0, _003CP.Length, SocketFlags.None, method_1, (Socket)iasyncResult_0.AsyncState);
			}
			else
			{
				method_6();
			}
		}
		catch
		{
		}
	}

	private void method_2(IAsyncResult iasyncResult_0)
	{
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				socket_0.BeginSend(_003CP, 0, num, SocketFlags.None, method_4, socket_0);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(_003CP, 0, _003CP.Length, SocketFlags.None, method_2, (Socket)iasyncResult_0.AsyncState);
			}
			else
			{
				method_6();
			}
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
			((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
			((Socket)iasyncResult_0.AsyncState).BeginReceive(_003CP, 0, _003CP.Length, SocketFlags.None, method_2, (Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}

	private void method_4(IAsyncResult iasyncResult_0)
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

	private void method_5(byte[] byte_0, int int_1)
	{
		try
		{
			switch (int_0)
			{
			case 0:
			{
				byte b2 = byte_0[2];
				if (byte_0[0] != 5)
				{
					method_6();
					break;
				}
				if (b2 != 0)
				{
					b2 = byte.MaxValue;
				}
				socket_0.BeginSend(new byte[2]
				{
					byte_0[0],
					b2
				}, 0, 2, SocketFlags.None, method_4, socket_0);
				int_0++;
				break;
			}
			case 1:
			{
				IPAddress iPAddress = null;
				ushort port = 0;
				byte b = _003CP[1];
				if (b == 1)
				{
					switch (_003CP[3])
					{
					case 1:
						iPAddress = IPAddress.Parse(byte_0[4] + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_1() + byte_0[5] + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_1() + byte_0[6] + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_1() + byte_0[7]);
						port = (ushort)(byte_0[8] * 256 + byte_0[9]);
						break;
					case 3:
						iPAddress = Dns.GetHostAddresses(Encoding.Default.GetString(byte_0, 5, byte_0[4]))[0];
						port = (ushort)(byte_0[4] + 5);
						port = (ushort)(byte_0[port] * 256 + byte_0[port + 1]);
						break;
					}
				}
				socket_1 = new Socket(iPAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
				socket_1.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, optionValue: true);
				IAsyncResult asyncResult = socket_1.BeginConnect(new IPEndPoint(iPAddress, port), method_3, socket_1);
				asyncResult.AsyncWaitHandle.WaitOne();
				if (socket_1.Connected)
				{
					byte_0[1] = 0;
				}
				else
				{
					byte_0[1] = 4;
				}
				socket_0.BeginSend(byte_0, 0, int_1, SocketFlags.None, method_4, socket_0);
				int_0++;
				break;
			}
			case 2:
				socket_1.BeginSend(byte_0, 0, int_1, SocketFlags.None, method_4, socket_1);
				break;
			}
		}
		catch
		{
			method_6();
		}
	}

	private void method_6()
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
