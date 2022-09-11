using System;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.Common;

[Serializable]
internal sealed class UnixEndPoint : EndPoint
{
	[NonSerialized]
	internal static GetString getString_0;

	public string SocketName { get; private set; }

	public UnixEndPoint(string socketName)
	{
		SocketName = socketName;
	}

	EndPoint EndPoint.Create(SocketAddress socketAddress)
	{
		int num = socketAddress.Size - 2;
		byte[] array = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = socketAddress[i + 2];
		}
		return new UnixEndPoint(Encoding.UTF8.GetString(array));
	}

	SocketAddress EndPoint.Serialize()
	{
		byte[] bytes = Encoding.UTF8.GetBytes(SocketName);
		SocketAddress socketAddress = new SocketAddress(AddressFamily.Unix, bytes.Length + 3);
		for (int i = 0; i < bytes.Length; i++)
		{
			socketAddress[i + 2] = bytes[i];
		}
		return socketAddress;
	}

	static UnixEndPoint()
	{
		Strings.CreateGetStringDelegate(typeof(UnixEndPoint));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398206), getString_0(107398201)).Replace(getString_0(107398164), getString_0(107398159)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398154)))
		{
			throw new SecurityException(getString_0(107398129));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
