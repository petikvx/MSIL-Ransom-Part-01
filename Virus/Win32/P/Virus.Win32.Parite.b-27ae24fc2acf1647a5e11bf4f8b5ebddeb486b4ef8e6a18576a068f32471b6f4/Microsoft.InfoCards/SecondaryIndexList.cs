using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SecondaryIndexList
{
	private class SearchComparer : IComparer<IntPtr>
	{
		public unsafe int Compare(IntPtr x, IntPtr y)
		{
			if (IntPtr.Zero == x)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("x");
			}
			if (IntPtr.Zero == y)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("y");
			}
			return Compare((SecondaryIndexItem*)(void*)x, (SecondaryIndexItem*)(void*)y);
		}

		public unsafe static int Compare(SecondaryIndexItem obj1, SecondaryIndexItem obj2)
		{
			return Compare(&obj1, &obj2);
		}

		public unsafe static int Compare(SecondaryIndexItem* pObj1, SecondaryIndexItem* pObj2)
		{
			if (null == pObj1)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("pObj1");
			}
			if (null == pObj2)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("pObj2");
			}
			byte* ptr = &pObj1->HashValue;
			byte* ptr2 = &pObj2->HashValue;
			int num = 0;
			int num2;
			while (true)
			{
				if (num < 60)
				{
					num2 = ptr[num] - ptr2[num];
					if (num2 != 0)
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			return num2;
		}
	}

	private class SortComparer : IComparer<IntPtr>
	{
		public unsafe int Compare(IntPtr x, IntPtr y)
		{
			if (IntPtr.Zero == x)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("x");
			}
			if (IntPtr.Zero == y)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("y");
			}
			return Compare((SecondaryIndexItem*)(void*)x, (SecondaryIndexItem*)(void*)y);
		}

		public unsafe static int Compare(SecondaryIndexItem obj1, SecondaryIndexItem obj2)
		{
			return Compare(&obj1, &obj2);
		}

		public unsafe static int Compare(SecondaryIndexItem* pObj1, SecondaryIndexItem* pObj2)
		{
			if (null == pObj1)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("pObj1");
			}
			if (null == pObj2)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("pObj2");
			}
			byte* ptr = &pObj1->HashValue;
			byte* ptr2 = &pObj2->HashValue;
			int num = 0;
			int num2;
			while (true)
			{
				if (num < 60)
				{
					num2 = ptr[num] - ptr2[num];
					if (num2 != 0)
					{
						break;
					}
					num++;
					continue;
				}
				return pObj1->LocalId - pObj2->LocalId;
			}
			return num2;
		}
	}

	private Hashtable m_indexes;

	private bool m_isOpen;

	private IComparer<IntPtr> m_searchComparer;

	private IComparer<IntPtr> m_sortComparer;

	public int Count
	{
		get
		{
			ThrowIfNotOpen();
			return m_indexes.Count;
		}
	}

	internal Hashtable InnerIndexes
	{
		get
		{
			ThrowIfNotOpen();
			return m_indexes;
		}
	}

	public SecondaryIndexList(SecondaryIndexDefinition[] definitions)
	{
		if (definitions != null && definitions.Length != 0)
		{
			m_indexes = new Hashtable(definitions.Length, StringComparer.Create(CultureInfo.InvariantCulture, ignoreCase: false));
			m_sortComparer = new SortComparer();
			m_searchComparer = new SearchComparer();
			for (int i = 0; i < definitions.Length; i++)
			{
				m_indexes.Add(definitions[i].Name, new SecondaryIndex(definitions[i], m_searchComparer, m_sortComparer));
			}
			m_isOpen = true;
			return;
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("definitions");
	}

	public void SetBuffer(string indexId, byte[] buffer, int lastIndex)
	{
		ThrowIfNotOpen();
		if (!m_indexes.ContainsKey(indexId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("indexId", indexId, SR.GetString("StoreIndexNameInvalid")));
		}
		if (buffer != null && buffer.Length != 0)
		{
			if ((uint)lastIndex > (uint)buffer.Length && lastIndex != -1)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("lastIndex", lastIndex, SR.GetString("StoreLastIndexOutOfRange")));
			}
			((SecondaryIndex)m_indexes[indexId]).SetBuffer(buffer, lastIndex);
			return;
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("buffer");
	}

	public void SetValuesForId(int localId, DataRowIndexBuffer indexBuffer, bool remove)
	{
		ThrowIfNotOpen();
		if (localId < 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("localId", localId, SR.GetString("StoreLocalIdOutOfRange")));
		}
		if (indexBuffer == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("indexBuffer");
		}
		PreValidateIndexBuffer(indexBuffer);
		foreach (string key in m_indexes.Keys)
		{
			SecondaryIndex secondaryIndex = (SecondaryIndex)m_indexes[key];
			secondaryIndex.SetValuesForId(localId, indexBuffer, remove);
		}
	}

	public bool Match(QueryParameter match, LocalIdCollection localIds)
	{
		ThrowIfNotOpen();
		if (localIds == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("localIds");
		}
		if (match == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("match");
		}
		if (!m_indexes.ContainsKey(match.IndexName))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("match", match.IndexName, SR.GetString("StoreIndexNameInvalid")));
		}
		SecondaryIndex secondaryIndex = (SecondaryIndex)m_indexes[match.IndexName];
		if (-1 == secondaryIndex.LastIndex)
		{
			return false;
		}
		IndexObject indexObject = null;
		int num = -1;
		bool result = false;
		for (int i = 0; i < match.Count; i++)
		{
			indexObject = match[i];
			num = secondaryIndex.Match(indexObject, localIds, 0, secondaryIndex.LastIndex);
			if (num >= 0)
			{
				result = true;
			}
		}
		return result;
	}

	public void PopulateRowIndexBuffer(DataRow row)
	{
		ThrowIfNotOpen();
		_ = row.IndexBuffer;
		foreach (string key in m_indexes.Keys)
		{
			SecondaryIndex secondaryIndex = (SecondaryIndex)m_indexes[key];
			secondaryIndex.PopulateRowIndexBuffer(row.IndexBuffer, row.LocalId);
		}
	}

	public void RemoveAllValuesForId(int id)
	{
		foreach (string key in m_indexes.Keys)
		{
			RemoveAllValuesForId(key, id);
		}
	}

	public void RemoveAllValuesForId(string indexId, int id)
	{
		ThrowIfNotOpen();
		if (!m_indexes.ContainsKey(indexId))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("indexId", indexId, SR.GetString("StoreIndexNameInvalid")));
		}
		((SecondaryIndex)m_indexes[indexId]).RemoveAllValuesForId(id);
	}

	public void Close()
	{
		if (!m_isOpen)
		{
			return;
		}
		foreach (string key in m_indexes.Keys)
		{
			((SecondaryIndex)m_indexes[key]).Close();
		}
		m_isOpen = false;
	}

	private void PreValidateIndexBuffer(DataRowIndexBuffer buffer)
	{
		foreach (string key in m_indexes.Keys)
		{
			SecondaryIndex secondaryIndex = (SecondaryIndex)m_indexes[key];
			if (SecondaryIndexSettings.Nullable != (secondaryIndex.Definition.Settings & SecondaryIndexSettings.Nullable) && (buffer[key] == null || buffer.GetValueCount(key) == 0))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexValueCanNotBeNull", new object[1] { secondaryIndex.Definition.Name })));
			}
		}
	}

	private void ThrowIfNotOpen()
	{
		if (!m_isOpen)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("SecondaryIndexList"));
		}
	}
}
