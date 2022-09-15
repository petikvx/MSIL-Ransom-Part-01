using System;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Tls;

public class DefaultTlsHeartbeat : TlsHeartbeat
{
	private readonly int idleMillis;

	private readonly int timeoutMillis;

	private uint counter;

	public virtual int IdleMillis => idleMillis;

	public virtual int TimeoutMillis => timeoutMillis;

	public DefaultTlsHeartbeat(int idleMillis, int timeoutMillis)
	{
		if (idleMillis <= 0)
		{
			throw new ArgumentException("must be > 0", "idleMillis");
		}
		if (timeoutMillis <= 0)
		{
			throw new ArgumentException("must be > 0", "timeoutMillis");
		}
		this.idleMillis = idleMillis;
		this.timeoutMillis = timeoutMillis;
	}

	public virtual byte[] GeneratePayload()
	{
		lock (this)
		{
			return Pack.UInt32_To_BE(++counter);
		}
	}
}
