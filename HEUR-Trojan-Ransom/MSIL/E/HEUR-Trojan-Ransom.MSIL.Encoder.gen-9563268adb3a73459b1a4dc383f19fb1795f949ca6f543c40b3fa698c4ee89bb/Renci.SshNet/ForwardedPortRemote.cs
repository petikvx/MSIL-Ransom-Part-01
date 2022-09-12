using System;
using System.Globalization;
using System.Net;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet;

public class ForwardedPortRemote : ForwardedPort, IDisposable
{
	private ForwardedPortStatus _status;

	private bool _requestStatus;

	private EventWaitHandle _globalRequestResponse = new AutoResetEvent(initialState: false);

	private CountdownEvent _pendingChannelCountdown;

	private bool _isDisposed;

	public override bool IsStarted => _status == ForwardedPortStatus.Started;

	public IPAddress BoundHostAddress { get; private set; }

	public string BoundHost => BoundHostAddress.ToString();

	public uint BoundPort { get; private set; }

	public IPAddress HostAddress { get; private set; }

	public string Host => HostAddress.ToString();

	public uint Port { get; private set; }

	public ForwardedPortRemote(IPAddress boundHostAddress, uint boundPort, IPAddress hostAddress, uint port)
	{
		if (boundHostAddress == null)
		{
			throw new ArgumentNullException("boundHostAddress");
		}
		if (hostAddress == null)
		{
			throw new ArgumentNullException("hostAddress");
		}
		boundPort.ValidatePort("boundPort");
		port.ValidatePort("port");
		BoundHostAddress = boundHostAddress;
		BoundPort = boundPort;
		HostAddress = hostAddress;
		Port = port;
		_status = ForwardedPortStatus.Stopped;
	}

	public ForwardedPortRemote(uint boundPort, string host, uint port)
		: this(string.Empty, boundPort, host, port)
	{
	}

	public ForwardedPortRemote(string boundHost, uint boundPort, string host, uint port)
		: this(DnsAbstraction.GetHostAddresses(boundHost)[0], boundPort, DnsAbstraction.GetHostAddresses(host)[0], port)
	{
	}

	protected override void StartPort()
	{
		if (!ForwardedPortStatus.ToStarting(ref _status))
		{
			return;
		}
		InitializePendingChannelCountdown();
		try
		{
			base.Session.RegisterMessage("SSH_MSG_REQUEST_FAILURE");
			base.Session.RegisterMessage("SSH_MSG_REQUEST_SUCCESS");
			base.Session.RegisterMessage("SSH_MSG_CHANNEL_OPEN");
			base.Session.RequestSuccessReceived += Session_RequestSuccess;
			base.Session.RequestFailureReceived += Session_RequestFailure;
			base.Session.ChannelOpenReceived += Session_ChannelOpening;
			base.Session.SendMessage(new TcpIpForwardGlobalRequestMessage(BoundHost, BoundPort));
			base.Session.WaitOnHandle(_globalRequestResponse);
			if (!_requestStatus)
			{
				throw new SshException(string.Format(CultureInfo.CurrentCulture, "Port forwarding for '{0}' port '{1}' failed to start.", new object[2] { Host, Port }));
			}
		}
		catch (Exception)
		{
			_status = ForwardedPortStatus.Stopped;
			base.Session.RequestSuccessReceived -= Session_RequestSuccess;
			base.Session.RequestFailureReceived -= Session_RequestFailure;
			base.Session.ChannelOpenReceived -= Session_ChannelOpening;
			throw;
		}
		_status = ForwardedPortStatus.Started;
	}

