using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp.Requests;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp;

internal class SftpSession : SubsystemSession, IDisposable, ISubsystemSession, ISftpSession
{
	internal const int MaximumSupportedVersion = 3;

	private const int MinimumSupportedVersion = 0;

	private readonly Dictionary<uint, SftpRequest> _requests = new Dictionary<uint, SftpRequest>();

	private readonly ISftpResponseFactory _sftpResponseFactory;

	private readonly List<byte> _data = new List<byte>(32768);

	private EventWaitHandle _sftpVersionConfirmed = new AutoResetEvent(initialState: false);

	private IDictionary<string, string> _supportedExtensions;

	private long _requestId;

	protected Encoding Encoding { get; private set; }

	public string WorkingDirectory { get; private set; }

	public uint ProtocolVersion { get; private set; }

	public uint NextRequestId => (uint)Interlocked.Increment(ref _requestId);

	public SftpSession(ISession session, int operationTimeout, Encoding encoding, ISftpResponseFactory sftpResponseFactory)
		: base(session, "sftp", operationTimeout)
	{
		Encoding = encoding;
		_sftpResponseFactory = sftpResponseFactory;
	}

	public void ChangeDirectory(string path)
	{
		string canonicalPath = GetCanonicalPath(path);
		byte[] handle = RequestOpenDir(canonicalPath);
		RequestClose(handle);
		WorkingDirectory = canonicalPath;
	}

	internal void SendMessage(SftpMessage sftpMessage)
	{
		byte[] bytes = sftpMessage.GetBytes();
		SendData(bytes);
	}

