using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupShaBase : KeyExchangeDiffieHellman
{
	public abstract BigInteger GroupPrime { get; }

	protected override byte[] CalculateHash()
	{
		KeyExchangeHashData keyExchangeHashData = new KeyExchangeHashData
		{
			ClientVersion = base.Session.ClientVersion,
			ServerVersion = base.Session.ServerVersion,
			ClientPayload = _clientPayload,
			ServerPayload = _serverPayload,
			HostKey = _hostKey,
			ClientExchangeValue = _clientExchangeValue,
			ServerExchangeValue = _serverExchangeValue,
			SharedKey = base.SharedKey
		};
		return Hash(keyExchangeHashData.GetBytes());
	}

	public override void Start(Session session, KeyExchangeInitMessage message)
	{
		base.Start(session, message);
		base.Session.RegisterMessage("SSH_MSG_KEXDH_REPLY");
		base.Session.KeyExchangeDhReplyMessageReceived += Session_KeyExchangeDhReplyMessageReceived;
		_prime = GroupPrime;
		_group = new BigInteger(new byte[1] { 2 });
		PopulateClientExchangeValue();
		SendMessage(new KeyExchangeDhInitMessage(_clientExchangeValue));
	}

	public override void Finish()
	{
		base.Finish();
		base.Session.KeyExchangeDhReplyMessageReceived -= Session_KeyExchangeDhReplyMessageReceived;
	}

	private void Session_KeyExchangeDhReplyMessageReceived(object sender, MessageEventArgs<KeyExchangeDhReplyMessage> e)
	{
		KeyExchangeDhReplyMessage message = e.Message;
		base.Session.UnRegisterMessage("SSH_MSG_KEXDH_REPLY");
		HandleServerDhReply(message.HostKey, message.F, message.Signature);
		Finish();
	}
}
