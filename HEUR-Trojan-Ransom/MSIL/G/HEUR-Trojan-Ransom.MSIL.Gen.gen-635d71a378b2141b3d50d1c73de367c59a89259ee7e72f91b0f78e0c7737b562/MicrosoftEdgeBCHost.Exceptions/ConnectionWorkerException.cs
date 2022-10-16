using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConnectionWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutDispatcher()
	{
	}
}
