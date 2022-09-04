using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

public sealed class GClass2
{
	private static string[] string_0 = new string[10] { "Operation completed successfully.", "General SOCKS server failure.", "Connection not allowed by ruleset.", "Network unreachable.", "Host unreachable.", "Connection refused.", "TTL expired.", "Command not supported.", "Address type not supported.", "Unknown error." };

	private GClass2()
	{
	}

	public static Socket smethod_0(string string_1, int int_0, string string_2, ushort ushort_0, string string_3, string string_4)
	{
		IPAddress iPAddress = null;
		IPAddress iPAddress2 = null;
		byte[] array = new byte[257];
		byte[] array2 = new byte[257];
		try
		{
			iPAddress2 = IPAddress.Parse(string_1);
		}
		catch (FormatException)
		{
			iPAddress2 = Dns.GetHostByAddress(string_1).AddressList[0];
		}
		try
		{
			iPAddress = IPAddress.Parse(string_2);
		}
		catch (FormatException)
		{
		}
		IPEndPoint remoteEP = new IPEndPoint(iPAddress2, int_0);
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		socket.Connect(remoteEP);
		ushort num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = 2;
		num = 3;
		array[2] = 0;
		num = 4;
		array[3] = 2;
		socket.Send(array, 4, SocketFlags.None);
		int num2 = socket.Receive(array2, 2, SocketFlags.None);
		if (num2 != 2)
		{
			throw new GException0("Bad response received from proxy server.");
		}
		if (array2[1] == byte.MaxValue)
		{
			socket.Close();
			throw new GException0("None of the authentication method was accepted by proxy server.");
		}
		num = 0;
		num = 1;
		array[0] = 5;
		num = 2;
		array[1] = (byte)string_3.Length;
		byte[] bytes = Encoding.Default.GetBytes(string_3);
		bytes.CopyTo(array, 2);
		num = (ushort)(2 + (ushort)bytes.Length);
		array[num++] = (byte)string_4.Length;
		bytes = Encoding.Default.GetBytes(string_4);
		bytes.CopyTo(array, num);
		num = (ushort)(num + (ushort)bytes.Length);
		socket.Send(array, num, SocketFlags.None);
		num2 = socket.Receive(array2, 2, SocketFlags.None);
		if (num2 != 2)
		{
			throw new GException0("Bad response received from proxy server.");
		}
		if (array2[1] != 0)
		{
			throw new GException0("Bad Usernaem/Password.");
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
			switch (iPAddress.AddressFamily)
			{
			case AddressFamily.InterNetworkV6:
				array[num++] = 4;
				bytes = iPAddress.GetAddressBytes();
				bytes.CopyTo(array, num);
				num = (ushort)(num + (ushort)bytes.Length);
				break;
			case AddressFamily.InterNetwork:
				array[num++] = 1;
				bytes = iPAddress.GetAddressBytes();
				bytes.CopyTo(array, num);
				num = (ushort)(num + (ushort)bytes.Length);
				break;
			}
		}
		else
		{
			array[num++] = 3;
			array[num++] = Convert.ToByte(string_2.Length);
			bytes = Encoding.Default.GetBytes(string_2);
			bytes.CopyTo(array, num);
			num = (ushort)(num + (ushort)bytes.Length);
		}
		byte[] bytes2 = BitConverter.GetBytes(ushort_0);
		for (int num3 = bytes2.Length - 1; num3 >= 0; num3--)
		{
			array[num++] = bytes2[num3];
		}
		socket.Send(array, num, SocketFlags.None);
		socket.Receive(array2);
		if (array2[1] != 0)
		{
			throw new GException0(string_0[array2[1]]);
		}
		return socket;
	}
}
