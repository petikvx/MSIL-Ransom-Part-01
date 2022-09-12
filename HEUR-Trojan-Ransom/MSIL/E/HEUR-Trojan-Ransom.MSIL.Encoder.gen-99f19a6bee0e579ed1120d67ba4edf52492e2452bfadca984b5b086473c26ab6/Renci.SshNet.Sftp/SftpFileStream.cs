using System;
using System.IO;
using System.Threading;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpFileStream : Stream
{
	private byte[] _handle;

	private ISftpSession _session;

	private readonly int _readBufferSize;

	private byte[] _readBuffer;

	private readonly int _writeBufferSize;

	private byte[] _writeBuffer;

	private int _bufferPosition;

	private int _bufferLen;

	private long _position;

	private bool _bufferOwnedByWrite;

	private bool _canRead;

	private bool _canSeek;

	private bool _canWrite;

	private readonly object _lock = new object();

	public override bool CanRead => _canRead;

	public override bool CanSeek => _canSeek;

	public override bool CanWrite => _canWrite;

	public override bool CanTimeout => true;

	public override long Length
	{
		get
		{
			lock (_lock)
			{
				CheckSessionIsOpen();
				if (!CanSeek)
				{
					throw new NotSupportedException("Seek operation is not supported.");
				}
				if (_bufferOwnedByWrite)
				{
					FlushWriteBuffer();
				}
				SftpFileAttributes sftpFileAttributes = _session.RequestFStat(_handle, nullOnError: true);
				if (sftpFileAttributes == null)
				{
					throw new IOException("Seek operation failed.");
				}
				return sftpFileAttributes.Size;
			}
		}
	}

	public override long Position
	{
		get
		{
			CheckSessionIsOpen();
			if (!CanSeek)
			{
				throw new NotSupportedException("Seek operation not supported.");
			}
			return _position;
		}
		set
		{
			Seek(value, SeekOrigin.Begin);
		}
	}

	public string Name { get; private set; }

	public virtual byte[] Handle
	{
		get
		{
			Flush();
			return _handle;
		}
	}

	public TimeSpan Timeout { get; set; }

	internal SftpFileStream(ISftpSession session, string path, FileMode mode, FileAccess access, int bufferSize)
	{
		if (session == null)
		{
			throw new SshConnectionException("Client not connected.");
		}
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		if (bufferSize <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		Timeout = TimeSpan.FromSeconds(30.0);
		Name = path;
		_session = session;
		_canRead = (access & FileAccess.Read) != 0;
		_canSeek = true;
		_canWrite = (access & FileAccess.Write) != 0;
		Flags flags = Flags.None;
		switch (access)
		{
		default:
			throw new ArgumentOutOfRangeException("access");
		case FileAccess.Read:
			flags |= Flags.Read;
			break;
		case FileAccess.Write:
			flags |= Flags.Write;
			break;
		case FileAccess.ReadWrite:
			flags |= Flags.Read;
			flags |= Flags.Write;
			break;
		}
		if ((access & FileAccess.Read) != 0 && mode == FileMode.Append)
		{
			throw new ArgumentException(string.Format("{0} mode can be requested only when combined with write-only access.", mode.ToString("G")));
		}
		if ((access & FileAccess.Write) == 0 && (mode == FileMode.Create || mode == FileMode.CreateNew || mode == FileMode.Truncate || mode == FileMode.Append))
		{
			throw new ArgumentException($"Combining {typeof(FileMode).Name}: {mode} with {typeof(FileAccess).Name}: {access} is invalid.");
		}
		switch (mode)
		{
		default:
			throw new ArgumentOutOfRangeException("mode");
		case FileMode.CreateNew:
			flags |= Flags.CreateNew;
			break;
		case FileMode.Create:
			_handle = _session.RequestOpen(path, flags | Flags.Truncate, nullOnError: true);
			flags = ((_handle != null) ? (flags | Flags.Truncate) : (flags | Flags.CreateNew));
			break;
		case FileMode.OpenOrCreate:
			flags |= Flags.CreateNewOrOpen;
			break;
		case FileMode.Truncate:
			flags |= Flags.Truncate;
			break;
		case FileMode.Append:
			flags |= Flags.Append | Flags.CreateNewOrOpen;
			break;
		case FileMode.Open:
			break;
		}
		if (_handle == null)
		{
			_handle = _session.RequestOpen(path, flags);
		}
		_readBufferSize = (int)session.CalculateOptimalReadLength((uint)bufferSize);
		_writeBufferSize = (int)session.CalculateOptimalWriteLength((uint)bufferSize, _handle);
		if (mode == FileMode.Append)
		{
			SftpFileAttributes sftpFileAttributes = _session.RequestFStat(_handle, nullOnError: false);
			_position = sftpFileAttributes.Size;
		}
	}

	~SftpFileStream()
	{
		Dispose(disposing: false);
	}

	public override void Flush()
	{
		lock (_lock)
		{
			CheckSessionIsOpen();
			if (_bufferOwnedByWrite)
			{
				FlushWriteBuffer();
			}
			else
			{
				FlushReadBuffer();
			}
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Invalid array range.");
		}
		lock (_lock)
		{
			CheckSessionIsOpen();
			SetupRead();
			while (true)
			{
				if (count > 0)
				{
					int num2 = _bufferLen - _bufferPosition;
					if (num2 <= 0)
					{
						byte[] array = _session.RequestRead(_handle, (ulong)_position, (uint)_readBufferSize);
						if (array.Length == 0)
						{
							_bufferPosition = 0;
							_bufferLen = 0;
							return num;
						}
						int num3 = count;
						if (num3 >= array.Length)
						{
							num3 = array.Length;
							_bufferPosition = 0;
							_bufferLen = 0;
						}
						else
						{
							int num4 = array.Length - num3;
							Buffer.BlockCopy(array, count, GetOrCreateReadBuffer(), 0, num4);
							_bufferPosition = 0;
							_bufferLen = num4;
						}
						Buffer.BlockCopy(array, 0, buffer, offset, num3);
						_position += num3;
						num += num3;
						if (array.Length < _readBufferSize)
						{
							break;
						}
						offset += num3;
						count -= num3;
					}
					else
					{
						if (num2 > count)
						{
							num2 = count;
						}
						Buffer.BlockCopy(GetOrCreateReadBuffer(), _bufferPosition, buffer, offset, num2);
						_bufferPosition += num2;
						_position += num2;
						num += num2;
						offset += num2;
						count -= num2;
					}
					continue;
				}
				return num;
			}
			return num;
		}
	}

	public override int ReadByte()
	{
		lock (_lock)
		{
			CheckSessionIsOpen();
			SetupRead();
			byte[] orCreateReadBuffer;
			if (_bufferPosition >= _bufferLen)
			{
				byte[] array = _session.RequestRead(_handle, (ulong)_position, (uint)_readBufferSize);
				if (array.Length == 0)
				{
					return -1;
				}
				orCreateReadBuffer = GetOrCreateReadBuffer();
				Buffer.BlockCopy(array, 0, orCreateReadBuffer, 0, array.Length);
				_bufferPosition = 0;
				_bufferLen = array.Length;
			}
			else
			{
				orCreateReadBuffer = GetOrCreateReadBuffer();
			}
			_position++;
			return orCreateReadBuffer[_bufferPosition++];
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		long num = -1L;
		lock (_lock)
		{
			CheckSessionIsOpen();
			if (!CanSeek)
			{
				throw new NotSupportedException("Seek is not supported.");
			}
			if (origin == SeekOrigin.Begin && offset == _position)
			{
				return offset;
			}
			if (origin == SeekOrigin.Current && offset == 0L)
			{
				return _position;
			}
			if (_bufferOwnedByWrite)
			{
				FlushWriteBuffer();
				switch (origin)
				{
				case SeekOrigin.Begin:
					num = offset;
					break;
				case SeekOrigin.Current:
					num = _position + offset;
					break;
				case SeekOrigin.End:
					num = _session.RequestFStat(_handle, nullOnError: false).Size - offset;
					break;
				}
				if (num == -1L)
				{
					throw new EndOfStreamException("End of stream.");
				}
				_position = num;
			}
			else
			{
				switch (origin)
				{
				case SeekOrigin.Begin:
					num = _position - _bufferPosition;
					if (offset >= num && offset < num + _bufferLen)
					{
						_bufferPosition = (int)(offset - num);
						_position = offset;
						return _position;
					}
					break;
				case SeekOrigin.Current:
					num = _position + offset;
					if (num >= _position - _bufferPosition && num < _position - _bufferPosition + _bufferLen)
					{
						_bufferPosition = (int)(num - (_position - _bufferPosition));
						_position = num;
						return _position;
					}
					break;
				}
				_bufferPosition = 0;
				_bufferLen = 0;
				switch (origin)
				{
				case SeekOrigin.Begin:
					num = offset;
					break;
				case SeekOrigin.Current:
					num = _position + offset;
					break;
				case SeekOrigin.End:
					num = _session.RequestFStat(_handle, nullOnError: false).Size - offset;
					break;
				}
				if (num < 0L)
				{
					throw new EndOfStreamException();
				}
				_position = num;
			}
			return _position;
		}
	}

	public override void SetLength(long value)
	{
		if (value < 0L)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		lock (_lock)
		{
			CheckSessionIsOpen();
			if (!CanSeek)
			{
				throw new NotSupportedException("Seek is not supported.");
			}
			if (_bufferOwnedByWrite)
			{
				FlushWriteBuffer();
			}
			else
			{
				SetupWrite();
			}
			SftpFileAttributes sftpFileAttributes = _session.RequestFStat(_handle, nullOnError: false);
			sftpFileAttributes.Size = value;
			_session.RequestFSetStat(_handle, sftpFileAttributes);
			if (_position > value)
			{
				_position = value;
			}
		}
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (buffer.Length - offset < count)
		{
			throw new ArgumentException("Invalid array range.");
		}
		lock (_lock)
		{
			CheckSessionIsOpen();
			SetupWrite();
			while (count > 0)
			{
				int num = _writeBufferSize - _bufferPosition;
				if (num <= 0)
				{
					FlushWriteBuffer();
					num = _writeBufferSize;
				}
				if (num > count)
				{
					num = count;
				}
				if (_bufferPosition == 0 && num == _writeBufferSize)
				{
					using AutoResetEvent wait = new AutoResetEvent(initialState: false);
					_session.RequestWrite(_handle, (ulong)_position, buffer, offset, num, wait);
				}
				else
				{
					Buffer.BlockCopy(buffer, offset, GetOrCreateWriteBuffer(), _bufferPosition, num);
					_bufferPosition += num;
				}
				_position += num;
				offset += num;
				count -= num;
			}
			if (_bufferPosition >= _writeBufferSize)
			{
				using (AutoResetEvent wait2 = new AutoResetEvent(initialState: false))
				{
					_session.RequestWrite(_handle, (ulong)(_position - _bufferPosition), GetOrCreateWriteBuffer(), 0, _bufferPosition, wait2);
				}
				_bufferPosition = 0;
			}
		}
	}

	public override void WriteByte(byte value)
	{
		lock (_lock)
		{
			CheckSessionIsOpen();
			SetupWrite();
			byte[] orCreateWriteBuffer = GetOrCreateWriteBuffer();
			if (_bufferPosition >= _writeBufferSize)
			{
				using (AutoResetEvent wait = new AutoResetEvent(initialState: false))
				{
					_session.RequestWrite(_handle, (ulong)(_position - _bufferPosition), orCreateWriteBuffer, 0, _bufferPosition, wait);
				}
				_bufferPosition = 0;
			}
			orCreateWriteBuffer[_bufferPosition++] = value;
			_position++;
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (_session == null || !disposing)
		{
			return;
		}
		lock (_lock)
		{
			if (_session == null)
			{
				return;
			}
			_canRead = false;
			_canSeek = false;
			_canWrite = false;
			if (_handle != null)
			{
				if (_session.IsOpen)
				{
					if (_bufferOwnedByWrite)
					{
						FlushWriteBuffer();
					}
					_session.RequestClose(_handle);
				}
				_handle = null;
			}
			_session = null;
		}
	}

	private byte[] GetOrCreateReadBuffer()
	{
		if (_readBuffer == null)
		{
			_readBuffer = new byte[_readBufferSize];
		}
		return _readBuffer;
	}

	private byte[] GetOrCreateWriteBuffer()
	{
		if (_writeBuffer == null)
		{
			_writeBuffer = new byte[_writeBufferSize];
		}
		return _writeBuffer;
	}

	private void FlushReadBuffer()
	{
		_bufferPosition = 0;
		_bufferLen = 0;
	}

	private void FlushWriteBuffer()
	{
		if (_bufferPosition > 0)
		{
			using (AutoResetEvent wait = new AutoResetEvent(initialState: false))
			{
				_session.RequestWrite(_handle, (ulong)(_position - _bufferPosition), _writeBuffer, 0, _bufferPosition, wait);
			}
			_bufferPosition = 0;
		}
	}

	private void SetupRead()
	{
		if (!CanRead)
		{
			throw new NotSupportedException("Read not supported.");
		}
		if (_bufferOwnedByWrite)
		{
			FlushWriteBuffer();
			_bufferOwnedByWrite = false;
		}
	}

	private void SetupWrite()
	{
		if (!CanWrite)
		{
			throw new NotSupportedException("Write not supported.");
		}
		if (!_bufferOwnedByWrite)
		{
			FlushReadBuffer();
			_bufferOwnedByWrite = true;
		}
	}

	private void CheckSessionIsOpen()
	{
		if (_session == null)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (!_session.IsOpen)
		{
			throw new ObjectDisposedException(GetType().FullName, "Cannot access a closed SFTP session.");
		}
	}
}
