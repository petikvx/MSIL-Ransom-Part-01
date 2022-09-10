using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class IndexedDataBuffer
{
	private byte[] m_buffer;

	private byte[] m_masterIndex;

	private FreeIndexList m_freeList;

	private int m_dataLength;

	private bool m_isOpen;

	private DataSource m_owner;

	public byte[] Index
	{
		get
		{
			ThrowIfNotOpen();
			return m_masterIndex;
		}
	}

	public byte[] Data
	{
		get
		{
			ThrowIfNotOpen();
			return m_buffer;
		}
	}

	public int DataLength
	{
		get
		{
			ThrowIfNotOpen();
			return m_dataLength;
		}
	}

	public unsafe IndexedDataBuffer(byte[] masterIndex, byte[] buffer, int dataLength, DataSource owner)
	{
		if (masterIndex != null && masterIndex.Length != 0)
		{
			if (buffer != null && buffer.Length != 0)
			{
				if (dataLength >= 0 && dataLength <= buffer.Length)
				{
					m_owner = owner;
					m_masterIndex = masterIndex;
					m_buffer = buffer;
					m_dataLength = dataLength;
					m_freeList = new FreeIndexList(20);
					fixed (byte* ptr = &m_masterIndex[0])
					{
						int* ptr2 = (int*)ptr;
						for (int i = 1; i < m_masterIndex.Length / 4; i++)
						{
							if (ptr2[i] <= 0)
							{
								m_freeList.Put(i);
							}
						}
					}
					m_isOpen = true;
					return;
				}
				throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("dataLength", dataLength, SR.GetString("StoreIndexDataBufferDataLengthOutOfRange")));
			}
			throw InfoCardTrace.ThrowHelperArgumentNull("buffer", SR.GetString("StoreIndexedDataBufferNullOrEmptyDataIndexBuffer"));
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("masterIndex", SR.GetString("StoreIndexedDataBufferNullOrEmptyMasterIndexBuffer"));
	}

	public void Close()
	{
		ThrowIfNotOpen();
		Clear();
		m_buffer = null;
		m_masterIndex = null;
		m_isOpen = false;
	}

	public unsafe DataRow CreateDataRow(int id)
	{
		ThrowIfNotOpen();
		if (id <= m_masterIndex.Length / 4 && !m_freeList.Contains(id))
		{
			int offset = GetOffset(ref id);
			fixed (byte* pHeader = &m_buffer[offset])
			{
				return DataRow.Create((EncryptedObjectHeader*)pHeader, m_owner);
			}
		}
		throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
	}

	public unsafe void CopyIVFromObject(int id, byte[] iv, int index)
	{
		ThrowIfNotOpen();
		if (iv != null && iv.Length != 0)
		{
			if (index >= 0 && index <= DataLength - iv.Length)
			{
				if (id > m_masterIndex.Length / 4 || m_freeList.Contains(id))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
				}
				int offset = GetOffset(ref id);
				InfoCardTrace.Assert(id >= 0, "Invalid ID was returned by GetOffset.", new object[0]);
				fixed (byte* ptr = &m_buffer[offset])
				{
					EncryptedObjectHeader* ptr2 = (EncryptedObjectHeader*)ptr;
					Marshal.Copy(new IntPtr(&ptr2->IV), iv, 0, iv.Length);
				}
				return;
			}
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("index", index, SR.GetString("StoreIndexDataBufferIndexOutOfRange")));
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("iv");
	}

	public unsafe Stream GetStreamForObjectData(int id)
	{
		ThrowIfNotOpen();
		if (id > m_masterIndex.Length / 4 || m_freeList.Contains(id))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
		}
		int offset = GetOffset(ref id);
		InfoCardTrace.Assert(id >= 0, "Invalid ID was returned by GetOffset.", new object[0]);
		int objectDataSize = GetObjectDataSize(offset);
		InfoCardTrace.Assert(objectDataSize <= m_buffer.Length - offset, "The length the stored object is invalid", new object[0]);
		return new MemoryStream(m_buffer, offset + sizeof(EncryptedObjectHeader), objectDataSize, writable: false, publiclyVisible: false);
	}

	public void RemoveObject(int id)
	{
		ThrowIfNotOpen();
		if (id > m_masterIndex.Length / 4 || m_freeList.Contains(id))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
		}
		int offset = GetOffset(ref id);
		InfoCardTrace.Assert(id >= 0, "Invalid ID was returned by GetOffset.", new object[0]);
		RemoveFromMasterIndex(id);
		EnsureSpaceForData(offset, 0);
	}

	public unsafe int WriteObject(int id, byte[] iv, byte[] data, int objectType, long lastChange, GlobalId globalId)
	{
		ThrowIfNotOpen();
		if (iv != null && iv.Length != 0)
		{
			if (data != null && data.Length != 0)
			{
				if (id > m_masterIndex.Length / 4)
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
				}
				if (id > 0 && m_freeList.Contains(id))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)new ArgumentOutOfRangeException("id", id, SR.GetString("StoreLocalIdOutOfRange")));
				}
				int offset = GetOffset(ref id);
				InfoCardTrace.Assert(id >= 0, "Invalid ID was returned by GetOffset.", new object[0]);
				EnsureSpaceForData(offset, data.Length);
				fixed (byte* ptr = &m_buffer[offset])
				{
					EncryptedObjectHeader* ptr2 = (EncryptedObjectHeader*)ptr;
					byte* value = (byte*)(ptr2 + 1);
					ptr2->LastChange = lastChange;
					ptr2->DataSize = data.Length;
					ptr2->ObjectType = objectType;
					ptr2->LocalId = id;
					ptr2->GlobalId = globalId;
					InfoCardTrace.Assert(iv.Length <= 32, "IV Length is invalid", new object[0]);
					Marshal.Copy(iv, 0, new IntPtr(&ptr2->IV), iv.Length);
					Marshal.Copy(data, 0, new IntPtr(value), data.Length);
				}
				return id;
			}
			throw InfoCardTrace.ThrowHelperArgumentNull("iv");
		}
		throw InfoCardTrace.ThrowHelperArgumentNull("iv");
	}

	private unsafe int GetObjectDataSize(int offset)
	{
		fixed (byte* ptr = &m_buffer[offset])
		{
			EncryptedObjectHeader* ptr2 = (EncryptedObjectHeader*)ptr;
			return ptr2->DataSize;
		}
	}

	private void Clear()
	{
		Array.Clear(m_buffer, 0, m_dataLength);
		Array.Clear(m_masterIndex, 0, m_masterIndex.Length);
		m_dataLength = 0;
	}

	private unsafe int EnsureSpaceForData(int offset, int dataSize)
	{
		InfoCardTrace.Assert((uint)offset <= (uint)m_dataLength, "offset specified is outside the range of the data buffer", new object[0]);
		InfoCardTrace.Assert(dataSize >= 0, "The requested data size must be greater than or equal to 0", new object[0]);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		if (dataSize != 0)
		{
			num = dataSize + sizeof(EncryptedObjectHeader);
		}
		if (num % 8 != 0)
		{
			num += 8 - num % 8;
		}
		if (offset == m_dataLength)
		{
			num2 = 0;
		}
		else
		{
			fixed (byte* ptr = &m_buffer[offset])
			{
				EncryptedObjectHeader* ptr2 = (EncryptedObjectHeader*)ptr;
				num2 = ptr2->DataSize + sizeof(EncryptedObjectHeader);
				if (num2 % 8 != 0)
				{
					num2 += 8 - num2 % 8;
				}
			}
		}
		InfoCardTrace.Assert(num2 <= m_dataLength, "currentSize can not be more ", new object[0]);
		if (num2 == num)
		{
			return num;
		}
		num3 = offset + num2;
		num5 = num - num2;
		num4 = num3 + num5;
		if (num5 > 0 && m_dataLength + num5 >= m_buffer.Length)
		{
			GrowBuffer(m_dataLength + num5);
		}
		InfoCardTrace.Assert((uint)num3 <= (uint)m_buffer.Length && num3 >= offset, "NextIndex value is corrupt when attempting to ensure space for object", new object[0]);
		InfoCardTrace.Assert((uint)num4 <= (uint)m_buffer.Length, "NextNewIndex value is corrupt when attempting to ensure space for object", new object[0]);
		if (m_dataLength != num3)
		{
			InfoCardTrace.Assert(m_dataLength - num3 > 0, "NextIndex data is corrupt when attempting to ensure space for object in middle of content.", new object[0]);
			Array.Copy(m_buffer, num3, m_buffer, num4, m_dataLength - num3);
			m_dataLength += num5;
			InfoCardTrace.Assert(m_dataLength >= 0, "DataLength has been corrupted.", new object[0]);
			if (num5 < 0)
			{
				InfoCardTrace.Assert(m_dataLength <= m_buffer.Length, "DataLength is larger than allocated buffer.", new object[0]);
				Array.Clear(m_buffer, m_dataLength, Math.Abs(num5));
			}
			UpdateMasterIndex(Math.Min(num3, num4), num5);
		}
		else
		{
			m_dataLength += num5;
		}
		InfoCardTrace.Assert(m_dataLength <= m_buffer.Length, "DataLength is larger than allocated buffer.", new object[0]);
		return num;
	}

	private void GrowMasterIndex()
	{
		int num = m_masterIndex.Length / 4;
		int num2 = Utility.CalculateIncreaseByPercent(m_masterIndex.Length, 4, 5);
		InfoCardTrace.Assert(num2 > m_masterIndex.Length, "NewSize must be greater than old size to grow master index buffer", new object[0]);
		byte[] array = new byte[num2];
		Array.Copy(m_masterIndex, 0, array, 0, m_masterIndex.Length);
		Array.Clear(m_masterIndex, 0, m_masterIndex.Length);
		m_masterIndex = array;
		int num3 = m_masterIndex.Length / 4;
		for (int i = num + 1; i < num3; i++)
		{
			m_freeList.Put(i);
		}
	}

	private void GrowBuffer(int spaceRequired)
	{
		InfoCardTrace.Assert(spaceRequired >= m_buffer.Length, "RequireSpace must be greater than old size to grow data buffer", new object[0]);
		int num = spaceRequired;
		num += num / 20;
		InfoCardTrace.Assert(num >= spaceRequired, "NewLength must be greater than required space to grow data buffer", new object[0]);
		byte[] array = new byte[num];
		Array.Copy(m_buffer, 0, array, 0, m_buffer.Length);
		Array.Clear(m_buffer, 0, m_buffer.Length);
		m_buffer = array;
		InfoCardTrace.Assert(m_dataLength <= m_buffer.Length, "DataLength Corrupt or buffer growth failed.", new object[0]);
	}

	private unsafe int GetOffset(ref int id)
	{
		if (id <= 0)
		{
			if (m_dataLength <= 0)
			{
				m_dataLength = 8;
			}
			int dataLength = m_dataLength;
			id = GetNextLocalId(dataLength);
			return dataLength;
		}
		fixed (byte* ptr = &m_masterIndex[0])
		{
			int* ptr2 = (int*)ptr;
			InfoCardTrace.Assert(ptr2[id] >= 0, "Master Index offset value is invalid", new object[0]);
			return ptr2[id];
		}
	}

	private unsafe void RemoveFromMasterIndex(int id)
	{
		InfoCardTrace.Assert(id > 0, "LocalId is invalid", new object[0]);
		fixed (byte* ptr = &m_masterIndex[0])
		{
			int* ptr2 = (int*)ptr;
			ptr2[id] = 0;
			m_freeList.Put(id);
		}
	}

	private unsafe void UpdateMasterIndex(int offset, int diff)
	{
		InfoCardTrace.Assert(offset > 0, "Offset is invalid", new object[0]);
		InfoCardTrace.Assert(diff != 0, "Difference is invalid", new object[0]);
		int num = m_masterIndex.Length / 4;
		fixed (byte* ptr = &m_masterIndex[0])
		{
			int* ptr2 = (int*)ptr;
			for (int i = 1; i < num; i++)
			{
				InfoCardTrace.Assert(ptr2 + i - ptr2 <= m_masterIndex.Length, "Pointer has walked past the end of the allocated buffer.", new object[0]);
				if (ptr2[i] > 0 && ptr2[i] >= offset)
				{
					ptr2[i] += diff;
				}
			}
		}
	}

	private unsafe int GetNextLocalId(int offset)
	{
		InfoCardTrace.Assert(offset >= 0, "The offset can not be negative.", new object[0]);
		int next = m_freeList.GetNext();
		if (next > 0)
		{
			InfoCardTrace.Assert(null != m_masterIndex, "m_masterIndex must not be null by now", new object[0]);
			InfoCardTrace.Assert(m_masterIndex.Length > 0, "m_masterIndex must not be empty.", new object[0]);
			fixed (byte* ptr = &m_masterIndex[0])
			{
				int* ptr2 = (int*)ptr;
				ptr2[next] = offset;
				return next;
			}
		}
		int num = m_masterIndex.Length / 4;
		GrowMasterIndex();
		int num2 = m_masterIndex.Length / 4;
		InfoCardTrace.Assert(num2 > num && num > 0, "Calculated count is corrupt or invalid.", new object[0]);
		fixed (byte* ptr3 = &m_masterIndex[0])
		{
			int* ptr4 = (int*)ptr3;
			ptr4[num] = offset;
		}
		return num;
	}

	public void ThrowIfNotOpen()
	{
		if (!m_isOpen)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new ObjectDisposedException("IndexedDataBuffer"));
		}
	}
}
