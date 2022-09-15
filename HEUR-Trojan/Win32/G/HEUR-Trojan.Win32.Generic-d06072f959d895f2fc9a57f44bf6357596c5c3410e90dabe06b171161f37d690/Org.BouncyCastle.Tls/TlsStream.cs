using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

internal class TlsStream : Stream
{
	private readonly TlsProtocol m_handler;

	public override bool CanRead => !m_handler.IsClosed;

	public override bool CanSeek => false;

	public override bool CanWrite => !m_handler.IsClosed;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	internal TlsStream(TlsProtocol handler)
	{
		m_handler = handler;
	}

	public override void Close()
	{
		m_handler.Close();
		base.Close();
	}

	public override void Flush()
	{
		m_handler.Flush();
	}

	public override int Read(byte[] buf, int off, int len)
	{
		return m_handler.ReadApplicationData(buf, off, len);
	}

	public override int ReadByte()
	{
		byte[] array = new byte[1];
		if (Read(array, 0, 1) > 0)
		{
			return array[0];
		}
		return -1;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}

	public override void Write(byte[] buf, int off, int len)
	{
		m_handler.WriteApplicationData(buf, off, len);
	}

	public override void WriteByte(byte b)
	{
		Write(new byte[1] { b }, 0, 1);
	}
}
