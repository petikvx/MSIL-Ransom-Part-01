using System;

namespace Renci.SshNet.Common;

public class ScpDownloadEventArgs : EventArgs
{
	public string Filename { get; private set; }

	public long Size { get; private set; }

	public long Downloaded { get; private set; }

	public ScpDownloadEventArgs(string filename, long size, long downloaded)
	{
		Filename = filename;
		Size = size;
		Downloaded = downloaded;
	}
}
