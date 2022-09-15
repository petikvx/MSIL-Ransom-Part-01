namespace Org.BouncyCastle.Tls;

public interface TlsSession
{
	byte[] SessionID { get; }

	bool IsResumable { get; }

	SessionParameters ExportSessionParameters();

	void Invalidate();
}
