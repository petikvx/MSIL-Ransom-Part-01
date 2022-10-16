using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PublisherWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RevertCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertCallback()
	{
	}
}
