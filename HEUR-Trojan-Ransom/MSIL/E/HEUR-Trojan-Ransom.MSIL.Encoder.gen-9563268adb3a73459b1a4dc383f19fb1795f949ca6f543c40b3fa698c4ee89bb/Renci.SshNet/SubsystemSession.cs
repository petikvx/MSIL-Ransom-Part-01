using System;
using System.Globalization;
using System.Threading;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;

namespace Renci.SshNet;

internal abstract class SubsystemSession : IDisposable, ISubsystemSession
{
	private const int SystemWaitHandleCount = 3;

	private ISession _session;

	private readonly string _subsystemName;

	private IChannelSession _channel;

	private Exception _exception;

	private EventWaitHandle _errorOccuredWaitHandle = new ManualResetEvent(initialState: false);

	private EventWaitHandle _sessionDisconnectedWaitHandle = new ManualResetEvent(initialState: false);

	private EventWaitHandle _channelClosedWaitHandle = new ManualResetEvent(initialState: false);

	private bool _isDisposed;

	public int OperationTimeout { get; private set; }

	internal IChannelSession Channel
	{
		get
		{
			EnsureNotDisposed();
			return _channel;
		}
	}

	public bool IsOpen
	{
		get
		{
			if (_channel != null)
			{
				return _channel.IsOpen;
			}
			return false;
		}
	}

	public event EventHandler<ExceptionEventArgs> ErrorOccurred;

	public event EventHandler<EventArgs> Disconnected;

