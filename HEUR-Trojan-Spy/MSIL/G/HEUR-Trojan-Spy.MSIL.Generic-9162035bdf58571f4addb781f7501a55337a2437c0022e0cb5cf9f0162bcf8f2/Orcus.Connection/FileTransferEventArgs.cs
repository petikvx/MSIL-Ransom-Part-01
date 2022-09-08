using System;

namespace Orcus.Connection;

public class FileTransferEventArgs : EventArgs
{
	public Guid Guid { get; }

	public FileTransferEventArgs(Guid guid)
	{
		Guid = guid;
	}
}
