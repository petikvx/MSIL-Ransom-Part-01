using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProducerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ListProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListProducer()
	{
	}
}
