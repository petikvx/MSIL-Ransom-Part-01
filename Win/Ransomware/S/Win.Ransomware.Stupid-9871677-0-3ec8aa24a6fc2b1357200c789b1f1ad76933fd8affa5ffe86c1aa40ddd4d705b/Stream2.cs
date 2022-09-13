using System;
using System.IO;
using Ionic.Zip;

internal class Stream2 : Stream
{
	private Class23 class23_0;

	private Stream stream_0;

	private CryptoMode cryptoMode_0;

	public override bool CanRead => cryptoMode_0 == CryptoMode.Decrypt;

	public override bool CanSeek => false;

	public override bool CanWrite => cryptoMode_0 == CryptoMode.Encrypt;

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

	public Stream2(Stream s, Class23 cipher, CryptoMode mode)
	{
		class23_0 = cipher;
		stream_0 = s;
		cryptoMode_0 = mode;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (cryptoMode_0 == CryptoMode.Encrypt)
		{
			throw new NotSupportedException("This stream does not encrypt via Read()");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		byte[] array = new byte[count];
		int num = stream_0.Read(array, 0, count);
		byte[] array2 = class23_0.method_0(array, num);
		for (int i = 0; i < num; i++)
		{
			buffer[offset + i] = array2[i];
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (cryptoMode_0 == CryptoMode.Decrypt)
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
		byte[] array2 = class23_0.method_1(array, count);
		stream_0.Write(array2, 0, array2.Length);
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
