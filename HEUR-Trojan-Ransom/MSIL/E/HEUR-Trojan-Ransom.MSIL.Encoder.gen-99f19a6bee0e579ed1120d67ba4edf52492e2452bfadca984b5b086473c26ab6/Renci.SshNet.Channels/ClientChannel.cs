using System;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal abstract class ClientChannel : Channel
{
	public event EventHandler<ChannelOpenConfirmedEventArgs> OpenConfirmed;

	public event EventHandler<ChannelOpenFailedEventArgs> OpenFailed;

	protected ClientChannel(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize)
		: base(session, localChannelNumber, localWindowSize, localPacketSize)
	{
		session.ChannelOpenConfirmationReceived += OnChannelOpenConfirmation;
		session.ChannelOpenFailureReceived += OnChannelOpenFailure;
	}

	protected virtual void OnOpenConfirmation(uint remoteChannelNumber, uint initialWindowSize, uint maximumPacketSize)
	{
		InitializeRemoteInfo(remoteChannelNumber, initialWindowSize, maximumPacketSize);
		base.IsOpen = true;
		this.OpenConfirmed?.Invoke(this, new ChannelOpenConfirmedEventArgs(remoteChannelNumber, initialWindowSize, maximumPacketSize));
	}

	protected void SendMessage(ChannelOpenMessage message)
	{
		base.Session.SendMessage(message);
	}

	protected virtual void OnOpenFailure(uint reasonCode, string description, string language)
	{
		this.OpenFailed?.Invoke(this, new ChannelOpenFailedEventArgs(base.LocalChannelNumber, reasonCode, description, language));
	}

	private void OnChannelOpenConfirmation(object sender, MessageEventArgs<ChannelOpenConfirmationMessage> e)
	{
		if (e.Message.LocalChannelNumber == base.LocalChannelNumber)
		{
			try
			{
				OnOpenConfirmation(e.Message.RemoteChannelNumber, e.Message.InitialWindowSize, e.Message.MaximumPacketSize);
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	private void OnChannelOpenFailure(object sender, MessageEventArgs<ChannelOpenFailureMessage> e)
	{
		if (e.Message.LocalChannelNumber == base.LocalChannelNumber)
		{
			try
			{
				OnOpenFailure(e.Message.ReasonCode, e.Message.Description, e.Message.Language);
			}
			catch (Exception ex)
			{
				OnChannelException(ex);
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		UnsubscribeFromSessionEvents(base.Session);
		base.Dispose(disposing);
	}

	private void UnsubscribeFromSessionEvents(ISession session)
	{
		if (session != null)
		{
			session.ChannelOpenConfirmationReceived -= OnChannelOpenConfirmation;
			session.ChannelOpenFailureReceived -= OnChannelOpenFailure;
		}
	}
}
