using System.IO;
using System.Net.Sockets;

namespace TRM.SpyBackdoor;

public static class TcpMessageProcess
{
	public static void PrcessMessage(MemoryStream messageBuffer, TcpClient tcpClient)
	{
		messageBuffer.Seek(0L, SeekOrigin.Begin);
	}
}
