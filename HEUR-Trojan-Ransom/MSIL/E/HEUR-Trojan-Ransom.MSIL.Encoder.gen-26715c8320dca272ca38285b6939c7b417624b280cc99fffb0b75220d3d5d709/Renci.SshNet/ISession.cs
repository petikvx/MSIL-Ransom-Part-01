using System;
using System.Threading;
using Renci.SshNet.Channels;
using Renci.SshNet.Common;
using Renci.SshNet.Messages;
using Renci.SshNet.Messages.Authentication;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet;

internal interface ISession : IDisposable
{
	IConnectionInfo ConnectionInfo { get; }

	bool IsConnected { get; }

	SemaphoreLight SessionSemaphore { get; }

	WaitHandle MessageListenerCompleted { get; }

	event EventHandler<MessageEventArgs<ChannelCloseMessage>> ChannelCloseReceived;

	event EventHandler<MessageEventArgs<ChannelDataMessage>> ChannelDataReceived;

	event EventHandler<MessageEventArgs<ChannelEofMessage>> ChannelEofReceived;

	event EventHandler<MessageEventArgs<ChannelExtendedDataMessage>> ChannelExtendedDataReceived;

	event EventHandler<MessageEventArgs<ChannelFailureMessage>> ChannelFailureReceived;

	event EventHandler<MessageEventArgs<ChannelOpenConfirmationMessage>> ChannelOpenConfirmationReceived;

	event EventHandler<MessageEventArgs<ChannelOpenFailureMessage>> ChannelOpenFailureReceived;

	event EventHandler<MessageEventArgs<ChannelOpenMessage>> ChannelOpenReceived;

	event EventHandler<MessageEventArgs<ChannelRequestMessage>> ChannelRequestReceived;

	event EventHandler<MessageEventArgs<ChannelSuccessMessage>> ChannelSuccessReceived;

	event EventHandler<MessageEventArgs<ChannelWindowAdjustMessage>> ChannelWindowAdjustReceived;

	event EventHandler<EventArgs> Disconnected;

	event EventHandler<ExceptionEventArgs> ErrorOccured;

	event EventHandler<HostKeyEventArgs> HostKeyReceived;

	event EventHandler<MessageEventArgs<RequestSuccessMessage>> RequestSuccessReceived;

	event EventHandler<MessageEventArgs<RequestFailureMessage>> RequestFailureReceived;

	event EventHandler<MessageEventArgs<BannerMessage>> UserAuthenticationBannerReceived;

	void Connect();

	IChannelSession CreateChannelSession();

	IChannelDirectTcpip CreateChannelDirectTcpip();

	IChannelForwardedTcpip CreateChannelForwardedTcpip(uint remoteChannelNumber, uint remoteWindowSize, uint remoteChannelDataPacketSize);

	void Disconnect();

	void OnDisconnecting();

	void RegisterMessage(string messageName);

	void SendMessage(Message message);

	bool TrySendMessage(Message message);

	void UnRegisterMessage(string messageName);

	void WaitOnHandle(WaitHandle waitHandle);

	void WaitOnHandle(WaitHandle waitHandle, TimeSpan timeout);

	WaitResult TryWait(WaitHandle waitHandle, TimeSpan timeout, out Exception exception);

	WaitResult TryWait(WaitHandle waitHandle, TimeSpan timeout);
}
