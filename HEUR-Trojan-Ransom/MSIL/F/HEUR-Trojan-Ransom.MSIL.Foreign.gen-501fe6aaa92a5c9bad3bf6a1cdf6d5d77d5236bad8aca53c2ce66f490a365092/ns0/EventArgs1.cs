using System;
using System.Net.Sockets;

namespace ns0;

internal class EventArgs1 : EventArgs
{
	private SocketError socketError_0;

	private int int_0;

	public SocketError SocketError_0 => socketError_0;

	public int Int32_0 => int_0;

	public EventArgs1(SocketError s_err, int s_n_err)
	{
		socketError_0 = s_err;
		int_0 = s_n_err;
	}
}
