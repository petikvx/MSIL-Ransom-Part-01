namespace Org.BouncyCastle.Tls;

internal interface DtlsHandshakeRetransmit
{
	void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len);
}
