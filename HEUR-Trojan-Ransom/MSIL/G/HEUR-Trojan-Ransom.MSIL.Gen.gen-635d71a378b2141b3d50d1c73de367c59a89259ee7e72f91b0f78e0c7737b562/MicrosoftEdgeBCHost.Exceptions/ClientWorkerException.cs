using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClientWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectSystem()
	{
	}
}
