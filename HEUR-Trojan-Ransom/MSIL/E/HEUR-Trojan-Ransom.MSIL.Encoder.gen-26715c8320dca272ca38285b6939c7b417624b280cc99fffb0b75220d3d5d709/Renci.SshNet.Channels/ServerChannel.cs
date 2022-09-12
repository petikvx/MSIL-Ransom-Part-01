using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal abstract class ServerChannel : Channel
{
	protected ServerChannel(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize, uint remoteChannelNumber, uint remoteWindowSize, uint remotePacketSize)
		: base(session, localChannelNumber, localWindowSize, localPacketSize)
	{
		InitializeRemoteInfo(remoteChannelNumber, remoteWindowSize, remotePacketSize);
	}

	protected void SendMessage(ChannelOpenConfirmationMessage message)
	{
		base.Session.SendMessage(message);
		base.IsOpen = true;
	}
}
