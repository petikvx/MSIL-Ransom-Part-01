using System;
using System.Threading;

namespace Renci.SshNet;

internal interface ISubsystemSession : IDisposable
{
	int OperationTimeout { get; }

	bool IsOpen { get; }

	void Connect();

	void Disconnect();

	void WaitOnHandle(WaitHandle waitHandle, int millisecondsTimeout);

	bool WaitOne(WaitHandle waitHandle, int millisecondsTimeout);

	int WaitAny(WaitHandle waitHandleA, WaitHandle waitHandleB, int millisecondsTimeout);

	int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout);

	WaitHandle[] CreateWaitHandleArray(params WaitHandle[] waitHandles);

	WaitHandle[] CreateWaitHandleArray(WaitHandle waitHandle1, WaitHandle waitHandle2);
}
