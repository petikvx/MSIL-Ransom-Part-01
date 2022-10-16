using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConnectionWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeLiteralContainer()
	{
	}
}
