namespace Org.BouncyCastle.Tls.Crypto.Impl;

public interface TlsBlockCipherImpl
{
	void SetKey(byte[] key, int keyOff, int keyLen);

	void Init(byte[] iv, int ivOff, int ivLen);

	int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset);

	int GetBlockSize();
}
