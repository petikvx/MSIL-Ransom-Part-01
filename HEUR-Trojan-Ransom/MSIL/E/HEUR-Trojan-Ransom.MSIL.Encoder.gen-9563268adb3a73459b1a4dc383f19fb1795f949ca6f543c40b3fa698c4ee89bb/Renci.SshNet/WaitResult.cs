namespace Renci.SshNet;

internal enum WaitResult
{
	Success = 1,
	TimedOut,
	Disconnected,
	Failed
}
