using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateItem()
	{
	}
}
