using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;

internal class ECKeyGenerationParameters : KeyGenerationParameters
{
	private readonly ECDomainParameters domainParams;

	public ECDomainParameters DomainParameters => domainParams;

	public ECKeyGenerationParameters(ECDomainParameters domainParameters, SecureRandom random)
		: base(random, domainParameters.N.BitLength)
	{
		domainParams = domainParameters;
	}
}
