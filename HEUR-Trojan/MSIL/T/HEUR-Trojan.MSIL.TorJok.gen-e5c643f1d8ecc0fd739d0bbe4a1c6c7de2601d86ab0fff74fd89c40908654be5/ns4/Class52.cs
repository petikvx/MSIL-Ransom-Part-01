using System;
using System.Threading;

namespace ns4;

internal sealed class Class52 : IAsyncResult
{
	internal bool bool_0 = true;

	internal object object_0;

	internal ManualResetEvent manualResetEvent_0;

	bool IAsyncResult.IsCompleted => bool_0;

	bool IAsyncResult.CompletedSynchronously => false;

	object IAsyncResult.AsyncState => object_0;

	WaitHandle IAsyncResult.AsyncWaitHandle
	{
		get
		{
			if (manualResetEvent_0 == null)
			{
				manualResetEvent_0 = new ManualResetEvent(initialState: false);
			}
			return manualResetEvent_0;
		}
	}
}
