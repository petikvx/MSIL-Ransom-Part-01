using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.InfoCards;

internal class RemoteX509Token : X509SecurityToken
{
	private List<SecurityKey> m_keys;

	private object m_sync;

	private bool m_disposed;

	public override ReadOnlyCollection<SecurityKey> SecurityKeys => m_keys.AsReadOnly();

	public RemoteX509Token(X509Certificate2 cert)
		: base(cert)
	{
		m_keys = new List<SecurityKey>(1);
		m_keys.Add((SecurityKey)(object)new RemoteX509AsymmetricSecurityKey(cert));
		m_sync = new object();
	}

	public override void Dispose()
	{
		try
		{
			if (m_disposed)
			{
				return;
			}
			lock (m_sync)
			{
				if (m_disposed)
				{
					return;
				}
				m_disposed = true;
				foreach (SecurityKey key in m_keys)
				{
					if (key is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
			}
		}
		finally
		{
			((X509SecurityToken)this).Dispose();
		}
	}
}
