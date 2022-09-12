using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupExchangeShaBase : KeyExchangeDiffieHellman
{
	private const int MinimumGroupSize = 1024;

	private const int PreferredGroupSize = 1024;

	private const int MaximumProupSize = 8192;

	protected override byte[] CalculateHash()
	{
		byte[] bytes = new GroupExchangeHashData
		{
			ClientVersion = base.Session.ClientVersion,
			ServerVersion = base.Session.ServerVersion,
			ClientPayload = _clientPayload,
			ServerPayload = _serverPayload,
			HostKey = _hostKey,
			MinimumGroupSize = 1024u,
			PreferredGroupSize = 1024u,
			MaximumGroupSize = 8192u,
			Prime = _prime,
			SubGroup = _group,
			ClientExchangeValue = _clientExchangeValue,
			ServerExchangeValue = _serverExchangeValue,
			SharedKey = base.SharedKey
		}.GetBytes();
		return Hash(bytes);
	}

	public override void Start(Session session, KeyExchangeInitMessage message)
	{
		base.Start(session, message);
		base.Session.RegisterMessage("SSH_MSG_KEX_DH_GEX_GROUP");
		base.Session.KeyExchangeDhGroupExchangeGroupReceived += Session_KeyExchangeDhGroupExchangeGroupReceived;
		SendMessage(new KeyExchangeDhGroupExchangeRequest(1024u, 1024u, 8192u));
	}

	public override void Finish()
	{
		base.Finish();
		base.Session.KeyExchangeDhGroupExchangeGroupReceived -= Session_KeyExchangeDhGroupExchangeGroupReceived;
		base.Session.KeyExchangeDhGroupExchangeReplyReceived -= Session_KeyExchangeDhGroupExchangeReplyReceived;
	}

	private void Session_KeyExchangeDhGroupExchangeGroupReceived(object sender, MessageEventArgs<KeyExchangeDhGroupExchangeGroup> e)
	{
		KeyExchangeDhGroupExchangeGroup message = e.Message;
		base.Session.UnRegisterMessage("SSH_MSG_KEX_DH_GEX_GROUP");
		base.Session.KeyExchangeDhGroupExchangeGroupReceived -= Session_KeyExchangeDhGroupExchangeGroupReceived;
		base.Session.RegisterMessage("SSH_MSG_KEX_DH_GEX_REPLY");
		base.Session.KeyExchangeDhGroupExchangeReplyReceived += Session_KeyExchangeDhGroupExchangeReplyReceived;
		_prime = message.SafePrime;
		_group = message.SubGroup;
		PopulateClientExchangeValue();
		SendMessage(new KeyExchangeDhGroupExchangeInit(_clientExchangeValue));
	}

	private void Session_KeyExchangeDhGroupExchangeReplyReceived(object sender, MessageEventArgs<KeyExchangeDhGroupExchangeReply> e)
	{
		KeyExchangeDhGroupExchangeReply message = e.Message;
		base.Session.UnRegisterMessage("SSH_MSG_KEX_DH_GEX_REPLY");
		base.Session.KeyExchangeDhGroupExchangeReplyReceived -= Session_KeyExchangeDhGroupExchangeReplyReceived;
		HandleServerDhReply(message.HostKey, message.F, message.Signature);
		Finish();
	}
}
