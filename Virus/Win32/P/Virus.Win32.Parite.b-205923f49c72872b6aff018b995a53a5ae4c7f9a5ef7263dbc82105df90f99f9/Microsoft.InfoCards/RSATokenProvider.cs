using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class RSATokenProvider : SecurityTokenProvider, IDisposable
{
	private InfoCardPolicy m_policy;

	private InfoCard m_card;

	private SelfIssuedAuthProofToken m_RSAToken;

	public RSATokenProvider(InfoCardPolicy policy, InfoCard card)
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == policy, "policy");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == card, "card");
		m_policy = policy;
		m_card = card;
	}

	public void Dispose()
	{
		if (m_RSAToken != null)
		{
			m_RSAToken.Dispose();
			m_RSAToken = null;
		}
	}

	protected override SecurityToken GetTokenCore(TimeSpan timeout)
	{
		if (m_RSAToken == null)
		{
			m_RSAToken = new SelfIssuedAuthProofToken(m_card.GetPrivateCryptography(m_policy.Recipient.GetIdentifier()), DateTime.UtcNow + timeout);
		}
		return (SecurityToken)(object)m_RSAToken;
	}
}
