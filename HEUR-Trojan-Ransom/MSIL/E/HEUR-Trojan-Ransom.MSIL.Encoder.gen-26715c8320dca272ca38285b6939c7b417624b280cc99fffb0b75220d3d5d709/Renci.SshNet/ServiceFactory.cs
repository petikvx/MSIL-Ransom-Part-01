using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;
using Renci.SshNet.NetConf;
using Renci.SshNet.Security;
using Renci.SshNet.Sftp;

namespace Renci.SshNet;

internal class ServiceFactory : IServiceFactory
{
	private static int PartialSuccessLimit = 5;

	public IClientAuthentication CreateClientAuthentication()
	{
		return new ClientAuthentication(PartialSuccessLimit);
	}

	public ISession CreateSession(ConnectionInfo connectionInfo)
	{
		return new Session(connectionInfo, this);
	}

	public ISftpSession CreateSftpSession(ISession session, int operationTimeout, Encoding encoding, ISftpResponseFactory sftpMessageFactory)
	{
		return new SftpSession(session, operationTimeout, encoding, sftpMessageFactory);
	}

	public PipeStream CreatePipeStream()
	{
		return new PipeStream();
	}

	public IKeyExchange CreateKeyExchange(IDictionary<string, Type> clientAlgorithms, string[] serverAlgorithms)
	{
		if (clientAlgorithms == null)
		{
			throw new ArgumentNullException("clientAlgorithms");
		}
		if (serverAlgorithms == null)
		{
			throw new ArgumentNullException("serverAlgorithms");
		}
		Type? type = (from c in clientAlgorithms
			from s in serverAlgorithms
			where s == c.Key
			select c.Value).FirstOrDefault();
		if (type == null)
		{
			throw new SshConnectionException("Failed to negotiate key exchange algorithm.", DisconnectReason.KeyExchangeFailed);
		}
		return type.CreateInstance<IKeyExchange>();
	}

	public ISftpFileReader CreateSftpFileReader(string fileName, ISftpSession sftpSession, uint bufferSize)
	{
		SftpOpenAsyncResult asyncResult = sftpSession.BeginOpen(fileName, Flags.Read, null, null);
		byte[] handle = sftpSession.EndOpen(asyncResult);
		SFtpStatAsyncResult asyncResult2 = sftpSession.BeginLStat(fileName, null, null);
		uint num = sftpSession.CalculateOptimalReadLength(bufferSize);
		long? fileSize;
		int maxPendingReads;
		try
		{
			SftpFileAttributes sftpFileAttributes = sftpSession.EndLStat(asyncResult2);
			fileSize = sftpFileAttributes.Size;
			maxPendingReads = Math.Min(10, (int)Math.Ceiling((double)sftpFileAttributes.Size / (double)num) + 1);
		}
		catch (SshException)
		{
			fileSize = null;
			maxPendingReads = 3;
		}
		return sftpSession.CreateFileReader(handle, sftpSession, num, maxPendingReads, fileSize);
	}

	public ISftpResponseFactory CreateSftpResponseFactory()
	{
		return new SftpResponseFactory();
	}

	public ShellStream CreateShellStream(ISession session, string terminalName, uint columns, uint rows, uint width, uint height, IDictionary<TerminalModes, uint> terminalModeValues, int bufferSize)
	{
		return new ShellStream(session, terminalName, columns, rows, width, height, terminalModeValues, bufferSize);
	}

	public IRemotePathTransformation CreateRemotePathDoubleQuoteTransformation()
	{
		return RemotePathTransformation.DoubleQuote;
	}

	public INetConfSession CreateNetConfSession(ISession session, int operationTimeout)
	{
		return new NetConfSession(session, operationTimeout);
	}
}
