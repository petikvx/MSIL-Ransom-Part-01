namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsCipher
{
	bool UsesOpaqueRecordType { get; }

	int GetCiphertextDecodeLimit(int plaintextLimit);

	int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit);

	int GetPlaintextLimit(int ciphertextLimit);

	TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len);

	TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len);

	void RekeyDecoder();

	void RekeyEncoder();
}
