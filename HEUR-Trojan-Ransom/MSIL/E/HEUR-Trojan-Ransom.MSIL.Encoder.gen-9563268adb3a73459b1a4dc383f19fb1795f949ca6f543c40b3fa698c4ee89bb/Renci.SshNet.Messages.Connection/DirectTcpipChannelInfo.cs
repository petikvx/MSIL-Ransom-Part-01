using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class DirectTcpipChannelInfo : ChannelOpenInfo
{
	private byte[] _hostToConnect;

	private byte[] _originatorAddress;

	public const string NAME = "direct-tcpip";

	public override string ChannelType => "direct-tcpip";

	public string HostToConnect
	{
		get
		{
			return SshData.Utf8.GetString(_hostToConnect, 0, _hostToConnect.Length);
		}
		private set
		{
			_hostToConnect = SshData.Utf8.GetBytes(value);
		}
	}

	public uint PortToConnect { get; private set; }

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

	protected override int BufferCapacity => base.BufferCapacity + 4 + _hostToConnect.Length + 4 + 4 + _originatorAddress.Length + 4;

	public DirectTcpipChannelInfo(byte[] data)
	{
		Load(data);
	}

	public DirectTcpipChannelInfo(string hostToConnect, uint portToConnect, string originatorAddress, uint originatorPort)
	{
		HostToConnect = hostToConnect;
		PortToConnect = portToConnect;
		OriginatorAddress = originatorAddress;
		OriginatorPort = originatorPort;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_hostToConnect = ReadBinary();
		PortToConnect = ReadUInt32();
		_originatorAddress = ReadBinary();
		OriginatorPort = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_hostToConnect);
		Write(PortToConnect);
		WriteBinaryString(_originatorAddress);
		Write(OriginatorPort);
	}
}
