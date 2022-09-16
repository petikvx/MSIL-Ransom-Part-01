using System;
using System.IO;
using System.Security.Cryptography;

namespace GreenPixelsCalculator.IO;

public class SecureStream : Stream
{
	public const int DEFAULT_AES_KEY_SIZE = 128;

	public const int DEFAULT_AES_BLOCK_SIZE = 128;

	private const byte ZERO = 0;

	public readonly byte[] WriterKey;

	public readonly byte[] WriterIV;

	private readonly AesManaged aes;

	private readonly int aesOutputSize;

	private CryptoStream reader;

	private CryptoStream writer;

	private byte writedAmount = 0;

	private int writedTotal = 0;

	public override bool CanRead => UsedStream.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => UsedStream.CanWrite;

	[Obsolete("This class does not support Length.", true)]
	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	[Obsolete("This class does not support Position.", true)]
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

	public Stream UsedStream { get; set; }

	public SecureStream(Stream underlying, int aesKeySize = 128, int aesBlockSize = 128)
	{
		UsedStream = underlying;
		aes = new AesManaged
		{
			KeySize = aesKeySize,
			BlockSize = aesBlockSize,
			Mode = CipherMode.CBC,
			Padding = PaddingMode.Zeros
		};
		WriterKey = aes.Key;
		WriterIV = aes.IV;
		ICryptoTransform cryptoTransform = aes.CreateEncryptor();
		aesOutputSize = cryptoTransform.OutputBlockSize;
		writer = new CryptoStream(underlying, cryptoTransform, CryptoStreamMode.Write);
	}

	public void InitializeReader(byte[] key, byte[] iv)
	{
		reader = new CryptoStream(UsedStream, aes.CreateDecryptor(key, iv), CryptoStreamMode.Read);
	}

	protected override void Dispose(bool disposing)
	{
		reader = null;
		writer = null;
		aes.Dispose();
	}

	public override void Flush()
	{
		if (writedAmount > 0)
		{
			byte times = (byte)(aesOutputSize - writedAmount);
			byte[] buffer = ((byte)0).Repeat((int)times);
			GreenPixelsCalculator.Core.Write(writer, buffer);
		}
		writedTotal = 0;
		writedAmount = 0;
		writer.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return reader.Read(buffer, offset, count);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		writedTotal += count;
		writedAmount = (byte)(writedTotal % aesOutputSize);
		writer.Write(buffer, offset, count);
	}

	public override int ReadByte()
	{
		return reader.ReadByte();
	}

	public override void WriteByte(byte value)
	{
		writedTotal++;
		writedAmount = (byte)(writedTotal % aesOutputSize);
		writer.WriteByte(value);
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
