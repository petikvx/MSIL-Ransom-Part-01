using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class ByteQueueOutputStream : BaseOutputStream
{
	private readonly ByteQueue m_buffer;

	public ByteQueue Buffer => m_buffer;

	public ByteQueueOutputStream()
	{
		m_buffer = new ByteQueue();
	}

	public override void WriteByte(byte b)
	{
		m_buffer.AddData(new byte[1] { b }, 0, 1);
	}

	public override void Write(byte[] buf, int off, int len)
	{
		m_buffer.AddData(buf, off, len);
	}
}
