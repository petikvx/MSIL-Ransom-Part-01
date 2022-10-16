using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProducerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceDispatcher()
	{
	}
}
