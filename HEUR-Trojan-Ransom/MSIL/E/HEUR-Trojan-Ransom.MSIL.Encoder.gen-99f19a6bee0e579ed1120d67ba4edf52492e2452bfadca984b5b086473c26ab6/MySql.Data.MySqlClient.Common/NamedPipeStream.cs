using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient.Common;

[SuppressUnmanagedCodeSecurity]
internal class NamedPipeStream : Stream
{
	private SafeFileHandle handle;

	private Stream fileStream;

	private int readTimeout = -1;

	private int writeTimeout = -1;

	private const int ERROR_PIPE_BUSY = 231;

	private const int ERROR_SEM_TIMEOUT = 121;

	public override bool CanRead => fileStream.CanRead;

	public override bool CanWrite => fileStream.CanWrite;

	public override bool CanSeek
	{
		get
		{
			throw new NotSupportedException(Resources.NamedPipeNoSeek);
		}
	}

	public override long Length
	{
		get
		{
			throw new NotSupportedException(Resources.NamedPipeNoSeek);
		}
	}

	public override long Position
	{
		get
		{
			throw new NotSupportedException(Resources.NamedPipeNoSeek);
		}
		set
		{
		}
	}

	public override bool CanTimeout => true;

	public override int ReadTimeout
	{
		get
		{
			return readTimeout;
		}
		set
		{
			readTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return writeTimeout;
		}
		set
		{
			writeTimeout = value;
		}
	}

	public NamedPipeStream(string path, FileAccess mode, uint timeout)
	{
		Open(path, mode, timeout);
	}

	private void CancelIo()
	{
		if (!NativeMethods.CancelIo(handle.DangerousGetHandle()))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	public void Open(string path, FileAccess mode, uint timeout)
	{
		IntPtr intPtr;
		while (true)
		{
			NativeMethods.SecurityAttributes securityAttributes = new NativeMethods.SecurityAttributes();
			securityAttributes.inheritHandle = true;
			securityAttributes.Length = Marshal.SizeOf(securityAttributes);
			intPtr = NativeMethods.CreateFile(path, 3221225472u, 0u, securityAttributes, 3u, 1073741824u, 0u);
			if (intPtr != IntPtr.Zero)
			{
				break;
			}
			if (Marshal.GetLastWin32Error() == 231)
			{
				LowResolutionStopwatch lowResolutionStopwatch = LowResolutionStopwatch.StartNew();
				bool num = NativeMethods.WaitNamedPipe(path, timeout);
				lowResolutionStopwatch.Stop();
				if (num)
				{
					timeout -= (uint)(int)lowResolutionStopwatch.ElapsedMilliseconds;
					continue;
				}
				if (timeout >= lowResolutionStopwatch.ElapsedMilliseconds && Marshal.GetLastWin32Error() != 121)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), "Error waiting for pipe");
				}
				throw new TimeoutException("Timeout waiting for named pipe");
			}
			throw new Win32Exception(Marshal.GetLastWin32Error(), "Error opening pipe");
		}
		handle = new SafeFileHandle(intPtr, ownsHandle: true);
		fileStream = new FileStream(handle, mode, 4096, isAsync: true);
	}

	public override void Flush()
	{
		fileStream.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (readTimeout == -1)
		{
			return fileStream.Read(buffer, offset, count);
		}
		IAsyncResult asyncResult = fileStream.BeginRead(buffer, offset, count, null, null);
		if (asyncResult.CompletedSynchronously)
		{
			return fileStream.EndRead(asyncResult);
		}
		if (!asyncResult.AsyncWaitHandle.WaitOne(readTimeout))
		{
			CancelIo();
			throw new TimeoutException("Timeout in named pipe read");
		}
		return fileStream.EndRead(asyncResult);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		if (writeTimeout == -1)
		{
			fileStream.Write(buffer, offset, count);
			return;
		}
		IAsyncResult asyncResult = fileStream.BeginWrite(buffer, offset, count, null, null);
		if (asyncResult.CompletedSynchronously)
		{
			fileStream.EndWrite(asyncResult);
		}
		if (!asyncResult.AsyncWaitHandle.WaitOne(readTimeout))
		{
			CancelIo();
			throw new TimeoutException("Timeout in named pipe write");
		}
		fileStream.EndWrite(asyncResult);
	}

	public override void Close()
	{
		if (handle != null && !handle.IsInvalid && !handle.IsClosed)
		{
			fileStream.Close();
			try
			{
				handle.Close();
			}
			catch (Exception)
			{
			}
		}
	}

	public override void SetLength(long length)
	{
		throw new NotSupportedException(Resources.NamedPipeNoSetLength);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(Resources.NamedPipeNoSeek);
	}

	internal static Stream Create(string pipeName, string hostname, uint timeout)
	{
		string path = ((string.Compare(hostname, "localhost", ignoreCase: true) != 0) ? $"\\\\{hostname}\\pipe\\{pipeName}" : ("\\\\.\\pipe\\" + pipeName));
		return new NamedPipeStream(path, FileAccess.ReadWrite, timeout);
	}
}
