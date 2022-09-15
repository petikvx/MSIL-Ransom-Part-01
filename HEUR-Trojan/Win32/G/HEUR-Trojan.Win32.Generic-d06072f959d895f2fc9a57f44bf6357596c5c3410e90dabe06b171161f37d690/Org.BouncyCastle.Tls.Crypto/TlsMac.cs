namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsMac
{
	int MacLength { get; }

	void SetKey(byte[] key, int keyOff, int keyLen);

	void Update(byte[] input, int inOff, int length);

	byte[] CalculateMac();

	void CalculateMac(byte[] output, int outOff);

	void Reset();
}
