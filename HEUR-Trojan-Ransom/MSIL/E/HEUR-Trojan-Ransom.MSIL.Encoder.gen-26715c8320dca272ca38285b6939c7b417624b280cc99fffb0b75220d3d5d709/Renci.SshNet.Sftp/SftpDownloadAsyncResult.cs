using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpDownloadAsyncResult : AsyncResult
{
	public bool IsDownloadCanceled { get; set; }

	public ulong DownloadedBytes { get; private set; }

	public SftpDownloadAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}

	internal void Update(ulong downloadedBytes)
	{
		DownloadedBytes = downloadedBytes;
	}
}
