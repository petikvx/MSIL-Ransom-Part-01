using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ns1;

internal class Class4
{
	private Socket socket_0;

	private Socket socket_1;

	private byte[] byte_0 = new byte[1024];

	private int int_0;

	public Class4(Socket socket_2)
	{
		socket_0 = socket_2;
	}

	public void method_0()
	{
		socket_0.BeginReceive(byte_0, 0, byte_0.Length, (SocketFlags)0, (AsyncCallback)method_1, (object)socket_0);
	}

	private void method_1(IAsyncResult iasyncResult_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				method_5(byte_0, num);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, (SocketFlags)0, (AsyncCallback)method_1, (object)(Socket)iasyncResult_0.AsyncState);
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		try
		{
			int num = ((Socket)iasyncResult_0.AsyncState).EndReceive(iasyncResult_0);
			if (num > 0)
			{
				socket_0.BeginSend(byte_0, 0, num, (SocketFlags)0, (AsyncCallback)method_4, (object)socket_0);
				((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, (SocketFlags)0, (AsyncCallback)method_2, (object)(Socket)iasyncResult_0.AsyncState);
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
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		try
		{
			((Socket)iasyncResult_0.AsyncState).EndConnect(iasyncResult_0);
			((Socket)iasyncResult_0.AsyncState).BeginReceive(byte_0, 0, byte_0.Length, (SocketFlags)0, (AsyncCallback)method_2, (object)(Socket)iasyncResult_0.AsyncState);
		}
		catch
		{
		}
	}

	private void method_4(IAsyncResult iasyncResult_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Socket)iasyncResult_0.AsyncState).EndSend(iasyncResult_0);
		}
		catch
		{
		}
	}

	private void method_5(byte[] byte_1, int int_1)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		switch (int_0)
		{
		case 0:
		{
			byte b2 = byte_1[0];
			byte b3 = byte_1[2];
			if (b2 != 5)
			{
				method_6();
				break;
			}
			if (b3 != 0)
			{
				b3 = byte.MaxValue;
			}
			socket_0.BeginSend(new byte[2] { b2, b3 }, 0, 2, (SocketFlags)0, (AsyncCallback)method_4, (object)socket_0);
			int_0++;
			break;
		}
		case 1:
		{
			IPAddress val = null;
			ushort num = 0;
			byte b = byte_0[1];
			if (b == 1)
			{
				switch (byte_0[3])
				{
				case 1:
					val = IPAddress.Parse(byte_1[4] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.eY() + byte_1[5] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.eY() + byte_1[6] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.eY() + byte_1[7]);
					num = (ushort)(byte_1[8] * 256 + byte_1[9]);
					break;
				case 3:
					val = Dns.GetHostAddresses(Encoding.Default.GetString(byte_1, 5, byte_1[4]))[0];
					num = (ushort)(byte_1[4] + 5);
					num = (ushort)(byte_1[num] * 256 + byte_1[num + 1]);
					break;
				}
			}
			socket_1 = new Socket(val.get_AddressFamily(), (SocketType)1, (ProtocolType)6);
			socket_1.SetSocketOption((SocketOptionLevel)65535, (SocketOptionName)8, true);
			IAsyncResult asyncResult = socket_1.BeginConnect((EndPoint)new IPEndPoint(val, (int)num), (AsyncCallback)method_3, (object)socket_1);
			asyncResult.AsyncWaitHandle.WaitOne();
			if (socket_1.get_Connected())
			{
				byte_1[1] = 0;
			}
			else
			{
				byte_1[1] = 4;
			}
			socket_0.BeginSend(byte_1, 0, int_1, (SocketFlags)0, (AsyncCallback)method_4, (object)socket_0);
			int_0++;
			break;
		}
		case 2:
			socket_1.BeginSend(byte_1, 0, int_1, (SocketFlags)0, (AsyncCallback)method_4, (object)socket_1);
			break;
		}
	}

	private void method_6()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			socket_1.Disconnect(false);
			socket_0.Disconnect(false);
			socket_1.Close();
			socket_0.Close();
		}
		catch
		{
		}
	}
}
