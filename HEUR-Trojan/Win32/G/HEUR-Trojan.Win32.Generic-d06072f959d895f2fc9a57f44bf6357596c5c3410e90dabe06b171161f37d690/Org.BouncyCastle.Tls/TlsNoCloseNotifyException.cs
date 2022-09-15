using System.IO;

namespace Org.BouncyCastle.Tls;

public class TlsNoCloseNotifyException : EndOfStreamException
{
	public TlsNoCloseNotifyException()
		: base("No close_notify alert received before connection closed")
	{
	}
}
