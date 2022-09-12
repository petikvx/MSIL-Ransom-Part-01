using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Sftp;

public class SftpUploadAsyncResult : AsyncResult
{
	public bool IsUploadCanceled { get; set; }

	public ulong UploadedBytes { get; private set; }

	public SftpUploadAsyncResult(AsyncCallback asyncCallback, object state)
		: base(asyncCallback, state)
	{
	}

	internal void Update(ulong uploadedBytes)
	{
		UploadedBytes = uploadedBytes;
	}
}
