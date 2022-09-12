using System;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Security;

internal abstract class KeyExchangeDiffieHellmanGroupSha1 : KeyExchangeDiffieHellman
{
	private class _ExchangeHashData : SshData
	{
		private byte[] _serverVersion;

		private byte[] _clientVersion;

		private byte[] _clientExchangeValue;

		private byte[] _serverExchangeValue;

		private byte[] _sharedKey;

		public string ServerVersion
		{
			private get
			{
				return SshData.Utf8.GetString(_serverVersion, 0, _serverVersion.Length);
			}
			set
			{
				_serverVersion = SshData.Utf8.GetBytes(value);
			}
		}

		public string ClientVersion
		{
			private get
			{
				return SshData.Utf8.GetString(_clientVersion, 0, _clientVersion.Length);
			}
			set
			{
				_clientVersion = SshData.Utf8.GetBytes(value);
			}
		}

		public byte[] ClientPayload { get; set; }

		public byte[] ServerPayload { get; set; }

		public byte[] HostKey { get; set; }

		public BigInteger ClientExchangeValue
		{
			private get
			{
				return _clientExchangeValue.ToBigInteger();
			}
			set
			{
				_clientExchangeValue = value.ToByteArray().Reverse();
			}
		}

		public BigInteger ServerExchangeValue
		{
			private get
			{
				return _serverExchangeValue.ToBigInteger();
			}
			set
			{
				_serverExchangeValue = value.ToByteArray().Reverse();
			}
		}

		public BigInteger SharedKey
		{
			private get
			{
				return _sharedKey.ToBigInteger();
			}
			set
			{
				_sharedKey = value.ToByteArray().Reverse();
			}
		}

		protected override int BufferCapacity => base.BufferCapacity + 4 + _clientVersion.Length + 4 + _serverVersion.Length + 4 + ClientPayload.Length + 4 + ServerPayload.Length + 4 + HostKey.Length + 4 + _clientExchangeValue.Length + 4 + _serverExchangeValue.Length + 4 + _sharedKey.Length;

		protected override void LoadData()
		{
			throw new NotImplementedException();
		}

		protected override void SaveData()
		{
			WriteBinaryString(_clientVersion);
			WriteBinaryString(_serverVersion);
			WriteBinaryString(ClientPayload);
			WriteBinaryString(ServerPayload);
			WriteBinaryString(HostKey);
			WriteBinaryString(_clientExchangeValue);
			WriteBinaryString(_serverExchangeValue);
			WriteBinaryString(_sharedKey);
		}
	}

	public abstract BigInteger GroupPrime { get; }

	protected override int HashSize => 160;

	protected override byte[] CalculateHash()
	{
		byte[] bytes = new _ExchangeHashData
		{
			ClientVersion = base.Session.ClientVersion,
			ServerVersion = base.Session.ServerVersion,
			ClientPayload = _clientPayload,
			ServerPayload = _serverPayload,
			HostKey = _hostKey,
			ClientExchangeValue = _clientExchangeValue,
			ServerExchangeValue = _serverExchangeValue,
			SharedKey = base.SharedKey
		}.GetBytes();
		return Hash(bytes);
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
