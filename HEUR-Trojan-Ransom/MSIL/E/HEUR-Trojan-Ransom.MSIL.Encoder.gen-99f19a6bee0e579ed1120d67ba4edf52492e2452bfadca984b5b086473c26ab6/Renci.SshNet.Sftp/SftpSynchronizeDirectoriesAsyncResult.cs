using System;
using System.Collections.Generic;
using System.IO;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpSynchronizeDirectoriesAsyncResult : AsyncResult<IEnumerable<FileInfo>>
{
	public int FilesRead { get; private set; }

	public SftpSynchronizeDirectoriesAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}

	internal void Update(int filesRead)
	{
		FilesRead = filesRead;
	}
}
