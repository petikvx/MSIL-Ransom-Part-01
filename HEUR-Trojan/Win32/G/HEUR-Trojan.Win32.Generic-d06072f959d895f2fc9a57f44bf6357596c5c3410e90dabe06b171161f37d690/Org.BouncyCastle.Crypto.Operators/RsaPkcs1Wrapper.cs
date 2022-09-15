using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;

namespace Org.BouncyCastle.Crypto.Operators;

internal class RsaPkcs1Wrapper : IKeyUnwrapper, IKeyWrapper
{
	private readonly AlgorithmIdentifier algId;

	private readonly IAsymmetricBlockCipher engine;

	public object AlgorithmDetails => algId;

	public RsaPkcs1Wrapper(bool forWrapping, ICipherParameters parameters)
	{
		algId = new AlgorithmIdentifier(PkcsObjectIdentifiers.RsaEncryption, DerNull.Instance);
		engine = new Pkcs1Encoding(new RsaBlindedEngine());
		engine.Init(forWrapping, parameters);
	}

	public IBlockResult Unwrap(byte[] cipherText, int offset, int length)
	{
		return new SimpleBlockResult(engine.ProcessBlock(cipherText, offset, length));
	}

	public IBlockResult Wrap(byte[] keyData)
	{
		return new SimpleBlockResult(engine.ProcessBlock(keyData, 0, keyData.Length));
	}
}
