using System;
using System.Threading;

namespace Renci.SshNet;

public class CommandAsyncResult : IAsyncResult
{
	public int BytesReceived { get; set; }

	public int BytesSent { get; set; }

	public object AsyncState { get; internal set; }

	public WaitHandle AsyncWaitHandle { get; internal set; }

	public bool CompletedSynchronously { get; internal set; }

	public bool IsCompleted { get; internal set; }

	internal bool EndCalled { get; set; }

	internal CommandAsyncResult()
	{
	}
}
