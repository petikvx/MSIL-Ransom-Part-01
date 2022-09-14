using System.Net;
using System.Net.Sockets;
using ns12;
using ns4;
using ns5;

namespace ns3;

internal abstract class Class54
{
	internal Socket socket_0;

	internal string string_0;

	internal Class52 class52_0;

	internal byte[] byte_0;

	internal int int_0;

	protected Delegate6 delegate6_0;

	public Class54(Socket socket_1, string string_1)
	{
		Class6.smethod_488(this, socket_1);
		Class6.smethod_355(string_1, this);
	}

	public abstract Class52 vmethod_0(string string_1, int int_1, Delegate6 delegate6_1, IPEndPoint ipendPoint_0);
}
