using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal sealed class ChannelSession : ClientChannel, IDisposable, IChannel, IChannelSession
{
	private int _failedOpenAttempts;

	private int _sessionSemaphoreObtained;

	private EventWaitHandle _channelOpenResponseWaitHandle = new AutoResetEvent(initialState: false);

	private EventWaitHandle _channelRequestResponse = new ManualResetEvent(initialState: false);

	private bool _channelRequestSucces;

	public override ChannelTypes ChannelType => ChannelTypes.Session;

	public ChannelSession(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize)
		: base(session, localChannelNumber, localWindowSize, localPacketSize)
	{
	}

	public void Open()
	{
		while (!base.IsOpen && _failedOpenAttempts < base.ConnectionInfo.RetryAttempts)
		{
			SendChannelOpenMessage();
			try
			{
				WaitOnHandle(_channelOpenResponseWaitHandle);
			}
			catch (Exception)
			{
				ReleaseSemaphore();
				throw;
			}
		}
		if (!base.IsOpen)
		{
			throw new SshException(string.Format(CultureInfo.CurrentCulture, "Failed to open a channel after {0} attempts.", new object[1] { _failedOpenAttempts }));
		}
	}

	protected override void OnOpenConfirmation(uint remoteChannelNumber, uint initialWindowSize, uint maximumPacketSize)
	{
		base.OnOpenConfirmation(remoteChannelNumber, initialWindowSize, maximumPacketSize);
		_channelOpenResponseWaitHandle.Set();
	}

	protected override void OnOpenFailure(uint reasonCode, string description, string language)
	{
		_failedOpenAttempts++;
		ReleaseSemaphore();
		_channelOpenResponseWaitHandle.Set();
	}

	protected override void Close()
	{
		base.Close();
		ReleaseSemaphore();
	}

	public bool SendPseudoTerminalRequest(string environmentVariable, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new PseudoTerminalRequestInfo(environmentVariable, columns, rows, width, height, terminalModeValues)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendX11ForwardingRequest(bool isSingleConnection, string protocol, byte[] cookie, uint screenNumber)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new X11ForwardingRequestInfo(isSingleConnection, protocol, cookie, screenNumber)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendEnvironmentVariableRequest(string variableName, string variableValue)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new EnvironmentVariableRequestInfo(variableName, variableValue)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendShellRequest()
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new ShellRequestInfo()));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendExecRequest(string command)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new ExecRequestInfo(command, base.ConnectionInfo.Encoding)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendBreakRequest(uint breakLength)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new BreakRequestInfo(breakLength)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendSubsystemRequest(string subsystem)
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new SubsystemRequestInfo(subsystem)));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendWindowChangeRequest(uint columns, uint rows, uint width, uint height)
	{
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new WindowChangeRequestInfo(columns, rows, width, height)));
		return true;
	}

	public bool SendLocalFlowRequest(bool clientCanDo)
	{
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new XonXoffRequestInfo(clientCanDo)));
		return true;
	}

	public bool SendSignalRequest(string signalName)
	{
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new SignalRequestInfo(signalName)));
		return true;
	}

	public bool SendExitStatusRequest(uint exitStatus)
	{
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new ExitStatusRequestInfo(exitStatus)));
		return true;
	}

	public bool SendExitSignalRequest(string signalName, bool coreDumped, string errorMessage, string language)
	{
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new ExitSignalRequestInfo(signalName, coreDumped, errorMessage, language)));
		return true;
	}

	public bool SendEndOfWriteRequest()
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new EndOfWriteRequestInfo()));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	public bool SendKeepAliveRequest()
	{
		_channelRequestResponse.Reset();
		SendMessage(new ChannelRequestMessage(base.RemoteChannelNumber, new KeepAliveRequestInfo()));
		WaitOnHandle(_channelRequestResponse);
		return _channelRequestSucces;
	}

	protected override void OnSuccess()
	{
		base.OnSuccess();
		_channelRequestSucces = true;
		_channelRequestResponse?.Set();
	}

	protected override void OnFailure()
	{
		base.OnFailure();
		_channelRequestSucces = false;
		_channelRequestResponse?.Set();
	}

	private void SendChannelOpenMessage()
	{
		if (Interlocked.CompareExchange(ref _sessionSemaphoreObtained, 1, 0) == 0)
		{
			base.SessionSemaphore.Wait();
			SendMessage(new ChannelOpenMessage(base.LocalChannelNumber, base.LocalWindowSize, base.LocalPacketSize, new SessionChannelOpenInfo()));
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (disposing)
		{
			EventWaitHandle channelOpenResponseWaitHandle = _channelOpenResponseWaitHandle;
			if (channelOpenResponseWaitHandle != null)
			{
				_channelOpenResponseWaitHandle = null;
				channelOpenResponseWaitHandle.Dispose();
			}
			EventWaitHandle channelRequestResponse = _channelRequestResponse;
			if (channelRequestResponse != null)
			{
				_channelRequestResponse = null;
				channelRequestResponse.Dispose();
			}
		}
	}

	private void ReleaseSemaphore()
	{
		if (Interlocked.CompareExchange(ref _sessionSemaphoreObtained, 0, 1) == 1)
		{
			base.SessionSemaphore.Release();
		}
	}
}
