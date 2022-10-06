using System;
using System.IO;

namespace XTSSharp;

public class RandomAccessSectorStream : Stream
{
	private readonly byte[] _buffer;

	private readonly int _bufferSize;

	private readonly SectorStream _s;

	private readonly bool _isStreamOwned;

	private bool _bufferDirty;

	private bool _bufferLoaded;

	private int _bufferPos;

	public override bool CanRead => _s.CanRead;

	public override bool CanSeek => _s.CanSeek;

	public override bool CanWrite => _s.CanWrite;

	public override long Length => _s.Length + _bufferPos;

	public override long Position
	{
		get
		{
			return _bufferLoaded ? (_s.Position - _bufferSize + _bufferPos) : (_s.Position + _bufferPos);
		}
		set
		{
			if (value < 0L)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			long num = value % _bufferSize;
			long position = value - num;
			if (_bufferLoaded)
			{
				long num2 = _s.Position - _bufferSize;
				if (value > num2 && value < num2 + _bufferSize)
				{
					_bufferPos = (int)num;
					return;
				}
			}
			if (_bufferDirty)
			{
				WriteSector();
			}
			_s.Position = position;
			ReadSector();
			_bufferPos = (int)num;
		}
	}

	public RandomAccessSectorStream(SectorStream s)
		: this(s, isStreamOwned: false)
	{
	}

	public RandomAccessSectorStream(SectorStream s, bool isStreamOwned)
	{
		_s = s;
		_isStreamOwned = isStreamOwned;
		_buffer = new byte[s.SectorSize];
		_bufferSize = s.SectorSize;
	}

	protected override void Dispose(bool disposing)
	{
		Flush();
		base.Dispose(disposing);
		if (_isStreamOwned)
		{
			_s.Dispose();
		}
	}

	public override void Flush()
	{
		if (_bufferDirty)
		{
			WriteSector();
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return Position = origin switch
		{
			SeekOrigin.End => Length - offset, 
			SeekOrigin.Begin => offset, 
			_ => Position + offset, 
		};
	}

	public override void SetLength(long value)
	{
		long num = value % _s.SectorSize;
		if (num > 0L)
		{
			value = value - num + _bufferSize;
		}
		_s.SetLength(value);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		long position = Position;
		if (position + count > _s.Length)
		{
			count = (int)(_s.Length - position);
		}
		if (!_bufferLoaded)
		{
			ReadSector();
		}
		int num = 0;
		while (count > 0)
		{
			int num2 = Math.Min(count, _bufferSize - _bufferPos);
			Buffer.BlockCopy(_buffer, _bufferPos, buffer, offset, num2);
			offset += num2;
			_bufferPos += num2;
			count -= num2;
			num += num2;
			if (_bufferPos == _bufferSize)
			{
				ReadSector();
			}
		}
		return num;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		while (count > 0)
		{
			if (!_bufferLoaded)
			{
				ReadSector();
			}
			int num = Math.Min(count, _bufferSize - _bufferPos);
			Buffer.BlockCopy(buffer, offset, _buffer, _bufferPos, num);
			offset += num;
			_bufferPos += num;
			count -= num;
			_bufferDirty = true;
			if (_bufferPos == _bufferSize)
			{
				WriteSector();
			}
		}
	}

	private void ReadSector()
	{
		if (_bufferLoaded && _bufferDirty)
		{
			WriteSector();
		}
		if (_s.Position != _s.Length)
		{
			int num = _s.Read(_buffer, 0, _buffer.Length);
			if (num != _bufferSize)
			{
				Array.Clear(_buffer, num, _buffer.Length - num);
			}
			_bufferLoaded = true;
			_bufferPos = 0;
			_bufferDirty = false;
		}
	}

	private void WriteSector()
	{
		if (_bufferLoaded)
		{
			_s.Seek(-_bufferSize, SeekOrigin.Current);
		}
		_s.Write(_buffer, 0, _bufferSize);
		_bufferDirty = false;
		_bufferLoaded = false;
		_bufferPos = 0;
		Array.Clear(_buffer, 0, _bufferSize);
	}
}
