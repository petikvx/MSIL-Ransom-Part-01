using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

internal class X11ChannelOpenInfo : ChannelOpenInfo
{
	private byte[] _originatorAddress;

	public const string Name = "x11";

	public override string ChannelType => "x11";

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

	protected override int BufferCapacity => base.BufferCapacity + 4 + _originatorAddress.Length + 4;

	public X11ChannelOpenInfo(byte[] data)
	{
		Load(data);
	}

	public X11ChannelOpenInfo(string originatorAddress, uint originatorPort)
	{
		OriginatorAddress = originatorAddress;
		OriginatorPort = originatorPort;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_originatorAddress = ReadBinary();
		OriginatorPort = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_originatorAddress);
		Write(OriginatorPort);
	}
}
