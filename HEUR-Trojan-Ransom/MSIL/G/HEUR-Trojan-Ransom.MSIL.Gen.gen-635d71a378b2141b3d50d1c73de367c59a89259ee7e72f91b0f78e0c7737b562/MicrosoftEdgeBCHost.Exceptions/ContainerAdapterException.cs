using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralWorker()
	{
	}
}
