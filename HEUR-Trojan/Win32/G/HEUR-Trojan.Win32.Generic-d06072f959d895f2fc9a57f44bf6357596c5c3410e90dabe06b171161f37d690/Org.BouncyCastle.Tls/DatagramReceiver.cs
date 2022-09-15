namespace Org.BouncyCastle.Tls;

public interface DatagramReceiver
{
	int GetReceiveLimit();

	int Receive(byte[] buf, int off, int len, int waitMillis);
}
