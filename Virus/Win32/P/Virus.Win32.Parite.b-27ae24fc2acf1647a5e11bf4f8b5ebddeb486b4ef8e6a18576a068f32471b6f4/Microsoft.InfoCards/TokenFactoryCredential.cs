using System;
using System.IO;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal abstract class TokenFactoryCredential : IDisposable
{
	public const int NoCredential = -1;

	private TokenFactoryCredentialType m_type;

	private Uri m_cardId;

	private int m_paramIndex;

	private int m_lcid;

	public int ParameterIndex => m_paramIndex;

	public TokenFactoryCredentialType CredentialType => m_type;

	public int LCID
	{
		get
		{
			return m_lcid;
		}
		set
		{
			m_lcid = value;
		}
	}

	public Uri CardId => m_cardId;

	protected TokenFactoryCredential(TokenFactoryCredentialType type)
	{
		m_type = type;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	public virtual void Dispose(bool disposing)
	{
	}

	public static TokenFactoryCredential CreateFrom(BinaryReader reader, UIAgentRequest request, int lcid)
	{
		TokenFactoryCredential tokenFactoryCredential;
		switch (reader.ReadInt32())
		{
		case -1:
			tokenFactoryCredential = null;
			break;
		default:
			InfoCardTrace.ThrowInvalidArgumentConditional(true, "CredentialType");
			tokenFactoryCredential = null;
			break;
		case 1:
			tokenFactoryCredential = new UserNameTokenFactoryCredential();
			tokenFactoryCredential.Deserialize(reader);
			break;
		case 2:
			tokenFactoryCredential = new SelfIssuedTokenFactoryCredential();
			tokenFactoryCredential.Deserialize(reader);
			break;
		case 3:
			tokenFactoryCredential = new X509CertificateTokenFactoryCredential(request);
			tokenFactoryCredential.Deserialize(reader);
			break;
		case 4:
			tokenFactoryCredential = new KerberosTokenFactoryCredential();
			tokenFactoryCredential.Deserialize(reader);
			break;
		}
		if (tokenFactoryCredential != null)
		{
			tokenFactoryCredential.LCID = lcid;
		}
		return tokenFactoryCredential;
	}

	private void Deserialize(BinaryReader reader)
	{
		m_cardId = new Uri(Utility.DeserializeString(reader));
		m_paramIndex = reader.ReadInt32();
		DeserializeData(reader);
	}

	protected abstract void DeserializeData(BinaryReader reader);
}
