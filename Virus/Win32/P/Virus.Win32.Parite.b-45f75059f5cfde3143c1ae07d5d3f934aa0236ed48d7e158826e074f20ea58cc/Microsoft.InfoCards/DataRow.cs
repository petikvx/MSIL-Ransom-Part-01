using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class DataRow
{
	private string m_instanceId;

	private string m_sourceId;

	private int m_localId;

	private int m_objectType;

	private long m_lastChange;

	private int m_objectSize;

	private GlobalId m_globalId;

	private byte[] m_buffer;

	private DataRowIndexBuffer m_indexBuffer;

	public GlobalId GlobalId
	{
		get
		{
			return m_globalId;
		}
		set
		{
			if (GlobalId.Empty == value)
			{
				throw InfoCardTrace.ThrowHelperArgumentNull("value");
			}
			m_globalId = value;
			SetIndexValue("ix_globalid", value);
		}
	}

	public string InstanceId
	{
		get
		{
			return m_instanceId;
		}
		internal set
		{
			m_instanceId = value;
		}
	}

	public string SourceId
	{
		get
		{
			return m_sourceId;
		}
		internal set
		{
			m_sourceId = value;
		}
	}

	public long LastChange
	{
		get
		{
			return m_lastChange;
		}
		internal set
		{
			m_lastChange = value;
		}
	}

	public int LocalId
	{
		get
		{
			return m_localId;
		}
		internal set
		{
			m_localId = value;
		}
	}

	public int ObjectType
	{
		get
		{
			return m_objectType;
		}
		set
		{
			m_objectType = value;
			SetIndexValue("ix_objecttype", value);
		}
	}

	internal DataRowIndexBuffer IndexBuffer => m_indexBuffer;

	public DataRow()
		: this(null, null)
	{
	}

	private DataRow(string instanceId, string sourceId)
	{
		m_instanceId = instanceId;
		m_sourceId = sourceId;
		m_indexBuffer = new DataRowIndexBuffer();
	}

	public void SetDataField(byte[] buffer)
	{
		SetDataField(buffer, buffer.Length);
	}

	public void SetDataField(byte[] buffer, int size)
	{
		m_buffer = buffer;
		m_objectSize = size;
	}

	public byte[] GetDataField()
	{
		return m_buffer;
	}

	public void SetMultiIndexValue(string name, params object[][] multiValues)
	{
		IndexObject[] array = new IndexObject[multiValues.Length];
		for (int i = 0; i < multiValues.Length; i++)
		{
			array[i] = new IndexObject(multiValues[i]);
		}
		m_indexBuffer.SetIndexValues(name, array);
	}

	public void SetIndexValue(string name, params object[] values)
	{
		object[][] array = new object[values.Length][];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new object[1] { values[i] };
		}
		SetMultiIndexValue(name, array);
	}

	internal unsafe static DataRow Create(EncryptedObjectHeader* pHeader, DataSource source)
	{
		DataRow dataRow = new DataRow(source.InstanceId, source.SourceId);
		dataRow.LastChange = pHeader->LastChange;
		dataRow.ObjectType = pHeader->ObjectType;
		dataRow.LocalId = pHeader->LocalId;
		dataRow.GlobalId = pHeader->GlobalId;
		dataRow.m_objectSize = pHeader->DataSize;
		return dataRow;
	}
}
