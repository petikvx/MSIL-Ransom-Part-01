using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.InfoCards;

internal sealed class RemoteCryptoTokenProvider : SecurityTokenProvider, IDisposable
{
	private RemoteX509Token m_token;

	private X509Certificate2 m_certificate;

	private object m_sync;

	public RemoteCryptoTokenProvider(X509Certificate2 cert)
	{
		m_sync = new object();
		m_certificate = cert;
	}

	public void Dispose()
	{
		IDisposable token = (IDisposable)m_token;
		if (token != null)
		{
			token.Dispose();
			m_token = null;
		}
	}

	protected override SecurityToken GetTokenCore(TimeSpan timeout)
	{
		return (SecurityToken)(object)InnerGetToken();
	}

	private X509SecurityToken InnerGetToken()
	{
		if (m_token == null)
		{
			lock (m_sync)
			{
				if (m_token == null)
				{
					m_token = new RemoteX509Token(m_certificate);
				}
			}
		}
		return (X509SecurityToken)(object)m_token;
	}
}
