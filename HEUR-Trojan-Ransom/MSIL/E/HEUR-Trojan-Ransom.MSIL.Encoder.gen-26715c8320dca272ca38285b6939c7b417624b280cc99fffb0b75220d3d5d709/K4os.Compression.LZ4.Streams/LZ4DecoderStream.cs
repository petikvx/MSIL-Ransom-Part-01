using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using K4os.Compression.LZ4.Encoders;
using K4os.Hash.xxHash;

namespace K4os.Compression.LZ4.Streams;

public class LZ4DecoderStream : Stream, IDisposable
{
	private readonly bool _interactive = true;

	private readonly bool _leaveOpen;

	private readonly Stream _inner;

	private const int _length16 = 16;

	private readonly byte[] _buffer16 = new byte[24];

	private int _index16;

	private readonly Func<ILZ4Descriptor, ILZ4Decoder> _decoderFactory;

	private ILZ4Descriptor _frameInfo;

	private ILZ4Decoder _decoder;

	private int _decoded;

	private byte[] _buffer;

	private long _position;

	public override bool CanRead => _inner.CanRead;

	public override bool CanSeek => false;

	public override bool CanWrite => false;

	public override long Length
	{
		get
		{
			EnsureFrame();
			return _frameInfo?.ContentLength ?? (-1L);
		}
	}

	public override long Position
	{
		get
		{
			return _position;
		}
		set
		{
			throw InvalidOperation("SetPosition");
		}
	}

	public override bool CanTimeout => _inner.CanTimeout;

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

	public LZ4DecoderStream(Stream inner, Func<ILZ4Descriptor, ILZ4Decoder> decoderFactory, bool leaveOpen = false)
	{
		_inner = inner;
		_decoderFactory = decoderFactory;
		_leaveOpen = leaveOpen;
		_position = 0L;
	}

	public override void Flush()
	{
		_inner.Flush();
	}

	public override Task FlushAsync(CancellationToken cancellationToken)
	{
		return _inner.FlushAsync(cancellationToken);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (!EnsureFrame())
		{
			return 0;
		}
		int read = 0;
		while (count > 0 && (_decoded > 0 || (_decoded = ReadBlock()) != 0) && !ReadDecoded(buffer, ref offset, ref count, ref read))
		{
		}
		return read;
	}

	public override int ReadByte()
	{
		if (Read(_buffer16, 16, 1) <= 0)
		{
			return -1;
		}
		return _buffer16[16];
	}

	private bool EnsureFrame()
	{
		if (_decoder == null)
		{
			return ReadFrame();
		}
		return true;
	}

	private bool ReadFrame()
	{
		FlushPeek();
		uint? num = TryPeek32();
		if (!num.HasValue)
		{
			return false;
		}
		if (num != 407708164)
		{
			throw MagicNumberExpected();
		}
		FlushPeek();
		ushort num2 = Peek16();
		int num3 = num2 & 0xFF;
		int num4 = (num2 >> 8) & 0xFF;
		int num5 = (num3 >> 6) & 0x11;
		if (num5 != 1)
		{
			throw UnknownFrameVersion(num5);
		}
		bool chaining = ((num3 >> 5) & 1) == 0;
		bool blockChecksum = ((num3 >> 4) & 1) != 0;
		bool flag = ((num3 >> 3) & 1) != 0;
		bool contentChecksum = ((num3 >> 2) & 1) != 0;
		bool num6 = (num3 & 1) != 0;
		int blockSizeCode = (num4 >> 4) & 7;
		long? contentLength = (flag ? new long?((long)Peek64()) : null);
		uint? dictionary = (num6 ? new uint?(Peek32()) : null);
		byte num7 = (byte)(XXH32.DigestOf(_buffer16, 0, _index16) >> 8);
		byte b = Peek8();
		if (num7 != b)
		{
			throw InvalidHeaderChecksum();
		}
		int num8 = MaxBlockSize(blockSizeCode);
		if (num6)
		{
			throw NotImplemented("Predefined dictionaries feature is not implemented");
		}
		_frameInfo = new LZ4Descriptor(contentLength, contentChecksum, chaining, blockChecksum, dictionary, num8);
		_decoder = _decoderFactory(_frameInfo);
		_buffer = new byte[num8];
		return true;
	}

