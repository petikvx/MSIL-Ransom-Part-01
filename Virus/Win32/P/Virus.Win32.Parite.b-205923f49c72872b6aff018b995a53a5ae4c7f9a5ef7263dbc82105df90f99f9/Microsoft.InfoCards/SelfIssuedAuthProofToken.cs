using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace Microsoft.InfoCards;

internal class SelfIssuedAuthProofToken : SecurityToken, IDisposable
{
	private string m_id;

	private DateTime m_expiration;

	private ReadOnlyCollection<SecurityKey> m_securityKeys;

	private SecurityKey m_securityKey;

	private bool m_isSymmetric;

	private RSACryptoServiceProvider m_publicKey;

	public override string Id => m_id;

	public override ReadOnlyCollection<SecurityKey> SecurityKeys => m_securityKeys;

	public override DateTime ValidTo => m_expiration;

	public override DateTime ValidFrom => DateTime.UtcNow;

	public SelfIssuedAuthProofToken(RSACryptoServiceProvider rsa, DateTime expiration)
		: this(expiration)
	{
		m_publicKey = new RSACryptoServiceProvider();
		m_publicKey.ImportCspBlob(rsa.ExportCspBlob(includePrivateParameters: false));
		InitCrypto((SecurityKey)(object)new SelfIssuedAuthAsymmetricKey(rsa));
	}

	public SelfIssuedAuthProofToken(InMemorySymmetricSecurityKey symKey, DateTime expiration)
		: this(expiration)
	{
		m_isSymmetric = true;
		InitCrypto((SecurityKey)(object)symKey);
	}

	private SelfIssuedAuthProofToken(DateTime expiration)
	{
		m_id = Guid.NewGuid().ToString();
		m_expiration = expiration.ToUniversalTime();
	}

	private void InitCrypto(SecurityKey securityKey)
	{
		m_securityKey = securityKey;
		List<SecurityKey> list = new List<SecurityKey>(1);
		list.Add(securityKey);
		m_securityKeys = list.AsReadOnly();
	}

	public override bool CanCreateKeyIdentifierClause<T>()
	{
		return (object)typeof(T) == typeof(RsaKeyIdentifierClause);
	}

	public override T CreateKeyIdentifierClause<T>()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if ((object)typeof(T) == typeof(RsaKeyIdentifierClause))
		{
			return (T)(object)new RsaKeyIdentifierClause((RSA)m_publicKey);
		}
		return ((SecurityToken)this).CreateKeyIdentifierClause<T>();
	}

	public override bool MatchesKeyIdentifierClause(SecurityKeyIdentifierClause keyIdentifierClause)
	{
		RsaKeyIdentifierClause val = (RsaKeyIdentifierClause)(object)((keyIdentifierClause is RsaKeyIdentifierClause) ? keyIdentifierClause : null);
		if (val != null)
		{
			return val.Matches((RSA)m_publicKey);
		}
		return false;
	}

	public void Dispose()
	{
		if (m_securityKey != null && !m_isSymmetric)
		{
			((IDisposable)m_securityKey).Dispose();
			m_securityKey = null;
			m_securityKeys = null;
		}
		if (m_publicKey != null)
		{
			((IDisposable)m_publicKey).Dispose();
			m_publicKey = null;
		}
	}
}
