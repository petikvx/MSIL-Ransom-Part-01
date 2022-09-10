using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

namespace Microsoft.InfoCards;

internal class TokenDescriptor : IDisposable
{
	private string m_tokenId;

	private DateTime m_effectiveTime;

	private DateTime m_expirationTime;

	private XmlElement m_protectedToken;

	private DisplayToken m_displayToken;

	private SymmetricAlgorithm m_symmetricProof;

	private string m_internalTokenReference;

	private string m_externalTokenReference;

	private List<string> m_disclosedClaims;

	private bool m_disposed;

	private object m_sync;

	public ReadOnlyCollection<string> DisclosedClaims => m_disclosedClaims.AsReadOnly();

	public string TokenId => m_tokenId;

	public DateTime EffectiveTime => m_effectiveTime;

	public DateTime ExpirationTime => m_expirationTime;

	public string InternalTokenReference => m_internalTokenReference;

	public string ExternalTokenReference => m_externalTokenReference;

	public XmlElement ProtectedToken => m_protectedToken;

	public DisplayToken DisplayToken => m_displayToken;

	public SymmetricAlgorithm SymmetricProof => m_symmetricProof;

	public TokenDescriptor(string tokenId, DateTime effectiveTime, DateTime expirationTime, XmlElement protectedToken, DisplayToken displayToken, SymmetricAlgorithm symmetricProof, string internalTokenReference, string externalTokenReference, IEnumerable<string> disclosedClaims)
	{
		m_sync = new object();
		m_tokenId = tokenId;
		m_effectiveTime = effectiveTime;
		m_expirationTime = expirationTime;
		m_protectedToken = protectedToken;
		m_displayToken = displayToken;
		m_symmetricProof = symmetricProof;
		m_internalTokenReference = internalTokenReference;
		m_externalTokenReference = externalTokenReference;
		m_disclosedClaims = new List<string>(disclosedClaims);
	}

	public void Write(BinaryWriter bwriter)
	{
		bwriter.Write(m_effectiveTime.ToFileTimeUtc());
		bwriter.Write(m_expirationTime.ToFileTimeUtc());
		Utility.SerializeString(bwriter, m_protectedToken.OuterXml);
		Utility.SerializeString(bwriter, m_internalTokenReference);
		Utility.SerializeString(bwriter, m_externalTokenReference);
	}

	public void Dispose()
	{
		if (m_disposed)
		{
			return;
		}
		lock (m_sync)
		{
			if (!m_disposed)
			{
				m_disposed = true;
				if (m_symmetricProof != null)
				{
					((IDisposable)m_symmetricProof).Dispose();
					m_symmetricProof = null;
				}
				m_protectedToken = null;
				m_expirationTime = DateTime.MinValue;
				m_effectiveTime = DateTime.MinValue;
				m_tokenId = null;
				m_externalTokenReference = null;
				m_internalTokenReference = null;
				m_disclosedClaims = null;
				m_displayToken = null;
			}
		}
	}
}
