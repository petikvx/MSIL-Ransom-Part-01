using System;
using System.Collections.Generic;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpListDirectoryAsyncResult : AsyncResult<IEnumerable<SftpFile>>
{
	public int FilesRead { get; private set; }

	public SftpListDirectoryAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}

	internal void Update(int filesRead)
	{
		FilesRead = filesRead;
	}
}
