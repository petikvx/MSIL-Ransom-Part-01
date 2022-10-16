using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProducerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SearchCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchCreator()
	{
	}
}
