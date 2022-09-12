using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet;

public class SshCommand : IDisposable
{
	private ISession _session;

	private readonly Encoding _encoding;

	private IChannelSession _channel;

	private CommandAsyncResult _asyncResult;

	private AsyncCallback _callback;

	private EventWaitHandle _sessionErrorOccuredWaitHandle;

	private Exception _exception;

	private bool _hasError;

	private readonly object _endExecuteLock = new object();

	private StringBuilder _result;

	private StringBuilder _error;

	private bool _isDisposed;

	public string CommandText { get; private set; }

	public TimeSpan CommandTimeout { get; set; }

	public int ExitStatus { get; private set; }

	public Stream OutputStream { get; private set; }

	public Stream ExtendedOutputStream { get; private set; }

	public string Result
	{
		get
		{
			if (_result == null)
			{
				_result = new StringBuilder();
			}
			if (OutputStream != null && OutputStream.Length > 0L)
			{
				StreamReader streamReader = new StreamReader(OutputStream, _encoding);
				_result.Append(streamReader.ReadToEnd());
			}
			return _result.ToString();
		}
	}

	public string Error
	{
		get
		{
			if (_hasError)
			{
				if (_error == null)
				{
					_error = new StringBuilder();
				}
				if (ExtendedOutputStream != null && ExtendedOutputStream.Length > 0L)
				{
					StreamReader streamReader = new StreamReader(ExtendedOutputStream, _encoding);
					_error.Append(streamReader.ReadToEnd());
				}
				return _error.ToString();
			}
			return string.Empty;
		}
	}

	internal SshCommand(ISession session, string commandText, Encoding encoding)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (commandText == null)
		{
			throw new ArgumentNullException("commandText");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		_session = session;
		CommandText = commandText;
		_encoding = encoding;
		CommandTimeout = Session.InfiniteTimeSpan;
		_sessionErrorOccuredWaitHandle = new AutoResetEvent(initialState: false);
		_session.Disconnected += Session_Disconnected;
		_session.ErrorOccured += Session_ErrorOccured;
	}

	public IAsyncResult BeginExecute()
	{
		return BeginExecute(null, null);
	}

	public IAsyncResult BeginExecute(AsyncCallback callback)
	{
		return BeginExecute(callback, null);
	}

	public IAsyncResult BeginExecute(AsyncCallback callback, object state)
	{
		if (_asyncResult != null && !_asyncResult.EndCalled)
		{
			throw new InvalidOperationException("Asynchronous operation is already in progress.");
		}
		_asyncResult = new CommandAsyncResult
		{
			AsyncWaitHandle = new ManualResetEvent(initialState: false),
			IsCompleted = false,
			AsyncState = state
		};
		if (_channel != null)
		{
			throw new SshException("Invalid operation.");
		}
		if (string.IsNullOrEmpty(CommandText))
		{
			throw new ArgumentException("CommandText property is empty.");
		}
		Stream outputStream = OutputStream;
		if (outputStream != null)
		{
			outputStream.Dispose();
			OutputStream = null;
		}
		Stream extendedOutputStream = ExtendedOutputStream;
		if (extendedOutputStream != null)
		{
			extendedOutputStream.Dispose();
			ExtendedOutputStream = null;
		}
		OutputStream = new PipeStream();
		ExtendedOutputStream = new PipeStream();
		_result = null;
		_error = null;
		_callback = callback;
		_channel = CreateChannel();
		_channel.Open();
		_channel.SendExecRequest(CommandText);
		return _asyncResult;
	}

	public IAsyncResult BeginExecute(string commandText, AsyncCallback callback, object state)
	{
		CommandText = commandText;
		return BeginExecute(callback, state);
	}

