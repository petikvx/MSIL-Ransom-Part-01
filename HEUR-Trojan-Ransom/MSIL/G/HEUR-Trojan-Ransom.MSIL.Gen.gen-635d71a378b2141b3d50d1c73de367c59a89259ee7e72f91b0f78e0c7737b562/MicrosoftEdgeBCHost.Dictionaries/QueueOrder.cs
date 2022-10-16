using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueOrder()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyReponse()
	{
	}
}
