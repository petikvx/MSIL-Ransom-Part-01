using System.Security.Cryptography;

namespace ns0;

internal interface ICngSymmetricAlgorithm
{
	int BlockSize { get; }

	CipherMode Mode { get; }

	PaddingMode Padding { get; }

	byte[] IV { get; set; }

	KeySizes[] LegalKeySizes { get; }

	byte[] BaseKey { get; set; }

	int BaseKeySize { get; set; }

	bool imethod_0(byte[] byte_0);

	string imethod_1();
}