	private void CloseFrame()
	{
		if (_decoder == null)
		{
			return;
		}
		try
		{
			_frameInfo = null;
			_buffer = null;
			_decoder.Dispose();
		}
		finally
		{
			_decoder = null;
		}
	}

	private static int MaxBlockSize(int blockSizeCode)
	{
		return blockSizeCode switch
		{
			4 => 65536, 
			5 => 262144, 
			6 => 1048576, 
			7 => 4194304, 
			_ => 65536, 
		};
	}

	private unsafe int ReadBlock()
	{
		FlushPeek();
		int num = (int)Peek32();
		if (num == 0)
		{
			if (_frameInfo.ContentChecksum)
			{
				Peek32();
			}
			CloseFrame();
			return 0;
		}
		bool num2 = (ulong)(num & 0x80000000L) > 0uL;
		num &= 0x7FFFFFFF;
		PeekN(_buffer, 0, num);
		if (_frameInfo.BlockChecksum)
		{
			Peek32();
		}
		fixed (byte* source = _buffer)
		{
			if (!num2)
			{
				return _decoder.Decode(source, num);
			}
			return _decoder.Inject(source, num);
		}
	}

	private bool ReadDecoded(byte[] buffer, ref int offset, ref int count, ref int read)
	{
		if (_decoded <= 0)
		{
			return true;
		}
		int num = Math.Min(count, _decoded);
		_decoder.Drain(buffer, offset, -_decoded, num);
		_position += num;
		_decoded -= num;
		offset += num;
		count -= num;
		read += num;
		return _interactive;
	}

	private int PeekN(byte[] buffer, int offset, int count, bool optional = false)
	{
		int num = 0;
		while (true)
		{
			if (count > 0)
			{
				int num2 = _inner.Read(buffer, num + offset, count);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				count -= num2;
				continue;
			}
			return num;
		}
		if (!(num == 0 && optional))
		{
			throw EndOfStream();
		}
		return 0;
	}

	private bool PeekN(int count, bool optional = false)
	{
		if (count == 0)
		{
			return true;
		}
		int num = PeekN(_buffer16, _index16, count, optional);
		_index16 += num;
		return num > 0;
	}

	private void FlushPeek()
	{
		_index16 = 0;
	}

	private ulong Peek64()
	{
		PeekN(8);
		return BitConverter.ToUInt64(_buffer16, _index16 - 8);
	}

	private uint? TryPeek32()
	{
		if (!PeekN(4, optional: true))
		{
			return null;
		}
		return BitConverter.ToUInt32(_buffer16, _index16 - 4);
	}

	private uint Peek32()
	{
		PeekN(4);
		return BitConverter.ToUInt32(_buffer16, _index16 - 4);
	}

	private ushort Peek16()
	{
		PeekN(2);
		return BitConverter.ToUInt16(_buffer16, _index16 - 2);
	}

	private byte Peek8()
	{
		PeekN(1);
		return _buffer16[_index16 - 1];
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

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw InvalidOperation("Seek");
	}

	public override void SetLength(long value)
	{
		throw InvalidOperation("SetLength");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw InvalidOperation("Write");
	}

	public override void WriteByte(byte value)
	{
		throw InvalidOperation("WriteByte");
	}

	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
	{
		throw InvalidOperation("WriteAsync");
	}

	private NotImplementedException NotImplemented(string operation)
	{
		return new NotImplementedException("Feature " + operation + " has not been implemented in " + GetType().Name);
	}

	private static InvalidDataException InvalidHeaderChecksum()
	{
		return new InvalidDataException("Invalid LZ4 frame header checksum");
	}

	private static InvalidDataException MagicNumberExpected()
	{
		return new InvalidDataException("LZ4 frame magic number expected");
	}

	private static InvalidDataException UnknownFrameVersion(int version)
	{
		return new InvalidDataException($"LZ4 frame version {version} is not supported");
	}

	private InvalidOperationException InvalidOperation(string operation)
	{
		return new InvalidOperationException("Operation " + operation + " is not allowed for " + GetType().Name);
	}

	private static EndOfStreamException EndOfStream()
	{
		return new EndOfStreamException("Unexpected end of stream. Data might be corrupted.");
	}
}
