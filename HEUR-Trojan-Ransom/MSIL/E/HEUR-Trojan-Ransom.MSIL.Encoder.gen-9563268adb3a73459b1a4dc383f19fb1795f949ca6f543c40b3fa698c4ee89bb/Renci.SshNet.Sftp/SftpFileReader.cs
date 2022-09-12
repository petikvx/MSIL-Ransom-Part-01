using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

internal class SftpFileReader : IDisposable, ISftpFileReader
{
	internal class BufferedRead
	{
		public int ChunkIndex { get; private set; }

		public byte[] Data { get; private set; }

		public ulong Offset { get; private set; }

		public BufferedRead(int chunkIndex, ulong offset)
		{
			ChunkIndex = chunkIndex;
			Offset = offset;
		}

		public void Complete(byte[] data)
		{
			Data = data;
		}
	}

	private const int ReadAheadWaitTimeoutInMilliseconds = 1000;

	private readonly byte[] _handle;

	private readonly ISftpSession _sftpSession;

	private readonly uint _chunkSize;

	private ulong _offset;

	private readonly long? _fileSize;

	private readonly Dictionary<int, BufferedRead> _queue;

	private readonly WaitHandle[] _waitHandles;

	private int _readAheadChunkIndex;

	private ulong _readAheadOffset;

	private readonly ManualResetEvent _readAheadCompleted;

	private int _nextChunkIndex;

	private bool _endOfFileReceived;

	private bool _isEndOfFileRead;

	private readonly SemaphoreLight _semaphore;

	private readonly object _readLock;

	private readonly ManualResetEvent _disposingWaitHandle;

	private bool _disposingOrDisposed;

	private Exception _exception;

	public SftpFileReader(byte[] handle, ISftpSession sftpSession, uint chunkSize, int maxPendingReads, long? fileSize)
	{
		_handle = handle;
		_sftpSession = sftpSession;
		_chunkSize = chunkSize;
		_fileSize = fileSize;
		_semaphore = new SemaphoreLight(maxPendingReads);
		_queue = new Dictionary<int, BufferedRead>(maxPendingReads);
		_readLock = new object();
		_readAheadCompleted = new ManualResetEvent(initialState: false);
		_disposingWaitHandle = new ManualResetEvent(initialState: false);
		_waitHandles = _sftpSession.CreateWaitHandleArray(_disposingWaitHandle, _semaphore.AvailableWaitHandle);
		StartReadAhead();
	}

