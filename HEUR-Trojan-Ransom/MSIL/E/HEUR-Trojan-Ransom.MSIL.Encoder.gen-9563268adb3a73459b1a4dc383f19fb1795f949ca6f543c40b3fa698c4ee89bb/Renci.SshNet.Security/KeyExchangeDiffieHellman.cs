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

	protected byte[] _clientExchangeValue;

	protected byte[] _serverExchangeValue;

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
		BigInteger bigInteger;
		do
		{
			_privateExponent = BigInteger.Random(bitLength);
			bigInteger = BigInteger.ModPow(_group, _privateExponent, _prime);
		}
		while (bigInteger < 1L || bigInteger > _prime - 1);
		_clientExchangeValue = bigInteger.ToByteArray().Reverse();
	}

	protected virtual void HandleServerDhReply(byte[] hostKey, byte[] serverExchangeValue, byte[] signature)
	{
		_serverExchangeValue = serverExchangeValue;
		_hostKey = hostKey;
		base.SharedKey = BigInteger.ModPow(serverExchangeValue.ToBigInteger(), _privateExponent, _prime).ToByteArray().Reverse();
		_signature = signature;
	}
}
