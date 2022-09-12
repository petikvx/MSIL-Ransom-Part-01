using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class ForwardedTcpipChannelInfo : ChannelOpenInfo
{
	private byte[] _connectedAddress;

	private byte[] _originatorAddress;

	public const string NAME = "forwarded-tcpip";

	public override string ChannelType => "forwarded-tcpip";

	public string ConnectedAddress
	{
		get
		{
			return SshData.Utf8.GetString(_connectedAddress, 0, _connectedAddress.Length);
		}
		private set
		{
			_connectedAddress = SshData.Utf8.GetBytes(value);
		}
	}

	public uint ConnectedPort { get; private set; }

	public string OriginatorAddress
	{
		get
		{
			return SshData.Utf8.GetString(_originatorAddress, 0, _originatorAddress.Length);
		}
		private set
		{
			_originatorAddress = SshData.Utf8.GetBytes(value);
		}
	}

	public uint OriginatorPort { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _connectedAddress.Length + 4 + 4 + _originatorAddress.Length + 4;

	public ForwardedTcpipChannelInfo(byte[] data)
	{
		Load(data);
	}

	public ForwardedTcpipChannelInfo(string connectedAddress, uint connectedPort, string originatorAddress, uint originatorPort)
	{
		ConnectedAddress = connectedAddress;
		ConnectedPort = connectedPort;
		OriginatorAddress = originatorAddress;
		OriginatorPort = originatorPort;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_connectedAddress = ReadBinary();
		ConnectedPort = ReadUInt32();
		_originatorAddress = ReadBinary();
		OriginatorPort = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_connectedAddress);
		Write(ConnectedPort);
		WriteBinaryString(_originatorAddress);
		Write(OriginatorPort);
	}
}
