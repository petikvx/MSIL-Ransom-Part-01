using System;
using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellman : KeyExchange
{
	protected BigInteger _group;

	protected BigInteger _prime;

	protected byte[] _clientPayload;

	protected byte[] _serverPayload;

	protected BigInteger _clientExchangeValue;

	protected BigInteger _serverExchangeValue;

	protected BigInteger _privateExponent;

	protected byte[] _hostKey;

	protected byte[] _signature;

	protected abstract int HashSize { get; }

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

	protected void PopulateClientExchangeValue()
	{
		if (_group.IsZero)
		{
			throw new ArgumentNullException("_group");
		}
		if (_prime.IsZero)
		{
			throw new ArgumentNullException("_prime");
		}
		int bitLength = Math.Max(HashSize * 2, 1024);
		do
		{
			_privateExponent = BigInteger.Random(bitLength);
			_clientExchangeValue = BigInteger.ModPow(_group, _privateExponent, _prime);
		}
		while (_clientExchangeValue < 1L || _clientExchangeValue > _prime - 1);
	}

	protected virtual void HandleServerDhReply(byte[] hostKey, BigInteger serverExchangeValue, byte[] signature)
	{
		_serverExchangeValue = serverExchangeValue;
		_hostKey = hostKey;
		base.SharedKey = BigInteger.ModPow(serverExchangeValue, _privateExponent, _prime);
		_signature = signature;
	}
}
