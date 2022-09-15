using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators;

internal class RsaOaepWrapper : IKeyUnwrapper, IKeyWrapper
{
	private readonly AlgorithmIdentifier algId;

	private readonly IAsymmetricBlockCipher engine;

	public object AlgorithmDetails => algId;

	public RsaOaepWrapper(bool forWrapping, ICipherParameters parameters, DerObjectIdentifier digestOid)
		: this(forWrapping, parameters, digestOid, digestOid)
	{
	}

	public RsaOaepWrapper(bool forWrapping, ICipherParameters parameters, DerObjectIdentifier digestOid, DerObjectIdentifier mgfOid)
	{
		AlgorithmIdentifier hashAlgorithm = new AlgorithmIdentifier(digestOid, DerNull.Instance);
		if (!mgfOid.Equals(NistObjectIdentifiers.IdShake128) && !mgfOid.Equals(NistObjectIdentifiers.IdShake256))
		{
			algId = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdRsaesOaep, new RsaesOaepParameters(hashAlgorithm, new AlgorithmIdentifier(PkcsObjectIdentifiers.IdMgf1, new AlgorithmIdentifier(mgfOid, DerNull.Instance)), RsaesOaepParameters.DefaultPSourceAlgorithm));
		}
		else
		{
			algId = new AlgorithmIdentifier(PkcsObjectIdentifiers.IdRsaesOaep, new RsaesOaepParameters(hashAlgorithm, new AlgorithmIdentifier(mgfOid), RsaesOaepParameters.DefaultPSourceAlgorithm));
		}
		engine = new OaepEncoding(new RsaBlindedEngine(), DigestUtilities.GetDigest(digestOid), DigestUtilities.GetDigest(mgfOid), null);
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