	protected override void StopPort(TimeSpan timeout)
	{
		if (ForwardedPortStatus.ToStopping(ref _status))
		{
			base.StopPort(timeout);
			base.Session.SendMessage(new CancelTcpIpForwardGlobalRequestMessage(BoundHost, BoundPort));
			WaitHandle.WaitAny(new WaitHandle[2]
			{
				_globalRequestResponse,
				base.Session.MessageListenerCompleted
			}, timeout);
			base.Session.RequestSuccessReceived -= Session_RequestSuccess;
			base.Session.RequestFailureReceived -= Session_RequestFailure;
			base.Session.ChannelOpenReceived -= Session_ChannelOpening;
			_pendingChannelCountdown.Signal();
			_pendingChannelCountdown.Wait(timeout);
			_status = ForwardedPortStatus.Stopped;
		}
	}

	protected override void CheckDisposed()
	{
		if (_isDisposed)
		{
			throw new ObjectDisposedException(GetType().FullName);
		}
	}

	private void Session_ChannelOpening(object sender, MessageEventArgs<ChannelOpenMessage> e)
	{
		ChannelOpenMessage channelOpenMessage = e.Message;
		ForwardedTcpipChannelInfo info = channelOpenMessage.Info as ForwardedTcpipChannelInfo;
		if (info == null || !(info.ConnectedAddress == BoundHost) || info.ConnectedPort != BoundPort)
		{
			return;
		}
		if (!IsStarted)
		{
			base.Session.SendMessage(new ChannelOpenFailureMessage(channelOpenMessage.LocalChannelNumber, "", 1u));
			return;
		}
		ThreadAbstraction.ExecuteThread(delegate
		{
			CountdownEvent pendingChannelCountdown = _pendingChannelCountdown;
			pendingChannelCountdown.AddCount();
			try
			{
				RaiseRequestReceived(info.OriginatorAddress, info.OriginatorPort);
				using IChannelForwardedTcpip channelForwardedTcpip = base.Session.CreateChannelForwardedTcpip(channelOpenMessage.LocalChannelNumber, channelOpenMessage.InitialWindowSize, channelOpenMessage.MaximumPacketSize);
				channelForwardedTcpip.Exception += Channel_Exception;
				channelForwardedTcpip.Bind(new IPEndPoint(HostAddress, (int)Port), this);
			}
			catch (Exception exception)
			{
				RaiseExceptionEvent(exception);
			}
			finally
			{
				try
				{
					pendingChannelCountdown.Signal();
				}
				catch (ObjectDisposedException)
				{
				}
			}
		});
	}

	private void InitializePendingChannelCountdown()
	{
		Interlocked.Exchange(ref _pendingChannelCountdown, new CountdownEvent(1))?.Dispose();
	}

	private void Channel_Exception(object sender, ExceptionEventArgs e)
	{
		RaiseExceptionEvent(e.Exception);
	}

	private void Session_RequestFailure(object sender, EventArgs e)
	{
		_requestStatus = false;
		_globalRequestResponse.Set();
	}

	private void Session_RequestSuccess(object sender, MessageEventArgs<RequestSuccessMessage> e)
	{
		_requestStatus = true;
		if (BoundPort == 0)
		{
			BoundPort = (e.Message.BoundPort.HasValue ? e.Message.BoundPort.Value : 0u);
		}
		_globalRequestResponse.Set();
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected override void Dispose(bool disposing)
	{
		if (_isDisposed)
		{
			return;
		}
		base.Dispose(disposing);
		if (disposing)
		{
			ISession session = base.Session;
			if (session != null)
			{
				base.Session = null;
				session.RequestSuccessReceived -= Session_RequestSuccess;
				session.RequestFailureReceived -= Session_RequestFailure;
				session.ChannelOpenReceived -= Session_ChannelOpening;
			}
			EventWaitHandle globalRequestResponse = _globalRequestResponse;
			if (globalRequestResponse != null)
			{
				_globalRequestResponse = null;
				globalRequestResponse.Dispose();
			}
			CountdownEvent pendingChannelCountdown = _pendingChannelCountdown;
			if (pendingChannelCountdown != null)
			{
				_pendingChannelCountdown = null;
				pendingChannelCountdown.Dispose();
			}
		}
		_isDisposed = true;
	}

	~ForwardedPortRemote()
	{
		Dispose(disposing: false);
	}
}