	protected SubsystemSession(ISession session, string subsystemName, int operationTimeout)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (subsystemName == null)
		{
			throw new ArgumentNullException("subsystemName");
		}
		_session = session;
		_subsystemName = subsystemName;
		OperationTimeout = operationTimeout;
	}

	public void Connect()
	{
		EnsureNotDisposed();
		if (IsOpen)
		{
			throw new InvalidOperationException("The session is already connected.");
		}
		_errorOccuredWaitHandle.Reset();
		_sessionDisconnectedWaitHandle.Reset();
		_sessionDisconnectedWaitHandle.Reset();
		_channelClosedWaitHandle.Reset();
		_session.ErrorOccured += Session_ErrorOccured;
		_session.Disconnected += Session_Disconnected;
		_channel = _session.CreateChannelSession();
		_channel.DataReceived += Channel_DataReceived;
		_channel.Exception += Channel_Exception;
		_channel.Closed += Channel_Closed;
		_channel.Open();
		if (!_channel.SendSubsystemRequest(_subsystemName))
		{
			Disconnect();
			throw new SshException(string.Format(CultureInfo.InvariantCulture, "Subsystem '{0}' could not be executed.", new object[1] { _subsystemName }));
		}
		OnChannelOpen();
	}

	public void Disconnect()
	{
		UnsubscribeFromSessionEvents(_session);
		IChannelSession channel = _channel;
		if (channel != null)
		{
			_channel = null;
			channel.DataReceived -= Channel_DataReceived;
			channel.Exception -= Channel_Exception;
			channel.Closed -= Channel_Closed;
			channel.Dispose();
		}
	}

	public void SendData(byte[] data)
	{
		EnsureNotDisposed();
		EnsureSessionIsOpen();
		_channel.SendData(data);
	}

	protected abstract void OnChannelOpen();

	protected abstract void OnDataReceived(byte[] data);

	protected void RaiseError(Exception error)
	{
		_exception = error;
		_errorOccuredWaitHandle?.Set();
		SignalErrorOccurred(error);
	}

	private void Channel_DataReceived(object sender, ChannelDataEventArgs e)
	{
		try
		{
			OnDataReceived(e.Data);
		}
		catch (Exception error)
		{
			RaiseError(error);
		}
	}

	private void Channel_Exception(object sender, ExceptionEventArgs e)
	{
		RaiseError(e.Exception);
	}

	private void Channel_Closed(object sender, ChannelEventArgs e)
	{
		_channelClosedWaitHandle?.Set();
	}

	public void WaitOnHandle(WaitHandle waitHandle, int millisecondsTimeout)
	{
		int num = WaitHandle.WaitAny(new WaitHandle[4] { _errorOccuredWaitHandle, _sessionDisconnectedWaitHandle, _channelClosedWaitHandle, waitHandle }, millisecondsTimeout);
		switch (num)
		{
		case 258:
			throw new SshOperationTimeoutException("Operation has timed out.");
		case 0:
			throw _exception;
		case 1:
			throw new SshException("Connection was closed by the server.");
		case 2:
			throw new SshException("Channel was closed.");
		case 3:
			return;
		}
		throw new NotImplementedException(string.Format(CultureInfo.InvariantCulture, "WaitAny return value '{0}' is not implemented.", new object[1] { num }));
	}

	public bool WaitOne(WaitHandle waitHandle, int millisecondsTimeout)
	{
		int num = WaitHandle.WaitAny(new WaitHandle[4] { _errorOccuredWaitHandle, _sessionDisconnectedWaitHandle, _channelClosedWaitHandle, waitHandle }, millisecondsTimeout);
		return num switch
		{
			258 => false, 
			0 => throw _exception, 
			1 => throw new SshException("Connection was closed by the server."), 
			2 => throw new SshException("Channel was closed."), 
			3 => true, 
			_ => throw new NotImplementedException(string.Format(CultureInfo.InvariantCulture, "WaitAny return value '{0}' is not implemented.", new object[1] { num })), 
		};
	}

	public int WaitAny(WaitHandle waitHandle1, WaitHandle waitHandle2, int millisecondsTimeout)
	{
		int num = WaitHandle.WaitAny(new WaitHandle[5] { _errorOccuredWaitHandle, _sessionDisconnectedWaitHandle, _channelClosedWaitHandle, waitHandle1, waitHandle2 }, millisecondsTimeout);
		return num switch
		{
			258 => throw new SshOperationTimeoutException("Operation has timed out."), 
			0 => throw _exception, 
			1 => throw new SshException("Connection was closed by the server."), 
			2 => throw new SshException("Channel was closed."), 
			3 => 0, 
			4 => 1, 
			_ => throw new NotImplementedException(string.Format(CultureInfo.InvariantCulture, "WaitAny return value '{0}' is not implemented.", new object[1] { num })), 
		};
	}

	public int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout)
	{
		int num = WaitHandle.WaitAny(waitHandles, millisecondsTimeout);
		return num switch
		{
			258 => throw new SshOperationTimeoutException("Operation has timed out."), 
			0 => throw _exception, 
			1 => throw new SshException("Connection was closed by the server."), 
			2 => throw new SshException("Channel was closed."), 
			_ => num - 3, 
		};
	}

	public WaitHandle[] CreateWaitHandleArray(WaitHandle waitHandle1, WaitHandle waitHandle2)
	{
		return new WaitHandle[5] { _errorOccuredWaitHandle, _sessionDisconnectedWaitHandle, _channelClosedWaitHandle, waitHandle1, waitHandle2 };
	}

	public WaitHandle[] CreateWaitHandleArray(params WaitHandle[] waitHandles)
	{
		WaitHandle[] array = new WaitHandle[waitHandles.Length + 3];
		array[0] = _errorOccuredWaitHandle;
		array[1] = _sessionDisconnectedWaitHandle;
		array[2] = _channelClosedWaitHandle;
		for (int i = 0; i < waitHandles.Length; i++)
		{
			array[i + 3] = waitHandles[i];
		}
		return array;
	}

	private void Session_Disconnected(object sender, EventArgs e)
	{
		_sessionDisconnectedWaitHandle?.Set();
		SignalDisconnected();
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		RaiseError(e.Exception);
	}

	private void SignalErrorOccurred(Exception error)
	{
		this.ErrorOccurred?.Invoke(this, new ExceptionEventArgs(error));
	}

	private void SignalDisconnected()
	{
		this.Disconnected?.Invoke(this, new EventArgs());
	}

	private void EnsureSessionIsOpen()
	{
		if (!IsOpen)
		{
			throw new InvalidOperationException("The session is not open.");
		}
	}

	private void UnsubscribeFromSessionEvents(ISession session)
	{
		if (session != null)
		{
			session.Disconnected -= Session_Disconnected;
			session.ErrorOccured -= Session_ErrorOccured;
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
			Disconnect();
			_session = null;
			EventWaitHandle errorOccuredWaitHandle = _errorOccuredWaitHandle;
			if (errorOccuredWaitHandle != null)
			{
				_errorOccuredWaitHandle = null;
				errorOccuredWaitHandle.Dispose();
			}
			EventWaitHandle sessionDisconnectedWaitHandle = _sessionDisconnectedWaitHandle;
			if (sessionDisconnectedWaitHandle != null)
			{
				_sessionDisconnectedWaitHandle = null;
				sessionDisconnectedWaitHandle.Dispose();
			}
			EventWaitHandle channelClosedWaitHandle = _channelClosedWaitHandle;
			if (channelClosedWaitHandle != null)
			{
				_channelClosedWaitHandle = null;
				channelClosedWaitHandle.Dispose();
			}
			_isDisposed = true;
		}
	}

	~SubsystemSession()
	{
		Dispose(disposing: false);
	}

	private void EnsureNotDisposed()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}
}
