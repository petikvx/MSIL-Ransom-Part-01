using System;

namespace Renci.SshNet.Common;

public class ScpUploadEventArgs : EventArgs
{
	public string Filename { get; private set; }

	public long Size { get; private set; }

	public long Uploaded { get; private set; }

	public ScpUploadEventArgs(string filename, long size, long uploaded)
	{
		Filename = filename;
		Size = size;
		Uploaded = uploaded;
	}
}
