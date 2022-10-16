using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CountToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountToken()
	{
	}
}
