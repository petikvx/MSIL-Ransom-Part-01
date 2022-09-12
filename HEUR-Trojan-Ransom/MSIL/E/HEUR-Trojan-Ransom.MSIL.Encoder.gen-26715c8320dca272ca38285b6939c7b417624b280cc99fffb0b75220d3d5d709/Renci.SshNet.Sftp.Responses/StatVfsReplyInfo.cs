using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp.Responses;

internal class StatVfsReplyInfo : ExtendedReplyInfo
{
	public SftpFileSytemInformation Information { get; private set; }

	public override void LoadData(SshDataStream stream)
	{
		Information = new SftpFileSytemInformation(stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64(), stream.ReadUInt64());
	}
}
