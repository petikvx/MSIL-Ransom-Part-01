using System.Net.Sockets;
using ns12;
using ns5;

namespace ns10;

internal abstract class Class57
{
	internal byte[] byte_0;

	internal Socket socket_0;

	protected Delegate6 delegate6_0;

	internal int int_0;

	public Class57(Socket socket_1)
	{
		Class6.smethod_197(socket_1, this);
	}

	public abstract void vmethod_0(Delegate6 delegate6_1);
}
