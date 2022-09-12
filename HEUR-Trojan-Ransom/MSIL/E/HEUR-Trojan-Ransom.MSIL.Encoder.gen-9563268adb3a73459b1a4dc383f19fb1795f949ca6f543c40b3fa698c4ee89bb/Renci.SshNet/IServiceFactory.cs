using System;
using System.Collections.Generic;
using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.NetConf;
using Renci.SshNet.Security;
using Renci.SshNet.Sftp;

namespace Renci.SshNet;

internal interface IServiceFactory
{
	IClientAuthentication CreateClientAuthentication();

	ISession CreateSession(ConnectionInfo connectionInfo);

	ISftpSession CreateSftpSession(ISession session, int operationTimeout, Encoding encoding, ISftpResponseFactory sftpMessageFactory);

	PipeStream CreatePipeStream();

	IKeyExchange CreateKeyExchange(IDictionary<string, Type> clientAlgorithms, string[] serverAlgorithms);

	ISftpFileReader CreateSftpFileReader(string fileName, ISftpSession sftpSession, uint bufferSize);

	ISftpResponseFactory CreateSftpResponseFactory();

	ShellStream CreateShellStream(ISession session, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues, int bufferSize);

	IRemotePathTransformation CreateRemotePathDoubleQuoteTransformation();

	INetConfSession CreateNetConfSession(ISession session, int operationTimeout);
}
