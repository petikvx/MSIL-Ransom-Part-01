using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

internal class SFtpStatAsyncResult : AsyncResult<SftpFileAttributes>
{
	public SFtpStatAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}
}