	public byte[] Read()
	{
		if (_disposingOrDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
		if (_exception != null)
		{
			throw _exception;
		}
		if (_isEndOfFileRead)
		{
			throw new SshException("Attempting to read beyond the end of the file.");
		}
		BufferedRead value;
		lock (_readLock)
		{
			while (!_queue.TryGetValue(_nextChunkIndex, out value) && _exception == null)
			{
				Monitor.Wait(_readLock);
			}
			if (_exception != null)
			{
				throw _exception;
			}
			byte[] data = value.Data;
			if (value.Offset == _offset)
			{
				if (data.Length == 0)
				{
					_isEndOfFileRead = true;
				}
				else
				{
					_queue.Remove(_nextChunkIndex);
					_offset += (ulong)data.Length;
					_nextChunkIndex++;
				}
				_semaphore.Release();
				return data;
			}
			if (data.Length == 0)
			{
				long? fileSize = _fileSize;
				if (fileSize.HasValue)
				{
					ulong offset = _offset;
					fileSize = _fileSize;
					if (offset == (ulong)fileSize.Value)
					{
						_isEndOfFileRead = true;
						_semaphore.Release();
						return value.Data;
					}
				}
			}
		}
		ulong num = value.Offset - _offset;
		byte[] array = _sftpSession.RequestRead(_handle, _offset, (uint)num);
		if (array.Length == 0)
		{
			lock (_readLock)
			{
				if (value.Data.Length != 0)
				{
					_exception = new SshException("Unexpectedly reached end of file.");
					if (!_disposingOrDisposed)
					{
						_semaphore.Release();
					}
					throw _exception;
				}
				_isEndOfFileRead = true;
				if (!_disposingOrDisposed)
				{
					_semaphore.Release();
				}
				return array;
			}
		}
		_offset += (uint)array.Length;
		return array;
	}

	~SftpFileReader()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected void Dispose(bool disposing)
	{
		if (_disposingOrDisposed)
		{
			return;
		}
		_disposingOrDisposed = true;
		if (!disposing)
		{
			return;
		}
		_exception = new ObjectDisposedException(GetType().FullName);
		_disposingWaitHandle.Set();
		_readAheadCompleted.WaitOne();
		lock (_readLock)
		{
			_semaphore.Dispose();
			Monitor.PulseAll(_readLock);
		}
		_readAheadCompleted.Dispose();
		_disposingWaitHandle.Dispose();
		if (!_sftpSession.IsOpen)
		{
			return;
		}
		try
		{
			SftpCloseAsyncResult asyncResult = _sftpSession.BeginClose(_handle, null, null);
			_sftpSession.EndClose(asyncResult);
		}
		catch (Exception)
		{
		}
	}

	private void StartReadAhead()
	{
		ThreadAbstraction.ExecuteThread(delegate
		{
			while (!_endOfFileReceived && _exception == null)
			{
				if (!ContinueReadAhead())
				{
					lock (_readLock)
					{
						Monitor.PulseAll(_readLock);
					}
					break;
				}
				if (_semaphore.Wait(1000))
				{
					if (_endOfFileReceived || _exception != null)
					{
						break;
					}
					BufferedRead bufferedRead = new BufferedRead(_readAheadChunkIndex, _readAheadOffset);
					try
					{
						long? fileSize = _fileSize;
						if (!fileSize.HasValue)
						{
							goto IL_00ba;
						}
						ulong readAheadOffset = _readAheadOffset;
						fileSize = _fileSize;
						if ((long)readAheadOffset <= fileSize.Value)
						{
							goto IL_00ba;
						}
						SftpReadAsyncResult asyncResult = _sftpSession.BeginRead(_handle, _readAheadOffset, _chunkSize, null, bufferedRead);
						byte[] data = _sftpSession.EndRead(asyncResult);
						ReadCompletedCore(bufferedRead, data);
						goto end_IL_0059;
						IL_00ba:
						_sftpSession.BeginRead(_handle, _readAheadOffset, _chunkSize, ReadCompleted, bufferedRead);
						end_IL_0059:;
					}
					catch (Exception cause)
					{
						HandleFailure(cause);
						break;
					}
					_readAheadOffset += _chunkSize;
					_readAheadChunkIndex++;
				}
			}
			_readAheadCompleted.Set();
		});
	}

	private bool ContinueReadAhead()
	{
		try
		{
			int num = _sftpSession.WaitAny(_waitHandles, _sftpSession.OperationTimeout);
			return num switch
			{
				1 => true, 
				0 => false, 
				_ => throw new NotImplementedException(string.Format(CultureInfo.InvariantCulture, "WaitAny return value '{0}' is not implemented.", new object[1] { num })), 
			};
		}
		catch (Exception value)
		{
			Interlocked.CompareExchange(ref _exception, value, null);
			return false;
		}
	}

	private void ReadCompleted(IAsyncResult result)
	{
		if (!_disposingOrDisposed)
		{
			SftpReadAsyncResult sftpReadAsyncResult = (SftpReadAsyncResult)result;
			byte[] data;
			try
			{
				data = sftpReadAsyncResult.EndInvoke();
			}
			catch (Exception cause)
			{
				HandleFailure(cause);
				return;
			}
			BufferedRead bufferedRead = (BufferedRead)sftpReadAsyncResult.AsyncState;
			ReadCompletedCore(bufferedRead, data);
		}
	}

	private void ReadCompletedCore(BufferedRead bufferedRead, byte[] data)
	{
		bufferedRead.Complete(data);
		lock (_readLock)
		{
			_queue.Add(bufferedRead.ChunkIndex, bufferedRead);
			Monitor.PulseAll(_readLock);
		}
		if (data.Length == 0)
		{
			_endOfFileReceived = true;
		}
	}

	private void HandleFailure(Exception cause)
	{
		Interlocked.CompareExchange(ref _exception, cause, null);
		_semaphore.Release();
		lock (_readLock)
		{
			Monitor.PulseAll(_readLock);
		}
	}
}
