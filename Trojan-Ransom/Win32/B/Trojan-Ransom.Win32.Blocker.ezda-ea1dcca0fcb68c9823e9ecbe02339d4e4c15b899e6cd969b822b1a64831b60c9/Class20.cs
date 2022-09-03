using System;
using System.Net;
using System.Net.Sockets;

internal class Class20
{
	private Class20()
	{
	}

	public static Socket smethod_0(string string_0, int int_0, string string_1, ushort ushort_0, string string_2, string string_3)
	{
		IPAddress iPAddress = null;
		IPAddress iPAddress2 = null;
		byte[] array = new byte[257];
		byte[] array2 = new byte[257];
		try
		{
			iPAddress2 = Delegate119.smethod_0(string_0);
		}
		catch (FormatException)
		{
			iPAddress2 = Delegate117.smethod_0(Delegate116.smethod_1(string_0))[0];
		}
		try
		{
			iPAddress = Delegate119.smethod_0(string_1);
		}
		catch (FormatException)
		{
		}
		IPEndPoint endPoint_ = Delegate118.smethod_0(iPAddress2, int_0);
		Socket socket = Delegate122.smethod_0(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		Delegate136.smethod_0(socket, endPoint_);
		ushort num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = 2;
		num = 3;
		array[2] = 0;
		num = 4;
		array[3] = 2;
		Delegate126.smethod_0(socket, array, 4, SocketFlags.None);
		int num2 = Delegate126.smethod_1(socket, array2, 2, SocketFlags.None);
		if (num2 != 2)
		{
			throw Delegate273.smethod_0();
		}
		if (array2[1] == byte.MaxValue)
		{
			Delegate128.smethod_0(socket);
			throw Delegate273.smethod_0();
		}
		num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = (byte)Delegate88.smethod_0(string_2);
		byte[] array3 = Delegate101.smethod_0(Delegate100.smethod_1(), string_2);
		Delegate274.smethod_0(array3, array, 2);
		num = (ushort)(2 + (ushort)array3.Length);
		array[num++] = (byte)Delegate88.smethod_0(string_3);
		array3 = Delegate101.smethod_0(Delegate100.smethod_1(), string_3);
		Delegate274.smethod_0(array3, array, num);
		num = (ushort)(num + (ushort)array3.Length);
		Delegate126.smethod_0(socket, array, num, SocketFlags.None);
		num2 = Delegate126.smethod_1(socket, array2, 2, SocketFlags.None);
		if (num2 != 2)
		{
			throw Delegate273.smethod_0();
		}
		if (array2[1] != 0)
		{
			throw Delegate273.smethod_0();
		}
		num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = 1;
		num = 3;
		array[2] = 0;
		if (iPAddress != null)
		{
			switch (Delegate275.smethod_0(iPAddress))
			{
			case AddressFamily.InterNetworkV6:
				array[num++] = 4;
				array3 = Delegate259.smethod_0(iPAddress);
				Delegate274.smethod_0(array3, array, num);
				num = (ushort)(num + (ushort)array3.Length);
				break;
			case AddressFamily.InterNetwork:
				array[num++] = 1;
				array3 = Delegate259.smethod_0(iPAddress);
				Delegate274.smethod_0(array3, array, num);
				num = (ushort)(num + (ushort)array3.Length);
				break;
			}
		}
		else
		{
			array[num++] = 3;
			array[num++] = Delegate276.smethod_0(Delegate88.smethod_0(string_1));
			array3 = Delegate101.smethod_0(Delegate100.smethod_1(), string_1);
			Delegate274.smethod_0(array3, array, num);
			num = (ushort)(num + (ushort)array3.Length);
		}
		byte[] array4 = Delegate260.smethod_0(ushort_0);
		for (int num3 = array4.Length - 1; num3 >= 0; num3--)
		{
			array[num++] = array4[num3];
		}
		Delegate126.smethod_0(socket, array, num, SocketFlags.None);
		Delegate277.smethod_0(socket, array2);
		if (array2[1] != 0)
		{
			throw Delegate273.smethod_0();
		}
		return socket;
	}
}
