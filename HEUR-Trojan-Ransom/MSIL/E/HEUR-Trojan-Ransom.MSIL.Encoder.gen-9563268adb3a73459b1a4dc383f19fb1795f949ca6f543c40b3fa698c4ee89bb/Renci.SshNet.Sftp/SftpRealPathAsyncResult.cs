using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

internal class SftpRealPathAsyncResult : AsyncResult<string>
{
	public SftpRealPathAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}
}
