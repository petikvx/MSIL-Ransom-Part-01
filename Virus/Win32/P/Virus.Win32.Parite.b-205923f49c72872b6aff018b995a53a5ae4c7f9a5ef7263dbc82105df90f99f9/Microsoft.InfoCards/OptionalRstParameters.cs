using System.ServiceModel.Security;
using System.Xml;

namespace Microsoft.InfoCards;

internal class OptionalRstParameters
{
	private string m_tokenType = string.Empty;

	private string m_signatureAlgorithm;

	private string m_encryptionAlgorithm;

	private string m_canonicalizationAlgorithm;

	private string m_signWith;

	private string m_encryptWith;

	private string m_keyWrapAlgorithm;

	public string SignatureAlgorithm
	{
		get
		{
			return m_signatureAlgorithm;
		}
		set
		{
			m_signatureAlgorithm = value;
		}
	}

	public string EncryptionAlgorithm
	{
		get
		{
			return m_encryptionAlgorithm;
		}
		set
		{
			m_encryptionAlgorithm = value;
		}
	}

	public string SignWith
	{
		get
		{
			return m_signWith;
		}
		set
		{
			m_signWith = value;
		}
	}

	public string EncryptWith
	{
		get
		{
			return m_encryptWith;
		}
		set
		{
			m_encryptWith = value;
		}
	}

	public string CanonicalizationAlgorithm
	{
		get
		{
			return m_canonicalizationAlgorithm;
		}
		set
		{
			m_canonicalizationAlgorithm = value;
		}
	}

	public string KeyWrapAlgorithm
	{
		get
		{
			return m_keyWrapAlgorithm;
		}
		set
		{
			m_keyWrapAlgorithm = value;
		}
	}

	public string TokenType
	{
		get
		{
			return m_tokenType;
		}
		set
		{
			m_tokenType = value;
		}
	}

	public static OptionalRstParameters CreateMergedParameters(OptionalRstParameters primary, OptionalRstParameters secondary)
	{
		OptionalRstParameters optionalRstParameters = new OptionalRstParameters();
		optionalRstParameters.m_canonicalizationAlgorithm = ((!string.IsNullOrEmpty(primary.m_canonicalizationAlgorithm)) ? primary.m_canonicalizationAlgorithm : secondary.m_canonicalizationAlgorithm);
		optionalRstParameters.m_encryptionAlgorithm = ((!string.IsNullOrEmpty(primary.m_encryptionAlgorithm)) ? primary.m_encryptionAlgorithm : secondary.m_encryptionAlgorithm);
		optionalRstParameters.m_encryptWith = ((!string.IsNullOrEmpty(primary.m_encryptWith)) ? primary.m_encryptWith : secondary.m_encryptWith);
		if (string.IsNullOrEmpty(primary.m_keyWrapAlgorithm) && string.IsNullOrEmpty(secondary.m_keyWrapAlgorithm))
		{
			optionalRstParameters.m_keyWrapAlgorithm = SecurityAlgorithmSuite.get_Default().get_DefaultAsymmetricKeyWrapAlgorithm();
		}
		else
		{
			optionalRstParameters.m_keyWrapAlgorithm = ((!string.IsNullOrEmpty(primary.m_keyWrapAlgorithm)) ? primary.m_keyWrapAlgorithm : secondary.m_keyWrapAlgorithm);
		}
		optionalRstParameters.m_signatureAlgorithm = ((!string.IsNullOrEmpty(primary.m_signatureAlgorithm)) ? primary.m_signatureAlgorithm : secondary.m_signatureAlgorithm);
		optionalRstParameters.m_signWith = ((!string.IsNullOrEmpty(primary.m_signWith)) ? primary.m_signWith : secondary.m_signWith);
		optionalRstParameters.m_tokenType = ((!string.IsNullOrEmpty(primary.m_tokenType)) ? primary.m_tokenType : secondary.m_tokenType);
		return optionalRstParameters;
	}

	public void WritePassOnElements(XmlDictionaryWriter writer, ProtocolProfile profile)
	{
		string defaultPrefix = profile.WSTrust.DefaultPrefix;
		if (!string.IsNullOrEmpty(TokenType))
		{
			((XmlWriter)(object)writer).WriteStartElement(defaultPrefix, profile.WSTrust.TokenType, profile.WSTrust.Namespace);
			((XmlWriter)(object)writer).WriteString(TokenType);
			((XmlWriter)(object)writer).WriteEndElement();
		}
		if (!string.IsNullOrEmpty(SignatureAlgorithm))
		{
			((XmlWriter)(object)writer).WriteStartElement(defaultPrefix, profile.WSTrust.SignatureAlgorithm, profile.WSTrust.Namespace);
			((XmlWriter)(object)writer).WriteString(SignatureAlgorithm);
			((XmlWriter)(object)writer).WriteEndElement();
		}
		if (!string.IsNullOrEmpty(CanonicalizationAlgorithm))
		{
			((XmlWriter)(object)writer).WriteStartElement(defaultPrefix, profile.WSTrust.CanonicalizationAlgorithm, profile.WSTrust.Namespace);
			((XmlWriter)(object)writer).WriteString(CanonicalizationAlgorithm);
			((XmlWriter)(object)writer).WriteEndElement();
		}
	}
}
