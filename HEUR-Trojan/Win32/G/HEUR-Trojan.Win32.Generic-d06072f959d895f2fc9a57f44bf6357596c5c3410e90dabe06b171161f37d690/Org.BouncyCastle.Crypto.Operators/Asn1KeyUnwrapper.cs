using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators;

public class Asn1KeyUnwrapper : IKeyUnwrapper
{
	private string algorithm;

	private IKeyUnwrapper wrapper;

	public object AlgorithmDetails => wrapper.AlgorithmDetails;

	public Asn1KeyUnwrapper(string algorithm, ICipherParameters key)
	{
		this.algorithm = algorithm;
		wrapper = KeyWrapperUtil.UnwrapperForName(algorithm, key);
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, ICipherParameters key)
		: this(algorithm, null, key)
	{
	}

	public Asn1KeyUnwrapper(DerObjectIdentifier algorithm, Asn1Encodable parameters, ICipherParameters key)
	{
		this.algorithm = algorithm.Id;
		if (algorithm.Equals(PkcsObjectIdentifiers.IdRsaesOaep))
		{
			RsaesOaepParameters instance = RsaesOaepParameters.GetInstance(parameters);
			WrapperProvider wrapperProvider;
			if (instance.MaskGenAlgorithm.Algorithm.Equals(PkcsObjectIdentifiers.IdMgf1))
			{
				AlgorithmIdentifier instance2 = AlgorithmIdentifier.GetInstance(instance.MaskGenAlgorithm.Parameters);
				wrapperProvider = new RsaOaepWrapperProvider(instance.HashAlgorithm.Algorithm, instance2.Algorithm);
			}
			else
			{
				wrapperProvider = new RsaOaepWrapperProvider(instance.HashAlgorithm.Algorithm, instance.MaskGenAlgorithm.Algorithm);
			}
			wrapper = (IKeyUnwrapper)wrapperProvider.CreateWrapper(forWrapping: false, key);
			return;
		}
		if (algorithm.Equals(PkcsObjectIdentifiers.RsaEncryption))
		{
			RsaesOaepParameters instance3 = RsaesOaepParameters.GetInstance(parameters);
			if (instance3.MaskGenAlgorithm.Algorithm.Equals(PkcsObjectIdentifiers.IdMgf1))
			{
				AlgorithmIdentifier instance4 = AlgorithmIdentifier.GetInstance(instance3.MaskGenAlgorithm.Parameters);
				new RsaOaepWrapperProvider(instance3.HashAlgorithm.Algorithm, instance4.Algorithm);
			}
			else
			{
				new RsaOaepWrapperProvider(instance3.HashAlgorithm.Algorithm, instance3.MaskGenAlgorithm.Algorithm);
			}
			wrapper = new RsaPkcs1Wrapper(forWrapping: false, key);
			return;
		}
		throw new ArgumentException("unknown algorithm: " + algorithm.Id);
	}

	public IBlockResult Unwrap(byte[] keyData, int offSet, int length)
	{
		return wrapper.Unwrap(keyData, offSet, length);
	}
}
