namespace Org.BouncyCastle.Tls;

public interface DatagramSender
{
	int GetSendLimit();

	void Send(byte[] buf, int off, int len);
}
