using System;

namespace Org.BouncyCastle.Tls.Crypto;

public sealed class TlsNullNullCipher : TlsCipher
{
	public static readonly TlsNullNullCipher Instance = new TlsNullNullCipher();

	public bool UsesOpaqueRecordType => false;

	public int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return plaintextLimit;
	}

	public int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		return plaintextLength;
	}

	public int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit;
	}

	public TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		byte[] array = new byte[headerAllocation + len];
		Array.Copy(plaintext, offset, array, headerAllocation, len);
		return new TlsEncodeResult(array, 0, array.Length, contentType);
	}

	public TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		return new TlsDecodeResult(ciphertext, offset, len, recordType);
	}

	public void RekeyDecoder()
	{
		throw new TlsFatalAlert(80);
	}

	public void RekeyEncoder()
	{
		throw new TlsFatalAlert(80);
	}
}
