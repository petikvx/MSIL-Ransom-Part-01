using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class TlsSrpKeyExchange : AbstractTlsKeyExchange
{
	protected TlsSrpIdentity m_srpIdentity;

	protected TlsSrpConfigVerifier m_srpConfigVerifier;

	protected TlsCertificate m_serverCertificate;

	protected byte[] m_srpSalt;

	protected TlsSrp6Client m_srpClient;

	protected TlsSrpLoginParameters m_srpLoginParameters;

	protected TlsCredentialedSigner m_serverCredentials;

	protected TlsSrp6Server m_srpServer;

	protected BigInteger m_srpPeerCredentials;

	public override bool RequiresServerKeyExchange => true;

	private static int CheckKeyExchange(int keyExchange)
	{
		if ((uint)(keyExchange - 21) > 2u)
		{
			throw new ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}
		return keyExchange;
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpIdentity srpIdentity, TlsSrpConfigVerifier srpConfigVerifier)
		: base(CheckKeyExchange(keyExchange))
	{
		m_srpIdentity = srpIdentity;
		m_srpConfigVerifier = srpConfigVerifier;
	}

	public TlsSrpKeyExchange(int keyExchange, TlsSrpLoginParameters srpLoginParameters)
		: base(CheckKeyExchange(keyExchange))
	{
		m_srpLoginParameters = srpLoginParameters;
	}

	public override void SkipServerCredentials()
	{
		if (m_keyExchange != 21)
		{
			throw new TlsFatalAlert(80);
		}
	}

	public override void ProcessServerCredentials(TlsCredentials serverCredentials)
	{
		if (m_keyExchange == 21)
		{
			throw new TlsFatalAlert(80);
		}
		m_serverCredentials = TlsUtilities.RequireSignerCredentials(serverCredentials);
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		if (m_keyExchange == 21)
		{
			throw new TlsFatalAlert(80);
		}
		m_serverCertificate = serverCertificate.GetCertificateAt(0);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		TlsSrpConfig config = m_srpLoginParameters.Config;
		m_srpServer = m_context.Crypto.CreateSrp6Server(config, m_srpLoginParameters.Verifier);
		BigInteger b = m_srpServer.GenerateServerCredentials();
		BigInteger[] explicitNG = config.GetExplicitNG();
		ServerSrpParams serverSrpParams = new ServerSrpParams(explicitNG[0], explicitNG[1], m_srpLoginParameters.Salt, b);
		DigestInputBuffer digestInputBuffer = new DigestInputBuffer();
		serverSrpParams.Encode(digestInputBuffer);
		if (m_serverCredentials != null)
		{
			TlsUtilities.GenerateServerKeyExchangeSignature(m_context, m_serverCredentials, null, digestInputBuffer);
		}
		return digestInputBuffer.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		DigestInputBuffer digestInputBuffer = null;
		Stream input2 = input;
		if (m_keyExchange != 21)
		{
			digestInputBuffer = new DigestInputBuffer();
			input2 = new TeeInputStream(input, digestInputBuffer);
		}
		ServerSrpParams serverSrpParams = ServerSrpParams.Parse(input2);
		if (digestInputBuffer != null)
		{
			TlsUtilities.VerifyServerKeyExchangeSignature(m_context, input, m_serverCertificate, null, digestInputBuffer);
		}
		TlsSrpConfig tlsSrpConfig = new TlsSrpConfig();
		tlsSrpConfig.SetExplicitNG(new BigInteger[2] { serverSrpParams.N, serverSrpParams.G });
		if (!m_srpConfigVerifier.Accept(tlsSrpConfig))
		{
			throw new TlsFatalAlert(71);
		}
		m_srpSalt = serverSrpParams.S;
		m_srpPeerCredentials = ValidatePublicValue(serverSrpParams.N, serverSrpParams.B);
		m_srpClient = m_context.Crypto.CreateSrp6Client(tlsSrpConfig);
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		throw new TlsFatalAlert(80);
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		byte[] srpIdentity = m_srpIdentity.GetSrpIdentity();
		byte[] srpPassword = m_srpIdentity.GetSrpPassword();
		TlsSrpUtilities.WriteSrpParameter(m_srpClient.GenerateClientCredentials(m_srpSalt, srpIdentity, srpPassword), output);
		m_context.SecurityParameters.m_srpIdentity = Arrays.Clone(srpIdentity);
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		m_srpPeerCredentials = ValidatePublicValue(m_srpLoginParameters.Config.GetExplicitNG()[0], TlsSrpUtilities.ReadSrpParameter(input));
		m_context.SecurityParameters.m_srpIdentity = Arrays.Clone(m_srpLoginParameters.Identity);
	}

	public override TlsSecret GeneratePreMasterSecret()
	{
		BigInteger n = ((m_srpServer != null) ? m_srpServer.CalculateSecret(m_srpPeerCredentials) : m_srpClient.CalculateSecret(m_srpPeerCredentials));
		return m_context.Crypto.CreateSecret(BigIntegers.AsUnsignedByteArray(n));
	}

	protected static BigInteger ValidatePublicValue(BigInteger N, BigInteger val)
	{
		val = val.Mod(N);
		if (val.Equals(BigInteger.Zero))
		{
			throw new TlsFatalAlert(47);
		}
		return val;
	}
}
