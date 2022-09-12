using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp.Responses;

internal class SftpStatusResponse : SftpResponse
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Status;

	public StatusCodes StatusCode { get; private set; }

	public string ErrorMessage { get; private set; }

	public string Language { get; private set; }

	public SftpStatusResponse(uint protocolVersion)
		: base(protocolVersion)
	{
	}

	protected override void LoadData()
	{
		base.LoadData();
		StatusCode = (StatusCodes)ReadUInt32();
		if (base.ProtocolVersion >= 3 && !base.IsEndOfData)
		{
			ErrorMessage = ReadString(SshData.Utf8);
			Language = ReadString(SshData.Ascii);
		}
	}
}
