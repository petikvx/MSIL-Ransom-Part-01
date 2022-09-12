using System;
using System.Globalization;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal abstract class Channel : IDisposable, IChannel
{
	private EventWaitHandle _channelClosedWaitHandle = new ManualResetEvent(initialState: false);

	private EventWaitHandle _channelServerWindowAdjustWaitHandle = new ManualResetEvent(initialState: false);

	private readonly object _serverWindowSizeLock = new object();

	private readonly uint _initialWindowSize;

	private uint? _remoteWindowSize;

	private uint? _remoteChannelNumber;

	private uint? _remotePacketSize;

	private ISession _session;

	private bool _closeMessageSent;

	private bool _closeMessageReceived;

	private bool _eofMessageReceived;

	private bool _eofMessageSent;

	private bool _isDisposed;

	protected ISession Session => _session;

	public abstract ChannelTypes ChannelType { get; }

	public uint LocalChannelNumber { get; private set; }

	public uint LocalPacketSize { get; private set; }

	public uint LocalWindowSize { get; private set; }

	public uint RemoteChannelNumber
	{
		get
		{
			if (!_remoteChannelNumber.HasValue)
			{
				throw CreateRemoteChannelInfoNotAvailableException();
			}
			return _remoteChannelNumber.Value;
		}
		private set
		{
			_remoteChannelNumber = value;
		}
	}

	public uint RemotePacketSize
	{
		get
		{
			if (!_remotePacketSize.HasValue)
			{
				throw CreateRemoteChannelInfoNotAvailableException();
			}
			return _remotePacketSize.Value;
		}
		private set
		{
			_remotePacketSize = value;
		}
	}

	public uint RemoteWindowSize
	{
		get
		{
			if (!_remoteWindowSize.HasValue)
			{
				throw CreateRemoteChannelInfoNotAvailableException();
			}
			return _remoteWindowSize.Value;
		}
		private set
		{
			_remoteWindowSize = value;
		}
	}

	public bool IsOpen { get; protected set; }

	protected bool IsConnected => _session.IsConnected;

	protected IConnectionInfo ConnectionInfo => _session.ConnectionInfo;

	protected SemaphoreLight SessionSemaphore => _session.SessionSemaphore;

	public event EventHandler<ExceptionEventArgs> Exception;

	public event EventHandler<ChannelDataEventArgs> DataReceived;

	public event EventHandler<ChannelExtendedDataEventArgs> ExtendedDataReceived;

	public event EventHandler<ChannelEventArgs> EndOfData;

	public event EventHandler<ChannelEventArgs> Closed;

	public event EventHandler<ChannelRequestEventArgs> RequestReceived;

	public event EventHandler<ChannelEventArgs> RequestSucceeded;

	public event EventHandler<ChannelEventArgs> RequestFailed;

	protected Channel(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize)
	{
		_session = session;
		_initialWindowSize = localWindowSize;
		LocalChannelNumber = localChannelNumber;
		LocalPacketSize = localPacketSize;
		LocalWindowSize = localWindowSize;
		session.ChannelWindowAdjustReceived += OnChannelWindowAdjust;
		session.ChannelDataReceived += OnChannelData;
		session.ChannelExtendedDataReceived += OnChannelExtendedData;
		session.ChannelEofReceived += OnChannelEof;
		session.ChannelCloseReceived += OnChannelClose;
		session.ChannelRequestReceived += OnChannelRequest;
		session.ChannelSuccessReceived += OnChannelSuccess;
		session.ChannelFailureReceived += OnChannelFailure;
		session.ErrorOccured += Session_ErrorOccured;
		session.Disconnected += Session_Disconnected;
	}

	protected void InitializeRemoteInfo(uint remoteChannelNumber, uint remoteWindowSize, uint remotePacketSize)
	{
		RemoteChannelNumber = remoteChannelNumber;
		RemoteWindowSize = remoteWindowSize;
		RemotePacketSize = remotePacketSize;
	}

	public void SendData(byte[] data)
	{
		SendData(data, 0, data.Length);
	}

	public void SendData(byte[] data, int offset, int size)
	{
		if (IsOpen)
		{
			int num = size;
			while (num > 0)
			{
				int dataLengthThatCanBeSentInMessage = GetDataLengthThatCanBeSentInMessage(num);
				ChannelDataMessage message = new ChannelDataMessage(RemoteChannelNumber, data, offset, dataLengthThatCanBeSentInMessage);
				_session.SendMessage(message);
				num -= dataLengthThatCanBeSentInMessage;
				offset += dataLengthThatCanBeSentInMessage;
			}
		}
	}

	protected virtual void OnWindowAdjust(uint bytesToAdd)
	{
		lock (_serverWindowSizeLock)
		{
			RemoteWindowSize += bytesToAdd;
		}
		_channelServerWindowAdjustWaitHandle.Set();
	}

	protected virtual void OnData(byte[] data)
	{
		AdjustDataWindow(data);
		this.DataReceived?.Invoke(this, new ChannelDataEventArgs(LocalChannelNumber, data));
	}

	protected virtual void OnExtendedData(byte[] data, uint dataTypeCode)
	{
		AdjustDataWindow(data);
		this.ExtendedDataReceived?.Invoke(this, new ChannelExtendedDataEventArgs(LocalChannelNumber, data, dataTypeCode));
	}

	protected virtual void OnEof()
	{
		_eofMessageReceived = true;
		this.EndOfData?.Invoke(this, new ChannelEventArgs(LocalChannelNumber));
	}

	protected virtual void OnClose()
	{
		_closeMessageReceived = true;
		_channelClosedWaitHandle?.Set();
		Close();
	}

	protected virtual void OnRequest(RequestInfo info)
	{
		this.RequestReceived?.Invoke(this, new ChannelRequestEventArgs(info));
	}

	protected virtual void OnSuccess()
	{
		this.RequestSucceeded?.Invoke(this, new ChannelEventArgs(LocalChannelNumber));
	}

	protected virtual void OnFailure()
	{
		this.RequestFailed?.Invoke(this, new ChannelEventArgs(LocalChannelNumber));
	}

	private void RaiseExceptionEvent(Exception exception)
	{
		this.Exception?.Invoke(this, new ExceptionEventArgs(exception));
	}

	private bool TrySendMessage(Message message)
	{
		return _session.TrySendMessage(message);
	}

	protected void SendMessage(Message message)
	{
		if (IsOpen)
		{
			_session.SendMessage(message);
		}
	}

	public void SendEof()
	{
		if (!IsOpen)
		{
			throw CreateChannelClosedException();
		}
		lock (this)
		{
			_session.SendMessage(new ChannelEofMessage(RemoteChannelNumber));
			_eofMessageSent = true;
		}
	}

	protected void WaitOnHandle(WaitHandle waitHandle)
	{
		_session.WaitOnHandle(waitHandle);
	}

	protected virtual void Close()
	{
		lock (this)
		{
			if (!_eofMessageSent && !_closeMessageReceived && !_eofMessageReceived && IsOpen && IsConnected && TrySendMessage(new ChannelEofMessage(RemoteChannelNumber)))
			{
				_eofMessageSent = true;
			}
			if (!_closeMessageSent && IsOpen && IsConnected && TrySendMessage(new ChannelCloseMessage(RemoteChannelNumber)))
			{
				_closeMessageSent = true;
				_session.TryWait(_channelClosedWaitHandle, ConnectionInfo.ChannelCloseTimeout);
			}
			if (IsOpen)
			{
				IsOpen = false;
				if (_closeMessageReceived)
				{
					this.Closed?.Invoke(this, new ChannelEventArgs(LocalChannelNumber));
				}
			}
		}
	}

	protected virtual void OnDisconnected()
	{
	}

	protected virtual void OnErrorOccured(Exception exp)
	{
	}

	private void Session_Disconnected(object sender, EventArgs e)
	{
		IsOpen = false;
		try
		{
			OnDisconnected();
		}
		catch (Exception ex)
		{
			OnChannelException(ex);
		}
	}

	protected void OnChannelException(Exception ex)
	{
		OnErrorOccured(ex);
		RaiseExceptionEvent(ex);
	}

	private void Session_ErrorOccured(object sender, ExceptionEventArgs e)
	{
		try
		{
			OnErrorOccured(e.Exception);
		}
		catch (Exception exception)
		{
			RaiseExceptionEvent(exception);
		}
	}

	private void OnChannelWindowAdjust(object sender, MessageEventArgs<ChannelWindowAdjustMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnWindowAdjust(e.Message.BytesToAdd);
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelData(object sender, MessageEventArgs<ChannelDataMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnData(e.Message.Data);
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelExtendedData(object sender, MessageEventArgs<ChannelExtendedDataMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnExtendedData(e.Message.Data, e.Message.DataTypeCode);
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelEof(object sender, MessageEventArgs<ChannelEofMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnEof();
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelClose(object sender, MessageEventArgs<ChannelCloseMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnClose();
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelRequest(object sender, MessageEventArgs<ChannelRequestMessage> e)
	{
		if (e.Message.LocalChannelNumber != LocalChannelNumber)
		{
			return;
		}
		try
		{
			if (!_session.ConnectionInfo.ChannelRequests.TryGetValue(e.Message.RequestName, out var value))
			{
				throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Request '{0}' is not supported.", new object[1] { e.Message.RequestName }));
			}
			value.Load(e.Message.RequestData);
			OnRequest(value);
		}
		catch (Exception ex)
		{
			OnChannelException(ex);
		}
	}

	private void OnChannelSuccess(object sender, MessageEventArgs<ChannelSuccessMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnSuccess();
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelFailure(object sender, MessageEventArgs<ChannelFailureMessage> e)
	{
		if (e.Message.LocalChannelNumber == LocalChannelNumber)
		{
			try
			{
				OnFailure();
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void AdjustDataWindow(byte[] messageData)
	{
		LocalWindowSize -= (uint)messageData.Length;
		if (LocalWindowSize < LocalPacketSize)
		{
			SendMessage(new ChannelWindowAdjustMessage(RemoteChannelNumber, _initialWindowSize - LocalWindowSize));
			LocalWindowSize = _initialWindowSize;
		}
	}

	private int GetDataLengthThatCanBeSentInMessage(int messageLength)
	{
		while (true)
		{
			lock (_serverWindowSizeLock)
			{
				uint remoteWindowSize = RemoteWindowSize;
				if (remoteWindowSize != 0)
				{
					uint num = Math.Min(Math.Min(RemotePacketSize, (uint)messageLength), remoteWindowSize);
					RemoteWindowSize -= num;
					return (int)num;
				}
				_channelServerWindowAdjustWaitHandle.Reset();
			}
			WaitOnHandle(_channelServerWindowAdjustWaitHandle);
		}
	}

	private static InvalidOperationException CreateRemoteChannelInfoNotAvailableException()
	{
		throw new InvalidOperationException("The channel has not been opened, or the open has not yet been confirmed.");
	}

	private static InvalidOperationException CreateChannelClosedException()
	{
		throw new InvalidOperationException("The channel is closed.");
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
			Close();
			ISession session = _session;
			if (session != null)
			{
				_session = null;
				session.ChannelWindowAdjustReceived -= OnChannelWindowAdjust;
				session.ChannelDataReceived -= OnChannelData;
				session.ChannelExtendedDataReceived -= OnChannelExtendedData;
				session.ChannelEofReceived -= OnChannelEof;
				session.ChannelCloseReceived -= OnChannelClose;
				session.ChannelRequestReceived -= OnChannelRequest;
				session.ChannelSuccessReceived -= OnChannelSuccess;
				session.ChannelFailureReceived -= OnChannelFailure;
				session.ErrorOccured -= Session_ErrorOccured;
				session.Disconnected -= Session_Disconnected;
			}
			EventWaitHandle channelClosedWaitHandle = _channelClosedWaitHandle;
			if (channelClosedWaitHandle != null)
			{
				_channelClosedWaitHandle = null;
				channelClosedWaitHandle.Dispose();
			}
			EventWaitHandle channelServerWindowAdjustWaitHandle = _channelServerWindowAdjustWaitHandle;
			if (channelServerWindowAdjustWaitHandle != null)
			{
				_channelServerWindowAdjustWaitHandle = null;
				channelServerWindowAdjustWaitHandle.Dispose();
			}
			_isDisposed = true;
		}
	}

	~Channel()
	{
		Dispose(disposing: false);
	}
}
