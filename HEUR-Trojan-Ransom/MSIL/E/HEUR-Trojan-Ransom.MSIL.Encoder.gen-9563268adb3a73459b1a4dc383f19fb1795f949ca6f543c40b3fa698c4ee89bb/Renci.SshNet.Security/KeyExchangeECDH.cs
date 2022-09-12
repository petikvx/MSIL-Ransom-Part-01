using System;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Agreement;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Generators;
using Renci.SshNet.Security.Org.BouncyCastle.Crypto.Parameters;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Security;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeECDH : KeyExchangeEC
{
	protected ECDHCBasicAgreement KeyAgreement;

	protected ECDomainParameters DomainParameters;

	protected abstract X9ECParameters CurveParameter { get; }

	public override void Start(Session session, KeyExchangeInitMessage message)
	{
		base.Start(session, message);
		base.Session.RegisterMessage("SSH_MSG_KEX_ECDH_REPLY");
		base.Session.KeyExchangeEcdhReplyMessageReceived += Session_KeyExchangeEcdhReplyMessageReceived;
		DomainParameters = new ECDomainParameters(CurveParameter.Curve, CurveParameter.G, CurveParameter.N, CurveParameter.H, CurveParameter.GetSeed());
		ECKeyPairGenerator eCKeyPairGenerator = new ECKeyPairGenerator();
		eCKeyPairGenerator.Init(new ECKeyGenerationParameters(DomainParameters, new SecureRandom()));
		AsymmetricCipherKeyPair asymmetricCipherKeyPair = eCKeyPairGenerator.GenerateKeyPair();
		KeyAgreement = new ECDHCBasicAgreement();
		KeyAgreement.Init(asymmetricCipherKeyPair.Private);
		_clientExchangeValue = ((ECPublicKeyParameters)asymmetricCipherKeyPair.Public).Q.GetEncoded();
		SendMessage(new KeyExchangeEcdhInitMessage(_clientExchangeValue));
	}

	public override void Finish()
	{
		base.Finish();
		base.Session.KeyExchangeEcdhReplyMessageReceived -= Session_KeyExchangeEcdhReplyMessageReceived;
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
		int num = (serverExchangeValue.Length - 1) / 2;
		byte[] array = new byte[num];
		Buffer.BlockCopy(serverExchangeValue, 1, array, 0, array.Length);
		byte[] array2 = new byte[num];
		Buffer.BlockCopy(serverExchangeValue, num + 1, array2, 0, array2.Length);
		ECPoint q = ((FpCurve)DomainParameters.Curve).CreatePoint(new Renci.SshNet.Security.Org.BouncyCastle.Math.BigInteger(1, array), new Renci.SshNet.Security.Org.BouncyCastle.Math.BigInteger(1, array2));
		ECPublicKeyParameters pubKey = new ECPublicKeyParameters("ECDH", q, DomainParameters);
		Renci.SshNet.Security.Org.BouncyCastle.Math.BigInteger bigInteger = KeyAgreement.CalculateAgreement(pubKey);
		base.SharedKey = bigInteger.ToByteArray().ToBigInteger2().ToByteArray()
			.Reverse();
	}
}
