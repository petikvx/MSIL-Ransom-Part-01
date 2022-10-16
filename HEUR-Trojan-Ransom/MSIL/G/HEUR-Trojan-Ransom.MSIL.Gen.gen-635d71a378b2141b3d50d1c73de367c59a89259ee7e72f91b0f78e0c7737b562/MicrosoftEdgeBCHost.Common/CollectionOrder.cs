using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionOrder()
	{
		WriterPropertyProducer.ResolveStub();
		GetReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetReponse()
	{
	}
}
