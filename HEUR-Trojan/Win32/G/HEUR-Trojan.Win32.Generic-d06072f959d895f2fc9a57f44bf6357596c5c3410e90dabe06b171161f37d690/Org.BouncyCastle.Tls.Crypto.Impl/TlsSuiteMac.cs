namespace Org.BouncyCastle.Tls.Crypto.Impl;

public interface TlsSuiteMac
{
	int Size { get; }

	byte[] CalculateMac(long seqNo, short type, byte[] message, int offset, int length);

	byte[] CalculateMacConstantTime(long seqNo, short type, byte[] message, int offset, int length, int expectedLength, byte[] randomData);
}
