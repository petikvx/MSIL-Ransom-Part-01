namespace Renci.SshNet.Sftp.Responses;

internal class SftpExtendedReplyResponse : SftpResponse
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.ExtendedReply;

	public SftpExtendedReplyResponse(uint protocolVersion)
		: base(protocolVersion)
	{
	}

	public T GetReply<T>() where T : ExtendedReplyInfo, new()
	{
		T val = new T();
		val.LoadData(base.DataStream);
		return val;
	}
}
