using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardClaimCollection : Dictionary<string, InfoCardClaim>
{
	private const int InvalidRow = 0;

	private Uri m_infoCardId;

	private int m_rowId;

	private InfoCardClaimCollection()
	{
	}

	public InfoCardClaimCollection(Uri infoCardId)
		: this()
	{
		if (null == infoCardId)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("infoCardId");
		}
		m_infoCardId = infoCardId;
	}

	public void Add(InfoCardClaim claim)
	{
		if (claim == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("claim");
		}
		base[claim.Id] = claim;
	}

	public void Get(StoreConnection con)
	{
		if (con == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("con");
		}
		DataRow dataRow = TryGetRow(con, QueryDetails.FullRow);
		if (dataRow != null)
		{
			Deserialize(new MemoryStream(dataRow.GetDataField()));
			m_rowId = dataRow.LocalId;
		}
	}

	public void Serialize(Stream stream, bool selfIssued)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		int num = base.Count;
		if (selfIssued && ContainsKey(InfoCardConstants.PPIDClaimsUri))
		{
			num--;
		}
		binaryWriter.Write(num);
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, InfoCardClaim> current = enumerator.Current;
			if (selfIssued)
			{
				if (InfoCardConstants.PPIDClaimsUri != current.Key)
				{
					current.Value.Serialize(binaryWriter);
				}
			}
			else
			{
				current.Value.Serialize(binaryWriter);
			}
		}
	}

	public void AgentSerialize(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write(base.Count);
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Serialize(binaryWriter);
		}
	}

	public void Deserialize(Stream stream)
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(stream, Encoding.Unicode);
		int num = binaryReader.ReadInt32();
		for (int i = 0; i < num; i++)
		{
			InfoCardClaim infoCardClaim = new InfoCardClaim();
			infoCardClaim.DeSerialize(binaryReader);
			base[infoCardClaim.Id] = infoCardClaim;
		}
	}

	public void Save(StoreConnection con, bool selfIssued)
	{
		if (con == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("con");
		}
		DataRow dataRow = TryGetRow(con, QueryDetails.FullHeader);
		if (dataRow == null)
		{
			dataRow = new DataRow();
			dataRow.ObjectType = 2;
			dataRow.GlobalId = Guid.NewGuid();
		}
		dataRow.SetIndexValue("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString()));
		MemoryStream memoryStream = new MemoryStream();
		Serialize(memoryStream, selfIssued);
		dataRow.SetDataField(memoryStream.ToArray());
		con.Save(dataRow);
		m_rowId = dataRow.LocalId;
	}

	public void Encrypt(PinProtectionHelper pinHelper)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, InfoCardClaim> current = enumerator.Current;
			if (current.Value.Value.Length > 0)
			{
				current.Value.Encrypt(pinHelper);
			}
		}
	}

	public void Decrypt(PinProtectionHelper pinHelper)
	{
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, InfoCardClaim> current = enumerator.Current;
			if (current.Value.Value.Length <= 0)
			{
				continue;
			}
			current.Value.Decrypt(pinHelper);
			if (string.IsNullOrEmpty(current.Value.Value))
			{
				continue;
			}
			if (!(InfoCardConstants.Gender == current.Key) || "0" == current.Value.Value || "1" == current.Value.Value || "2" == current.Value.Value)
			{
				if (!(InfoCardConstants.DateOfBirth == current.Key))
				{
					continue;
				}
				try
				{
					XmlConvert.ToDateTime(current.Value.Value, XmlDateTimeSerializationMode.Utc);
				}
				catch (Exception ex)
				{
					if (InfoCardTrace.IsFatal(ex))
					{
						throw;
					}
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidEncryptedClaimValues")));
				}
				continue;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceInvalidEncryptedClaimValues")));
		}
	}

	public InfoCardClaimCollection Clone()
	{
		InfoCardClaimCollection infoCardClaimCollection = new InfoCardClaimCollection(new Uri(m_infoCardId.OriginalString));
		infoCardClaimCollection.m_rowId = m_rowId;
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, InfoCardClaim> current = enumerator.Current;
			infoCardClaimCollection[(string)current.Key.Clone()] = current.Value.Clone();
		}
		return infoCardClaimCollection;
	}

	protected DataRow TryGetRow(StoreConnection con, QueryDetails details)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "null infocard id", new object[0]);
		return con.GetSingleRow(details, new QueryParameter("ix_objecttype", 2), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
	}
}
