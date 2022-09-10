using System;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class LedgerEntry
{
	private const int InvalidRow = 0;

	private const byte Version = 1;

	private const byte m_marker = 29;

	private bool m_isDirty;

	private DateTime m_disclosureDate = DateTime.MinValue;

	private string m_recipientId;

	private Recipient m_recipient;

	private byte[] m_subjectKey;

	private string[] m_disclosedClaims;

	private Uri m_infoCardId;

	private string m_immediateRecipientOrgId;

	private int m_rowId;

	public bool IsDirty => m_isDirty;

	public DateTime DisclosureDate
	{
		set
		{
			m_disclosureDate = value;
			m_isDirty = true;
		}
	}

	public byte[] SubjectKey
	{
		get
		{
			InfoCardTrace.Assert(!Utility.ArrayIsNullOrEmpty(m_subjectKey), "SubjectKey not populated!", new object[0]);
			return m_subjectKey;
		}
	}

	public string[] DisclosedClaims
	{
		get
		{
			return m_disclosedClaims;
		}
		set
		{
			m_disclosedClaims = value;
			m_isDirty = true;
		}
	}

	public Recipient Recipient => m_recipient;

	public Uri InfoCardId => m_infoCardId;

	public LedgerEntry(Stream stream, StoreConnection connection)
	{
		InfoCardTrace.Assert(null != stream, " Null input stream", new object[0]);
		InfoCardTrace.Assert(null != connection, "Null storeconnection", new object[0]);
		m_isDirty = false;
		Deserialize(stream);
		DataRow singleRow = connection.GetSingleRow(new QueryParameter("ix_objecttype", -3), new QueryParameter("ix_name", m_recipientId));
		InfoCardTrace.Assert(null != singleRow, "Recipient should always exist in store before a ledger entry is created ", new object[0]);
		if (singleRow != null)
		{
			m_recipient = new Recipient(new MemoryStream(singleRow.GetDataField()));
		}
		ThrowIfNotComplete();
	}

	public static LedgerEntry NewLedgerEntry(Uri infoCardId, Recipient recipient, byte[] masterKey, string immediateTokenRecipientOrganizationIdentifier)
	{
		return new LedgerEntry(infoCardId, recipient, masterKey, immediateTokenRecipientOrganizationIdentifier);
	}

	public LedgerEntry(Uri infoCardId, Recipient recipient, byte[] masterKey, string immediateTokenRecipientOrganizationIdentifier)
	{
		InfoCardTrace.Assert(null != recipient, "Null recipient", new object[0]);
		InfoCardTrace.Assert(null != infoCardId, "Null infocard ID", new object[0]);
		m_isDirty = true;
		m_infoCardId = infoCardId;
		m_disclosureDate = DateTime.Now;
		m_recipient = recipient;
		m_recipientId = recipient.RecipientId;
		m_immediateRecipientOrgId = immediateTokenRecipientOrganizationIdentifier;
		m_subjectKey = RsaKeyGen.CreateRsaKeyPairX931(masterKey, Convert.FromBase64String(immediateTokenRecipientOrganizationIdentifier));
		ThrowIfNotComplete();
	}

	public bool CheckAndUpdateSubjectKey(string immediateTokenRecipientOrgId, byte[] masterKey)
	{
		if (m_immediateRecipientOrgId != immediateTokenRecipientOrgId)
		{
			m_immediateRecipientOrgId = immediateTokenRecipientOrgId;
			m_subjectKey = RsaKeyGen.CreateRsaKeyPairX931(masterKey, Convert.FromBase64String(immediateTokenRecipientOrgId));
			return true;
		}
		return false;
	}

	public void ThrowIfNotComplete()
	{
		if (m_immediateRecipientOrgId == null || m_recipientId == null || Utility.ArrayIsNullOrEmpty(m_subjectKey) || !(null != m_infoCardId) || !(DateTime.MinValue != m_disclosureDate))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SerializationIncompleteException(GetType()));
		}
	}

	public void Serialize(BinaryWriter writer)
	{
		ThrowIfNotComplete();
		writer.Write((byte)1);
		writer.Write(m_disclosureDate.ToFileTimeUtc());
		Utility.SerializeString(writer, m_recipientId);
		Utility.SerializeString(writer, m_immediateRecipientOrgId);
		Utility.SerializeBytes(writer, m_subjectKey);
		Utility.SerializeUri(writer, m_infoCardId);
		writer.Write((m_disclosedClaims != null) ? m_disclosedClaims.Length : 0);
		if (m_disclosedClaims != null)
		{
			string[] disclosedClaims = m_disclosedClaims;
			foreach (string str in disclosedClaims)
			{
				Utility.SerializeString(writer, str);
			}
		}
		writer.Write((byte)29);
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		if (1 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "version mismatch deserializing ledger", new object[0]);
		}
		m_disclosureDate = DateTime.FromFileTimeUtc(binaryReader.ReadInt64());
		m_recipientId = Utility.DeserializeString(binaryReader);
		m_immediateRecipientOrgId = Utility.DeserializeString(binaryReader);
		m_subjectKey = binaryReader.ReadBytes(binaryReader.ReadInt32());
		m_infoCardId = Utility.DeserializeUri(binaryReader);
		int num = binaryReader.ReadInt32();
		if (num > 0)
		{
			m_disclosedClaims = new string[num];
			for (int i = 0; i < num; i++)
			{
				m_disclosedClaims[i] = Utility.DeserializeString(binaryReader);
			}
		}
		if (29 != binaryReader.ReadByte())
		{
			InfoCardTrace.Assert(false, "Invalid stream detected deserializing ledger", new object[0]);
		}
		ThrowIfNotComplete();
		m_isDirty = false;
	}

	public void Save(StoreConnection con)
	{
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = -1;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString()));
		dataRow.SetIndexValue("ix_name", m_recipientId);
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter writer = new BinaryWriter(memoryStream, Encoding.Unicode);
		Serialize(writer);
		dataRow.SetDataField(memoryStream.ToArray());
		con.GetSingleRow(QueryDetails.FullHeader, new QueryParameter("ix_objecttype", -3), new QueryParameter("ix_name", m_recipientId));
		if (dataRow != null)
		{
			con.Save(dataRow);
		}
		else
		{
			InfoCardTrace.Assert(false, "Currupt store - no recipient found for ledger", new object[0]);
		}
		m_rowId = dataRow.LocalId;
		m_isDirty = false;
	}

	public override string ToString()
	{
		return base.ToString();
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "populate infocard before retrieving ledger", new object[0]);
		return con.GetSingleRow(QueryDetails.FullHeader, new QueryParameter("ix_objecttype", -1), new QueryParameter("ix_name", m_recipientId), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
	}
}
