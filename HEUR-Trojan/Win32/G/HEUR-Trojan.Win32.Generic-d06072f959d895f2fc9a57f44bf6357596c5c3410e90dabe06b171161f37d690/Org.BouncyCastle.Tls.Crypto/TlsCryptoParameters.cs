namespace Org.BouncyCastle.Tls.Crypto;

public class TlsCryptoParameters
{
	private readonly TlsContext m_context;

	public SecurityParameters SecurityParameters => m_context.SecurityParameters;

	public ProtocolVersion ClientVersion => m_context.ClientVersion;

	public ProtocolVersion RsaPreMasterSecretVersion => m_context.RsaPreMasterSecretVersion;

	public virtual ProtocolVersion ServerVersion => m_context.ServerVersion;

	public bool IsServer => m_context.IsServer;

	public TlsNonceGenerator NonceGenerator => m_context.NonceGenerator;

	public TlsCryptoParameters(TlsContext context)
	{
		m_context = context;
	}
}
