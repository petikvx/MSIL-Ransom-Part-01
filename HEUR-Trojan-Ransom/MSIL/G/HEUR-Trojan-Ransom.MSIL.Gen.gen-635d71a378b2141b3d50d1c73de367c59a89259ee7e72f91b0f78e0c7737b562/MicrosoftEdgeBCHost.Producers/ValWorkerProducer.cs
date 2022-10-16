using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListField()
	{
	}
}
