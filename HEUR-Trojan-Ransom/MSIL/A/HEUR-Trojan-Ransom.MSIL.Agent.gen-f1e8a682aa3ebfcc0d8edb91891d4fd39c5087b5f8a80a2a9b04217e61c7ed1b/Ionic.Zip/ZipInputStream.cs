using System;
using System.IO;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zip;

public class ZipInputStream : Stream
{
	private Stream _inputStream;

	private Encoding _provisionalAlternateEncoding;

	private ZipEntry _currentEntry;

	private bool _firstEntry;

	private bool _needSetup;

	private ZipContainer _container;

	private CrcCalculatorStream _crcStream;

	private long _LeftToRead;

	internal string _Password;

	private long _endOfEntry;

	private string _name;

	private bool _leaveUnderlyingStreamOpen;

	private bool _closed;

	private bool _findRequired;

	private bool _exceptionPending;

	public Encoding ProvisionalAlternateEncoding
	{
		get
		{
			return _provisionalAlternateEncoding;
		}
		set
		{
			_provisionalAlternateEncoding = value;
		}
	}

	public int CodecBufferSize { get; set; }

	public string Password
	{
		set
		{
			if (_closed)
			{
				_exceptionPending = true;
				throw new InvalidOperationException("The stream has been closed.");
			}
			_Password = value;
		}
	}

	internal Stream ReadStream => _inputStream;

	public override bool CanRead => true;

	public override bool CanSeek => _inputStream.CanSeek;

	public override bool CanWrite => false;

	public override long Length => _inputStream.Length;

	public override long Position
	{
		get
		{
			return _inputStream.Position;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public ZipInputStream(Stream stream)
		: this(stream, leaveOpen: false)
	{
	}

	public ZipInputStream(string fileName)
	{
		Stream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
		_Init(stream, leaveOpen: false, fileName);
	}

	public ZipInputStream(Stream stream, bool leaveOpen)
	{
		_Init(stream, leaveOpen, null);
	}

	private void _Init(Stream stream, bool leaveOpen, string name)
	{
		_inputStream = stream;
		if (!_inputStream.CanRead)
		{
			throw new ZipException("The stream must be readable.");
		}
		_container = new ZipContainer(this);
		_provisionalAlternateEncoding = Encoding.GetEncoding("IBM437");
		_leaveUnderlyingStreamOpen = leaveOpen;
		_findRequired = true;
		_name = name ?? "(stream)";
	}

	public override string ToString()
	{
		return $"ZipInputStream::{_name}(leaveOpen({_leaveUnderlyingStreamOpen})))";
	}

	private void SetupStream()
	{
		_crcStream = _currentEntry.InternalOpenReader(_Password);
		_LeftToRead = _crcStream.Length;
		_needSetup = false;
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (_closed)
		{
			_exceptionPending = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		if (_needSetup)
		{
			SetupStream();
		}
		if (_LeftToRead == 0L)
		{
			return 0;
		}
		int count2 = (int)((_LeftToRead > count) ? count : _LeftToRead);
		int num = _crcStream.Read(buffer, offset, count2);
		_LeftToRead -= num;
		if (_LeftToRead == 0L)
		{
			int crc = _crcStream.Crc;
			_currentEntry.VerifyCrcAfterExtract(crc);
			_inputStream.Seek(_endOfEntry, SeekOrigin.Begin);
		}
		return num;
	}

	public ZipEntry GetNextEntry()
	{
		if (_findRequired)
		{
			long num = SharedUtilities.FindSignature(_inputStream, 67324752);
			if (num == -1L)
			{
				return null;
			}
			_inputStream.Seek(-4L, SeekOrigin.Current);
		}
		else if (_firstEntry)
		{
			_inputStream.Seek(_endOfEntry, SeekOrigin.Begin);
		}
		_currentEntry = ZipEntry.ReadEntry(_container, !_firstEntry);
		_endOfEntry = _inputStream.Position;
		_firstEntry = true;
		_needSetup = true;
		_findRequired = false;
		return _currentEntry;
	}

	protected override void Dispose(bool disposing)
	{
		if (_closed)
		{
			return;
		}
		if (disposing)
		{
			if (_exceptionPending)
			{
				return;
			}
			if (!_leaveUnderlyingStreamOpen)
			{
				_inputStream.Dispose();
			}
		}
		_closed = true;
	}

	public override void Flush()
	{
		throw new NotSupportedException("Flush");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("Write");
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		_findRequired = true;
		return _inputStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