	public string EndExecute(IAsyncResult asyncResult)
	{
		if (asyncResult == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		if (asyncResult is CommandAsyncResult commandAsyncResult && _asyncResult == commandAsyncResult)
		{
			lock (_endExecuteLock)
			{
				if (commandAsyncResult.EndCalled)
				{
					throw new ArgumentException("EndExecute can only be called once for each asynchronous operation.");
				}
				WaitOnHandle(_asyncResult.AsyncWaitHandle);
				UnsubscribeFromEventsAndDisposeChannel(_channel);
				_channel = null;
				commandAsyncResult.EndCalled = true;
				return Result;
			}
		}
		throw new ArgumentException($"The {typeof(IAsyncResult).Name} object was not returned from the corresponding asynchronous method on this class.");
	}

	public string Execute()
	{
		return EndExecute(BeginExecute(null, null));
	}

	public void CancelAsync()
	{
		if (_channel != null && _channel.IsOpen && _asyncResult != null)
		{
			_channel.Dispose();
		}
	}

	public string Execute(string commandText)
	{
		CommandText = commandText;
		return Execute();
	}

	private IChannelSession CreateChannel()
	{
		IChannelSession channelSession = _session.CreateChannelSession();
		channelSession.DataReceived += Channel_DataReceived;
		channelSession.ExtendedDataReceived += Channel_ExtendedDataReceived;
		channelSession.RequestReceived += Channel_RequestReceived;
		channelSession.Closed += Channel_Closed;
		return channelSession;
	}

	private void Session_Disconnected(object sender, EventArgs e)
	{
		if (!_isDisposed)
		{
			_exception = new SshConnectionException("An established connection was aborted by the software in your host machine.", DisconnectReason.ConnectionLost);
			_sessionErrorOccuredWaitHandle.Set();
		}
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		if (!_isDisposed)
		{
			_exception = e.Exception;
			_sessionErrorOccuredWaitHandle.Set();
		}
	}

	private void Channel_Closed(object sender, ChannelEventArgs e)
	{
		OutputStream?.Flush();
		ExtendedOutputStream?.Flush();
		_asyncResult.IsCompleted = true;
		if (_callback != null)
		{
			ThreadAbstraction.ExecuteThread(delegate
			{
				_callback(_asyncResult);
			});
		}
		((EventWaitHandle)_asyncResult.AsyncWaitHandle).Set();
	}

	private void Channel_RequestReceived(object sender, ChannelRequestEventArgs e)
	{
		if (e.Info is ExitStatusRequestInfo exitStatusRequestInfo)
		{
			ExitStatus = (int)exitStatusRequestInfo.ExitStatus;
			if (exitStatusRequestInfo.WantReply)
			{
				ChannelSuccessMessage message = new ChannelSuccessMessage(_channel.LocalChannelNumber);
				_session.SendMessage(message);
			}
		}
		else if (e.Info.WantReply)
		{
			ChannelFailureMessage message2 = new ChannelFailureMessage(_channel.LocalChannelNumber);
			_session.SendMessage(message2);
		}
	}

	private void Channel_ExtendedDataReceived(object sender, ChannelExtendedDataEventArgs e)
	{
		if (ExtendedOutputStream != null)
		{
			ExtendedOutputStream.Write(e.Data, 0, e.Data.Length);
			ExtendedOutputStream.Flush();
		}
		if (e.DataTypeCode == 1)
		{
			_hasError = true;
		}
	}

	private void Channel_DataReceived(object sender, ChannelDataEventArgs e)
	{
		if (OutputStream != null)
		{
			OutputStream.Write(e.Data, 0, e.Data.Length);
			OutputStream.Flush();
		}
		if (_asyncResult != null)
		{
			lock (_asyncResult)
			{
				_asyncResult.BytesReceived += e.Data.Length;
			}
		}
	}

	private void WaitOnHandle(WaitHandle waitHandle)
	{
		switch (WaitHandle.WaitAny(new WaitHandle[2] { _sessionErrorOccuredWaitHandle, waitHandle }, CommandTimeout))
		{
		case 258:
			throw new SshOperationTimeoutException(string.Format(CultureInfo.CurrentCulture, "Command '{0}' has timed out.", new object[1] { CommandText }));
		case 0:
			throw _exception;
		}
	}

	private void UnsubscribeFromEventsAndDisposeChannel(IChannel channel)
	{
		if (channel != null)
		{
			channel.DataReceived -= Channel_DataReceived;
			channel.ExtendedDataReceived -= Channel_ExtendedDataReceived;
			channel.RequestReceived -= Channel_RequestReceived;
			channel.Closed -= Channel_Closed;
			channel.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_isDisposed && disposing)
		{
			ISession session = _session;
			if (session != null)
			{
				session.Disconnected -= Session_Disconnected;
				session.ErrorOccured -= Session_ErrorOccured;
				_session = null;
			}
			IChannelSession channel = _channel;
			if (channel != null)
			{
				UnsubscribeFromEventsAndDisposeChannel(channel);
				_channel = null;
			}
			Stream outputStream = OutputStream;
			if (outputStream != null)
			{
				outputStream.Dispose();
				OutputStream = null;
			}
			Stream extendedOutputStream = ExtendedOutputStream;
			if (extendedOutputStream != null)
			{
				extendedOutputStream.Dispose();
				ExtendedOutputStream = null;
			}
			EventWaitHandle sessionErrorOccuredWaitHandle = _sessionErrorOccuredWaitHandle;
			if (sessionErrorOccuredWaitHandle != null)
			{
				sessionErrorOccuredWaitHandle.Dispose();
				_sessionErrorOccuredWaitHandle = null;
			}
			_isDisposed = true;
		}
	}

	~SshCommand()
	{
		Dispose(disposing: false);
	}
}
