using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security;

internal class GroupExchangeHashData : SshData
{
	private byte[] _serverVersion;

	private byte[] _clientVersion;

	private byte[] _prime;

	private byte[] _subGroup;

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

	public uint MinimumGroupSize { get; set; }

	public uint PreferredGroupSize { get; set; }

	public uint MaximumGroupSize { get; set; }

	public BigInteger Prime
	{
		private get
		{
			return _prime.ToBigInteger();
		}
		set
		{
			_prime = value.ToByteArray().Reverse();
		}
	}

	public BigInteger SubGroup
	{
		private get
		{
			return _subGroup.ToBigInteger();
		}
		set
		{
			_subGroup = value.ToByteArray().Reverse();
		}
	}

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

	protected override int BufferCapacity => base.BufferCapacity + 4 + _clientVersion.Length + 4 + _serverVersion.Length + 4 + ClientPayload.Length + 4 + ServerPayload.Length + 4 + HostKey.Length + 4 + 4 + 4 + 4 + _prime.Length + 4 + _subGroup.Length + 4 + _clientExchangeValue.Length + 4 + _serverExchangeValue.Length + 4 + _sharedKey.Length;

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
		Write(MinimumGroupSize);
		Write(PreferredGroupSize);
		Write(MaximumGroupSize);
		WriteBinaryString(_prime);
		WriteBinaryString(_subGroup);
		WriteBinaryString(_clientExchangeValue);
		WriteBinaryString(_serverExchangeValue);
		WriteBinaryString(_sharedKey);
	}
}
