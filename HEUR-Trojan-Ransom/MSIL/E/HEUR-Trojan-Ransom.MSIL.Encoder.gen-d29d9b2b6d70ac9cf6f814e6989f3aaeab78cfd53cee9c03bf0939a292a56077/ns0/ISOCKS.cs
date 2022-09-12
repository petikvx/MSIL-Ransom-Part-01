using System.Net.Sockets;

namespace ns0;

internal interface ISOCKS
{
	Socket SOCKSBaglan(string ip, short port);
}
