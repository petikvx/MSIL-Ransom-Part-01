using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace xClient.Core.Extensions;

public static class SocketExtensions
{
	internal struct TcpKeepAlive
	{
		internal uint onoff;

		internal uint keepalivetime;

		internal uint keepaliveinterval;
	}

	public static void SetKeepAliveEx(this Socket socket, uint keepAliveInterval, uint keepAliveTime)
	{
		TcpKeepAlive tcpKeepAlive = default(TcpKeepAlive);
		tcpKeepAlive.onoff = 1u;
		tcpKeepAlive.keepaliveinterval = keepAliveInterval;
		tcpKeepAlive.keepalivetime = keepAliveTime;
		TcpKeepAlive tcpKeepAlive2 = tcpKeepAlive;
		int num = Marshal.SizeOf((object)tcpKeepAlive2);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)tcpKeepAlive2, intPtr, fDeleteOld: true);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		socket.IOControl(IOControlCode.KeepAliveValues, array, null);
	}
}
