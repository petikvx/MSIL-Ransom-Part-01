using System;
using System.IO;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class TimedStream : Stream
{
	private enum IOKind
	{
		Read,
		Write
	}

	private readonly Stream _baseStream;

	private int _timeout;

	private int _lastReadTimeout;

	private int _lastWriteTimeout;

	private readonly LowResolutionStopwatch _stopwatch;

	internal bool IsClosed { get; private set; }

	public override bool CanRead => _baseStream.CanRead;

	public override bool CanSeek => _baseStream.CanSeek;

	public override bool CanWrite => _baseStream.CanWrite;

	public override long Length => _baseStream.Length;

	public override long Position
	{
		get
		{
			return _baseStream.Position;
		}
		set
		{
			_baseStream.Position = value;
		}
	}

	public override bool CanTimeout => _baseStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return _baseStream.ReadTimeout;
		}
		set
		{
			_baseStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return _baseStream.WriteTimeout;
		}
		set
		{
			_baseStream.WriteTimeout = value;
		}
	}

	public TimedStream(Stream baseStream)
	{
		_baseStream = baseStream;
		_timeout = (baseStream.CanTimeout ? baseStream.ReadTimeout : (-1));
		IsClosed = false;
		_stopwatch = new LowResolutionStopwatch();
	}

	private bool ShouldResetStreamTimeout(int currentValue, int newValue)
	{
		if (!_baseStream.CanTimeout)
		{
			return false;
		}
		if (newValue == -1 && currentValue != newValue)
		{
			return true;
		}
		if (newValue > currentValue)
		{
			return true;
		}
		return currentValue >= newValue + 100;
	}

	private void StartTimer(IOKind op)
	{
		int num = ((_timeout != -1) ? (_timeout - (int)_stopwatch.ElapsedMilliseconds) : (-1));
		if (op == IOKind.Read)
		{
			if (ShouldResetStreamTimeout(_lastReadTimeout, num))
			{
				_baseStream.ReadTimeout = num;
				_lastReadTimeout = num;
			}
		}
		else if (ShouldResetStreamTimeout(_lastWriteTimeout, num))
		{
			_baseStream.WriteTimeout = num;
			_lastWriteTimeout = num;
		}
		if (_timeout != -1)
		{
			_stopwatch.Start();
		}
	}

	private void StopTimer()
	{
		if (_timeout != -1)
		{
			_stopwatch.Stop();
			if (_stopwatch.ElapsedMilliseconds > _timeout)
			{
				ResetTimeout(-1);
				throw new TimeoutException("Timeout in IO operation");
			}
		}
	}

	public override void Flush()
	{
		try
		{
			StartTimer(IOKind.Write);
			_baseStream.Flush();
			StopTimer();
		}
		catch (Exception e)
		{
			HandleException(e);
			throw;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		try
		{
			StartTimer(IOKind.Read);
			int result = _baseStream.Read(buffer, offset, count);
			StopTimer();
			return result;
		}
		catch (Exception e)
		{
			HandleException(e);
			throw;
		}
	}

	public override int ReadByte()
	{
		try
		{
			StartTimer(IOKind.Read);
			int result = _baseStream.ReadByte();
			StopTimer();
			return result;
		}
		catch (Exception e)
		{
			HandleException(e);
			throw;
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return _baseStream.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		_baseStream.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		try
		{
			StartTimer(IOKind.Write);
			_baseStream.Write(buffer, offset, count);
			StopTimer();
		}
		catch (Exception e)
		{
			HandleException(e);
			throw;
		}
	}

	public override void Close()
	{
		if (!IsClosed)
		{
			IsClosed = true;
			_baseStream.Close();
			_baseStream.Dispose();
		}
	}

	public void ResetTimeout(int newTimeout)
	{
		if (newTimeout != -1 && newTimeout != 0)
		{
			_timeout = newTimeout;
		}
		else
		{
			_timeout = -1;
		}
		_stopwatch.Reset();
	}

	private void HandleException(Exception e)
	{
		_stopwatch.Stop();
		ResetTimeout(-1);
	}
}
