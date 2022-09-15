using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public abstract class AbstractTlsKeyExchange : TlsKeyExchange
{
	protected readonly int m_keyExchange;

	protected TlsContext m_context;

	public virtual bool RequiresServerKeyExchange => false;

	public virtual bool RequiresCertificateVerify => true;

	protected AbstractTlsKeyExchange(int keyExchange)
	{
		m_keyExchange = keyExchange;
	}

	public virtual void Init(TlsContext context)
	{
		m_context = context;
	}

	public abstract void SkipServerCredentials();

	public abstract void ProcessServerCredentials(TlsCredentials serverCredentials);

	public virtual void ProcessServerCertificate(Certificate serverCertificate)
	{
		throw new TlsFatalAlert(80);
	}

	public virtual byte[] GenerateServerKeyExchange()
	{
		if (RequiresServerKeyExchange)
		{
			throw new TlsFatalAlert(80);
		}
		return null;
	}

	public virtual void SkipServerKeyExchange()
	{
		if (RequiresServerKeyExchange)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public virtual void ProcessServerKeyExchange(Stream input)
	{
		if (!RequiresServerKeyExchange)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public virtual short[] GetClientCertificateTypes()
	{
		return null;
	}

	public virtual void SkipClientCredentials()
	{
	}

	public abstract void ProcessClientCredentials(TlsCredentials clientCredentials);

	public virtual void ProcessClientCertificate(Certificate clientCertificate)
	{
	}

	public abstract void GenerateClientKeyExchange(Stream output);

	public virtual void ProcessClientKeyExchange(Stream input)
	{
		throw new TlsFatalAlert(80);
	}

	public abstract TlsSecret GeneratePreMasterSecret();
}
