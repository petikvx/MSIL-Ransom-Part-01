using System;
using System.Security.Cryptography;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Security.Chaos.NaCl;
using Renci.SshNet.Security.Chaos.NaCl.Internal.Ed25519Ref10;

namespace Renci.SshNet.Security;

internal class KeyExchangeECCurve25519 : KeyExchangeEC
{
	private byte[] _privateKey;

	public override string Name => "curve25519-sha256";

	protected override int HashSize => 256;

	public override void Start(Session session, KeyExchangeInitMessage message)
	{
		base.Start(session, message);
		base.Session.RegisterMessage("SSH_MSG_KEX_ECDH_REPLY");
		base.Session.KeyExchangeEcdhReplyMessageReceived += Session_KeyExchangeEcdhReplyMessageReceived;
		byte[] array = new byte[MontgomeryCurve25519.PublicKeySizeInBytes];
		array[0] = 9;
		Random random = new Random();
		_privateKey = new byte[MontgomeryCurve25519.PrivateKeySizeInBytes];
		random.NextBytes(_privateKey);
		_clientExchangeValue = new byte[MontgomeryCurve25519.PublicKeySizeInBytes];
		MontgomeryOperations.scalarmult(_clientExchangeValue, 0, _privateKey, 0, array, 0);
		SendMessage(new KeyExchangeEcdhInitMessage(_clientExchangeValue));
	}

	public override void Finish()
	{
		base.Finish();
		base.Session.KeyExchangeEcdhReplyMessageReceived -= Session_KeyExchangeEcdhReplyMessageReceived;
	}

	protected override byte[] Hash(byte[] hashData)
	{
		using SHA256 sHA = CryptoAbstraction.CreateSHA256();
		return sHA.ComputeHash(hashData, 0, hashData.Length);
	}

	private void Session_KeyExchangeEcdhReplyMessageReceived(object sender, MessageEventArgs<KeyExchangeEcdhReplyMessage> e)
	{
		KeyExchangeEcdhReplyMessage message = e.Message;
		base.Session.UnRegisterMessage("SSH_MSG_KEX_ECDH_REPLY");
		HandleServerEcdhReply(message.KS, message.QS, message.Signature);
		Finish();
	}

	private void HandleServerEcdhReply(byte[] hostKey, byte[] serverExchangeValue, byte[] signature)
	{
		_serverExchangeValue = serverExchangeValue;
		_hostKey = hostKey;
		_signature = signature;
		byte[] array = new byte[MontgomeryCurve25519.PublicKeySizeInBytes];
		MontgomeryOperations.scalarmult(array, 0, _privateKey, 0, serverExchangeValue, 0);
		base.SharedKey = array.ToBigInteger2().ToByteArray().Reverse();
	}
}
