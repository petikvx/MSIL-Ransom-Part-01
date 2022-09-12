namespace Renci.SshNet.Common;

internal class ChannelExtendedDataEventArgs : ChannelDataEventArgs
{
	public uint DataTypeCode { get; private set; }

	public ChannelExtendedDataEventArgs(uint channelNumber, byte[] data, uint dataTypeCode)
		: base(channelNumber, data)
	{
		DataTypeCode = dataTypeCode;
	}
}
