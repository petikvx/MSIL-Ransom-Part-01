using System;
using System.Globalization;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp;

internal sealed class SftpResponseFactory : ISftpResponseFactory
{
	public SftpMessage Create(uint protocolVersion, byte messageType, Encoding encoding)
	{
		SftpMessageTypes sftpMessageTypes = (SftpMessageTypes)messageType;
		return sftpMessageTypes switch
		{
			SftpMessageTypes.ExtendedReply => new SftpExtendedReplyResponse(protocolVersion), 
			SftpMessageTypes.Status => new SftpStatusResponse(protocolVersion), 
			SftpMessageTypes.Handle => new SftpHandleResponse(protocolVersion), 
			SftpMessageTypes.Data => new SftpDataResponse(protocolVersion), 
			SftpMessageTypes.Name => new SftpNameResponse(protocolVersion, encoding), 
			SftpMessageTypes.Attrs => new SftpAttrsResponse(protocolVersion), 
			SftpMessageTypes.Version => new SftpVersionResponse(), 
			_ => throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Message type '{0}' is not supported.", new object[1] { sftpMessageTypes })), 
		};
	}
}
