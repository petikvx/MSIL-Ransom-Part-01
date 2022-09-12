using System;
using System.Globalization;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_OPEN", 90)]
public class ChannelOpenMessage : Message
{
	internal const byte MessageNumber = 90;

	private byte[] _infoBytes;

	public byte[] ChannelType { get; private set; }

	public uint LocalChannelNumber { get; protected set; }

	public uint InitialWindowSize { get; private set; }

	public uint MaximumPacketSize { get; private set; }

	public ChannelOpenInfo Info { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + ChannelType.Length + 4 + 4 + 4 + _infoBytes.Length;

	public ChannelOpenMessage()
	{
	}

	public ChannelOpenMessage(uint channelNumber, uint initialWindowSize, uint maximumPacketSize, ChannelOpenInfo info)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		ChannelType = SshData.Ascii.GetBytes(info.ChannelType);
		LocalChannelNumber = channelNumber;
		InitialWindowSize = initialWindowSize;
		MaximumPacketSize = maximumPacketSize;
		Info = info;
		_infoBytes = info.GetBytes();
	}

	protected override void LoadData()
	{
		ChannelType = ReadBinary();
		LocalChannelNumber = ReadUInt32();
		InitialWindowSize = ReadUInt32();
		MaximumPacketSize = ReadUInt32();
		_infoBytes = ReadBytes();
		string @string = SshData.Ascii.GetString(ChannelType, 0, ChannelType.Length);
		switch (@string)
		{
		case "forwarded-tcpip":
			Info = new ForwardedTcpipChannelInfo(_infoBytes);
			break;
		case "direct-tcpip":
			Info = new DirectTcpipChannelInfo(_infoBytes);
			break;
		case "x11":
			Info = new X11ChannelOpenInfo(_infoBytes);
			break;
		default:
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Channel type '{0}' is not supported.", new object[1] { @string }));
		case "session":
			Info = new SessionChannelOpenInfo(_infoBytes);
			break;
		}
	}

	protected override void SaveData()
	{
		WriteBinaryString(ChannelType);
		Write(LocalChannelNumber);
		Write(InitialWindowSize);
		Write(MaximumPacketSize);
		Write(_infoBytes);
	}

	internal override void Process(Session session)
	{
		session.OnChannelOpenReceived(this);
	}
}
