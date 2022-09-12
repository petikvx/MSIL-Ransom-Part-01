namespace ns0;

internal class SOCKS
{
	public enum Protokoller
	{
		SOCKS5,
		SOCKS4,
		SOCKS4a
	}

	public ISOCKS SOCKSOlustur(Protokoller protokol, string proxyIp, short proxyPort)
	{
		ISOCKS result = null;
		switch (protokol)
		{
		case Protokoller.SOCKS5:
			result = new SOCKS5(proxyIp, proxyPort);
			break;
		case Protokoller.SOCKS4:
			result = new SOCKS4(proxyIp, proxyPort);
			break;
		case Protokoller.SOCKS4a:
			result = new SOCKS4a(proxyIp, proxyPort);
			break;
		}
		return result;
	}
}
