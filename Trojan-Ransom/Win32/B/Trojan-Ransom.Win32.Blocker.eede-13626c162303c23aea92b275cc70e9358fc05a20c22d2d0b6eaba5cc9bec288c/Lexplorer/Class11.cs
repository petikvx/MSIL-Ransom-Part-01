using System.Net.NetworkInformation;

namespace Lexplorer;

internal class Class11
{
	private const int TIME_TO_LIVE = 128;

	private const int BUFFER_LENGTH = 32;

	private const int RETRIES_COUNT = 4;

	private const int DEFAULT_TIMEOUT = 1000;

	private int _timeout = 1000;

	public int Timeout
	{
		get
		{
			return _timeout;
		}
		set
		{
			_timeout = value;
		}
	}

	public Class11()
	{
	}

	public Class11(int timeout)
	{
		_timeout = timeout;
	}

	public long PingHost(string host)
	{
		if (host.Contains(":"))
		{
			host = host.Substring(0, host.IndexOf(':'));
		}
		long num = 0L;
		PingOptions options = new PingOptions(128, dontFragment: true);
		Ping ping = new Ping();
		byte[] buffer = new byte[32];
		for (int i = 0; i < 4; i++)
		{
			try
			{
				PingReply pingReply = ping.Send(host, _timeout, buffer, options);
				if (pingReply != null)
				{
					if (pingReply.Status == IPStatus.Success)
					{
						num += pingReply.RoundtripTime;
						continue;
					}
					return long.MaxValue;
				}
				return long.MaxValue;
			}
			catch
			{
				return long.MaxValue;
			}
		}
		return num;
	}
}
