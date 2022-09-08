using System;

namespace Orcus.Commands.FileExplorer;

public class UploadFinishedEventArgs : EventArgs
{
	public UploadProcess UploadProcess { get; }

	public UploadFinishedEventArgs(UploadProcess uploadProcess)
	{
		UploadProcess = uploadProcess;
	}
}
