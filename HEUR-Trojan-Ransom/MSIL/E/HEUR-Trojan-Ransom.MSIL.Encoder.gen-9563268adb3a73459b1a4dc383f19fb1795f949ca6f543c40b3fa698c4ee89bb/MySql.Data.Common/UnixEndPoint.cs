using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace MySql.Data.Common;

[Serializable]
internal class UnixEndPoint : EndPoint
{
	public string SocketName { get; private set; }

	public UnixEndPoint(string socketName)
	{
		SocketName = socketName;
	}

	public override EndPoint Create(SocketAddress socketAddress)
	{
		int num = socketAddress.Size - 2;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = socketAddress[i + 2];
		}
		return new UnixEndPoint(Encoding.UTF8.GetString(array));
	}

	public override SocketAddress Serialize()
	{
		byte[] bytes = Encoding.UTF8.GetBytes(SocketName);
		SocketAddress socketAddress = new SocketAddress(AddressFamily.Unix, bytes.Length + 3);
		for (int i = 0; i < bytes.Length; i++)
		{
			socketAddress[i + 2] = bytes[i];
		}
		return socketAddress;
	}
}
