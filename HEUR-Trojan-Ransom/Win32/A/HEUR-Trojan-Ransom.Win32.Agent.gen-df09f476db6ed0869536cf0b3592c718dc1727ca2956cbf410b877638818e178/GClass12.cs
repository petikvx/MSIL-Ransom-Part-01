using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

public class GClass12
{
	private byte[] byte_0;

	private byte[] byte_1;

	public GClass12(Socket socket_0, byte[] byte_2, int int_0)
	{
		Class51.smethod_0();
		base._002Ector();
		if (!smethod_2(byte_2))
		{
			return;
		}
		int num = GClass11.smethod_3(byte_2, "\r\n\r\n");
		int num2 = GClass11.smethod_3(byte_2, "\r\n", num + 4);
		string string_ = GClass11.smethod_6(byte_2, num + 4, num2);
		int num3 = GClass11.smethod_2(string_);
		if (num3 > 0)
		{
			byte_0 = new byte[65535];
			byte_1 = new byte[int_0];
			byte_2 = GClass11.smethod_9(byte_2, num + 4, num2 + 2, new byte[0]);
			Buffer.BlockCopy(byte_2, 0, byte_1, 0, int_0);
			if (!socket_0.Connected)
			{
				return;
			}
			int num4 = 0;
			int int_ = socket_0.Receive(byte_0, 0, byte_0.Length, SocketFlags.None);
			while ((num4 = smethod_0(byte_0, int_)) != -1)
			{
				byte[] array = smethod_1(byte_0, int_);
				byte[] dst = new byte[array.Length + byte_1.Length];
				Buffer.BlockCopy(byte_1, 0, dst, 0, byte_1.Length);
				Buffer.BlockCopy(array, 0, dst, byte_1.Length, array.Length);
				byte_1 = dst;
				if (num4 == -2)
				{
					break;
				}
				int_ = socket_0.Receive(byte_0, 0, byte_0.Length, SocketFlags.None);
			}
			Console.WriteLine("Got chunk! Size: {0}", byte_1.Length);
		}
		else
		{
			byte_1 = new byte[int_0];
			Buffer.BlockCopy(byte_2, 0, byte_1, 0, int_0);
		}
	}

	[SpecialName]
	public byte[] method_0()
	{
		return byte_1;
	}

	[SpecialName]
	public byte[] method_1()
	{
		int num = GClass11.smethod_3(byte_1, "\r\n\r\n") + 4;
		int int_ = byte_1.Length - num - 7;
		return GClass11.smethod_5(byte_1, "\r\n\r\n", "\r\n\r\n" + GClass11.smethod_0(int_).Replace("0x", "") + "\r\n");
	}

	public static int smethod_0(byte[] byte_2, int int_0)
	{
		if (GClass11.smethod_3(byte_2, "\r\n0\r\n\r\n", int_0 - 7) != -1)
		{
			return -2;
		}
		string string_ = GClass11.smethod_6(byte_2, 0, GClass11.smethod_3(byte_2, "\r\n"));
		return GClass11.smethod_2(string_);
	}

	public static byte[] smethod_1(byte[] byte_2, int int_0)
	{
		return GClass11.smethod_7(byte_2, GClass11.smethod_3(byte_2, "\r\n") + 2, int_0);
	}

	public static bool smethod_2(byte[] byte_2)
	{
		if (smethod_3(byte_2))
		{
			return GClass11.smethod_3(byte_2, "Transfer-Encoding: chunked\r\n") != -1;
		}
		return false;
	}

	public static bool smethod_3(byte[] byte_2)
	{
		if (GClass11.smethod_3(byte_2, "HTTP/1.1") != -1)
		{
			return GClass11.smethod_3(byte_2, "\r\n\r\n") != -1;
		}
		return false;
	}
}