	public string GetCanonicalPath(string path)
	{
		string fullRemotePath = GetFullRemotePath(path);
		string text = string.Empty;
		KeyValuePair<string, SftpFileAttributes>[] array = RequestRealPath(fullRemotePath, nullOnError: true);
		if (array != null)
		{
			text = array[0].Key;
		}
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		if (!fullRemotePath.EndsWith("/.", StringComparison.OrdinalIgnoreCase) && !fullRemotePath.EndsWith("/..", StringComparison.OrdinalIgnoreCase) && !fullRemotePath.Equals("/", StringComparison.OrdinalIgnoreCase) && fullRemotePath.IndexOf('/') >= 0)
		{
			string[] array2 = fullRemotePath.Split(new char[1] { '/' });
			string text2 = string.Join("/", array2, 0, array2.Length - 1);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "/";
			}
			array = RequestRealPath(text2, nullOnError: true);
			if (array != null)
			{
				text = array[0].Key;
			}
			if (string.IsNullOrEmpty(text))
			{
				return fullRemotePath;
			}
			string text3 = string.Empty;
			if (text[text.Length - 1] != '/')
			{
				text3 = "/";
			}
			return string.Format(CultureInfo.InvariantCulture, "{0}{1}{2}", new object[3]
			{
				text,
				text3,
				array2[^1]
			});
		}
		return fullRemotePath;
	}

	public ISftpFileReader CreateFileReader(byte[] handle, ISftpSession sftpSession, uint chunkSize, int maxPendingReads, long? fileSize)
	{
		return new SftpFileReader(handle, sftpSession, chunkSize, maxPendingReads, fileSize);
	}

	internal string GetFullRemotePath(string path)
	{
		string result = path;
		if (!string.IsNullOrEmpty(path) && path[0] != '/' && WorkingDirectory != null)
		{
			result = ((WorkingDirectory[WorkingDirectory.Length - 1] != '/') ? string.Format(CultureInfo.InvariantCulture, "{0}/{1}", new object[2] { WorkingDirectory, path }) : string.Format(CultureInfo.InvariantCulture, "{0}{1}", new object[2] { WorkingDirectory, path }));
		}
		return result;
	}

	protected override void OnChannelOpen()
	{
		SendMessage(new SftpInitRequest(3u));
		WaitOnHandle(_sftpVersionConfirmed, base.OperationTimeout);
		if (ProtocolVersion > 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Server SFTP version {0} is not supported.", new object[1] { ProtocolVersion }));
		}
		_ = ProtocolVersion;
		WorkingDirectory = RequestRealPath(".")[0].Key;
	}

	protected override void OnDataReceived(byte[] data)
	{
		int num = 0;
		int num2 = data.Length;
		if (_data.Count == 0)
		{
			while (num2 >= 5)
			{
				int num3 = (data[num] << 24) | (data[num + 1] << 16) | (data[num + 2] << 8) | data[num + 3];
				int num4 = num3 + 4;
				if (num2 < num4)
				{
					break;
				}
				if (TryLoadSftpMessage(data, num + 4, num3))
				{
					num2 -= num4;
					num += num4;
					continue;
				}
				return;
			}
			if (num2 != 0)
			{
				if (num > 0)
				{
					byte[] array = new byte[num2];
					Buffer.BlockCopy(data, num, array, 0, num2);
					_data.AddRange(array);
				}
				else
				{
					_data.AddRange(data);
				}
			}
			return;
		}
		_data.AddRange(data);
		while (_data.Count >= 5)
		{
			int num5 = (_data[0] << 24) | (_data[1] << 16) | (_data[2] << 8) | _data[3];
			int num6 = num5 + 4;
			if (_data.Count >= num6)
			{
				byte[] array2 = new byte[num5];
				_data.CopyTo(4, array2, 0, num5);
				if (_data.Count == num6)
				{
					_data.Clear();
				}
				else
				{
					_data.RemoveRange(0, num6);
				}
				if (!TryLoadSftpMessage(array2, 0, num5))
				{
					break;
				}
				continue;
			}
			break;
		}
	}

	private bool TryLoadSftpMessage(byte[] packetData, int offset, int count)
	{
		SftpMessage sftpMessage = _sftpResponseFactory.Create(ProtocolVersion, packetData[offset], Encoding);
		sftpMessage.Load(packetData, offset + 1, count - 1);
		try
		{
			if (sftpMessage is SftpVersionResponse sftpVersionResponse)
			{
				ProtocolVersion = sftpVersionResponse.Version;
				_supportedExtensions = sftpVersionResponse.Extentions;
				_sftpVersionConfirmed.Set();
			}
			else
			{
				HandleResponse(sftpMessage as SftpResponse);
			}
			return true;
		}
		catch (Exception error)
		{
			RaiseError(error);
			return false;
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			EventWaitHandle sftpVersionConfirmed = _sftpVersionConfirmed;
			if (sftpVersionConfirmed != null)
			{
				_sftpVersionConfirmed = null;
				sftpVersionConfirmed.Dispose();
			}
		}
	}

	private void SendRequest(SftpRequest request)
	{
		lock (_requests)
		{
			_requests.Add(request.RequestId, request);
		}
		SendMessage(request);
	}

	public byte[] RequestOpen(string path, Flags flags, bool nullOnError = false)
	{
		byte[] handle = null;
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpOpenRequest request = new SftpOpenRequest(ProtocolVersion, NextRequestId, path, Encoding, flags, delegate(SftpHandleResponse response)
			{
				handle = response.Handle;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return handle;
	}

	public SftpOpenAsyncResult BeginOpen(string path, Flags flags, AsyncCallback callback, object state)
	{
		SftpOpenAsyncResult asyncResult = new SftpOpenAsyncResult(callback, state);
		SftpOpenRequest request = new SftpOpenRequest(ProtocolVersion, NextRequestId, path, Encoding, flags, delegate(SftpHandleResponse response)
		{
			asyncResult.SetAsCompleted(response.Handle, completedSynchronously: false);
		}, delegate(SftpStatusResponse response)
		{
			asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
		});
		SendRequest(request);
		return asyncResult;
	}

	public byte[] EndOpen(SftpOpenAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndOpen has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			return asyncResult.EndInvoke();
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		return asyncResult.EndInvoke();
	}

	public void RequestClose(byte[] handle)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpCloseRequest request = new SftpCloseRequest(ProtocolVersion, NextRequestId, handle, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public SftpCloseAsyncResult BeginClose(byte[] handle, AsyncCallback callback, object state)
	{
		SftpCloseAsyncResult asyncResult = new SftpCloseAsyncResult(callback, state);
		SftpCloseRequest request = new SftpCloseRequest(ProtocolVersion, NextRequestId, handle, delegate(SftpStatusResponse response)
		{
			asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
		});
		SendRequest(request);
		return asyncResult;
	}

	public void EndClose(SftpCloseAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndClose has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			asyncResult.EndInvoke();
			return;
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		asyncResult.EndInvoke();
	}

	public SftpReadAsyncResult BeginRead(byte[] handle, ulong offset, uint length, AsyncCallback callback, object state)
	{
		SftpReadAsyncResult asyncResult = new SftpReadAsyncResult(callback, state);
		SftpReadRequest request = new SftpReadRequest(ProtocolVersion, NextRequestId, handle, offset, length, delegate(SftpDataResponse response)
		{
			asyncResult.SetAsCompleted(response.Data, completedSynchronously: false);
		}, delegate(SftpStatusResponse response)
		{
			if (response.StatusCode != StatusCodes.Eof)
			{
				asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
			}
			else
			{
				asyncResult.SetAsCompleted(Array<byte>.Empty, completedSynchronously: false);
			}
		});
		SendRequest(request);
		return asyncResult;
	}

	public byte[] EndRead(SftpReadAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndRead has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			return asyncResult.EndInvoke();
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		return asyncResult.EndInvoke();
	}

	public byte[] RequestRead(byte[] handle, ulong offset, uint length)
	{
		SshException exception = null;
		byte[] data = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpReadRequest request = new SftpReadRequest(ProtocolVersion, NextRequestId, handle, offset, length, delegate(SftpDataResponse response)
			{
				data = response.Data;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				if (response.StatusCode != StatusCodes.Eof)
				{
					exception = GetSftpException(response);
				}
				else
				{
					data = Array<byte>.Empty;
				}
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
		return data;
	}

	public void RequestWrite(byte[] handle, ulong serverOffset, byte[] data, int offset, int length, AutoResetEvent wait, Action<SftpStatusResponse> writeCompleted = null)
	{
		SshException exception = null;
		SftpWriteRequest request = new SftpWriteRequest(ProtocolVersion, NextRequestId, handle, serverOffset, data, offset, length, delegate(SftpStatusResponse response)
		{
			if (writeCompleted != null)
			{
				writeCompleted(response);
			}
			exception = GetSftpException(response);
			if (wait != null)
			{
				wait.Set();
			}
		});
		SendRequest(request);
		if (wait != null)
		{
			WaitOnHandle(wait, base.OperationTimeout);
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public SftpFileAttributes RequestLStat(string path)
	{
		SshException exception = null;
		SftpFileAttributes attributes = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpLStatRequest request = new SftpLStatRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpAttrsResponse response)
			{
				attributes = response.Attributes;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
		return attributes;
	}

	public SFtpStatAsyncResult BeginLStat(string path, AsyncCallback callback, object state)
	{
		SFtpStatAsyncResult asyncResult = new SFtpStatAsyncResult(callback, state);
		SftpLStatRequest request = new SftpLStatRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpAttrsResponse response)
		{
			asyncResult.SetAsCompleted(response.Attributes, completedSynchronously: false);
		}, delegate(SftpStatusResponse response)
		{
			asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
		});
		SendRequest(request);
		return asyncResult;
	}

	public SftpFileAttributes EndLStat(SFtpStatAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndLStat has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			return asyncResult.EndInvoke();
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		return asyncResult.EndInvoke();
	}

	public SftpFileAttributes RequestFStat(byte[] handle, bool nullOnError)
	{
		SshException exception = null;
		SftpFileAttributes attributes = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpFStatRequest request = new SftpFStatRequest(ProtocolVersion, NextRequestId, handle, delegate(SftpAttrsResponse response)
			{
				attributes = response.Attributes;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null && !nullOnError)
		{
			throw exception;
		}
		return attributes;
	}

	public void RequestSetStat(string path, SftpFileAttributes attributes)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpSetStatRequest request = new SftpSetStatRequest(ProtocolVersion, NextRequestId, path, Encoding, attributes, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public void RequestFSetStat(byte[] handle, SftpFileAttributes attributes)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpFSetStatRequest request = new SftpFSetStatRequest(ProtocolVersion, NextRequestId, handle, attributes, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public byte[] RequestOpenDir(string path, bool nullOnError = false)
	{
		SshException exception = null;
		byte[] handle = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpOpenDirRequest request = new SftpOpenDirRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpHandleResponse response)
			{
				handle = response.Handle;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return handle;
	}

	public KeyValuePair<string, SftpFileAttributes>[] RequestReadDir(byte[] handle)
	{
		SshException exception = null;
		KeyValuePair<string, SftpFileAttributes>[] result = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpReadDirRequest request = new SftpReadDirRequest(ProtocolVersion, NextRequestId, handle, delegate(SftpNameResponse response)
			{
				result = response.Files;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				if (response.StatusCode != StatusCodes.Eof)
				{
					exception = GetSftpException(response);
				}
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
		return result;
	}

	public void RequestRemove(string path)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpRemoveRequest request = new SftpRemoveRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public void RequestMkDir(string path)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpMkDirRequest request = new SftpMkDirRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public void RequestRmDir(string path)
	{
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpRmDirRequest request = new SftpRmDirRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	internal KeyValuePair<string, SftpFileAttributes>[] RequestRealPath(string path, bool nullOnError = false)
	{
		SshException exception = null;
		KeyValuePair<string, SftpFileAttributes>[] result = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpRealPathRequest request = new SftpRealPathRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpNameResponse response)
			{
				result = response.Files;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return result;
	}

	public SftpRealPathAsyncResult BeginRealPath(string path, AsyncCallback callback, object state)
	{
		SftpRealPathAsyncResult asyncResult = new SftpRealPathAsyncResult(callback, state);
		SftpRealPathRequest request = new SftpRealPathRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpNameResponse response)
		{
			asyncResult.SetAsCompleted(response.Files[0].Key, completedSynchronously: false);
		}, delegate(SftpStatusResponse response)
		{
			asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
		});
		SendRequest(request);
		return asyncResult;
	}

	public string EndRealPath(SftpRealPathAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndRealPath has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			return asyncResult.EndInvoke();
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		return asyncResult.EndInvoke();
	}

	public SftpFileAttributes RequestStat(string path, bool nullOnError = false)
	{
		SshException exception = null;
		SftpFileAttributes attributes = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpStatRequest request = new SftpStatRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpAttrsResponse response)
			{
				attributes = response.Attributes;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return attributes;
	}

	public SFtpStatAsyncResult BeginStat(string path, AsyncCallback callback, object state)
	{
		SFtpStatAsyncResult asyncResult = new SFtpStatAsyncResult(callback, state);
		SftpStatRequest request = new SftpStatRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpAttrsResponse response)
		{
			asyncResult.SetAsCompleted(response.Attributes, completedSynchronously: false);
		}, delegate(SftpStatusResponse response)
		{
			asyncResult.SetAsCompleted(GetSftpException(response), completedSynchronously: false);
		});
		SendRequest(request);
		return asyncResult;
	}

	public SftpFileAttributes EndStat(SFtpStatAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult.EndInvokeCalled)
		{
			throw new InvalidOperationException("EndStat has already been called.");
		}
		if (asyncResult.IsCompleted)
		{
			return asyncResult.EndInvoke();
		}
		using WaitHandle waitHandle = asyncResult.AsyncWaitHandle;
		WaitOnHandle(waitHandle, base.OperationTimeout);
		return asyncResult.EndInvoke();
	}

	public void RequestRename(string oldPath, string newPath)
	{
		if (ProtocolVersion < 2)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_RENAME operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpRenameRequest request = new SftpRenameRequest(ProtocolVersion, NextRequestId, oldPath, newPath, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	internal KeyValuePair<string, SftpFileAttributes>[] RequestReadLink(string path, bool nullOnError = false)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_READLINK operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		KeyValuePair<string, SftpFileAttributes>[] result = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpReadLinkRequest request = new SftpReadLinkRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpNameResponse response)
			{
				result = response.Files;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return result;
	}

	public void RequestSymLink(string linkpath, string targetpath)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_SYMLINK operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			SftpSymLinkRequest request = new SftpSymLinkRequest(ProtocolVersion, NextRequestId, linkpath, targetpath, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			SendRequest(request);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public void RequestPosixRename(string oldPath, string newPath)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_EXTENDED operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			PosixRenameRequest posixRenameRequest = new PosixRenameRequest(ProtocolVersion, NextRequestId, oldPath, newPath, Encoding, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			if (!_supportedExtensions.ContainsKey(posixRenameRequest.Name))
			{
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Extension method {0} currently not supported by the server.", new object[1] { posixRenameRequest.Name }));
			}
			SendRequest(posixRenameRequest);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public SftpFileSytemInformation RequestStatVfs(string path, bool nullOnError = false)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_EXTENDED operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		SftpFileSytemInformation information = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			StatVfsRequest statVfsRequest = new StatVfsRequest(ProtocolVersion, NextRequestId, path, Encoding, delegate(SftpExtendedReplyResponse response)
			{
				information = response.GetReply<StatVfsReplyInfo>().Information;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			if (!_supportedExtensions.ContainsKey(statVfsRequest.Name))
			{
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Extension method {0} currently not supported by the server.", new object[1] { statVfsRequest.Name }));
			}
			SendRequest(statVfsRequest);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return information;
	}

	internal SftpFileSytemInformation RequestFStatVfs(byte[] handle, bool nullOnError = false)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_EXTENDED operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		SftpFileSytemInformation information = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			FStatVfsRequest fStatVfsRequest = new FStatVfsRequest(ProtocolVersion, NextRequestId, handle, delegate(SftpExtendedReplyResponse response)
			{
				information = response.GetReply<StatVfsReplyInfo>().Information;
				wait.Set();
			}, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			if (!_supportedExtensions.ContainsKey(fStatVfsRequest.Name))
			{
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Extension method {0} currently not supported by the server.", new object[1] { fStatVfsRequest.Name }));
			}
			SendRequest(fStatVfsRequest);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (!nullOnError && exception != null)
		{
			throw exception;
		}
		return information;
	}

	internal void HardLink(string oldPath, string newPath)
	{
		if (ProtocolVersion < 3)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "SSH_FXP_EXTENDED operation is not supported in {0} version that server operates in.", new object[1] { ProtocolVersion }));
		}
		SshException exception = null;
		AutoResetEvent wait = new AutoResetEvent(initialState: false);
		try
		{
			HardLinkRequest hardLinkRequest = new HardLinkRequest(ProtocolVersion, NextRequestId, oldPath, newPath, delegate(SftpStatusResponse response)
			{
				exception = GetSftpException(response);
				wait.Set();
			});
			if (!_supportedExtensions.ContainsKey(hardLinkRequest.Name))
			{
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Extension method {0} currently not supported by the server.", new object[1] { hardLinkRequest.Name }));
			}
			SendRequest(hardLinkRequest);
			WaitOnHandle(wait, base.OperationTimeout);
		}
		finally
		{
			if (wait != null)
			{
				((IDisposable)wait).Dispose();
			}
		}
		if (exception != null)
		{
			throw exception;
		}
	}

	public uint CalculateOptimalReadLength(uint bufferSize)
	{
		uint localPacketSize = base.Channel.LocalPacketSize;
		return Math.Min(bufferSize, localPacketSize) - 13;
	}

	public uint CalculateOptimalWriteLength(uint bufferSize, byte[] handle)
	{
		uint num = (uint)(25 + handle.Length);
		uint remotePacketSize = base.Channel.RemotePacketSize;
		return Math.Min(bufferSize, remotePacketSize) - num;
	}

	private static SshException GetSftpException(SftpStatusResponse response)
	{
		return response.StatusCode switch
		{
			StatusCodes.Ok => null, 
			StatusCodes.NoSuchFile => new SftpPathNotFoundException(response.ErrorMessage), 
			StatusCodes.PermissionDenied => new SftpPermissionDeniedException(response.ErrorMessage), 
			_ => new SshException(response.ErrorMessage), 
		};
	}

	private void HandleResponse(SftpResponse response)
	{
		SftpRequest value;
		lock (_requests)
		{
			_requests.TryGetValue(response.ResponseId, out value);
			if (value != null)
			{
				_requests.Remove(response.ResponseId);
			}
		}
		if (value == null)
		{
			throw new InvalidOperationException("Invalid response.");
		}
		value.Complete(response);
	}
}
