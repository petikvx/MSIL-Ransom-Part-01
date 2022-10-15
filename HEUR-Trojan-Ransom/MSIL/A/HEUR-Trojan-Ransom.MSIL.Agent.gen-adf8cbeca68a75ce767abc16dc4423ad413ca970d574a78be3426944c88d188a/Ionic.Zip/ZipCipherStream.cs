using System;
using System.IO;

namespace Ionic.Zip;

internal class ZipCipherStream : Stream
{
	private ZipCrypto _cipher;

	private Stream _s;

	private CryptoMode _mode;

	public override bool CanRead => _mode == CryptoMode.Decrypt;

	public override bool CanSeek => false;

	public override bool CanWrite => _mode == CryptoMode.Encrypt;

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

	public ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode)
	{
		_cipher = cipher;
		_s = s;
		_mode = mode;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (_mode == CryptoMode.Encrypt)
		{
			throw new NotSupportedException("This stream does not encrypt via Read()");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		byte[] array = new byte[count];
		int num = _s.Read(array, 0, count);
		byte[] array2 = _cipher.DecryptMessage(array, num);
		for (int i = 0; i < num; i++)
		{
			buffer[offset + i] = array2[i];
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (_mode == CryptoMode.Decrypt)
		{
			throw new NotSupportedException("This stream does not Decrypt via Write()");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (count == 0)
		{
			return;
		}
		byte[] array = null;
		if (offset != 0)
		{
			array = new byte[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = buffer[offset + i];
			}
		}
		else
		{
			array = buffer;
		}
		byte[] array2 = _cipher.EncryptMessage(array, count);
		_s.Write(array2, 0, array2.Length);
	}

	public override void Flush()
	{
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
