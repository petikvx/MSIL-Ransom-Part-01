namespace Org.BouncyCastle.Tls.Crypto.Impl;

public interface TlsAeadCipherImpl
{
	void SetKey(byte[] key, int keyOff, int keyLen);

	void Init(byte[] nonce, int macSize, byte[] additionalData);

	int GetOutputSize(int inputLength);

	int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset);
}
