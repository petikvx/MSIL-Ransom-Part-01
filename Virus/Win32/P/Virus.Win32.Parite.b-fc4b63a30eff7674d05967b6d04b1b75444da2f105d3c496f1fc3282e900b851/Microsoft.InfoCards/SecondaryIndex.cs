using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SecondaryIndex
{
	private byte[] m_buffer;

	private int m_lastIndex;

	private IComparer<IntPtr> m_searchComparer;

	private IComparer<IntPtr> m_sortComparer;

	private SecondaryIndexDefinition m_definition;

	private bool m_isOpen;

	public SecondaryIndexDefinition Definition
	{
		get
		{
			ThrowIfNotOpen();
			return m_definition;
		}
	}

	public int LastIndex
	{
		get
		{
			ThrowIfNotOpen();
			return m_lastIndex;
		}
	}

	public SecondaryIndex(SecondaryIndexDefinition definition, IComparer<IntPtr> search, IComparer<IntPtr> sort)
	{
		if (definition == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("definition");
		}
		if (search == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("search");
		}
		if (sort == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("sort");
		}
		m_definition = definition;
		m_searchComparer = search;
		m_sortComparer = sort;
		Clear();
		m_isOpen = true;
	}

	public byte[] GetBuffer()
	{
		ThrowIfNotOpen();
		return m_buffer;
	}

	internal void SetValuesForId(int id, DataRowIndexBuffer indexBuffer, bool remove)
	{
		ThrowIfNotOpen();
		if (id <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", SR.GetString("StoreLocalIdOutOfRange")));
		}
		IndexObject[] array = indexBuffer[m_definition.Name].ToArray();
		if (remove)
		{
			RemoveForIdAndShiftData(id);
		}
		if (array == null || array.Length == 0)
		{
			return;
		}
		int num = 0;
		while (true)
		{
			if (num >= array.Length)
			{
				return;
			}
			if (!array[num].IsCompiled)
			{
				if (!array[num].CanCompile)
				{
					break;
				}
				array[num].Compile(m_definition);
			}
			ValidateIndexValue(array[num].CompiledForm);
			ShiftAndInsertValues(id, array[num].CompiledForm);
			num++;
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexObjectCanNotBeCompiled")));
	}

	public void RemoveAllValuesForId(int id)
	{
		ThrowIfNotOpen();
		if (id <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", SR.GetString("StoreLocalIdOutOfRange")));
		}
		RemoveForIdAndShiftData(id);
	}

	public unsafe void PopulateRowIndexBuffer(DataRowIndexBuffer buffer, int id)
	{
		ThrowIfNotOpen();
		if (id <= 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", SR.GetString("StoreLocalIdOutOfRange")));
		}
		if (-1 == m_lastIndex)
		{
			return;
		}
		List<IndexObject> list = new List<IndexObject>();
		fixed (byte* ptr = &m_buffer[0])
		{
			SecondaryIndexItem* ptr2 = (SecondaryIndexItem*)ptr;
			for (int i = 0; i < m_lastIndex + 1; i++)
			{
				if (ptr2[i].LocalId == id)
				{
					byte[] array = new byte[60];
					Marshal.Copy((IntPtr)(&ptr2[i].HashValue), array, 0, 60);
					list.Add(new IndexObject(array));
				}
			}
			if (list.Count > 0)
			{
				buffer.SetIndexValues(m_definition.Name, list.ToArray());
			}
		}
	}

	public void Close()
	{
		if (m_isOpen)
		{
			Clear();
			m_buffer = null;
			m_isOpen = false;
		}
	}

	public void ValidateIndexValue(byte[] indexValue)
	{
		if (SecondaryIndexSettings.Nullable != (m_definition.Settings & SecondaryIndexSettings.Nullable) && IsBufferEmpty(indexValue))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreNullIndexValueNotPermitted", new object[1] { m_definition.Name })));
		}
	}

	public void SetBuffer(byte[] buffer, int lastIndex)
	{
		ThrowIfNotOpen();
		m_buffer = buffer;
		m_lastIndex = lastIndex;
	}

	public unsafe int Match(IndexObject obj, LocalIdCollection collection, int low, int high)
	{
		if (obj == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("obj");
		}
		if (collection == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("collection");
		}
		if ((uint)low > (uint)high)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("low", low, SR.GetString("StoreLowValueOutOfRange")));
		}
		if ((uint)high > (uint)m_lastIndex)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("high", high, SR.GetString("StoreHighValueOutOfRange")));
		}
		if (!obj.IsCompiled)
		{
			if (!obj.CanCompile)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreIndexObjectCanNotBeCompiled")));
			}
			obj.Compile(m_definition);
		}
		ValidateIndexValue(obj.CompiledForm);
		SecondaryIndexItem secondaryIndexItem = default(SecondaryIndexItem);
		Marshal.Copy(obj.CompiledForm, 0, (IntPtr)(&secondaryIndexItem.HashValue), 60);
		return Match(&secondaryIndexItem, collection, low, high);
	}

	public unsafe void Clear()
	{
		m_buffer = new byte[sizeof(SecondaryIndexItem) * m_definition.InitialSize];
		m_lastIndex = -1;
	}

	private unsafe void RemoveForIdAndShiftData(int id)
	{
		if (-1 == m_lastIndex)
		{
			return;
		}
		int num = m_lastIndex + 1;
		int num2 = 0;
		int num3 = 0;
		fixed (byte* ptr = &m_buffer[0])
		{
			SecondaryIndexItem* ptr2 = (SecondaryIndexItem*)ptr;
			do
			{
				InfoCardTrace.Assert((uint)num2 < (uint)m_buffer.Length, "currentOffset is invalid or has been corrupted.", new object[0]);
				InfoCardTrace.Assert(0 == num2 % sizeof(SecondaryIndexItem), "currentOffset is not aligned proppertly.  This can cause data corruption.", new object[0]);
				InfoCardTrace.Assert(ptr2 + num3 - ptr2 <= num * sizeof(SecondaryIndexItem), "Current IndexPointer has walked beyond the total count of valid data.", new object[0]);
				num3 = num2 / sizeof(SecondaryIndexItem);
				InfoCardTrace.Assert(ptr2 + num3 - ptr2 < m_buffer.Length, "Current IndexPointer has walked beyond the allocated buffer", new object[0]);
				if (ptr2[num3].LocalId != id)
				{
					num2 += sizeof(SecondaryIndexItem);
					continue;
				}
				if (num != num3 + 1)
				{
					InfoCardTrace.Assert(m_lastIndex >= 0, "LastIndex indicates an invalid state for the index", new object[0]);
					Array.Copy(m_buffer, num2 + sizeof(SecondaryIndexItem), m_buffer, num2, (num - (num3 + 1)) * sizeof(SecondaryIndexItem));
					Array.Clear(m_buffer, m_lastIndex * sizeof(SecondaryIndexItem), sizeof(SecondaryIndexItem));
				}
				else
				{
					Array.Clear(m_buffer, num2, sizeof(SecondaryIndexItem));
				}
				m_lastIndex--;
				num--;
			}
			while (num2 / sizeof(SecondaryIndexItem) < num);
		}
	}

	private unsafe void ShiftAndInsertValues(int id, byte[] indexValue)
	{
		InfoCardTrace.Assert(id > 0, "Invalid LocalId", new object[0]);
		InfoCardTrace.Assert(null != indexValue, "Null indev value passed", new object[0]);
		InfoCardTrace.Assert(indexValue.Length == 60, "Index buffer is not correct size.", new object[0]);
		SecondaryIndexItem secondaryIndexItem = default(SecondaryIndexItem);
		secondaryIndexItem.LocalId = id;
		Marshal.Copy(indexValue, 0, (IntPtr)(&secondaryIndexItem.HashValue), 60);
		AddItem(&secondaryIndexItem);
	}

	private static bool IsBufferEmpty(byte[] hash)
	{
		int num = 0;
		while (true)
		{
			if (num < hash.Length)
			{
				if (hash[num] != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private unsafe int BSearch(SecondaryIndexItem* pMatch, IComparer<IntPtr> comp, int lowStart, int highStart)
	{
		int num = lowStart;
		int num2 = highStart;
		fixed (byte* ptr = &m_buffer[0])
		{
			SecondaryIndexItem* ptr2 = (SecondaryIndexItem*)ptr;
			while (num <= num2)
			{
				int num3 = (num2 + num) / 2;
				int num4 = comp.Compare((IntPtr)pMatch, (IntPtr)(ptr2 + num3));
				if (num4 == 0)
				{
					num2 = num3;
					if (num2 == num)
					{
						return num2;
					}
				}
				else if (num4 < 0)
				{
					num2 = num3 - 1;
				}
				else
				{
					num = num3 + 1;
				}
			}
		}
		return ~num;
	}

	private unsafe int Match(SecondaryIndexItem* pMatch, LocalIdCollection results, int lowStart, int highStart)
	{
		int num = BSearch(pMatch, m_searchComparer, lowStart, highStart);
		if (num >= 0)
		{
			fixed (byte* ptr = &m_buffer[0])
			{
				SecondaryIndexItem* ptr2 = (SecondaryIndexItem*)ptr;
				InfoCardTrace.Assert(num * sizeof(SecondaryIndexItem) < m_buffer.Length, "Index has moved beyond the allocated buffer.", new object[0]);
				do
				{
					results.Add(ptr2[num].LocalId);
					num++;
				}
				while (num <= m_lastIndex && m_searchComparer.Compare((IntPtr)(ptr2 + num), (IntPtr)pMatch) == 0);
			}
			num--;
		}
		return num;
	}

	private unsafe void AddItem(SecondaryIndexItem* pMatch)
	{
		int num = 0;
		InfoCardTrace.Assert(null != pMatch, "Match pointer is null", new object[0]);
		InfoCardTrace.Assert(pMatch->LocalId > 0, "Match pointer has invalid local id", new object[0]);
		if (SecondaryIndexSettings.Unique == (m_definition.Settings & SecondaryIndexSettings.Unique))
		{
			num = BSearch(pMatch, m_searchComparer, 0, m_lastIndex);
			if (num >= 0)
			{
				throw InfoCardTrace.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("StoreUniqueIndexConstraintBroken", new object[1] { m_definition.Name })));
			}
		}
		else
		{
			num = BSearch(pMatch, m_sortComparer, 0, m_lastIndex);
		}
		if (num < 0)
		{
			num = ~num;
			int num2 = m_lastIndex + 1;
			int num3 = m_buffer.Length / sizeof(SecondaryIndexItem);
			if (num2 + 1 >= num3)
			{
				GrowIndex();
			}
			if (num < num2)
			{
				int num4 = num2 * sizeof(SecondaryIndexItem);
				int num5 = num * sizeof(SecondaryIndexItem);
				int destinationIndex = num5 + sizeof(SecondaryIndexItem);
				int num6 = num4 - num5;
				InfoCardTrace.Assert(num6 > 0, "No Bytes to copy into index.", new object[0]);
				Array.Copy(m_buffer, num5, m_buffer, destinationIndex, num6);
			}
			fixed (byte* ptr = &m_buffer[0])
			{
				SecondaryIndexItem* ptr2 = (SecondaryIndexItem*)ptr;
				InfoCardTrace.Assert(ptr2 + num - ptr2 < m_buffer.Length, "IndexPointer is beyond the end of the allocated buffer", new object[0]);
				ptr2[num] = *pMatch;
			}
			m_lastIndex++;
		}
	}

	private unsafe void GrowIndex()
	{
		int num = Utility.CalculateIncreaseByPercent(m_buffer.Length, sizeof(SecondaryIndexItem), 5);
		InfoCardTrace.Assert(num > m_buffer.Length && 0 == num % sizeof(SecondaryIndexItem), "New size calculated for index is invalid.", new object[0]);
		int length = (m_lastIndex + 1) * sizeof(SecondaryIndexItem);
		byte[] array = new byte[num];
		Array.Copy(m_buffer, 0, array, 0, length);
		Array.Clear(m_buffer, 0, length);
		m_buffer = array;
	}

	private void ThrowIfNotOpen()
	{
		if (!m_isOpen)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("SecondaryIndex"));
		}
	}
}
