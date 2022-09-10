using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class LedgerEntryCollection : Dictionary<string, LedgerEntry>
{
	private Uri m_infoCardId;

	private LedgerEntryCollection()
	{
	}

	public void Add(LedgerEntry entry)
	{
		base[entry.Recipient.RecipientId] = entry;
	}

	public LedgerEntryCollection(Uri infoCardId)
	{
		m_infoCardId = infoCardId;
	}

	public void Get(StoreConnection con)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "The infocard id must be specified prior to executing this operation", new object[0]);
		ICollection<DataRow> collection = con.Query(QueryDetails.FullRow, new QueryParameter("ix_objecttype", -1), new QueryParameter("ix_parentid", GlobalId.DeriveFrom(m_infoCardId.ToString())));
		if (collection == null || collection.Count <= 0)
		{
			return;
		}
		foreach (DataRow item in (List<DataRow>)collection)
		{
			LedgerEntry ledgerEntry = new LedgerEntry(new MemoryStream(item.GetDataField()), con);
			base[ledgerEntry.Recipient.RecipientId] = ledgerEntry;
		}
	}

	public void Serialize(Stream stream)
	{
		BinaryWriter binaryWriter = new BinaryWriter(stream, Encoding.Unicode);
		binaryWriter.Write(base.Count);
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.Serialize(binaryWriter);
		}
	}

	public void Save(StoreConnection con)
	{
		InfoCardTrace.Assert(null != m_infoCardId, "The infocard id must be specified prior to executing this operation", new object[0]);
		using Enumerator enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			LedgerEntry value = enumerator.Current.Value;
			if (value.IsDirty)
			{
				value.Save(con);
			}
		}
	}
}
