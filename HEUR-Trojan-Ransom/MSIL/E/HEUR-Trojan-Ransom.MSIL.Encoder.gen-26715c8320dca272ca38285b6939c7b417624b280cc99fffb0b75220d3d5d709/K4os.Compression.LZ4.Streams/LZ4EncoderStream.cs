using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using K4os.Compression.LZ4.Encoders;
using K4os.Hash.xxHash;

namespace K4os.Compression.LZ4.Streams;

public class LZ4EncoderStream : Stream, IDisposable
{
	private readonly Stream _inner;

	private const int _length16 = 16;

	private readonly byte[] _buffer16 = new byte[24];

	private int _index16;

	private ILZ4Encoder _encoder;

	private readonly Func<ILZ4Descriptor, ILZ4Encoder> _encoderFactory;

	private readonly ILZ4Descriptor _descriptor;

	private readonly bool _leaveOpen;

	private byte[] _buffer;

	private long _position;

	public override bool CanRead => false;

	public override bool CanSeek => false;

	public override bool CanWrite => _inner.CanWrite;

	public override long Length => _position;

	public override long Position
	{
		get
		{
			return _position;
		}
		set
		{
			throw InvalidOperation("Position");
		}
	}

	public override bool CanTimeout => _inner.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return _inner.ReadTimeout;
		}
		set
		{
			_inner.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return _inner.WriteTimeout;
		}
		set
		{
			_inner.WriteTimeout = value;
		}
	}

	public LZ4EncoderStream(Stream inner, ILZ4Descriptor descriptor, Func<ILZ4Descriptor, ILZ4Encoder> encoderFactory, bool leaveOpen = false)
	{
		_inner = inner;
		_descriptor = descriptor;
		_encoderFactory = encoderFactory;
		_leaveOpen = leaveOpen;
	}

	public override void Flush()
	{
		_inner.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return _inner.FlushAsync(cancellationToken);
	}

	public override void Close()
	{
		CloseFrame();
	}

	public override void WriteByte(byte value)
	{
		_buffer16[16] = value;
		Write(_buffer16, 16, 1);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (_encoder == null)
		{
			WriteFrame();
		}
		while (count > 0)
		{
			int loaded;
			int encoded;
			EncoderAction action = _encoder.TopupAndEncode(buffer, offset, count, _buffer, 0, _buffer.Length, forceEncode: false, allowCopy: true, out loaded, out encoded);
			WriteBlock(encoded, action);
			_position += loaded;
			offset += loaded;
			count -= loaded;
		}
	}

	private void WriteFrame()
	{
		Stash32(407708164u);
		FlushStash();
		bool chaining = _descriptor.Chaining;
		bool blockChecksum = _descriptor.BlockChecksum;
		bool contentChecksum = _descriptor.ContentChecksum;
		bool hasValue = _descriptor.ContentLength.HasValue;
		bool hasValue2 = _descriptor.Dictionary.HasValue;
		int num = 0x40 | (((!chaining) ? 1 : 0) << 5) | ((blockChecksum ? 1 : 0) << 4) | ((hasValue ? 1 : 0) << 3) | ((contentChecksum ? 1 : 0) << 2) | (hasValue2 ? 1 : 0);
		int blockSize = _descriptor.BlockSize;
		int num2 = MaxBlockSizeCode(blockSize) << 4;
		Stash16((ushort)(((uint)num & 0xFFu) | (uint)((num2 & 0xFF) << 8)));
		if (hasValue)
		{
			throw NotImplemented("ContentSize feature is not implemented");
		}
		if (hasValue2)
		{
			throw NotImplemented("Predefined dictionaries feature is not implemented");
		}
		byte value = (byte)(XXH32.DigestOf(_buffer16, 0, _index16) >> 8);
		Stash8(value);
		FlushStash();
		_encoder = CreateEncoder();
		_buffer = new byte[LZ4Codec.MaximumOutputSize(blockSize)];
	}

	private ILZ4Encoder CreateEncoder()
	{
		ILZ4Encoder iLZ4Encoder = _encoderFactory(_descriptor);
		if (iLZ4Encoder.BlockSize > _descriptor.BlockSize)
		{
			throw InvalidValue("BlockSize is greater than declared");
		}
		return iLZ4Encoder;
	}

	private void CloseFrame()
	{
		if (_encoder == null)
		{
			return;
		}
		try
		{
			int encoded;
			EncoderAction action = _encoder.FlushAndEncode(_buffer, 0, _buffer.Length, allowCopy: true, out encoded);
			WriteBlock(encoded, action);
			Stash32(0u);
			FlushStash();
			if (_descriptor.ContentChecksum)
			{
				throw NotImplemented("ContentChecksum");
			}
			_buffer = null;
			_encoder.Dispose();
		}
		finally
		{
			_encoder = null;
		}
	}

	private int MaxBlockSizeCode(int blockSize)
	{
		if (blockSize > 65536)
		{
			if (blockSize > 262144)
			{
				if (blockSize > 1048576)
				{
					if (blockSize > 4194304)
					{
						throw InvalidBlockSize(blockSize);
					}
					return 7;
				}
				return 6;
			}
			return 5;
		}
		return 4;
	}

	private void WriteBlock(int length, EncoderAction action)
	{
		switch (action)
		{
		case EncoderAction.Encoded:
			WriteBlock(length, compressed: true);
			break;
		case EncoderAction.Copied:
			WriteBlock(length, compressed: false);
			break;
		}
	}

	private void WriteBlock(int length, bool compressed)
	{
		if (length > 0)
		{
			Stash32((uint)length | ((!compressed) ? 2147483648u : 0u));
			FlushStash();
			_inner.Write(_buffer, 0, length);
			if (_descriptor.BlockChecksum)
			{
				throw NotImplemented("BlockChecksum");
			}
		}
	}

	public new void Dispose()
	{
		Dispose(disposing: true);
		base.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			CloseFrame();
			if (!_leaveOpen)
			{
				_inner.Dispose();
			}
		}
	}

	private void Stash8(byte value)
	{
		_buffer16[_index16++] = value;
	}

	private void Stash16(ushort value)
	{
		_buffer16[_index16] = (byte)value;
		_buffer16[_index16 + 1] = (byte)(value >> 8);
		_index16 += 2;
	}

	private void Stash32(uint value)
	{
		_buffer16[_index16] = (byte)value;
		_buffer16[_index16 + 1] = (byte)(value >> 8);
		_buffer16[_index16 + 2] = (byte)(value >> 16);
		_buffer16[_index16 + 3] = (byte)(value >> 24);
		_index16 += 4;
	}

	private void FlushStash()
	{
		if (_index16 > 0)
		{
			_inner.Write(_buffer16, 0, _index16);
		}
		_index16 = 0;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw InvalidOperation("Seek");
	}

	public override void SetLength(long value)
	{
		throw InvalidOperation("SetLength");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw InvalidOperation("Read");
	}

	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		throw InvalidOperation("ReadAsync");
	}

	public override int ReadByte()
	{
		throw InvalidOperation("ReadByte");
	}

	private NotImplementedException NotImplemented(string operation)
	{
		return new NotImplementedException("Feature " + operation + " has not been implemented in " + GetType().Name);
	}

	private InvalidOperationException InvalidOperation(string operation)
	{
		return new InvalidOperationException("Operation " + operation + " is not allowed for " + GetType().Name);
	}

	private static ArgumentException InvalidValue(string description)
	{
		return new ArgumentException(description);
	}

	private ArgumentException InvalidBlockSize(int blockSize)
	{
		return new ArgumentException($"Invalid block size ${blockSize} for {GetType().Name}");
	}
}
