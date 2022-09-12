using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeEC : KeyExchange
{
	protected byte[] _clientPayload;

	protected byte[] _serverPayload;

	protected byte[] _clientExchangeValue;

	protected byte[] _serverExchangeValue;

	protected byte[] _hostKey;

	protected byte[] _signature;

	protected abstract int HashSize { get; }

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

	protected override bool ValidateExchangeHash()
	{
		byte[] data = CalculateHash();
		uint count = Pack.BigEndianToUInt32(_hostKey);
		string @string = Encoding.UTF8.GetString(_hostKey, 4, (int)count);
		KeyHostAlgorithm keyHostAlgorithm = base.Session.ConnectionInfo.HostKeyAlgorithms[@string](_hostKey);
		base.Session.ConnectionInfo.CurrentHostKeyAlgorithm = @string;
		if (CanTrustHostKey(keyHostAlgorithm))
		{
			return keyHostAlgorithm.VerifySignature(data, _signature);
		}
		return false;
	}

	public override void Start(Session session, KeyExchangeInitMessage message)
	{
		base.Start(session, message);
		_serverPayload = message.GetBytes();
		_clientPayload = base.Session.ClientInitMessage.GetBytes();
	}
}
