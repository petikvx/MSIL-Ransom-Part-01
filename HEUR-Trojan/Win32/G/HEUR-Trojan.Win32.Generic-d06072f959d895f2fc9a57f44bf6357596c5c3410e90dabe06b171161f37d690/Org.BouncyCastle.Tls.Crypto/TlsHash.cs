namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsHash
{
	void Update(byte[] input, int inOff, int length);

	byte[] CalculateHash();

	TlsHash CloneHash();

	void Reset();
}
