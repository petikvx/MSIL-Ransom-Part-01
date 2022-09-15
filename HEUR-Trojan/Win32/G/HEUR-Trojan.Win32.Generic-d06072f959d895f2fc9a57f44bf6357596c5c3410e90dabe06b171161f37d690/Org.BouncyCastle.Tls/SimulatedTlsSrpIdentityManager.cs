using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class SimulatedTlsSrpIdentityManager : TlsSrpIdentityManager
{
	private static readonly byte[] PrefixPassword = Strings.ToByteArray("password");

	private static readonly byte[] PrefixSalt = Strings.ToByteArray("salt");

	protected readonly Srp6Group m_group;

	protected readonly TlsSrp6VerifierGenerator m_verifierGenerator;

	protected readonly TlsMac m_mac;

	public static SimulatedTlsSrpIdentityManager GetRfc5054Default(TlsCrypto crypto, Srp6Group group, byte[] seedKey)
	{
		TlsMac tlsMac = crypto.CreateHmac(2);
		tlsMac.SetKey(seedKey, 0, seedKey.Length);
		TlsSrpConfig tlsSrpConfig = new TlsSrpConfig();
		tlsSrpConfig.SetExplicitNG(new BigInteger[2] { group.N, group.G });
		return new SimulatedTlsSrpIdentityManager(group, crypto.CreateSrp6VerifierGenerator(tlsSrpConfig), tlsMac);
	}

	public SimulatedTlsSrpIdentityManager(Srp6Group group, TlsSrp6VerifierGenerator verifierGenerator, TlsMac mac)
	{
		m_group = group;
		m_verifierGenerator = verifierGenerator;
		m_mac = mac;
	}

	public virtual TlsSrpLoginParameters GetLoginParameters(byte[] identity)
	{
		m_mac.Update(PrefixSalt, 0, PrefixSalt.Length);
		m_mac.Update(identity, 0, identity.Length);
		byte[] salt = m_mac.CalculateMac();
		m_mac.Update(PrefixPassword, 0, PrefixPassword.Length);
		m_mac.Update(identity, 0, identity.Length);
		byte[] password = m_mac.CalculateMac();
		BigInteger verifier = m_verifierGenerator.GenerateVerifier(salt, identity, password);
		TlsSrpConfig tlsSrpConfig = new TlsSrpConfig();
		tlsSrpConfig.SetExplicitNG(new BigInteger[2] { m_group.N, m_group.G });
		return new TlsSrpLoginParameters(identity, tlsSrpConfig, verifier, salt);
	}
}
