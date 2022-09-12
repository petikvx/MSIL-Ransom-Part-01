using System;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;

internal abstract class ECKeyParameters : AsymmetricKeyParameter
{
	private static readonly string[] algorithms = new string[2] { "EC", "ECDH" };

	private readonly string algorithm;

	private readonly ECDomainParameters parameters;

	public string AlgorithmName => algorithm;

	public ECDomainParameters Parameters => parameters;

	protected ECKeyParameters(string algorithm, bool isPrivate, ECDomainParameters parameters)
		: base(isPrivate)
	{
		if (algorithm == null)
		{
			throw new ArgumentNullException("algorithm");
		}
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		this.algorithm = VerifyAlgorithmName(algorithm);
		this.parameters = parameters;
	}

	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is ECDomainParameters obj2))
		{
			return false;
		}
		return Equals(obj2);
	}

	protected bool Equals(ECKeyParameters other)
	{
		if (parameters.Equals(other.parameters))
		{
			return Equals((AsymmetricKeyParameter)other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return parameters.GetHashCode() ^ base.GetHashCode();
	}

	internal ECKeyGenerationParameters CreateKeyGenerationParameters(SecureRandom random)
	{
		return new ECKeyGenerationParameters(parameters, random);
	}

	internal static string VerifyAlgorithmName(string algorithm)
	{
		if (Array.IndexOf(algorithms, algorithm, 0, algorithms.Length) < 0)
		{
			throw new ArgumentException("unrecognised algorithm: " + algorithm, "algorithm");
		}
		return algorithm.ToUpper();
	}
}
