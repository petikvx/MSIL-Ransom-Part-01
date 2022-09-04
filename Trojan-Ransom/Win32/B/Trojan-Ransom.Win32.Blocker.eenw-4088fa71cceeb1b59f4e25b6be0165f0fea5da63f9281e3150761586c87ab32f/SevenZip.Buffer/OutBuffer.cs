using System.IO;

namespace SevenZip.Buffer;

public class OutBuffer
{
	private byte[] m_Buffer;

	private uint m_Pos;

	private uint m_BufferSize;

	private Stream m_Stream;

	private ulong m_ProcessedSize;

	public OutBuffer(uint bufferSize)
	{
		m_Buffer = new byte[bufferSize];
		m_BufferSize = bufferSize;
	}

	public void SetStream(Stream stream)
	{
		m_Stream = stream;
	}

	public void FlushStream()
	{
		m_Stream.Flush();
	}

	public void CloseStream()
	{
		m_Stream.Close();
	}

	public void ReleaseStream()
	{
		m_Stream = null;
	}

	public void Init()
	{
		m_ProcessedSize = 0uL;
		m_Pos = 0u;
	}

	public void WriteByte(byte b)
	{
		m_Buffer[m_Pos++] = b;
		if (m_Pos >= m_BufferSize)
		{
			FlushData();
		}
	}

	public void FlushData()
	{
		if (m_Pos != 0)
		{
			m_Stream.Write(m_Buffer, 0, (int)m_Pos);
			m_Pos = 0u;
		}
	}

	public ulong GetProcessedSize()
	{
		return m_ProcessedSize + m_Pos;
	}
}
