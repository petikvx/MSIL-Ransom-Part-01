using System;
using System.IO;

namespace Ionic.Zip;

internal class ZipSegmentedStream : Stream
{
	private enum RwMode
	{
		None,
		ReadOnly,
		Write
	}

	private RwMode rwMode;

	private bool _exceptionPending;

	private string _baseName;

	private string _baseDir;

	private string _currentName;

	private string _currentTempName;

	private uint _currentDiskNumber;

	private uint _maxDiskNumber;

	private long _maxSegmentSize;

	private Stream _innerStream;

	public bool ContiguousWrite { get; set; }

	public uint CurrentSegment
	{
		get
		{
			return _currentDiskNumber;
		}
		private set
		{
			_currentDiskNumber = value;
			_currentName = null;
		}
	}

	public string CurrentName
	{
		get
		{
			if (_currentName == null)
			{
				_currentName = _NameForSegment(CurrentSegment);
			}
			return _currentName;
		}
	}

	public string CurrentTempName => _currentTempName;

	public override bool CanRead
	{
		get
		{
			if (rwMode == RwMode.ReadOnly && _innerStream != null)
			{
				return _innerStream.CanRead;
			}
			return false;
		}
	}

	public override bool CanSeek
	{
		get
		{
			if (_innerStream != null)
			{
				return _innerStream.CanSeek;
			}
			return false;
		}
	}

	public override bool CanWrite
	{
		get
		{
			if (rwMode == RwMode.Write && _innerStream != null)
			{
				return _innerStream.CanWrite;
			}
			return false;
		}
	}

	public override long Length => _innerStream.Length;

	public override long Position
	{
		get
		{
			return _innerStream.Position;
		}
		set
		{
			_innerStream.Position = value;
		}
	}

	private ZipSegmentedStream()
	{
		_exceptionPending = false;
	}

	public static ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
	{
		ZipSegmentedStream zipSegmentedStream = new ZipSegmentedStream();
		zipSegmentedStream.rwMode = RwMode.ReadOnly;
		zipSegmentedStream.CurrentSegment = initialDiskNumber;
		zipSegmentedStream._maxDiskNumber = maxDiskNumber;
		zipSegmentedStream._baseName = name;
		zipSegmentedStream._SetReadStream();
		return zipSegmentedStream;
	}

	public static ZipSegmentedStream ForWriting(string name, long maxSegmentSize)
	{
		ZipSegmentedStream zipSegmentedStream = new ZipSegmentedStream
		{
			rwMode = RwMode.Write,
			CurrentSegment = 0u,
			_baseName = name,
			_maxSegmentSize = maxSegmentSize,
			_baseDir = Path.GetDirectoryName(name)
		};
		if (zipSegmentedStream._baseDir == "")
		{
			zipSegmentedStream._baseDir = ".";
		}
		zipSegmentedStream._SetWriteStream(0u);
		return zipSegmentedStream;
	}

	public static Stream ForUpdate(string name, uint diskNumber)
	{
		return File.Open($"{Path.Combine(Path.GetDirectoryName(name), Path.GetFileNameWithoutExtension(name))}.z{diskNumber + 1:D2}", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
	}

	private string _NameForSegment(uint diskNumber)
	{
		return $"{Path.Combine(Path.GetDirectoryName(_baseName), Path.GetFileNameWithoutExtension(_baseName))}.z{diskNumber + 1:D2}";
	}

	public uint ComputeSegment(int length)
	{
		if (_innerStream.Position + length > _maxSegmentSize)
		{
			return CurrentSegment + 1;
		}
		return CurrentSegment;
	}

	public override string ToString()
	{
		return string.Format("{0}[{1}][{2}], pos=0x{3:X})", "ZipSegmentedStream", CurrentName, rwMode.ToString(), Position);
	}

	private void _SetReadStream()
	{
		if (_innerStream != null)
		{
			_innerStream.Dispose();
		}
		if (CurrentSegment + 1 == _maxDiskNumber)
		{
			_currentName = _baseName;
		}
		_innerStream = File.OpenRead(CurrentName);
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (rwMode != RwMode.ReadOnly)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("Stream Error: Cannot Read.");
		}
		int num = _innerStream.Read(buffer, offset, count);
		int num2 = num;
		while (true)
		{
			if (num2 != count)
			{
				if (_innerStream.Position == _innerStream.Length)
				{
					if (CurrentSegment + 1 == _maxDiskNumber)
					{
						break;
					}
					CurrentSegment++;
					_SetReadStream();
					offset += num2;
					count -= num2;
					num2 = _innerStream.Read(buffer, offset, count);
					num += num2;
					continue;
				}
				_exceptionPending = true;
				throw new ZipException($"Read error in file {CurrentName}");
			}
			return num;
		}
		return num;
	}

	private void _SetWriteStream(uint increment)
	{
		if (_innerStream != null)
		{
			_innerStream.Dispose();
			if (File.Exists(CurrentName))
			{
				File.Delete(CurrentName);
			}
			File.Move(_currentTempName, CurrentName);
		}
		if (increment != 0)
		{
			CurrentSegment += increment;
		}
		SharedUtilities.CreateAndOpenUniqueTempFile(_baseDir, out _innerStream, out _currentTempName);
		if (CurrentSegment == 0)
		{
			_innerStream.Write(BitConverter.GetBytes(134695760), 0, 4);
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (rwMode != RwMode.Write)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("Stream Error: Cannot Write.");
		}
		if (ContiguousWrite)
		{
			if (_innerStream.Position + count > _maxSegmentSize)
			{
				_SetWriteStream(1u);
			}
		}
		else
		{
			while (_innerStream.Position + count > _maxSegmentSize)
			{
				long num = _maxSegmentSize - _innerStream.Position;
				int num2 = (int)((num <= buffer.Length) ? num : buffer.Length);
				_innerStream.Write(buffer, offset, num2);
				_SetWriteStream(1u);
				count -= num2;
				offset += num2;
			}
		}
		_innerStream.Write(buffer, offset, count);
	}

	public long TruncateBackward(uint diskNumber, long offset)
	{
		if (rwMode != RwMode.Write)
		{
			_exceptionPending = true;
			throw new ZipException("bad state.");
		}
		if (diskNumber == CurrentSegment)
		{
			return _innerStream.Seek(offset, SeekOrigin.Begin);
		}
		if (_innerStream != null)
		{
			_innerStream.Dispose();
			if (File.Exists(_currentTempName))
			{
				File.Delete(_currentTempName);
			}
		}
		for (uint num = CurrentSegment - 1; num > diskNumber; num--)
		{
			string path = _NameForSegment(num);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
		}
		CurrentSegment = diskNumber;
		for (int i = 0; i < 3; i++)
		{
			try
			{
				_currentTempName = Path.Combine(Path.GetDirectoryName(CurrentName), SharedUtilities.InternalGetTempFileName());
				File.Move(CurrentName, _currentTempName);
			}
			catch (IOException)
			{
				if (i == 2)
				{
					throw;
				}
				continue;
			}
			break;
		}
		_innerStream = new FileStream(_currentTempName, FileMode.Open);
		return _innerStream.Seek(offset, SeekOrigin.Begin);
	}

	public override void Flush()
	{
		_innerStream.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return _innerStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		if (rwMode != RwMode.Write)
		{
			_exceptionPending = true;
			throw new InvalidOperationException();
		}
		_innerStream.SetLength(value);
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (_innerStream != null)
			{
				_innerStream.Dispose();
				if (rwMode != RwMode.Write)
				{
				}
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}
}
