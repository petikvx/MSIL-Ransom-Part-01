using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardClaim
{
	private string m_id;

	private string m_claimValue;

	private string m_displayTag;

	private string m_description;

	public string Id => m_id;

	public string Value
	{
		get
		{
			return m_claimValue;
		}
		set
		{
			m_claimValue = value;
		}
	}

	public string DisplayTag => m_displayTag;

	public string Description => m_description;

	public InfoCardClaim()
	{
	}

	public InfoCardClaim(string id, string value)
		: this(id, value, null, null)
	{
	}

	public InfoCardClaim(string id, string value, string description, string displaytag)
	{
		if (string.IsNullOrEmpty(id))
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("id");
		}
		m_id = id;
		m_claimValue = value;
		m_displayTag = displaytag;
		m_description = description;
	}

	public override string ToString()
	{
		return m_claimValue;
	}

	public void ThrowIfNotComplete()
	{
		if (string.IsNullOrEmpty(m_id))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		ThrowIfNotComplete();
		if (writer == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("writer");
		}
		Utility.SerializeString(writer, m_id);
		Utility.SerializeString(writer, m_displayTag);
		Utility.SerializeString(writer, m_description);
		Utility.SerializeString(writer, m_claimValue);
	}

	public void DeSerialize(BinaryReader reader)
	{
		m_id = Utility.DeserializeString(reader);
		m_displayTag = Utility.DeserializeString(reader);
		m_description = Utility.DeserializeString(reader);
		m_claimValue = Utility.DeserializeString(reader);
	}

	public void Encrypt(PinProtectionHelper pinHelper)
	{
		UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
		byte[] bytes = unicodeEncoding.GetBytes(m_claimValue);
		m_claimValue = Convert.ToBase64String(pinHelper.Encrypt(bytes));
	}

	public void Decrypt(PinProtectionHelper pinHelper)
	{
		UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
		byte[] encrypted = Convert.FromBase64String(m_claimValue);
		m_claimValue = unicodeEncoding.GetString(pinHelper.Decrypt(encrypted));
	}

	public InfoCardClaim Clone()
	{
		return new InfoCardClaim((string)m_id.Clone(), string.IsNullOrEmpty(m_claimValue) ? null : ((string)m_claimValue.Clone()), string.IsNullOrEmpty(m_description) ? null : ((string)m_description.Clone()), string.IsNullOrEmpty(m_displayTag) ? null : ((string)m_displayTag.Clone()));
	}
}
