using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProducerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		FlushItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushItem()
	{
	}
}
