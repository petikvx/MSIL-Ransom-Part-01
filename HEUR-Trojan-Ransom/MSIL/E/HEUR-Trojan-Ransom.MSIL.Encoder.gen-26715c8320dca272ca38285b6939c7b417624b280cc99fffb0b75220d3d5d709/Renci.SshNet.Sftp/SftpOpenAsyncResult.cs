using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

internal class SftpOpenAsyncResult : AsyncResult<byte[]>
{
	public SftpOpenAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}
}
